Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Public NotInheritable Class initialize_chart
    Public count As Integer
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub initialize_chart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        count = 0
        tmrsplah.Start()

    End Sub

    Private Sub tmrsplah_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrsplah.Tick
        count = count + 1
        progress_updates.Value = count
        If count = 20 Then
            'Try

            InitializePie()
            'Me.Close()
            'Catch ex As Exception

            'lblchck.Text = "No internet connection..."
            'If count = 60 Then
            Me.Close()
            'End If
            'End Try
        End If
        If count > 99 Then
            tmrsplah.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
