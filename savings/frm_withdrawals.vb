Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_withdrawals
    Dim postno As Integer = 0
    Dim runbal As Integer = 0
    Dim postID As String

    Private Sub gen_ref()
        Dim ref As Integer = 0
        conn()
        sql = "SELECT count(reference) as ref from CashiersTransaction"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            ref = rd("ref").ToString
            txtref.Text = ref.ToString("000000") & systemdate.Month
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub frm_withdrawals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "New Withdrawals (" & frm_savings.dtgridsaving.CurrentRow.Cells(0).Value & ")"
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
        txtsa.SelectedValue = frm_savings.dtgridsaving.CurrentRow.Cells(7).Value
    End Sub

    Private Sub gen_saType()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM chartaccounts where Accttype ='savings' ORDER BY acct_description ASC" '
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
        txtsa.DataSource = table1
        Me.txtsa.AutoFilter = True
        txtsa.DisplayMember = "Description"
        txtsa.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsa.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsa.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsa.EditorControl.Columns(0).Width = 100
        Me.txtsa.EditorControl.Columns(1).Width = 280
        Me.txtsa.MultiColumnComboBoxElement.DropDownWidth = 400
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
        Call conn()
        sql = "SELECT DISTINCT Remarks FROM accountledger GROUP BY Remarks ORDER BY Remarks ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        txtrmrks.Items.Clear()
        While rd.Read()
            txtrmrks.Items.Add(rd.Item("Remarks"))
        End While
        myConn.Close()
    End Sub

    'Private Sub compute_runbal()
    '    conn()
    '    sql = "SELECT (SUM(b.debit)-SUM(b.credit))As SaAmnt "
    '    sql += "FROM AccountMaster a, AccountLedger b WHERE a.Accountnumber=b.Accountnumber and a.Accountnumber ='" + frm_savings.dtgridsavings.CurrentRow.Cells(0).Value + "'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    If rd.Read Then
    '        runbal = Double.Parse(rd("SaAmnt")) - Double.Parse(txtamnt.Text)
    '    End If
    '    myConn.Close()
    'End Sub
    Private Sub insert_to_disburse()
        If Not txtpmode.SelectedValue = "DM" Then
            conn()
            sql = "INSERT INTO CashiersTransaction(Payee,Debit,Credit,Reference,Trndate,Ttime,UserID,GLaccount,Remarks,AcctReference) VALUES ('" + frm_savings.dtgridsaving.CurrentRow.Cells(1).Value + "',0," + txtamnt.Text + ",'" + txtref.Text + "','" + txtpdate.Value + "','" + time.ToString + "','" + user.ToString + "','" + GL_sa + "','Withdrawal','0')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox("Transaction complete.", MsgBoxStyle.Information, "Success")
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

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtpdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpmode.Focus()
        End If
    End Sub

    Private Sub txtpmode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtref.Focus()
        End If
    End Sub

    Private Sub txtrmrks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrmrks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsa.Focus()
        End If
    End Sub

    Private Sub txtref_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrmrks.Focus()
        End If
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
        Dim loans As Double = 0
        Dim bal As Integer = Double.Parse(frm_savings.dtgridsaving.CurrentRow.Cells(3).Value) - Double.Parse(txtamnt.Text)
        If txtpmode.Text.Trim = "" Then
            MsgBox("Please input post mode", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtref.Text.Trim = "" Then
            MsgBox("Please input reference", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtamnt.Text.Trim = "" Then
            MsgBox("Please input deposit amount", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf bal < 0 Then
            MsgBox("Amount withdrawal is greater than the savings balance.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtrmrks.Text.Trim = "" Then
            MsgBox("Please input remarks", MsgBoxStyle.Exclamation, "Invalid")
        Else
            conn()
            sql = "SELECT LoanAmnt FROM loans where accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "' and status='A'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                loans = rd("LoanAmnt")
            Else
                loans = 0
            End If
            rd.Close()
            myConn.Close()

            If loans > 5999 Then
                If bal < 1000 Then '
                    If MessageBox.Show("Account balance is greater than minimum required. Click yes to continue", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        GoTo 1
                    End If
                End If
            Else
                If bal < 500 Then '
                    If MessageBox.Show("Account balance is greater than minimum required. Click yes to continue", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        GoTo 1
                    End If
                End If
            End If
            'If MessageBox.Show("Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                postno = Double.Parse(rd("postno")) + 1
            Else
                postno = 1
            End If
            myConn.Close()

            'compute_runbal()
            'If Double.Parse(txtamnt.Text) = 0 Then
            conn()
            sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,GL_sa,userid,tdate,Active) VALUES "
            sql += "('" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
            sql += ",'" + txtpdate.Value + "'"
            sql += "," + postno.ToString + ""
            sql += ",'" + txtpmode.SelectedValue.ToString + "'"
            sql += ",0," + Double.Parse(txtamnt.Text).ToString + ""
            sql += ",'" + txtrmrks.Text + "'"
            sql += ",'" + txtref.Text + "'"
            sql += ",'" + txtsa.SelectedValue + "'"
            sql += ",'" + user.ToString + "'"
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
            'End If
            'conn()
            'sql = "select (sum(debit-credit)) as runbal from accountledger where accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'rd = cmd.ExecuteReader
            'If rd.Read Then
            '    If rd("runbal") < 1 Then
            '        conn()
            '        sql = "UPDATE accountmaster set accountstatus='Closed' WHERE accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "'"
            '        cmd = New SqlCommand(sql, myConn)
            '        myConn.Open()
            '        cmd.ExecuteNonQuery()
            '        myConn.Close()
            '    End If
            'End If
            'rd.Close()
            'myConn.Close()
            'If txtpmode.SelectedValue = "CSH" Then
            '    insert_to_disburse()
            'End If
            gen_ref()
            txtamnt.Clear()
            txtpmode.Text = ""
            txtref.Clear()
            txtrmrks.Text = ""
            Me.Close()
            frm_savings.display_ledger()
            'End If
        End If
1:
    End Sub

    Private Sub bttn_saveclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_saveclose.Click
        Me.Close()
    End Sub

    Private Sub txtcash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsa.Focus()
        End If
    End Sub

    Private Sub txtsavingstype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtpmode.Focus()
        End If
    End Sub

    Private Sub txtpmode_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpmode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamnt.Focus()
        End If
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