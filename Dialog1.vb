Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_company_param

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtcompanyname.Text.Trim = "" Then
            MsgBox("Company name cannot be empty.", MsgBoxStyle.Exclamation, "Message")
            txtcompanyname.Focus()
        ElseIf txtcompanyaddr.Text.Trim = "" Then
            MsgBox("Company address cannot be empty.", MsgBoxStyle.Exclamation, "Message")
            txtcompanyaddr.Focus()
        ElseIf txtbranchname.Text.Trim = "" Then
            MsgBox("Branch name cannot be empty.", MsgBoxStyle.Exclamation, "Message")
            txtbranchname.Focus()
        ElseIf txtbranchcode.Text.Trim = "" Then
            MsgBox("Branch code cannot be empty.", MsgBoxStyle.Exclamation, "Message")
            txtbranchcode.Focus()
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            conn()
            sql = "DELETE FROM CompanyName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "INSERT INTO CompanyName(CompanyName,CompanyAddress,CompanyBranch,BranchCode)VALUES('" + txtcompanyname.Text + "','" + txtcompanyaddr.Text + "','" + txtbranchname.Text + "','" + txtbranchcode.Text + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_company_param_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
