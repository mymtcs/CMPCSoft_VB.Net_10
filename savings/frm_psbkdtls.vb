Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_psbkdtls
    'Public lineno As Integer = 0

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If IsNumeric(txtline.Text) = False Then
            MsgBox("Invalid line number.", MsgBoxStyle.Exclamation, "Invalid")
            'ElseIf Double.Parse(txtline.Value) > 35 Then
            '    MsgBox("Line number limit is 35. Please try again", MsgBoxStyle.Exclamation, "Invalid")
        Else
            frm_printsavings.lineno = txtline.Value
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            'frm_printsavings.postno = txtpostno.Text
            'frm_printsavings.ShowDialog()
            'conn()
            'sql = "UPDATE ACCOUNTLEDGER SET Editable='N' WHERE accountnumber='" + Me.Text + "'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()

            frm_printsavings.printSA_ledger()
            'frm_printsavings.Show()
            frm_printsavings.crviewer.PrintReport()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_psbkdtls_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = frm_savings.dtgridsaving.CurrentRow.Cells(0).Value
            txtpostno.Text = frm_savings.lstsavingledger.FocusedItem.SubItems(1).Text
        Catch ex As Exception
            txtpostno.Text = 0
        End Try
    End Sub
End Class
