Imports System.Windows.Forms
Imports System.Object
Imports System.Text

Public Class frm_randompassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As New Random
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(14, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        txtencrypted.Text = Crypt(sb.ToString.Substring(2, 5))
        userpass = Crypt(txtencrypted.Text)
        ' MsgBox(userpass)
    End Sub
End Class
