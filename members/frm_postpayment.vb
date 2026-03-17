Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_postpayment
    Dim memcode As String
    Dim prndue As Decimal = 0
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
    Dim life As Decimal = 0
    Dim saacct_CF As String
    Dim postnoCF As Integer = 0

    Private Sub frm_postpayment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_members.view_loanledger()
    End Sub

    Private Sub frm_postpayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' If usertype = "Admin" Then
        chk_auto_comp.Enabled = True
        'Else
        '    chk_auto_comp.Enabled = False
        'End If

        dttrn.Enabled = False
        dttrn.Value = systemdate '// TRANSACTION DATE

        txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value '// Loan Number
        GL_loans = frm_members.dtgrid_products.CurrentRow.Cells(0).Value    '// Loan Product

        select_grptype()

        If multiproduct = "Y" Then
            chksavings.Checked = False
            chkprndue.Checked = True
            chkprndue.Enabled = False
            chksavings.Enabled = False
        Else
            chkprndue.Enabled = True
            chksavings.Enabled = True
            chksavings.Checked = True
        End If

        dttrn.Value = systemdate            '// Transaction Date
        dtcollection.Value = systemdate     '// Collection Date

        view_loansched()                    '// Loan Schedule - OK
        cbopay_type.Text = "CASH"
        select_GL()

        gen_amounts()

    End Sub

    Private Sub select_GL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS where Accttype like '%cash%'"
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
        sql += "," + txt2.Text + ",0"
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

    Private Sub view_loansched()
        Dim table1 As DataTable = New DataTable()

        Dim lcLoanNumber As String = txtlno.Text '// Loan Number
        Dim lcGL_Loans As String = frm_members.dtgrid_products.CurrentRow.Cells(0).Value '// Product ex 1050-03 Hawak Kamay

        'MessageBox.Show("view_loansched()")
        'MessageBox.Show("frm_members.dtgrid_products.CurrentRow.Cells(0).Value " & frm_members.dtgrid_products.CurrentRow.Cells(0).Value)

        conn()

        ' Original script 
        'sql = "SELECT a.LnNum,CONVERT(VARCHAR(10),a.duedate,101) As duedate,a.AmntRcvbl,"
        'sql += "(a.rngprin+a.rngint) As rngamnt FROM Loansched a, loans b WHERE a.pnnumber=b.pnnumber and a.pnnumber='" + txtlno.Text + "' AND b.GL_loans='" + frm_members.dtgrid_products.CurrentRow.Cells(0).Value + "'  ORDER BY a.LnNum ASC" 'and a.duedate>=(select max(collectiondate) from loancollect where pnnumber=a.pnnumber)


        ' replace with stored procedure
        sql = "EXEC usp_ViewLoanSched "
        sql += "'" + lcLoanNumber + "'" + ",'" + lcGL_Loans + "'"

        'MessageBox.Show(sql)

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()

        'MessageBox.Show("view_loansched() myConn.Open() ")

        rd = cmd.ExecuteReader()
        table1.Columns.Add("Pay No")
        table1.Columns.Add("Collection Date")
        table1.Columns.Add("Amount Rcvbl.")
        table1.Columns.Add("Amnt Expected")

        While (rd.Read())
            table1.Rows.Add(rd("LnNum").ToString, rd("duedate").ToString, rd("AmntRcvbl").ToString, rd("rngamnt").ToString)
        End While

        rd.Close()
        myConn.Close()

        ' load to collection combobox
        cbo_collections.DataSource = table1 '// PayNo Combobox on form

        Me.cbo_collections.AutoFilter = True
        cbo_collections.DisplayMember = "Pay No"
        cbo_collections.ValueMember = "Collection Date"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.cbo_collections.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.cbo_collections.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.cbo_collections.EditorControl.Columns(0).Width = 40
        Me.cbo_collections.EditorControl.Columns(1).Width = 100
        Me.cbo_collections.EditorControl.Columns(2).Width = 100
        Me.cbo_collections.EditorControl.Columns(3).Width = 100
        Me.cbo_collections.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub gen_amounts()
        '// check the field data
        'MsgBox(cbo_collections.SelectedValue, MsgBoxStyle.DefaultButton1)
        'cbo_collections.SelectedValue && is from Pay No. combobox

        ' MemCode, pnnumber, grpcode, Fullname, interestdue, prnamnt, rngprin, rngint, lh  
        conn()
        sql = "SELECT a.MemCode,a.pnnumber,a.grpcode,c.Fullname,"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "rngprin=isnull(((select sum(principal) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(principal+advprincipal) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        sql += "rngint=isnull(((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(intpaid+advinterest) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        sql += "b.principal,b.interest,b.savings,cf=isnull((b.cf),0),"

        If chklh.Checked = True Then
            ' original
            'sql += "lh=isnull(((select sum(lh) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(lh) FROM loancollect where pnnumber=a.pnnumber),0)),0),"

            ' NEW
            If cbopay_type.Text = "WAIVE" Then '// WAIVE PAYMENT TYPE HAS NO C19
                ' sql += "lh=isnull((b.lh),0)," ' SET TO ZERO 

                sql += "lh=isnull((0),0),"
            Else
                sql += "lh=isnull(((select sum(lh) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate and duedate >= '2021-10-01 00:00:00')-isnull((SELECT SUM(lh) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
 
            End If

        Else
            sql += "lh=isnull((b.lh),0),"
        End If

        'sql += "cf=isnull(((select sum(cf) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(cf) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        ' sql += "lh=isnull((select top 1 lh from Loansched where pnnumber=a.pnnumber),0),"

        sql += "ttlprnpaid=isnull((select SUM(principal+advprincipal) from LoanCollect where pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((select SUM(intpaid+AdvInterest) from LoanCollect where pnnumber=a.pnnumber),0),"
        sql += "payno=isnull((select count(payno)+1 from loancollect where pnnumber=a.pnnumber),1)"
        sql += "FROM  Loans a,Loansched b, Members c "
        sql += "WHERE a.pnnumber=b.pnnumber AND a.memcode=c.memcode AND a.pnnumber='" + txtlno.Text + "' AND a.status='A' and b.duedate='" + cbo_collections.SelectedValue + "' "
        sql += "GROUP BY a.memcode,a.pnnumber,c.Fullname,a.interestdue,a.grpcode,b.principal,b.interest,b.savings,b.cf,b.lh,b.duedate"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            'txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value.ToString
            memcode = rd("MemCode").ToString
            txtfullname.Text = rd("Fullname").ToString
            prndue = Double.Parse(rd("rngprin"))
            intdue = Double.Parse(rd("rngint"))
            prnbal = Double.Parse(rd("prnamnt")) - Double.Parse(rd("ttlprnpaid"))
            intbal = Double.Parse(rd("interestdue")) - Double.Parse(rd("ttlintpaid"))
            life = Double.Parse(rd("LH"))
            If cbopay_type.Text = "DM" Then
                p_savings = 0
            Else
                cf = rd("CF").ToString
                p_savings = rd("savings").ToString
            End If
            payno = rd("payno").ToString
        End If
        rd.Close()
        myConn.Close()

        txt7.Text = prndue.ToString ' 
        txt5.Text = intdue.ToString
        txt2.Text = cf.ToString
        txt3.Text = life.ToString
        txt1.Text = p_savings.ToString

        ' total amount payable or due
        total_amntpaid = prndue + intdue + life + cf + p_savings ' total amount payable or amount due

        txtmain.Text = total_amntpaid ' Total amount payable - principal + interest + c19 + savings

        compute_payment()
    End Sub

    Private Sub txtamount_paid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmain.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    Private Sub txtamount_paid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmain.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtmain.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtmain.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtmain.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            'If e.KeyChar = Chr(13) Then GetNextControl(bttnsave, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub compute_payment()
        ' note: textbox
        ' txtmain.Text = Amount Paid
        ' txt7.Text = Principal Balance

        Dim lnPersonalSavings As Double
        Dim lnCenterFund As Double
        Dim lnPrincipalDue As Double
        Dim lnLH_CovidFund As Double
        Dim lnInterestDue As Double

        If txtmain.Text.Trim <> "" Then ' amount is not equal to zero
            'Try


            ' e check ang PRINCIPAL BALANCE kung more than zero
            ' or e check ang AMOUNT PAID kung dili ba blanco
            If Double.Parse(txt7.Text) > 0 Or txtmain.Text.Trim <> "" Then  ' PRIN BALANCE more than zero ug AMOUNT paid dili blanco

                ' assign sa textbox ang mga value
                '//
                txt1.Text = p_savings.ToString ' 1 Personal Savings 
                txt2.Text = cf.ToString        ' 2 Center Fund 
                txt7.Text = prndue.ToString    ' 3 Principal Due
                txt3.Text = life.ToString      ' 4 Life and Health or Covid Fund 
                txt5.Text = intdue.ToString    ' 5 Interest Due

                txt6.Text = advprn.ToString    ' 6 Advance Principal
                txt4.Text = advint.ToString    ' 7 Advance Interest

                'MessageBox.Show("Total nga bayronon sa PayNo = total_amntpaid = " & total_amntpaid.ToString)

                ' Amount Paid = Amount Paid - total amount payable ( in by payment order )
                ' amount entered = amount entered - total amount payable 
                ' example:
                ' amount entered = 50
                ' amount entered = 50  - 237
                ' amount entered = -187
                '
                '// txtmain.text or amount nga gbayad minus ta total nga bayronon
                txtmain.Text = Double.Parse(txtmain.Text) - total_amntpaid

                '// echeck kung ang amount nga gibayad minus sa total nga bayronon, dili ba negative
                If Double.Parse(txtmain.Text) < 0 Then ' Negative: - amount paid kay less than zero 

                    ' human kuhai ang AMOUNT PAID ug TOTAL NGA BAYRONON, ang PERSONAL SAVINGS kay pun an ug NEGATIVE nga amount paid
                    ' ang personal savings kay Personal saving + NEGATIVE AMOUNT value

                    lnPersonalSavings = txt1.Text '// store textbox personal savings to var
                    txt1.Text = Double.Parse(lnPersonalSavings) + Double.Parse(txtmain.Text) 'personal savings
                    lnPersonalSavings = txt1.Text '// store textbox personal savings to var updated amount

                    ' echeck kung ang PERSONAL SAVING ug mag negative
                    If Double.Parse(lnPersonalSavings) < 0 Then ' negative 

                        '//txt2.Text = Double.Parse(txt1.Text) + Double.Parse(txt2.Text) 
                        lnCenterFund = txt2.Text '// store textbox Center Fund to var
                        txt2.Text = Double.Parse(lnPersonalSavings) + Double.Parse(lnCenterFund)
                        lnCenterFund = txt2.Text '// store textbox Center Fund to var updated amount

                        ' kay nag negative man ang PERSONAL SAVINGS, himuon nalang syang zero ang PERSONAL SAVINGS.
                        txt1.Text = 0
                        lnPersonalSavings = txt1.Text '// store textbox personal savings to var

                        ' e check ang CENTER FUND kung mag negative
                        'If Double.Parse(txt2.Text) < 0 Then ' CENTER FUND nag negative amount
                        If Double.Parse(lnCenterFund) < 0 Then '// negative

                            lnPrincipalDue = txt7.Text
                            txt7.Text = Double.Parse(lnCenterFund) + Double.Parse(lnPrincipalDue)
                            lnPrincipalDue = txt7.Text

                            txt2.Text = 0
                            lnCenterFund = txt2.Text


                            'If Double.Parse(txt7.Text) < 0 Then ' PRINCIPAL DUE  negative amount
                            If Double.Parse(lnPrincipalDue) < 0 Then ' PRINCIPAL DUE  negative amount

                                lnLH_CovidFund = txt3.Text
                                txt3.Text = Double.Parse(lnPrincipalDue) + Double.Parse(lnLH_CovidFund)
                                lnLH_CovidFund = txt3.Text

                                txt7.Text = 0
                                lnPrincipalDue = txt7.Text

                                If Double.Parse(lnLH_CovidFund) < 0 Then ' LH or Covid Fund Negative

                                    lnInterestDue = txt5.Text
                                    txt5.Text = Double.Parse(lnLH_CovidFund) + Double.Parse(lnInterestDue)
                                    lnInterestDue = txt5.Text

                                    txt3.Text = 0
                                    lnLH_CovidFund = txt3.Text


                                    ' Interest Due
                                    ' e check ang INTEREST DUE kung mag negative
                                    'If Double.Parse(txt5.Text) < 0 Then ' INTEREST DUE negative
                                    If Double.Parse(lnInterestDue) < 0 Then ' INTEREST DUE negative
                                        ' Personal Savings 
                                        ' Personal Savings 
                                        ' Interest Due * multiply ug negative then pun an sa Saving
                                        txt1.Text = (Double.Parse(txt5.Text) * -1) + Double.Parse(txt1.Text)
                                        lnPersonalSavings = txt1.Text

                                        ' Interest Due himuon nga zero
                                        txt5.Text = 0
                                        lnInterestDue = txt5.Text

                                    End If
                                End If
                            End If
                        End If
                    End If

                Else

                    'mas gamay ang gbayad, mao mag negative ang amount paid
                    'MessageBox.Show("Amount Paid is smaller than total amount payable" & Double.Parse(txtmain.Text))

                End If


                'MessageBox.Show("Check IF Double.Parse(txtmain.Text) > 0")

                ' echeck kung dunay bay g enter nga amount paid, kung zero sya meaning mao pa pag load niya initial
                If Double.Parse(txtmain.Text) > 0 Then ' Amount Paid greater than zero

                    ' dinhi naa na syay g enter nga amount paid nga more than zero, dili negative
                    'MessageBox.Show("Double.Parse(txtmain.Text) is greater than 0")

                    If multiproduct = "Y" Or cbopay_type.Text = "DM" Then

                        ' Advance Principal = Advance Principal + Amount Paid
                        txt6.Text = Double.Parse(txt6.Text) + Double.Parse(txtmain.Text) ' Advance Principal

                    Else

                        If chksavings.Checked = True Then
                            ' savings
                            txt1.Text = Double.Parse(txt1.Text) + Double.Parse(txtmain.Text)
                        Else
                            txt6.Text = Double.Parse(txt6.Text) + Double.Parse(txtmain.Text)
                            If Double.Parse(txt6.Text) > prndue Then
                                Dim prndiff As Double = Double.Parse(txt6.Text) - prndue
                                txt6.Text = Double.Parse(txt6.Text) - prndiff
                                txt4.Text = Double.Parse(txt4.Text) + prndiff
                            End If
                        End If
                    End If
                Else
                    ' dinhi wala syay g enter nga amount paid or nag Load pa sa form
                    'MessageBox.Show("Double.Parse(txtmain.Text) is less than 0")
                End If


                ' computation of total amount paid
                ' ( Principal Due + Interest Due ) + Personal Savings + Center Fund + Advance Principal + Advance Interest + Life and Health or Covid Fund

                Dim ttlpaid As Decimal = ((((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text)) + Double.Parse(txt4.Text) + Double.Parse(txt3.Text)

                'MessageBox.Show("((((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text)) + Double.Parse(txt4.Text) + Double.Parse(txt3.Text)")

                'MessageBox.Show("ttlpaid " & ttlpaid)

                txtmain.Text = Math.Truncate((ttlpaid) * 100) / 100

                'MsgBox(txtmain.Text)
                'MessageBox.Show(txtmain.Text)

                'Disable divided 2 of amount less than total amount payable
                ' disabled - 09/29/2021
                If (prndue + intdue) > ttlpaid Then
                    Dim amntpaid_div As Double = Double.Parse(txtmain.Text) / 2

                    'txt7.Text = amntpaid_div
                    'txt5.Text = amntpaid_div

                    If Double.Parse(txt5.Text) > intdue Then
                        Dim intdiff As Double = Double.Parse(txt5.Text) - intdue
                        'txt5.Text = Double.Parse(txt5.Text) - intdiff
                        'txt7.Text = Double.Parse(txt7.Text) + intdiff
                    ElseIf Double.Parse(txt7.Text) > prndue Then
                        Dim intdiff As Double = Double.Parse(txt7.Text) - prndue
                        'txt7.Text = Double.Parse(txt7.Text) - intdiff
                        'txt5.Text = Double.Parse(txt5.Text) + intdiff
                    End If

                    Dim ttlpaid1 As Decimal = (((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text) + Double.Parse(txt4.Text)
                    txtmain.Text = Math.Truncate((ttlpaid1) * 100) / 100
                End If

                'MessageBox.Show("ttlpaid")

                txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlpaid)
                'MessageBox.Show(txtmain.Text)
            Else
                MsgBox("Amount paid must be greater than zero", MsgBoxStyle.Exclamation, "Invalid")
            End If
            'Catch ex As Exception

            'End Try
            'Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))

            If Double.Parse(lblprnbal.Text) < 0 Then
                Dim nega As Decimal = Double.Parse(lblprnbal.Text) * -1
                If Double.Parse(lblprnbal.Text) < 0 Then
                    txt4.Text = nega
                    txt6.Text = Double.Parse(txt6.Text) - nega
                    lblprnbal.Text = 0
                End If
            End If

            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
        Else
            txtmain.Text = 0
        End If
    End Sub

    Private Sub compute_payment_Orig()
        ' note: textbox
        ' txtmain.Text = Amount Paid
        ' txt7.Text = Principal Balance

        If txtmain.Text.Trim <> "" Then ' amount is not equal to zero
            'Try


            ' e check ang PRINCIPAL BALANCE kung more than zero
            ' or e check ang AMOUNT PAID kung dili ba blanco
            If Double.Parse(txt7.Text) > 0 Or txtmain.Text.Trim <> "" Then  ' PRIN BALANCE more than zero ug AMOUNT paid dili blanco

                ' assign sa textbox ang mga value
                '//
                txt7.Text = prndue.ToString    ' Principal Due
                txt5.Text = intdue.ToString    ' Interest Due
                txt1.Text = p_savings.ToString ' Personal Savings 
                txt2.Text = cf.ToString        ' Center Fund   
                txt3.Text = life.ToString      ' Life and Health or Covid Fund 
                txt6.Text = advprn.ToString    ' Advance Principal
                txt4.Text = advint.ToString    ' Advance Interest

                'MessageBox.Show("Total nga bayronon sa PayNo = total_amntpaid = " & total_amntpaid.ToString)

                ' Amount Paid = Amount Paid - total amount payable ( in by payment order )
                ' amount entered = amount entered - total amount payable 
                ' example:
                ' amount entered = 50
                ' amount entered = 50  - 237
                ' amount entered = -187
                '
                'txtmain.text or amount nga gbayad minus ta total nga bayronon
                txtmain.Text = Double.Parse(txtmain.Text) - total_amntpaid

                'MessageBox.Show(" Amount Entered or txtmain.Text = " & txtmain.Text.ToString)

                ' echeck kung ang amount nga gibayad minus sa total nga bayronon, dili ba negative
                If Double.Parse(txtmain.Text) < 0 Then ' Negative: - amount paid kay less than zero 
                    ' human kuhai ang AMOUNT PAID ug TOTAL NGA BAYRONON, ang PERSONAL SAVINGS kay pun an ug NEGATIVE nga amount paid
                    ' ang personal savings kay Personal saving + NEGATIVE AMOUNT value
                    txt1.Text = Double.Parse(txt1.Text) + Double.Parse(txtmain.Text) 'personal savings

                    ' echeck kung ang PERSONAL SAVING ug mag negative
                    If Double.Parse(txt1.Text) < 0 Then ' negative PERSONAL SAVINGS

                        ' Center Fund = p Savings + Center Fund
                        txt2.Text = Double.Parse(txt1.Text) + Double.Parse(txt2.Text)

                        ' kay nag negative man ang PERSONAL SAVINGS, himuon nalang syang zero ang PERSONAL SAVINGS.
                        txt1.Text = 0

                        ' e check ang CENTER FUND kung mag negative
                        If Double.Parse(txt2.Text) < 0 Then ' nag negative amount
                            ' Life and Health or Covid Fund
                            ' LH kay pun an pud ug negative nga Center Fund
                            txt3.Text = Double.Parse(txt3.Text) + Double.Parse(txt2.Text)

                            ' dayun himuon nga ZERO ang CENTER FUND
                            txt2.Text = 0

                            ' e check ang LIFE & HEALTY kung mag negative
                            If Double.Parse(txt3.Text) < 0 Then ' negative amount

                                ' Principal Due kay pun an ug negative nga LH
                                txt7.Text = Double.Parse(txt7.Text) + Double.Parse(txt3.Text)

                                ' dayun himuon nga ZERO ang LIFE & HEALTH
                                txt3.Text = 0

                                ' e check ang PRINCIPAL DUE kung mag negative
                                If Double.Parse(txt7.Text) < 0 Then ' negative

                                    ' Interest Due
                                    ' Interest Due pun an ug negative nga Life and Healt
                                    txt5.Text = Double.Parse(txt5.Text) + Double.Parse(txt7.Text)

                                    ' dayun himuon nga ZERO ang Principal Due
                                    txt7.Text = 0

                                    'Must Insert LH or Covid Fund here


                                    ' e check ang INTEREST DUE kung mag negative
                                    If Double.Parse(txt5.Text) < 0 Then 'negative
                                        ' Personal Savings 
                                        ' Interest Due * multiply ug negative then pun an sa Saving
                                        txt1.Text = (Double.Parse(txt5.Text) * -1) + Double.Parse(txt1.Text)

                                        ' Interest Due himuon nga zero
                                        txt5.Text = 0
                                    End If
                                End If
                            End If
                        End If
                    End If

                Else

                    'mas gamay ang gbayad, mao mag negative ang amount paid
                    'MessageBox.Show("Amount Paid is smaller than total amount payable" & Double.Parse(txtmain.Text))

                End If


                'MessageBox.Show("Check IF Double.Parse(txtmain.Text) > 0")

                ' echeck kung dunay bay g enter nga amount paid, kung zero sya meaning mao pa pag load niya initial
                If Double.Parse(txtmain.Text) > 0 Then ' Amount Paid greater than zero

                    ' dinhi naa na syay g enter nga amount paid nga more than zero, dili negative
                    'MessageBox.Show("Double.Parse(txtmain.Text) is greater than 0")

                    If multiproduct = "Y" Or cbopay_type.Text = "DM" Then

                        ' Advance Principal = Advance Principal + Amount Paid
                        txt6.Text = Double.Parse(txt6.Text) + Double.Parse(txtmain.Text) ' Advance Principal

                    Else

                        If chksavings.Checked = True Then
                            ' savings
                            txt1.Text = Double.Parse(txt1.Text) + Double.Parse(txtmain.Text)
                        Else
                            txt6.Text = Double.Parse(txt6.Text) + Double.Parse(txtmain.Text)
                            If Double.Parse(txt6.Text) > prndue Then
                                Dim prndiff As Double = Double.Parse(txt6.Text) - prndue
                                txt6.Text = Double.Parse(txt6.Text) - prndiff
                                txt4.Text = Double.Parse(txt4.Text) + prndiff
                            End If
                        End If
                    End If
                Else
                    ' dinhi wala syay g enter nga amount paid or nag Load pa sa form
                    'MessageBox.Show("Double.Parse(txtmain.Text) is less than 0")
                End If


                ' computation of total amount paid
                ' ( Principal Due + Interest Due ) + Personal Savings + Center Fund + Advance Principal + Advance Interest + Life and Health or Covid Fund

                Dim ttlpaid As Decimal = ((((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text)) + Double.Parse(txt4.Text) + Double.Parse(txt3.Text)

                'MessageBox.Show("((((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text)) + Double.Parse(txt4.Text) + Double.Parse(txt3.Text)")

                'MessageBox.Show("ttlpaid " & ttlpaid)

                txtmain.Text = Math.Truncate((ttlpaid) * 100) / 100

                'MsgBox(txtmain.Text)
                'MessageBox.Show(txtmain.Text)

                'Disable divided 2 of amount less than total amount payable
                ' disabled - 09/29/2021
                If (prndue + intdue) > ttlpaid Then
                    Dim amntpaid_div As Double = Double.Parse(txtmain.Text) / 2

                    'txt7.Text = amntpaid_div
                    'txt5.Text = amntpaid_div

                    If Double.Parse(txt5.Text) > intdue Then
                        Dim intdiff As Double = Double.Parse(txt5.Text) - intdue
                        'txt5.Text = Double.Parse(txt5.Text) - intdiff
                        'txt7.Text = Double.Parse(txt7.Text) + intdiff
                    ElseIf Double.Parse(txt7.Text) > prndue Then
                        Dim intdiff As Double = Double.Parse(txt7.Text) - prndue
                        'txt7.Text = Double.Parse(txt7.Text) - intdiff
                        'txt5.Text = Double.Parse(txt5.Text) + intdiff
                    End If

                    Dim ttlpaid1 As Decimal = (((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text) + Double.Parse(txt4.Text)
                    txtmain.Text = Math.Truncate((ttlpaid1) * 100) / 100
                End If

                'MessageBox.Show("ttlpaid")

                txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlpaid)
                'MessageBox.Show(txtmain.Text)
            Else
                MsgBox("Amount paid must be greater than zero", MsgBoxStyle.Exclamation, "Invalid")
            End If
            'Catch ex As Exception

            'End Try
            'Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))

            If Double.Parse(lblprnbal.Text) < 0 Then
                Dim nega As Decimal = Double.Parse(lblprnbal.Text) * -1
                If Double.Parse(lblprnbal.Text) < 0 Then
                    txt4.Text = nega
                    txt6.Text = Double.Parse(txt6.Text) - nega
                    lblprnbal.Text = 0
                End If
            End If

            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
        Else
            txtmain.Text = 0
        End If
    End Sub
    Private Sub compute_payment_Orig2()
        ' note: textbox
        ' txtmain.Text = Amount Paid
        ' txt7.Text = Principal Balance

        If txtmain.Text.Trim <> "" Then ' amount is not equal to zero
            'Try


            ' e check ang PRINCIPAL BALANCE kung more than zero
            ' or e check ang AMOUNT PAID kung dili ba blanco
            If Double.Parse(txt7.Text) > 0 Or txtmain.Text.Trim <> "" Then  ' PRIN BALANCE more than zero ug AMOUNT paid dili blanco

                ' assign sa textbox ang mga value
                '//
                txt7.Text = prndue.ToString    ' Principal Due
                txt5.Text = intdue.ToString    ' Interest Due
                txt1.Text = p_savings.ToString ' Personal Savings 
                txt2.Text = cf.ToString        ' Center Fund   
                txt3.Text = life.ToString      ' Life and Health or Covid Fund 
                txt6.Text = advprn.ToString    ' Advance Principal
                txt4.Text = advint.ToString    ' Advance Interest

                'MessageBox.Show("Total nga bayronon sa PayNo = total_amntpaid = " & total_amntpaid.ToString)

                ' Amount Paid = Amount Paid - total amount payable ( in by payment order )
                ' amount entered = amount entered - total amount payable 
                ' example:
                ' amount entered = 50
                ' amount entered = 50  - 237
                ' amount entered = -187
                '
                'txtmain.text or amount nga gbayad minus ta total nga bayronon
                txtmain.Text = Double.Parse(txtmain.Text) - total_amntpaid

                'MessageBox.Show(" Amount Entered or txtmain.Text = " & txtmain.Text.ToString)

                ' echeck kung ang amount nga gibayad minus sa total nga bayronon, dili ba negative
                If Double.Parse(txtmain.Text) < 0 Then ' Negative: - amount paid kay less than zero 
                    ' human kuhai ang AMOUNT PAID ug TOTAL NGA BAYRONON, ang PERSONAL SAVINGS kay pun an ug NEGATIVE nga amount paid
                    ' ang personal savings kay Personal saving + NEGATIVE AMOUNT value
                    txt1.Text = Double.Parse(txt1.Text) + Double.Parse(txtmain.Text) 'personal savings

                    ' echeck kung ang PERSONAL SAVING ug mag negative
                    If Double.Parse(txt1.Text) < 0 Then ' negative PERSONAL SAVINGS

                        ' Center Fund = p Savings + Center Fund
                        txt2.Text = Double.Parse(txt1.Text) + Double.Parse(txt2.Text)

                        ' kay nag negative man ang PERSONAL SAVINGS, himuon nalang syang zero ang PERSONAL SAVINGS.
                        txt1.Text = 0

                        ' e check ang CENTER FUND kung mag negative
                        If Double.Parse(txt2.Text) < 0 Then ' nag negative amount
                            ' Life and Health or Covid Fund
                            ' LH kay pun an pud ug negative nga Center Fund
                            txt3.Text = Double.Parse(txt3.Text) + Double.Parse(txt2.Text)

                            ' dayun himuon nga ZERO ang CENTER FUND
                            txt2.Text = 0

                            ' e check ang LIFE & HEALTY kung mag negative
                            If Double.Parse(txt3.Text) < 0 Then ' negative amount

                                ' Principal Due kay pun an ug negative nga LH
                                txt7.Text = Double.Parse(txt7.Text) + Double.Parse(txt3.Text)

                                ' dayun himuon nga ZERO ang LIFE & HEALTH
                                txt3.Text = 0

                                ' e check ang PRINCIPAL DUE kung mag negative
                                If Double.Parse(txt7.Text) < 0 Then ' negative

                                    ' Interest Due
                                    ' Interest Due pun an ug negative nga Life and Healt
                                    txt5.Text = Double.Parse(txt5.Text) + Double.Parse(txt7.Text)

                                    ' dayun himuon nga ZERO ang Principal Due
                                    txt7.Text = 0

                                    'Must Insert LH or Covid Fund here


                                    ' e check ang INTEREST DUE kung mag negative
                                    If Double.Parse(txt5.Text) < 0 Then 'negative
                                        ' Personal Savings 
                                        ' Interest Due * multiply ug negative then pun an sa Saving
                                        txt1.Text = (Double.Parse(txt5.Text) * -1) + Double.Parse(txt1.Text)

                                        ' Interest Due himuon nga zero
                                        txt5.Text = 0
                                    End If
                                End If
                            End If
                        End If
                    End If

                Else

                    'mas gamay ang gbayad, mao mag negative ang amount paid
                    'MessageBox.Show("Amount Paid is smaller than total amount payable" & Double.Parse(txtmain.Text))

                End If


                'MessageBox.Show("Check IF Double.Parse(txtmain.Text) > 0")

                ' echeck kung dunay bay g enter nga amount paid, kung zero sya meaning mao pa pag load niya initial
                If Double.Parse(txtmain.Text) > 0 Then ' Amount Paid greater than zero

                    ' dinhi naa na syay g enter nga amount paid nga more than zero, dili negative
                    'MessageBox.Show("Double.Parse(txtmain.Text) is greater than 0")

                    If multiproduct = "Y" Or cbopay_type.Text = "DM" Then

                        ' Advance Principal = Advance Principal + Amount Paid
                        txt6.Text = Double.Parse(txt6.Text) + Double.Parse(txtmain.Text) ' Advance Principal

                    Else

                        If chksavings.Checked = True Then
                            ' savings
                            txt1.Text = Double.Parse(txt1.Text) + Double.Parse(txtmain.Text)
                        Else
                            txt6.Text = Double.Parse(txt6.Text) + Double.Parse(txtmain.Text)
                            If Double.Parse(txt6.Text) > prndue Then
                                Dim prndiff As Double = Double.Parse(txt6.Text) - prndue
                                txt6.Text = Double.Parse(txt6.Text) - prndiff
                                txt4.Text = Double.Parse(txt4.Text) + prndiff
                            End If
                        End If
                    End If
                Else
                    ' dinhi wala syay g enter nga amount paid or nag Load pa sa form
                    'MessageBox.Show("Double.Parse(txtmain.Text) is less than 0")
                End If


                ' computation of total amount paid
                ' ( Principal Due + Interest Due ) + Personal Savings + Center Fund + Advance Principal + Advance Interest + Life and Health or Covid Fund

                Dim ttlpaid As Decimal = ((((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text)) + Double.Parse(txt4.Text) + Double.Parse(txt3.Text)

                'MessageBox.Show("((((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text)) + Double.Parse(txt4.Text) + Double.Parse(txt3.Text)")

                'MessageBox.Show("ttlpaid " & ttlpaid)

                txtmain.Text = Math.Truncate((ttlpaid) * 100) / 100

                'MsgBox(txtmain.Text)
                'MessageBox.Show(txtmain.Text)

                'Disable divided 2 of amount less than total amount payable
                ' disabled - 09/29/2021
                If (prndue + intdue) > ttlpaid Then
                    Dim amntpaid_div As Double = Double.Parse(txtmain.Text) / 2

                    'txt7.Text = amntpaid_div
                    'txt5.Text = amntpaid_div

                    If Double.Parse(txt5.Text) > intdue Then
                        Dim intdiff As Double = Double.Parse(txt5.Text) - intdue
                        'txt5.Text = Double.Parse(txt5.Text) - intdiff
                        'txt7.Text = Double.Parse(txt7.Text) + intdiff
                    ElseIf Double.Parse(txt7.Text) > prndue Then
                        Dim intdiff As Double = Double.Parse(txt7.Text) - prndue
                        'txt7.Text = Double.Parse(txt7.Text) - intdiff
                        'txt5.Text = Double.Parse(txt5.Text) + intdiff
                    End If

                    Dim ttlpaid1 As Decimal = (((Double.Parse(txt7.Text) + Double.Parse(txt5.Text)) + (Double.Parse(txt1.Text))) + Double.Parse(txt2.Text)) + Double.Parse(txt6.Text) + Double.Parse(txt4.Text)
                    txtmain.Text = Math.Truncate((ttlpaid1) * 100) / 100
                End If

                'MessageBox.Show("ttlpaid")

                txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlpaid)
                'MessageBox.Show(txtmain.Text)
            Else
                MsgBox("Amount paid must be greater than zero", MsgBoxStyle.Exclamation, "Invalid")
            End If
            'Catch ex As Exception

            'End Try
            'Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))

            If Double.Parse(lblprnbal.Text) < 0 Then
                Dim nega As Decimal = Double.Parse(lblprnbal.Text) * -1
                If Double.Parse(lblprnbal.Text) < 0 Then
                    txt4.Text = nega
                    txt6.Text = Double.Parse(txt6.Text) - nega
                    lblprnbal.Text = 0
                End If
            End If

            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
        Else
            txtmain.Text = 0
        End If
    End Sub


    Private Sub txtamount_paid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmain.KeyUp
        Try
            If Not txtmain.Text.Contains(".") And Double.Parse(txtmain.Text) > 0 Then
                txtmain.Text = Format(Val(Replace(txtmain.Text, ",", "")), "#,###,###")
                txtmain.Select(txtmain.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount_paid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmain.Validated
        If chk_auto_comp.Checked = True Then
            compute_payment()
        End If
    End Sub

    Private Sub chkprndue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkprndue.CheckedChanged
        If chkprndue.Checked = True Then
            chksavings.Checked = False
        Else
            chksavings.Checked = True
        End If
        compute_payment()
    End Sub

    Private Sub chksavings_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksavings.CheckedChanged
        If chksavings.Checked = True Then
            chkprndue.Checked = False
        Else
            chkprndue.Checked = True
        End If
        compute_payment()
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

    Private Sub txtadvprn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt6.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txt6.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txt6.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txt6.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(txt6, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtcoll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtmain.Focus()
        End If
    End Sub

    Private Sub cbo_collections_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_collections.Validated
        gen_amounts()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click

        ' note: textbox name
        ' txt3.text = Life and Health or LH (09/28/2021)

        If multiproduct = "Y" Then
            If cbopay_type.Text = "DM" Then
                cbopay_type.Text = "CASH"
            End If
        Else
            If cbopay_type.Text = "DM" Then
                chkprndue.Checked = True
                conn()
                sql = "SELECT sum(debit-credit) as balance FROM AccountLedger WHERE active='Y' and accountnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    If rd("balance") - Double.Parse(txtmain.Text) < 1000 Then
                        If (rd("balance") - Double.Parse(txtmain.Text)) < 0 Then
                            MsgBox("DM amount is greater than savings balance.", MsgBoxStyle.Exclamation, "Savings Balance (" & rd("balance").ToString & ")")
                            GoTo a
                        Else
                            If MessageBox.Show("Savings account is below minimum than required. Are you sure you want to continue?", "Savings Balance (" & rd("balance").ToString & ")", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                                cbopay_type.Text = "CASH"
                                GoTo a
                            End If
                        End If
                    End If
                End If
                rd.Close()
                myConn.Close()
            Else
                If Double.Parse(txt3.Text) < life Then
                    ' Do not pop-up messagebox for LH, 
                    ' modified 09/28/2021

                    'If MessageBox.Show("The system detected life and health benefits zero payment. This will end the members LH benefits, Yes to continue and No to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                    If MessageBox.Show("The system detected life and health benefits or Covid Fund zero payment. This will end the members LH benefits, Yes to continue and No to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then

                        ' do not update LH, no need to set the LH to zero
                        ' modified 09/28/2021

                        'conn()
                        'sql = "UPDATE loansched set LH=0 WHERE pnnumber='" + txtlno.Text + "'"
                        'cmd = New SqlCommand(sql, myConn)
                        'myConn.Open()
                        'cmd.ExecuteNonQuery()
                        'myConn.Close()

                    Else
                        ' do nothing...
                        ' modified 09/28/2021
                        ' GoTo a
                    End If
                End If
            End If
        End If
        'gen_amounts()
        'End If


        If chk_auto_comp.Checked = True Then
            compute_payment() ' compute payment
        End If


        If Double.Parse(lblprnbal.Text) < 0.0 Then
            MsgBox("Principal paid is greater than principal balance", MsgBoxStyle.Exclamation, "Invalid")
            txtmain.Focus()
        ElseIf Double.Parse(lblintbal.Text) < 0 Then
            MsgBox("Interest paid is greater than interest balance", MsgBoxStyle.Exclamation, "Invalid")
            txtmain.Focus()
        ElseIf dttrn.Value < dtcollection.Value Then
            MsgBox("Transaction date must be greater than collection date", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtref.Text.Trim = "" Then
            MsgBox("Reference cannot be empty!", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf txtref.Text.StartsWith("DM") = True And cbopay_type.Text <> "DM" Then
            MsgBox("Invalid payment type when reference is DM.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtref.Text.EndsWith("DM") = True And cbopay_type.Text <> "DM" Then
            MsgBox("Invalid payment type when reference is DM.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtref.Text.Length < 2 Then
            MsgBox("Reference must be greater than 2 numbers or letters.", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf txtmain.Text.Trim = "" Then
            MsgBox("Amount paid cannot be empty!", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf Decimal.Parse(txtmain.Text) < 0.01 Then
            MsgBox("Amount paid must be greater than one.", MsgBoxStyle.Exclamation, "Invalid")
            txtmain.Focus()
        ElseIf IsNumeric(txtmain.Text) = False Then
            MsgBox("Invalid amount paid.", MsgBoxStyle.Exclamation, "Invalid")
            txtmain.Focus()
        Else
            'If cbopay_type.Text = "WAIVE" Then
            '    conn()
            '    sql = "SELECT pnnumber FROM logs WHERE pnnumber='" + txtlno.Text + "'"
            '    cmd = New SqlCommand(sql, myConn)
            '    myConn.Open()
            '    rd = cmd.ExecuteReader
            '    If rd.Read Then
            '        insert_payment()
            '        conn()
            '        sql = "UPDATE Loans SET status='X', dateclosed='" + dttrn.Value + "' WHERE pnnumber='" + txtlno.Text + "'"
            '        cmd = New SqlCommand(sql, myConn)
            '        myConn.Open()
            '        cmd.ExecuteNonQuery()
            '        myConn.Close()
            '    Else
            '        MsgBox("You have no permission to waive this loan.", MsgBoxStyle.Exclamation, "System Override")
            '    End If
            'Else
            insert_payment()
            dttrn.Enabled = False
            'insert_GL()
            gen_amounts()

            txtref.Clear()
            txt6.Text = 0
            'End If
        End If
a:
    End Sub

    Private Sub insert_GL()
        dtgrid_gl.Rows.Clear()

        dtgrid_gl.Rows.Add(txtgl.SelectedValue, "Cash", txtmain.Text, 0)
        If (Decimal.Parse(txt5.Text) + Decimal.Parse(txt4.Text)) > 0 Then
            dtgrid_gl.Rows.Add(GL_income, "Interest income received from " & txtfullname.Text, 0, Decimal.Parse(txt5.Text) + Decimal.Parse(txt4.Text))
        End If
        If (Decimal.Parse(txt7.Text) + Decimal.Parse(txt6.Text)) > 0 Then
            dtgrid_gl.Rows.Add(GL_loans, "Loans receivable principal paid of " & txtfullname.Text, 0, Decimal.Parse(txt7.Text) + Decimal.Parse(txt6.Text))
        End If
        If Decimal.Parse(txt1.Text) > 0 Then
            dtgrid_gl.Rows.Add(GL_sa, "Savings deposit of madam/sir " & txtfullname.Text, 0, txt1.Text)
        End If
        If Decimal.Parse(txt2.Text) > 0 Then
            dtgrid_gl.Rows.Add(GL_cf, "Center fund received from " & txtfullname.Text, 0, txt2.Text)
        End If

    End Sub

    Private Sub insert_payment()
        If MessageBox.Show("Click yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,LH,SSSCont,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
            sql += "VALUES('" + memcode + "'," 'memcode
            sql += "" + payno.ToString + ","   'payno
            sql += "'" + dttrn.Value + "',"    'trnxdate   
            sql += "'" + cbopay_type.Text + "'," 'remarks
            sql += "'" + frm_members.dtgridloan_list.CurrentRow.Cells(0).Value + "'," 'pnnumber
            sql += "" + prndue.ToString + "," 'prndue
            sql += "" + Double.Parse(txt7.Text).ToString + "," 'principal
            sql += "" + Double.Parse(txtmain.Text).ToString + "," 'prnpaid
            sql += "" + intdue.ToString + "," 'intdue
            sql += "" + Double.Parse(txt5.Text).ToString + "," 'intpaid
            sql += "" + Double.Parse(txt4.Text).ToString + "," 'AdvInterest
            sql += "" + Double.Parse(txt1.Text).ToString + "," 'savings
            sql += "" + Double.Parse(txt2.Text).ToString + "," 'CF
            sql += "" + Double.Parse(txt3.Text).ToString + "," 'LH
            sql += "" + Double.Parse(txtsss.Text).ToString + "," 'SSSCont
            sql += "" + Double.Parse(txtpen_paid.Text).ToString + "," 'penpaid
            sql += "" + Double.Parse(txtmain.Text).ToString + "," 'amtpaid
            sql += "'" + txtref.Text + "'," 'prnum
            sql += "'" + txtref.Text + "'," 'ornumber
            sql += "'" + user.ToString + "'," 'userid
            sql += "'" + dttrn.Value + "',"
            sql += "'" + time.ToString + "',"
            sql += "'N',"
            sql += "'" + dtcollection.Text + "',"
            sql += "" + txt6.Text + ","
            sql += "" + Double.Parse(lblprnbal.Text).ToString + ","
            sql += "" + Double.Parse(lblintbal.Text).ToString + ""
            sql += ")"

            'display query
            'MsgBox(sql.ToString)

            'MessageBox.Show("txtmain.Text " + txtmain.Text)

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            If cbopay_type.Text = "DM" Then
                If Double.Parse(txtmain.Text) > 0 Then
                    conn()
                    sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
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
                    Dim remarks As String = "DM-" & txtlno.Text
                    conn()
                    sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,gl_sa,tdate,Active) VALUES "
                    sql += "('" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "'"
                    sql += ",'" + dttrn.Value + "'"
                    sql += "," + postno.ToString + ""
                    sql += ",'DM'"
                    sql += ",0," + Double.Parse(txtmain.Text).ToString + ""
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
            If Double.Parse(lblprnbal.Text) = 0 And Double.Parse(lblintbal.Text) = 0 Then ' MUST BE EQUAL TO ZERO BE PAID UP

                conn()
                sql = "UPDATE Loans SET status='O' WHERE pnnumber='" + txtlno.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                frm_members.view_member()

            End If


        End If
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose.Click
        Me.Close()
    End Sub

    Private Sub txtref_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtref.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtref.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub cbopay_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopay_type.SelectedIndexChanged
        If multiproduct = "Y" Then
            If cbopay_type.Text = "DM" Then
                cbopay_type.Text = "CASH"
            End If
        Else
            If cbopay_type.Text = "DM" Then
                chkprndue.Checked = True
                conn()
                sql = "SELECT sum(debit-credit) as balance FROM AccountLedger WHERE accountnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(10).Value + "' and Active='Y'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    If rd("balance") < 1000 Then
                        If MessageBox.Show("Savings account is below minimum than required. Are you sure you want to continue?", "Savings Balance (" & rd("balance").ToString & ")", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cbopay_type.Text = "CASH"
                        End If
                    End If
                End If
                rd.Close()
                myConn.Close()
            End If
        End If
        gen_amounts()
        'End If
    End Sub

    Private Sub chk_auto_comp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_auto_comp.CheckedChanged
        If chk_auto_comp.Checked = False Then
            txt7.Enabled = True
            txt6.Enabled = True
            txt5.Enabled = True
            txt4.Enabled = True
            txt1.Enabled = True
            txt2.Enabled = True
            txtmain.Enabled = False
        Else
            txt4.Enabled = False
            txt7.Enabled = False
            txt5.Enabled = False
            txt4.Enabled = False
            txt1.Enabled = False
            txt2.Enabled = False
            txtmain.Enabled = True
            compute_payment()
        End If
    End Sub

    Private Sub txtprnpaid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt7.Validated
        Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))
            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
            txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txt7.Text) + Double.Parse(txt6.Text) + Double.Parse(txt5.Text) + Double.Parse(txt4.Text) + Double.Parse(txt2.Text) + Double.Parse(txt1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtadvprnpaid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt6.Validated
        Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))
            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
            txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txt7.Text) + Double.Parse(txt6.Text) + Double.Parse(txt5.Text) + Double.Parse(txt4.Text) + Double.Parse(txt2.Text) + Double.Parse(txt1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtintpaid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt5.Validated
        Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))
            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
            txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txt7.Text) + Double.Parse(txt6.Text) + Double.Parse(txt5.Text) + Double.Parse(txt4.Text) + Double.Parse(txt2.Text) + Double.Parse(txt1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtadv_intpaid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt4.Validated
        Try
            lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prnbal - (Double.Parse(txt7.Text) + Double.Parse(txt6.Text)))
            lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txt5.Text) + Double.Parse(txt4.Text)))
            txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txt7.Text) + Double.Parse(txt6.Text) + Double.Parse(txt5.Text) + Double.Parse(txt4.Text) + Double.Parse(txt2.Text) + Double.Parse(txt1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsa_amount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.Validated
        Try
            txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txt7.Text) + Double.Parse(txt6.Text) + Double.Parse(txt5.Text) + Double.Parse(txt4.Text) + Double.Parse(txt2.Text) + Double.Parse(txt1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcf_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2.Validated
        Try
            txtmain.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txt7.Text) + Double.Parse(txt6.Text) + Double.Parse(txt5.Text) + Double.Parse(txt4.Text) + Double.Parse(txt2.Text) + Double.Parse(txt1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsss_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsss.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtsss.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtsss.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtsss.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            'If e.KeyChar = Chr(13) Then GetNextControl(bttnsave, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsss_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsss.KeyUp
        Try
            If Not txtsss.Text.Contains(".") And Double.Parse(txtsss.Text) > 0 Then
                txtsss.Text = Format(Val(Replace(txtsss.Text, ",", "")), "#,###,###")
                txtsss.Select(txtsss.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
        If e.KeyCode = Keys.Enter Then
            txtmain.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pn_backdate.Visible = True
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        pn_backdate.Visible = False
    End Sub

    Private Sub bttncont1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont1.Click
        If txtpassword_rec.Text = adminpass Then
            dttrn.Enabled = True
            pn_backdate.Visible = False
        Else
            MessageBox.Show("Invalid password")
            'Try
            '    mysqlconn()
            '    sql = "select * from access_temp where accesspass='" + txtpassword_rec.Text + "' and userid='" + user + "' and status='A'"
            '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            '    mysqlmyconn.Open()
            '    mysqlrd = mysqlcmd.ExecuteReader
            '    If mysqlrd.Read Then
            '        If txtpassword_rec.Text = mysqlrd("accesspass") Then
            '            dttrn.Enabled = True
            '            pn_backdate.Visible = False
            '        End If
            '    Else
            '        MsgBox("Invalid access of user ID.", MsgBoxStyle.Exclamation, "Invalid User")
            '    End If
            '    mysqlrd.Close()
            '    mysqlmyconn.Close()

            '    update_accesstemp()
            'Catch ex As Exception
            '    MsgBox("Cannot connect to MySql Host.", MsgBoxStyle.Exclamation, "Failed to connect")
            'End Try
        End If
        txtpassword_rec.Clear()
    End Sub

    Private Sub cbo_collections_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_collections.SelectedIndexChanged

    End Sub

    Private Sub txtsss_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsss.TextChanged

    End Sub

    Private Sub txtmain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmain.TextChanged

    End Sub
End Class