Imports System.Windows.Forms

Public Class check_savingsinterest_password

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtpass.Text.Trim = "coolway9658" Then
            Me.Close()
            frm_generate_savingsint.MdiParent = MDIfrm
            MDIfrm.pnmain.Controls.Add(frm_generate_savingsint)
            frm_generate_savingsint.Show()
            frm_generate_savingsint.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
