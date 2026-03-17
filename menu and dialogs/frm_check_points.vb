Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_check_points
    Public comboCol_deduction As New GridViewMultiComboBoxColumn("Descriptions")
    Public comboCol_Items As New GridViewMultiComboBoxColumn("Item Descriptions")
    Public comboCol2 As New GridViewMultiComboBoxColumn("Beneficiary")
    Public loanrate As Integer = 0
    Public penaltyrate As Decimal = 0
    Public address As String
    Public loannum As Integer
    Public payable As Integer = 0

    Private loan_code As Integer = 0
    Dim cbu As Decimal = 0
    Dim cycle As Integer = 2
    Dim loanstr As Integer
    Dim dt As New System.Data.DataTable
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
        Dim table1 As System.Data.DataTable = New System.Data.DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer  ORDER BY fullname ASC" '
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

    Public Sub gen_sacct()

        conn()
        sql = "SELECT Accountnumber FROM AccountMaster WHERE MemCode='" + txtmember.SelectedValue + "' AND AccountStatus='Active'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtsaacct.Text = rd("Accountnumber").ToString()
        Else
            If MessageBox.Show("This Member's savings account has already closed. Click yes to create new account", "Closed account", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'If MessageBox.Show("This Member's savings account has already closed. Would you like the system to generate a new one?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
a:              conn()
                sql = "SELECT * FROM SA_AcctnoSeries WHERE CYear='" + DateTime.Now.Year.ToString + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader()
                If rd.Read Then
                    sanum = rd("LastLAcctno") + 1
                    txtsaacct.Text = branchcode & "-" & rd("CYear").ToString.Substring(2, 2) & code_series & sanum.ToString("000000") & "-" & "PS"
                Else
                    conn()
                    sql = "INSERT INTO SA_AcctnoSeries(LastLAcctno,CYear,Branch)Values('000000','" + DateTime.Now.Year.ToString + "','" + branchcode.ToString + "')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    GoTo a
                End If
                rd.Close()
                myConn.Close()

                conn()
                sql = "SELECT accountnumber FROM Accountmaster WHERE accountnumber='" + txtsaacct.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader()
                If rd.Read Then
                    update_saving()
                    GoTo a
                Else
                    insert_acctMaster()
                    update_saving()
                End If
                rd.Close()
                myConn.Close()
            End If
            ' MsgBox("This Member's savings account has already close. The system will auto generate the new one.", MsgBoxStyle.Information, "Creating Savings Account")
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



    Public Sub select_cycle()
        conn()
        sql = "SELECT isnull((max(cycle)),0) as cycle from loans where Memcode='" + txtmember.SelectedValue + "' and GL_loans='" + GL_loans + "'"
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
        Dim dtTest As System.Data.DataTable = New System.Data.DataTable()
        dtTest.Columns.Add("Member Code", GetType(String))
        dtTest.Columns.Add("Fullname", GetType(String))

        conn()
        If Me.Text = "View Loan" Then
            sql = "select * from members where status='A' order by fullname"
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


    Private Sub frm_newloan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GL_loans = "1050-02"
        select_grptype()
        conn()
        sql = "SELECT * from dummy"
        conn()
        'sql = "SELECT a.payno,CONVERT(VARCHAR(10),a.trnxdate,101) As trnxdate,CONVERT(VARCHAR(10),a.collectiondate,101) As collectiondate,a.prnum,a.prndue,a.principal,a.AdvPrincipal,a.intdue,a.intpaid,a.AdvInterest,a.savings,a.CF,a.prnduebalance,a.intduebalance,a.runningbalance,a.userid,a.remarks FROM LoanCollect a ORDER BY payno"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstloans.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        If Me.Text = "View Loan" Then
            If frm_members.dtgridloan_list.CurrentRow.Cells(7).Value <> "Active" Then
                bttnsave.Enabled = False
            Else
                bttnsave.Enabled = True
                txtmember.Enabled = True
            End If
        End If
        dtschedoffirst.Value = systemdate
        dtrel.Value = systemdate
        If Not productcode = "IL" Then
            dtschedoffirst.Enabled = False
        End If
        TabControl1.SelectedPage = RadPageViewPage1

        'display_members()
        'gen_members()
        'view_officer()
        'gen_fund()
        'view_ctr()
        gen_loantype()

        creategview_deductions()
        creategview_items()

        creategview_beneficiary()
        lstgensched.Items.Clear()
        txtlnamnt.Text = 0
        txtdeduction.Text = 0
        txtlnproceeds.Text = 0
        If Not Me.Text = "New Loan" Then

        End If
    End Sub

    Public Sub creategview_items()
        'InitializeComponent()
        dtgrid_items.Columns.Clear()
        dtgrid_items.Rows.Clear()

        Dim deductionsMF As System.Data.DataTable = New System.Data.DataTable()
        conn()
        'sql = "select x.reference,x.itemcode,x.price,x.itemdesc,x.warehouse,(x.ttlstcksrec-x.ttlstocksrel) As ttlstocks from(select a.reference,a.itemcode,(a.principal+a.markup) as price,"
        'sql += "itemdesc=isnull((select itemdesc from itemsMF where itemcode=a.itemcode),0),"
        'sql += "warehouse=(select description from WareHouse where warehouseID=a.warehouseID),"
        'sql += "ttlstcksrec=isnull((select sum(qty) from Iteminventory where itemcode=a.itemcode),0),"
        'sql += "ttlstocksrel=isnull((select sum(qty) from LoanItems where itemcode=a.itemcode),0)"
        'sql += "from iteminventory a)x"

        sql = "SELECT * FROM("
        sql += "select x.*,(x.qty-x.ttlqtyrel) As ttlstocks from (select b.description,a.itemcode,(a.principal+a.markup) as price,a.reference,CONVERT(VARCHAR(10),a.trndate,101) as trndate,"
        sql += "ttlqtyrel=isnull((select sum(qty) from LoanItems where reference=a.reference and TrnDate <='" + systemdate + "'),0),"
        sql += "qty=isnull((select sum(qty) from ItemInventory where reference=a.reference and trndate <='" + systemdate + "'),0),"
        sql += "itemdesc=isnull((select ItemDesc from ItemsMF where  itemcode=a.itemcode),'Grocery')"
        sql += "from ItemInventory a, WareHouse b where a.warehouseID=b.warehouseID"
        sql += ")x"
        sql += ")y WHERE y.ttlstocks>0"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        deductionsMF.Columns.Add("Code")
        deductionsMF.Columns.Add("Items Descriptions")
        deductionsMF.Columns.Add("Item Price")
        deductionsMF.Columns.Add("Stocks")
        deductionsMF.Columns.Add("Warehouse")
        While (rd.Read())
            deductionsMF.Rows.Add(rd("reference").ToString, rd("itemdesc").ToString, rd("price").ToString, rd("ttlstocks").ToString, rd("description").ToString)
        End While
        rd.Close()
        myConn.Close()

        '0
        comboCol_Items.DataSource = deductionsMF
        comboCol_Items.FieldName = "Items Descriptions"
        comboCol_Items.DisplayMember = "Items Descriptions"
        comboCol_Items.ValueMember = "Code"
        comboCol_Items.Width = 200
        comboCol_Items.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgrid_items.Columns.Add(comboCol_Items)

        '1
        Dim qty As New GridViewTextBoxColumn("Qty")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(qty)
        qty.Width = 50

        '2
        Dim code As New GridViewTextBoxColumn("Item Code")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(code)
        code.ReadOnly = True
        code.Width = 80
        '3
        Dim amount As New GridViewTextBoxColumn("Item Price")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(amount)
        amount.Width = 100
        '4
        Dim markup As New GridViewTextBoxColumn("Markup")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(markup)
        markup.Width = 100
        'markup.ReadOnly = True
        '5
        Dim ttlamount As New GridViewTextBoxColumn("Total Price")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(ttlamount)
        ttlamount.Width = 100
        ttlamount.ReadOnly = True

        '6
        Dim grocery As New GridViewTextBoxColumn("Grocery")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(grocery)
        grocery.IsVisible = False

        '7
        Dim Itemdesc As New GridViewTextBoxColumn("Itemdesc")
        Me.dtgrid_items.MasterTemplate.AutoGenerateColumns = False
        dtgrid_items.Columns.Add(Itemdesc)
        Itemdesc.IsVisible = False

        If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
            conn()
            sql = "SELECT * FROM LoanItems WHERE pnnumber='" + txtlno.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                dtgrid_items.Rows.Add(rd("reference").ToString, rd("qty").ToString, rd("ItemCode").ToString, rd("ItemPrice").ToString, rd("markup").ToString, (Double.Parse(rd("ItemPrice")) + Double.Parse(rd("markup"))))
            End While
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub edit()
        'If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
        conn()
        sql = "select a.memcode,a.fullname,a.address,b.* from members a, loans b where a.memcode=b.memcode and b.pnnumber='" + txtlno.Text + "'"
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
            txtlnamnt.Text = rd("loanamnt").ToString
            txtdeduction.Text = rd("TotalDeduction").ToString
            txtlnproceeds.Text = rd("netproceeds").ToString
            txtschdlnamnt.Text = rd("loanamnt").ToString
            txtschdinterestperann.Text = rd("Intrate").ToString
            penaltyrate = rd("penaltyrate").ToString
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
        End If
        rd.Close()
        myConn.Close()

        'conn()
        'sql = "select a.CollCode from officer a, loans b where a.CollCode=b.CollCode and b.pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.Read Then
        '    txtcoll.SelectedValue = rd("CollCode").ToString
        'End If
        'rd.Close()
        'myConn.Close()

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
        'sql = "select a.accountnumber from accountmaster a, loans b where a.memcode=b.memcode and a.accountstatus='Active' and b.pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.Read Then
        '    txtsaacct.Text = rd("Accountnumber").ToString
        'End If
        'rd.Close()
        'myConn.Close()

        'conn()
        'sql = "select a.fundcode from Funding a, loans b where a.fundcode=b.fundcode and b.pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.Read Then
        '    txtfunding.SelectedValue = rd("FundCode").ToString
        'End If
        'rd.Close()
        'myConn.Close()

        'conn()
        'sql = "select a.* from loancomaker a, loans b where a.pnnumber=b.pnnumber and b.pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.Read Then
        '    txtcomaker.Text = rd("CoMaker").ToString
        '    txtcoaddress.Text = rd("CMkrAddress").ToString
        '    txtcocontact.Text = rd("ContactNumber").ToString
        'End If
        'rd.Close()
        'myConn.Close()

        select_cycle()
        view_sched()

        'For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
        '    Try
        '        txtdeduction.Text = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + Double.Parse(txtdeduction.Text)
        '    Catch ex As Exception

        '    End Try
        'Next
        txtlnproceeds.Text = Double.Parse(txtlnamnt.Text) - Double.Parse(txtdeduction.Text)
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
        sql = "SELECT LnNum,DueDate,Principal,Interest,savings,CF,CBU,AmntRcvbl FROM Loansched WHERE pnnumber='" + txtlno.Text + "' order by LnNum"
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
                lstgensched.Items(x).BackColor = Color.LightGreen
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
        Dim table1 As System.Data.DataTable = New System.Data.DataTable()
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
        Dim dtTest As System.Data.DataTable = New System.Data.DataTable()
        dtTest.Columns.Add("Center Code", GetType(String))
        dtTest.Columns.Add("Center Name", GetType(String))

        conn()
        sql = "select * from center where gl_loans='" + GL_loans + "' and status='A' order by ctrname"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtTest.Rows.Add(rd("ctrcode"), rd("ctrname") & "_" & rd("ctrcode"))
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
        sql = "INSERT INTO LoanNumberSeries(LastLNCode,CYear,Branch) VALUES ('000000','" + systemdate.Year.ToString + "','" + branchcode + "')"
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
            sql = "SELECT ColDayno FROM Center WHERE ctrcode='" + txtctr.SelectedValue + "'"
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
        Dim table1 As System.Data.DataTable = New System.Data.DataTable()
        conn()
        sql = "SELECT loancode,loandesc,rate,cf,savingsprcnt FROM Loantype WHERE GL_loans='" + GL_loans + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Columns.Add("Rate")
        table1.Columns.Add("CF")
        table1.Columns.Add("Savings")
        ' table1.Rows.Add("-select-", "-select-", "-select-", "-select-", "-select-")
        While (rd.Read())
            table1.Rows.Add(rd("loancode").ToString, rd("loandesc").ToString, rd("Rate").ToString, rd("CF").ToString, rd("savingsprcnt").ToString)
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
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub setgrpcode()
        Try
            conn()
            sql = "SELECT DISTINCT grpcode FROM Loans WHERE ctrcode='" + txtctr.SelectedValue.ToString + "' ORDER BY grpcode ASC"
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
        txtsch_weeks.Text = cboterms.Text
        If multiproduct = "Y" Then
            Dim dtched As Date = dtschedoffirst.Value
            Dim payno As Integer = 0
            Dim intdue As Decimal = 0
            Dim prndue As Decimal = 0
            Dim ttlmarkup As Decimal = 0
            Dim ttlnamount As Decimal = 0
            Dim ttlreceivable As Decimal = 0
            Dim loanamnt As Decimal = Double.Parse(txtlnamnt.Text)

            lstgensched.Items.Clear()
            'Try
            txtschdlnamnt.Text = txtlnamnt.Text
            txtschdinterestperann.Text = interest.ToString
            lstgensched.Items.Clear()
            Dim dtsched As Date = dtschedoffirst.Value
            payno = 0
            intdue = 0
            prndue = 0
            ttlmarkup = 0
            For i As Integer = 0 To dtgrid_items.Rows.Count - 1
                If dtgrid_items.Rows(i).Cells(4).Value <> "" Then
                    ttlmarkup = ttlmarkup + Double.Parse(dtgrid_items.Rows(i).Cells(4).Value)
                End If
            Next
            loanamnt = Double.Parse(txtlnamnt.Text) - Double.Parse(ttlmarkup)
            txtschdpayable.Text = payable
            prndue = loanamnt / payable
            intdue = ttlmarkup / payable

            lblprndue.Text = 0
            lblintdue.Text = 0
            For x As Integer = 0 To payable - 1
                payno = payno + 1
                Dim lvitem As New ListViewItem(payno)
                lvitem.SubItems.Add(dtsched)
                If x = (payable - 1) Then
                    Dim lstprndue As Decimal = loanamnt - Double.Parse(lblprndue.Text)
                    Dim lstintdue As Decimal = ttlmarkup - Double.Parse(lblintdue.Text)

                    lvitem.SubItems.Add(lstprndue.ToString("F", CultureInfo.InvariantCulture))
                    lvitem.SubItems.Add(lstintdue.ToString("F", CultureInfo.InvariantCulture))
                Else
                    lvitem.SubItems.Add(prndue.ToString("F", CultureInfo.InvariantCulture))
                    lvitem.SubItems.Add(intdue.ToString("F", CultureInfo.InvariantCulture)) '454 - 1980
                End If
                lvitem.SubItems.Add(savings)
                lvitem.SubItems.Add(cf)
                lvitem.SubItems.Add(0)
                lstgensched.Items.Add(lvitem)

                ttlreceivable = Double.Parse(lstgensched.Items(x).SubItems(2).Text) + Double.Parse(lstgensched.Items(x).SubItems(3).Text) + Double.Parse(lstgensched.Items(x).SubItems(4).Text) + Double.Parse(lstgensched.Items(x).SubItems(5).Text)
                lvitem.SubItems.Add(ttlreceivable.ToString("F", CultureInfo.InvariantCulture))

                lvitem.SubItems.Add(Double.Parse(lstgensched.Items(x).SubItems(2).Text) * Double.Parse(payno))
                lvitem.SubItems.Add(Double.Parse(lstgensched.Items(x).SubItems(3).Text) * Double.Parse(payno))

                If txtsch_weeks.Text = "Daily" Then
                    dtsched = dtsched.AddDays(1)
                ElseIf txtsch_weeks.Text = "Week(s)" Then
                    dtsched = dtsched.AddDays(7)
                ElseIf txtsch_weeks.Text = "Semi-Monthly" Then
                    dtsched = dtsched.AddDays(14)
                ElseIf txtsch_weeks.Text = "Month(s)" Then
                    dtsched = dtsched.AddMonths(1)
                ElseIf txtsch_weeks.Text = "Year(s)" Then
                    dtsched = dtsched.AddYears(1)
                End If
                'If x = payable - 1 Then
                lblmatdate.Text = lstgensched.Items(x).SubItems(1).Text
                'End If
                lblprndue.Text = Double.Parse(lstgensched.Items(x).SubItems(2).Text) + Double.Parse(lblprndue.Text)
                lblintdue.Text = Double.Parse(lstgensched.Items(x).SubItems(3).Text) + Double.Parse(lblintdue.Text)
            Next
        Else

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
                payno = payno + 1
                Dim lvitem As New ListViewItem(payno)
                lvitem.SubItems.Add(dtsched)
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
                    dtsched = dtsched.AddDays(14)
                ElseIf cboterms.Text = "Month(s)" Then
                    dtsched = dtsched.AddMonths(1)
                ElseIf cboterms.Text = "Year(s)" Then
                    dtsched = dtsched.AddYears(1)
                End If

                'If x = payable - 1 Then
                lblmatdate.Text = lstgensched.Items(x).SubItems(1).Text
                'End If
                lblprndue.Text = Double.Parse(lstgensched.Items(x).SubItems(2).Text) + Double.Parse(lblprndue.Text)
                lblintdue.Text = Double.Parse(lstgensched.Items(x).SubItems(3).Text) + Double.Parse(lblintdue.Text)
            Next
            'Catch ex As Exception

            'End Try
        End If

        For x As Integer = 0 To lstgensched.Items.Count - 1
            If x Mod 2 Then
                lstgensched.Items(x).BackColor = Color.LightGreen
            Else
                lstgensched.Items(x).BackColor = Color.White
            End If
        Next

        'bttnsave.Enabled = True
        bttnsave.Focus()

        bttndisclosure.Enabled = True
        bttnpromissory.Enabled = True
    End Sub

    Private Sub gen_deduction()
        conn()
        sql = "SELECT * from deductionMF where code ='" + dtgrd_deduction.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            dtgrd_deduction.CurrentRow.Cells(1).Value = rd("code").ToString
            If rd("percentage") > 0 Then
                dtgrd_deduction.CurrentRow.Cells(2).Value = Double.Parse(txtlnamnt.Text) * rd("percentage")
            Else
                dtgrd_deduction.CurrentRow.Cells(2).Value = rd("fixedamnt").ToString
            End If

        End If
        rd.Close()
        myConn.Close()
        Dim lndeduction As Decimal = 0
        For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
            If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                lndeduction = Double.Parse(dtgrd_deduction.Rows(i).Cells(2).Value) + lndeduction
            End If
        Next
        txtdeduction.Text = lndeduction
        If lndeduction > 0 Then
            dtgrid_items.Rows.Clear()
        End If
        'txtlnamnt.Focus()
        txtlnproceeds.Text = Decimal.Parse(txtlnamnt.Text) - lndeduction

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
                sql = "INSERT INTO LoansDeduction(PnNumber,code,Description,Amount) VALUES ('" + txtlno.Text + "','" + dtgrd_deduction.Rows(i).Cells(1).Value + "','" + dtgrd_deduction.Rows(i).Cells(3).Value + "'," + dtgrd_deduction.Rows(i).Cells(2).Value.ToString + ")"
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
            gen_sacct()
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
            gen_sacct()
            select_cycle()
        End If
    End Sub

    Private Sub txtloantype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtloantype.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboterms.Focus()
        End If
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated

    End Sub

    Private Sub gen_loan_rate()
        Try
            conn()
            sql = "SELECT * FROM loantype WHERE loancode=" + txtloantype.SelectedValue.ToString + ""
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                loannum = rd("loannum").ToString
                loanrate = rd("rate").ToString
                cf = rd("CF").ToString
                savingsrate = rd("SavingsPrcnt").ToString
                penaltyrate = rd("penaltyrate").ToString
                txtschdinterestperann.Text = loanrate.ToString
                cbu = rd("CBU").ToString
            End If
            rd.Close()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
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
        ElseIf txtctr.SelectedValue = "" Then
            MsgBox("Invalid selection of center.", MsgBoxStyle.Exclamation, "Invalid")
            txtctr.Focus()
        ElseIf cbogrpcode.Text.Trim = "" Then
            MsgBox("Group No. is required.", MsgBoxStyle.Exclamation, "Invalid")
            cbogrpcode.Focus()
        ElseIf cboterms.Text.Trim = "" Then
            MsgBox("Term field is required.", MsgBoxStyle.Exclamation, "Invalid")
            cboterms.Focus()
        ElseIf productcode = "HL" And txtsaacct.Text.Trim = "" Then
            MsgBox("Savings account is empty.", MsgBoxStyle.Exclamation, "Invalid Savings Acct.")
        ElseIf IsNumeric(txtlnamnt.Text) = False Then
            MsgBox("Invalid Loan Amount.", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        ElseIf Double.Parse(txtlnamnt.Text) < 1 Then
            MsgBox("Loan amount should be greater than 0.", MsgBoxStyle.Exclamation, "Invalid")
            txtlnamnt.Focus()
        Else
            gen_loan_rate()
            If Me.Text = "Edit Loan" Then
                If MessageBox.Show("Are you sure you want to update this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    conn()
                    sql = "UPDATE Loans SET CollCode='" + txtcoll.SelectedValue + "',"
                    sql += "FundCode='" + txtfunding.SelectedValue + "',"
                    sql += "LoanAmnt=" + Double.Parse(txtlnamnt.Text).ToString + ","
                    sql += "netproceeds=" + txtlnproceeds.Text + ","
                    sql += "IntRate=" + txtschdinterestperann.Text + ","
                    sql += "ModeofPayment='" + cboterms.Text + "',"
                    sql += "Status='A',Released='N',userid='" + user.ToString + "',"
                    sql += "loantype='" + loantype.ToString + "',"
                    sql += "Firstpaymentdate='" + dtschedoffirst.Value + "',"
                    sql += "releasedate='" + dtrel.Value + "',"
                    sql += "cycle=" + cycle.ToString + ","
                    sql += "ctrcode='" + txtctr.SelectedValue + "',"
                    sql += "col_type='" + cbo_collateral.Text + "',"
                    sql += "purpose='" + txtloan_purpose.Text + "',"
                    sql += "grpcode='" + cbogrpcode.Text + "' WHERE pnnumber='" + txtlno.Text + "'"
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
                    insert_loanitems()
                    insert_loansched()
                    MsgBox("Loan Number " & txtlno.Text & " was successfully updated.", MsgBoxStyle.Information)
                End If

            ElseIf Me.Text = "View Loan" Then
                'bttn_gensched.Enabled = False
                conn()
                sql = "UPDATE loans set CollCode='" + txtcoll.SelectedValue.ToString + "',ctrcode='" + txtctr.SelectedValue.ToString + "',grpcode='" + cbogrpcode.Text + "' WHERE pnnumber='" + txtlno.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                insert_loansched()
                MsgBox("Loan Number " & txtlno.Text & " was successfully updated.", MsgBoxStyle.Information, "Success")
            Else
                'If txtcomaker.Text.Trim = "" Or txtcoaddress.Text.Trim = "" Or txtcocontact.Text.Trim = "" Then
                '    MsgBox("Note : CoMaker information is needed. You can still edit this loan to add a CoMaker.", MsgBoxStyle.Information, "Information")
                'End If
                conn()
                sql = "SELECT pnnumber FROM loans where pnnumber='" + txtlno.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If Not rd.Read Then
                    If MessageBox.Show("Are you sure you want to save this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        gen_pnnumber()
                        update_pnnumber()

                        conn()
                        sql = "INSERT INTO Loans(Memcode,Pnnumber,CollCode,FundCode,LoanAmnt,TotalDeduction,netproceeds,IntRate,modeofpayment,LoanDate,Status,Released,userid,loantype,cycle,firstpaymentdate,releasedate,ctrcode,grpcode,col_type,Purpose,PayNo,PenaltyRate,Accountnumber,GL_loans) VALUES "
                        sql += "('" + txtmember.SelectedValue + "',"
                        sql += "'" + txtlno.Text + "',"
                        sql += "'" + txtcoll.SelectedValue.ToString + "',"
                        sql += "'" + txtfunding.SelectedValue.ToString + "',"
                        sql += "" + Double.Parse(txtlnamnt.Text).ToString + ","
                        sql += "" + txtdeduction.Text + ","
                        sql += "" + txtlnproceeds.Text + ","
                        sql += "" + txtschdinterestperann.Text + ","
                        sql += "'" + cboterms.Text + "',"
                        sql += "'" + systemdate.ToString + "',"
                        sql += "'A',"
                        sql += "'N',"
                        sql += "'" + user.ToString + "',"
                        sql += "'" + txtloantype.SelectedValue + "',"
                        sql += "" + txtcycle.Text + ","
                        sql += "'" + dtschedoffirst.Value + "',"
                        sql += "'" + dtrel.Value + "',"
                        sql += "'" + txtctr.SelectedValue + "',"
                        sql += "" + cbogrpcode.Text + ","
                        sql += "'" + cbo_collateral.Text + "',"
                        sql += "'" + txtloan_purpose.Text + "',"
                        sql += "" + payable.ToString + ","
                        sql += "" + penaltyrate.ToString + ","
                        sql += "'" + txtsaacct.Text + "',"
                        sql += "'" + GL_loans + "'"
                        sql += ")"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()

                        'update_members_saacct()
                        insert_deductions()
                        insert_loanitems()
                        insert_comaker()
                        insert_benefeciary()

                        'MsgBox("New loan was successfully added.", MsgBoxStyle.Information)
                        txtschdlnamnt.Text = txtlnamnt.Text
                        insert_loansched()
                        'bttn_gensched.Enabled = True
                        'bttn_gensched.Focus()
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

    Private Sub insert_loanitems()
        For i As Integer = 0 To dtgrid_items.Rows.Count - 1
            If dtgrid_items.Rows(i).Cells(2).Value <> "" Then
                conn()
                sql = "INSERT INTO Loanitems(PnNumber,itemcode,reference,ItemPrice,qty,markup,remarks,userID) VALUES "
                sql += "('" + txtlno.Text + "',"
                sql += "'" + dtgrid_items.Rows(i).Cells(2).Value + "',"
                sql += "'" + dtgrid_items.Rows(i).Cells(0).Value + "',"
                sql += "" + dtgrid_items.Rows(i).Cells(3).Value + ","
                sql += "" + dtgrid_items.Rows(i).Cells(1).Value + ","
                sql += "" + dtgrid_items.Rows(i).Cells(4).Value.ToString + ","
                sql += "'" + "Item release to " & txtmember.Text + "',"
                sql += "'" + user + "'"
                sql += ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
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

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        For i As Integer = 0 To lstloans.Items.Count - 1
            txtlno.Text = lstloans.Items(i).SubItems(0).Text
            edit()
            conn()
            sql = "SELECT * FROM LoanItems WHERE pnnumber='" + txtlno.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            dtgrid_items.Rows.Clear()
            While rd.Read
                dtgrid_items.Rows.Add(rd("reference").ToString, rd("qty").ToString, rd("ItemCode").ToString, rd("ItemPrice").ToString, rd("markup").ToString, (Double.Parse(rd("ItemPrice")) + Double.Parse(rd("markup"))))
            End While
            rd.Close()
            myConn.Close()
            insert_loansched()
            'GoTo 1
        Next
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

        Dim deductionsMF As System.Data.DataTable = New System.Data.DataTable()
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
        amount.ReadOnly = True
        amount.Width = 120

        '3
        Dim dummy As New GridViewTextBoxColumn("dummy")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(dummy)
        dummy.IsVisible = False

        If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
            conn()
            sql = "SELECT * FROM LoansDeduction WHERE pnnumber='" + txtlno.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                dtgrd_deduction.Rows.Add(rd("code").ToString, rd("code").ToString, rd("amount").ToString, rd("Description").ToString)
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
        gen_deduction()
        dtgrd_deduction.CurrentRow.Cells(3).Value = dtgrd_deduction.CurrentCell.Text
    End Sub

    Private Sub dtgrd_deduction_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrd_deduction.Validated
        gen_deduction()
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
            gen_deduction()
            txtlnamnt.Text = Format(Me.txtlnamnt.Text("Currency"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub insert_loansched()
        'conn()
        'sql = "SELECT * FROM loancollect WHERE pnnumber='" + txtlno.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader
        'If Not rd.Read Then
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
        'TabControl1.SelectedPage = RadPageViewPage2
        'bttnnew.Enabled = True
        'bttnnew.Focus()
        'Else
        '    MsgBox("Please save loans first to generate the schedule.", MsgBoxStyle.Exclamation, "Invalid")
        'End If
        'rd.Close()
        'myConn.Close()
    End Sub

    Private Sub bttn_gensched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub RadPageViewPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadPageViewPage2.Click
    '    bttnsave.Enabled = True
    'End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        bttnsave.Enabled = True
    End Sub

    Public Sub creategview_beneficiary()
        'InitializeComponent()
        dtgr_benefeciary.Columns.Clear()
        dtgr_benefeciary.Rows.Clear()

        Dim beneficiary As System.Data.DataTable = New System.Data.DataTable()
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


    Private Sub dtgrid_items_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrid_items.CellEditorInitialized
        If dtgrid_items.CurrentCell.ColumnIndex = 0 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.dtgrid_items.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol_Items.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
            dtgrid_items.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextCell
        End If
    End Sub

    Private Sub dtgrid_items_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrid_items.CellEndEdit
        Try
            If dtgrid_items.CurrentCell.ColumnIndex = 1 Then
                conn()
                sql = "SELECT * from Iteminventory where reference ='" + dtgrid_items.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    dtgrid_items.CurrentRow.Cells(2).Value = rd("itemcode").ToString
                    dtgrid_items.CurrentRow.Cells(3).Value = Double.Parse(rd("principal")) * Double.Parse(dtgrid_items.CurrentRow.Cells(1).Value)
                    dtgrid_items.CurrentRow.Cells(4).Value = Double.Parse(rd("markup")) * Double.Parse(dtgrid_items.CurrentRow.Cells(1).Value)
                    dtgrid_items.CurrentRow.Cells(6).Value = rd("grocery").ToString
                    dtgrid_items.CurrentRow.Cells(7).Value = rd("ItemDesc").ToString
                    If rd("grocery") = "Y" Then
                        dtgrid_items.CurrentRow.Cells(1).ReadOnly = True
                        dtgrid_items.CurrentRow.Cells(1).Value = "1"
                    Else
                        dtgrid_items.CurrentRow.Cells(1).ReadOnly = False
                    End If
                End If
                rd.Close()
                myConn.Close()

                'dtgrid_items.CurrentRow.Cells(3).Value = Double.Parse(dtgrid_items.CurrentRow.Cells(3).Value) * Double.Parse(dtgrid_items.CurrentRow.Cells(1).Value)
                'dtgrid_items.CurrentRow.Cells(4).Value = Double.Parse(dtgrid_items.CurrentRow.Cells(4).Value) * Double.Parse(dtgrid_items.CurrentRow.Cells(1).Value)
            End If

            For i As Integer = 0 To dtgrid_items.Rows.Count - 1
                If dtgrid_items.Rows(i).Cells(3).Value <> "" Then
                    If dtgrid_items.CurrentRow.Cells(1).Value <> "" And dtgrid_items.CurrentRow.Cells(6).Value = "Y" Then
                        If payable > 6 Then
                            dtgrid_items.CurrentRow.Cells(4).Value = Double.Parse(dtgrid_items.CurrentRow.Cells(3).Value) * 0.25
                        Else
                            dtgrid_items.CurrentRow.Cells(4).Value = Double.Parse(dtgrid_items.CurrentRow.Cells(3).Value) * 0.2
                        End If
                    End If
                    dtgrid_items.CurrentRow.Cells(5).Value = Decimal.Parse(dtgrid_items.CurrentRow.Cells(3).Value) + Decimal.Parse(dtgrid_items.CurrentRow.Cells(4).Value)
                    txtlnamnt.Text = 0
                    'Try
                    txtlnamnt.Text = Double.Parse(dtgrid_items.Rows(i).Cells(5).Value) + Double.Parse(txtlnamnt.Text)
                    txtlnproceeds.Text = Double.Parse(txtlnamnt.Text) - Double.Parse(txtdeduction.Text)
                End If

                If dtgrid_items.Rows(i).Cells(6).Value = "Y" Then
                    'dtgrd_deduction.Rows(i).Cells(1).ReadOnly = True
                    dtgrid_items.Rows(i).Cells(4).ReadOnly = True
                    'dtgrd_deduction.Rows(i).Cells(3).ReadOnly = False
                Else
                    'dtgrd_deduction.Rows(i).Cells(1).ReadOnly = False
                    'dtgrd_deduction.Rows(i).Cells(3).ReadOnly = True
                    dtgrid_items.Rows(i).Cells(4).ReadOnly = False
                End If
            Next
            Try
                dtgrid_items.CurrentRow.Cells(5).Value = Double.Parse(dtgrid_items.CurrentRow.Cells(3).Value) + Double.Parse(dtgrid_items.CurrentRow.Cells(4).Value)
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gen_grpcode()
        conn()
        sql = "SELECT TOP 1 grpcode from loans where memcode ='" + txtmember.SelectedValue + "' order by releasedate DESC"
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

    Private Sub dtgridmembers_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dtgrid_items_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_items.Validated
        Try
            Dim lnamount As Decimal = 0
            For i As Integer = 0 To dtgrid_items.Rows.Count - 1
                'Try
                lnamount = Decimal.Parse(dtgrid_items.Rows(i).Cells(5).Value) + lnamount
                txtlnproceeds.Text = Decimal.Parse(txtlnamnt.Text) - Decimal.Parse(txtdeduction.Text)
            Next
            txtlnamnt.Text = lnamount
            If lnamount > 1 Then
                dtgrd_deduction.Rows.Clear()
                txtdeduction.Text = 0
            End If
            gen_sched()
        Catch ex As Exception

        End Try
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
        Dim r1 As System.Drawing.Rectangle = e.Bounds
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
        Dim r2 As System.Drawing.Rectangle = e.Bounds
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
        gen_pnnumber()
        setgrpcode()
        If Not productcode = "CL" Then
            gen_sacct()
        End If
        select_cycle()
        txtfunding.Focus()
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
        Dim r1 As System.Drawing.Rectangle = e.Bounds
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
        Dim r2 As System.Drawing.Rectangle = e.Bounds
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
            sql = "SELECT DISTINCT grpcode FROM Loans WHERE ctrcode='" + txtctr.SelectedValue.ToString + "' ORDER BY grpcode ASC"
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

    Private Sub lstloans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstloans.Click
        
    End Sub

    Private Sub lstloans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstloans.SelectedIndexChanged
        
    End Sub
End Class