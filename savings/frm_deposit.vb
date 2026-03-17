Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_deposit
    Dim postno As Integer = 0
    Dim runbal As Integer = 0

    Private Sub frm_deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "New Deposit (" & frm_savings.dtgridsaving.CurrentRow.Cells(0).Value & ")"
        If usertype = "Admin" Then
            txtpdate.Enabled = True
        Else
            txtpdate.Enabled = False
        End If
        txtpdate.Value = systemdate
        select_post_mode()
        'select_remrks()
        gen_saType()
        gen_ref()
        txtsavings.SelectedValue = frm_savings.dtgridsaving.CurrentRow.Cells(7).Value
        'txtrmrks.Text = "Transfer from old account."
    End Sub

    Private Sub gen_saType()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM chartaccounts where Accttype='savings'  ORDER BY acct_description ASC" '
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsavings.DataSource = table1
        Me.txtsavings.AutoFilter = True
        txtsavings.DisplayMember = "Description"
        txtsavings.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsavings.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsavings.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsavings.EditorControl.Columns(0).Width = 100
        Me.txtsavings.EditorControl.Columns(1).Width = 280
        Me.txtsavings.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub



    Private Sub gen_ref()
        conn()
        sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        Dim ref As Integer = 0
        If rd.Read Then
            Try
                ref = Double.Parse(rd("postno")) + 1
            Catch ex As Exception
                ref = 1
            End Try
        End If
        rd.Close()
        myConn.Close()
        txtref.Text = systemdate.Month & "-" & ref.ToString("000000")
    End Sub

    Private Sub select_post_mode()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT postID,postname FROM SA_postType"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("PostID")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("postID").ToString, rd("postname").ToString)
        End While
        rd.Close()
        myConn.Close()
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

    Private Sub select_remrks()
        'Try
        Call conn()
        sql = "SELECT DISTINCT Remarks FROM accountledger GROUP BY Remarks ORDER BY Remarks ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        txtrmrks.Items.Clear()
        While rd.Read()
            txtrmrks.Items.Add(rd.Item("Remarks"))
        End While
        rd.Close()
        myConn.Close()
        'Catch ex As Exception
        'myConn.Close()
        'End Try
    End Sub

    Private Sub compute_runbal()
        conn()
        sql = "SELECT (SUM(b.debit)-SUM(b.credit))As SaAmnt "
        sql += "FROM AccountMaster a, AccountLedger b WHERE a.Accountnumber=b.Accountnumber and a.Accountnumber ='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            runbal = Double.Parse(rd("SaAmnt")) + Double.Parse(txtamnt.Text)
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txtrmrks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrmrks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsavings.Focus()
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
            sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
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
            rd.Close()
            myConn.Close()

            conn()
            sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,GL_sa,tdate,Active) VALUES "
            sql += "('" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
            sql += ",'" + txtpdate.Value + "'"
            sql += "," + postno.ToString + ""
            sql += ",'" + txtpmode.SelectedValue.ToString + "'"
            sql += "," + Double.Parse(txtamnt.Text).ToString + ",0"
            sql += ",'" + txtrmrks.Text + "'"
            sql += ",'" + txtref.Text + "'"
            sql += ",'" + user.ToString + "'"
            sql += ",'" + txtsavings.SelectedValue + "'"
            sql += ",'" + systemdate + "'"
            If txtpmode.SelectedValue = "CSH" Or txtpmode.SelectedValue = "CHK" Then
                sql += ",'N'"
            Else
                sql += ",'Y'"
            End If
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
            frm_savings.display_ledger()
            'End If
        End If
    End Sub

    Private Sub bttn_saveclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_saveclose.Click
        Me.Close()
    End Sub

    Private Sub txtcash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsavings.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsavings.Focus()
        End If
    End Sub

    Private Sub txtsavingstype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        txtpmode.Focus()
    End Sub

    Private Sub lblchange_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblchange.LinkClicked
        pnAccess.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If txtaccess.Text.Trim = adminpass Then
            txtpdate.Enabled = True
            pnAccess.Visible = False
        Else
            MsgBox("Invalid password.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

End Class