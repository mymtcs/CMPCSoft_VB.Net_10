Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_chartAccounts

    Private Sub frm_chartAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_chartAccounts()
    End Sub

    Public Sub view_chartAccounts()
        dtgrid_chartaccounts.Rows.Clear()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS WHERE  acct_description LIKE '%" + txtsearch.Text + "%' ORDER BY ACCOUNTCODE"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgrid_chartaccounts.Rows.Add
            dtgrid_chartaccounts.Rows(x).Cells(0).Value = rd("Accountcode").ToString
            dtgrid_chartaccounts.Rows(x).Cells(1).Value = rd("acct_description").ToString
            dtgrid_chartaccounts.Rows(x).Cells(2).Value = rd("Active").ToString
            dtgrid_chartaccounts.Rows(x).Cells(3).Value = rd("Accttype").ToString
        End While
        rd.Close()
        myConn.Close()

        For x As Integer = 0 To dtgrid_chartaccounts.Rows.Count - 1
            If x Mod 2 Then
                dtgrid_chartaccounts.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next

        Try
            dtgridaccounts.Rows.Clear()
            conn()
            sql = "SELECT * FROM CHARTACCOUNTS WHERE  acct_description LIKE '%" + txtsearch.Text + "%' ORDER BY ACCOUNTCODE"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While rd.Read
                dtgridaccounts.Rows.Add(rd("Accountcode").ToString, rd("acct_description").ToString, rd("Active").ToString, rd("Accttype").ToString)
            End While
            rd.Close()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        view_chartAccounts()
    End Sub

    Private Sub dtgrid_chartaccounts_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_chartaccounts.CellEndEdit
        If dtgrid_chartaccounts.CurrentRow.Cells(0).Value <> "" Then
            conn()
            sql = "SELECT * FROM CHARTACCOUNTS WHERE ACCOUNTCODE='" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE CHARTACCOUNTS SET acct_description='" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "',ACTIVE='" + dtgrid_chartaccounts.CurrentRow.Cells(2).Value + "',Accttype='" + dtgrid_chartaccounts.CurrentRow.Cells(3).Value + "' WHERE ACCOUNTCODE='" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO CHARTACCOUNTS (ACCOUNTCODE,acct_description,ACTIVE,Accttype) VALUES ('" + dtgrid_chartaccounts.CurrentRow.Cells(0).Value + "','" + dtgrid_chartaccounts.CurrentRow.Cells(1).Value + "','" + dtgrid_chartaccounts.CurrentRow.Cells(2).Value + "','" + dtgrid_chartaccounts.CurrentRow.Cells(3).Value + "')"
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
