Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_additem
    Dim itemcode As Integer = 0

    Private Sub frm_additem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_code()
    End Sub

    Private Sub gen_code()
        conn()
        sql = "SELECT MAX(ItemCode) as ItemCode FROM ItemsMF"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                itemcode = Double.Parse(rd("ItemCode")) + 1
                txtcode.Text = itemcode.ToString("000")
            Catch ex As Exception
                itemcode = 1
                txtcode.Text = itemcode.ToString("000")
            End Try
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtdesc.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtcode.Text.Trim = "" Then
            MsgBox("Item code is required.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtcat.Text.Trim = "" Then
            MsgBox("Item category is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtcat.Focus()
        ElseIf txtdesc.Text.Trim = "" Then
            MsgBox("Item description is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtdesc.Focus()
        Else
            conn()
            sql = "INSERT INTO ItemsMF(ItemCode,ItemDesc,Itemcategory,status,users) VALUES ('" + itemcode.ToString("000") + "','" + txtdesc.Text + "','" + txtcat.Text + "','A','" + user.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox("New item was successfully added.", MsgBoxStyle.Information)
            txtcat.Text = ""
            txtdesc.Clear()
            gen_code()
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
        frm_items.view_items()
    End Sub
End Class