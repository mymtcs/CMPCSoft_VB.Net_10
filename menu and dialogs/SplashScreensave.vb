Public NotInheritable Class SplashScreensave
    Public count As Integer = 0
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub tmrsplah_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrsplah.Tick
        count = count + 1
        If count >= 0 And count <= 5 Then
            lblprocess.Text = "Analysing data..."
        ElseIf count >= 6 And count <= 9 Then
            lblprocess.Text = "Manipulating data..."
        ElseIf count >= 10 Then
            lblprocess.Text = "Do not interupt this process..."
        End If
    End Sub

    Private Sub SplashScreensave_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tmrsplah.Start()
    End Sub
End Class
