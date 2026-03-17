Public Class frm_suspicious

    Private Sub frm_suspicious_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frm_suspicious_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim timeleft As Integer = Double.Parse(loginfrm.timeleft) / 60
        If loginfrm.timeleft <= 1 Then
            lblmessage1.Text = "You have failed to login 3 times."
            lblmessage2.Text = "You can login after " & loginfrm.timeleft.ToString & " minute."
        ElseIf loginfrm.timeleft > 5 Then
            lblmessage1.Text = "Changing machine date has been detected."
            lblmessage2.Text = "You can login after " & timeleft.ToString("00") & " hr(s)."
        Else
            lblmessage1.Text = "You have failed to login 3 times."
            lblmessage2.Text = "You can login after " & loginfrm.timeleft.ToString & " minutes."
        End If
    End Sub
End Class