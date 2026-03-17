Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_items

    Private Sub frm_items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_items()
    End Sub

    Public Sub view_items()
        conn()
        dtgriditems.Rows.Clear()
        sql = "SELECT * From ITEMSMF ORDER BY itemdesc ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgriditems.Rows.Add
            dtgriditems.Rows(x).Cells(0).Value = rd("itemcode").ToString
            dtgriditems.Rows(x).Cells(1).Value = rd("itemdesc").ToString
            dtgriditems.Rows(x).Cells(2).Value = rd("Itemcategory").ToString
            If rd("status") = "A" Then
                dtgriditems.Rows(x).Cells(3).Value = "Active"
            Else
                dtgriditems.Rows(x).Cells(3).Value = "Inactive"
            End If
        End While
        myConn.Close()

        For x As Integer = 0 To dtgriditems.Rows.Count - 1
            If x Mod 2 Then
                dtgriditems.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Public Sub ViewInventory()
        conn()
        dtgrid_inv.Rows.Clear()
        sql = "SELECT a.reference,a.trndate,b.itemdesc,a.principal,a.markup,a.qty FROM ItemInventory a, ItemsMF b WHERE a.itemcode=b.itemcode and a.itemcode='" + dtgriditems.CurrentRow.Cells(0).Value + "' and a.trndate ='" & systemdate & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim trndate As Date = rd("trndate").ToString
            Dim x As Integer = dtgrid_inv.Rows.Add
            dtgrid_inv.Rows(x).Cells(0).Value = trndate.ToShortDateString
            dtgrid_inv.Rows(x).Cells(1).Value = rd("reference").ToString
            dtgrid_inv.Rows(x).Cells(2).Value = rd("itemdesc").ToString
            dtgrid_inv.Rows(x).Cells(3).Value = rd("principal").ToString
            dtgrid_inv.Rows(x).Cells(4).Value = rd("markup").ToString
            dtgrid_inv.Rows(x).Cells(5).Value = rd("qty").ToString
            dtgrid_inv.Rows(x).Cells(6).Value = "X"
        End While
        myConn.Close()

        For x As Integer = 0 To dtgrid_inv.Rows.Count - 1
            If x Mod 2 Then
                dtgrid_inv.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub dtgriditems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgriditems.Click
        ViewInventory()
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        frm_additem.ShowDialog()
    End Sub

    Private Sub bttndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnedit.Click
        frm_edit_item.ShowDialog()
    End Sub

    Private Sub bttnreceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnreceive.Click
        frm_receivestocks.Text = "Receive Stocks"
        frm_receivestocks.ShowDialog()
    End Sub

    Private Sub dtgrid_inv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_inv.DoubleClick
        frm_receivestocks.Text = "Edit Received Stocks"
        frm_receivestocks.ShowDialog()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_receivestocks.Text = "Edit Received Stocks"
        frm_receivestocks.ShowDialog()
    End Sub

    Private Sub dtgrid_inv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_inv.CellContentClick
        Dim delete As Int32 = 6
        If e.ColumnIndex = delete Then
            If MessageBox.Show("Delete item " & dtgrid_inv.CurrentRow.Cells(2).Value & " from stocks?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                conn()
                sql = "DELETE FROM ItemInventory WHERE trndate = @date AND reference = @ref"
                cmd = New SqlCommand(sql, myConn)
                cmd.Parameters.AddWithValue("@date", dtgrid_inv.CurrentRow.Cells(0).Value)
                cmd.Parameters.AddWithValue("@ref", dtgrid_inv.CurrentRow.Cells(1).Value)
                myConn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item successfully removed from stocks", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myConn.Close()

                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Deleted stocks with reference " & dtgrid_inv.CurrentRow.Cells(1).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                view_items()
                ViewInventory()
            Else

            End If
        End If
    End Sub
End Class