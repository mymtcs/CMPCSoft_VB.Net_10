Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_company_manager

    Private Sub frm_company_manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_GL_loans()
        select_GL_sa()
        select_GL_intrest()
        select_GL_cash()
    End Sub

    Private Sub select_GL_loans()
        'Try
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("GL_loans").ToString, rd("loandesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtglloans.DataSource = table1
        Me.txtglloans.AutoFilter = True
        txtglloans.DisplayMember = "Description"
        txtglloans.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtglloans.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtglloans.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtglloans.EditorControl.Columns(0).Width = 100
        Me.txtglloans.EditorControl.Columns(1).Width = 300
        Me.txtglloans.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Private Sub select_GL_sa()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM ChartAccounts WHERE Accttype='savings'"
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
        txtglsavings.DataSource = table1
        Me.txtglsavings.AutoFilter = True
        txtglsavings.DisplayMember = "Description"
        txtglsavings.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtglsavings.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtglsavings.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtglsavings.EditorControl.Columns(0).Width = 100
        Me.txtglsavings.EditorControl.Columns(1).Width = 300
        Me.txtglsavings.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Private Sub select_GL_intrest()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM ChartAccounts WHERE Accttype='Income'"
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
        txtglinterest.DataSource = table1
        Me.txtglinterest.AutoFilter = True
        txtglinterest.DisplayMember = "Description"
        txtglinterest.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtglinterest.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtglinterest.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtglinterest.EditorControl.Columns(0).Width = 100
        Me.txtglinterest.EditorControl.Columns(1).Width = 300
        Me.txtglinterest.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Private Sub select_GL_cash()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM ChartAccounts WHERE Accttype='Savings'"
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
        txtglcf.DataSource = table1
        Me.txtglcf.AutoFilter = True
        txtglcf.DisplayMember = "Description"
        txtglcf.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtglcf.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtglcf.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtglcf.EditorControl.Columns(0).Width = 100
        Me.txtglcf.EditorControl.Columns(1).Width = 300
        Me.txtglcf.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtareamanager.Text.Trim = "" Then
            MsgBox("Area manager cannot be emtpy.", MsgBoxStyle.Exclamation)
            txtareamanager.Focus()
        ElseIf txtpsupervisor.Text.Trim = "" Then
            MsgBox("Product supervisor cannot be emtpy.", MsgBoxStyle.Exclamation)
            txtbookkeeper.Focus()
        Else
            conn()
            sql = "SELECT TOP 1 * FROM sysparmtr where gl_loans='" + txtglloans.SelectedValue + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE sysparmtr SET Areamanager='" + txtareamanager.Text + "',Areasupervisor='" + txtpsupervisor.Text + "',Bookkeeper='" + txtbookkeeper.Text + "',Cashier='" + txtcashier.Text + "', GL_loans='" + txtglloans.SelectedValue + "',GL_income='" + txtglinterest.SelectedValue + "',GL_sa='" + txtglsavings.SelectedValue + "',GL_cf='" + txtglcf.SelectedValue + "' WHERE gl_loans='" + txtglloans.SelectedValue + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Update completed.", MsgBoxStyle.Information, "Success")
            Else
                conn()
                sql = "INSERT INTO sysparmtr (Areamanager,Areasupervisor,Bookkeeper,Cashier,GL_loans,GL_income,GL_sa,GL_cf) VALUES ('" + txtareamanager.Text + "','" + txtpsupervisor.Text + "','" + txtbookkeeper.Text + "','" + txtcashier.Text + "', '" + txtglloans.SelectedValue + "','" + txtglinterest.SelectedValue + "','" + txtglsavings.SelectedValue + "','" + txtglcf.SelectedValue + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Saving completed.", MsgBoxStyle.Information, "Success")
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtpsupervisor.Clear()
        txtareamanager.Clear()
        txtbookkeeper.Clear()
        txtcashier.Clear()
    End Sub

    Private Sub txtglloans_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtglloans.Validated
        conn()
        sql = "SELECT * FROM sysparmtr where gl_loans='" + txtglloans.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtareamanager.Text = rd("Areamanager")
            txtpsupervisor.Text = rd("Areasupervisor")
            txtbookkeeper.Text = rd("Bookkeeper")
            txtcashier.Text = rd("Cashier")
            txtglinterest.SelectedValue = rd("GL_income")
            txtglsavings.SelectedValue = rd("GL_sa")
            txtglcf.SelectedValue = rd("GL_cf")
        End If
        rd.Close()
        myConn.Close()
    End Sub
End Class