Imports System.Windows.Forms

Public Class check_usercontrol_password

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtpass.Text.Trim = adminpass Then
            Me.Close()
            frm_usercontrols.ShowDialog()
            txtpass.Clear()
        Else
            MessageBox.Show("Invalid password")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
