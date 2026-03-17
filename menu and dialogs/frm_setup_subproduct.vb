Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_setup_subproduct

    Private Sub frm_setup_subproduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_subproducts()
    End Sub

    Public Sub view_subproducts()
        conn()
        dtgrd_subproducts.Rows.Clear()
        sql = "SELECT * from subproducts order by code"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            dtgrd_subproducts.Rows.Add(rd("Code").ToString, rd("Description").ToString, rd("GL_loans").ToString, rd("Rate"), rd("Pen_rate").ToString, rd("GroupType").ToString)
        End While
        rd.Close()
        myConn.Close()
        For x As Integer = 0 To dtgrd_subproducts.Rows.Count - 1
            If x Mod 2 Then
                dtgrd_subproducts.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Dim row As DataGridViewRow = dtgrd_subproducts.Rows(x)
            row.Height = 20
        Next
    End Sub

    Private Sub dtgrd_subproducts_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrd_subproducts.CellEndEdit
        Try
            If e.ColumnIndex = 3 Or e.ColumnIndex = 5 Then
                conn()
                sql = "UPDATE subproducts SET Rate=" + dtgrd_subproducts.CurrentRow.Cells(3).Value.ToString + ", GroupType=" + dtgrd_subproducts.CurrentRow.Cells(5).Value.ToString + " WHERE code='" + dtgrd_subproducts.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class