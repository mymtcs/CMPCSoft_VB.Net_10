Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_userexpire

    Private Sub frm_userexpire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtexpire.Value = systemdate
        display_user()
    End Sub

    Private Sub display_user()
        conn()
        lstdropdown.Items.Clear()
        sql = "SELECT fullname,userid,pwd,Type,wrkstnID,pwddateexpiration from users order by fullname"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstdropdown.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstdropdown.Items.Count - 1
            If i Mod 2 Then
                lstdropdown.Items(i).BackColor = Color.AliceBlue
            Else
                lstdropdown.Items(i).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub lstdropdown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstdropdown.Click
        dtexpire.Value = lstdropdown.FocusedItem.SubItems(5).Text
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        conn()
        sql = "UPDATE users SET pwddateexpiration='" + dtexpire.Value + "' where userid='" + lstdropdown.FocusedItem.SubItems(1).Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        MsgBox("You have successfully updated user account.", MsgBoxStyle.Information, "Success")

        display_user()
    End Sub

End Class