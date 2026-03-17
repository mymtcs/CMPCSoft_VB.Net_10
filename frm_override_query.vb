Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization

Public Class frm_override_query

    Private Sub bttn_override_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_override.Click
        If txtuser_override.Text = "mis" And txtpassword_override.Text = "coolway9658" Then
            If MessageBox.Show("Are you sure you want to proceed this query?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    conn()
                    sql = frm_query.txtquery.Text
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    Me.Close()
                    frm_query.lblerror.Text = "Query executed successfulyy."
                Catch ex As Exception
                    frm_query.lblerror.Text = ex.Message
                End Try
            End If
        End If
    End Sub

    Private Sub bttn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_override_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser_override.Focus()
    End Sub

    Private Sub txtoverride_amount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            bttn_override.Focus()
        End If
    End Sub

    Private Sub txtpassword_override_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword_override.LostFocus
        If txtpassword_override.Text.Trim = "" Then
            txtpassword_override.Text = "Enter ID.."
        End If
    End Sub
End Class