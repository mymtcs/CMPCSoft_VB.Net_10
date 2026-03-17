Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_assigned_user

    Private Sub frm_assigned_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_user()
        conn()
        sql = "select DISTINCT loandesc,gl_loans from Loantype ORDER BY loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        dtgrid_controls.Rows.Clear()
        While rd.Read
            dtgrid_controls.Rows.Add(False, rd("loandesc"), rd("gl_loans"))
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_user()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM Users"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("User ID")
        table1.Columns.Add("Fullname")
        While (rd.Read())
            table1.Rows.Add(rd("userID").ToString, rd("fullname").ToString)
        End While
        txtuser.DataSource = table1
        Me.txtuser.AutoFilter = True
        txtuser.DisplayMember = "Fullname"
        txtuser.ValueMember = "User ID"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtuser.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtuser.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtuser.EditorControl.Columns(0).Width = 90
        Me.txtuser.EditorControl.Columns(1).Width = 200
        Me.txtuser.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub btnnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnsave.Click
        conn()
        sql = "DELETE FROM UserAssigned WHERE userID='" + txtuser.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
            If dtgrid_controls.Rows(i).Cells(0).Value = True Then
                conn()
                sql = "INSERT INTO UserAssigned(userID,gl_loans) VALUES ('" + txtuser.SelectedValue + "','" + dtgrid_controls.Rows(i).Cells(2).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
        MsgBox("User " & txtuser.Text & " was successfully assigned.", MsgBoxStyle.Information, "Complete")
    End Sub

    Private Sub dtgrid_controls_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_controls.CellClick
        If dtgrid_controls.CurrentRow.Cells(0).Value = False Then
            dtgrid_controls.CurrentRow.Cells(0).Value = True
        Else
            dtgrid_controls.CurrentRow.Cells(0).Value = False
        End If
    End Sub

    Private Sub bttnuncheckall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
            dtgrid_controls.Rows(i).Cells(0).Value = False
        Next
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        Me.Close()
    End Sub

    Private Sub txtuser_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Validated
        Try
            For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
                dtgrid_controls.Rows(i).Cells(0).Value = False
            Next
            conn()
            sql = "select * from UserAssigned WHERE userID='" + txtuser.SelectedValue + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
                    If dtgrid_controls.Rows(i).Cells(2).Value = rd("gl_loans") Then
                        dtgrid_controls.Rows(i).Cells(0).Value = True
                    End If
                Next
            End While
            rd.Close()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class