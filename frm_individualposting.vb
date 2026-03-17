Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_individualposting

    Private Sub frm_individualposting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_coll()
    End Sub

    Private Sub select_coll()
        'Try
        Call conn()
        sql = "SELECT Fullname FROM officer ORDER BY Fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        txtcoll.Items.Clear()
        While rd.Read()
            txtcoll.Items.Add(rd.Item("Fullname"))
        End While
        myConn.Close()
        'Catch ex As Exception
        'myConn.Close()
        'End Try
    End Sub
End Class