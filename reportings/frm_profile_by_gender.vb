Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_profile_by_gender

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
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("str13", Type.GetType("System.String"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int6", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select distinct z.* from(select distinct w.gender,"
        'sql += "noofborrowers=isnull((select count(pnnumber) from loans where gl_loans='" + GL_loans + "' and memcode in(select memcode from members where gender=w.gender) and status='A'),0),"
        sql += "noofborrowers=isnull((select count(y.pnnumber) from(select x.*,(x.prnamnt-x.ttlprnpaid) As LoanBal, (x.intamnt-x.ttlintpaid) As intBal from (SELECT a.pnnumber,a.loanamnt,"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<='" + dtfrom.Value + "' and pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where trnxdate<='" + dtfrom.Value + "' and pnnumber=a.pnnumber),0) "
        sql += " from Loans a,members b WHERE a.MemCode=b.MemCode and a.memcode in(select memcode from members where gender=w.gender) AND a.released='Y' and a.status<>'X' and a.releasedate<='" + dtfrom.Value + "' and a.gl_loans='" + GL_loans + "'"
        sql += ")x )y WHERE (y.LoanBal+y.intBal)>0),0),"
        sql += "ttlondue=isnull((select count(y.pnnumber) as ttlmembers from ("
        sql += "select x.*,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.totalintdue-x.TotalIntPaid) >1) then datediff(day,x.Duedate,'" + dtfrom.Value + "') else (case when ((x.totalprndue-x.TotalPrnPaid)>1) then datediff(day,x.Duedate,'" + dtfrom.Value + "') else 0 end)  end as PARDays from ("
        sql += "select a.pnnumber,"
        sql += "loanamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtfrom.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtfrom.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where  trnxdate<='" + dtfrom.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<='" + dtfrom.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtfrom.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where  a.status<>'X' and a.memcode in(select memcode from members where gender=w.gender) and a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + GL_loans + "') x"
        sql += ") y where y.PARdays>0),0),"

        sql += "loanbal=isnull((select sum(y.LoanBal) from(select x.*,(x.prnamnt-x.ttlprnpaid) As LoanBal, (x.intamnt-x.ttlintpaid) As intBal from (SELECT a.pnnumber,a.loanamnt,"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<='" + dtfrom.Value + "' and pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where trnxdate<='" + dtfrom.Value + "' and pnnumber=a.pnnumber),0) "
        sql += " from Loans a,members b WHERE a.MemCode=b.MemCode and a.memcode in(select memcode from members where gender=w.gender) AND a.released='Y' and a.status<>'X' and a.releasedate<='" + dtfrom.Value + "' and a.gl_loans='" + GL_loans + "'"
        sql += ")x )y WHERE (y.LoanBal+y.intBal)>0),0),"

        sql += "PARamount=isnull((select sum(y.prnbal) from ("
        sql += "select x.*,(x.prnamnt-x.TotalPrnPaid)as prnbal,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.totalintdue-x.TotalIntPaid) >1) then datediff(day,x.Duedate,'" + dtfrom.Value + "') else (case when ((x.totalprndue-x.TotalPrnPaid)>1) then datediff(day,x.Duedate,'" + dtfrom.Value + "') else 0 end)  end as PARDays from ("
        sql += "select a.pnnumber,a.loanamnt,"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtfrom.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtfrom.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where  trnxdate<='" + dtfrom.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<='" + dtfrom.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtfrom.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where  a.status<>'X' and a.memcode in(select memcode from members where gender=w.gender) and a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + GL_loans + "') x"
        sql += ") y where y.PARdays>0),0)"
        sql += "from members w)z"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("gender").ToString
            row(1) = rd("noofborrowers").ToString
            row(2) = rd("ttlondue").ToString
            row(3) = rd("loanbal").ToString
            row(4) = rd("PARamount").ToString
            row(5) = dtfrom.Value
            row(6) = CompName
            Try
                row(7) = (rd("ttlondue") / rd("noofborrowers")) * 100
                row(8) = (rd("PARamount") / rd("loanbal")) * 100
            Catch ex As Exception
                row(7) = 0
                row(8) = 0
            End Try
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
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

    Private Sub frm_ctr_inctv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.Value = systemdate
    End Sub
End Class