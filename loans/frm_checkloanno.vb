Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_checkloanno

    Private Sub bttnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsubmit.Click
        If txtpass.Text.Trim = userpass Then '
            lblpass.Visible = False
            conn()
            sql = "UPDATE LoanNumberSeries set LastLNCode='" + txtloan_num.Text.ToString + "' where cyear='" + systemdate.Year.ToString + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            txtpass.Clear()
            Me.Close()
        Else
            lblpass.Visible = True
        End If
    End Sub

    Private Sub frm_checkloanno_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_loanProcess_indv.gen_pnnumber()
        frm_loanProcess_grp.gen_pnnumber()
    End Sub

    Private Sub frm_checkloanno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_loannum()
    End Sub

    Private Sub gen_loannum()
        conn()
        sql = "select LastLNCode from LoanNumberSeries where cYear='" + systemdate.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtloan_num.Text = rd("LastLNCode").ToString
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class