Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class collfrm
    Dim code As Integer = 0

    Private Sub gencode()
        conn()
        sql = "SELECT MAX(substring(CollCode,4,6)) As code FROM Officer"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                code = Double.Parse(rd("code")) + 1
            Catch ex As Exception
                code = 1
            End Try
        Else
            code = 1
        End If
        rd.Close()
        myConn.Close()
        txtcode.Text = branchcode.ToString & "-" & code_series & code.ToString("000")
    End Sub

    Private Sub collfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gencode()
        display_officer()
    End Sub

    Private Sub display_officer()
        conn()
        lstcoll.Items.Clear()
        sql = "SELECT CollCode,Fullname,Address,Contactno FROM Officer WHERE gl_loans='" + GL_loans + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstcoll.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstcoll.Items.Count - 1
            If i Mod 2 Then
                lstcoll.Items(i).BackColor = Color.LightGreen
            Else
                lstcoll.Items(i).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        If txtfullname.Text.Trim = "" Then
            MsgBox("Contact name cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtcontact.Text.Trim = "" Then
            MsgBox("Contact number cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            conn()
            sql = "INSERT INTO Officer(CollCode,Fullname,Address,Contactno,gl_loans,status) VALUES ('" + txtcode.Text + "','" + txtfullname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + GL_loans + "','A')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox("New officer was successfully added.", MsgBoxStyle.Information)
            txtfullname.Clear()
            txtaddress.Clear()
            txtcode.Clear()
            txtcontact.Clear()
            gencode()
            display_officer()
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub
End Class