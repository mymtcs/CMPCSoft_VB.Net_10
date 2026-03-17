Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_loanProcess_grp
    Public comboCol_deduction As New GridViewMultiComboBoxColumn("Descriptions")
    Public comboCol_Items As New GridViewMultiComboBoxColumn("Item Descriptions")
    Public comboCol2 As New GridViewMultiComboBoxColumn("Beneficiary")
    Public loanrate As Decimal = 0
    Public penaltyrate As Decimal = 0
    Public address As String
    Public loannum As Integer
    Public payable As Integer = 0

    Private loan_code As Integer = 0
    Dim cbu As Decimal = 0
    Dim cycle As Integer = 2
    Dim loanstr As Integer
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim dtpart As Integer = 0
    Dim sanum As Integer = 0
    Dim savings As Integer = 0
    Dim savingsrate As Decimal = 0
    Dim cf As Integer = 0
    Dim lh As Integer = 0
    Public loantype As String = ""
    Dim adjmatdate As String = ""
    Dim modeofpay As String = ""
    Dim ttlbenf As Integer = 0
    Dim pnnumber As String = ""
    Dim prndue As Decimal = 0
    Dim intdue As Decimal = 0
    Dim life_health As Decimal = 0
    Dim p_savings As Decimal = 0
    Dim total_amntpaid = 0
    Dim payno As Decimal = 0
    Dim colldate As DateTime
    Dim intbal As Decimal = 0
    Dim prinbal As Decimal = 0
    Dim advprn As Decimal = 0
    Dim advint As Decimal = 0
    Dim memcode As String
    Dim sqlstr As String = ""

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer WHERE status='A'  ORDER BY fullname ASC" '
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll.DataSource = table1
        Me.txtcoll.AutoFilter = True
        txtcoll.DisplayMember = "Fullname"
        txtcoll.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll.EditorControl.Columns(0).Width = 100
        Me.txtcoll.EditorControl.Columns(1).Width = 200
        Me.txtcoll.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    ''Public Sub gen_sacct()
    ''    conn()
    ''    sql = "SELECT Accountnumber FROM AccountMaster WHERE MemCode='" & txtmember.SelectedValue & "' and dateclosed is null AND AccountStatus='Active'"
    ''    cmd = New SqlCommand(sql, myConn)
    ''    myConn.Open()
    ''    rd = cmd.ExecuteReader()
    ''    If rd.Read Then
    ''        txtsaacct.Text = rd("Accountnumber").ToString()
    ''    Else
    ''        txtsaacct.Text = ""
    ''    End If
    ''    rd.Close()
    ''    myConn.Close()
    ''End Sub

    'Private Sub insert_acctMaster()
    '    conn()
    '    sql = "INSERT INTO AccountMaster(Accountnumber,Dateopen,AccountType,userid,tdate,MemCode,AccountStatus,GL_sa) values "
    '    sql += "('" & txtsaacct.Text & "',"
    '    sql += "'" & systemdate & "',"
    '    sql += "'PS',"
    '    sql += "'" & user.ToString & "',"
    '    sql += "'" & systemdate & "',"
    '    sql += "'" & txtmember.SelectedValue & "',"
    '    sql += "'Active',"
    '    sql += "'" & GL_sa.ToString & "'"
    '    sql += ")"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    cmd.ExecuteNonQuery()
    '    myConn.Close()
    'End Sub

    Private Sub frm_newloan_HL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        pnmember.Visible = False
        frm_newloanlist.view_loanlist_HL()
    End Sub

    Public Sub select_cycle()
        conn()
        sql = "SELECT isnull((count(memcode)),0) as cycle from loans where Memcode='" & txtmember.SelectedValue & "' and status='O' and GL_loans='" & GL_loans & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            If Me.Text = "New Loan" Then
                txtcycle.Text = Double.Parse(rd("cycle")) + 1
            End If

            If Me.Text = "ReNew Loan" Then
                txtcycle.Text = Double.Parse(rd("cycle")) + 2
            End If

        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_members()
        Dim dtTest As DataTable = New DataTable()
        Me.txtmember.DataSource = Nothing
        dtTest.Columns.Add("Member Code", GetType(String))
        dtTest.Columns.Add("Fullname", GetType(String))

        conn()
        If Me.Text = "View Loan" Then
            sql = "select * from members where memcode='" & member_code.ToString & "' order by fullname"
        Else
            sql = "select * from members where status='A' order by fullname"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        dtTest.Rows.Add("-select-", "-select-")
        While rd.Read
            dtTest.Rows.Add(rd("memcode"), rd("fullname"))
        End While
        rd.Close()
        myConn.Close()

        ' Bind the ComboBox to the DataTable
        Me.txtmember.DataSource = dtTest
        Me.txtmember.DisplayMember = "Fullname"
        Me.txtmember.ValueMember = "Member Code"

        ' Enable the owner draw on the ComboBox.
        Me.txtmember.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items.
    End Sub

    Private Sub append()
        Dim MySource_coaddress As New AutoCompleteStringCollection()

        conn()
        sql = "SELECT DISTINCT address FROM members GROUP BY address"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read()
            MySource_coaddress.AddRange(New String() {rd("address").ToString})
        End While
        rd.Close()
        myConn.Close()
        With txtcoaddress
            .AutoCompleteCustomSource = MySource_coaddress
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .Height = 15
        End With
    End Sub

    Private Sub get_pnnumber()
        conn()
        sql = "select top 1 pnnumber from loans where memcode='" & member_code & "' and status='A' and released='Y' and gl_loans='" & GL_loans & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            pnnumber = rd("pnnumber")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub view_loansched()
        Try
            Dim table1 As DataTable = New DataTable()
            cbo_collections.DataSource = Nothing
            conn()
            sql = "SELECT top 1 a.LnNum,CONVERT(VARCHAR(10),a.duedate,101) As duedate,a.AmntRcvbl,"
            sql += "(a.rngprin+a.rngint) As rngamnt FROM Loansched a WHERE a.pnnumber='" & pnnumber & "' ORDER BY a.LnNum desc" 'and a.duedate>=(select max(collectiondate) from loancollect where pnnumber=a.pnnumber)
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
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
            cbo_collections.DataSource = table1
            Me.cbo_collections.AutoFilter = True
            cbo_collections.DisplayMember = "Collection Date"
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
        Catch ex As Exception

        End Try
        gen_amounts()
    End Sub

    Private Sub compute_payment()
        If Double.Parse(txtprnpaid.Text) > 0 Or txtamount_paid.Text.Trim <> "" Then
            If txtamount_paid.Text.Trim = "" Then
                txtamount_paid.Text = 0
            End If
            txtprnpaid.Text = prndue.ToString
            txtintdue.Text = intdue.ToString
            txtsa_amount.Text = p_savings.ToString
            txtcf.Text = cf.ToString
            txtlife_health.Text = life_health
            txtadvprn.Text = advprn.ToString
            txtadv_int.Text = advint.ToString
            txtamount_paid.Text = Double.Parse(txtamount_paid.Text) - total_amntpaid
            If Double.Parse(txtamount_paid.Text) < 0 Then
                txtsa_amount.Text = Double.Parse(txtsa_amount.Text) + Double.Parse(txtamount_paid.Text)
                If Double.Parse(txtsa_amount.Text) < 0 Then
                    txtcf.Text = Double.Parse(txtsa_amount.Text) + Double.Parse(txtcf.Text)
                    txtsa_amount.Text = 0
                    If Double.Parse(txtcf.Text) < 0 Then
                        txtlife_health.Text = Double.Parse(txtlife_health.Text) + Double.Parse(txtcf.Text)
                        txtcf.Text = 0
                        If Double.Parse(txtlife_health.Text) < 0 Then
                            txtprnpaid.Text = Double.Parse(txtprnpaid.Text) + Double.Parse(txtlife_health.Text)
                            txtlife_health.Text = 0
                            If Double.Parse(txtprnpaid.Text) < 0 Then
                                txtintdue.Text = Double.Parse(txtintdue.Text) + Double.Parse(txtprnpaid.Text)
                                txtprnpaid.Text = 0
                                If Double.Parse(txtintdue.Text) < 0 Then
                                    txtsa_amount.Text = (Double.Parse(txtintdue.Text) * -1) + Double.Parse(txtsa_amount.Text)
                                    txtintdue.Text = 0
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If Double.Parse(txtamount_paid.Text) > 0 Then
                If chksavings.Checked = True Then
                    txtsa_amount.Text = Double.Parse(txtsa_amount.Text) + Double.Parse(txtamount_paid.Text)
                Else
                    txtadvprn.Text = Double.Parse(txtadvprn.Text) + Double.Parse(txtamount_paid.Text)
                    If Double.Parse(txtadvprn.Text) > prndue Then
                        Dim prndiff As Double = Double.Parse(txtadvprn.Text) - prndue
                        txtadvprn.Text = Double.Parse(txtadvprn.Text) - prndiff
                        txtadv_int.Text = Double.Parse(txtadv_int.Text) + prndiff
                    End If
                End If
            End If
            Dim ttlpaid As Decimal = (((Double.Parse(txtprnpaid.Text) + Double.Parse(txtintdue.Text)) + (Double.Parse(txtsa_amount.Text))) + Double.Parse(txtcf.Text)) + Double.Parse(txtadvprn.Text) + Double.Parse(txtadv_int.Text) + Double.Parse(txtlife_health.Text)
            txtamount_paid.Text = Math.Truncate((ttlpaid) * 100) / 100
            If (prndue + intdue) > ttlpaid Then
                Dim amntpaid_div As Double = Double.Parse(txtamount_paid.Text) / 2
                txtprnpaid.Text = amntpaid_div
                txtintdue.Text = amntpaid_div
                If Double.Parse(txtintdue.Text) > intdue Then
                    Dim intdiff As Double = Double.Parse(txtintdue.Text) - intdue
                    txtintdue.Text = Double.Parse(txtintdue.Text) - intdiff
                    txtprnpaid.Text = Double.Parse(txtprnpaid.Text) + intdiff
                End If
                Dim ttlpaid1 As Decimal = (((Double.Parse(txtprnpaid.Text) + Double.Parse(txtintdue.Text)) + (Double.Parse(txtsa_amount.Text))) + Double.Parse(txtcf.Text)) + Double.Parse(txtadv_int.Text) + Double.Parse(txtadv_int.Text)
                txtamount_paid.Text = Math.Truncate((ttlpaid1) * 100) / 100
            End If

            txtamount_paid.Text = Math.Truncate((ttlpaid) * 100) / 100
            txtamount_paid.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlpaid)
        Else
            MsgBox("Amount paid must be greater than zero", MsgBoxStyle.Exclamation, "Invalid")
        End If
        'Catch ex As Exception

        'End Try
        'Try
        lblprnbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", prinbal - (Double.Parse(txtprnpaid.Text) + Double.Parse(txtadvprn.Text)))

        If Double.Parse(lblprnbal.Text) < 0 Then
            Dim nega As Decimal = Double.Parse(lblprnbal.Text) * -1
            If Double.Parse(lblprnbal.Text) < 0 Then
                txtadv_int.Text = nega
                txtadvprn.Text = Double.Parse(txtadvprn.Text) - nega
                lblprnbal.Text = 0
            End If

        End If
        lblintbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", intbal - (Double.Parse(txtintdue.Text) + Double.Parse(txtadv_int.Text)))

    End Sub

    Private Sub display_members_list()
        conn()
        If chk_offset.Checked = True Then
            sql = "select memcode,fullname from members where status='A' and memcode in(select y.memcode from("
            sql += "select x.memcode,x.pnnumber,x.status,(x.rngamnt-x.TotalPaid)as Loanbal,x.offset_amount from ("
            sql += "select a.memcode,a.pnnumber,a.status,(a.loanamnt) As loanamnt,a.interestdue,"
            sql += "offset_amount=isnull((select sum(principal+interest) from loansched where pnnumber=a.pnnumber and LnNum>=19),0),"
            sql += "rngamnt=isnull((select sum(principal+interest) from loansched where pnnumber=a.pnnumber),0),"
            sql += "TotalPaid=isnull((SELECT SUM(principal+advprincipal+intpaid+advinterest) from LoanCollect where trnxdate<=getdate() and cancel='N' AND pnnumber=a.pnnumber),0)"
            sql += " from Loans a where a.status='A' and a.released='Y' and a.gl_loans='" & GL_loans & "')x )y where y.Loanbal<=y.offset_amount) and fullname like '%" & txtsearch.Text.Trim & "%' order by fullname"
        Else
            sql = "select memcode,fullname from members where memcode not in(select memcode from loans where status='A' and released='Y' and gl_loans='" & GL_loans & "') and status='A' and fullname like '%" & txtsearch.Text.Trim & "%' order by fullname"
        End If

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        lstmembers.Items.Clear()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstmembers.Items.Add(lvitem)
            'lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub frm_newloan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MsgBox(Me.Text)

        pnmember.Size = New Size(744, 270)
        txtsaacct.Clear()
        dtschedoffirst.Value = systemdate
        dtrel.Value = systemdate
        If grouptype = "N" Then
            dtschedoffirst.Enabled = False
        End If
        TabControl1.SelectedPage = RadPageViewPage1
        pn_payment.Visible = False
        'display_members()
        gen_members()
        display_members_list()

        view_officer()
        gen_fund()
        view_ctr()
        gen_loantype()
        view_subproducts()
        append()

        creategview_deductions()

        creategview_beneficiary()
        lstgensched.Items.Clear()
        txtlnamnt.Text = 0
        txtdeduction.Text = 0
        txtlnproceeds.Text = 0
        gen_cbuacct()
        bttnsave.Enabled = True

        If Me.Text = "View Loan" Then
            chk_offset.Enabled = False
            txtlno.Text = loannumber
            If frm_members.dtgridloan_list.CurrentRow.Cells(7).Value = "Active" Then
                bttnsave.Enabled = True
            End If
        End If
        If Me.Text = "New Loan" Then
            txtlnamnt.Enabled = True
            txtLoanBalance.Enabled = False

            chk_offset.Enabled = True
            bttnfind.Enabled = True
        Else
            chk_offset.Enabled = False
            edit()
            bttnfind.Enabled = False
        End If

        If chk_offset.Checked = True Then
            lnk_offset.Enabled = True
        Else
            lnk_offset.Enabled = False
        End If

        If Me.Text = "Re-Construct Loan" Then
            frm_recons_amount.ShowDialog()
            txtmember.SelectedValue = member_code
            txtloantype.Enabled = False
            txtlnamnt.Enabled = False
            txtlnamnt.Text = frm_recons_amount.txtprin.Text
            txtpayno.Text = frm_recons_amount.txtcycle.Text
            cboterms.Text = frm_recons_amount.cboterms.Text
        End If

        'modified -- 9/26/2024 by windel tonacao

        If Me.Text = "ReNew Loan" Then
            txtlnamnt.Enabled = False
            'txtlnamnt.Enabled = True
            txtLoanBalance.Enabled = False


            'original loan number
            txtlno.Text = loannumber

            'MsgBox(frm_members.dtgridloan_list.CurrentRow.Cells(0).Value)
            'txtlno.Text = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value

            frm_renew_amount.ShowDialog()
            txtmember.SelectedValue = member_code
            txtloantype.Enabled = False
            txtlnamnt.Enabled = False

            'txtlnamnt this is the origina
            'txtlnamnt.Text = frm_renew_amount.txtprin.Text 

            'new: 10/17/2024
            txtlnamnt.Text = frm_renew_amount.txtRenewAmt.Text
            txtLoanBalance.Text = frm_renew_amount.txtTotalLoanBal.Text
            txtlnproceeds.Text = Format(Val(Replace(Double.Parse(frm_renew_amount.txtNetLoanAmt.Text), ",", "")), "##,###,###")

            'original loan number


            txtpayno.Text = frm_renew_amount.txtcycle.Text
            cboterms.Text = frm_renew_amount.cboterms.Text
        End If

        GetSavingsAccount()
    End Sub

    Private Sub view_subproducts()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * from SubProducts where gl_loans='" & GL_loans & "' order by description" '
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Columns.Add("Rate")
        While (rd.Read())
            table1.Rows.Add(rd("Code").ToString, rd("Description").ToString, rd("Rate").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsubproduct.DataSource = table1
        Me.txtsubproduct.AutoFilter = True
        txtsubproduct.DisplayMember = "Description"
        txtsubproduct.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsubproduct.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsubproduct.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsubproduct.EditorControl.Columns(0).Width = 100
        Me.txtsubproduct.EditorControl.Columns(1).Width = 200
        Me.txtsubproduct.EditorControl.Columns(2).Width = 100
        Me.txtsubproduct.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub txtamount_paid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount_paid.Validated
        compute_payment()
    End Sub

    Private Sub gen_amounts()
        'cbo_collections.SelectedValue = dtcoll.Value
        conn()
        sql = "SELECT a.MemCode,a.pnnumber,a.grpcode,c.Fullname,"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "rngprin=isnull(((select sum(principal) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(principal+advprincipal) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        sql += "rngint=isnull(((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(intpaid+advinterest) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        sql += "b.principal,b.interest,b.savings,cf=isnull((b.cf),0),lh=isnull((b.lh),0),"
        sql += "ttlprnpaid=isnull((select SUM(principal+advprincipal) from LoanCollect where pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((select SUM(intpaid+AdvInterest) from LoanCollect where pnnumber=a.pnnumber),0),"
        sql += "payno=isnull((select count(payno)+1 from loancollect where pnnumber=a.pnnumber),1)"
        sql += "FROM  Loans a,Loansched b, Members c "
        sql += "WHERE a.pnnumber=b.pnnumber AND a.memcode=c.memcode AND a.pnnumber='" & pnnumber & "' AND a.status='A' and b.duedate='" & cbo_collections.Text & "' "
        sql += "GROUP BY a.memcode,a.pnnumber,c.Fullname,a.interestdue,a.grpcode,b.principal,b.interest,b.savings,b.cf,b.lh,b.duedate"


        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            lblfname.Text = rd("Fullname").ToString
            prndue = Double.Parse(rd("rngprin"))
            intdue = Double.Parse(rd("rngint"))
            prinbal = Double.Parse(rd("prnamnt")) - Double.Parse(rd("ttlprnpaid"))
            intbal = Double.Parse(rd("interestdue")) - Double.Parse(rd("ttlintpaid"))
            life_health = rd("LH").ToString
            'If chkfullpaid.Checked = True Then
            '    cf = 0
            '    p_savings = 0
            'Else
            cf = 0
            p_savings = 0
            'End If
            Try
                payno = rd("payno").ToString
            Catch ex As Exception
                payno = 1
            End Try
        End If
        rd.Close()
        myConn.Close()
        txtprnpaid.Text = prndue.ToString
        txtintdue.Text = intdue.ToString
        txtcf.Text = cf.ToString
        txtsa_amount.Text = p_savings.ToString
        txtlife_health.Text = life_health
        total_amntpaid = ((((prndue + intdue) + cf) + p_savings) + life_health)
        txtamount_paid.Text = total_amntpaid
        compute_payment()
        'lblrunbal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", (runbal - (Double.Parse(txtamountdue.Text) + Double.Parse(txtadvprn.Text)) - Double.Parse(txtintdue.Text)))
    End Sub

    Private Sub edit()
        'Dim ischeckedLH As Boolean
        Dim ischeckedoffset As Boolean
        'If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
        conn()
        sql = "select a.memcode,a.fullname,a.address,b.* from members a, loans b where a.memcode=b.memcode and b.pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            address = rd("address").ToString
            txtmember.SelectedValue = rd("MemCode").ToString
            txtctr.SelectedValue = rd("ctrcode").ToString

            cbogrpcode.Text = rd("grpcode").ToString
            dtrel.Value = rd("releasedate").ToString
            dtschedoffirst.Value = rd("firstpaymentdate").ToString
            txtlnamnt.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("loanamnt"))
            txtdeduction.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("TotalDeduction"))
            txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("netproceeds"))
            txtschdlnamnt.Text = rd("loanamnt").ToString
            txtschdinterestperann.Text = rd("Intrate").ToString
            penaltyrate = rd("penaltyrate").ToString
            txtloantype.SelectedValue = rd("loantype")
            loanrate = rd("Intrate").ToString
            cbo_collateral.Text = rd("col_type").ToString
            txtloan_purpose.Text = rd("purpose").ToString
            txtcycle.Text = rd("cycle").ToString
            txtschdpayable.Text = rd("payno").ToString
            payable = rd("payno").ToString
            loantype = rd("loantype").ToString
            adjmatdate = rd("maturitydate").ToString
            txtsaacct.Text = rd("accountnumber").ToString

            txtsch_weeks.Text = rd("ModeofPayment").ToString
            cboterms.Text = rd("ModeofPayment").ToString
            txtpayno.Value = rd("Payno").ToString
            txtsubproduct.SelectedValue = rd("Subproductcode").ToString
            'Try
            '    ischeckedLH = rd("isCheckedLH").ToString
            'Catch ex As Exception
            '    ischeckedLH = False
            'End Try
            'chklh.Checked = ischeckedLH
            Try
                ischeckedoffset = rd("isOffset").ToString
            Catch ex As Exception
                ischeckedoffset = False
            End Try
        End If
        rd.Close()
        myConn.Close()
        chk_offset.Checked = ischeckedoffset
        txtmember.SelectedValue = member_code

        gen_savbalance()
        conn()
        sql = "select a.CollCode from officer a, loans b where a.CollCode=b.CollCode and b.pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtcoll.SelectedValue = rd("CollCode").ToString
        End If
        rd.Close()
        myConn.Close()

        conn()
        ' this is original
        'sql = "select a.loancode,a.cbu,a.CF,a.SavingsPrcnt from loantype a, loans b where a.loancode=b.loantype and b.pnnumber='" & loannumber & "'"

        ' this is modified, added column LH
        ' 09/23/2021
        sql = "select a.loancode,a.cbu,a.CF,a.SavingsPrcnt, a.LH from loantype a, loans b where a.loancode=b.loantype and b.pnnumber='" & loannumber & "'"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtloantype.SelectedValue = loantype
            cbu = rd("cbu")
            cf = rd("CF")
            savingsrate = rd("SavingsPrcnt")

            'added 09/23/2021 added lh from table
            lh = rd("lh")
        End If
        rd.Close()
        myConn.Close()


        conn()
        sql = "select a.accountnumber from accountmaster a, loans b where a.memcode=b.memcode and a.accountstatus='Active' and b.pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtsaacct.Text = rd("Accountnumber").ToString
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "select a.fundcode from Funding a, loans b where a.fundcode=b.fundcode and b.pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtfunding.SelectedValue = rd("FundCode").ToString
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "select a.* from loancomaker a, loans b where a.pnnumber=b.pnnumber and b.pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtcomaker.Text = rd("CoMaker").ToString
            txtcoaddress.Text = rd("CMkrAddress").ToString
            txtcocontact.Text = rd("ContactNumber").ToString
        End If
        rd.Close()
        myConn.Close()

        select_cycle()
        view_sched()
        get_pnnumber()
        view_loansched()
        'For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
        '    Try
        '        txtdeduction.Text = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + Double.Parse(txtdeduction.Text)
        '    Catch ex As Exception

        '    End Try
        'Next
        txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(txtlnamnt.Text) - Double.Parse(txtdeduction.Text))
        txtfunding.Focus()
        txtfunding.TabIndex = 0
        'bttnnew.Enabled = False
        'Else
        'bttn_gensched.Enabled = False
        'End If
    End Sub

    Private Sub view_sched()
        lblintdue.Text = 0
        lblprndue.Text = 0
        lstgensched.Items.Clear()
        conn()
        sql = "SELECT LnNum,CONVERT(VARCHAR(12),DueDate,107),Principal,Interest,savings,CF,CBU,LH,AmntRcvbl FROM Loansched WHERE pnnumber='" & loannumber & "' order by LnNum"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstgensched.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
        For x As Integer = 0 To lstgensched.Items.Count - 1
            If x Mod 2 Then
                lstgensched.Items(x).BackColor = Color.AliceBlue
            Else
                lstgensched.Items(x).BackColor = Color.White
            End If

            If x = payable - 1 Then
                lblmatdate.Text = lstgensched.Items(x).SubItems(1).Text
            End If
            lblprndue.Text = Double.Parse(lstgensched.Items(x).SubItems(2).Text) + Double.Parse(lblprndue.Text)
            lblintdue.Text = Double.Parse(lstgensched.Items(x).SubItems(3).Text) + Double.Parse(lblintdue.Text)
        Next
    End Sub

    Private Sub gen_fund()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM Funding"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("fundcode").ToString, rd("funddesc").ToString)
        End While
        txtfunding.DataSource = table1
        Me.txtfunding.AutoFilter = True
        txtfunding.DisplayMember = "Description"
        txtfunding.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtfunding.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtfunding.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtfunding.EditorControl.Columns(0).Width = 90
        Me.txtfunding.EditorControl.Columns(1).Width = 200
        Me.txtfunding.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub

    Private Sub view_ctr()
        Dim dtTest As DataTable = New DataTable()
        dtTest.Columns.Add("Center Code", GetType(String))
        dtTest.Columns.Add("Center Name", GetType(String))

        conn()
        If Me.Text = "View Loan" Then
            sql = "select * from center where  status='A' order by ctrname"
        Else
            sql = "select * from center where gl_loans='" & GL_loans & "' and status='A' order by ctrname"
        End If

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            If rdb_ctrcheif.Checked = True Then
                dtTest.Rows.Add(rd("ctrcode"), rd("ctrchief") & "_" & rd("ctrcode"))
            Else
                dtTest.Rows.Add(rd("ctrcode"), rd("ctrname") & "_" & rd("ctrcode"))
            End If

        End While
        rd.Close()
        myConn.Close()

        ' Bind the ComboBox to the DataTable
        Me.txtctr.DataSource = dtTest
        Me.txtctr.DisplayMember = "Center Name"
        Me.txtctr.ValueMember = "Center Code"

        ' Enable the owner draw on the ComboBox.
        Me.txtctr.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items
    End Sub

    Public Sub gen_pnnumber()
        conn()
        sql = "select LastLNCode from LoanNumberSeries WHERE CYear='" & systemdate.Year.ToString & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            Try
                loan_code = Double.Parse(rd("LastLNCode")) + 1
            Catch ex As Exception
                loan_code = 1
            End Try
        Else
            insertloancode()
        End If
        rd.Close()
        myConn.Close()
        txtlno.Text = branchcode.ToString & "-" & code_series & loan_code.ToString("000000") & "-" & systemdate.Year.ToString.Substring(2, 2)
    End Sub

    Private Sub insertloancode()
        conn()
        sql = "INSERT INTO LoanNumberSeries(LastLNCode,CYear) VALUES ('000000','" & systemdate.Year.ToString & "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        gen_pnnumber()
    End Sub

    Private Sub gen_sched()
        If txtctr.Text.Trim <> "" Then
            Dim exday As DayOfWeek
            conn()
            sql = "SELECT ColDayno FROM Center WHERE ctrcode='" & txtctr.SelectedValue & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("ColDayno") = 1 Then
                    exday = DayOfWeek.Monday
                ElseIf rd("ColDayno") = 2 Then
                    exday = DayOfWeek.Tuesday
                ElseIf rd("ColDayno") = 3 Then
                    exday = DayOfWeek.Wednesday
                ElseIf rd("ColDayno") = 4 Then
                    exday = DayOfWeek.Thursday
                End If

                Dim today As Date = dtrel.Value
                Dim dayIndex As Integer = today.DayOfWeek
                If dayIndex < exday Then
                    dayIndex += 7
                End If
                Dim dayDiff As Integer = dayIndex - exday
                Dim frstched As Date = today.AddDays(-dayDiff + 7)
                dtschedoffirst.Value = frstched
            End If

            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub dtrel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtrel.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    Private Sub dtrel_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtrel.Validated
        gen_sched()
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        ' this is the original
        sql = "SELECT loancode,loandesc,rate,cf,savingsprcnt FROM Loantype where gl_loans='" & GL_loans & "'"

        ' modified 09/23/2021, added lh column from loantype table
        sql = "SELECT loancode,loandesc,rate,cf,savingsprcnt, lh FROM Loantype where gl_loans='" & GL_loans & "'"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Columns.Add("Rate")
        table1.Columns.Add("CF")
        table1.Columns.Add("Savings")

        'added 09/23/2021
        table1.Columns.Add("LH")

        ' table1.Rows.Add("-select-", "-select-", "-select-", "-select-", "-select-")
        'table1.Rows.Add("-select-", "-select-", 0, 0, 0)
        While (rd.Read())
            ' this is the original
            'table1.Rows.Add(rd("loancode").ToString, rd("loandesc").ToString, rd("Rate").ToString, rd("CF").ToString, rd("savingsprcnt").ToString)

            ' modified 09/23/2021 add lh column
            table1.Rows.Add(rd("loancode").ToString, rd("loandesc").ToString, rd("Rate").ToString, rd("CF").ToString, rd("savingsprcnt").ToString, rd("lh").ToString)
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
        Me.txtloantype.EditorControl.Columns(2).Width = 60
        Me.txtloantype.EditorControl.Columns(3).Width = 60
        Me.txtloantype.EditorControl.Columns(4).Width = 60

        'added 09/23/2021 add 1 column
        Me.txtloantype.EditorControl.Columns(5).Width = 60

        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub setgrpcode()
        Try
            conn()
            sql = "SELECT DISTINCT grpcode FROM Loans WHERE ctrcode='" & txtctr.SelectedValue.ToString & "' ORDER BY grpcode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            cbogrpcode.Items.Clear()
            While rd.Read
                cbogrpcode.Items.Add(rd("grpcode").ToString)
            End While
            rd.Close()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gen_loansched()
        'If chklh.Checked = True Then
        '    If cboterms.Text = "Daily" Then
        '        lh = 1
        '    ElseIf cboterms.Text = "Week(s)" Then
        '        lh = 5
        '    ElseIf cboterms.Text = "Semi-Monthly" Then
        '        lh = 10
        '    ElseIf cboterms.Text = "Month(s)" Then
        '        lh = 20
        '    End If
        'Else
        '    lh = 0
        'End If

        ' added 09/23/2021
        ' add a LH column to Covid Fund of 10 pesos per week
        ' requested by Sam Coyoca
        'lh = 10.0


        txtsch_weeks.Text = cboterms.Text
        lstgensched.Items.Clear()
        Dim dtsched As Date = dtschedoffirst.Value
        Dim payno As Integer = 0
        Dim intdue As Decimal = 0
        Dim prndue As Decimal = 0
        Dim ttlmarkup As Decimal = 0
        Dim ttlnamount As Decimal = 0
        Dim ttlreceivable As Decimal = 0
        Dim loanamnt As Decimal = Double.Parse(txtlnamnt.Text)
        txtschdlnamnt.Text = txtlnamnt.Text
        txtschdpayable.Text = payable
        prndue = Double.Parse(txtlnamnt.Text) / payable
        intdue = (Double.Parse(txtlnamnt.Text) * (loanrate / 100)) / payable
        lblprndue.Text = 0
        lblintdue.Text = 0

        'countsavings
        Dim ttlsavings As Decimal = 0
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            If dtgrd_deduction.Rows(i).Cells(0).Value = "003" Or dtgrd_deduction.Rows(i).Cells(0).Value = "004" Or dtgrd_deduction.Rows(i).Cells(0).Value = "007" Then
                ttlsavings = ttlsavings + Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value)
            End If
        Next
        savings = (Double.Parse(txtlnamnt.Text) * (savingsrate / 100)) / payable
        ' MsgBox(savingsrate)
        'end countsavings

        'generate schedule
        For x As Integer = 0 To payable - 1
            'conn()
            'sql = "Select * from Reg_holidays where date='" & dtsched.ToString & "'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'rd = cmd.ExecuteReader
            'If rd.Read Then
            '    If txtsch_weeks.Text = "Daily" Then
            '        dtsched = dtsched.AddDays(1)
            '    ElseIf txtsch_weeks.Text = "Week(s)" Then
            '        dtsched = dtsched.AddDays(7)
            '    ElseIf txtsch_weeks.Text = "Semi-Monthly" Then
            '        dtsched = dtsched.AddDays(15)
            '    ElseIf txtsch_weeks.Text = "Month(s)" Then
            '        dtsched = dtsched.AddMonths(1)
            '    ElseIf txtsch_weeks.Text = "Year(s)" Then
            '        dtsched = dtsched.AddYears(1)
            '    End If
            'End If
            'rd.Close()
            'myConn.Close()

            payno = payno + 1
            Dim lvitem As New ListViewItem(payno)
            lvitem.SubItems.Add(Format(dtsched, "MMM,d,yyyy"))
            Dim lstprndue As Decimal = 0
            Dim lstintdue As Decimal = 0
            If x = (payable - 1) Then
                'MsgBox(lblprndue.Text)
                If Me.Text = "Re-Construct Loan" Then
                    lstprndue = Double.Parse(txtlnamnt.Text) - Double.Parse(lblprndue.Text)
                    lstintdue = Double.Parse(frm_recons_amount.txtpdi.Text) - Double.Parse(lblintdue.Text)
                Else
                    lstprndue = Double.Parse(txtlnamnt.Text) - Double.Parse(lblprndue.Text)
                    lstintdue = (Double.Parse(txtlnamnt.Text) * (loanrate / 100)) - Double.Parse(lblintdue.Text)
                End If

                lvitem.SubItems.Add(lstprndue.ToString("F", CultureInfo.InvariantCulture))
                lvitem.SubItems.Add(lstintdue.ToString("F", CultureInfo.InvariantCulture))
            Else
                lvitem.SubItems.Add(prndue.ToString("F", CultureInfo.InvariantCulture))
                lvitem.SubItems.Add(intdue.ToString("F", CultureInfo.InvariantCulture))
            End If

            lvitem.SubItems.Add(savings)
            lvitem.SubItems.Add(cf)
            lvitem.SubItems.Add(cbu)
            lvitem.SubItems.Add(lh)
            lstgensched.Items.Add(lvitem)

            ttlreceivable = Double.Parse(lstgensched.Items(x).SubItems(2).Text) + Double.Parse(lstgensched.Items(x).SubItems(3).Text) + Double.Parse(lstgensched.Items(x).SubItems(4).Text) + Double.Parse(lstgensched.Items(x).SubItems(5).Text + Double.Parse(lstgensched.Items(x).SubItems(6).Text))
            lvitem.SubItems.Add(ttlreceivable.ToString("F", CultureInfo.InvariantCulture))
            '
            lvitem.SubItems.Add(Double.Parse(lstgensched.Items(x).SubItems(2).Text) * Double.Parse(payno))
            lvitem.SubItems.Add(Double.Parse(lstgensched.Items(x).SubItems(3).Text) * Double.Parse(payno))

            If cboterms.Text = "Daily" Then
                dtsched = dtsched.AddDays(1)
            ElseIf cboterms.Text = "Week(s)" Then
                dtsched = dtsched.AddDays(7)
            ElseIf cboterms.Text = "Semi-Monthly" Then
                dtsched = dtsched.AddDays(15)
            ElseIf cboterms.Text = "Month(s)" Then
                dtsched = dtsched.AddMonths(1)
            ElseIf cboterms.Text = "Year(s)" Then
                dtsched = dtsched.AddYears(1)
            End If

            'If x = payable - 1 Then
            Dim dtmat As DateTime = lstgensched.Items(x).SubItems(1).Text
            lblmatdate.Text = dtmat.ToString("M/d/yyyy")
            'End If
            lblprndue.Text = Double.Parse(lstgensched.Items(x).SubItems(2).Text) + Double.Parse(lblprndue.Text)
            lblintdue.Text = Double.Parse(lstgensched.Items(x).SubItems(3).Text) + Double.Parse(lblintdue.Text)
        Next
        'Catch ex As Exception

        'End Try

        For x As Integer = 0 To lstgensched.Items.Count - 1
            If x Mod 2 Then
                lstgensched.Items(x).BackColor = Color.AliceBlue
            Else
                lstgensched.Items(x).BackColor = Color.White
            End If
        Next

        'bttnsave.Enabled = True
        bttnsave.Focus()

        bttndisclosure.Enabled = True
        bttnpromissory.Enabled = True
    End Sub

    'Private Sub gen_deduction()

    'End Sub

    Private Sub insert_comaker()
        conn()
        sql = "INSERT INTO LoanComaker(PnNumber,CoMaker,CMkrAddress,ContactNumber,GL_loans) VALUES ('" & txtlno.Text & "','" & txtcomaker.Text & "','" & txtcoaddress.Text & "','" & txtcocontact.Text & "','" & GL_loans & "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub update_comaker()
        conn()
        sql = "UPDATE LoanComaker set CoMaker='" & txtcomaker.Text & "',ContactNumber='" & txtcocontact.Text & "',CMkrAddress='" & txtcoaddress.Text & "' WHERE pnnumber='" & txtlno.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub update_pnnumber()
        conn()
        sql = "UPDATE LoanNumberSeries SET LastLNCode='" & loan_code.ToString("000000") & "' WHERE CYear='" & systemdate.Year.ToString & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub insert_deductions()
        conn()
        For ded As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            If dtgrd_deduction.Rows(ded).Cells(1).Value <> "" Then
                'MsgBox(dtgrd_deduction.Rows(ded).Cells(3).Value.ToString)
                sql = "INSERT INTO LoansDeduction(PnNumber,code,Description,Amount,Acro) VALUES ('" & txtlno.Text & "','" & dtgrd_deduction.Rows(ded).Cells(1).Value & "','" & dtgrd_deduction.Rows(ded).Cells(3).Value.ToString & "'," & Double.Parse(dtgrd_deduction.Rows(ded).Cells(2).Value).ToString & ",'" & dtgrd_deduction.Rows(ded).Cells(4).Value.ToString & "')"
                'MsgBox(sql.ToString)
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next

        'insert the deduction of loan balance.... 11/21/2024
        Dim cdeductioncode As String
        Dim cdeductiondesc As String
        Dim nLoanBalance As Decimal
        Dim cAcroname As String

        cdeductioncode = "999"
        cdeductiondesc = "Loan Balance"
        nLoanBalance = txtLoanBalance.Text 'LOAN BALANCE VALUE
        cAcroname = "OFS"

        'conn()
        'sql = "INSERT INTO LoansDeduction(PnNumber,code,Description,Amount,Acro) VALUES ('" & txtlno.Text & "','" & '"cdeductioncode"' & "','" & dtgrd_deduction.Rows(ded).Cells(3).Value.ToString & "'," & Double.Parse(dtgrd_deduction.Rows(ded).Cells(2).Value).ToString & ",'" & dtgrd_deduction.Rows(ded).Cells(4).Value.ToString & "')"
        'sql = "INSERT INTO LoansDeduction(PnNumber,code,Description,Amount,Acro) VALUES ('" & txtlno.Text & "','" & cdeductioncode & "','" & cdeductiondesc & "'," & nLoanBalance & ",'" & cAcroname & "')"
        sql = "INSERT INTO LoansDeduction(PnNumber, code, Description, Amount, Acro ) VALUES ('" & txtlno.Text & "', '" & cdeductioncode & "', '" & cdeductiondesc & "', '" & nLoanBalance & "', '" & cAcroname & "' )       "

        'MessageBox.Show(sql)

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Private Sub insert_sched()
        conn()
        For i As Integer = 0 To lstgensched.Items.Count - 1
            Dim prndue As Decimal = lstgensched.Items(i).SubItems(2).Text
            If lstgensched.Items(i).SubItems(0).Text <> "" Then
                sql = "INSERT INTO Loansched(PnNumber,LnNum,DueDate,Principal,Interest,savings,CF,cbu,LH,AmntRcvbl,rngprin,rngint) VALUES "
                sql += "('" & txtlno.Text & "',"
                sql += "" & lstgensched.Items(i).SubItems(0).Text & ","
                sql += "'" & lstgensched.Items(i).SubItems(1).Text & "',"
                sql += "" & lstgensched.Items(i).SubItems(2).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(3).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(4).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(5).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(6).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(7).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(8).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(9).Text & ","
                sql += "" & lstgensched.Items(i).SubItems(10).Text & ""
                sql += ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub clear()
        txtctr.Text = ""
        txtfunding.Text = ""
        txtlnamnt.Text = "0.00"
        txtlno.Clear()
        txtcoll.Text = ""
        txtlnproceeds.Text = 0
        txtdeduction.Text = 0
        txtschdinterestperann.Text = 0
        txtschdlnamnt.Text = 0
        txtschdpayable.Text = 0
        txtloantype.Text = ""
        dtgrd_deduction.Rows.Clear()
    End Sub

    Private Sub cbofullname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            gen_pnnumber()
            txtlno.Text = "01-" & loanstr.ToString("000000") & "-" & systemdate.Year.ToString.Substring(2, 2)
            txtfunding.Focus()
        End If
    End Sub

    Private Sub cbocoll_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtloantype.Focus()
        End If
    End Sub

    Private Sub txtctr_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cbogrpcode.Focus()
        End If
    End Sub

    Private Sub cbogrpcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbogrpcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtrel.Focus()
        End If
    End Sub

    Private Sub dtschedoffirst_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtschedoffirst.Validated
        dtpart = DateDiff(DateInterval.Weekday, dtrel.Value, dtschedoffirst.Value)
    End Sub

    Private Sub txtcomaker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcomaker.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcoaddress.Focus()
        End If
    End Sub

    Private Sub txtcoaddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcoaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcocontact.Focus()
        End If
    End Sub

    Private Sub bttndisclosure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndisclosure.Click
        frm_disclosure.ShowDialog()
    End Sub

    Private Sub bttnpromissory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnpromissory.Click
        frm_promisorry_note.ShowDialog()
    End Sub

    Private Sub txtfname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtfunding.Focus()
        End If
    End Sub

    Private Sub txtfname_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Me.Text = "View Loan" Then
            gen_pnnumber()
            select_cycle()
        End If
    End Sub

    Private Sub txtloantype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtloantype.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboterms.Focus()
        End If
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        gen_loan_rate()
    End Sub

    Private Sub gen_loan_rate()
        'Try
        conn()
        sql = "SELECT * FROM loantype WHERE loancode=" & txtloantype.SelectedValue.ToString & ""
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            loantype = rd("loancode").ToString
            loanrate = rd("rate") * payable
            cf = rd("CF").ToString
            savingsrate = rd("SavingsPrcnt").ToString
            penaltyrate = rd("penaltyrate").ToString
            txtschdinterestperann.Text = loanrate.ToString
            cbu = rd("CBU").ToString

            'added 09/23/2021 added lh 
            lh = rd("lh").ToString

        End If
        rd.Close()
        myConn.Close()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        Dim cRenewLoanNumber As String
        Dim cSql As String

        'save original loan number
        If Me.Text = "ReNew Loan" Then
            cRenewLoanNumber = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value
        End If

        'Try
        If txtmember.Text.Trim = "" Then
            MsgBox("Members name is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtmember.Focus()
        ElseIf txtlno.Text = "(auto generated)" Then
            MsgBox("Invalid loan number.", MsgBoxStyle.Exclamation, "Invalid")
            txtfunding.Focus()
        ElseIf txtfunding.SelectedValue = "" Then
            MsgBox("Invalid selection of funding.", MsgBoxStyle.Exclamation, "Invalid")
            txtfunding.Focus()
        ElseIf txtcoll.SelectedValue = "" Then
            MsgBox("Invalid selection of officer.", MsgBoxStyle.Exclamation, "Invalid")
            txtcoll.Focus()
        ElseIf txtloantype.SelectedValue = "" Then
            MsgBox("Invalid selection of loan type.", MsgBoxStyle.Exclamation, "Invalid")
            txtloantype.Focus()
        ElseIf txtsaacct.Text = "" And multiproduct = "N" Then
            MsgBox("Invalid selection of savings account.", MsgBoxStyle.Exclamation, "Invalid")
            txtsaacct.Focus()
        ElseIf txtctr.SelectedValue = "" Then
            MsgBox("Invalid selection of center.", MsgBoxStyle.Exclamation, "Invalid")
            txtctr.Focus()
        ElseIf cbogrpcode.Text.Trim = "" Then
            MsgBox("Group No. is required.", MsgBoxStyle.Exclamation, "Invalid")
            cbogrpcode.Focus()
        ElseIf cboterms.Text.Trim = "" Then
            MsgBox("Term field is required.", MsgBoxStyle.Exclamation, "Invalid")
            cboterms.Focus()
        ElseIf multiproduct = "N" And txtsaacct.Text.Trim = "" Then
            MsgBox("Savings account is empty. Create savings account first to save this loan.", MsgBoxStyle.Exclamation, "Invalid Savings Acct.")
        ElseIf IsNumeric(txtlnamnt.Text) = False Then
            MsgBox("Invalid Loan Amount.", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        ElseIf Double.Parse(txtlnamnt.Text) < 1 Then
            MsgBox("Loan amount should be greater than 0.", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        ElseIf txtsaacct.Text = "Savings not found" Then
            MsgBox("Savings not found", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        Else
            'gen_sacct()
            gen_cbuacct()
            gen_loan_rate()
            If Me.Text = "Edit Loan" Then
                If MessageBox.Show("Are you sure you want to update this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    conn()
                    sql = "UPDATE Loans SET CollCode='" & txtcoll.SelectedValue & "',"
                    sql += "FundCode='" & txtfunding.SelectedValue & "',"
                    sql += "LoanAmnt=" & Double.Parse(txtlnamnt.Text).ToString & ","
                    sql += "netproceeds=" & Double.Parse(txtlnproceeds.Text).ToString & ","
                    sql += "IntRate=" & txtschdinterestperann.Text & ","
                    sql += "ModeofPayment='" & cboterms.Text & "',"
                    sql += "Status='A',Released='N',userid='" & user.ToString & "',"
                    sql += "loantype='" & txtloantype.SelectedValue & "',"
                    sql += "Firstpaymentdate='" & dtschedoffirst.Value & "',"
                    sql += "releasedate='" & dtrel.Value & "',"
                    sql += "cycle=" & txtcycle.Text & ","
                    sql += "ctrcode='" & txtctr.SelectedValue & "',"
                    sql += "col_type='" & cbo_collateral.Text & "',"
                    sql += "purpose='" & txtloan_purpose.Text & "',"
                    sql += "TotalDeduction=" & Double.Parse(txtdeduction.Text).ToString & ","
                    sql += "grpcode='" & cbogrpcode.Text & "',"
                    sql += "accountnumber='" & txtsaacct.Text & "',"
                    sql += "isCheckedLH='False',"
                    sql += "isOffset='" & chk_offset.Checked.ToString & "'"
                    sql += " WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "DELETE FROM Beneficiary WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()

                    conn()
                    sql = "DELETE FROM LoansDeduction WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()

                    conn()
                    sql = "DELETE FROM LoanItems WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    update_comaker()
                    insert_deductions()
                    insert_benefeciary()
                    insert_offset_account()
                    insert_loansched()
                    MsgBox("Loan Number " & txtlno.Text & " was successfully updated.", MsgBoxStyle.Information)
                    bttnsave.Enabled = False
                End If

            ElseIf Me.Text = "View Loan" Then
                If usertype = "Admin" Then
                    conn()
                    sql = "UPDATE Loans SET CollCode='" & txtcoll.SelectedValue & "',"
                    sql += "FundCode='" & txtfunding.SelectedValue & "',"
                    sql += "LoanAmnt=" & Double.Parse(txtlnamnt.Text).ToString & ","
                    sql += "netproceeds=" & Double.Parse(txtlnproceeds.Text).ToString & ","
                    sql += "IntRate=" & txtschdinterestperann.Text & ","
                    sql += "ModeofPayment='" & cboterms.Text & "',"
                    sql += "userid='" & user.ToString & "',"
                    sql += "loantype='" & txtloantype.SelectedValue & "',"
                    sql += "Firstpaymentdate='" & dtschedoffirst.Value & "',"
                    sql += "releasedate='" & dtrel.Value & "',"
                    sql += "cycle=" & txtcycle.Text & ","
                    sql += "ctrcode='" & txtctr.SelectedValue & "',"
                    sql += "col_type='" & cbo_collateral.Text & "',"
                    sql += "purpose='" & txtloan_purpose.Text & "',"
                    sql += "grpcode='" & cbogrpcode.Text & "',"
                    sql += "accountnumber='" & txtsaacct.Text & "',"
                    sql += "isCheckedLH='False'"
                    sql += " WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    insert_loansched()
                Else
                    conn()
                    sql = "UPDATE loans set CollCode='" & txtcoll.SelectedValue.ToString & "', "
                    sql += "Firstpaymentdate='" & dtschedoffirst.Value & "',"
                    sql += "accountnumber='" & txtsaacct.Text & "',ctrcode='" & txtctr.SelectedValue.ToString & "',grpcode='" & cbogrpcode.Text & "' WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    insert_loansched()


                    'Dim lh As Double = 0
                    'If chklh.Checked = True Then
                    '    If cboterms.Text = "Daily" Then
                    '        lh = 1
                    '    ElseIf cboterms.Text = "Week(s)" Then
                    '        lh = 5
                    '    ElseIf cboterms.Text = "Semi-Monthly" Then
                    '        lh = 10
                    '    ElseIf cboterms.Text = "Month(s)" Then
                    '        lh = 20
                    '    End If
                    'Else
                    '    lh = 0
                    'End If
                    conn()
                    sql = "UPDATE loansched set LH='" & lh.ToString & "' WHERE pnnumber='" & txtlno.Text & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                End If
                'bttn_gensched.Enabled = False
                'MsgBox(txtsaacct.SelectedValue)

                'insert_loansched()

                conn()
                Dim reasons As String = "Editing loans(view loans) of " & txtmember.Text & " to " & loanrate & "rate- " & cboterms.Text & " term- " & txtcoll.SelectedValue & " collector code"
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                MsgBox("Loan Number " & txtlno.Text & " was successfully updated.", MsgBoxStyle.Information, "Success")
                bttnsave.Enabled = False

            ElseIf Me.Text = "Re-Construct Loan" Then
                gen_pnnumber()

                conn()
                sql = "INSERT INTO Loans(Memcode,Pnnumber,CollCode,FundCode,LoanAmnt,TotalDeduction,netproceeds,IntRate,modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,ctrcode,grpcode,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,GL_loans,isCheckedLH,isOffset,Restructured,subproductcode) VALUES "
                sql += "('" & txtmember.SelectedValue & "',"
                sql += "'" & txtlno.Text & "',"
                sql += "'" & txtcoll.SelectedValue.ToString & "',"
                sql += "'" & txtfunding.SelectedValue.ToString & "',"
                sql += "" & Double.Parse(txtlnamnt.Text).ToString & ","
                sql += "" & txtdeduction.Text & ","
                sql += "" & Double.Parse(txtlnproceeds.Text).ToString & ","
                sql += "" & loanrate.ToString & ","
                sql += "'" & cboterms.Text & "',"
                sql += "'" & systemdate.ToString & "',"
                sql += "'A',"
                sql += "'Y',"
                sql += "'" & user.ToString & "',"
                sql += "'" & txtloantype.SelectedValue & "',"
                sql += "" & txtcycle.Text & ","
                sql += "'" & dtschedoffirst.Value & "',"
                sql += "'" & dtrel.Value & "',"
                sql += "'" & txtctr.SelectedValue & "',"
                sql += "" & cbogrpcode.Text & ","
                sql += "'" & cbo_collateral.Text & "',"
                sql += "'" & txtloan_purpose.Text & "',"
                sql += "" & payable.ToString & ","
                sql += "" & penaltyrate.ToString & ","
                sql += "'" & txtsaacct.Text & "',"
                sql += "'" & GL_loans & "',"
                sql += "'False',"
                sql += "'" & chk_offset.Checked.ToString & "',"
                sql += "'Yes',"
                sql += "'" & txtsubproduct.SelectedValue & "'"
                sql += ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                insert_deductions()
                insert_offset_account()
                insert_comaker()
                insert_benefeciary()

                txtschdlnamnt.Text = txtlnamnt.Text
                insert_loansched()
                update_pnnumber()
                loannumber = txtlno.Text
                bttnsave.Enabled = False

            ElseIf Me.Text = "ReNew Loan" Then
                'MsgBox("You are about to save this Renew Loan", MsgBoxStyle.Exclamation, "Renew Loan")
                'MsgBox("Loan number " & txtlno.Text)

                'store old pnnumber to new loan number
                cRenewLoanNumber = cRenewLoanNumber

                'get new loan number
                gen_pnnumber()

                conn()
                sql = "SELECT pnnumber FROM loans where pnnumber='" & txtlno.Text & "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If Not rd.Read Then
                    If MessageBox.Show("Are you sure you want to save this Renew loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        'cRenewLoanNumber
                        gen_pnnumber()


                        cSql = "'False',"
                        cSql += "'" & chk_offset.Checked.ToString & "',"
                        cSql += "'" & cRenewLoanNumber & "'"
                        cSql += ")"
                        'MsgBox(cSql)

                        'RenewLoanNumber

                        conn()
                        'sql = "INSERT INTO Loans(Memcode,Pnnumber,CollCode,FundCode,LoanAmnt,TotalDeduction,netproceeds,IntRate,modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,ctrcode,grpcode,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,GL_loans,isCheckedLH, isOffset ) VALUES "
                        'sql += "('" & txtmember.SelectedValue & "',"                    'Memcode
                        'sql += "'" & txtlno.Text & "',"                                 'Pnnumber
                        'sql += "'" & txtcoll.SelectedValue.ToString & "',"              'CollCode
                        'sql += "'" & txtfunding.SelectedValue.ToString & "',"           'FundCode
                        'sql += "" & Double.Parse(txtlnamnt.Text).ToString & ","         'LoanAmnt
                        'sql += "" & txtdeduction.Text & ","                             'TotalDeduction
                        'sql += "" & Double.Parse(txtlnproceeds.Text).ToString & ","     'netproceeds
                        'sql += "" & loanrate.ToString & ","                             'IntRate
                        'sql += "'" & cboterms.Text & "',"                               'modeofpayment
                        'sql += "'" & systemdate.ToString & "',"                         'LoanDate
                        'sql += "'A',"                                                   'Status
                        'sql += "'N',"                                                   'Released
                        'sql += "'" & user.ToString & "',"                               'userid
                        'sql += "'" & txtloantype.SelectedValue & "',"                   'loantype
                        'sql += "" & txtcycle.Text & ","                                 'cycle
                        'sql += "'" & dtschedoffirst.Value & "',"                        'firstpaymentdate
                        'sql += "'" & dtrel.Value & "',"                                 'releasedate
                        'sql += "'" & txtctr.SelectedValue & "',"                        'ctrcode
                        'sql += "" & cbogrpcode.Text & ","                               'grpcode
                        'sql += "'" & cbo_collateral.Text & "',"                         'col_type
                        'sql += "'" & txtloan_purpose.Text & "',"                        'Purpose
                        'sql += "" & payable.ToString & ","                              'PayNo
                        'sql += "" & penaltyrate.ToString & ","                          'PenaltyRate
                        'sql += "'" & txtsaacct.Text & "',"                              'Accountnumber  
                        'sql += "'" & GL_loans & "',"                                    'GL_loans,
                        'sql += "'False',"                                               'isCheckedLH
                        'sql += "'" & chk_offset.Checked.ToString & "'"                  'isOffset
                        'sql += "'" & cRenewLoanNumber & "'"                              'Renew Loan number
                        'sql += ")"


                        'sql = "INSERT INTO Loans(Memcode,Pnnumber,CollCode,FundCode,LoanAmnt, TotalDeduction, netproceeds,IntRate,modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,ctrcode,grpcode,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,GL_loans,isCheckedLH,isOffset) VALUES "
                        sql = "INSERT INTO Loans(Memcode,Pnnumber, CollCode, FundCode, LoanAmnt, TotalDeduction, netproceeds, IntRate, modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,ctrcode,grpcode,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,GL_loans,isCheckedLH,isOffset, renewLoanNumber) VALUES "

                        sql += "('" & txtmember.SelectedValue & "',"                    'Memcode
                        sql += "'" & txtlno.Text & "',"                                 'Pnnumber
                        sql += "'" & txtcoll.SelectedValue.ToString & "',"              'CollCode
                        sql += "'" & txtfunding.SelectedValue.ToString & "',"           'FundCode
                        sql += "" & Double.Parse(txtlnamnt.Text).ToString & ","         'LoanAmnt
                        sql += "" & txtdeduction.Text & ","                             'TotalDeduction
                        sql += "" & Double.Parse(txtlnproceeds.Text).ToString & ","     'netproceeds
                        sql += "" & loanrate.ToString & ","                             'IntRate
                        sql += "'" & cboterms.Text & "',"                               'modeofpayment
                        sql += "'" & systemdate.ToString & "',"                         'LoanDate
                        sql += "'A',"                                                   'Status
                        sql += "'N',"                                                   'Released
                        sql += "'" & user.ToString & "',"                               'userid
                        sql += "'" & txtloantype.SelectedValue & "', "                   'loantype
                        sql += "" & txtcycle.Text & ", "                                 'cycle
                        sql += "'" & dtschedoffirst.Value & "',"                        'firstpaymentdate
                        sql += "'" & dtrel.Value & "',"                                 'releasedate
                        sql += "'" & txtctr.SelectedValue & "',"                        'ctrcode
                        sql += "" & cbogrpcode.Text & ","                               'grpcode
                        sql += "'" & cbo_collateral.Text & "',"                         'col_type
                        sql += "'" & txtloan_purpose.Text & "',"                        'Purpose
                        sql += "" & payable.ToString & ","                              'PayNo,,isOffset
                        sql += "" & penaltyrate.ToString & ","                          'PenaltyRate
                        sql += "'" & txtsaacct.Text & "',"                              'Accountnumber  
                        sql += "'" & GL_loans & "',"                                    'GL_loans,
                        sql += "'False',"                                               'isCheckedLH
                        sql += "'" & chk_offset.Checked.ToString & "',"                  'isOffset
                        sql += "'" & cRenewLoanNumber & "'"
                        sql += ")"



                        'MsgBox(sql)

                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()


                        'Set Old loan number to Paid Paid...
                        'updated.... 10/29/2024
                        'sql = "UPDATE loans set Status='O' WHERE pnnumber='" & cRenewLoanNumber & "'"
                        'cmd.ExecuteNonQuery()

                        myConn.Close()

                        insert_deductions()
                        insert_offset_account()
                        insert_comaker()
                        insert_benefeciary()




                        txtschdlnamnt.Text = txtlnamnt.Text
                        insert_loansched()
                        update_pnnumber()
                        loannumber = txtlno.Text
                        bttnsave.Enabled = False
                    Else
                    End If
                    rd.Close()
                    myConn.Close()
                Else
                    MsgBox("Loan number " & txtlno.Text & " is already exist.")
                    update_pnnumber()
                    gen_pnnumber()
                End If




            Else
                conn()
                gen_pnnumber()

                sql = "SELECT pnnumber FROM loans where pnnumber='" & txtlno.Text & "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If Not rd.Read Then
                    If MessageBox.Show("Are you sure you want to save this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        gen_pnnumber()

                        conn()
                        sql = "INSERT INTO Loans(Memcode,Pnnumber,CollCode,FundCode,LoanAmnt,TotalDeduction,netproceeds,IntRate,modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,ctrcode,grpcode,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,GL_loans,isCheckedLH,isOffset) VALUES "
                        sql += "('" & txtmember.SelectedValue & "',"                    'Memcode
                        sql += "'" & txtlno.Text & "',"                                 'Pnnumber
                        sql += "'" & txtcoll.SelectedValue.ToString & "',"              'CollCode
                        sql += "'" & txtfunding.SelectedValue.ToString & "',"           'FundCode
                        sql += "" & Double.Parse(txtlnamnt.Text).ToString & ","         'LoanAmnt
                        sql += "" & txtdeduction.Text & ","                             'TotalDeduction
                        sql += "" & Double.Parse(txtlnproceeds.Text).ToString & ","     'netproceeds
                        sql += "" & loanrate.ToString & ","                             'IntRate
                        sql += "'" & cboterms.Text & "',"                               'modeofpayment
                        sql += "'" & systemdate.ToString & "',"                         'LoanDate
                        sql += "'A',"                                                   'Status
                        sql += "'N',"                                                   'Released
                        sql += "'" & user.ToString & "',"                               'userid
                        sql += "'" & txtloantype.SelectedValue & "',"                   'loantype
                        sql += "" & txtcycle.Text & ","                                 'cycle
                        sql += "'" & dtschedoffirst.Value & "',"                        'firstpaymentdate
                        sql += "'" & dtrel.Value & "',"                                 'releasedate
                        sql += "'" & txtctr.SelectedValue & "',"                        'ctrcode
                        sql += "" & cbogrpcode.Text & ","                               'grpcode
                        sql += "'" & cbo_collateral.Text & "',"                         'col_type
                        sql += "'" & txtloan_purpose.Text & "',"                        'Purpose
                        sql += "" & payable.ToString & ","                              'PayNo,,isOffset
                        sql += "" & penaltyrate.ToString & ","                          'PenaltyRate
                        sql += "'" & txtsaacct.Text & "',"                              'Accountnumber  
                        sql += "'" & GL_loans & "',"                                    'GL_loans,
                        sql += "'False',"                                               'isCheckedLH
                        sql += "'" & chk_offset.Checked.ToString & "'"                  'isOffset
                        sql += ")"
                        cmd = New SqlCommand(sql, myConn)


                        'sql += "'" & txtsaacct.Text & "',"                              'Accountnumber  
                        'sql += "'" & GL_loans & "',"                                    'GL_loans,
                        'sql += "'False',"                                               'isCheckedLH
                        'sql += "'" & chk_offset.Checked.ToString & "',"                  'isOffset
                        'sql += "'" & cRenewLoanNumber & "'"                              'Renew Loan number
                        'sql += ")"
                        'cmd = New SqlCommand(sql, myConn)

                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        insert_deductions()
                        insert_offset_account()
                        insert_comaker()
                        insert_benefeciary()

                        txtschdlnamnt.Text = txtlnamnt.Text
                        insert_loansched()
                        update_pnnumber()
                        loannumber = txtlno.Text
                        bttnsave.Enabled = False
                    Else
                    End If
                    rd.Close()
                    myConn.Close()
                Else
                    MsgBox("Loan number " & txtlno.Text & " is already exist.")
                    update_pnnumber()
                    gen_pnnumber()
                End If
            End If
        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Invalid")
        'End Try
    End Sub

    Private Sub insert_offset_account()
        Try
            conn()
            sql = "DELETE FROM Offset_Payment WHERE memcode='" & member_code & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = sqlstr
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub update_members_saacct()
    '    conn()
    '    sql = "UPDATE Members SET Accountnumber='" & txtsaacct.Text & "' WHERE Memcode='" & txtmemcode.Text & "'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    cmd.ExecuteNonQuery()
    '    myConn.Close()
    'End Sub

    Private Sub update_saving()
        conn()
        sql = "UPDATE SA_AcctnoSeries SET LastLAcctno='" & sanum.ToString("000000") & "' WHERE CYear='" & DateTime.Now.Year.ToString & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub insert_benefeciary()
        For i As Integer = 0 To dtgr_benefeciary.Rows.Count - 1
            If dtgr_benefeciary.Rows(i).Cells(0).Value <> "" Then
                conn()
                sql = "INSERT INTO Beneficiary(pnnumber,fullname,birthdate,relationship) VALUES ('" & txtlno.Text & "','" & dtgr_benefeciary.Rows(i).Cells(0).Value & "','" & dtgr_benefeciary.Rows(i).Cells(1).Value & "','" & dtgr_benefeciary.Rows(i).Cells(2).Value & "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        view_officer()
        gen_fund()
        view_ctr()
        gen_loantype()
        txtlno.Text = "(Auto Generated)"
        dtrel.Value = systemdate
        dtgrd_deduction.Rows.Clear()
        TabControl1.SelectedPage = RadPageViewPage1
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        clear()
        lstgensched.Items.Clear()
        Me.Close()
    End Sub

    Private Sub txtcoll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcoll.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtloantype.Focus()
        End If
    End Sub

    Private Sub txtfunding_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfunding.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcoll.Focus()
        End If
    End Sub


    Private Sub cboctr_Validated1(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            gen_grpcode()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bttnprntched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnprntched.Click
        loannumber = txtlno.Text
        frm_amortsched.ShowDialog()
    End Sub

    Private Sub cboweeks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtlnamnt.Focus()
        End If
    End Sub

    Public Sub creategview_deductions()
        'InitializeComponent()
        dtgrd_deduction.Columns.Clear()
        dtgrd_deduction.Rows.Clear()

        Dim deductionsMF As DataTable = New DataTable()
        conn()
        sql = "SELECT * from deductionMF"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        deductionsMF.Columns.Add("Code")
        deductionsMF.Columns.Add("Descriptions")
        deductionsMF.Columns.Add("Percentage")
        deductionsMF.Columns.Add("Fixed Amount")
        deductionsMF.Columns.Add("Acro")
        While (rd.Read())
            deductionsMF.Rows.Add(rd("code").ToString, rd("Description").ToString, rd("Percentage").ToString, rd("fixedamnt").ToString)
        End While
        rd.Close()
        myConn.Close()

        '0
        comboCol_deduction.DataSource = deductionsMF
        comboCol_deduction.FieldName = "Descriptions"
        comboCol_deduction.DisplayMember = "Descriptions"
        comboCol_deduction.ValueMember = "Code"
        comboCol_deduction.Width = 300
        comboCol_deduction.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgrd_deduction.Columns.Add(comboCol_deduction)

        '1
        Dim acctcode As New GridViewTextBoxColumn("Code")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(acctcode)
        acctcode.ReadOnly = True
        acctcode.Width = 150

        '2
        Dim amount As New GridViewTextBoxColumn("Amount")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(amount)
        'amount.ReadOnly = True
        amount.Width = 120

        '3
        Dim dummy As New GridViewTextBoxColumn("dummy")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(dummy)
        dummy.IsVisible = False

        '4
        Dim acro As New GridViewTextBoxColumn("Acro")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(acro)
        acro.IsVisible = False

        If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
            conn()
            sql = "SELECT * FROM LoansDeduction WHERE pnnumber='" & loannumber & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                dtgrd_deduction.Rows.Add(rd("code").ToString, rd("code").ToString, rd("amount").ToString, rd("Description").ToString, rd("Acro").ToString)
            End While
            rd.Close()
            myConn.Close()
        End If

    End Sub

    Private Sub dtgrd_deduction_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_deduction.CellEditorInitialized
        If dtgrd_deduction.CurrentCell.ColumnIndex = 0 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.dtgrd_deduction.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol_deduction.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
            dtgrd_deduction.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextCell
        End If
    End Sub

    Private Sub dtgrd_deduction_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_deduction.CellEndEdit
        'MsgBox("dtgrd_deduction_CellEndEdit", MsgBoxStyle.Exclamation, "Invalid")

        If e.ColumnIndex = 0 Then
            Try
                conn()
                sql = "SELECT * from deductionMF where code ='" & dtgrd_deduction.CurrentRow.Cells(0).Value.ToString & "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    dtgrd_deduction.CurrentRow.Cells(1).Value = rd("code").ToString
                    dtgrd_deduction.CurrentRow.Cells(3).Value = rd("Description").ToString
                    dtgrd_deduction.CurrentRow.Cells(4).Value = rd("acro").ToString
                    If rd("percentage") > 0 Then
                        If rd("base_on_month") = "Y" Then
                            If cboterms.Text = "Week(s)" Then
                                Dim terms As Integer = Double.Parse(txtpayno.Text) / 4
                                dtgrd_deduction.CurrentRow.Cells(2).Value = Double.Parse(txtlnamnt.Text) * ((Math.Round(terms)) * rd("percentage"))
                            ElseIf cboterms.Text = "Semi-Monthly" Then
                                Dim terms As Integer = Double.Parse(txtpayno.Text) / 2
                                dtgrd_deduction.CurrentRow.Cells(2).Value = Double.Parse(txtlnamnt.Text) * ((Math.Round(terms)) * rd("percentage"))
                            Else
                                dtgrd_deduction.CurrentRow.Cells(2).Value = Double.Parse(txtlnamnt.Text) * (Double.Parse(txtpayno.Text) * rd("percentage"))
                            End If
                        Else
                            dtgrd_deduction.CurrentRow.Cells(2).Value = Double.Parse(txtlnamnt.Text) * rd("percentage")
                        End If
                    Else
                        If rd("acro") = "BCI" Then
                            If cboterms.Text = "Week(s)" Then
                                Dim terms As Integer = Double.Parse(txtpayno.Text) / 4
                                If terms > 12 Then
                                    dtgrd_deduction.CurrentRow.Cells(2).Value = Math.Round(((Double.Parse(txtlnamnt.Text) / 1000) * 1) * (12))
                                Else
                                    dtgrd_deduction.CurrentRow.Cells(2).Value = Math.Round(((Double.Parse(txtlnamnt.Text) / 1000) * 1) * (Math.Round(terms)))
                                End If
                            ElseIf cboterms.Text = "Semi-Monthly" Then
                                Dim terms As Integer = Double.Parse(txtpayno.Text) / 2
                                If terms > 12 Then
                                    dtgrd_deduction.CurrentRow.Cells(2).Value = Math.Round(((Double.Parse(txtlnamnt.Text) / 1000) * 1) * (12))
                                Else
                                    dtgrd_deduction.CurrentRow.Cells(2).Value = Math.Round(((Double.Parse(txtlnamnt.Text) / 1000) * 1) * (Math.Round(terms)))
                                End If
                            Else
                                Dim terms As Integer = Double.Parse(txtpayno.Text)
                                If terms > 12 Then
                                    dtgrd_deduction.CurrentRow.Cells(2).Value = Math.Round(((Double.Parse(txtlnamnt.Text) / 1000) * 1) * (12))
                                Else
                                    dtgrd_deduction.CurrentRow.Cells(2).Value = Math.Round(((Double.Parse(txtlnamnt.Text) / 1000) * 1) * (Math.Round(terms)))
                                End If
                            End If
                        ElseIf rd("acro") = "INS" Then
                            If cboterms.Text = "Week(s)" Then
                                Dim terms As Integer = Double.Parse(txtpayno.Text) / 4
                                dtgrd_deduction.CurrentRow.Cells(2).Value = 50 * (Math.Round(terms))
                            ElseIf cboterms.Text = "Semi-Monthly" Then
                                Dim terms As Integer = Double.Parse(txtpayno.Text) / 2
                                dtgrd_deduction.CurrentRow.Cells(2).Value = 50 * (Math.Round(terms))
                            Else
                                dtgrd_deduction.CurrentRow.Cells(2).Value = 50 * Double.Parse(txtpayno.Text)
                            End If
                        Else
                            dtgrd_deduction.CurrentRow.Cells(2).Value = rd("fixedamnt").ToString
                        End If
                    End If
                    'MsgBox(dtgrd_deduction.CurrentRow.Cells(3).Value)
                End If
                rd.Close()
                myConn.Close()
            Catch ex As Exception
                MessageBox.Show("Please do not select Karamay Fund deduction first to avoid error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End If

        Dim lndeduction As Decimal = 0
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            'If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
            lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
            'End If
        Next
        'txtdeduction.Text = lndeduction

        'MsgBox(lndeduction, MsgBoxStyle.Exclamation, "Deduction")

        'original
        'txtdeduction.Text = lndeduction

        'modified 10/21/2024 formula: deduction + loan balance
        txtdeduction.Text = lndeduction '+ Double.Parse(txtLoanBalance.Text)

        'txtlnamnt.Focus()
        txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction - Decimal.Parse(txtLoanBalance.Text))


        'dtgrd_deduction.CurrentRow.Cells(3).Value = dtgrd_deduction.CurrentCell.Text
    End Sub

    Private Sub dtgrd_deduction_CellValidated(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellValidatedEventArgs) Handles dtgrd_deduction.CellValidated
        Dim lndeduction As Decimal = 0
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            'If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
            lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
            'End If
        Next
        'txtdeduction.Text = lndeduction

        'MsgBox(lndeduction, MsgBoxStyle.Exclamation, "CellValidated Deduction")

        'original
        'txtdeduction.Text = lndeduction

        'modified 10/21/2024 formula: deduction + loan balance
        txtdeduction.Text = lndeduction '+ Double.Parse(txtLoanBalance.Text)

        'txtlnamnt.Focus()
        txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction - Decimal.Parse(txtLoanBalance.Text))

    End Sub

    Private Sub dtgrd_deduction_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrd_deduction.Validated
        Dim lndeduction As Decimal = 0

        'MsgBox("dtgrd_deduction_Validated", MsgBoxStyle.Exclamation, "Invalid")

        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
            End If
        Next

        'original
        'txtdeduction.Text = lndeduction

        'MsgBox(lndeduction, MsgBoxStyle.Exclamation, "Deduction")

        'modified 10/21/2024 formula: deduction + loan balance
        txtdeduction.Text = lndeduction '+ Double.Parse(txtLoanBalance.Text)

        'txtlnamnt.Focus()
        txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction - Decimal.Parse(txtLoanBalance.Text))
        gen_sched()
    End Sub


    Private Sub txtlnamnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlnamnt.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtlnamnt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtlnamnt.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtlnamnt.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = Chr(13) Then GetNextControl(dtgrd_deduction, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtlnamnt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlnamnt.KeyUp
        Try
            If Not txtlnamnt.Text.Contains(".") Then
                txtlnamnt.Text = Format(Val(Replace(txtlnamnt.Text, ",", "")), "#,###,###")
                txtlnamnt.Select(txtlnamnt.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtlnamnt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlnamnt.Validated



        Try
            Dim lndeduction As Decimal = 0
            For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
                If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                    lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
                End If
            Next
            'original
            'txtdeduction.Text = lndeduction

            'modified 10/21/2024 formula: deduction + loan balance
            txtdeduction.Text = lndeduction '+ Double.Parse(txtLoanBalance.Text)


            'txtlnamnt.Focus()
            txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction - Decimal.Parse(txtLoanBalance.Text))
            txtlnamnt.Text = Format(Me.txtlnamnt.Text("Currency"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub insert_loansched()
        'conn()
        'sql = "SELECT * FROM loancollect WHERE pnnumber='" & txtlno.Text & "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader
        'If Not rd.Read Then
        gen_loansched()

        conn()
        sql = "UPDATE loans SET payno=" & txtpayno.Value.ToString & ", modeofpayment='" & cboterms.Text & "', firstpaymentdate='" & dtschedoffirst.Value & "',Releasedate='" & dtrel.Value & "',Maturitydate='" & lblmatdate.Text & "',InterestDue=" & lblintdue.Text & " WHERE pnnumber='" & txtlno.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        conn()
        sql = "DELETE FROM Loansched WHERE pnnumber='" & txtlno.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        insert_sched()
        TabControl1.SelectedPage = RadPageViewPage2
        'bttnnew.Enabled = True
        'bttnnew.Focus()
        'Else
        '    MsgBox("Please save loans first to generate the schedule.", MsgBoxStyle.Exclamation, "Invalid")
        'End If
        'rd.Close()
        'myConn.Close()
    End Sub

    'Private Sub bttn_gensched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    ''Private Sub RadPageViewPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadPageViewPage2.Click
    ''    bttnsave.Enabled = True
    ''End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        'bttnsave.Enabled = True
    End Sub

    Public Sub creategview_beneficiary()
        'InitializeComponent()
        dtgr_benefeciary.Columns.Clear()
        dtgr_benefeciary.Rows.Clear()

        Dim beneficiary As DataTable = New DataTable()
        'conn()
        'sql = "SELECT * from deductionMF"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        beneficiary.Columns.Add("Code")
        beneficiary.Columns.Add("Relationship")
        'While (rd.Read())
        beneficiary.Rows.Add(1, "Father")
        beneficiary.Rows.Add(2, "Mother")
        beneficiary.Rows.Add(3, "Daughter")
        beneficiary.Rows.Add(4, "Son")
        beneficiary.Rows.Add(5, "Sister")
        beneficiary.Rows.Add(6, "Brother")
        beneficiary.Rows.Add(7, "Husband")
        beneficiary.Rows.Add(8, "Wife")
        'End While
        'rd.Close()
        'myConn.Close()

        '0
        Dim fullname As New GridViewTextBoxColumn("Fullname")
        Me.dtgr_benefeciary.MasterTemplate.AutoGenerateColumns = False
        dtgr_benefeciary.Columns.Add(fullname)
        fullname.Width = 250

        '1
        Dim bdate As New GridViewTextBoxColumn("Birthdate")
        Me.dtgr_benefeciary.MasterTemplate.AutoGenerateColumns = False
        dtgr_benefeciary.Columns.Add(bdate)
        bdate.Width = 250

        '2
        comboCol2.DataSource = beneficiary
        comboCol2.FieldName = "Relationship"
        comboCol2.DisplayMember = "Relationship"
        comboCol2.ValueMember = "Relationship"
        comboCol2.Width = 200
        comboCol2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgr_benefeciary.Columns.Add(comboCol2)

        If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
            conn()
            sql = "SELECT * FROM Beneficiary WHERE pnnumber='" & txtlno.Text & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                dtgr_benefeciary.Rows.Add(rd("fullname").ToString, rd("birthdate").ToString, rd("relationship").ToString)
            End While
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub dtgr_benefeciary_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgr_benefeciary.CellEditorInitialized
        If dtgr_benefeciary.CurrentCell.ColumnIndex = 2 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.dtgr_benefeciary.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol2.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
            dtgr_benefeciary.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextCell
        End If
    End Sub

    Private Sub dtgr_benefeciary_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgr_benefeciary.CellEndEdit
        ttlbenf = 0
        For i As Integer = 0 To dtgr_benefeciary.Rows.Count - 1
            If dtgr_benefeciary.Rows(i).Cells(0).Value <> "" And dtgr_benefeciary.Rows(i).Cells(1).Value <> "" And dtgr_benefeciary.Rows(i).Cells(2).Value <> "" Then
                ttlbenf = ttlbenf + 1
            End If
        Next
    End Sub

    Private Sub txtcocontact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcocontact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtloan_purpose.Focus()
        End If
    End Sub

    Private Sub txtres_loan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtloan_purpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_collateral.Focus()
        End If
    End Sub

    Private Sub cbo_collateral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_collateral.KeyDown
        bttnsave.Focus()
    End Sub


    Private Sub gen_grpcode()
        conn()
        sql = "SELECT TOP 1 grpcode from loans where memcode ='" & txtmember.SelectedValue & "' order by releasedate DESC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            cbogrpcode.Text = rd("grpcode")
        Else
            cbogrpcode.Text = 1
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub txtcoll_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcoll.SelectedIndexChanged

    End Sub

    Private Sub txtmember_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles txtmember.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(txtmember.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("Member Code").ToString()
        Dim name As String = drv("Fullname").ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 2

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
    End Sub

    Private Sub txtmember_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmember.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    txtfunding.Focus()
        'End If
    End Sub

    Private Sub txtmember_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmember.Validated
        'member_code = txtmember.SelectedValue
        'If Me.Text = "New Loan" Then
        '    gen_pnnumber()
        'End If
        ''gen_savbalance()
        'get_pnnumber()
        'view_loansched()
        'gen_cbuacct()
        'select_cycle()
        'genaddress()
        'txtfunding.Focus()
    End Sub

    Private Sub gen_savbalance()
        Try
            conn()
            ' MODIFIED AND ADDED active = 'Y' to exclude cancelled trans - 11/23/21
            sql = "select balance=isnull((sum(debit-credit)),0) from accountledger where accountnumber='" & txtsaacct.Text & "' AND active = 'Y' "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                lblsa_bal.Text = Decimal.Parse(rd("balance").ToString)
            Else
                lblsa_bal.Text = "0.00"
            End If
            rd.Close()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub genaddress()
        conn()
        sql = "select address from members where memcode='" & txtmember.SelectedValue & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            address = rd("address").ToString
        Else
            address = "not modify"
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Public Sub gen_cbuacct()
        conn()
        sql = "SELECT CBUAccount FROM members WHERE MemCode='" & txtmember.SelectedValue & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtcbu.Text = rd("CBUAccount").ToString()
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "select balance=isnull((sum(debit-credit)),0) from cbuledger where CBUAccount='" & txtcbu.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            lbl_cbubal.Text = Double.Parse(rd("balance")).ToString
        Else
            lbl_cbubal.Text = 0
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub txtpayno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpayno.ValueChanged
        payable = txtpayno.Value
    End Sub

    Private Sub txtctr_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles txtctr.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(txtctr.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("Center Code").ToString()
        Dim name As String = drv("Center Name").ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 2

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
    End Sub

    Private Sub txtctr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtctr.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbogrpcode.Focus()
        End If
    End Sub

    Private Sub txtctr_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtctr.Validated
        Try
            conn()
            sql = "SELECT DISTINCT grpcode FROM Loans WHERE ctrcode='" & txtctr.SelectedValue.ToString & "' ORDER BY grpcode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                cbogrpcode.Items.Add(rd("grpcode").ToString)
            End While
            rd.Close()
            myConn.Close()
            gen_sched()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdb_ctrname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ctrname.CheckedChanged
        view_ctr()
        If Not Me.Text = "New Loan" Then
            Try
                edit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub rdb_ctrcheif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ctrcheif.CheckedChanged
        view_ctr()
        If Not Me.Text = "New Loan" Then
            Try
                edit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub GetSavingsAccount()
        conn()
        sql = "SELECT Accountnumber FROM AccountMaster WHERE MemCode = '" & txtmember.SelectedValue & "' "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read() Then
            txtsaacct.Text = rd("Accountnumber")
        Else
            txtsaacct.Text = "Savings not found"
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        conn()
        sql = "SELECT Accountnumber FROM AccountMaster WHERE MemCode = '" & txtmember.SelectedValue & "' "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read() Then
            txtsaacct.Text = rd("Accountnumber")
        Else
            txtsaacct.Text = "Savings not found"
        End If
        rd.Close()
        myConn.Close()
        frm_select_savingsACC.membercode = txtmember.SelectedValue
        frm_select_savingsACC.ShowDialog()
        gen_savbalance()
        'GetSavingsAccount()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frm_checkloanno.ShowDialog()
    End Sub

    Private Sub txtsaacct_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        gen_savbalance()
    End Sub

    Private Sub bttnapply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnapply.Click
        conn()
        sql = "SELECT * FROM DeductionMF WHERE ACRO='OFS'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
                If dtgrd_deduction.Rows(i).Cells(4).Value = rd("Acro") Then
                    dtgrd_deduction.Rows(i).Cells(2).Value = Double.Parse(txtamount_paid.Text)
                    GoTo 1
                End If
            Next
            dtgrd_deduction.Rows.Add(rd("code"), rd("code"), Double.Parse(txtamount_paid.Text), rd("description"), rd("Acro"))
            rd.Close()
1:
            'conn()
            sqlstr = "INSERT INTO Offset_Payment(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,prnpaid,intdue,intpaid,AdvInterest,savings,CF,LH,SSSCont,penpaid,amtpaid,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,prnduebalance,intduebalance) "
            sqlstr += "VALUES('" & txtmember.SelectedValue & "',"
            sqlstr += "" & payno.ToString & ","
            sqlstr += "'" & dtrel.Value & "',"
            sqlstr += "'Offset',"
            sqlstr += "'" & pnnumber & "',"
            sqlstr += "" & prndue.ToString & ","
            sqlstr += "" & txtprnpaid.Text & ","
            sqlstr += "" & Double.Parse(txtamount_paid.Text).ToString & ","
            sqlstr += "" & intdue.ToString & ","
            sqlstr += "" & txtintdue.Text & ","
            sqlstr += "" & txtadv_int.Text & ","
            sqlstr += "" & txtsa_amount.Text & ","
            sqlstr += "" & txtcf.Text & ","
            sqlstr += "" & Double.Parse(txtlife_health.Text).ToString & ","
            sqlstr += "" & Double.Parse(txtsss.Text).ToString & ","
            sqlstr += "" & txtpen_paid.Text & ","
            sqlstr += "" & Double.Parse(txtamount_paid.Text).ToString & ","
            sqlstr += "'" & txtlno.Text & "',"
            sqlstr += "'" & txtlno.Text & "',"
            sqlstr += "'" & user.ToString & "',"
            sqlstr += "'" & dtrel.Value & "',"
            sqlstr += "'" & time.ToString & "',"
            sqlstr += "'Y',"
            sqlstr += "'" & dtrel.Text & "',"
            sqlstr += "" & txtadvprn.Text & ","
            sqlstr += "" & Decimal.Parse(lblprnbal.Text).ToString & ","
            sqlstr += "" & Decimal.Parse(lblintbal.Text).ToString & ""
            sqlstr += ")"
            'MsgBox(sql.ToString)
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()

            pn_payment.Visible = False
        Else
            MsgBox("Not modified offset deduction.", MsgBoxStyle.Information, "Message")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_offset.LinkClicked
        If pn_payment.Visible = False Then
            pn_payment.Visible = True
        Else
            pn_payment.Visible = False
        End If
    End Sub

    Private Sub cbo_collections_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_collections.Validated
        gen_amounts()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        pn_payment.Visible = False
    End Sub

    Private Sub chk_offset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_offset.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        gen_members()
        display_members_list()
        If chk_offset.Checked = True Then
            lnk_offset.Enabled = True
        Else
            lnk_offset.Enabled = False
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub bttnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnfind.Click
        If pnmember.Visible = False Then
            pnmember.Visible = True
        Else
            pnmember.Visible = False
        End If
    End Sub

    Private Sub lstmembers_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstmembers.KeyUp
        If e.KeyCode = Keys.Enter Then
            members_selected()
        End If
    End Sub

    Private Sub lstmembers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstmembers.SelectedIndexChanged
        txtmember.SelectedValue = lstmembers.FocusedItem.SubItems(0).Text
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        members_selected()
    End Sub

    Private Sub members_selected()
        member_code = txtmember.SelectedValue
        gen_pnnumber()
        'gen_savbalance()
        gen_cbuacct()
        select_cycle()
        genaddress()
        pnmember.Visible = False
        txtfunding.Focus()
        If chk_offset.Checked = True Then
            get_pnnumber()
            view_loansched()
        End If
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        If e.KeyCode = Keys.Down Then
            lstmembers.Focus()
            lstmembers.Items(0).Selected = True
        Else
            display_members_list()
        End If
    End Sub

    Private Sub RadPageViewPage1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles RadPageViewPage1.Paint

    End Sub

    Private Sub txtsubproduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubproduct.SelectedIndexChanged

    End Sub

    Private Sub txtlnproceeds_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlnproceeds.TextChanged

    End Sub



    Private Sub gen_amounts_renew(ByVal pcPNNumber As String)
        '// check the field data
        'MsgBox(cbo_collections.SelectedValue, MsgBoxStyle.DefaultButton1)
        'cbo_collections.SelectedValue && is from Pay No. combobox

        'MsgBox(pcPNNumber, MsgBoxStyle.Exclamation, "Gen Amount Renew")

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
        Dim cpayno As String
        Dim ntotal_amntpaid As Double
        Dim ntxtmain As Double

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
        cpayno = ""
        ntotal_amntpaid = 0.0
        ntxtmain = 0.0             'total amount paid

        ' MemCode, pnnumber, grpcode, Fullname, interestdue, prnamnt, rngprin, rngint, lh  
        conn()
        sql = "SELECT a.MemCode,a.pnnumber,a.grpcode,c.Fullname,"

        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber= pcPNNumber),0),"

        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber= pcPNNumber ),0),"

        sql += "rngprin=isnull(((select sum(principal) from loansched where pnnumber= pcPNNumber and duedate<=b.duedate)-isnull((SELECT SUM(principal+advprincipal) FROM loancollect where pnnumber= pcPNNumber),0)),0),"

        sql += "rngint=isnull(((select sum(interest) from loansched where pnnumber= pcPNNumber and duedate<=b.duedate)-isnull((SELECT SUM(intpaid+advinterest) FROM loancollect where pnnumber= pcPNNumber ),0)),0),"

        sql += "b.principal,b.interest,b.savings,cf=isnull((b.cf),0),"

        sql += "lh=isnull(((select sum(lh) from loansched where pnnumber= pcPNNumber and duedate<=b.duedate and duedate >= '2021-10-01 00:00:00')-isnull((SELECT SUM(lh) FROM loancollect where pnnumber= pcPNNumber ),0)),0),"

        sql += "ttlprnpaid=isnull((select SUM(principal+advprincipal) from LoanCollect where pnnumber= pcPNNumber ),0),"

        sql += "ttlintpaid=isnull((select SUM(intpaid+AdvInterest) from LoanCollect where pnnumber= pcPNNumber ),0),"

        sql += "payno=isnull((select count(payno)+1 from loancollect where pnnumber= pcPNNumber ),1)"

        sql += "FROM  Loans a,Loansched b, Members c "
        sql += "WHERE a.pnnumber=b.pnnumber AND a.memcode=c.memcode AND a.pnnumber='" + pcPNNumber + "' AND a.status='A' and b.duedate='" + cbo_collections.SelectedValue + "' "
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

            If ccbopay_type = "DM" Then
                p_savings = 0
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
        total_amntpaid = nprndue + nintdue + nlife + ncf + np_savings ' total amount payable or amount due
        ntxtmain = total_amntpaid ' Total amount payable - principal + interest + c19 + savings

        'save to table loancollect

        'compute_payment()
    End Sub

    'Private Sub txtamount_paid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmain.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        bttnsave.Focus()
    '    End If
    'End Sub


End Class