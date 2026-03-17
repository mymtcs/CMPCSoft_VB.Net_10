Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_editbrgy
    Dim provcode As String
    Dim muncode As String
    Dim brnchcode As String
    Dim brgycode As Integer = 0

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        conn()
        sql = "UPDATE barangay SET ProvCode='" + provcode.ToString + "',MunCode='" + muncode.ToString + "',BrgyDesc='" + txtbrgyname.Text + "' WHERE BrgyCode='" + brgycode.ToString("000000") + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        MsgBox("New barangay was successfully updated.", MsgBoxStyle.Information)
        txtprov.Clear()
        txtmun.Clear()
        txtbrgyname.Clear()
        Me.Close()
        frm_address.view_barangays()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pnprov.Size = New Size(347, 97)
        If pnprov.Visible = False Then
            pnprov.Visible = True
        Else
            pnprov.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pnmun.Size = New Size(347, 97)
        If pnmun.Visible = False Then
            pnmun.Visible = True
        Else
            pnmun.Visible = False
        End If
    End Sub

    Private Sub view_prov()
        Call conn()
        lstprov.Items.Clear()
        sql = "SELECT * FROM province WHERE provdesc LIKE'%" + txtprov.Text.Trim + "%' order by provdesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstprov.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub frm_addbrgy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        brgycode = frm_address.dtgridbrgy.CurrentRow.Cells(2).Value
        conn()
        sql = "SELECT a.*,b.provdesc,c.MunDesc FROM barangay a,province b,municipal c WHERE a.BrgyCode='" + brgycode.ToString("000000") + "' and a.ProvCode=b.ProvCode and a.MunCode=c.MunCode"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            provcode = rd("ProvCode").ToString
            muncode = rd("MunCode").ToString
            brgycode = rd("BrgyCode").ToString
            txtprov.Text = rd("provdesc").ToString
            txtmun.Text = rd("MunDesc").ToString
            txtbrgyname.Text = rd("BrgyDesc").ToString
            txtcode.Text = rd("BrgyCode").ToString
        End If
        rd.Close()
        myConn.Close()

        view_prov()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        frm_address.view_barangays()
    End Sub


    Private Sub txtprov_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprov.KeyUp
        pnprov.Size = New Size(347, 97)
        view_prov()
        If txtprov.Text.Length > 0 Then
            pnprov.Visible = True
        Else
            pnprov.Visible = False
        End If
        If e.KeyCode = Keys.Down Then
            lstprov.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            txtmun.Focus()
        End If
    End Sub

    Private Sub lstprov_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstprov.DoubleClick
        provcode = lstprov.FocusedItem.SubItems(0).Text
        txtprov.Text = lstprov.FocusedItem.SubItems(1).Text
        txtmun.Focus()
        pnprov.Visible = False
        view_mun()
    End Sub

    Private Sub view_mun()
        Call conn()
        lstmun.Items.Clear()
        sql = "SELECT MunCode,MunDesc FROM municipal WHERE ProvCode='" + lstprov.FocusedItem.SubItems(0).Text + "' and MunDesc LIKE'%" + txtmun.Text + "%' order by MunDesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstmun.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub lstprov_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstprov.KeyUp
        If e.KeyCode = Keys.Enter Then
            provcode = lstprov.FocusedItem.SubItems(0).Text
            txtprov.Text = lstprov.FocusedItem.SubItems(1).Text
            pnprov.Visible = False
            view_mun()
            txtmun.Focus()
        End If
    End Sub

    Private Sub txtmun_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmun.KeyUp
        pnmun.Size = New Size(347, 97)
        view_mun()
        If txtmun.Text.Length > 0 Then
            pnmun.Visible = True
        Else
            pnmun.Visible = False
        End If
        If e.KeyCode = Keys.Down Then
            lstmun.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            txtbrgyname.Focus()
        End If
    End Sub

    Private Sub lstmun_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstmun.DoubleClick
        muncode = lstmun.FocusedItem.SubItems(0).Text
        txtmun.Text = lstmun.FocusedItem.SubItems(1).Text
        pnmun.Visible = False
        txtbrgyname.Focus()
    End Sub

    Private Sub lstmun_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstmun.KeyUp
        If e.KeyCode = Keys.Enter Then
            muncode = lstmun.FocusedItem.SubItems(0).Text
            txtmun.Text = lstmun.FocusedItem.SubItems(1).Text
            pnmun.Visible = False
            txtbrgyname.Focus()
        End If
    End Sub
End Class