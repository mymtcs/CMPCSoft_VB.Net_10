Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_masterlistSA

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer  ORDER BY fullname ASC" 'WHERE  productcode='" + productcode.ToString + "'
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        table1.Rows.Add("000", "All")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll.DataSource = table1
        Me.txtcoll.AutoFilter = True
        txtcoll.DisplayMember = "Fullname"
        txtcoll.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll.EditorControl.Columns(0).Width = 100
        Me.txtcoll.EditorControl.Columns(1).Width = 200
        Me.txtcoll.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub display_satype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM ChartAccounts WHERE Accttype='savings'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsavings_type.DataSource = table1
        Me.txtsavings_type.AutoFilter = True
        txtsavings_type.DisplayMember = "Description"
        txtsavings_type.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsavings_type.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsavings_type.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsavings_type.EditorControl.Columns(0).Width = 100
        Me.txtsavings_type.EditorControl.Columns(1).Width = 200
        Me.txtsavings_type.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub gen_masterlist()
        'REPORT OBJECT
        Dim MyRpt As New masterlistSA

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("int4", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        Dim status As String = "Active"
        conn()
        If rdps.IsChecked = True Then
            sql = "select  x.* from(select a.Accountnumber,CONVERT(VARCHAR(10),a.dateopen,101) As dateopen,a.accountstatus,a.AccountType, "
            sql += "accountname=isnull((select fullname from members where memcode=a.memcode),(select (ctrname+' '+ctrcode) from center where accountnumber=a.accountnumber)),"
            sql += "DateClosed=isnull((select DateClosed from AccountMaster where Accountnumber=a.Accountnumber),'" + systemdate.AddYears(999) + "'),"
            sql += "Address=isnull((select address from members where memcode=a.memcode),(select ctraddress from center where accountnumber=a.accountnumber)),"
            sql += "acctbalance=isnull((select sum(debit-credit) from accountledger where postingdate<='" + gendate.Value + "'  and active='Y' and gl_sa='" + txtsavings_type.SelectedValue + "' and accountnumber=a.Accountnumber),0)"
            sql += " FROM AccountMaster a WHERE a.accounttype='PS'  "
            sql += ")x WHERE x.accountstatus = '" + status + "' and x.acctbalance>0  GROUP BY x.DateClosed,x.acctbalance,x.Accountnumber,x.accountname,x.Address,x.dateopen,x.accountstatus,x.AccountType ORDER BY x.AccountType,x.accountname ASC"
        Else
            sql = "select  x.* from(select a.Accountnumber,CONVERT(VARCHAR(10),a.dateopen,101) As dateopen,a.accountstatus,a.AccountType, "
            sql += "accountname=isnull((select fullname from members where memcode=a.memcode),(select (ctrname+' '+ctrcode) from center where accountnumber=a.accountnumber)),"
            sql += "DateClosed=isnull((select DateClosed from AccountMaster where Accountnumber=a.Accountnumber),'" + systemdate.AddYears(999) + "'),"
            sql += "Address=isnull((select address from members where memcode=a.memcode),(select ctraddress from center where accountnumber=a.accountnumber)),"
            sql += "acctbalance=isnull((select sum(debit-credit) from accountledger where postingdate<='" + gendate.Value + "' and active='Y' and accountnumber=a.Accountnumber),0)"
            sql += " FROM AccountMaster a WHERE a.accounttype='CF' "
            sql += ")x WHERE x.accountstatus ='" + status + "' and x.acctbalance>0  GROUP BY x.DateClosed,x.acctbalance,x.Accountnumber,x.accountname,x.Address,x.dateopen,x.accountstatus,x.AccountType ORDER BY x.AccountType,x.accountname ASC"
        End If

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = gendate.Value
            row(3) = productcode
            row(4) = rd("Accountnumber").ToString
            row(5) = rd("accountname").ToString
            row(6) = rd("address").ToString
            row(7) = rd("dateopen").ToString
            row(8) = rd("acctbalance").ToString
            DS.Tables(0).Rows.Add(row)
        End While

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub frm_masterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gendate.Value = systemdate
        view_officer()
        display_satype()
    End Sub

    Private Sub bttn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_generate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        gen_masterlist()
        SplashScreen.Close()
    End Sub

    Private Sub txtsavings_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsavings_type.SelectedIndexChanged

    End Sub
End Class