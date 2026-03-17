Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_balance_check
    Public comboCol_Items As New GridViewMultiComboBoxColumn("GL Account")

    Private Sub frm_balance_check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        creategview_items()
        ttlamountpost()
    End Sub

    Private Sub ttlamountpost()
        conn()
        ' ORIGINAL SCRIPT
        ' sql = "SELECT isnull((SUM(a.principal+a.advprincipal+a.intpaid+a.advinterest+a.savings+a.cf)),0) as amntpost FROM LoanCollect a, loans b WHERE a.trnxdate='" + systemdate + "' and  b.gl_loans='" + GL_loans + "' and a.pnnumber=b.pnnumber and a.remarks='CASH'"

        ' NEW SCRIPT
        sql = "SELECT isnull((SUM(a.principal+a.advprincipal+a.intpaid+a.advinterest+a.savings+a.cf+a.lh)),0) as amntpost FROM LoanCollect a, loans b WHERE a.trnxdate='" + systemdate + "' and  b.gl_loans='" + GL_loans + "' and a.pnnumber=b.pnnumber and a.remarks='CASH'"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            lbl_accounting.Text = rd("amntpost").ToString
        End If
        rd.Close()
        myConn.Close()

    End Sub

    Public Sub creategview_items()
        'InitializeComponent()
        dtgrid_balance_check.Columns.Clear()
        dtgrid_balance_check.Rows.Clear()

        Dim gl_account As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM ChartAccounts"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        gl_account.Columns.Add("Account Code")
        gl_account.Columns.Add("Account Descriptions")
        gl_account.Columns.Add("Account Type")
        While (rd.Read())
            gl_account.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("Accttype").ToString)
        End While
        rd.Close()
        myConn.Close()

        '0
        comboCol_Items.DataSource = gl_account
        comboCol_Items.FieldName = "GL Account"
        comboCol_Items.DisplayMember = "Account Descriptions"
        comboCol_Items.ValueMember = "Account Code"
        comboCol_Items.Width = 250
        comboCol_Items.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgrid_balance_check.Columns.Add(comboCol_Items)

        '1
        Dim code As New GridViewTextBoxColumn("Account Code")
        Me.dtgrid_balance_check.MasterTemplate.AutoGenerateColumns = False
        dtgrid_balance_check.Columns.Add(code)
        code.Width = 150
        code.ReadOnly = True

        '2
        Dim amount As New GridViewTextBoxColumn("Amount")
        Me.dtgrid_balance_check.MasterTemplate.AutoGenerateColumns = False
        dtgrid_balance_check.Columns.Add(amount)
        amount.ReadOnly = True
        amount.Width = 120
    End Sub

    Private Sub bttn_cont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cont.Click
        'If Double.Parse(lbl_balance.Text) = 0 Then
        frm_upload_savings.upload_savings()
        '    Me.Close()
        'Else
        '    MsgBox("Cannot upload savings when balance is not equal to zero.", MsgBoxStyle.Exclamation, "Message")
        'End If
    End Sub

    Private Sub dtgrid_balance_check_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrid_balance_check.CellEditorInitialized
        If dtgrid_balance_check.CurrentCell.ColumnIndex = 0 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.dtgrid_balance_check.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol_Items.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
            dtgrid_balance_check.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextCell
        End If
    End Sub

    Private Sub dtgrid_balance_check_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrid_balance_check.CellEndEdit
        dtgrid_balance_check.CurrentRow.Cells(1).Value = dtgrid_balance_check.CurrentRow.Cells(0).Value
        If dtgrid_balance_check.CurrentCell.ColumnIndex = 0 Then
            conn()
            sql = "SELECT isnull((SUM(debit)),0) as debit FROM CashiersTransaction WHERE GLaccount='" + dtgrid_balance_check.CurrentRow.Cells(0).Value + "' and trndate='" + systemdate + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                dtgrid_balance_check.CurrentRow.Cells(2).Value = rd("debit").ToString
            Else
                dtgrid_balance_check.CurrentRow.Cells(2).Value = 0
            End If
            rd.Close()
            myConn.Close()
        End If
        'lbl_balance.Text = 0
        'lbl_cashiers.Text = 0
        'For i As Integer = 0 To dtgrid_balance_check.Rows.Count - 1
        '    Try
        '        lbl_cashiers.Text = Double.Parse(dtgrid_balance_check.Rows(i).Cells(2).Value) + Double.Parse(lbl_cashiers.Text)
        '    Catch ex As Exception

        '    End Try
        'Next
        'Try
        '    lbl_balance.Text = Double.Parse(lbl_accounting.Text) - Double.Parse(lbl_cashiers.Text)
        'Catch ex As Exception
        '    lbl_balance.Text = 0
        'End Try
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        ttlamountpost()
        lbl_balance.Text = 0
        lbl_cashiers.Text = 0
        For i As Integer = 0 To dtgrid_balance_check.Rows.Count - 1
            Try
                lbl_cashiers.Text = Double.Parse(dtgrid_balance_check.Rows(i).Cells(2).Value) + Double.Parse(lbl_cashiers.Text)
            Catch ex As Exception

            End Try
        Next
        Try
            lbl_balance.Text = Double.Parse(lbl_accounting.Text) - Double.Parse(lbl_cashiers.Text)
        Catch ex As Exception
            lbl_balance.Text = 0
        End Try
    End Sub

End Class