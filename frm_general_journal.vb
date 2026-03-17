Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports Telerik.WinControls.Data

Public Class frm_general_journal_report
    Public comboCol1 As New GridViewMultiComboBoxColumn("Account Titles")
    Public comboCol2 As New GridViewMultiComboBoxColumn("Remarks")
    Public officer As DataTable = New DataTable()
    Public ctr As DataTable = New DataTable()

    Dim postID As Integer = 0
    Dim ref_no As String
    Dim ctrlnum As Integer = 0
    Dim ctrcode As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For i As Integer = 0 To Radgview.Rows.Count - 1
        '    MsgBox(Radgview.Rows(i).Cells(4).Value.ToString)
        'Next

    End Sub

    Private Sub frm_general_journal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Radgview.Rows.Clear()
        If Me.Text = "Edit General Journal" Then
            conn()
            sql = "SELECT * FROM GENERALLEDGER WHERE REFERENCE='" + txtref.Text + "' and DATEMOD='" + dttrn.Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                Radgview.Rows.Add(rd("ACCOUNTCODE").ToString, rd("ACCOUNTCODE").ToString, rd("REMARKS").ToString, rd("DEBIT").ToString, rd("CREDIT").ToString)
            End While
            rd.Close()
            myConn.Close()

            lbloutbal.Text = 0
            lbldebit.Text = 0
            lblcredit.Text = 0
            For i As Integer = 0 To Radgview.Rows.Count - 1
                If Radgview.Rows(i).Cells(0).Value <> "" Then
                    lbldebit.Text = Decimal.Parse(lbldebit.Text) + Radgview.Rows(i).Cells(3).Value
                    lblcredit.Text = Decimal.Parse(lblcredit.Text) + Radgview.Rows(i).Cells(4).Value
                End If
            Next
            lbloutbal.Text = Decimal.Parse(lbldebit.Text) - Decimal.Parse(lblcredit.Text)
        Else
            dttrn.Value = systemdate
        End If
    End Sub

    Private Sub bttnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_accountype.ShowDialog()
        txtref.Focus()
    End Sub

    Public Sub AllowOnlyNumeric(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "")
    End Sub

    Private Sub txtpayee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Radgview.Focus()
        End If
    End Sub

    Private Sub gen_ctr()

        'conn()
        'If Radgview.CurrentRow.Cells(1).Value = "1000" Then
        '    sql = "SELECT collID,Fullname FROM Officer ORDER BY Fullname ASC"
        'Else
        '    sql = "SELECT ctrID,ctrname,ctrchief FROM Center ORDER BY ctrname ASC"
        'End If
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'While (rd.Read())
        '    Dim lvitem As New ListViewItem(rd(0).ToString())
        '    For i As Integer = 1 To rd.FieldCount - 1
        '        lvitem.SubItems.Add(rd(i).ToString())
        '    Next
        '    lstctr.Items.Add(lvitem)
        'End While
        'rd.Close()
        'myConn.Close()
    End Sub

    Private Sub Radgview_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Radgview.CellEditorInitialized
        If Radgview.CurrentCell.ColumnIndex = 0 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.Radgview.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol1.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
        End If
    End Sub

    Private Sub Radgview_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Radgview.CellEndEdit
        Radgview.CurrentRow.Cells(1).Value = Radgview.CurrentRow.Cells(0).Value
        Try
            lbldebit.Text = 0
            lblcredit.Text = 0
            lbloutbal.Text = 0
            If IsNumeric(Radgview.CurrentRow.Cells(3).Value) = False Then
                Radgview.CurrentRow.Cells(3).Value = "0.00"
            End If
            If IsNumeric(Radgview.CurrentRow.Cells(4).Value) = False Then
                Radgview.CurrentRow.Cells(4).Value = "0.00"
            End If
            'Try
            For i As Integer = 0 To Radgview.Rows.Count - 1
                lbldebit.Text = Decimal.Parse(lbldebit.Text) + Radgview.Rows(i).Cells(3).Value
                lblcredit.Text = Decimal.Parse(lblcredit.Text) + Radgview.Rows(i).Cells(4).Value
            Next
            lbloutbal.Text = Decimal.Parse(lbldebit.Text) - Decimal.Parse(lblcredit.Text)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
        Dim acc_titles As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM ChartAccounts ORDER BY acct_description ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        acc_titles.Columns.Add("Account Code")
        acc_titles.Columns.Add("Account Titles")
        While (rd.Read())
            acc_titles.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()

        Dim table1 As New DataTable()
        table1.Columns.Add("Account Titles", GetType(String))
        table1.Columns.Add("Code", GetType(String))
        table1.Columns.Add("Remarks", GetType(String))
        table1.Columns.Add("Center", GetType(String))
        table1.Columns.Add("Amount", GetType(Integer))
        table1.Columns.Add("Control #", GetType(String))

        '0
        comboCol1.DataSource = acc_titles
        comboCol1.FieldName = "acctttls"
        comboCol1.HeaderText = "Account Titles"
        comboCol1.DisplayMember = "Account Titles"
        comboCol1.ValueMember = "Account Code"
        Radgview.Columns.Add(comboCol1)
        comboCol1.Width = 300
        comboCol1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        '1
        Dim acctcode As New GridViewTextBoxColumn("Code")
        Me.Radgview.MasterTemplate.AutoGenerateColumns = False
        Radgview.Columns.Add(acctcode)
        acctcode.IsVisible = False
        acctcode.Width = 100

        '3
        Dim Debit As New GridViewTextBoxColumn("Debit")
        Me.Radgview.MasterTemplate.AutoGenerateColumns = False
        Radgview.Columns.Add(Debit)
        Debit.Width = 120
        '4
        Dim Credit As New GridViewTextBoxColumn("Credit")
        Me.Radgview.MasterTemplate.AutoGenerateColumns = False
        Radgview.Columns.Add(Credit)
        Credit.Width = 120
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtref.Text.Trim = "" Then
            MsgBox("Reference number is required", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf Decimal.Parse(lbloutbal.Text) <> 0 Then
            MsgBox("Out of balance must be a zero.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If Me.Text = "Edit General Journal" Then
                If MessageBox.Show("Are you sure you want to update this journal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    conn()
                    sql = "DELETE FROM GENERALLEDGER WHERE REFERENCE='" + txtref.Text + "' and DATEMOD='" + dttrn.Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    For i As Integer = 0 To Radgview.Rows.Count - 1
                        If Radgview.Rows(i).Cells(1).Value <> "" Then
                            conn()
                            sql = "INSERT INTO GENERALLEDGER (ACCOUNTCODE,REFERENCE,REMARKS,DEBIT,CREDIT,DATEMOD,USERID,JOURNAL) VALUES ('" + Radgview.Rows(i).Cells(0).Value.ToString + "','" + txtref.Text + "','" + Radgview.Rows(i).Cells(2).Value.ToString + "'," + Radgview.Rows(i).Cells(3).Value.ToString + "," + Radgview.Rows(i).Cells(4).Value.ToString + ",'" + dttrn.Value + "','" + user.ToString + "','yes')"
                            cmd = New SqlCommand(sql, myConn)
                            myConn.Open()
                            cmd.ExecuteNonQuery()
                            myConn.Close()
                        End If
                    Next
                    txtref.Focus()
                End If
            ElseIf Me.Text = "New General Journal" Then
                If MessageBox.Show("Are you sure you want to save this journal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    For i As Integer = 0 To Radgview.Rows.Count - 1
                        If Radgview.Rows(i).Cells(1).Value <> "" Then
                            conn()
                            sql = "INSERT INTO GENERALLEDGER (ACCOUNTCODE,REFERENCE,REMARKS,DEBIT,CREDIT,DATEMOD,USERID,JOURNAL) VALUES ('" + Radgview.Rows(i).Cells(0).Value + "','" + txtref.Text + "','" + txtdesc.Text + "'," + Radgview.Rows(i).Cells(2).Value.ToString + "," + Radgview.Rows(i).Cells(3).Value.ToString + ",'" + dttrn.Value + "','" + user.ToString + "','yes')"
                            'MsgBox(sql.ToString)
                            cmd = New SqlCommand(sql, myConn)
                            myConn.Open()
                            cmd.ExecuteNonQuery()
                            myConn.Close()
                        End If
                    Next
                    txtref.Focus()
                    Radgview.Rows.Clear()
                    txtref.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        txtref.Clear()
        Radgview.Rows.Clear()
        bttnsave.Enabled = True
        txtref.Focus()
        Me.Text = "New General Journal"
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose.Click
        txtref.Clear()
        frm_cashiering.gen_distribution_of_receipts()
        Me.Close()
    End Sub

    'Private Sub Radgview_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Radgview.KeyPress
    '    Try
    '        If e.KeyChar <> ControlChars.Back Then
    '            If Radgview.CurrentCell.ColumnIndex = 4 Then
    '                AllowOnlyNumeric(e)
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub Radgview_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Radgview.Validated
        lbldebit.Text = 0
        lblcredit.Text = 0
        lbloutbal.Text = 0
        If IsNumeric(Radgview.CurrentRow.Cells(2).Value) = False Then
            Radgview.CurrentRow.Cells(2).Value = "0.00"
        End If
        If IsNumeric(Radgview.CurrentRow.Cells(3).Value) = False Then
            Radgview.CurrentRow.Cells(3).Value = "0.00"
        End If
        'Try
        For i As Integer = 0 To Radgview.Rows.Count - 1
            lbldebit.Text = Decimal.Parse(lbldebit.Text) + Radgview.Rows(i).Cells(2).Value
            lblcredit.Text = Decimal.Parse(lblcredit.Text) + Radgview.Rows(i).Cells(3).Value
        Next
        lbloutbal.Text = Decimal.Parse(lbldebit.Text) - Decimal.Parse(lblcredit.Text)
    End Sub

    Private Sub bttnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnprint.Click
        frm_print_voucher.ref = txtref.Text
        frm_print_voucher.evtype = "cashreceipts_vouch"
        frm_print_voucher.ShowDialog()
    End Sub
End Class