Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_occupation

    Private Sub frm_occupation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_newmembers.gen_occupation()
        frm_editmembers.gen_occupation()
    End Sub

    Private Sub frm_occupations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_chartAccounts()
    End Sub

    Public Sub view_chartAccounts()
        dtgrid_chartaccounts.Rows.Clear()
        conn()
        sql = "SELECT * FROM Occupation ORDER BY occupcode"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgrid_chartaccounts.Rows.Add
            dtgrid_chartaccounts.Rows(x).Cells(0).Value = rd("occupcode").ToString
            dtgrid_chartaccounts.Rows(x).Cells(1).Value = rd("occupdesc").ToString
        End While
        rd.Close()
        myConn.Close()

        For x As Integer = 0 To dtgrid_chartaccounts.Rows.Count - 1
            If x Mod 2 Then
                dtgrid_chartaccounts.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        view_chartAccounts()
    End Sub

    Private Sub dtgrid_chartaccounts_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_chartaccounts.CellEndEdit
        If dtgrid_chartaccounts.CurrentRow.Cells(0).Value <> "" Then
            conn()
            sql = "SELECT * FROM Occupation WHERE occupcode='" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE Occupation SET occupdesc='" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "' WHERE occupcode='" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO Occupation (occupcode,occupdesc) VALUES ('" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + "','" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub
End Class
