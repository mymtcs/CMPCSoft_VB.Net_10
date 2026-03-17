Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization

Public Class frm_accountype

    Private Sub frm_accountype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_account()
    End Sub

    Private Sub gen_account()
        lstacctype.Items.Clear()
        conn()
        sql = "SELECT * FROM ChartAccounts WHERE acct_description LIKE'%" + txtsearch.Text.Trim + "%' ORDER BY accountcode"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstacctype.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstacctype.Items.Count - 1
           If i Mod 2 Then
                lstacctype.Items(i).BackColor = Color.LightGreen
            Else
                lstacctype.Items(i).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub lstacctype_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstacctype.DoubleClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        gen_account()
    End Sub
End Class