Public NotInheritable Class loadingscreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Dim count As Integer = 3

    Private Sub loadingscreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub loadingscreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf MDIfrm.Show)
        thread.Start()
        'MDIfrm.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        count = count - 1
        If count <= 0 Then
            Me.Hide()
            'MDIfrm.Show()
        End If
    End Sub
End Class
