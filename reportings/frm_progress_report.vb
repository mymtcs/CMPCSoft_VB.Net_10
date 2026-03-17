Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_progress_report
    Private cntr As String
    Private collcode As String
    Private ctrcode As String

    Private Sub frmpar_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub progress_report_officer()
        'REPORT OBJECT
        Dim MyRpt As New progressreport

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim connection As SqlConnection
        Dim adapter As SqlDataAdapter
        Dim command As New SqlCommand

        Dim i As Integer
        Dim ds As New DataSet
        Dim dsr As New DataSet

        'ADD A TABLE TO THE DATASET
        ds.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With ds.Tables(0).Columns
            .Add("str16", Type.GetType("System.String")) '1
            .Add("str13", Type.GetType("System.String")) '2
            .Add("str12", Type.GetType("System.String")) '3
            .Add("date1", Type.GetType("System.DateTime")) '4
            .Add("date3", Type.GetType("System.DateTime")) '5
            .Add("str1", Type.GetType("System.String")) '6
            .Add("str2", Type.GetType("System.String")) '7
            .Add("int1", Type.GetType("System.Double")) '8
            .Add("int2", Type.GetType("System.Double")) '9
            .Add("int3", Type.GetType("System.Double")) '10
            .Add("int4", Type.GetType("System.Double")) '11
            .Add("int7", Type.GetType("System.Double")) '12
            .Add("int8", Type.GetType("System.Double")) '13
            .Add("int9", Type.GetType("System.Double")) '14
            .Add("int5", Type.GetType("System.Double")) '15
            .Add("int10", Type.GetType("System.Double")) '16
            .Add("int11", Type.GetType("System.Double")) '17
            .Add("int12", Type.GetType("System.Double")) '18
            .Add("int13", Type.GetType("System.Double")) '19
            .Add("int14", Type.GetType("System.Double")) '20
            .Add("str15", Type.GetType("System.String")) '21
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        'conn()
        'sql = "select z.* from(select w.collcode,w.fullname,"
        'sql += "ttlborrowers=isnull((select count(y.pnnumber) from ("
        'sql += "select x.*,(x.prnamount-x.TotalPrnPaid) as loanbal from ("
        'sql += "select a.pnnumber,a.collcode,"
        'sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber),0)"
        'sql += " from Loans a where a.status<>'X' and a.gl_loans=w.gl_loans and a.released='Y'"
        'sql += ") x where x.DateClosed>'" + dtto.Value + "'"
        'sql += ") y where y.loanbal>0 and y.collcode=w.collcode),0),"

        'sql += "loanbalance=isnull((select sum(y.loanbal) from ("
        'sql += "select x.*,(x.prnamount-x.TotalPrnPaid) as loanbal from ("
        'sql += "select a.pnnumber,a.collcode,"
        'sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber),0)"
        'sql += " from Loans a where a.status<>'X' and a.releasedate<='" + dtto.Value + "' and a.gl_loans=w.gl_loans and a.released='Y'"
        'sql += ") x where x.DateClosed>'" + dtto.Value + "'"
        'sql += ") y where y.loanbal>0 and y.collcode=w.collcode),0),"

        'sql += "ttlrel=isnull((select count(a.pnnumber) from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.collcode=w.collcode),0),"

        'sql += "ttlrelamount=isnull((select sum(x.prnamount) from(select "
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0)"
        'sql += " from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.collcode=w.collcode"
        'sql += ")x),0),"

        'sql += "ttlrel_new=isnull((select count(a.pnnumber) from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle =1 and a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.collcode=w.collcode),0),"

        'sql += "ttlrelamount_new=isnull((select sum(x.prnamount) from(select "
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0)"
        'sql += " from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle =1 and a.status<>'X'  and a.released='Y' and a.gl_loans=w.gl_loans  and  a.collcode=w.collcode"
        'sql += ")x),0),"

        'sql += "ttlrel_old=isnull((select count(a.pnnumber) from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle >1 and a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans  and  a.collcode=w.collcode),0),"

        'sql += "ttlrelamount_old=isnull((select sum(x.prnamount) from(select "
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0)"
        'sql += " from loans a where a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.cycle >1 and a.status<>'X'  and a.released='Y' and a.gl_loans=w.gl_loans  and  a.collcode=w.collcode"
        'sql += ")x),0),"

        'sql += "PARmembers=isnull((select count(y.pnnumber) from ("
        'sql += "select x.* ,case when ((x.totalprndue-x.TotalPrnPaid) >1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else (case when ((x.totalintdue-x.TotalIntPaid)>1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else 0 end)  end as PARDays from ("
        'sql += "select a.pnnumber,a.collcode,"
        'sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        'sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        'sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber),0),"
        'sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<'" + dtto.Value + "' AND pnnumber=a.pnnumber),0),"
        'sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        'sql += " from Loans a where a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans "
        'sql += ") x where x.DateClosed>'" + dtto.Value + "'"
        'sql += ") y where y.PARdays>0 and y.collcode=w.collcode),0),"

        'sql += "PARamount=isnull((select sum(y.loanbal) from ("
        'sql += "select x.*,(x.prnamount-x.TotalPrnPaid) loanbal ,case when ((x.totalprndue-x.TotalPrnPaid) >1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else (case when ((x.totalintdue-x.TotalIntPaid)>1) then datediff(day,x.Duedate,'" + dtto.Value.AddDays(1) + "') else 0 end)  end as PARDays from ("
        'sql += "select a.pnnumber,a.collcode,"
        'sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        'sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        'sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        'sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtto.Value + "'),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber),0),"
        'sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<'" + dtto.Value + "' AND pnnumber=a.pnnumber),0),"
        'sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtto.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        'sql += "from Loans a where a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans "
        'sql += ") x where x.DateClosed>'" + dtto.Value + "'"
        'sql += ") y where y.PARdays>0 and y.collcode=w.collcode),0),"

        'sql += "ttlreveneu=isnull((select sum(x.ttlintpaid) as ttlintpaid from(select "
        'sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where  trnxdate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and pnnumber=a.pnnumber),0)"
        'sql += "from loans a where a.gl_loans=w.gl_loans  and a.collcode=w.collcode)x),0)"

        'sql += "from officer w where w.status='A' and w.gl_loans='" + txtloantype.SelectedValue + "')z ORDER BY z.fullname"

        'cmd = New SqlCommand(sql, myConn)
        'cmd.CommandTimeout = 200
        'myConn.Open()
        'rd = cmd.ExecuteReader()

        'Dim connetionString As String

        'connetionString = "Data Source=bogo_server;Initial Catalog=#Coolw@yDB;User ID=sa;Password=server"
        connection = New SqlConnection(constr)

        connection.Open()
        command.Connection = connection
        command.CommandTimeout = 300
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_gen_Progress_Report"

        command.Parameters.AddWithValue("@gl_loans", txtloantype.SelectedValue)
        command.Parameters.AddWithValue("@view", cbo_option.Text)
        command.Parameters.AddWithValue("@datefrom", Date.Parse(dtfrom.Value))
        command.Parameters.AddWithValue("@dateto", Date.Parse(dtto.Value))
        command.Parameters.AddWithValue("@code", txtcenter.SelectedValue)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(dsr)

        For i = 0 To dsr.Tables(0).Rows.Count - 1
            row = ds.Tables(0).NewRow
            row(0) = txtloantype.Text '1
            row(1) = CompName '2
            row(2) = compaddress '3
            row(3) = dtfrom.Value '4
            row(4) = dtto.Value '5
            row(5) = dsr.Tables(0).Rows(i).Item(0) '6
            row(6) = dsr.Tables(0).Rows(i).Item(1) '7
            row(7) = dsr.Tables(0).Rows(i).Item(2)  '8
            row(8) = dsr.Tables(0).Rows(i).Item(3)  '9
            row(9) = dsr.Tables(0).Rows(i).Item(4) '10
            row(10) = dsr.Tables(0).Rows(i).Item(5)  '11
            row(11) = dsr.Tables(0).Rows(i).Item(6)  '12
            row(12) = dsr.Tables(0).Rows(i).Item(7)  '13
            row(13) = dsr.Tables(0).Rows(i).Item(8) '14
            row(14) = dsr.Tables(0).Rows(i).Item(9)  '15
            row(15) = dsr.Tables(0).Rows(i).Item(10)  '16

            If Double.Parse(dsr.Tables(0).Rows(i).Item(2)) <= 0 Then
                row(16) = 0
            Else
                row(16) = Double.Parse(dsr.Tables(0).Rows(i).Item(10)) / Double.Parse(dsr.Tables(0).Rows(i).Item(2)) * 100
            End If
            row(17) = dsr.Tables(0).Rows(i).Item(11)

            If Double.Parse(dsr.Tables(0).Rows(i).Item(3)) <= 0 Then
                row(18) = 0
            Else
                row(18) = (Double.Parse(dsr.Tables(0).Rows(i).Item(11)) / Double.Parse(dsr.Tables(0).Rows(i).Item(3))) * 100
            End If
            row(19) = dsr.Tables(0).Rows(i).Item(12)
            row(20) = cbo_option.Text & "'s PERFORMANCE REPORT"
            ds.Tables(0).Rows.Add(row)
        Next
        connection.Close()
        'While rd.Read
        '    row = DS.Tables(0).NewRow
        '    row(0) = txtloantype.Text '1
        '    row(1) = CompName '2
        '    row(2) = compaddress '3
        '    row(3) = dtfrom.Value '4
        '    row(4) = dtto.Value '5
        '    row(5) = rd("collcode") '6
        '    row(6) = rd("fullname").ToString '7
        '    row(7) = rd("ttlborrowers").ToString '8
        '    row(8) = rd("loanbalance").ToString '9
        '    row(9) = rd("ttlrel").ToString '10
        '    row(10) = rd("ttlrelamount").ToString '11
        '    row(11) = rd("ttlrel_new").ToString '12
        '    row(12) = rd("ttlrelamount_new").ToString '13
        '    row(13) = rd("ttlrel_old").ToString '14
        '    row(14) = rd("ttlrelamount_old").ToString '15
        '    row(15) = rd("PARmembers").ToString '16

        '    If rd("ttlborrowers") <= 0 Then
        '        row(16) = 0
        '    Else
        '        row(16) = (rd("PARmembers") / rd("ttlborrowers")) * 100
        '    End If
        '    row(17) = rd("PARamount").ToString

        '    If rd("loanbalance") <= 0 Then
        '        row(18) = 0
        '    Else
        '        row(18) = (rd("PARamount") / rd("loanbalance")) * 100
        '    End If
        '    row(19) = rd("ttlreveneu").ToString
        '    row(20) = "By (" & cbo_option.Text & ")"
        '    DS.Tables(0).Rows.Add(row)
        'End While

        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        select_grptype()
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue

        'If cbo_option.Text = "Product Officer" Then
        progress_report_officer()
        'Else
        '    progress_report_center()
        'End If

        SplashScreen.Close()
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        gen_center()
    End Sub
End Class