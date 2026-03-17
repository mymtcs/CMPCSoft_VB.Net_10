Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_loans_deduction
    Dim code As Integer = 1

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub select_acro()
        Dim table1 As DataTable = New DataTable()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        table1.Rows.Add("SV", "Savings type")
        table1.Rows.Add("CBU", "CBU type")
        table1.Rows.Add("CGF", "Credit Guarantee type")
        table1.Rows.Add("PF", "Processing fee type")
        table1.Rows.Add("INS", "Insurance type")
        table1.Rows.Add("BCI", "Ben Life type")
        table1.Rows.Add("SC", "Service charge type")
        table1.Rows.Add("LH", "Life and Health")
        table1.Rows.Add("OFS", "Offset Account")
        table1.Rows.Add("KF", "Karamay Fund type")
        myConn.Close()
        txtacro.DataSource = table1
        Me.txtacro.AutoFilter = True
        txtacro.DisplayMember = "Acct. Description"
        txtacro.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtacro.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtacro.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtacro.EditorControl.Columns(0).Width = 100
        Me.txtacro.EditorControl.Columns(1).Width = 250
        Me.txtacro.EditorControl.Columns(1).Width = 200
        Me.txtacro.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub select_GL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("accttype").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtgl.DataSource = table1
        Me.txtgl.AutoFilter = True
        txtgl.DisplayMember = "Acct. Description"
        txtgl.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtgl.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtgl.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtgl.EditorControl.Columns(0).Width = 100
        Me.txtgl.EditorControl.Columns(1).Width = 250
        Me.txtgl.EditorControl.Columns(1).Width = 200
        Me.txtgl.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub frm_weavedlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_GL()
        select_acro()
        view_deductionsMF()
    End Sub

    Private Sub view_deductionsMF()
        dtgrid_deductions.Rows.Clear()
        conn()
        sql = "SELECT * FROM deductionMF"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtgrid_deductions.Rows.Add(rd("code").ToString, rd("description").ToString, rd("fixedamnt").ToString, rd("percentage").ToString, rd("display").ToString, rd("acro").ToString, rd("base_on_month").ToString, rd("GLaccount").ToString)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If dtgrid_deductions.CurrentRow.Cells(0).Value <> "" And dtgrid_deductions.CurrentRow.Cells(1).Value <> "" And dtgrid_deductions.CurrentRow.Cells(3).Value <> "" And dtgrid_deductions.CurrentRow.Cells(4).Value <> "" Then
            conn()
            sql = "SELECT * FROM DeductionMF WHERE code='" + txtcode.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE DeductionMF SET description='" + txtdesc.Text + "',fixedamnt=" + txtfxamount.Text + ",percentage=" + txtpercentage.Text + ",display='" + txtvisible.Text + "',acro='" + txtacro.SelectedValue + "',base_on_month='" + txtmbase.Text + "',GLaccount='" + txtgl.SelectedValue + "', userID='" + user + "' WHERE code='" + txtcode.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Deduction code " & txtcode.Text & " was successfully updated.", MsgBoxStyle.Information)
            Else
                conn()
                sql = "INSERT INTO DeductionMF (code,description,fixedamnt,percentage,display,acro,base_on_month,GLaccount,userID) VALUES ('" + txtcode.Text + "','" + txtdesc.Text + "'," + txtfxamount.Text + "," + txtpercentage.Text + ",'" + txtvisible.Text + "','" + txtacro.SelectedValue + "','" + txtmbase.Text + "','" + txtgl.SelectedValue + "','" + user + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("New Deduction was successfully added.", MsgBoxStyle.Information)
                view_deductionsMF()
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub dtgrid_deductions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_deductions.Click
        txtcode.Text = dtgrid_deductions.CurrentRow.Cells(0).Value
        txtdesc.Text = dtgrid_deductions.CurrentRow.Cells(1).Value
        txtfxamount.Text = dtgrid_deductions.CurrentRow.Cells(2).Value
        txtpercentage.Text = dtgrid_deductions.CurrentRow.Cells(3).Value
        txtvisible.Text = dtgrid_deductions.CurrentRow.Cells(4).Value
        txtacro.SelectedValue = dtgrid_deductions.CurrentRow.Cells(5).Value
        txtmbase.Text = dtgrid_deductions.CurrentRow.Cells(6).Value
        txtgl.SelectedValue = dtgrid_deductions.CurrentRow.Cells(7).Value
    End Sub
End Class