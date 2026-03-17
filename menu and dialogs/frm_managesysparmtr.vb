Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_managesysparmtr
    Dim code As Integer = 1

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_managesysparmtr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_deductionsMF()
    End Sub

    Private Sub view_deductionsMF()
        dtgrid_deductions.Rows.Clear()
        conn()
        sql = "SELECT * FROM loanterms"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtgrid_deductions.Rows.Add(rd("code").ToString, rd("description").ToString, rd("Payable").ToString, rd("yeardays").ToString, rd("Type").ToString)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub dtgrid_deductions_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_deductions.CellEndEdit
        If dtgrid_deductions.CurrentRow.Cells(0).Value <> "" And dtgrid_deductions.CurrentRow.Cells(1).Value <> "" And dtgrid_deductions.CurrentRow.Cells(3).Value <> "" And dtgrid_deductions.CurrentRow.Cells(4).Value <> "" Then
            conn()
            sql = "SELECT * FROM loanterms WHERE code='" + dtgrid_deductions.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE loanterms SET description='" + dtgrid_deductions.CurrentRow.Cells(1).Value + "',Payable=" + dtgrid_deductions.CurrentRow.Cells(2).Value + ",yeardays=" + dtgrid_deductions.CurrentRow.Cells(3).Value + ",Type='" + dtgrid_deductions.CurrentRow.Cells(4).Value + "' WHERE code='" + dtgrid_deductions.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO loanterms (code,description,Payable,yeardays,Type) VALUES ('" + dtgrid_deductions.CurrentRow.Cells(0).Value + "','" + dtgrid_deductions.CurrentRow.Cells(1).Value + "'," + dtgrid_deductions.CurrentRow.Cells(2).Value + "," + dtgrid_deductions.CurrentRow.Cells(3).Value + ",'" + dtgrid_deductions.CurrentRow.Cells(4).Value + "')"
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