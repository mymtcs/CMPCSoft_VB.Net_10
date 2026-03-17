Public NotInheritable Class BackupDBSplashScreen
    Public count As Integer
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        picload.Enabled = True
        bttnok.Visible = False
        count = 0
        lblprocess.Text = "Generating Database.."
        tmrsplah.Start()
    End Sub

    Private Sub tmrsplah_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrsplah.Tick
        count = count + 1
        If count >= 1 And count <= 2 Then
            lblprocess.Text = "Please wait.."
        ElseIf count >= 3 And count <= 5 Then
            lblprocess.Text = "Please wait..."
        ElseIf count >= 6 And count <= 9 Then
            lblprocess.Text = "Please wait...."
        ElseIf count >= 10 Then
            lblprocess.Text = "Please wait....."
        End If
    End Sub

    Private Sub bttnok_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles bttnok.LinkClicked
        Me.Close()
        Process.Start("explorer.exe", strpath & "\Backup")
    End Sub
End Class
