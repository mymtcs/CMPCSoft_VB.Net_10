Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_post_ssspayment
    Dim postno As Integer = 0
    Dim runbal As Integer = 0

    Private Sub frm_deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpdate.Value = systemdate
        select_post_mode()
        'txtrmrks.Text = "Transfer from old account."
    End Sub

    Private Sub select_post_mode()
        Dim table1 As DataTable = New DataTable()
        table1.Columns.Add("PostID")
        table1.Columns.Add("Description")
        table1.Rows.Add("Co", "SSS Contribution")
        table1.Rows.Add("Ln", "SSS loan payment")
        txtpmode.DataSource = table1
        Me.txtpmode.AutoFilter = True
        txtpmode.DisplayMember = "Description"
        txtpmode.ValueMember = "PostID"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtpmode.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtpmode.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtpmode.EditorControl.Columns(0).Width = 100
        Me.txtpmode.EditorControl.Columns(1).Width = 200
        Me.txtpmode.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub txtpdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpmode.Focus()
        End If
    End Sub

    Private Sub txtref_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrmrks.Focus()
        End If
    End Sub

    Private Sub txtpmode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpmode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamnt.Focus()
        End If
    End Sub

    Private Sub txtamnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamnt.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtamnt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtamnt.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtamnt.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            If e.KeyChar = Chr(13) Then GetNextControl(txtamnt, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamnt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamnt.KeyUp
        Try
            If Not txtamnt.Text.Contains(".") Then
                txtamnt.Text = Format(Val(Replace(txtamnt.Text, ",", "")), "#,###,###")
                txtamnt.Select(txtamnt.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bttn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_save.Click
        If txtpmode.Text.Trim = "" Then
            MsgBox("Please input post mode", MsgBoxStyle.Exclamation, "Message")
        ElseIf txtref.Text.Trim = "" Then
            MsgBox("Please input reference", MsgBoxStyle.Exclamation, "Message")
        ElseIf txtamnt.Text.Trim = "" Then
            MsgBox("Please input deposit amount", MsgBoxStyle.Exclamation, "Message")
        ElseIf Double.Parse(txtamnt.Text) = 0 Then
            MsgBox("Invalid amount", MsgBoxStyle.Exclamation, "Message")
        ElseIf txtrmrks.Text.Trim = "" Then
            MsgBox("Please input remarks", MsgBoxStyle.Exclamation, "Message")
        Else
            'If MessageBox.Show("Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "SELECT MAX(postno) As postno FROM SSSledger WHERE Memcode='" + Me.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                Try
                    postno = Double.Parse(rd("postno")) + 1
                Catch ex As Exception
                    postno = 1
                End Try
            End If
            myConn.Close()

            conn()
            sql = "INSERT INTO SSSLedger(Memcode,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Reference,userid,tdate,Active) VALUES "
            sql += "('" + Me.Text + "'"
            sql += ",'" + txtpdate.Value + "'"
            sql += "," + postno.ToString + ""
            sql += ",'" + txtpmode.SelectedValue.ToString + "'"
            sql += "," + Double.Parse(txtamnt.Text).ToString + ",0"
            sql += ",'" + txtrmrks.Text + "'"
            sql += ",'" + txtref.Text + "'"
            sql += ",'" + user.ToString + "'"
            sql += ",'" + systemdate + "'"
            sql += ",'Y'"
            sql += ")"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()


            txtamnt.Clear()
            txtpmode.Text = ""
            txtref.Clear()
            txtrmrks.Text = ""
            Me.Close()
            frm_sss_masterFile.display_ledger()
            'End If
        End If
    End Sub

    Private Sub bttn_saveclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_saveclose.Click
        Me.Close()
    End Sub


    Private Sub txtsavingstype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        txtpmode.Focus()
    End Sub
End Class