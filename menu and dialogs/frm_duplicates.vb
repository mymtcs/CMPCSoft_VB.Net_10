Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop
Public Class frm_duplicates

    Private Sub frm_duplicates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If usertype = "Administrator" Or usertype = "Admin" Or usertype = "Bookkeeper" Then
            MergeMembersToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub LoadDuplicates()
        Dim status As String = "A"
        grid_members.Rows.Clear()
        conn()
        sql = "SELECT a.* FROM Members a"
        sql += " JOIN (SELECT firstname, lastname, COUNT(*) as counted"
        sql += " FROM Members WHERE status = '" & status & "'"
        sql += " GROUP BY firstname, lastname"
        sql += " HAVING COUNT(*) > 1 ) b"
        sql += " ON a.firstname = b.firstname"
        sql += " AND a.lastname = b.lastname"
        sql += " WHERE status = '" & status & "' ORDER BY a.lastname, a.firstname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            grid_members.Rows.Add(rd("lastname"), rd("firstname"))
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub btn_generate_Click(sender As System.Object, e As System.EventArgs) Handles btn_generate.Click
        LoadDuplicates()
    End Sub

    Private Sub MergeMembersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MergeMembersToolStripMenuItem.Click
        frm_utilities.txtsearch.Text = grid_members.CurrentRow.Cells(1).Value.ToString
        frm_utilities.Show()
        frm_utilities.TabControl1.SelectedTab = frm_utilities.TabPage3
    End Sub
End Class