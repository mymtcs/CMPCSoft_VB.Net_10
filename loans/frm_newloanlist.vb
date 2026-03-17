Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports System.ComponentModel
Imports Telerik.WinControls.Data

Public Class frm_newloanlist
    Public Event ColumnHeaderMouseClick As DataGridViewCellMouseEventHandler
    Dim postID As Integer = 0
    Dim acctcode As String
    Dim saamnt As Decimal = 0
    Dim cbu As Decimal = 0
    Dim offset As Decimal = 0
    Dim bypass As Boolean = False

    Public Sub view_loanlist_HL()
        conn()
        dtgridloanlist.Rows.Clear()
        sql = "SELECT a.pnnumber,a.MemCode,b.Fullname,CONVERT(VARCHAR(10),a.Releasedate,101) As Releasedate,a.LoanAmnt,a.netproceeds,a.accountnumber,a.netproceeds,b.CBUAccount,Description=isnull((select Description from SubProducts where code=a.subproductcode),'none') FROM Loans a,Members b WHERE a.MemCode=b.MemCode and a.Released='N' AND a.status='A' AND a.GL_loans='" + txtloantype.SelectedValue + "' ORDER BY b.Fullname Asc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            dtgridloanlist.Rows.Add(False, rd("MemCode").ToString, rd("pnnumber").ToString, rd("Fullname").ToString, Date.Parse(rd("Releasedate")).ToString("M/dd/yyyy"), String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("LoanAmnt")), rd("accountnumber").ToString, "For Approval", rd("netproceeds"), rd("CBUAccount"), rd("Description"))
        End While
        myConn.Close()
        Dim ttlamnt As Decimal = 0
        For x As Integer = 0 To dtgridloanlist.Rows.Count - 1
            If dtgridloanlist.Rows(x).Cells(3).Value <> "" Then
                ttlamnt = Double.Parse(ttlamnt) + dtgridloanlist.Rows(x).Cells(5).Value
            End If
        Next
        lbl_ttlamnt.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlamnt)

        For x As Integer = 0 To dtgridloanlist.Rows.Count - 1
            If x Mod 2 Then
                dtgridloanlist.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Dim row As DataGridViewRow = dtgridloanlist.Rows(x)
            row.Height = 30
        Next
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype WHERE gl_loans in(select gl_loans from UserAssigned where userID='" + user.ToString + "') order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("-Select-", "-Select-")
        While (rd.Read())
            table1.Rows.Add(rd("gl_loans").ToString, rd("loandesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtloantype.DataSource = table1
        Me.txtloantype.AutoFilter = True
        txtloantype.DisplayMember = "Description"
        txtloantype.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtloantype.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtloantype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtloantype.EditorControl.Columns(0).Width = 90
        Me.txtloantype.EditorControl.Columns(1).Width = 200
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub

    Private Sub frm_newloanlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        gen_loantype()
        view_loanlist_HL()
    End Sub

    'Private Sub dtgridloanlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If dtgridloanlist.CurrentRow.Cells(4).Value <> systemdate Then
    '        MsgBox("Loan number " & dtgridloanlist.CurrentRow.Cells(2).Value & " cannot be release. Date of releases must match the transaction date", MsgBoxStyle.Exclamation, "Invalid")
    '    End If
    'End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        If txtloantype.SelectedValue = "-Select-" Then
            MsgBox("Please select loan type.", MsgBoxStyle.Exclamation, "Message")
        Else
            GL_loans = txtloantype.SelectedValue
            select_grptype()
            If grouptype = "Y" And multiproduct = "N" Then
                frm_loanProcess_grp.Text = "New Loan"
                'frm_loanProcess_grp.txtmember.Enabled = True
                frm_loanProcess_grp.ShowDialog()
            ElseIf multiproduct = "Y" Then
                frm_loanProcess_commodity.Text = "New Loan"
                ' frm_loanProcess_commodity.txtmember.Enabled = True
                frm_loanProcess_commodity.ShowDialog()
            Else
                frm_loanProcess_indv.Text = "New Loan"
                frm_loanProcess_indv.ShowDialog()
                'frm_loanProcess_teachers.Text = "New Loan"
                'frm_loanProcess_teachers.ShowDialog()
            End If
        End If
    End Sub

    'Private Sub bttnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnedit.Click
    '    loannumber = dtgridloanlist.CurrentRow.Cells(2).Value
    '    member_code = dtgridloanlist.CurrentRow.Cells(1).Value
    '    GL_loans = txtloantype.SelectedValue
    '    select_grptype()
    '    If grouptype = "Y" And multiproduct = "N" Then
    '        frm_loanProcess_grp.Text = "Edit Loan"
    '        frm_loanProcess_grp.txtlno.Text = dtgridloanlist.CurrentRow.Cells(2).Value
    '        frm_loanProcess_grp.txtmember.Enabled = False
    '        frm_loanProcess_grp.ShowDialog()
    '    ElseIf multiproduct = "Y" Then
    '        frm_loanProcess_commodity.Text = "Edit Loan"
    '        frm_loanProcess_commodity.txtmember.Enabled = True
    '        frm_loanProcess_commodity.ShowDialog()
    '    Else
    '        frm_loanProcess_indv.Text = "Edit Loan"
    '        frm_loanProcess_indv.txtlno.Text = dtgridloanlist.CurrentRow.Cells(2).Value
    '        frm_loanProcess_indv.ShowDialog()
    '    End If
    'End Sub

    Private Sub bttnuncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
            dtgridloanlist.Rows(i).Cells.Item("rel").Value = False
        Next
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are you sure you want to cancel this loan(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
                If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                    conn()
                    sql = "UPDATE Loans SET status='X' WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Cancel the Pnnumber " & dtgridloanlist.CurrentRow.Cells(2).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "DELETE FROM Loansched WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "DELETE FROM Loansdeduction WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "DELETE FROM LoanItems WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                End If
            Next
            view_loanlist_HL()
        End If
    End Sub

    Private Sub bttnrel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrel.Click
        Dim countchecked As Integer = 0

        Dim lnLoanBalance As Double = 0
        txtLoanBalance.Text = lnLoanBalance 'initialize loan balance

        For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
            If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                countchecked = countchecked + 1
            End If
        Next
        If countchecked = 0 Then
            MsgBox("Please select loan(s).", MsgBoxStyle.Exclamation, "Message")
        Else
            If multiproduct = "N" Or dtgridloanlist.CurrentRow.Cells(10).Value = "Special Loan" Then
                If dtgridloanlist.CurrentRow.Cells(0).Value = True Then
                    Dim netproceeds As Decimal = 0
                    conn()

                    sql = "select a.gl_loans from loantype a, loans b where a.gl_loans=b.gl_loans and pnnumber='" + dtgridloanlist.CurrentRow.Cells(2).Value + "'"
                    sql = "select x.* from(select a.gl_loans,a.netproceeds,"
                    sql += "savings=isnull((select sum(amount) from LoansDeduction where Acro = 'SV' and pnnumber=a.pnnumber),0),"
                    sql += "offset=isnull((select sum(amount) from LoansDeduction where Acro = 'OFS' and pnnumber=a.pnnumber),0),"
                    sql += "cbu=isnull((select sum(amount) from LoansDeduction where Acro = 'CBU' and pnnumber=a.pnnumber),0)"
                    sql += "from loans a where a.pnnumber='" + dtgridloanlist.CurrentRow.Cells(2).Value + "')x"

                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    rd = cmd.ExecuteReader
                    If rd.Read Then
                        lblacct_code.Text = rd("gl_loans").ToString
                        saamnt = rd("savings").ToString
                        cbu = rd("cbu").ToString
                        offset = rd("offset")
                        netproceeds = rd("netproceeds").ToString
                        txtfname.Text = dtgridloanlist.CurrentRow.Cells(3).Value
                        txtnetproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", netproceeds)
                    End If
                    rd.Close()
                    myConn.Close()

                    'add to datagrid GL
                    dtgrid_gl.Rows.Clear()
                    conn()

                    sql = "select b.GLaccount,a.Amount,a.Description from LoansDeduction a, DeductionMF b where a.code=b.code and a.pnnumber='" + dtgridloanlist.CurrentRow.Cells(2).Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    rd = cmd.ExecuteReader

                    While rd.Read
                        dtgrid_gl.Rows.Add(rd("GLaccount").ToString, rd("Description").ToString, 0, rd("Amount").ToString)

                        'get the amount balance
                        If rd("Description").ToString = "Loan Balance" Then
                            lnLoanBalance = rd("Amount")
                            txtLoanBalance.Text = lnLoanBalance
                            MessageBox.Show(rd("Amount").ToString)
                        Else
                            txtLoanBalance.Text = lnLoanBalance
                        End If

                    End While

                    'add loan balance


                    dtgrid_gl.Rows.Add("1003-1", "Net proceeds of " & txtfname.Text, 0, txtnetproceeds.Text)
                    dtgrid_gl.Rows.Add(txtloantype.SelectedValue, "Loans Receivable", dtgridloanlist.CurrentRow.Cells(5).Value.ToString, 0)
                    rd.Close()
                    myConn.Close()

                    'bttnuncheck.Enabled = False
                    'bttnvouch.Enabled = False
                    bttnrefresh.Enabled = False
                    bttnnew.Enabled = False
                    bttnrel.Enabled = True
                    pn_voucher.Visible = True
                    dtgridloanlist.Enabled = False
                    pn_voucher.Enabled = True
                    txtvoucher_no.Focus()
                End If
            Else
                MsgBox("There are " & countchecked & " selected loan to release.", MsgBoxStyle.Exclamation, "Message")
                release(txtLoanBalance.Text)
            End If
        End If
    End Sub


    Private Sub RadButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton4.Click
        pn_voucher.Visible = False
        dtgridloanlist.Enabled = True
        'bttnuncheck.Enabled = True

        bttnrefresh.Enabled = True
        bttnnew.Enabled = True
        bttnrel.Enabled = True
    End Sub

    Private Sub bttn_cont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cont.Click

        ' MessageBox.Show("Release Loan button")

        conn()
        sql = "SELECT pnnumber FROM Loansched WHERE pnnumber='" + dtgridloanlist.CurrentRow.Cells(2).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then

            If systemdate <> Date.Parse(dtgridloanlist.CurrentRow.Cells(4).Value).ToString("M/d/yyyy") Then
                MsgBox("Invalid release date.", MsgBoxStyle.Exclamation, "Invalid")
            ElseIf txtvoucher_no.Text.Trim = "" Then
                MsgBox("Voucher No. cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            Else
                ' MessageBox.Show("Goto release()")
                release(txtLoanBalance.Text)

            End If
        Else
            MsgBox("Please generate the schedule of this loan.", MsgBoxStyle.Exclamation, "Notification")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub release(ByVal pnLoanBalance As Double)
        Dim cRenew_LoanNumber As String
        Dim cLoanNumber As String
        Dim lcMemcode As String
        Dim lcTrnxdate As String


        cRenew_LoanNumber = ""
        cLoanNumber = ""
        lcMemcode = ""
        lcTrnxdate = ""

        If MessageBox.Show("Are you sure you want to release this loan(s)?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'Try
            For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
                If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                    If Date.Parse(dtgridloanlist.Rows(i).Cells(4).Value).ToString("M/d/yyyy") = systemdate Or bypass = True Then


                        cLoanNumber = dtgridloanlist.Rows(i).Cells(2).Value
                        lcTrnxdate = dtgridloanlist.Rows(i).Cells(4).Value.ToString

                        'MessageBox.Show((cLoanNumber, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        'MsgBox(cLoanNumber, MsgBoxStyle.Exclamation, "Loan Number")

                        conn()
                        sql = "SELECT pnnumber FROM Loansched WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        rd = cmd.ExecuteReader
                        If rd.Read Then
                            Try
                                ' MessageBox.Show(sql)
                                ' MessageBox.Show(saamnt)

                                If saamnt > 0 Then
                                    ' MessageBox.Show("insert_savings()")
                                    insert_savings()
                                End If

                                If cbu > 0 Then
                                    insert_cbu()
                                End If

                                If offset > 0 Then
                                    insert_offset_account()
                                End If
                            Catch ex As Exception

                            End Try
                            'do whatever you need to do.
                            Try
                                select_grptype()
                                If multiproduct = "Y" Then
                                    conn()
                                    sql = "UPDATE LoanItems SET TrnDate='" + dtgridloanlist.Rows(i).Cells(4).Value + "' WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                                    cmd = New SqlCommand(sql, myConn)
                                    myConn.Open()
                                    cmd.ExecuteNonQuery()
                                    myConn.Close()
                                    If dtgridloanlist.CurrentRow.Cells(10).Value = "Special Loan" Then
                                        conn()
                                        sql = "INSERT INTO CashiersTransaction(Payee,Debit,Credit,Reference,Trndate,Ttime,UserID,GLaccount,Remarks,AcctReference) VALUES ('" + txtfname.Text + "',0," + Double.Parse(txtnetproceeds.Text).ToString + ",'" + txtvoucher_no.Text + "','" + systemdate + "','" + time.ToString + "','" + user.ToString + "','" + lblacct_code.Text + "','Loan Release','" + dtgridloanlist.Rows(i).Cells(6).Value + "')"
                                        cmd = New SqlCommand(sql, myConn)
                                        myConn.Open()
                                        cmd.ExecuteNonQuery()
                                        myConn.Close()
                                    End If
                                Else
                                    conn()
                                    sql = "INSERT INTO CashiersTransaction(Payee,Debit,Credit,Reference,Trndate,Ttime,UserID,GLaccount,Remarks,AcctReference) VALUES ('" + txtfname.Text + "',0," + Double.Parse(txtnetproceeds.Text).ToString + ",'" + txtvoucher_no.Text + "','" + systemdate + "','" + time.ToString + "','" + user.ToString + "','" + lblacct_code.Text + "','Loan Release','" + dtgridloanlist.Rows(i).Cells(6).Value + "')"
                                    cmd = New SqlCommand(sql, myConn)
                                    myConn.Open()
                                    cmd.ExecuteNonQuery()
                                    myConn.Close()
                                End If



                                conn()
                                sql = "UPDATE Loans SET Released='Y' WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                                cmd = New SqlCommand(sql, myConn)
                                myConn.Open()
                                cmd.ExecuteNonQuery()
                                myConn.Close()




                                'renewal
                                'mark loan as Paid after renewal, set status as 'O'
                                'sql = "SELECT renewloannumber FROM Loans WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                                'cmd = New SqlCommand(sql, myConn)

                                'conn()
                                'myConn.Open()
                                'rd = cmd.ExecuteReader
                                'If rd.Read Then
                                'cRenew_LoanNumber = rd("renewloannumber").ToString
                                'End If
                                'myConn.Close()

                                conn()
                                'sql = "SELECT pnnumber FROM Loansched WHERE pnnumber='" + dtgridloanlist.CurrentRow.Cells(2).Value + "'"
                                sql = "SELECT renewloannumber, memcode FROM Loans WHERE pnnumber='" + cLoanNumber + "'"
                                cmd = New SqlCommand(sql, myConn)
                                myConn.Open()
                                rd = cmd.ExecuteReader
                                If rd.Read Then

                                    'MessageBox.Show(rd("renewloannumber").ToString)
                                    cRenew_LoanNumber = rd("renewloannumber").ToString
                                    lcMemcode = rd("memcode").ToString

                                End If


                                'mark as paid
                                conn()
                                If cRenew_LoanNumber <> "" Then
                                    sql = "UPDATE Loans SET status ='O' WHERE pnnumber='" + cRenew_LoanNumber + "'"
                                    cmd = New SqlCommand(sql, myConn)
                                    myConn.Open()
                                    cmd.ExecuteNonQuery()
                                End If
                                myConn.Close()

                                'mark payment 
                                If cRenew_LoanNumber <> "" Then

                                    'MsgBox("gen_amounts_renew(cRenew_LoanNumber, lcTrnxdate)", MsgBoxStyle.Exclamation, "Notification")
                                    gen_amounts_renew(cRenew_LoanNumber, lcTrnxdate, pnLoanBalance)

                                End If


                                'insert_gl()

                                cbu = 0
                                saamnt = 0
                                txtvoucher_no.Text.ToString.Replace(" ", "")

                                conn()
                                sql = "INSERT INTO logs (PnNumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Released loan number " & dtgridloanlist.Rows(i).Cells(2).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                                cmd = New SqlCommand(sql, myConn)
                                myConn.Open()
                                cmd.ExecuteNonQuery()
                                myConn.Close()
                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
                                'txtvoucher_no.Clear()
                                'GoTo a
                            End Try
                        End If
                        rd.Close()
                        myConn.Close()
                    Else
                        'message
                        MessageBox.Show("No release")
                    End If
                End If
            Next
a:
            pn_voucher.Visible = False
            dtgridloanlist.Enabled = True
            view_loanlist_HL()
            'bttnuncheck.Enabled = True
            'bttnvouch.Enabled = True
            bttnrefresh.Enabled = True
            bttnnew.Enabled = True
            bttnrel.Enabled = True
            bypass = False
        End If
    End Sub


    Private Sub insert_savings()
        Dim postno As Integer
        For i As Integer = 0 To dtgridloanlist.Rows.Count - 1

            'MessageBox.Show(" Private Sub insert_savings()")

            If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                conn()
                sql = "SELECT max(postno) as postno FROM AccountLedger WHERE Accountnumber='" + dtgridloanlist.Rows(i).Cells(6).Value + "' ORDER BY postno DESC"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader

                If rd.Read Then
                    Try
                        postno = Double.Parse(rd("postno")) + 1
                    Catch ex As Exception
                        postno = 1
                    End Try
                Else
                    postno = 1
                End If
                rd.Close()
                myConn.Close()


                ' DISPLAY THE GL_SA VALUE
                ' MsgBox(GL_sa)
                ' MessageBox.Show(dtgridloanlist.Rows(i).Cells(6).Value)

                ' GET THE accountmaster table GL_sa field
                conn()
                sql = "SELECT a.GL_sa, a.AccountNumber  FROM accountmaster a where a.accountnumber='" + dtgridloanlist.Rows(i).Cells(6).Value + "' "
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    ' GL_sa = rd("GL_sa").ToString
                    AccountMaster_GL_sa = rd("GL_sa").ToString
                End If
                rd.Close()
                myConn.Close()

                ' MessageBox.Show("AccountMaster_GL_sa " & AccountMaster_GL_sa & " Account Number " & dtgridloanlist.Rows(i).Cells(6).Value)

                conn()
                sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,tdate,GL_sa,Active) VALUES "
                sql += "('" + dtgridloanlist.Rows(i).Cells(6).Value + "',"
                sql += "'" + systemdate + "',"
                sql += "" + postno.ToString + ","
                sql += "'CM',"
                sql += "" + saamnt.ToString + ","
                sql += "0,"
                sql += "'Loan Release',"
                sql += "'" + txtvoucher_no.Text + "',"
                sql += "'" + user.ToString + "',"
                sql += "'" + systemdate + "',"
                'sql += "'" + GL_sa + "','Y'"
                sql += "'" + AccountMaster_GL_sa + "','Y'"
                sql += ")"
                cmd = New SqlCommand(sql, myConn)

                'MessageBox.Show(sql)

                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub insert_cbu()
        Dim postno As Integer
        For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
            If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                conn()
                sql = "SELECT isnull((max(postno)),0) as postno FROM CBULedger WHERE CBUAccount='" + dtgridloanlist.Rows(i).Cells(9).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    Try
                        postno = Double.Parse(rd("postno")) + 1
                    Catch ex As Exception
                        postno = 1
                    End Try
                Else
                    postno = 1
                End If
                rd.Close()
                myConn.Close()

                conn()
                sql = "INSERT INTO CBULedger(CBUAccount,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Reference,userid,tdate,Active,GL_loans) VALUES "
                sql += "('" + dtgridloanlist.Rows(i).Cells(9).Value + "',"
                sql += "'" + dtgridloanlist.CurrentRow.Cells(4).Value.ToString + "',"
                sql += "" + postno.ToString + ","
                sql += "'LR',"
                sql += "" + cbu.ToString + ","
                sql += "0,"
                sql += "'Loan Release',"
                sql += "'" + txtvoucher_no.Text + "',"
                sql += "'" + user.ToString + "',"
                sql += "'" + systemdate + "',"
                sql += "'Y',"
                sql += "'" + lblacct_code.Text + "'"
                sql += ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub insert_offset_account()
        conn()
        sql = "INSERT INTO LoanCollect "
        sql += "([Memcode]"
        sql += ",[pnnumber]"
        sql += ",[payno]"
        sql += ",[orcode]"
        sql += ",[trnxdate]"
        sql += ",[ornumber]"
        sql += ",[paytype]"
        sql += ",[remarks]"
        sql += ",[BranchCode]"
        sql += ",[prndue]"
        sql += ",[prnpaid]"
        sql += ",[principal]"
        sql += ",[AdvPrincipal]"
        sql += ",[prnduebalance]"
        sql += ",[intdue]"
        sql += ",[intpaid]"
        sql += ",[AdvInterest]"
        sql += ",[intduebalance]"
        sql += ",[CF]"
        sql += ",[savings]"
        sql += ",[PenaltyDue]"
        sql += ",[penpaid]"
        sql += ",[PenaltyBalance]"
        sql += ",[PDIDue]"
        sql += ",[pdipaid]"
        sql += ",[PDIBalance]"
        sql += ",[amtpaid]"
        sql += ",[totalCashAmnt]"
        sql += ",[totalCheckAmnt]"
        sql += ",[prnum]"
        sql += ",[userid]"
        sql += ",[tdate]"
        sql += ",[ttime]"
        sql += ",[cancel]"
        sql += ",[collectiondate]"
        sql += ",[ttlprnpaid]"
        sql += ",[ttlintpaid]"
        sql += ",[Reference]"
        sql += ",[LH]"
        sql += ",[SSSCont])"

        sql += " Select [Memcode] "
        sql += ",[pnnumber]"
        sql += ",[payno]"
        sql += ",'" & txtvoucher_no.Text & "'"
        sql += ",'" + dtgridloanlist.CurrentRow.Cells(4).Value.ToString + "'"
        sql += ",'" & txtvoucher_no.Text & "'"
        sql += ",[paytype]"
        sql += ",[remarks]"
        sql += ",[BranchCode]"
        sql += ",[prndue]"
        sql += ",[prnpaid]"
        sql += ",[principal]"
        sql += ",[AdvPrincipal]"
        sql += ",[prnduebalance]"
        sql += ",[intdue]"
        sql += ",[intpaid]"
        sql += ",[AdvInterest]"
        sql += ",[intduebalance]"
        sql += ",[CF]"
        sql += ",[savings]"
        sql += ",[PenaltyDue]"
        sql += ",[penpaid]"
        sql += ",[PenaltyBalance]"
        sql += ",[PDIDue]"
        sql += ",[pdipaid]"
        sql += ",[PDIBalance]"
        sql += ",[amtpaid]"
        sql += ",[totalCashAmnt]"
        sql += ",[totalCheckAmnt]"
        sql += ",'" & txtvoucher_no.Text & "'"
        sql += ",[userid]"
        sql += ",'" + dtgridloanlist.CurrentRow.Cells(4).Value.ToString + "'"
        sql += ",[ttime]"
        sql += ",'N'"
        sql += ",[collectiondate]"
        sql += ",[ttlprnpaid]"
        sql += ",[ttlintpaid]"
        sql += ",[Reference]"
        sql += ",[LH]"
        sql += ",[SSSCont]"
        sql += " FROM Offset_Payment WHERE memcode='" & dtgridloanlist.CurrentRow.Cells(1).Value & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        Dim pnnumber As String = ""
        conn()
        sql = "select pnnumber from Offset_Payment WHERE memcode='" & dtgridloanlist.CurrentRow.Cells(1).Value & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            pnnumber = rd("pnnumber")
        End If
        rd.Close()
        myConn.Close()

        If Not pnnumber = "" Then
            conn()
            sql = "UPDATE Loans SET status='O' WHERE pnnumber='" & pnnumber & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        End If

        conn()
        sql = "DELETE FROM Offset_Payment WHERE memcode='" & dtgridloanlist.CurrentRow.Cells(1).Value & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Private Sub txtvoucher_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvoucher_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            release(txtLoanBalance.Text)
        End If
    End Sub


    Private Sub bttnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrefresh.Click
        If multiproduct = "Y" And usertype <> "Cashier" Then
            bttnrel.Enabled = True
            bttnrel.Text = "Released"
        ElseIf multiproduct = "N" And usertype <> "Accounting" Then
            bttnrel.Text = "       View Voucher "
            If usertype = "Bookkeeper" Then
                bttnrel.Enabled = False
            Else
                bttnrel.Enabled = True
            End If
        End If
        view_loanlist_HL()
        bttnprint.Enabled = False
    End Sub

    Private Sub txtloantype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloantype.SelectedIndexChanged
        bttnrel.Enabled = True
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        view_loanlist_HL()
        If multiproduct = "Y" And usertype <> "Cashier" Then
            bttnrel.Text = "Released"
            bttnrel.Enabled = True
        ElseIf multiproduct = "N" And usertype <> "Accounting" Then
            bttnrel.Text = "       View Voucher "
            If usertype = "Bookkeeper" Then
                bttnrel.Enabled = False
            Else
                bttnrel.Enabled = True
            End If
        End If
        bttnprint.Enabled = False
    End Sub

    Private Sub dtgridloanlist_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridloanlist.CellClick
        loannumber = ""
        If Not multiproduct = "Y" Or usertype = "Cashier" Then
            Dim count As Integer = 0
            For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
                If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                    count = count + 1
                End If
                If count > 0 Then
                    dtgridloanlist.Rows(i).Cells(0).Value = False
                End If
            Next
        End If

        If dtgridloanlist.CurrentRow.Cells(0).Value = False Then
            dtgridloanlist.CurrentRow.Cells(0).Value = True
            loannumber = dtgridloanlist.CurrentRow.Cells(2).Value
        Else
            dtgridloanlist.CurrentRow.Cells(0).Value = False
        End If

        'If usertype = "Admin" Then
        '    If dtgridloanlist.CurrentRow.Cells(4).Value > systemdate And multiproduct = "Y" Then
        '        dtgridloanlist.CurrentRow.Cells(0).Value = False
        '    End If
        'Else
        '    If dtgridloanlist.CurrentRow.Cells(4).Value <> systemdate And multiproduct = "Y" Then
        '        dtgridloanlist.CurrentRow.Cells(0).Value = False
        '    End If
        'End If
        Dim countchecked As Integer = 0
        For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
            If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                countchecked = countchecked + 1
            End If
        Next
        If countchecked = 0 Then
            bttnprint.Enabled = False
        Else
            bttnprint.Enabled = True
        End If

        If Date.Parse(dtgridloanlist.CurrentRow.Cells(4).Value).ToString("M/d/yyyy") = systemdate Then
            bttn_cont.Enabled = True
        Else
            If usertype <> "Admin" Then
                bttn_cont.Enabled = False
            Else
                bttn_cont.Enabled = True
            End If
        End If
    End Sub

    Private Sub dtgridloanlist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgridloanlist.KeyDown
        If e.KeyCode = Keys.Space Then
            loannumber = dtgridloanlist.CurrentRow.Cells(2).Value
            If Not multiproduct = "Y" Then
                Dim count As Integer = 0
                'Try
                For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
                    If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                        count = count + 1
                    End If
                    If count > 0 Then
                        dtgridloanlist.Rows(i).Cells(0).Value = False
                    End If
                Next
                dtgridloanlist.CurrentRow.Cells(0).Value = True
                loannumber = dtgridloanlist.CurrentRow.Cells(2).Value
            Else
                If dtgridloanlist.CurrentRow.Cells(0).Value = False Then
                    dtgridloanlist.CurrentRow.Cells(0).Value = True
                Else
                    dtgridloanlist.CurrentRow.Cells(0).Value = False
                End If
            End If
        End If
    End Sub

    Private Sub RadMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem1.Click
        frm_printvouch.generate_voucher()
        frm_printvouch.crv.PrintReport()
        'frm_printvouch.Show()
    End Sub

    Private Sub RadMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem2.Click
        frm_disclosure.ShowDialog()
    End Sub

    Private Sub RadMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem3.Click
        frm_amortsched.ShowDialog()
    End Sub

    Private Sub RadMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem4.Click
        frm_promisorry_note.ShowDialog()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        frm_add_comaker.ShowDialog()
    End Sub

    Private Sub bttncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        Dim count As Integer = 0
        For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
            If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                count = count + 1
            End If
        Next
        If count = 0 Then
            MsgBox("Please select loan(s) to cancel", MsgBoxStyle.Exclamation, "Message")
        Else
            If MessageBox.Show("Are you sure you want to cancel this loan(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To dtgridloanlist.Rows.Count - 1
                    If dtgridloanlist.Rows(i).Cells(0).Value = True Then
                        conn()
                        sql = "UPDATE Loans SET status='X' WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        conn()
                        sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Cancel the Pnnumber " & dtgridloanlist.CurrentRow.Cells(2).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        conn()
                        sql = "DELETE FROM Loansched WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        conn()
                        sql = "DELETE FROM Loansdeduction WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        conn()
                        sql = "DELETE FROM LoanItems WHERE pnnumber='" + dtgridloanlist.Rows(i).Cells(2).Value + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                Next
                view_loanlist_HL()
            End If
        End If
    End Sub


    Private Sub bttnrenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton6.Click
        If txtloantype.SelectedValue = "-Select-" Then
            MsgBox("Please select loan type.", MsgBoxStyle.Exclamation, "Message")
        Else
            GL_loans = txtloantype.SelectedValue
            select_grptype()
            If grouptype = "Y" And multiproduct = "N" Then
                frm_loanProcess_grp.Text = "New Loan"
                'frm_loanProcess_grp.txtmember.Enabled = True
                frm_loanProcess_grp.ShowDialog()
            ElseIf multiproduct = "Y" Then
                frm_loanProcess_commodity.Text = "New Loan"
                ' frm_loanProcess_commodity.txtmember.Enabled = True
                frm_loanProcess_commodity.ShowDialog()
            Else
                frm_loanProcess_indv_renew.Text = "New Loan"
                frm_loanProcess_indv_renew.ShowDialog()
                'frm_loanProcess_teachers.Text = "New Loan"
                'frm_loanProcess_teachers.ShowDialog()
            End If
        End If
    End Sub




    Private Sub gen_amounts_renew(ByVal pcPNNumber As String, ByVal pcTrnxdate As String, ByVal pnLoan_Balance As Double)
        '// check the field data
        'MsgBox(cbo_collections.SelectedValue, MsgBoxStyle.DefaultButton1)
        'cbo_collections.SelectedValue && is from Pay No. combobox


        'MsgBox(pcPNNumber + pnLoan_Balance.ToString, MsgBoxStyle.Exclamation, "Gen Amount Renew FUNCTION !!!!!!!!")

        Dim cmemcode As String
        Dim ctxtfullname As String
        Dim nprndue As Double
        Dim nintdue As Double
        Dim nprnbal As Double
        Dim nintbal As Double
        Dim nlife As Double
        Dim ccbopay_type As String
        Dim np_savings As String
        Dim ncf As Double
        Dim cpayno As Integer
        Dim ntotal_amntpaid As Double
        Dim ntxtmain As Double
        Dim nprnamnt As Double

        cmemcode = ""
        ctxtfullname = ""
        nprndue = 0.0
        nintdue = 0.0
        nprnbal = 0.0
        nintbal = 0.0
        nlife = 0.0
        ccbopay_type = "DM"
        np_savings = 0.0
        ncf = 0.0
        cpayno = 0
        nprnamnt = 0.0
        ntotal_amntpaid = 0.0
        ntxtmain = 0.0             'total amount paid

        ' MemCode, pnnumber, grpcode, Fullname, interestdue, prnamnt, rngprin, rngint, lh  
        conn()
        sql = "SELECT a.MemCode,a.pnnumber,a.grpcode,c.Fullname,"

        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber= a.pnnumber),0),"

        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber= a.pnnumber ),0),"

        sql += "rngprin=isnull(((select sum(principal) from loansched where pnnumber= a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(principal+advprincipal) FROM loancollect where pnnumber= a.pnnumber),0)),0),"

        sql += "rngint=isnull(((select sum(interest) from loansched where pnnumber= a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(intpaid+advinterest) FROM loancollect where pnnumber= a.pnnumber ),0)),0),"

        sql += "b.principal,b.interest,b.savings,cf=isnull((b.cf),0),"

        sql += "lh=isnull(((select sum(lh) from loansched where pnnumber= a.pnnumber and duedate<=b.duedate and duedate >= '2021-10-01 00:00:00')-isnull((SELECT SUM(lh) FROM loancollect where pnnumber= a.pnnumber ),0)),0),"

        sql += "ttlprnpaid=isnull((select SUM(principal+advprincipal) from LoanCollect where pnnumber= a.pnnumber ),0),"

        sql += "ttlintpaid=isnull((select SUM(intpaid+AdvInterest) from LoanCollect where pnnumber= a.pnnumber ),0),"

        sql += "payno=isnull((select count(payno)+1 from loancollect where pnnumber= a.pnnumber ),1)"

        sql += "FROM  Loans a,Loansched b, Members c "

        'this is original
        'sql += "WHERE a.pnnumber=b.pnnumber AND a.memcode=c.memcode AND a.pnnumber='" + pcPNNumber + "' AND a.status='A' and b.duedate='" + cbo_collections.SelectedValue + "' "

        'tangtangun natu ang duedate
        sql += "WHERE a.pnnumber=b.pnnumber AND a.memcode=c.memcode AND a.pnnumber='" + pcPNNumber + "' "
        sql += "GROUP BY a.memcode,a.pnnumber,c.Fullname,a.interestdue,a.grpcode,b.principal,b.interest,b.savings,b.cf,b.lh,b.duedate"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            'txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value.ToString
            cmemcode = rd("MemCode").ToString
            ctxtfullname = rd("Fullname").ToString
            nprndue = Double.Parse(rd("rngprin"))
            nintdue = Double.Parse(rd("rngint"))
            nprnbal = Double.Parse(rd("prnamnt")) - Double.Parse(rd("ttlprnpaid"))
            nintbal = Double.Parse(rd("interestdue")) - Double.Parse(rd("ttlintpaid"))
            nlife = Double.Parse(rd("LH"))
            nprnamnt = Double.Parse(rd("prnamnt"))

            If ccbopay_type = "DM" Or ccbopay_type = "RENEW" Then
                np_savings = 0
            Else
                ncf = rd("CF")
                np_savings = rd("savings")
            End If
            cpayno = rd("payno").ToString
        End If
        rd.Close()
        myConn.Close()

        'txt7.Text = prndue.ToString ' 
        'txt5.Text = intdue.ToString
        'txt2.Text = cf.ToString
        'txt3.Text = life.ToString
        'txt1.Text = p_savings.ToString

        ' total amount payable or due
        ntotal_amntpaid = nprndue + nintdue + nlife + ncf + np_savings ' total amount payable or amount due
        ntxtmain = ntotal_amntpaid ' Total amount payable - principal + interest + c19 + savings

        'save to table loancollect

        'get all the data first, ug ang mga variables...
        'Dim lcPayno As String
        Dim lcRemarks As String
        'Dim lcPnnumber As String
        Dim lnPrincipal As Double

        'lcPayno = ""
        lcRemarks = "RENEW"
        'lcPnnumber = cRenew_LoanNumber
        lnPrincipal = nprnamnt

        Dim lnPrndue As Double
        Dim lnPrnpaid As Double
        Dim lnIntdue As Double
        Dim lnIntpaid As Double
        Dim lnAdvInterest As Double
        Dim lnSavings As Double
        Dim lnCF As Double
        Dim lnLH As Double
        Dim lnSSSCont As Double
        Dim lnPenpaid As Double
        Dim lnAmtpaid As Double
        Dim lcPrnum As String
        Dim lcOrnumber As String
        Dim lcUserid As String
        Dim lcTdate As String
        Dim lcTtime As String
        Dim lcCollectiondate As String
        Dim lnAdvPrincipal As Double
        Dim lnPrnduebalance As Double
        Dim lnIntduebalance As Double
        Dim lnPayno As Integer



        lnPrndue = nprndue ' total principal due
        lnPrnpaid = nprndue ' total principal paid
        lnIntdue = nintdue 'interest due
        lnIntpaid = nintdue 'interest paid
        lnLH = nlife ' life & health
        lnPayno = cpayno

        lnAdvInterest = 0.0
        lnSavings = np_savings
        lnCF = 0.0

        lnSSSCont = 0.0
        lnPenpaid = 0.0
        lnAmtpaid = ntxtmain 'total amount paid
        lcPrnum = ""
        lcOrnumber = ""
        lcUserid = ""
        lcTdate = ""
        lcTtime = ""
        lcCollectiondate = ""
        lnAdvPrincipal = 0.0
        lnPrnduebalance = 0.0
        lnIntduebalance = 0.0

        'insert payment to loan collect 
        'prndue, prnpaid, intdue, intpaid, savings,CF,LH, amtpaid, prnduebalance,intduebalance
        'MsgBox("insert_payment_renew", MsgBoxStyle.Exclamation, "insert_payment_renew")
        'insert_payment_renew(cmemcode, lnPayno, pcTrnxdate, lcRemarks, pcPNNumber, lnPrndue, lnPrincipal, lnPrnpaid, lnIntdue, lnIntpaid, lnAdvInterest, lnSavings, lnCF, lnLH, lnSSSCont, lnPenpaid, lnAmtpaid, lcPrnum, lcOrnumber, lcUserid, lcTdate, lcTtime, lcCollectiondate, lnAdvPrincipal, lnPrnduebalance, lnIntduebalance)
        'pnLoan_Balance() as amount paid
        insert_payment_renew(cmemcode, lnPayno, pcTrnxdate, lcRemarks, pcPNNumber, lnPrndue, lnPrincipal, lnPrnpaid, lnIntdue, lnIntpaid, lnAdvInterest, lnSavings, lnCF, lnLH, lnSSSCont, lnPenpaid, pnLoan_Balance, lcPrnum, lcOrnumber, lcUserid, lcTdate, lcTtime, lcCollectiondate, lnAdvPrincipal, lnPrnduebalance, lnIntduebalance)



        'compute_payment()
    End Sub


    'this module will insert payment to loancollect table
    'modified: 11/26/2024 by Windel Tonacao
    Private Sub insert_payment_renew(ByVal pcMemcode As String, ByVal pnPaynoX As Double, ByVal pcTrnxdate As String, ByVal pcRemarks As String, ByVal pcPnnumber As String, ByVal pnPrndue As Double, ByVal pnPrincipal As Double, ByVal pnPrnpaid As Double, ByVal pnIntdue As Double, ByVal pnIntpaid As Double, ByVal pnAdvInterest As Double, ByVal pnSavings As Double, ByVal pnCF As Double, ByVal pnLH As Double, ByVal pnSSSCont As Double, ByVal pnPenpaid As Double, ByVal pnAmtpaid As Double, ByVal pcPrnum As String, ByVal pcOrnumber As String, ByVal pcUserid As String, ByVal pcTdate As String, ByVal pcTtime As String, ByVal pcCollectiondate As String, ByVal pnAdvPrincipal As Double, ByVal pnPrnduebalance As Double, ByVal pnIntduebalance As Double)

        Dim lnPostno As Integer
        lnPostno = 0

        'MsgBox("INSIDE insert_payment_renew", MsgBoxStyle.Exclamation, "INSIDE insert_payment_renew FUNCTION!!!!")
        'MsgBox(pnPaynoX.ToString)

        'important columns
        'prndue, prnpaid, intdue, intpaid, savings,CF,LH, amtpaid, prnduebalance,intduebalance
        conn() 'myconn

        'sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,LH,SSSCont,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
        'sql += "VALUES('" + pcMemcode + "'," 
        'sql += "" + pnPayno + ","   'payno
        'sql += "'" + pcTrnxdate + "',"    'trnxdate   
        'sql += "'" + pcRemarks + "'," 'remarks
        'sql += "'" + pcPnnumber + "'," 'pnnumber
        'sql += "" + pnPrndue.ToString + "," 'prndue
        'sql += "" + pnPrincipal.ToString + "," 'principal
        'sql += "" + pnPrnpaid.ToString + "," 'prnpaid
        'sql += "" + pnIntdue.ToString + "," 'intdue
        'sql += "" + pnIntpaid.ToString + "," 'intpaid
        'sql += "" + pnAdvInterest.ToString + "," 'AdvInterest
        'sql += "" + pnSavings.ToString + "," 'savings
        'sql += "" + pnCF.ToString + "," 'CF
        'sql += "" + pnLH.ToString + "," 'LH
        'sql += "" + pnSSSCont.ToString + "," 'SSSCont
        'sql += "" + pnPenpaid.ToString + "," 'penpaid
        'sql += "" + pnAmtpaid.ToString + "," 'amtpaid
        'sql += "'" + pcPrnum + "'," 'prnum
        'sql += "'" + pcOrnumber + "'," 'ornumber
        'sql += "'" + pcUserid + "'," 'userid
        'sql += "'" + pcTdate + "',"
        'sql += "'" + pcTtime + "',"
        'sql += "'N',"
        'sql += "'" + pcCollectiondate + "',"
        'sql += "" + pnAdvPrincipal + ","
        'sql += "" + pnPrnduebalance.ToString + ","
        'sql += "" + pnIntduebalance.ToString + ""
        'sql += ")"


        'pcMemcode

        'sql = "INSERT INTO LoanCollect(memcode, payno ) "
        sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,LH,SSSCont,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
        sql += "VALUES('" + pcMemcode + "',"
        sql += pnPaynoX.ToString + ","   'payno
        sql += "'" + pcTrnxdate + "',"    'trnxdate   
        sql += "'" + pcRemarks + "'," 'remarks
        sql += "'" + pcPnnumber + "'," 'pnnumber
        sql += "" + pnPrndue.ToString + "," 'prndue
        sql += "" + pnPrincipal.ToString + "," 'principal
        sql += "" + pnPrnpaid.ToString + "," 'prnpaid
        sql += "" + pnIntdue.ToString + "," 'intdue
        sql += "" + pnIntpaid.ToString + "," 'intpaid
        sql += "" + pnAdvInterest.ToString + "," 'AdvInterest
        sql += "" + pnSavings.ToString + "," 'savings
        sql += "" + pnCF.ToString + "," 'CF
        sql += "" + pnLH.ToString + "," 'LH
        sql += "" + pnSSSCont.ToString + "," 'SSSCont
        sql += "" + pnPenpaid.ToString + "," 'penpaid
        sql += "" + pnAmtpaid.ToString + "," 'amtpaid
        sql += "'" + pcPrnum + "'," 'prnum
        sql += "'" + pcOrnumber + "'," 'ornumber
        sql += "'" + pcUserid + "'," 'userid
        sql += "'" + pcTdate + "',"
        sql += "'" + pcTtime + "',"
        sql += "'N',"
        sql += "'" + pcCollectiondate + "',"
        sql += "" + pnAdvPrincipal.ToString + ","
        sql += "" + pnPrnduebalance.ToString + ","
        sql += "" + pnIntduebalance.ToString + ""
        sql += ")"

        'display query
        'MsgBox(sql.ToString)

        'MessageBox.Show("txtmain.Text " + txtmain.Text)

        cmd = New SqlCommand(sql, myConn)
        ' off sa, dili natu e execute kay mo gamit ta ug stored procedure 12/26/2024
        'myConn.Open()
        'cmd.ExecuteNonQuery()
        'myConn.Close()

        If pcRemarks = "DM" Or pcRemarks = "RENEW" Then 'cbopay_type.Text
            If pnAmtpaid > 0 Then ' Double.Parse(txtmain.Text)
                conn()
                sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    Try
                        lnPostno = Double.Parse(rd("postno")) + 1
                    Catch ex As Exception
                        lnPostno = 1
                    End Try
                Else
                    lnPostno = 1
                End If
                rd.Close()
                myConn.Close()
                Dim remarks As String = "RENEW-" & pcPnnumber
                conn()
                sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,gl_sa,tdate,Active) VALUES "
                sql += "('" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                sql += ",'" + pcTrnxdate + "'"
                sql += "," + lnPostno.ToString + ""
                sql += ",'DM'"
                sql += ",0," + pnAmtpaid.ToString + ""
                sql += ",'" + remarks.ToString + "'"
                sql += ",'" + txtref.Text + "'"
                sql += ",'" + user.ToString + "'"
                sql += ",'" + GL_sa + "'"
                sql += ",'" + systemdate + "','Y')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            'If Decimal.Parse(txtcf.Text) > 0 Then
            '    insert_CF()
            'End If
        End If


        'extract the date thru stored procedure
        Dim cmdComputeInterest As New SqlCommand

        Dim cmdApplyPayment As New SqlCommand
        cmdApplyPayment.Connection = myConn
        cmdApplyPayment.CommandTimeout = 300
        cmdApplyPayment.CommandType = CommandType.StoredProcedure
        cmdApplyPayment.CommandText = "usp_RenewLoan_HK"


        '@pnnumber AS VARCHAR(50), 
        '@orcode AS VARCHAR(50),
        '@trnxdate as VARCHAR(50),
        '@ornumber AS VARCHAR(50),
        '@paytype AS VARCHAR(1),
        '@remarks AS VARCHAR(200),
        '@amountpaid AS MONEY
        cmdApplyPayment.Parameters.AddWithValue("@pnnumber", pcPnnumber)
        cmdApplyPayment.Parameters.AddWithValue("@orcode", pcPrnum)
        cmdApplyPayment.Parameters.AddWithValue("@trnxdate", pcTrnxdate)
        cmdApplyPayment.Parameters.AddWithValue("@ornumber", pcOrnumber)
        cmdApplyPayment.Parameters.AddWithValue("@paytype", 1)
        cmdApplyPayment.Parameters.AddWithValue("@remarks", pcRemarks)
        cmdApplyPayment.Parameters.AddWithValue("@amountpaid", pnAmtpaid)



        'cmdComputeInterest.Parameters.AddWithValue("@dtfrom", dtfrom.Value.ToString)

        'cmdComputeInterest.Connection = myConn
        'cmdComputeInterest.CommandTimeout = 300
        'cmdComputeInterest.CommandType = CommandType.StoredProcedure
        'cmdComputeInterest.CommandText = "usp_Compute_ADB_Interest"


        'cmdComputeInterest.Parameters.AddWithValue("@dtfrom", dtfrom.Value.ToString)
        'cmdComputeInterest.Parameters.AddWithValue("@dtto", dtto.Value.ToString)
        'cmdComputeInterest.Parameters.AddWithValue("@gl_sa", txtsa.SelectedValue)
        'cmdComputeInterest.Parameters.AddWithValue("@InterestRate", 0.04)
        'cmdComputeInterest.Parameters.AddWithValue("@MaintainingBalance", 1000)

        myConn.Open()
        'rd = cmdComputeInterest.ExecuteReader(

        rd = cmdApplyPayment.ExecuteReader()

        'While (rd.Read())
        'Dim lvitem As New ListViewItem(rd(0).ToString())
        'For i As Integer = 1 To rd.FieldCount - 1
        'lvitem.SubItems.Add(rd(i).ToString())
        'Next
        'lstsa.Items.Add(lvitem)
        'reference = rd("ornumber")
        'End While
        rd.Close()
        myConn.Close()



    End Sub



    'this module will insert payment to loancollect table
    'modified: 11/26/2024 by Windel Tonacao
    Private Sub insert_payment_renew_orig(ByVal pcMemcode As String, ByVal pnPaynoX As Double, ByVal pcTrnxdate As String, ByVal pcRemarks As String, ByVal pcPnnumber As String, ByVal pnPrndue As Double, ByVal pnPrincipal As Double, ByVal pnPrnpaid As Double, ByVal pnIntdue As Double, ByVal pnIntpaid As Double, ByVal pnAdvInterest As Double, ByVal pnSavings As Double, ByVal pnCF As Double, ByVal pnLH As Double, ByVal pnSSSCont As Double, ByVal pnPenpaid As Double, ByVal pnAmtpaid As Double, ByVal pcPrnum As String, ByVal pcOrnumber As String, ByVal pcUserid As String, ByVal pcTdate As String, ByVal pcTtime As String, ByVal pcCollectiondate As String, ByVal pnAdvPrincipal As Double, ByVal pnPrnduebalance As Double, ByVal pnIntduebalance As Double)

        Dim lnPostno As Integer
        lnPostno = 0

        'MsgBox("INSIDE insert_payment_renew", MsgBoxStyle.Exclamation, "INSIDE insert_payment_renew FUNCTION!!!!")

        'MsgBox(pnPaynoX.ToString)

        'important columns
        'prndue, prnpaid, intdue, intpaid, savings,CF,LH, amtpaid, prnduebalance,intduebalance
        conn()
        'sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,LH,SSSCont,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
        'sql += "VALUES('" + pcMemcode + "'," 
        'sql += "" + pnPayno + ","   'payno
        'sql += "'" + pcTrnxdate + "',"    'trnxdate   
        'sql += "'" + pcRemarks + "'," 'remarks
        'sql += "'" + pcPnnumber + "'," 'pnnumber
        'sql += "" + pnPrndue.ToString + "," 'prndue
        'sql += "" + pnPrincipal.ToString + "," 'principal
        'sql += "" + pnPrnpaid.ToString + "," 'prnpaid
        'sql += "" + pnIntdue.ToString + "," 'intdue
        'sql += "" + pnIntpaid.ToString + "," 'intpaid
        'sql += "" + pnAdvInterest.ToString + "," 'AdvInterest
        'sql += "" + pnSavings.ToString + "," 'savings
        'sql += "" + pnCF.ToString + "," 'CF
        'sql += "" + pnLH.ToString + "," 'LH
        'sql += "" + pnSSSCont.ToString + "," 'SSSCont
        'sql += "" + pnPenpaid.ToString + "," 'penpaid
        'sql += "" + pnAmtpaid.ToString + "," 'amtpaid
        'sql += "'" + pcPrnum + "'," 'prnum
        'sql += "'" + pcOrnumber + "'," 'ornumber
        'sql += "'" + pcUserid + "'," 'userid
        'sql += "'" + pcTdate + "',"
        'sql += "'" + pcTtime + "',"
        'sql += "'N',"
        'sql += "'" + pcCollectiondate + "',"
        'sql += "" + pnAdvPrincipal + ","
        'sql += "" + pnPrnduebalance.ToString + ","
        'sql += "" + pnIntduebalance.ToString + ""
        'sql += ")"


        'pcMemcode

        'sql = "INSERT INTO LoanCollect(memcode, payno ) "
        sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,LH,SSSCont,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
        sql += "VALUES('" + pcMemcode + "',"
        sql += pnPaynoX.ToString + ","   'payno
        sql += "'" + pcTrnxdate + "',"    'trnxdate   
        sql += "'" + pcRemarks + "'," 'remarks
        sql += "'" + pcPnnumber + "'," 'pnnumber
        sql += "" + pnPrndue.ToString + "," 'prndue
        sql += "" + pnPrincipal.ToString + "," 'principal
        sql += "" + pnPrnpaid.ToString + "," 'prnpaid
        sql += "" + pnIntdue.ToString + "," 'intdue
        sql += "" + pnIntpaid.ToString + "," 'intpaid
        sql += "" + pnAdvInterest.ToString + "," 'AdvInterest
        sql += "" + pnSavings.ToString + "," 'savings
        sql += "" + pnCF.ToString + "," 'CF
        sql += "" + pnLH.ToString + "," 'LH
        sql += "" + pnSSSCont.ToString + "," 'SSSCont
        sql += "" + pnPenpaid.ToString + "," 'penpaid
        sql += "" + pnAmtpaid.ToString + "," 'amtpaid
        sql += "'" + pcPrnum + "'," 'prnum
        sql += "'" + pcOrnumber + "'," 'ornumber
        sql += "'" + pcUserid + "'," 'userid
        sql += "'" + pcTdate + "',"
        sql += "'" + pcTtime + "',"
        sql += "'N',"
        sql += "'" + pcCollectiondate + "',"
        sql += "" + pnAdvPrincipal.ToString + ","
        sql += "" + pnPrnduebalance.ToString + ","
        sql += "" + pnIntduebalance.ToString + ""
        sql += ")"

        'display query
        'MsgBox(sql.ToString)

        'MessageBox.Show("txtmain.Text " + txtmain.Text)

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        If pcRemarks = "DM" Then 'cbopay_type.Text
            If pnAmtpaid > 0 Then ' Double.Parse(txtmain.Text)
                conn()
                sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    Try
                        lnPostno = Double.Parse(rd("postno")) + 1
                    Catch ex As Exception
                        lnPostno = 1
                    End Try
                Else
                    lnPostno = 1
                End If
                rd.Close()
                myConn.Close()
                Dim remarks As String = "DM-" & pcPnnumber
                conn()
                sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,gl_sa,tdate,Active) VALUES "
                sql += "('" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                sql += ",'" + pcTrnxdate + "'"
                sql += "," + lnPostno.ToString + ""
                sql += ",'DM'"
                sql += ",0," + pnAmtpaid.ToString + ""
                sql += ",'" + remarks.ToString + "'"
                sql += ",'" + txtref.Text + "'"
                sql += ",'" + user.ToString + "'"
                sql += ",'" + GL_sa + "'"
                sql += ",'" + systemdate + "','Y')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            'If Decimal.Parse(txtcf.Text) > 0 Then
            '    insert_CF()
            'End If
        End If

        ' ORIGINAL CONDITION, LESS THAN 0 IS PAID UP
        ' If Double.Parse(lblprnbal.Text) < 1 And Double.Parse(lblintbal.Text) < 1 Then ' TURN OFF, MUST BE EQUAL TO ZERO BE PAID UP

        ' NEW DATA, MUST BE EQUAL TO ZERO TO BE PAID UP
        'If Double.Parse(lblprnbal.Text) = 0 And Double.Parse(lblintbal.Text) = 0 Then ' MUST BE EQUAL TO ZERO BE PAID UP

        'conn()
        'sql = "UPDATE Loans SET status='O' WHERE pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'cmd.ExecuteNonQuery()
        'myConn.Close()
        'frm_members.view_member()

        'End If



    End Sub


End Class