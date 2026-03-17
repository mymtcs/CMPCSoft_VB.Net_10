Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_performance_officer

    Private Sub generate_ctr_incntv()
        'REPORT OBJECT
        Dim MyRpt As New loanprofileby_gender

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("date3", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "SELECT y.ctrcode,y.Ctrchief,y.Countmem,y.Loanrel,SUM(y.PrnPar) As ttlPrnpar,SUM(y.IntPar) As ttlIntpar,SUM(y.ttllnbal) As ttllnbal from ("
        sql += "select x.ctrcode,x.Ctrchief,x.Countmem,x.Loanrel,(x.Totallnamount-x.TotalPrnPaid) As ttllnbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,(select TOP 1 duedate from loansched where pnnumber=x.PnNumber AND rngprin>x.TotalPrnPaid) As duedate,case when ((x.TotalPrnPaid-x.totalprndue) < 0) then datediff(day,x.Duedate,'" + dtto.Value + "') else (case when ((x.TotalIntPaid-x.totalintdue)<0) then datediff(day,x.Duedate,'" + dtto.Value + "') else 0 end)  end as PARDays from ("
        sql += "select a.ctrcode,a.pnnumber,a.loandate,a.maturitydate,"
        sql += "Loanamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "PARday=datediff(day,(select TOP 1 duedate from loansched where pnnumber=a.PnNumber AND rngprin>(SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE pnnumber=a.pnnumber and trnxdate<='" + dtto.Value + "') order by duedate ASC),'" + dtto.Value + "'),"
        sql += "Countmem=(select count(ctrcode) from Loans where ctrcode=a.ctrcode and status='A'),"
        sql += "Loanrel=isnull((select sum(loanamnt) from loans where ctrcode=a.ctrcode and releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "'),0),"
        sql += "Ctrchief=(select ctrchief +'  ('+ ctrname +')' as ctr from Center where ctrcode=a.ctrcode),"
        sql += "Totallnamount=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and CONVERT(DATETIME,FLOOR(convert(float,duedate)))<='" + dtto.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and CONVERT(DATETIME,FLOOR(convert(float,duedate)))<='" + dtto.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate)))<='" + dtto.Value + "' AND pnnumber=a.pnnumber and cancel='N'),0),"
        sql += "TotalintPaid=isnull((select sum(intpaid+advinterest) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate)))<='" + dtto.Value + "' AND pnnumber=a.pnnumber and cancel='N'),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin<((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc)) "
        sql += "from Loans a where  a.released='Y'"
        sql += ")x group by x.ctrcode,x.Ctrchief,x.pnnumber,x.Totallnamount,x.TotalPrnPaid,x.Totalprndue,x.TotalPrnPaid,x.Duedate,x.Totalintdue,x.TotalintPaid,x.Countmem,x.Loanrel"
        sql += ") y GROUP BY y.ctrcode,y.Ctrchief,y.Countmem,y.Loanrel"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("ctrcode").ToString
            row(1) = rd("Ctrchief").ToString
            row(2) = rd("Countmem").ToString
            row(3) = rd("Loanrel").ToString
            If Double.Parse(rd("ttlPrnpar")) < 1 Then
                row(4) = 0
            Else
                row(4) = rd("ttlPrnpar").ToString
            End If
            If Double.Parse(rd("ttlPrnpar")) < 1 Then
                row(5) = 0
            Else
                row(5) = rd("ttlIntpar").ToString
            End If

            If Double.Parse(rd("ttlPrnpar")) < 1 Or Double.Parse(rd("ttlIntpar")) < 1 Then
                row(6) = 0
            Else
                row(6) = rd("ttllnbal").ToString
            End If
            row(7) = dtto.Value
            DS.Tables(0).Rows.Add(row)
        End While

        'row(8) = MDIfrm.lblparval.Text

        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub bttngen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngen.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        generate_ctr_incntv()
        SplashScreen.Close()
    End Sub

    Private Sub frm_performance_officer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtto.Value = systemdate
        dtfrom.Value = dtto.Value.AddDays(-30)
    End Sub

    Private Sub dtto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtto.ValueChanged
        dtfrom.Value = dtto.Value.AddDays(-30)
    End Sub
End Class