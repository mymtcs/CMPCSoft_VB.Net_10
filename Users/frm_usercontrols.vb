Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_usercontrols

    Private Sub frm_usercontrols_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_user()
        conn()
        sql = "select * from UserNavigation ORDER BY controls"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        dtgrid_controls.Rows.Clear()
        While rd.Read
            dtgrid_controls.Rows.Add(False, rd("controls"), rd("navigationID"))
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

    Private Sub bttncheckall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnsave.Click
        conn()
        sql = "DELETE FROM UserControls WHERE userID='" + txtuser.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        conn()
        sql = "DELETE FROM UserTypeControls WHERE Type='" + cbotype.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
            If dtgrid_controls.Rows(i).Cells(0).Value = True Then
                conn()
                sql = "INSERT INTO UserControls(userID,navigationID) VALUES ('" + txtuser.SelectedValue + "'," + dtgrid_controls.Rows(i).Cells(2).Value.ToString + ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                conn()
                sql = "INSERT INTO UserTypeControls(Type,navigationID) VALUES ('" + cbotype.Text + "'," + dtgrid_controls.Rows(i).Cells(2).Value.ToString + ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
        MsgBox("User control modified successfully.", MsgBoxStyle.Information, "Complete")
    End Sub

    Private Sub dtgrid_controls_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_controls.CellClick
        If dtgrid_controls.CurrentRow.Cells(0).Value = False Then
            dtgrid_controls.CurrentRow.Cells(0).Value = True
        Else
            dtgrid_controls.CurrentRow.Cells(0).Value = False
        End If
    End Sub

    Private Sub bttnuncheckall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnuncheckall.Click
        For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
            dtgrid_controls.Rows(i).Cells(0).Value = False
        Next
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        Me.Close()
    End Sub

    Private Sub txtuser_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Validated
        'For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
        '    dtgrid_controls.Rows(i).Cells(0).Value = False
        'Next
        'conn()
        'sql = "select * from UserControls WHERE userid='" + txtuser.SelectedValue + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
        '        If dtgrid_controls.Rows(i).Cells(2).Value = rd("navigationID") Then
        '            dtgrid_controls.Rows(i).Cells(0).Value = True
        '        End If
        '    Next
        'End While
        'rd.Close()
        'myConn.Close()
    End Sub

    Private Sub cbotype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotype.Validated
        For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
            dtgrid_controls.Rows(i).Cells(0).Value = False
        Next
        conn()
        sql = "select * from UserTypeControls WHERE type='" + cbotype.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            For i As Integer = 0 To dtgrid_controls.Rows.Count - 1
                If dtgrid_controls.Rows(i).Cells(2).Value = rd("navigationID") Then
                    dtgrid_controls.Rows(i).Cells(0).Value = True
                End If
            Next
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub lnkassigned_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkassigned.LinkClicked
        frm_assigned_user.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_userexpire.ShowDialog()
    End Sub
End Class