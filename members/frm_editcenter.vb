Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_editcenter

    Private Sub frm_editcenter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_center.gen_center()
    End Sub

    Private Sub frm_editcenter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtctrcode.Text = frm_center.lst_center.FocusedItem.SubItems(0).Text
            'txtctr_num.Text = frm_center.lst_center.FocusedItem.SubItems(1).Text
            txtaddress.Text = frm_center.lst_center.FocusedItem.SubItems(5).Text
            txtctrname.Text = frm_center.lst_center.FocusedItem.SubItems(1).Text
            txtctrcheif.Text = frm_center.lst_center.FocusedItem.SubItems(2).Text
            txtcol_day_no.Text = frm_center.lst_center.FocusedItem.SubItems(4).Text
            txtacctnumber.Text = frm_center.lst_center.FocusedItem.SubItems(6).Text
        Catch ex As Exception
            Me.Close()
            MsgBox("Please select a center to edit.", MsgBoxStyle.Exclamation, "Note")
        End Try
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        conn()
        sql = "UPDATE center SET accountnumber='" + txtacctnumber.Text + "', ctrname='" + txtctrname.Text + "',ctrchief='" + txtctrcheif.Text + "',ColDayno=" + txtcol_day_no.Text + ",ctraddress='" + txtaddress.Text + "' WHERE ctrcode='" + txtctrcode.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        conn()
        sql = "UPDATE accountmaster SET memcode='" + txtctrcode.Text + "' WHERE accountnumber='" + txtacctnumber.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        conn()
        sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Editing the center " & txtctrcode.Text & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        MsgBox("Center successfully updated", MsgBoxStyle.Information, "Success")
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub
End Class