Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_source_of_income

    Private Sub frm_source_of_income_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_newmembers.gen_src_ofIncome()
        frm_editmembers.gen_src_ofIncome()
    End Sub

    Private Sub frm_source_of_income_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_chartAccounts()
    End Sub

    Public Sub view_chartAccounts()
        dtgrid_chartaccounts.Rows.Clear()
        conn()
        sql = "SELECT * FROM SourceofIncome ORDER BY SourceofIncome"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            dtgrid_chartaccounts.Rows.Add(rd("id").ToString, rd("SourceofIncome").ToString)
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
        If dtgrid_chartaccounts.CurrentRow.Cells(1).Value <> "" Then
            conn()
            sql = "SELECT SourceofIncome FROM SourceofIncome WHERE SourceofIncome='" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE SourceofIncome SET SourceofIncome='" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "' WHERE ID=" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + ""
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO SourceofIncome (SourceofIncome) VALUES ('" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "')"
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
