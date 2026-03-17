Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_edit_item
    Dim itemcode As Integer = 0

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        conn()
        sql = "UPDATE ItemsMF SET ItemDesc='" + txtdesc.Text + "',unit='" + txtcat.Text + "',users='" + user.ToString + "' WHERE Itemcode='" + txtcode.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        MsgBox("Item code " & txtcode.Text & "  was successfully updated.", MsgBoxStyle.Information)
        txtcat.Text = ""
        txtdesc.Clear()
        Me.Close()
        frm_items.view_items()
    End Sub

    Private Sub frm_additem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdesc.Text = frm_items.dtgriditems.CurrentRow.Cells(1).Value
        txtcode.Text = frm_items.dtgriditems.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frm_items.view_items()
    End Sub

    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtdesc.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
End Class