Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_loanProcess_teachers
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
    Public loantype As String = ""
    Dim adjmatdate As String = ""
    Dim modeofpay As String = ""
    Dim ttlbenf As Integer = 0

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        If Me.Text = "View Loan" Then
            sql = "SELECT CollCode,fullname FROM Officer WHERE status='A' ORDER BY fullname ASC" '
        Else
            sql = "SELECT CollCode,fullname FROM Officer WHERE status='A'  ORDER BY fullname ASC" '
        End If
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

    Public Sub gen_cbuacct()
        conn()
        sql = "SELECT CBUAccount FROM members WHERE MemCode='" + txtmember.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtcbu.Text = rd("CBUAccount").ToString()
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "select balance=isnull((sum(debit-credit)),0) from cbuledger where CBUAccount='" + txtcbu.Text + "'"
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

    Private Sub insert_acctMaster()
        conn()
        sql = "INSERT INTO AccountMaster(Accountnumber,Dateopen,AccountType,userid,tdate,MemCode,AccountStatus,GL_sa) values "
        sql += "('" + txtsaacct.Text + "',"
        sql += "'" + systemdate + "',"
        sql += "'PS',"
        sql += "'" + user.ToString + "',"
        sql += "'" + systemdate + "',"
        sql += "'" + txtmember.SelectedValue + "',"
        sql += "'Active',"
        sql += "'" + GL_sa.ToString + "'"
        sql += ")"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub frm_newloan_HL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_newloanlist.view_loanlist_HL()
    End Sub

    Public Sub select_cycle()
        conn()
        sql = "SELECT isnull((max(cycle)),0) as cycle from loans where Memcode='" + txtmember.SelectedValue + "' and status='O' and GL_loans='" + GL_loans + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            If Me.Text = "New Loan" Then
                txtcycle.Text = Double.Parse(rd("cycle")) + 1
            Else
                txtcycle.Text = Double.Parse(rd("cycle"))
            End If
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_members()
        Dim dtTest As DataTable = New DataTable()
        dtTest.Columns.Add("Member Code", GetType(String))
        dtTest.Columns.Add("Fullname", GetType(String))

        conn()
        If Me.Text = "View Loan" Then
            sql = "select * from members where memcode='" + member_code.ToString + "' order by fullname"
        ElseIf Me.Text = "Edit Loan" Then
            sql = "select * from members where memcode  in(select memcode from loans where status='A' and released='N') and status='A' order by fullname"
        Else
            sql = "select * from members where memcode not in(select memcode from loans where status='A' and gl_loans='" + GL_loans + "') and status='A' order by fullname"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
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

    Private Sub frm_newloan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtschedoffirst.Value = systemdate
        dtrel.Value = systemdate
        TabControl1.SelectedPage = RadPageViewPage1
        gen_members()
        view_officer()
        view_subproducts()
        gen_fund()
        view_ctr()
        gen_loantype()
        append()

        creategview_deductions()

        creategview_beneficiary()
        lstgensched.Items.Clear()
        txtlnamnt.Text = 0
        txtdeduction.Text = 0
        txtlnproceeds.Text = 0
        gen_cbuacct()
        gen_SA()
        bttnsave.Enabled = True


        If Me.Text = "View Loan" Then
            If frm_members.dtgridloan_list.CurrentRow.Cells(7).Value = "Active" Then
                bttnsave.Enabled = True
            End If
        End If
        If Not Me.Text = "New Loan" Then
            gen_SA()
            edit()
        Else
            gen_pnnumber()
        End If

    End Sub

    Private Sub view_subproducts()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * from SubProducts where gl_loans='" + GL_loans + "' order by description" '
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

    Private Sub edit()
        'If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
        conn()
        sql = "select a.fullname,a.address,b.* from members a, loans b where a.memcode=b.memcode and b.pnnumber='" + loannumber + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            address = rd("address").ToString
            txtmember.SelectedValue = rd("MemCode").ToString
            'cboctr.SelectedValue = rd("ctrcode").ToString

            'cbogrpcode.Text = rd("grpcode").ToString
            dtrel.Value = rd("releasedate").ToString
            dtschedoffirst.Value = rd("firstpaymentdate").ToString
            txtlnamnt.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("loanamnt"))
            txtdeduction.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("TotalDeduction"))
            txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("netproceeds"))
            txtschdlnamnt.Text = rd("loanamnt").ToString
            txtschdinterestperann.Text = rd("Intrate").ToString
            penaltyrate = rd("penaltyrate").ToString
            txtloantype.SelectedValue = rd("loantype")
            loantype = rd("loantype").ToString
            loanrate = rd("Intrate").ToString
            cbo_collateral.Text = rd("col_type").ToString
            txtloan_purpose.Text = rd("purpose").ToString
            txtcycle.Text = rd("cycle").ToString
            txtschdpayable.Text = rd("payno").ToString
            payable = rd("payno").ToString
            txtsubproduct.SelectedValue = rd("subproductcode")
            adjmatdate = rd("maturitydate").ToString
            txtsaacct.SelectedValue = rd("accountnumber").ToString

            txtsch_weeks.Text = rd("ModeofPayment").ToString
            cboterms.Text = rd("ModeofPayment").ToString
            txtpayno.Value = rd("Payno").ToString
        End If
        rd.Close()
        myConn.Close()

        gen_savbalance()
        conn()
        sql = "select a.CollCode from officer a, loans b where a.CollCode=b.CollCode and b.pnnumber='" + txtlno.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtcoll.SelectedValue = rd("CollCode").ToString
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "select a.loancode,a.cbu,a.CF,a.SavingsPrcnt from loantype a, loans b where a.loancode=b.loantype and b.pnnumber='" + txtlno.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtloantype.SelectedValue = loantype
            cbu = rd("cbu")
            cf = rd("CF")
            savingsrate = rd("SavingsPrcnt")
        End If
        rd.Close()
        myConn.Close()

        'conn()
        'sql = "select a.code,a.type,a.description,a.payable from loanterms a, loans b where a.code=b.termcode and b.pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.Read Then
        '    txtsch_weeks.Text = rd("type").ToString
        '    cboterms.Text = rd("code").ToString
        '    payable = rd("payable").ToString
        'End If
        'rd.Close()
        'myConn.Close()

        conn()
        sql = "select a.fundcode from Funding a, loans b where a.fundcode=b.fundcode and b.pnnumber='" + txtlno.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtfunding.SelectedValue = rd("FundCode").ToString
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "select a.* from loancomaker a, loans b where a.pnnumber=b.pnnumber and b.pnnumber='" + txtlno.Text + "'"
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
        sql = "SELECT LnNum,CONVERT(VARCHAR(12),DueDate,107),Principal,Interest,savings,CF,CBU,AmntRcvbl FROM Loansched WHERE pnnumber='" + txtlno.Text + "' order by LnNum"
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
                Dim dtmat As DateTime = lstgensched.Items(x).SubItems(1).Text
                lblmatdate.Text = dtmat.ToString("M/d/yyyy")
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
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * from Center WHERE gl_loans='" + GL_loans + "' ORDER BY ctrcode ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Ctr. Code")
        table1.Columns.Add("Ctr. Name")
        table1.Columns.Add("Ctr. Cheif")
        table1.Columns.Add("ColDayNo")
        While (rd.Read())
            table1.Rows.Add(rd("ctrcode").ToString, rd("ctrname").ToString, rd("ctrchief").ToString, rd("ColDayNo").ToString)
        End While
        rd.Close()
        myConn.Close()
        cboctr.DataSource = table1
        Me.cboctr.AutoFilter = True
        cboctr.DisplayMember = "Ctr. Name"
        cboctr.ValueMember = "Ctr. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.cboctr.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.cboctr.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.cboctr.EditorControl.Columns(0).Width = 90
        Me.cboctr.EditorControl.Columns(1).Width = 200
        Me.cboctr.EditorControl.Columns(2).Width = 200
        Me.cboctr.EditorControl.Columns(3).Width = 60
        Me.cboctr.MultiColumnComboBoxElement.DropDownWidth = 690
        'Catch ex As Exception
        'End Try
    End Sub

    Public Sub gen_pnnumber()
        conn()
        sql = "select LastLNCode from LoanNumberSeries WHERE CYear='" + systemdate.Year.ToString + "'"
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
        sql = "INSERT INTO LoanNumberSeries(LastLNCode,CYear) VALUES ('000000','" + systemdate.Year.ToString + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        gen_pnnumber()
    End Sub

    Private Sub gen_sched()
        If cboctr.Text.Trim <> "" Then
            Dim exday As DayOfWeek
            conn()
            sql = "SELECT ColDayno FROM Center WHERE ctrcode='" + cboctr.SelectedValue + "'"
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
        sql = "SELECT loancode,loandesc,rate,cf,savingsprcnt FROM Loantype WHERE gl_loans='" + GL_loans + "' order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Columns.Add("Rate")
        table1.Columns.Add("CF")
        table1.Columns.Add("Savings")
        'table1.Rows.Add("-select-", "-select-", 0, 0, 0)
        While (rd.Read())
            table1.Rows.Add(rd("loancode"), rd("loandesc"), rd("Rate").ToString, rd("CF").ToString, rd("savingsprcnt").ToString)
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
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 520
    End Sub

    Private Sub gen_grpcode()
        conn()
        sql = "SELECT DISTINCT grpcode FROM Loans WHERE ctrcode='" + cboctr.SelectedValue.ToString + "' ORDER BY grpcode ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        cbogrpcode.Items.Clear()
        While rd.Read
            cbogrpcode.Items.Add(rd("grpcode").ToString)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_loansched()
        txtsch_weeks.Text = cboterms.Text
        txtschdinterestperann.Text = loanrate.ToString
        'Try
        lstgensched.Items.Clear()
        Dim dtsched As Date = dtschedoffirst.Value
        Dim payno As Integer = 0
        Dim intdue As Decimal = 0
        Dim prndue As Decimal = 0
        Dim ttlmarkup As Decimal = 0
        Dim ttlnamount As Decimal = 0
        Dim ttlreceivable As Decimal = 0
        Dim loanamnt As Decimal = Double.Parse(txtlnamnt.Text)
        'MsgBox(payable)
        txtschdlnamnt.Text = txtlnamnt.Text
        txtschdpayable.Text = payable
        prndue = Double.Parse(txtlnamnt.Text) / payable
        intdue = (Double.Parse(txtlnamnt.Text) * (loanrate)) / payable
        lblprndue.Text = 0
        lblintdue.Text = 0


        savings = (Double.Parse(txtlnamnt.Text) * (savingsrate / 100)) / payable
        ' MsgBox(savingsrate)
        'end countsavings

        'generate schedule
        For x As Integer = 0 To payable - 1
            'conn()
            'sql = "Select * from Reg_holidays where date='" + dtsched.ToString + "'"
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
            If x = (payable - 1) Then
                'MsgBox(lblprndue.Text)
                Dim lstprndue As Decimal = Double.Parse(txtlnamnt.Text) - Double.Parse(lblprndue.Text)
                Dim lstintdue As Decimal = (Double.Parse(txtlnamnt.Text) * (loanrate / 100)) - Double.Parse(lblintdue.Text)

                lvitem.SubItems.Add(lstprndue.ToString("F", CultureInfo.InvariantCulture))
                lvitem.SubItems.Add(lstintdue.ToString("F", CultureInfo.InvariantCulture))
            Else
                lvitem.SubItems.Add(prndue.ToString("F", CultureInfo.InvariantCulture))
                lvitem.SubItems.Add(intdue.ToString("F", CultureInfo.InvariantCulture))
            End If

            lvitem.SubItems.Add(savings)
            lvitem.SubItems.Add(cf)
            lvitem.SubItems.Add(cbu)
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


    Private Sub insert_comaker()
        conn()
        sql = "INSERT INTO LoanComaker(PnNumber,CoMaker,CMkrAddress,ContactNumber,GL_loans) VALUES ('" + txtlno.Text + "','" + txtcomaker.Text + "','" + txtcoaddress.Text + "','" + txtcocontact.Text + "','" + GL_loans + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub update_comaker()
        conn()
        sql = "UPDATE LoanComaker set CoMaker='" + txtcomaker.Text + "',ContactNumber='" + txtcocontact.Text + "',CMkrAddress='" + txtcoaddress.Text + "' WHERE pnnumber='" + txtlno.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub update_pnnumber()
        conn()
        sql = "UPDATE LoanNumberSeries SET LastLNCode='" + loan_code.ToString("000000") + "' WHERE CYear='" + systemdate.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub insert_deductions()
        conn()
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            If dtgrd_deduction.Rows(i).Cells(1).Value <> "" Then
                sql = "INSERT INTO LoansDeduction(PnNumber,code,Description,Amount,acro) VALUES ('" + txtlno.Text + "','" + dtgrd_deduction.Rows(i).Cells(1).Value + "','" + dtgrd_deduction.Rows(i).Cells(3).Value + "'," + dtgrd_deduction.Rows(i).Cells(2).Value.ToString + ",'" + dtgrd_deduction.Rows(i).Cells(4).Value.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub insert_sched()
        conn()
        For i As Integer = 0 To lstgensched.Items.Count - 1
            Dim prndue As Decimal = lstgensched.Items(i).SubItems(2).Text
            If lstgensched.Items(i).SubItems(0).Text <> "" Then
                sql = "INSERT INTO Loansched(PnNumber,LnNum,DueDate,Principal,Interest,savings,CF,cbu,AmntRcvbl,rngprin,rngint) VALUES "
                sql += "('" + txtlno.Text + "',"
                sql += "" + lstgensched.Items(i).SubItems(0).Text + ","
                sql += "'" + lstgensched.Items(i).SubItems(1).Text + "',"
                sql += "" + lstgensched.Items(i).SubItems(2).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(3).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(4).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(5).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(6).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(7).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(8).Text + ","
                sql += "" + lstgensched.Items(i).SubItems(9).Text + ""
                sql += ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub clear()
        cboctr.Text = ""
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

    Private Sub txtlnamnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlnamnt.KeyDown
        'Try
        '    txtschdlnamnt.Text = txtlnamnt.Text
        'Catch ex As Exception
        'End Try
        'If IsNumeric(txtlnamnt.Text) = False Then
        '    MsgBox("Invalid loan amount.Input field must be numeric.", MsgBoxStyle.Exclamation)
        '    txtlnamnt.Text = "0.00"
        '    txtlnamnt.Focus()
        'End If
        'If e.KeyCode = Keys.Enter Then
        '    txtloantype.Focus()
        'End If
    End Sub

    Private Sub cbofullname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            gen_pnnumber()
            txtlno.Text = "01-" & loanstr.ToString("000000") & "-" & systemdate.Year.ToString.Substring(2, 2)
            gen_SA()
            txtfunding.Focus()
        End If
    End Sub

    Private Sub cbocoll_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtloantype.Focus()
        End If
    End Sub

    Private Sub cboctr_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cbogrpcode.Focus()
        End If
    End Sub

    Private Sub cboctr_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        conn()
        sql = "SELECT DISTINCT grpcode FROM Loans WHERE ctrcode='" + cboctr.SelectedValue.ToString + "' ORDER BY grpcode ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            cbogrpcode.Items.Add(rd("grpcode").ToString)
        End While
        rd.Close()
        myConn.Close()
        gen_sched()
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
            gen_SA()
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
        sql = "SELECT * FROM loantype WHERE loancode=" + txtloantype.SelectedValue.ToString + ""
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
        End If
        rd.Close()
        myConn.Close()
        ' Catch ex As Exception

        'End Try
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        'Try
        If txtmember.Text.Trim = "" Then
            MsgBox("Members name is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtmember.Focus()
        ElseIf txtlno.Text.Trim = "(Auto Generated)" Then
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
        ElseIf txtsaacct.SelectedValue = "" And isP3 = "N" Then
            MsgBox("Invalid selection of savings account.", MsgBoxStyle.Exclamation, "Invalid")
            txtsaacct.Focus()
        ElseIf multiproduct = "N" And txtsaacct.Text.Trim = "" And isP3 = "N" Then
            MsgBox("Savings account is empty. Create savings account first to save this loan.", MsgBoxStyle.Exclamation, "Invalid Savings Acct.")
        ElseIf cboterms.Text.Trim = "" Then
            MsgBox("Term field is required.", MsgBoxStyle.Exclamation, "Invalid")
            cboterms.Focus()
        ElseIf IsNumeric(txtlnamnt.Text) = False Then
            MsgBox("Invalid Loan Amount.", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        ElseIf Double.Parse(txtlnamnt.Text) < 1 Then
            MsgBox("Loan amount should be greater than 0.", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        Else
            gen_cbuacct()
            gen_loan_rate()
            If Me.Text = "Edit Loan" Then
                If MessageBox.Show("Are you sure you want to update this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    conn()
                    sql = "UPDATE Loans SET CollCode='" + txtcoll.SelectedValue + "',"
                    sql += "FundCode='" + txtfunding.SelectedValue + "',"
                    sql += "LoanAmnt=" + Double.Parse(txtlnamnt.Text).ToString + ","
                    sql += "netproceeds=" + Double.Parse(txtlnproceeds.Text).ToString + ","
                    sql += "IntRate=" + loanrate.ToString + ","
                    sql += "Penaltyrate=" + penaltyrate.ToString + ","
                    sql += "ModeofPayment='" + cboterms.Text + "',"
                    sql += "Status='A',Released='N',userid='" + user.ToString + "',"
                    sql += "loantype='" + loantype.ToString + "',"
                    sql += "Firstpaymentdate='" + dtschedoffirst.Value + "',"
                    sql += "releasedate='" + dtrel.Value + "',"
                    sql += "cycle=" + cycle.ToString + ","
                    sql += "col_type='" + cbo_collateral.Text + "',"
                    sql += "purpose='" + txtloan_purpose.Text + "',"
                    sql += "Subproductcode='" + txtsubproduct.SelectedValue + "',"
                    sql += "accountnumber='" + txtsaacct.SelectedValue + "'"
                    sql += " WHERE pnnumber='" + txtlno.Text + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "DELETE FROM Beneficiary WHERE pnnumber='" + txtlno.Text + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()

                    conn()
                    sql = "DELETE FROM LoansDeduction WHERE pnnumber='" + txtlno.Text + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()

                    conn()
                    sql = "DELETE FROM LoanItems WHERE pnnumber='" + txtlno.Text + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    update_comaker()
                    insert_benefeciary()
                    insert_deductions()
                    insert_loansched()
                    MsgBox("Loan Number " & txtlno.Text & " was successfully updated.", MsgBoxStyle.Information)
                    bttnsave.Enabled = False
                End If

            ElseIf Me.Text = "View Loan" Then
                If usertype = "Admin" Then
                    conn()
                    sql = "UPDATE Loans SET CollCode='" + txtcoll.SelectedValue + "',"
                    sql += "FundCode='" + txtfunding.SelectedValue + "',"
                    sql += "LoanAmnt=" + Double.Parse(txtlnamnt.Text).ToString + ","
                    sql += "netproceeds=" + Double.Parse(txtlnproceeds.Text).ToString + ","
                    sql += "IntRate=" + loanrate.ToString + ","
                    sql += "Penaltyrate=" + penaltyrate.ToString + ","
                    sql += "ModeofPayment='" + cboterms.Text + "',"
                    sql += "userid='" + user.ToString + "',"
                    sql += "loantype='" + loantype.ToString + "',"
                    sql += "Firstpaymentdate='" + dtschedoffirst.Value + "',"
                    sql += "releasedate='" + dtrel.Value + "',"
                    sql += "cycle=" + cycle.ToString + ","
                    sql += "col_type='" + cbo_collateral.Text + "',"
                    sql += "purpose='" + txtloan_purpose.Text + "',"
                    sql += "Subproductcode='" + txtsubproduct.SelectedValue + "',"
                    sql += "accountnumber='" + txtsaacct.SelectedValue + "'"
                    sql += " WHERE pnnumber='" + txtlno.Text + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    insert_loansched()
                Else
                    conn()
                    sql = "UPDATE Loans SET CollCode='" + txtcoll.SelectedValue + "',"
                    sql += "userid='" + user.ToString + "'"
                    sql += " WHERE pnnumber='" + txtlno.Text + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                End If

                conn()
                Dim reasons As String = "Editing loans(view loans) of " & txtmember.Text & " to " & loanrate & "rate- " & cboterms.Text & " term- " & txtcoll.SelectedValue & " collector code"
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','" + reasons + "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                MsgBox("Loan Number " & txtlno.Text & " was successfully updated.", MsgBoxStyle.Information, "Success")
                bttnsave.Enabled = False
            Else
                If txtcomaker.Text.Trim = "" Or txtcoaddress.Text.Trim = "" Or txtcocontact.Text.Trim = "" Then
                    MsgBox("Note : CoMaker information is needed. You can still edit this loan to add a CoMaker.", MsgBoxStyle.Information, "Information")
                End If
                conn()
                sql = "SELECT pnnumber FROM loans where pnnumber='" + txtlno.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If Not rd.Read Then
                    If MessageBox.Show("Are you sure you want to save this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        gen_pnnumber()

                        conn()
                        sql = "INSERT INTO Loans(Memcode,Pnnumber,CollCode,FundCode,LoanAmnt,TotalDeduction,netproceeds,IntRate,modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,Subproductcode,GL_loans) VALUES "
                        sql += "('" + txtmember.SelectedValue + "',"
                        sql += "'" + txtlno.Text + "',"
                        sql += "'" + txtcoll.SelectedValue.ToString + "',"
                        sql += "'" + txtfunding.SelectedValue.ToString + "',"
                        sql += "" + Double.Parse(txtlnamnt.Text).ToString + ","
                        sql += "" + txtdeduction.Text + ","
                        sql += "" + Double.Parse(txtlnproceeds.Text).ToString + ","
                        sql += "" + loanrate.ToString + ","
                        sql += "'" + cboterms.Text + "',"
                        sql += "'" + systemdate.ToString + "',"
                        sql += "'A',"
                        sql += "'N',"
                        sql += "'" + user.ToString + "',"
                        sql += "'" + txtloantype.SelectedValue + "',"
                        sql += "" + txtcycle.Text + ","
                        sql += "'" + dtschedoffirst.Value + "',"
                        sql += "'" + dtrel.Value + "',"
                        sql += "'" + cbo_collateral.Text + "',"
                        sql += "'" + txtloan_purpose.Text + "',"
                        sql += "" + payable.ToString + ","
                        sql += "" + penaltyrate.ToString + ","
                        sql += "'" + txtsaacct.SelectedValue + "',"
                        sql += "'" + txtsubproduct.SelectedValue + "',"
                        sql += "'" + GL_loans + "'"
                        sql += ")"
                        ' MsgBox(sql.ToString)
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        'update_members_saacct()
                        insert_deductions()
                        insert_comaker()
                        insert_benefeciary()

                        'MsgBox("New loan was successfully added.", MsgBoxStyle.Information)
                        txtschdlnamnt.Text = txtlnamnt.Text

                        insert_loansched()
                        update_pnnumber()
                        bttnsave.Enabled = False
                    Else
                        TabControl1.SelectedPage = RadPageViewPage3
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

    'Private Sub update_members_saacct()
    '    conn()
    '    sql = "UPDATE Members SET Accountnumber='" + txtsaacct.Text + "' WHERE Memcode='" + txtmemcode.Text + "'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    cmd.ExecuteNonQuery()
    '    myConn.Close()
    'End Sub

    Private Sub update_saving()
        conn()
        sql = "UPDATE SA_AcctnoSeries SET LastLAcctno='" + sanum.ToString("000000") + "' WHERE CYear='" + DateTime.Now.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub insert_benefeciary()
        For i As Integer = 0 To dtgr_benefeciary.Rows.Count - 1
            If dtgr_benefeciary.Rows(i).Cells(0).Value <> "" Then
                conn()
                sql = "INSERT INTO Beneficiary(pnnumber,fullname,birthdate,relationship) VALUES ('" + txtlno.Text + "','" + dtgr_benefeciary.Rows(i).Cells(0).Value + "','" + dtgr_benefeciary.Rows(i).Cells(1).Value + "','" + dtgr_benefeciary.Rows(i).Cells(2).Value + "')"
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

    Private Sub cboctr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboctr.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbogrpcode.Focus()
        End If
    End Sub

    Private Sub cboctr_Validated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboctr.Validated
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
            sql = "SELECT * FROM LoansDeduction WHERE pnnumber='" + txtlno.Text + "'"
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
        If e.ColumnIndex = 0 Then
            conn()
            sql = "SELECT * from deductionMF where code ='" + dtgrd_deduction.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                dtgrd_deduction.CurrentRow.Cells(1).Value = rd("code").ToString
                dtgrd_deduction.CurrentRow.Cells(3).Value = rd("Description").ToString
                dtgrd_deduction.CurrentRow.Cells(4).Value = rd("acro").ToString
                If rd("percentage") > 0 Then
                    Try
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
                    Catch ex As Exception

                    End Try
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

            End If
            rd.Close()
            myConn.Close()
        End If

        Dim lndeduction As Decimal = 0
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            Try
                If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                    lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
                End If
            Catch ex As Exception

            End Try
        Next
        txtdeduction.Text = lndeduction
        'txtlnamnt.Focus()
        txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction)
    End Sub

    Private Sub dtgrd_deduction_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrd_deduction.Validated
        Dim lndeduction As Decimal = 0
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
            End If
        Next
        txtdeduction.Text = lndeduction
        'txtlnamnt.Focus()
        txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction)
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
            If e.KeyChar = "-" Then e.Handled = False
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
            txtdeduction.Text = lndeduction
            'txtlnamnt.Focus()
            txtlnproceeds.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Decimal.Parse(txtlnamnt.Text) - lndeduction)
            txtlnamnt.Text = Format(Me.txtlnamnt.Text("Currency"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub insert_loansched()
        conn()
        sql = "SELECT * FROM loans WHERE pnnumber='" + txtlno.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            gen_loansched()
            conn()
            sql = "UPDATE loans SET payno=" + txtpayno.Value.ToString + ", modeofpayment='" + cboterms.Text + "', firstpaymentdate='" + dtschedoffirst.Value + "',Releasedate='" + dtrel.Value + "',Maturitydate='" + lblmatdate.Text + "',InterestDue=" + lblintdue.Text + " WHERE pnnumber='" + txtlno.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "DELETE FROM Loansched WHERE pnnumber='" + txtlno.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            insert_sched()
            TabControl1.SelectedPage = RadPageViewPage2
            'bttnnew.Enabled = True
            'bttnnew.Focus()
        Else
            MsgBox("Please save loans first to generate the schedule.", MsgBoxStyle.Exclamation, "Invalid")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttn_gensched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub RadPageViewPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadPageViewPage2.Click
    '    bttnsave.Enabled = True
    'End Sub

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
            sql = "SELECT * FROM Beneficiary WHERE pnnumber='" + txtlno.Text + "'"
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

    Private Sub dtgridmembers_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtgridmembers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

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
        If e.KeyCode = Keys.Enter Then
            txtfunding.Focus()
        End If
    End Sub

    Private Sub txtmember_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmember.Validated
        member_code = txtmember.SelectedValue
        If Me.Text = "New Loan" Then
            gen_pnnumber()
        End If
        gen_SA()
        gen_savbalance()
        gen_cbuacct()
        select_cycle()
        genaddress()
        txtfunding.Focus()
    End Sub

    Private Sub gen_savbalance()
        Try
            conn()
            sql = "select balance=isnull((sum(debit-credit)),0) from accountledger where accountnumber='" + txtsaacct.SelectedValue + "'"
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

    Private Sub gen_SA()
        If txtmember.SelectedValue <> "" Then
            Dim dtTest As DataTable = New DataTable()
            dtTest.Columns.Add("AccountNumber", GetType(String))
            dtTest.Columns.Add("Status", GetType(String))

            conn()
            sql = "select * FROM AccountMaster  WHERE memcode ='" + member_code.ToString + "' ORDER BY Accountstatus"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            txtsaacct.Text = ""
            While rd.Read
                dtTest.Rows.Add(rd("Accountnumber"), rd("AccountStatus"))
            End While
            rd.Close()
            myConn.Close()

            ' Bind the ComboBox to the DataTable
            Me.txtsaacct.DataSource = dtTest
            Me.txtsaacct.DisplayMember = "Accountnumber"
            Me.txtsaacct.ValueMember = "Accountnumber"

            ' Enable the owner draw on the ComboBox.
            Me.txtsaacct.DrawMode = DrawMode.OwnerDrawFixed
            ' Handle th
        End If
    End Sub

    Private Sub genaddress()
        conn()
        sql = "select address from members where memcode='" + txtmember.SelectedValue + "'"
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

    Private Sub txtpayno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpayno.ValueChanged
        payable = txtpayno.Value
    End Sub

    Private Sub txtsaacct_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles txtsaacct.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(txtsaacct.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("AccountNumber").ToString()
        Dim name As String = drv("Status").ToString()

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

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        gen_SA()
        conn()
        sql = "UPDATE Loans SET accountnumber='" + txtsaacct.SelectedValue + "' WHERE pnnumber='" + txtlno.Text + "' and status='A'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        gen_savbalance()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frm_checkloanno.ShowDialog()
    End Sub

    Private Sub txtsaacct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsaacct.Validated
        gen_savbalance()
    End Sub
End Class