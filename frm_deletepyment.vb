Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_deletepyment

    Public Sub view()
        conn()
        lstmembers.Items.Clear()
        sql = "SELECT payno,prnum,fullname,prnpaid,collectiondate FROM LoanCollect WHERE prnum='" + txtprnumber.Text + "' ORDER BY fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstmembers.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstmembers.Items.Count - 1
            If i Mod 2 Then
                lstmembers.Items(i).BackColor = Color.LightCyan
            Else
                lstmembers.Items(i).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub bttnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsearch.Click
        view()
    End Sub

    Private Sub bttndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndel.Click
        If MessageBox.Show("Are you sure you want to remove this payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "DELETE FROM LoanCollect WHERE prnum='" + lstmembers.FocusedItem.SubItems(1).Text + "' and fullname='" + lblname.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            view()
        End If

    End Sub

    Private Sub lstmembers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstmembers.SelectedIndexChanged
        lblname.Text = lstmembers.FocusedItem.SubItems(2).Text
    End Sub
End Class