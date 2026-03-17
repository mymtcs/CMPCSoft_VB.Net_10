Public Class frmcheckby

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtcheckby.Text.Trim = "" Then
            MsgBox("Check by field could not be empty!", MsgBoxStyle.Exclamation)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtcheckby_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcheckby.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcheckby.Text.Trim = "" Then
                MsgBox("Check by field could not be empty!", MsgBoxStyle.Exclamation)
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class