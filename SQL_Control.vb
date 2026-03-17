Imports System.Data.SqlClient

Public Class SQL_Control
    Private DBCon As New SqlConnection("Server=WIN1102;Database=#Coolw@yDB;User=sa;Pwd=c00lw@ys3rv3r;")

    ' DATABASE COMMAND, without new because we always replace the command
    Private DBCmd As SqlCommand

    ' DB DATA - DB Data Adapter
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ByVal cConnectionString As String)
        DBCon = New SqlConnection(cConnectionString)
    End Sub

End Class
