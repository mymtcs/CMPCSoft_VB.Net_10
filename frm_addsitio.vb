Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_addsitio
    Dim sitcode As Integer = 0

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtsitname.Text.Trim = "" Then
            MsgBox("Sitio name cannot be empty", MsgBoxStyle.Exclamation, "Invalid")
            txtsitname.Focus()
        Else
            conn()
            sql = "INSERT INTO sitio(ProvCode,MunCode,BrgyCode,sitcode,sitdesc,branchCode) VALUES ('" + txtprov.Text + "','" + txtmun.Text + "','" + txtbrgycode.Text + "','" + txtsitcode.Text + "','" + txtsitname.Text + "','13')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox("New sitio was successfully added.", MsgBoxStyle.Information)
            txtprov.Clear()
            txtmun.Clear()
            txtsitname.Clear()
            gen_code()
        End If
    End Sub

    Private Sub gen_code()
        conn()
        sql = "SELECT MAX(sitcode) as sitcode FROM sitio"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                sitcode = Double.Parse(rd("sitcode")) + 1
                txtsitcode.Text = sitcode.ToString("000000")
            Catch ex As Exception
                sitcode = 1
                txtsitcode.Text = sitcode.ToString("000000")
            End Try
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub frm_addbrgy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_code()
        txtprov.Text = frm_address.dtgridbrgy.CurrentRow.Cells(0).Value
        txtmun.Text = frm_address.dtgridbrgy.CurrentRow.Cells(1).Value
        txtbrgycode.Text = frm_address.dtgridbrgy.CurrentRow.Cells(2).Value
        txtsitcode.Text = sitcode.ToString("000000")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        frm_address.view_sitio()
    End Sub
End Class