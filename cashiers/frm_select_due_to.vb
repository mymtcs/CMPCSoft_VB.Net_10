Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_select_due_to

    Private Sub frm_select_due_to_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM ChartAccounts ORDER BY acct_description ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("000", "All")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()
        cbo_chart.DataSource = table1
        Me.cbo_chart.AutoFilter = True
        cbo_chart.DisplayMember = "Description"
        cbo_chart.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.cbo_chart.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.cbo_chart.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.cbo_chart.EditorControl.Columns(0).Width = 100
        Me.cbo_chart.EditorControl.Columns(1).Width = 300
        Me.cbo_chart.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub bttnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnok.Click
        frm_print_voucher.Show()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub
End Class