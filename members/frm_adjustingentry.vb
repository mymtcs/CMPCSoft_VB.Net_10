Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_adjustingentry
    Dim memcode As String
    Dim amntdue As Decimal = 0
    Dim intdue As Decimal = 0
    Dim cf As Decimal = 0
    Dim p_savings As Decimal = 0
    Dim total_amntpaid = 0
    Dim payno As Decimal = 0
    Dim postno As Decimal = 0
    Dim colldate As DateTime
    Dim prnbal As Decimal = 0
    Dim intbal As Decimal = 0
    Dim advprn As Decimal = 0
    Dim advint As Decimal = 0
    Dim saacct_CF As String
    Dim postnoCF As Integer = 0

    Private Sub frm_adjustingentry_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_members.view_loanledger()
    End Sub

    Private Sub frm_adjustingentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value
        If multiproduct = "Y" Then
            chkprndue.Checked = True
            chksavings.Enabled = False
            chkprndue.Enabled = False
        Else
            chksavings.Checked = True
        End If
        dttrn.Value = systemdate
        txtcoll_date.Value = systemdate
        'view_loansched()
        cbopay_type.Text = "ADJUSTING ENTRY"
        select_GL()
        gen_amounts()
    End Sub

    Private Sub select_GL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS WHERE Accttype='Cash'"
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
        Me.txtgl.EditorControl.Columns(2).Width = 150
        Me.txtgl.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub insert_CF()
        'Try
        conn()
        sql = "select b.Accountnumber from center a, accountmaster b where a.Accountnumber=b.accountnumber and a.ctrcode='" + frm_members.dtgridloan_list.CurrentRow.Cells(5).Value + "' and b.accountstatus='Active'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            saacct_CF = rd("Accountnumber").ToString
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + saacct_CF.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            Try
                postnoCF = Double.Parse(rd("postno")) + 1
            Catch ex As Exception
                postnoCF = 1
            End Try
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,RunBalance,Remarks,Refrence,userid,tdate,GL_sa) VALUES "
        sql += "('" + saacct_CF.ToString + "'"
        sql += ",'" + dttrn.Value + "'"
        sql += "," + postnoCF.ToString + ""
        sql += ",'CSH-CL'"
        sql += "," + txtcf.Text + ",0"
        sql += ",0"
        sql += ",'CF Collections'"
        sql += ",'" + txtref.Text + "'"
        sql += ",'" + user.ToString + "'"
        sql += ",'" + systemdate + "'"
        sql += ",'" + GL_sa + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        'Catch ex As Exception

        'End Try
    End Sub


    Private Sub gen_amounts()
        conn()
        sql = "select x.* from(select top 1 a.*, "
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "postno=isnull((select count(payno)+1 from loancollect where pnnumber=a.pnnumber),1)"
        sql += " from loancollect a where a.pnnumber='" + txtlno.Text + "' order by a.payno desc)x"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            'txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value.ToString
            memcode = rd("memcode").ToString
            txtfullname.Text = frm_members.dtgridmember.CurrentRow.Cells(1).Value
            txtprnpaid.Text = Double.Parse(rd("principal")) - (Double.Parse(rd("principal")) * 2)
            txtadvprn.Text = Double.Parse(rd("advprincipal")) - (Double.Parse(rd("advprincipal")) * 2)
            txtintdue.Text = Double.Parse(rd("intpaid")) - (Double.Parse(rd("intpaid")) * 2)
            txtadv_int.Text = Double.Parse(rd("advinterest")) - (Double.Parse(rd("advinterest")) * 2)
            txtsa_amount.Text = Double.Parse(rd("savings")) - (Double.Parse(rd("savings")) * 2)
            txtcf.Text = Double.Parse(rd("cf")) - (Double.Parse(rd("cf")) * 2)
            cf = rd("CF").ToString
            prnbal = rd("prnamnt")
            intbal = rd("interestdue")
            payno = rd("postno")
        End If
        rd.Close()
        myConn.Close()
        'MsgBox(amntdue.ToString)
        'txtprnpaid.Text = rd("principal").ToString
        'txtintdue.Text = intdue.ToString
        'txtcf.Text = cf.ToString
        'txtsa_amount.Text = p_savings.ToString
        'total_amntpaid = ((amntdue + intdue) + cf) + p_savings
        'compute_payment()
        'lblrunbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", (runbal - (Double.Parse(txtamountdue.Text) + Double.Parse(txtadvprn.Text)) - Double.Parse(txtintdue.Text)))

        lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txtprnpaid.Text) + Double.Parse(txtadvprn.Text)))
        lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txtintdue.Text) + Double.Parse(txtadv_int.Text)))
    End Sub

    Private Sub txtamount_paid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    'Private Sub txtamount_paid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Try
    '        Dim dot As Integer, ch As String
    '        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    '        If e.KeyChar = "." And txtamount_paid.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

    '        dot = txtamount_paid.Text.IndexOf(".")
    '        If dot > -1 Then            'allow only 2 decimal places
    '            ch = txtamount_paid.Text.Substring(dot + 1)
    '            If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
    '        End If

    '        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    '        If e.KeyChar = Chr(13) Then GetNextControl(txtamount_paid, True).Focus() 'Enter key moves to next control in Tab order
    '    Catch ex As Exception

    '    End Try
    'End Sub



    Private Sub chkprndue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkprndue.CheckedChanged
        If chkprndue.Checked = True Then
            chksavings.Checked = False
        Else
            chksavings.Checked = True
        End If
    End Sub

    Private Sub chksavings_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksavings.CheckedChanged
        If chksavings.Checked = True Then
            chkprndue.Checked = False
        Else
            chkprndue.Checked = True
        End If
    End Sub

    'Private Sub chkfullpaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfullpaid.CheckedChanged
    '    SplashScreen.count = 0
    '    Control.CheckForIllegalCrossThreadCalls = False
    '    thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
    '    thread.Start()
    '    gen_amounts()
    '    compute_payment()
    '    SplashScreen.Close()
    'End Sub

    Private Sub txtadvprn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadvprn.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtadvprn.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtadvprn.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtadvprn.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(txtintdue, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cbo_collections_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        gen_amounts()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtref.Text.Trim = "" Then
            MsgBox("Reference cannot be empty!", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf txtref.Text.Length < 2 Then
            MsgBox("Reference must be greater than 2 characters.", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        Else

            insert_payment()
            'insert_GL()
            gen_amounts()

            txtref.Clear()
            txtadvprn.Text = 0
        End If
    End Sub

    Private Sub insert_GL()
        dtgrid_gl.Rows.Clear()

        dtgrid_gl.Rows.Add(txtgl.SelectedValue, "Loans Receivable", Double.Parse(txtintdue.Text) + Double.Parse(txtadv_int.Text) + Double.Parse(txtprnpaid.Text) + Double.Parse(txtadvprn.Text) + Double.Parse(txtsa_amount.Text) + Double.Parse(txtcf.Text), 0)
        If (Decimal.Parse(txtintdue.Text) + Decimal.Parse(txtadv_int.Text)) > 0 Then
            dtgrid_gl.Rows.Add(GL_income.ToString, "Interest income received from " & txtfullname.Text, 0, Decimal.Parse(txtintdue.Text) + Decimal.Parse(txtadv_int.Text))
        End If
        If (Decimal.Parse(txtprnpaid.Text) + Decimal.Parse(txtadvprn.Text)) > 0 Then
            dtgrid_gl.Rows.Add(GL_loans.ToString, "Loans receivable principal paid of " & txtfullname.Text, 0, Decimal.Parse(txtprnpaid.Text) + Decimal.Parse(txtadvprn.Text))
        End If
        If Decimal.Parse(txtsa_amount.Text) > 0 Then
            dtgrid_gl.Rows.Add(GL_sa.ToString, "Savings deposit of madam/sir " & txtfullname.Text, 0, txtsa_amount.Text)
        End If
        If Decimal.Parse(txtcf.Text) > 0 Then
            dtgrid_gl.Rows.Add(GL_cf.ToString, "Center fund received from " & txtfullname.Text, 0, txtcf.Text)
        End If

    End Sub

    Private Sub insert_payment()
        If MessageBox.Show("Click yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
            sql += "VALUES('" + memcode + "',"
            sql += "" + payno.ToString + ","
            sql += "'" + dttrn.Value + "',"
            sql += "'" + cbopay_type.Text + "',"
            sql += "'" + frm_members.dtgridloan_list.CurrentRow.Cells(0).Value + "',"
            sql += "" + amntdue.ToString + ","
            sql += "" + txtprnpaid.Text + ","
            sql += "0,"
            sql += "" + intdue.ToString + ","
            sql += "" + txtintdue.Text + ","
            sql += "" + txtadv_int.Text + ","
            sql += "" + txtsa_amount.Text + ","
            sql += "" + txtcf.Text + ","
            sql += "0,"
            sql += "0,"
            sql += "'" + txtref.Text + "',"
            sql += "'" + txtref.Text + "',"
            sql += "'" + user.ToString + "',"
            sql += "'" + dttrn.Value + "',"
            sql += "'" + time.ToString + "',"
            sql += "'N',"
            sql += "'" + txtcoll_date.Text + "',"
            sql += "" + txtadvprn.Text + ","
            sql += "" + Decimal.Parse(lblprnbal.Text).ToString + ","
            sql += "" + Decimal.Parse(lblintbal.Text).ToString + ""
            sql += ")"
            'MsgBox(sql.ToString)
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            'If Not productcode = "CL" Then
            If Double.Parse(txtsa_amount.Text) <> 0 Then
                '    conn()
                '    sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                '    cmd = New SqlCommand(sql, myConn)
                '    myConn.Open()
                '    rd = cmd.ExecuteReader
                '    If rd.Read Then
                '        Try
                '            postno = Double.Parse(rd("postno")) + 1
                '        Catch ex As Exception
                '            postno = 1
                '        End Try
                '    Else
                '        postno = 1
                '    End If
                '    rd.Close()
                '    myConn.Close()

                '    conn()
                '    sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,gl_sa,tdate) VALUES "
                '    sql += "('" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                '    sql += ",'" + dttrn.Value + "'"
                '    sql += "," + postno.ToString + ""
                '    sql += ",'CSH-CL'"
                '    sql += "," + txtsa_amount.Text + ",0"
                '    sql += ",'PS Collections'"
                '    sql += ",'" + txtref.Text + "'"
                '    sql += ",'" + user.ToString + "'"
                '    sql += ",'" + GL_sa + "'"
                '    sql += ",'" + systemdate + "')"
                '    cmd = New SqlCommand(sql, myConn)
                '    myConn.Open()
                '    cmd.ExecuteNonQuery()
                '    myConn.Close()
                'MsgBox("Note: Savings account balance is affected by this entry.", MsgBoxStyle.Exclamation, "Important")
            End If
            'If Decimal.Parse(txtcf.Text) <> 0 Then
            '    insert_CF()
            'End If
            ''End If

            'If Double.Parse(lblprnbal.Text) < 1 And Double.Parse(lblintbal.Text) < 1 Then
            '    conn()
            '    sql = "UPDATE Loans SET status='O' WHERE pnnumber='" + txtlno.Text + "'"
            '    cmd = New SqlCommand(sql, myConn)
            '    myConn.Open()
            '    cmd.ExecuteNonQuery()
            '    myConn.Close()
            '    frm_members.view_member()
            '    'frm_members.bttnpost.Enabled = False
            '    'frm_members.bttnedit_payment.Enabled = False
            'End If
        End If
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose.Click
        Me.Close()
    End Sub

    Private Sub txtadv_int_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadv_int.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtadv_int.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtadv_int.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtadv_int.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(txtadv_int, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcf.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtcf.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtcf.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtcf.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(txtcbu, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtintdue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtintdue.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtintdue.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtintdue.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtintdue.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(txtsa_amount, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsa_amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsa_amount.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtsa_amount.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtsa_amount.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtsa_amount.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(txtcf, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub
End Class