Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_sys_users


    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        Me.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        conn()
        sql = "SELECT * FROM users where userid='" + user.ToString + "' and pwd='" + txtpass.Text.Trim + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            If txtnewpass.Text.Length < 3 Then
                MsgBox("New password must be greater than 2 characters.", MsgBoxStyle.Exclamation)
                txtnewpass.Focus()
            ElseIf txtnewpass.Text.Trim <> txtrepass.Text Then
                MsgBox("New password not match.", MsgBoxStyle.Exclamation)
                txtrepass.Clear()
                txtrepass.Focus()
            Else
                conn()
                sql = "UPDATE Users SET pwd='" + txtrepass.Text + "' WHERE userid='" + user.ToString + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Changed password using (" & user & ") ID','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                MsgBox("You have successfully changed your password. Please re-login your new password to continue.", MsgBoxStyle.Information, "Success")
            End If
        Else
            End
        End If
        rd.Close()
        myConn.Close()
    End Sub
End Class