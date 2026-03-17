
Imports System.Data.SqlClient


Public Class SQLControl

    ' INITIALIZE CONNECTION STRING
    'Private cSQLConnString As String
    'cSQLConnString = {"Server=" & loginfrm.txtserver.Text + ";Database=" & loginfrm.txtdb.Text + ";User=sa;" + "Pwd=" & loginfrm.txtserver_pass.Text.Replace("123456789", "") + ";"}

    ' DATABASE CONNECTION
    ' PROPERTY FOR SqlConnection 1= Server 2=Database 3=user 4=password
    ' loginfrm.txtserver.Text, 

    ' Private DBCon As New SqlConnection("Server=WIN1102;Database=#Coolw@yDB;User=sa;Pwd=c00lw@ys3rv3r;")
    Private DBCon As New SqlConnection("Server=" & loginfrm.txtserver.Text + ";Database=" & loginfrm.txtdb.Text + ";User=sa;" + "Pwd=" & loginfrm.txtserver_pass.Text.Replace("123456789", "") + ";")

    'Public cConnString As String = ""
    'cConnString = "Data Source=" & loginfrm.txtserver.Text + ";Network Library=DBMSSOCN;Initial Catalog=" + loginfrm.txtdb.Text + ";USER ID=sa; PASSWORD=" + loginfrm.txtserver_pass.Text.Replace("123456789", "") + ";"
    'Private DBCon As New SqlConnection("Data Source=" & loginfrm.txtserver.Text & ";Database=" & loginfrm.txtdb.Text & "User=sa;" & "Pwd=" & loginfrm.txtserver_pass.Text.Replace("123456789", "") + ";")

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


    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ByVal ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(ByVal Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            ' BRAND NEW DATA
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message

        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If

        End Try

    End Sub


    ' ADD PARAMS
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional ByVal Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False

        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception")

    End Function

End Class
