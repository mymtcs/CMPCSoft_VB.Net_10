Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_ctr_incentives
    Private cntr As String
    Private collcode As String
    Private ctrcode As String

    Private Sub frm_ctr_incentives_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtto.Value = systemdate
        dtfrom.Value = systemdate
        gen_loantype()
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT GL_loans,description FROM Products WHERE gl_loans in(select gl_loans from UserAssigned where userID='" + user.ToString + "') order by description"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("-select-", "-select-")
        While (rd.Read())
            table1.Rows.Add(rd("gl_loans").ToString, rd("description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtloantype.DataSource = table1
        Me.txtloantype.AutoFilter = True
        txtloantype.DisplayMember = "Description"
        txtloantype.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtloantype.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtloantype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtloantype.EditorControl.Columns(0).Width = 90
        Me.txtloantype.EditorControl.Columns(1).Width = 200
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub

    Private Sub gen_center()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT ctrcode,ctrname FROM center where gl_loans='" + txtloantype.SelectedValue + "' and status='A'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Center Name")
        table1.Rows.Add("-select-", "-select-")
        While (rd.Read())
            table1.Rows.Add(rd("ctrcode").ToString, rd("ctrname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcenter.DataSource = table1
        Me.txtcenter.AutoFilter = True
        txtcenter.DisplayMember = "Center Name"
        txtcenter.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcenter.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcenter.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcenter.EditorControl.Columns(0).Width = 90
        Me.txtcenter.EditorControl.Columns(1).Width = 200
        Me.txtcenter.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub

    Private Sub progress_report_center()
        'REPORT OBJECT
        Dim MyRpt As New ctr_incentives

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))

            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            '.Add("int4", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select z.* from(select w.ctrcode,w.ctrname,w.ctrchief,"

        sql += "ttlborrowers=isnull((select count(y.pnnumber) from ("
        sql += "select x.*,(x.prnamount-x.TotalPrnPaid) as loanbal from ("
        sql += "select a.pnnumber,"
        sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0)"
        sql += " from Loans a where a.status<>'X' and a.gl_loans=w.gl_loans and a.released='Y' and a.ctrcode=w.ctrcode"
        sql += ") x where x.DateClosed>'" + dtto.Value + "' "
        sql += ") y where y.loanbal>0 ),0),"

        'sql += "loanbalance=isnull((select sum(y.loanbal) from ("
        'sql += "select x.*,(x.prnamount-x.TotalPrnPaid) as loanbal from ("
        'sql += "select a.pnnumber,a.ctrcode,"
        'sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber),0)"
        'sql += " from Loans a where a.status<>'X' and a.releasedate<='" + dtto.Value + "' and a.gl_loans=w.gl_loans and a.released='Y'"
        'sql += ") x  where x.DateClosed>'" + dtto.Value + "' "
        'sql += ") y where y.loanbal>0 and y.ctrcode=w.ctrcode),0),"

        'sql += "ttlrel=isnull((select count(a.pnnumber) from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.ctrcode=w.ctrcode),0),"

        sql += "ttlrelamount=isnull((select sum(x.prnamount) from(select "
        sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0)"
        sql += " from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.ctrcode=w.ctrcode"
        sql += ")x),0),"

        'sql += "ttlrel_new=isnull((select count(a.pnnumber) from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle =1 and a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.ctrcode=w.ctrcode),0),"

        'sql += "ttlrelamount_new=isnull((select sum(x.prnamount) from(select "
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0)"
        'sql += " from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle =1 and a.status<>'X'  and a.released='Y' and a.gl_loans=w.gl_loans  and  a.ctrcode=w.ctrcode"
        'sql += ")x),0),"

        'sql += "ttlrel_old=isnull((select count(a.pnnumber) from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle >1 and a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.ctrcode=w.ctrcode),0),"

        'sql += "ttlrelamount_old=isnull((select sum(x.prnamount) from(select "
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0)"
        'sql += " from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle >1 and a.status<>'X'  and a.released='Y' and a.gl_loans=w.gl_loans  and  a.ctrcode=w.ctrcode"
        'sql += ")x),0),"

        'sql += "PARmembers=isnull((select count(y.pnnumber) from ("
        'sql += "select x.* ,case when ((x.totalprndue-x.TotalPrnPaid) >1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else (case when ((x.totalintdue-x.TotalIntPaid)>1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else 0 end)  end as PARDays from ("
        'sql += "select a.pnnumber,a.ctrcode,"
        'sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        'sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        'sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber),0),"
        'sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<'" + dtto.Value + "' AND pnnumber=a.pnnumber),0),"
        'sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        'sql += " from Loans a where a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans "
        'sql += ") x where x.DateClosed>'" + dtto.Value + "'"
        'sql += ") y where y.PARdays>0 and y.ctrcode=w.ctrcode),0)"

        sql += "PARamount=isnull((select sum(y.loanbal) from ("
        sql += "select x.*,(x.prnamount-x.TotalPrnPaid) loanbal ,case when ((x.totalprndue-x.TotalPrnPaid) >1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else (case when ((x.totalintdue-x.TotalIntPaid)>1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else 0 end)  end as PARDays from ("
        sql += "select a.pnnumber,a.ctrcode,"
        sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<'" + dtto.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += "from Loans a where a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans "
        sql += ") x where x.DateClosed>'" + dtto.Value + "'"
        sql += ") y where y.PARdays>0 and y.ctrcode=w.ctrcode),0)"

        'sql += "ttlreveneu=isnull((select sum(x.ttlintpaid) as ttlintpaid from(select "
        'sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where  trnxdate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and pnnumber=a.pnnumber),0)"
        'sql += "from loans a where a.gl_loans=w.gl_loans and a.ctrcode=w.ctrcode)x),0)"

        sql += "from center w where w.status='A' and w.gl_loans='" + txtloantype.SelectedValue + "')z WHERE z.ttlborrowers>0 ORDER BY z.ctrname, z.ttlborrowers DESC"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 600
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = productcode.ToString
            row(3) = dtfrom.Value
            row(4) = dtto.Value
            row(5) = rd("ctrcode").ToString
            row(6) = rd("ctrname").ToString
            row(7) = rd("ctrchief").ToString
            row(8) = rd("ttlborrowers").ToString
            row(9) = rd("ttlrelamount").ToString
            row(10) = rd("PARamount").ToString
            'row(11) = rd("ttlreveneu").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        'Next
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        MsgBox("Expect 6 to 10 minutes to generate this report.", MsgBoxStyle.Information, "MIS Message")
        select_grptype()
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue
        progress_report_center()
        SplashScreen.Close()
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        gen_center()
    End Sub
End Class