Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_weavedlg

    Private Sub bttncont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont.Click
        If txtreasons.Text.Trim = "" Then
            MsgBox("Reason cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtreasons.Focus()
        ElseIf txtreasons.Text.Trim.Length < 6 Then
            MsgBox("Reason must be greater than 6 characters.", MsgBoxStyle.Exclamation, "Invalid")
            txtreasons.Focus()
        Else
            conn()
            sql = "INSERT INTO logs(pnnumber,reasons,date,userID) VALUES ('" + txtlno.Text + "','" + txtreasons.Text + "','" + systemdate + "','" + user.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub txtlno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtreasons.Focus()
        End If
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        conn()
        sql = "DELETE FROM logs WHERE pnnumber='" + txtlno.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        Me.Close()
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose.Click
        Me.Close()
    End Sub

    Private Sub frm_weavedlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value
    End Sub
End Class