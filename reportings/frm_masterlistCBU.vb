Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_masterlistCBU

  
    Private Sub gen_masterlist()
        'REPORT OBJECT
        Dim MyRpt As New masterlistCBU

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
            .Add("int4", Type.GetType("System.Double"))
            .Add("str4", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()

        sql = "select  x.* from(select a.CBUAccount,a.fullname,a.address,a.tdate, "
        sql += "acctbalance=isnull((select sum(debit-credit) from CBULedger where Active='Y' and  postingdate<='" + gendate.Value + "' and CBUAccount=a.CBUAccount "
        If Not txtloantype.SelectedValue = "000" Then
            sql += " and gl_loans='" + txtloantype.SelectedValue + "'"
        End If
        sql += "),0)"
        sql += " FROM Members a where a.status='A'"
        sql += ")x WHERE x.acctbalance>0 "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim date_open As Date = Format(rd("tdate"), "MM/dd/yyyy")
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = gendate.Value
            row(3) = productcode
            row(4) = rd("CBUAccount").ToString
            row(5) = rd("fullname").ToString
            row(6) = rd("address").ToString
            row(7) = rd("acctbalance").ToString
            If rd("acctbalance") > 3000 Then
                row(8) = "Regular"
            Else
                row(8) = "Associate"
            End If
            row(9) = date_open.ToShortDateString
            DS.Tables(0).Rows.Add(row)
        End While

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype WHERE gl_loans in(select gl_loans from UserAssigned where userID='" + user.ToString + "') order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("000", "All")
        While (rd.Read())
            table1.Rows.Add(rd("gl_loans").ToString, rd("loandesc").ToString)
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

    Private Sub frm_masterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_loantype()
        gendate.Value = systemdate
    End Sub

    Private Sub bttn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_generate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        gen_masterlist()
        SplashScreen.Close()
    End Sub
End Class