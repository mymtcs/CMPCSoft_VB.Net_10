Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data
Imports System.Globalization

Public Class frm_CBUwithdrawals
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

    Private Sub frm_CBUwithdrawals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "CBU Withdrawals (" & frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value & ")"
        txtpdate.Value = systemdate
        select_remrks()
        txtamnt.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", frm_cbuledger.dtgridsaving.CurrentRow.Cells(2).Value)
        gen_ref()
        select_GL()
    End Sub

    Private Sub select_GL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS WHERE acct_description LIKE '%PAID UP SHARE CAPITAL%'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("accttype").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtgl.DataSource = table1
        Me.txtgl.AutoFilter = True
        txtgl.DisplayMember = "Acct. Description"
        txtgl.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtgl.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtgl.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtgl.EditorControl.Columns(0).Width = 100
        Me.txtgl.EditorControl.Columns(1).Width = 250
        Me.txtgl.EditorControl.Columns(1).Width = 200
        Me.txtgl.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub select_remrks()
        Call conn()
        sql = "SELECT DISTINCT Remarks FROM CBUledger GROUP BY Remarks ORDER BY Remarks ASC"
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
        conn()
        sql = "INSERT INTO CashiersTransaction(Payee,Debit,Credit,Reference,Trndate,Ttime,UserID,GLaccount,Remarks,AcctReference) VALUES ('" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(1).Value + "',0," + Double.Parse(txtamnt.Text).ToString + ",'" + txtref.Text + "','" + txtpdate.Value + "','" + time.ToString + "','" + user.ToString + "','" + txtgl.SelectedValue + "','Withdrawal','0')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        MsgBox("Transaction complete.", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub txtamnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamnt.KeyDown
        If e.KeyCode = Keys.Enter Then
            RadButton1.Focus()
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

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Dim bal As Integer = Double.Parse(frm_cbuledger.dtgridsaving.CurrentRow.Cells(2).Value) - Double.Parse(txtamnt.Text)
        If txtref.Text.Trim = "" Then
            MsgBox("Please input reference.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf cbotpost.Text.Trim = "" Then
            MsgBox("Please input post mode.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtamnt.Text.Trim = "" Then
            MsgBox("Please input deposit amount.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf bal < 0 Then
            MsgBox("Amount withdrawal is greater than the cbu balance.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtrmrks.Text.Trim = "" Then
            MsgBox("Please input remarks.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If MessageBox.Show("Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                conn()
                sql = "SELECT MAX(postno) As postno FROM CBULedger WHERE CBUaccount='" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    postno = Double.Parse(rd("postno")) + 1
                Else
                    postno = 1
                End If
                myConn.Close()

                conn()
                sql = "INSERT INTO CBULedger(CBUaccount,PostingDate,Postno,Debit,Credit,Remarks,Reference,userid,tdate,Active,postmode, GL_loans) VALUES "
                sql += "('" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "'"
                sql += ",'" + txtpdate.Value + "'"
                sql += "," + postno.ToString + ""
                sql += ",0," + Double.Parse(txtamnt.Text).ToString + ""
                sql += ",'" + txtrmrks.Text + "'"
                sql += ",'" + txtref.Text + "'"
                sql += ",'" + user.ToString + "'"
                sql += ",'" + systemdate + "'"
                If cbotpost.Text = "Cash" Then
                    sql += ",'N'"
                Else
                    sql += ",'Y'"
                End If
                sql += ",'" & cbotpost.Text & "'"
                sql += ",'" & txtgl.SelectedValue & "'"
            End If
            sql += ")"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            'insert_to_disburse()
            gen_ref()
            txtamnt.Clear()
            txtref.Clear()
            txtrmrks.Text = ""
            Me.Close()
            frm_cbuledger.display_ledger()
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub


    Private Sub txtpmode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtref.Focus()
        End If
    End Sub

    Private Sub txtrmrks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrmrks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamnt.Focus()
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
End Class