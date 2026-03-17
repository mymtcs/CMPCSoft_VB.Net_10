Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_loan_terms
    Dim code As Integer = 1

    Private Sub bttncont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtpayable.Text.Trim = "" Then
            MsgBox("Payable field cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtpayable.Focus()
        ElseIf IsNumeric(txtpayable.Text) = False Then
            MsgBox("Payable field must be numeric.", MsgBoxStyle.Exclamation, "Invalid")
            txtpayable.Focus()
        ElseIf txtmode.Text.Trim = "" Then
            MsgBox("Mode field cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtmode.Focus()
        ElseIf txtdesc.Text.Trim = "" Then
            MsgBox("Description field cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtdesc.Focus()
        Else
            conn()
            sql = "SELECT * FROM LoanTerms WHERE code='" + txtcode.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If Not rd.Read Then
                conn()
                sql = "INSERT INTO LoanTerms(code,Description,Payable,yeardays,Type) VALUES ('" + txtcode.Text + "','" + txtdesc.Text + "'," + txtpayable.Text + ",360,'" + txtmode.Text + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                gencode()
                viewloan_terms()
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndelete.Click
        conn()
        sql = "SELECT * FROM Loans WHERE termcode='" + txtcode.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If Not rd.Read Then
            conn()
            sql = "DELETE FROM Loanterms WHERE code='" + txtcode.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            txtdesc.Clear()
            txtpayable.Text = 0
            txtmode.Text = ""
            viewloan_terms()
        Else
            MsgBox("Failed to delete, Loan Terms are being used in loans.", MsgBoxStyle.Exclamation, "Invalid")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose.Click
        Me.Close()
    End Sub

    Private Sub frm_weavedlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gencode()
        viewloan_terms()
    End Sub

    Private Sub viewloan_terms()
        dtgrd_term.Rows.Clear()
        conn()
        sql = "SELECT * FROM Loanterms"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtgrd_term.Rows.Add(rd("code").ToString, rd("description").ToString, rd("payable").ToString, rd("type").ToString)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub dtgrd_term_CellClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_term.CellClick
        txtcode.Text = dtgrd_term.CurrentRow.Cells(0).Value
        txtdesc.Text = dtgrd_term.CurrentRow.Cells(1).Value
        txtpayable.Text = dtgrd_term.CurrentRow.Cells(2).Value
        txtmode.Text = dtgrd_term.CurrentRow.Cells(3).Value
    End Sub

    Private Sub gencode()
        conn()
        sql = "SELECT MAX(code) As code FROM loanterms"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                code = Double.Parse(rd("code")) + 1
            Catch ex As Exception
                code = 1
            End Try
        Else
            code = 1
        End If
        rd.Close()
        myConn.Close()
        txtcode.Text = code.ToString("000")
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        gencode()
        txtdesc.Clear()
        txtpayable.Text = 0
        txtmode.Text = ""
    End Sub
End Class