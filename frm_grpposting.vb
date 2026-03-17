Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.Threading

Public Class frm_grpposting
    Public comboCol_deduction As New GridViewMultiComboBoxColumn("GL Account")
    Dim postno As Integer = 0
    Dim postnoCF As Integer = 0
    Dim runbal As Integer = 0
    Dim count_click As Integer = 0
    'Dim ctrlnum As Integer = 0
    Dim saacct_CF As String
    Dim ttlcf As Decimal = 0
    Dim ttlPS As Decimal = 0
    Dim amntpost As Decimal = 0
    Dim ttlprin As Decimal = 0
    Dim ttlint As Decimal = 0

    Dim prndue As Decimal = 0
    Dim intdue As Decimal = 0
    Dim cf As Decimal = 0
    Dim life_health As Decimal = 0
    Dim cbu As Decimal = 0
    Dim p_savings As Decimal = 0
    Dim total_amntpaid = 0
    Dim payno As Decimal = 0
    Dim colldate As DateTime
    Dim intbal As Decimal = 0
    Dim prinbal As Decimal = 0
    Dim advprn As Decimal = 0
    Dim advint As Decimal = 0
    Dim memcode As String

    Private Sub frm_grpposting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdate.Enabled = False
        txtdate.Value = systemdate
        dtcoll.Value = systemdate
        gen_loantype()
        gen_cashGL()
        If grouptype = "Y" And multiproduct = "N" Then
            lbloption.Text = "Center :"
            select_center()
        Else
            lbloption.Text = "Product Assistant :"
            select_coll()
        End If
        txtloantype.Focus()
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

    Private Sub gen_cashGL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM ChartAccounts WHERE Accttype = 'cash'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Account Name")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcash.DataSource = table1
        Me.txtcash.AutoFilter = True
        myConn.Open()
        txtcash.DisplayMember = "Account Name"
        txtcash.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcash.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcash.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcash.EditorControl.Columns(0).Width = 90
        Me.txtcash.EditorControl.Columns(1).Width = 200
        Me.txtcash.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub

    Private Sub select_center()
        'Try
        Dim table1 As DataTable = New DataTable()
        conn()
        'sql = "SELECT a.ctrcode,a.ctrname FROM center a WHERE gl_loans='" + GL_loans + "' and a.ctrcode in(select AcctReference from CashiersTransaction where Trndate='" + txtdate.Value + "')"
        sql = "SELECT a.ctrcode,a.ctrname FROM center a WHERE gl_loans='" + GL_loans + "'"
        cmd = New SqlCommand(sql, myConn)

        myConn.Open() '// added a new line to open connection
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Center Code")
        table1.Columns.Add("Center Name")

        table1.Rows.Add("xxx", "--please select--")
        While (rd.Read())
            table1.Rows.Add(rd("ctrcode").ToString, rd("ctrname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcenter.DataSource = table1
        Me.txtcenter.AutoFilter = True
        txtcenter.DisplayMember = "Center Name"
        txtcenter.ValueMember = "Center Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcenter.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcenter.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcenter.EditorControl.Columns(0).Width = 100
        Me.txtcenter.EditorControl.Columns(1).Width = 200
        Me.txtcenter.MultiColumnComboBoxElement.DropDownWidth = 400
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub select_coll()
        Try
            Dim table1 As DataTable = New DataTable()
            conn()
            ' ORIGNAL
            sql = "select CollCode,fullname from Officer where status='A' and collcode in(select acctreference from CashiersTransaction where trndate='" + txtdate.Value + "')"

            ' NEW NO COLLCODE 12/13/2021
            sql = "select CollCode,fullname from Officer where status='A' " 'and collcode in(select acctreference from CashiersTransaction where trndate='" + txtdate.Value + "')"
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

            txtcenter.DataSource = table1

            Me.txtcenter.AutoFilter = True
            txtcenter.DisplayMember = "Fullname"
            txtcenter.ValueMember = "Code"
            Dim filter As New FilterDescriptor()
            filter.PropertyName = Me.txtcenter.DisplayMember
            filter.Operator = FilterOperator.Contains
            Me.txtcenter.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            Me.txtcenter.EditorControl.Columns(0).Width = 100
            Me.txtcenter.EditorControl.Columns(1).Width = 200
            Me.txtcenter.MultiColumnComboBoxElement.DropDownWidth = 350
        Catch ex As Exception

        End Try
    End Sub

    Public Sub view_center_posting()
        'dtgrid_grpposting.Rows.Clear()

        'If multiproduct = "Y" Then
        '    chkprndue.Enabled = False
        '    chksavings.Enabled = False
        '    chkprndue.Checked = True
        '    conn()
        '    sql = "select * from ("
        '    sql += "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar from ("
        '    sql += "select a.pnnumber,a.MemCode,a.grpcode,a.ctrcode,(CONVERT(VARCHAR(10),a.loandate,110)) As loandate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As matdate,"
        '    sql += "b.savings,b.CF,b.CBU,LH=isnull((b.LH),0),c.Fullname,"
        '    sql += "Accountnumber='xxx'," 'isnull((select accountnumber from Accountmaster where memcode=c.memcode and Accountstatus='Active'),'0'),"
        '    sql += "interestdue=isnull((select SUM(interest) from loansched where pnnumber=a.pnnumber),0),"
        '    sql += "prnamnt=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        '    sql += "collname=(select fullname from Officer where CollCode=a.CollCode and GL_loans=a.GL_loans),"
        '    sql += "ctrname=(select ctrchief from Center where ctrcode=a.ctrcode AND GL_loans=a.GL_loans),"
        '    sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtcoll.Value + "'),b.principal),"
        '    sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtcoll.Value + "'),b.interest),"
        '    sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        '    sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        '    sql += "payno=isnull((select top 1 (payno)+1 from loancollect where pnnumber=a.pnnumber order by payno desc),1),"
        '    sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin<((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        '    sql += "from Loans a,Loansched b, Members c where"
        '    sql += " a.ctrcode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + GL_loans + "' "
        '    sql += " and a.pnnumber=b.pnnumber and a.MemCode=c.MemCode AND a.status='A' and a.released='Y'  AND b.duedate='" + dtcoll.Value + "' "
        '    sql += ") x"
        '    sql += ") y  GROUP BY y.matdate,y.loandate,y.Accountnumber,y.ctrcode,y.collname,y.ctrname,y.PrnPar,y.IntPar,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.payno,y.Duedate,y.pnnumber,y.MemCode,y.Fullname,y.prnamnt,y.interestdue,y.grpcode,y.savings,y.CF,y.CBU,y.LH ORDER BY y.ctrcode,y.grpcode,y.Fullname,y.pnnumber ASC"
        'Else
        '    'conn()
        '    'sql = "select * from ("
        '    'sql += "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar from ("
        '    'sql += "select a.pnnumber,a.MemCode,a.grpcode,a.ctrcode,(CONVERT(VARCHAR(10),a.loandate,110)) As loandate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As matdate,"
        '    'sql += "b.savings,b.CF,b.CBU,LH=isnull((b.LH),0),c.Fullname,a.accountnumber,"
        '    'sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        '    'sql += "prnamnt=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        '    'sql += "collname=(select fullname from Officer where CollCode=a.CollCode AND GL_loans=a.GL_loans),"
        '    'sql += "ctrname=(select ctrchief from Center where ctrcode=a.ctrcode AND GL_loans=a.GL_loans),"
        '    'sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtcoll.Value + "'),0),"
        '    'sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtcoll.Value + "'),0),"
        '    'sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        '    'sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        '    'sql += "payno=isnull((select top 1 (payno)+1 from loancollect where pnnumber=a.pnnumber order by payno desc),1),"
        '    'sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin<((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        '    'sql += "from Loans a,Loansched b, Members c  where"
        '    'If grouptype = "N" Then
        '    '    sql += " a.collcode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + GL_loans + "' "
        '    'Else
        '    '    sql += " a.ctrcode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + GL_loans + "' "
        '    'End If
        '    'sql += " and a.pnnumber=b.pnnumber and a.MemCode=c.MemCode AND a.status='A' and a.released='Y'  AND b.duedate='" + dtcoll.Value + "' "
        '    'sql += ") x"
        '    'sql += ") y  GROUP BY y.matdate,y.loandate,y.ctrcode,y.collname,y.ctrname,y.PrnPar,y.IntPar,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.payno,y.Duedate,y.Accountnumber,y.pnnumber,y.MemCode,y.Fullname,y.prnamnt,y.interestdue,y.grpcode,y.savings,y.CF,y.CBU,y.LH ORDER BY y.grpcode,y.Fullname ASC"

        '    conn()
        '    sql = "select * from ("
        '    sql += "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar,(x.TotalPrnPaid+x.TotalintPaid) as ttlamntpaid from ("
        '    sql += "select a.Accountnumber,a.pnnumber,c.SSSNo,a.interestdue,a.MemCode,a.grpcode,a.ctrcode,(CONVERT(VARCHAR(10),a.releasedate,110)) As releasedate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As maturitydate,"
        '    sql += "b.Interest,b.Principal,b.savings,LH=isnull((b.lh),0),b.Duedate,b.CF,c.Fullname,"
        '    sql += "sssbal=isnull((select sum(debit-credit) from SSSLedger where memcode=a.memcode),0),"
        '    sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        '    sql += "intloan=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        '    sql += "collname=(select fullname from Officer where CollCode=a.CollCode),"
        '    sql += "ctrname=(select ctrchief from Center where ctrcode=a.ctrcode),"
        '    sql += "ctraddr=(select ctraddress from Center where ctrcode=a.ctrcode),"
        '    sql += "payno=isnull((select top 1 (payno)+1 from loancollect where pnnumber=a.pnnumber order by payno desc),1),"
        '    sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<'" + dtcoll.Value + "'),0),"
        '    sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<'" + dtcoll.Value + "'),0),"
        '    sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtcoll.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        '    sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + dtcoll.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        '    sql += "TotalPayment=ISNULL((select count(pnnumber) FROM loancollect where pnnumber=a.pnnumber and cancel='N'),0),"
        '    sql += "savingsBal=isnull((select (SUM(debit)-SUM(credit)) from accountledger where Active='Y' and accountnumber=a.accountnumber),0)"
        '    sql += "from Loans a,Loansched b, Members c where"
        '    sql += " a.ctrcode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + txtloantype.SelectedValue + "' "
        '    sql += " and a.pnnumber=b.pnnumber and a.MemCode=c.MemCode  AND a.status='A' AND c.status='A' and a.released='Y' "
        '    sql += ") x"
        '    sql += ") y where y.Duedate='" + dtcoll.Value + "' ORDER BY y.grpcode,y.fullname ASC"
        'End If

        'cmd = New SqlCommand(sql, myConn)
        'cmd.CommandTimeout = 120
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'Try

        'MsgBox("Public Sub view_center_posting()")


        Dim row As DataRow = Nothing
        Dim connection As SqlConnection
        Dim adapter As SqlDataAdapter
        Dim command As New SqlCommand

        'Dim ds As New DataSet
        Dim dsr As New DataSet

        connection = New SqlConnection(constr)

        connection.Open()

        command.Connection = connection
        command.CommandTimeout = 300
        command.CommandType = CommandType.StoredProcedure

        'MsgBox("usp_gen_collectibles")

        command.CommandText = "usp_gen_collectibles"


        'MsgBox(multiproduct)
        command.Parameters.AddWithValue("@gl_loans", txtloantype.SelectedValue)
        command.Parameters.AddWithValue("@ctrcode", txtcenter.SelectedValue)
        command.Parameters.AddWithValue("@view", multiproduct)
        command.Parameters.AddWithValue("@collectionDate", dtcoll.Value)
        command.Parameters.AddWithValue("@trnxdate", txtdate.Value)
        command.Parameters.AddWithValue("@grouptype", grouptype)
        adapter = New SqlDataAdapter(command)
        adapter.Fill(dsr)
        dtgrid_grpposting.Rows.Clear()

        For Each DR As DataRow In dsr.Tables(0).Rows
            Dim prnpar As Decimal = DR("PrnPar")
            Dim intpar As Decimal = DR("IntPar")
            If prnpar < 0 Then
                prnpar = 0
            End If
            If intpar < 0 Then
                intpar = 0
            End If
            dtgrid_grpposting.Rows.Add(CStr(DR("MemCode")).ToString _
                                       , CStr(DR("pnnumber")).ToString _
                                       , CStr(DR("Fullname")).ToString _
                                       , CStr(DR("grpcode")).ToString _
                                       , prnpar _
                                       , intpar _
                                       , prnpar _
                                       , 0 _
                                       , intpar _
                                       , 0 _
                                       , 0 _
                                       , Double.Parse(DR("savings")).ToString _
                                       , Double.Parse(DR("CF")).ToString _
                                       , 0 _
                                        , Double.Parse(DR("LH")).ToString _
                                       , Double.Parse(DR("PrnPar") + DR("IntPar") + DR("savings") + DR("CF") + DR("LH")) _
                                       , "" _
                                       , Double.Parse(DR("prnamnt") - DR("TotalPrnPaid")) _
                                       , Double.Parse(DR("interestdue") - DR("TotalintPaid")) _
                                       , (Double.Parse(DR("prnamnt") + DR("interestdue"))) - (Double.Parse(DR("TotalPrnPaid") + DR("TotalintPaid"))) _
                                       , CStr(DR("payno")).ToString _
                                       , CStr(DR("pnnumber")).ToString _
                                       , CStr(DR("Accountnumber")).ToString _
                                       , Double.Parse(DR("savings")) _
                                       , Double.Parse(DR("cf")).ToString _
                                       , CStr(DR("memcode")).ToString _
                                       )
        Next
        bttnsave.Enabled = True
        bttncancel.Enabled = True

        'For i = 0 To dsr.Tables(0).Rows.Count - 1
        '    dtgrid_grpposting.Rows.Add(dsr.Tables(0).Rows(i).Item(0), _
        '                               dsr.Tables(0).Rows(i).Item(1), _
        '                               dsr.Tables(0).Rows(i).Item(2), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3), _
        '                               dsr.Tables(0).Rows(i).Item(3))
        'Next
        connection.Close()

        For x As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
            If x Mod 2 Then
                dtgrid_grpposting.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Dim rows As DataGridViewRow = dtgrid_grpposting.Rows(x)
            rows.Height = 35
        Next
        pn_load.Visible = False
        'Catch ex As Exception

        'End Try
        '       While rd.Read
        '           Dim x As Integer = dtgrid_grpposting.Rows.Add
        '           dtgrid_grpposting.Rows(x).Cells(0).Value = rd("MemCode").ToString
        '           dtgrid_grpposting.Rows(x).Cells(1).Value = rd("pnnumber").ToString
        '           dtgrid_grpposting.Rows(x).Cells(2).Value = rd("Fullname").ToString
        'dtgrid_grpposting.Rows(x).Cells(3).Value = rd("grpcode").ToString
        '           If rd("PrnPar") < 0 Then
        '               dtgrid_grpposting.Rows(x).Cells(4).Value = 0
        '           Else
        '               dtgrid_grpposting.Rows(x).Cells(4).Value = rd("PrnPar").ToString
        '           End If
        '           If rd("IntPar") < 0 Then
        '               dtgrid_grpposting.Rows(x).Cells(5).Value = 0
        '           Else
        '               dtgrid_grpposting.Rows(x).Cells(5).Value = rd("IntPar").ToString
        '           End If
        '           dtgrid_grpposting.Rows(x).Cells(6).Value = dtgrid_grpposting.Rows(x).Cells(4).Value
        '           dtgrid_grpposting.Rows(x).Cells(7).Value = 0
        '           dtgrid_grpposting.Rows(x).Cells(8).Value = dtgrid_grpposting.Rows(x).Cells(5).Value
        '           dtgrid_grpposting.Rows(x).Cells(9).Value = 0
        '           dtgrid_grpposting.Rows(x).Cells(10).Value = 0
        '           dtgrid_grpposting.Rows(x).Cells(11).Value = rd("savings").ToString
        '           dtgrid_grpposting.Rows(x).Cells(12).Value = rd("CF").ToString
        '           dtgrid_grpposting.Rows(x).Cells(13).Value = 0
        '           dtgrid_grpposting.Rows(x).Cells(14).Value = rd("LH").ToString
        '           dtgrid_grpposting.Rows(x).Cells(15).Value = (((Double.Parse(dtgrid_grpposting.Rows(x).Cells(6).Value) + Double.Parse(dtgrid_grpposting.Rows(x).Cells(7).Value) + Double.Parse(dtgrid_grpposting.Rows(x).Cells(8).Value)) + Double.Parse(dtgrid_grpposting.Rows(x).Cells(9).Value)) + Double.Parse(dtgrid_grpposting.Rows(x).Cells(10).Value)) + Double.Parse(dtgrid_grpposting.Rows(x).Cells(11).Value) + Double.Parse(dtgrid_grpposting.Rows(x).Cells(12).Value)
        '           dtgrid_grpposting.Rows(x).Cells(16).Value = ""
        '           dtgrid_grpposting.Rows(x).Cells(17).Value = Double.Parse(rd("prnamnt").ToString) - Double.Parse(rd("TotalPrnPaid").ToString)
        '           dtgrid_grpposting.Rows(x).Cells(18).Value = Double.Parse(rd("interestdue").ToString) - Double.Parse(rd("TotalintPaid").ToString)
        '           dtgrid_grpposting.Rows(x).Cells(19).Value = (Double.Parse(rd("prnamnt").ToString) + Double.Parse(rd("interestdue").ToString)) - (Double.Parse(rd("TotalPrnPaid").ToString) + Double.Parse(rd("TotalintPaid").ToString))
        '           dtgrid_grpposting.Rows(x).Cells(20).Value = rd("payno").ToString
        '           dtgrid_grpposting.Rows(x).Cells(21).Value = rd("pnnumber").ToString
        '           dtgrid_grpposting.Rows(x).Cells(22).Value = rd("Accountnumber").ToString
        '           dtgrid_grpposting.Rows(x).Cells(23).Value = rd("savings").ToString
        '           dtgrid_grpposting.Rows(x).Cells(24).Value = rd("CF").ToString
        '           dtgrid_grpposting.Rows(x).Cells(25).Value = rd("memcode").ToString
        '           bttnsave.Enabled = True
        '           bttncancel.Enabled = True
        '       End While
        '       myConn.Close()

        '       For x As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
        '           If x Mod 2 Then
        '               dtgrid_grpposting.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
        '           End If
        '           Dim row As DataGridViewRow = dtgrid_grpposting.Rows(x)
        '           row.Height = 30
        '       Next
        '       'Catch ex As Exception
        '       'End Try
    End Sub

    Private Sub dtgrid_grpposting_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_grpposting.CellClick
        'If multiproduct = "Y" Then
        '    chkprndue.Checked = True
        'Else
        '    chksavings.Checked = True
        'End If
        ''view_loansched()
        ''cbo_collections.Text = dtcoll.Value
        ''gen_amounts()
        'txtsss.Focus()
    End Sub

    Private Sub dtgrid_grpposting_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_grpposting.CellEndEdit
        amntpost = 0
        For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
            amntpost = amntpost + Decimal.Parse(dtgrid_grpposting.Rows(i).Cells(15).Value)
        Next

        lblamntpost.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", amntpost)
        If chk_PR.Checked = True Then
            If dtgrid_grpposting.CurrentRow.Cells(16).Value <> "" Then
                For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
                    If dtgrid_grpposting.Rows(i).Cells(3).Value = dtgrid_grpposting.CurrentRow.Cells(3).Value Then
                        dtgrid_grpposting.Rows(i).Cells(16).Value = dtgrid_grpposting.CurrentRow.Cells(16).Value
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub txtdate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdate.Validated
        'If productcode = "HL" Or productcode = "CL" Then
        If grouptype = "Y" Then
            select_center()
        Else
            select_coll()
        End If
        'ElseIf productcode = "IL" Then
        'select_coll()
        'End If
    End Sub

    Private Sub gen_amounts()
        'sql += "lh=isnull(((select sum(lh) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate and duedate >= '2021-10-01 00:00:00')-isnull((SELECT SUM(lh) FROM loancollect where pnnumber=a.pnnumber),0)),0),"

        cbo_collections.SelectedValue = dtcoll.Value
        conn()
        sql = "SELECT a.MemCode,a.pnnumber,a.grpcode,c.Fullname,"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "rngprin=isnull(((select sum(principal) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(principal+advprincipal) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        sql += "rngint=isnull(((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(intpaid+advinterest) FROM loancollect where pnnumber=a.pnnumber),0)),0),"

        ' ORIGINAL
        'sql += "b.principal,b.interest,b.savings,cf=isnull((b.cf),0),lh=isnull((b.lh),0),"

        ' NEW 10/13/2021 - NOW WORKING
        sql += "b.principal,b.interest,b.savings,cf=isnull((b.cf),0), " ' lh=isnull((b.lh),0),"
        ' COMPUTE THE C19 10/13/2021
        sql += "lh=isnull(((select sum(lh) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate and duedate >= '2021-10-01 00:00:00')-isnull((SELECT SUM(lh) FROM loancollect where pnnumber=a.pnnumber),0)),0),"

        'sql += "lh=isnull(((select sum(lh) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(lh) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        'sql += "cf=isnull(((select sum(cf) from loansched where pnnumber=a.pnnumber and duedate<=b.duedate)-isnull((SELECT SUM(cf) FROM loancollect where pnnumber=a.pnnumber),0)),0),"
        'sql += "lh=isnull((select top 1 lh from Loansched where pnnumber=a.pnnumber),0),"
        'sql += "cf=isnull((select top 1 lh from Loansched where pnnumber=a.pnnumber),0),"

        sql += "ttlprnpaid=isnull((select SUM(principal+advprincipal) from LoanCollect where pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((select SUM(intpaid+AdvInterest) from LoanCollect where pnnumber=a.pnnumber),0),"
        sql += "payno=isnull((select count(payno)+1 from loancollect where pnnumber=a.pnnumber),1)"
        sql += "FROM  Loans a,Loansched b, Members c "
        sql += "WHERE a.pnnumber=b.pnnumber AND a.memcode=c.memcode AND a.pnnumber='" + dtgrid_grpposting.CurrentRow.Cells(1).Value + "' AND a.status='A' and b.duedate='" + cbo_collections.Text + "' "
        sql += "GROUP BY a.memcode,a.pnnumber,c.Fullname,a.interestdue,a.grpcode,b.principal,b.interest,b.savings,b.cf,b.lh,b.duedate"


        'sql = "select * from ("
        'sql += "select x.TotalPrnPaid,x.TotalintPaid,x.payno,x.pnnumber,x.Fullname,x.prnloan,x.intloan,x.principal,x.interest,x.savings,x.CF,(x.totalprndue-x.TotalPrnPaid) as prndue,(x.totalintdue-x.TotalIntPaid) as intdue from ("
        'sql += "select a.pnnumber,b.Fullname,a.prnloan,a.intloan,c.principal,c.interest,c.savings,c.CF,"
        'sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + cbo_collections.SelectedValue.ToString + "'),0),"
        'sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + cbo_collections.SelectedValue.ToString + "'),0),"
        'sql += "TotalPrnPaid=isnull((SELECT SUM(prnpaid+advprincipal) from LoanCollect where trnxdate<='" + cbo_collections.SelectedValue.ToString + "' AND pnnumber=a.pnnumber),0),"
        'sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + cbo_collections.SelectedValue.ToString + "' AND pnnumber=a.pnnumber),0),"
        'sql += "payno=(select top 1 (payno)+1 from loancollect where pnnumber=a.pnnumber order by payno desc)"
        'sql += " from Loans a,Members b,loansched c where a.status='A' and a.MemCode=b.MemCode and a.pnnumber=c.pnnumber and a.released='Y' AND a.Loantype='" + productcode.ToString + "'"
        'sql += ") x"
        'sql += ") y where y.pnnumber='" + txtlno.Text + "' GROUP BY y.TotalPrnPaid,y.TotalintPaid,y.payno,y.pnnumber,y.prnloan,y.intloan,y.Fullname,y.principal,y.interest,y.savings,y.CF,y.prndue,y.intdue"
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
            cf = rd("CF").ToString
            p_savings = rd("savings").ToString
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

    Private Sub compute_payment()

        If Double.Parse(txtprnpaid.Text) > 0 Or txtamount_paid.Text.Trim <> "" Then

            If txtamount_paid.Text.Trim = "" Then
                txtamount_paid.Text = 0
            End If

            txtprnpaid.Text = prndue.ToString      ' PRINCIPAL DUE
            txtintdue.Text = intdue.ToString       ' INTEREST DUE
            txtsa_amount.Text = p_savings.ToString ' SAVINGS
            txtcf.Text = cf.ToString               ' CENTER FUND
            txtlife_health.Text = life_health      ' LH OR C19  
            txtadvprn.Text = advprn.ToString       ' ADVANCE PRINCIPAL
            txtadv_int.Text = advint.ToString      ' ADVANCE INTEREST

            ' AMOUNT NGA GI BAYAD MINUS SA TOTAL NA BAYRONON
            ' total_amntpaid     = 1,450.00 - TOTAL AMOUNT TO BE PAID
            ' txtamount_paid.Text= 1,000 - ACTUAL AMOUNT PAID
            ' EX: txtamount_paid.Tex = 1,000 - 1,450.00 = -450 (negative)
            '

            'MsgBox("txtamount_paid.Text " & txtamount_paid.Text)

            ' AMOUNT PAID IS LOWER VALUE THAN TOTAL PAYABLE WILL PRODUCT NEGATIVE AMOUNT PAID
            txtamount_paid.Text = Double.Parse(txtamount_paid.Text) - total_amntpaid

            'MsgBox("total_amntpaid " & total_amntpaid)
            'MsgBox("txtamount_paid.Text After" & txtamount_paid.Text)

            ' MAS GAMAY ANG GIBAYAD KAYSA TOTAL NGA BAYRONON ( negative txtamount_paid.text )
            ' NEGATIVE AMOUNT PAID VALUE
            If Double.Parse(txtamount_paid.Text) < 0 Then

                ' 1. SAVINGS AMOUNT TEXTBOX = SAVINGS AMOUNT + AMOUNT PAID
                ' 15 + - 100 = -85 ( savings amount is negative -85 )
                txtsa_amount.Text = Double.Parse(txtsa_amount.Text) + Double.Parse(txtamount_paid.Text)

                'MsgBox("i am here at the computation" & txtamount_paid.Text)

                ' SAVINGS AMOUNT
                If Double.Parse(txtsa_amount.Text) < 0 Then ' AMOUNT PAID KAY LESS THAN ZERO

                    ' CENTER FUND = NEGATIVE SAVINGS AMOUNT + CENTER FUND
                    ' CENTER FUND = -85 + 5 = -80
                    txtcf.Text = Double.Parse(txtsa_amount.Text) + Double.Parse(txtcf.Text)

                    ' KAY NAG NEGATIVE MAN ANG SAVINGS AMOUNT, MAKE IT ZERO
                    txtsa_amount.Text = 0

                End If

                ' CENTER FUND
                If Double.Parse(txtcf.Text) < 0 Then

                    ' NEGATIVE CENTER FUND AMOUNT
                    'txtlife_health.Text = Double.Parse(txtlife_health.Text) + Double.Parse(txtcf.Text)

                    txtprnpaid.Text = Double.Parse(txtprnpaid.Text) + Double.Parse(txtcf.Text)
                    txtcf.Text = 0
                End If

                ' PRINCIPAL PAID
                If Double.Parse(txtprnpaid.Text) < 0 Then
                    'txtintdue.Text = Double.Parse(txtintdue.Text) + Double.Parse(txtprnpaid.Text)

                    txtlife_health.Text = Double.Parse(txtlife_health.Text) + Double.Parse(txtprnpaid.Text)
                    txtprnpaid.Text = 0
                End If

                ' C19 OR LIFE & HEALTH
                If Double.Parse(txtlife_health.Text) < 0 Then
                    'txtprnpaid.Text = Double.Parse(txtprnpaid.Text) + Double.Parse(txtlife_health.Text)

                    txtintdue.Text = Double.Parse(txtintdue.Text) + Double.Parse(txtlife_health.Text)
                    txtlife_health.Text = 0
                End If

                ' INTEREST
                If Double.Parse(txtintdue.Text) < 0 Then
                    txtsa_amount.Text = (Double.Parse(txtintdue.Text) * -1) + Double.Parse(txtsa_amount.Text)
                    txtintdue.Text = 0
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

                ' OFF KAY PARA DILI E DIVIDE UG 2 ANG AMOUNT PAID
                'txtprnpaid.Text = amntpaid_div ' OFF KAY PARA DILI E DIVIDE UG 2 ANG AMOUNT PAID
                'txtintdue.Text = amntpaid_div  ' OFF KAY PARA DILI E DIVIDE UG 2 ANG AMOUNT PAID

                If Double.Parse(txtintdue.Text) > intdue Then
                    Dim intdiff As Double = Double.Parse(txtintdue.Text) - intdue
                    ' OFF KAY PARA DILI E DIVIDE UG 2
                    'txtintdue.Text = Double.Parse(txtintdue.Text) - intdiff ' OFF KAY PARA DILI E DIVIDE UG 2
                    'txtprnpaid.Text = Double.Parse(txtprnpaid.Text) + intdiff  ' OFF KAY PARA DILI E DIVIDE UG 2
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

    Private Sub compute_payment_orig() ' MODIFIED 10/12/2021
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

    Private Sub view_loansched()
        Try
            Dim table1 As DataTable = New DataTable()
            conn()
            sql = "SELECT a.LnNum,CONVERT(VARCHAR(10),a.duedate,101) As duedate,a.AmntRcvbl,"
            sql += "(a.rngprin+a.rngint) As rngamnt FROM Loansched a WHERE a.pnnumber='" + dtgrid_grpposting.CurrentRow.Cells(1).Value.ToString + "' ORDER BY a.LnNum ASC" 'and a.duedate>=(select max(collectiondate) from loancollect where pnnumber=a.pnnumber)
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
    End Sub

    Private Sub dtgrid_grpposting_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_grpposting.DoubleClick
        If multiproduct = "Y" Then
            chkprndue.Checked = True
        Else
            chksavings.Checked = True
        End If
        view_loansched()
        cbo_collections.Text = dtcoll.Value
        gen_amounts()
        'dtgrid_grpposting.Enabled = False
        pn_payment.Visible = True
        txtsss.Focus()
    End Sub

    Private Sub dtgrid_grpposting_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgrid_grpposting.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf dtgrid_grpposting_KeyPress
    End Sub

    Private Sub dtgrid_grpposting_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtgrid_grpposting.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            If dtgrid_grpposting.CurrentCell.ColumnIndex = 12 Then
                AllowOnlyNumeric(e)
            End If
        End If
    End Sub

    Public Sub AllowOnlyNumeric(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "")
    End Sub

    Private Sub dtgrid_grpposting_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgrid_grpposting.KeyUp
        If e.KeyCode = Keys.Enter Then
            If multiproduct = "Y" Then
                chkprndue.Checked = True
            Else
                chksavings.Checked = True
            End If
            view_loansched()
            cbo_collections.Text = dtcoll.Value
            gen_amounts()
            'dtgrid_grpposting.Enabled = False
            pn_payment.Visible = True
            txtsss.Focus()
        End If
    End Sub

    Private Sub dtgrid_grpposting_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_grpposting.SelectionChanged

    End Sub

    Private Sub dtgrid_grpposting_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_grpposting.Sorted
        Try
            For x As Integer = 0 To dtgrid_grpposting.Rows.Count
                dtgrid_grpposting.Rows(x).DefaultCellStyle.BackColor = Color.White
                If x Mod 2 Then
                    dtgrid_grpposting.Rows(x).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    ' THIS SUB BUTTON WILL GENERATE LIST OF AMOUNT PAYABLE PER MEMBER
    Private Sub bttngnerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngnerate.Click
        Try
            GL_loans = txtloantype.SelectedValue ' LOAN TYPE LIKE 1050-03 AS HAWAK KAMAY

            select_grptype()

            ' GET THE TOTAL AMOUNT PAID ( TOTAL AS GROUP )
            'MsgBox("cashamount()")


            cashamount()

            lblamntpost.Text = 0
            pn_load.Visible = True

            Control.CheckForIllegalCrossThreadCalls = False

            'MsgBox("AddressOf view_center_posting()")


            thread = New System.Threading.Thread(AddressOf view_center_posting)
            thread.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        Dim countemptyPR As Integer = 0
        For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
            If dtgrid_grpposting.Rows(i).Cells(16).Value = "" Then
                countemptyPR = countemptyPR + 1
            End If
        Next

        If txtcenter.Text.Trim = "" Then
            MsgBox("Center name cannot be empty!", MsgBoxStyle.Exclamation, "Invalid")
            txtcenter.Focus()
            'ElseIf Double.Parse(lbl_ttlamntpaid.Text) <> Double.Parse(lblamntpost.Text) Then
            '    MsgBox("Amount post must match the cashiers amount.", MsgBoxStyle.Exclamation, "Invalid Amount")
        ElseIf countemptyPR > 0 Then
            MsgBox(countemptyPR.ToString & " empty PR # found in field. PR # cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If Double.Parse(lbl_ttlamntpaid.Text) <> Double.Parse(lblamntpost.Text) Then
                If MessageBox.Show("Amount post is not equal to cashiers amount. Would you like to save this payments?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo a
                End If
            End If
            'dtgrid_grpposting.Enabled = False


            For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
                ttlint = ttlint + (Double.Parse(dtgrid_grpposting.Rows(i).Cells(8).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(9).Value))
                ttlprin = ttlprin + (Double.Parse(dtgrid_grpposting.Rows(i).Cells(6).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(7).Value))
                ttlPS = ttlPS + (Double.Parse(dtgrid_grpposting.Rows(i).Cells(11).Value))
                cf = cf + (Double.Parse(dtgrid_grpposting.Rows(i).Cells(12).Value))
            Next

            txtttlamountpaid.Text = lblamntpost.Text
            dtgrid_gl.Rows.Clear()
            dtgrid_gl.Rows.Add(GL_loans, 0, lblprn.Text)
            dtgrid_gl.Rows.Add(GL_income, 0, lblint.Text)
            dtgrid_gl.Rows.Add(GL_sa, 0, lblsa.Text)
            dtgrid_gl.Rows.Add(GL_cf, 0, lblcenterfund.Text)
            pn_ornumber.Visible = True
        End If
a:
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        If count_click = 1 Then
            If MessageBox.Show("Are you sure you want to cancel your inputed data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                dtgrid_grpposting.Rows.Clear()
                bttnsave.Enabled = False
                bttncancel.Enabled = False
            End If
        End If
    End Sub

    Private Sub insert_CF()
        conn()
        sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + lblcf.Text + "'"
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


        '--------------------on testing ---------------------
        'GET THE GL_SA CODE HERE - 07/12/2022
        ' GET THE accountmaster table GL_sa field
        conn()
        sql = "SELECT a.GL_sa, a.AccountNumber  FROM accountmaster a where a.accountnumber='" + lblcf.Text + "' "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            ' GL_sa = rd("GL_sa").ToString
            AccountMaster_GL_sa = rd("GL_sa").ToString
        End If
        rd.Close()
        myConn.Close()
        ' ------------------------------------------------

        conn()
        sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,RunBalance,Remarks,Refrence,userid,GL_sa,tdate,DRCR_acct) VALUES "
        sql += "('" + lblcf.Text + "'"
        sql += ",'" + txtdate.Value + "'"
        sql += "," + postnoCF.ToString + ""
        sql += ",'CSH-CL'"
        sql += "," + ttlcf.ToString + ",0"
        sql += ",0"
        sql += ",'CF Collections'"
        sql += ",'" + txtornumber.Text + "'"
        sql += ",'" + user.ToString + "'"
        'sql += ",'" + GL_sa + "'"
        sql += ",'" + AccountMaster_GL_sa + "'" 'added 7/12/2022 testing sa
        sql += ",'" + systemdate + "','" & txtcash.SelectedValue & "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub txtcenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcenter.SelectedIndexChanged
        'cashamount()
        conn()
        sql = "select accountnumber from center where ctrcode='" + txtcenter.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            lblcf.Text = rd("accountnumber").ToString
            cashamount()
        Else
            lblcf.Text = "000"
            lbl_ttlamntpaid.Text = 0
        End If
        rd.Close()
        myConn.Close()
    End Sub

    ' TOTAL CASH AMOUNT REMITTED TO CASHIER
    Private Sub cashamount()
        'Dim cCenterCode As String

        'MsgBox("CENTER CODE " & txtcenter.SelectedValue) ' CENTER CODE
        'MsgBox("GROUP TYPE " & grouptype) ' CENTER CODE
        'MsgBox("Private Sub cashamount()")

        conn()
        'MsgBox("cashamount()")

        If grouptype = "N" Then
            'MsgBox("grouptype = 'N' ")

            sql = "SELECT ISNULL(( SUM(b.debit) ),0) AS debit " & _
                  "FROM officer a, Cashierstransaction b " & _
                  "WHERE a.collcode='" + txtcenter.SelectedValue.ToString + "' AND b.trndate='" + txtdate.Value + "' AND a.collcode=b.Acctreference"

            'MsgBox(sql)

        Else
            'MsgBox("grouptype = 'Y' ")

            sql = "SELECT isnull((sum(b.debit)),0)as Debit FROM center a,CashiersTransaction b " & _
                  " WHERE a.ctrcode='" + txtcenter.SelectedValue + "'  AND b.trndate='" + txtdate.Value + "' AND a.ctrcode=b.AcctReference"
        End If


        cmd = New SqlCommand(sql, myConn)
        myConn.Open()

        ' GET THE TOTAL AMOUNT PAID OF GROUP POSTING
        rd = cmd.ExecuteReader()
        If rd.Read Then
            lbl_ttlamntpaid.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("Debit"))
        Else
            lbl_ttlamntpaid.Text = 0
        End If

        rd.Close()
        myConn.Close()
        'MsgBox("Exit Private Sub cashamount()")
    End Sub
    ' ORIGINAL cashamount class MODIFIED 10/12/2021, JUST IN ANY ERROR, RESTORE THIS CODE
    Private Sub cashamount_ORIG()
        conn()
        If grouptype = "N" Then
            sql = "SELECT isnull((sum(b.debit)),0)as Debit FROM officer a,Cashierstransaction b"
            sql += " WHERE a.collcode='" + txtcenter.SelectedValue.ToString + "' AND b.trndate='" + txtdate.Value + "' AND a.collcode=b.Acctreference"
        Else
            sql = "SELECT isnull((sum(b.debit)),0)as Debit FROM center a,CashiersTransaction b"
            sql += " WHERE a.ctrcode='" + txtcenter.SelectedValue + "'  AND b.trndate='" + txtdate.Value + "' AND a.ctrcode=b.AcctReference"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            lbl_ttlamntpaid.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("Debit"))
        Else
            lbl_ttlamntpaid.Text = 0
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttn_cont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cont.Click
        If txtornumber.Text.Trim = "" Then
            MsgBox("OR Number cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtornumber.Focus()
            'ElseIf Double.Parse(ttlcredit.Text) <> Double.Parse(txtprnpaid.Text) Then
            '    MsgBox("Debit amount is not equal to credit amount.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If MessageBox.Show("Click yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                SplashScreensave.count = 0
                Control.CheckForIllegalCrossThreadCalls = False
                thread = New System.Threading.Thread(AddressOf SplashScreensave.ShowDialog)
                thread.Start()
                conn()
                For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
                    If dtgrid_grpposting.Rows(i).Cells(15).Value > 0 Then
                        Dim prndue As Integer = Double.Parse(dtgrid_grpposting.Rows(i).Cells(4).Value)
                        sql = "INSERT INTO LoanCollect(memcode,payno,trnxdate,remarks,pnnumber,prndue,principal,intpaid,intdue,savings,CF,SSSCont,LH,penpaid,amtpaid,orcode,prnum,ornumber,userid,tdate,ttime,cancel,collectiondate,AdvPrincipal,AdvInterest) "
                        sql += "VALUES('" + dtgrid_grpposting.Rows(i).Cells(0).Value + "',"
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(20).Value).ToString + ","
                        sql += "'" + txtdate.Value + "',"
                        sql += "'CASH',"
                        sql += "'" + dtgrid_grpposting.Rows(i).Cells(1).Value + "',"
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(4).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(6).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(8).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(5).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(11).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(12).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(13).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(14).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(10).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(15).Value).ToString + ","
                        sql += "'" + dtgrid_grpposting.Rows(i).Cells(16).Value + "',"
                        sql += "'" + dtgrid_grpposting.Rows(i).Cells(16).Value + "',"
                        sql += "'" + txtornumber.Text + "',"
                        sql += "'" + user.ToString + "',"
                        sql += "'" + systemdate + "',"
                        sql += "'" + time.ToString + "',"
                        sql += "'N',"
                        sql += "'" + dtcoll.Value + "',"
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(7).Value).ToString + ","
                        sql += "" + Double.Parse(dtgrid_grpposting.Rows(i).Cells(9).Value).ToString + ""
                        sql += ")"
                        'MsgBox(sql.ToString)
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                Next

                MDIfrm.update_status()
                txtdate.Enabled = False
                dtgrid_gl.Rows.Clear()
                dtgrid_gl.Rows.Add(GL_loans, 0, lblprn.Text)
                dtgrid_gl.Rows.Add(GL_income, 0, lblint.Text)
                dtgrid_gl.Rows.Add(GL_sa, 0, lblsa.Text)
                dtgrid_gl.Rows.Add(GL_cf, 0, lblcenterfund.Text)
                dtgrid_gl.Rows.Add(txtcash.SelectedValue, Double.Parse(txtttlamountpaid.Text), 0)

                pn_ornumber.Visible = False
                view_center_posting()
                SplashScreensave.Close()
                'dtgrid_grpposting.Enabled = True
            End If
        End If
    End Sub


    Private Sub RadButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton4.Click
        pn_ornumber.Visible = False
        'dtgrid_grpposting.Enabled = True
    End Sub

    Private Sub txtamount_paid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount_paid.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtamount_paid.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtamount_paid.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtamount_paid.Text.Substring(dot + 1)
                If ch.Length > 1 Then
                    ' txtamount_paid.Clear()
                End If
                'e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            'If e.KeyChar = Chr(13) Then GetNextControl(txtamount_paid, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount_paid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount_paid.KeyUp
        Try
            If Not txtamount_paid.Text.Contains(".") And Double.Parse(txtamount_paid.Text) > 0 Then
                txtamount_paid.Text = Format(Val(Replace(txtamount_paid.Text, ",", "")), "#,###,###")
                txtamount_paid.Select(txtamount_paid.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
        If e.KeyCode = Keys.Enter Then
            compute_payment()
            apply_payment()
        End If
    End Sub

    Private Sub txtamount_paid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount_paid.Validated
        compute_payment()
    End Sub

    Private Sub bttnapply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnapply.Click
        apply_payment()
    End Sub

    Private Sub apply_payment()
        If Decimal.Parse(lblprnbal.Text) < 0 Or Decimal.Parse(lblintbal.Text) < 0 Then
            MsgBox("Amount paid is greater than the amount due.", MsgBoxStyle.Exclamation, "Over Payment")
            bttncancel.Focus()
        Else
            dtgrid_grpposting.CurrentRow.Cells(4).Value = prndue.ToString
            dtgrid_grpposting.CurrentRow.Cells(5).Value = intdue.ToString
            If Decimal.Parse(txtprnpaid.Text) < 0 Then
                dtgrid_grpposting.CurrentRow.Cells(6).Value = 0
            Else
                dtgrid_grpposting.CurrentRow.Cells(6).Value = Decimal.Parse(txtprnpaid.Text)
            End If
            Try
                dtgrid_grpposting.CurrentRow.Cells(7).Value = Decimal.Parse(txtadvprn.Text)
            Catch ex As Exception
                dtgrid_grpposting.CurrentRow.Cells(7).Value = 0
            End Try
            dtgrid_grpposting.CurrentRow.Cells(8).Value = Double.Parse(txtintdue.Text)
            dtgrid_grpposting.CurrentRow.Cells(9).Value = Double.Parse(txtadv_int.Text)
            dtgrid_grpposting.CurrentRow.Cells(10).Value = Double.Parse(txtpen_paid.Text)
            dtgrid_grpposting.CurrentRow.Cells(11).Value = Double.Parse(txtsa_amount.Text)
            dtgrid_grpposting.CurrentRow.Cells(12).Value = Double.Parse(txtcf.Text)
            Try
                dtgrid_grpposting.CurrentRow.Cells(13).Value = Double.Parse(txtsss.Text)
            Catch ex As Exception
                dtgrid_grpposting.CurrentRow.Cells(13).Value = 0
            End Try
            dtgrid_grpposting.CurrentRow.Cells(14).Value = Double.Parse(txtlife_health.Text)
            dtgrid_grpposting.CurrentRow.Cells(15).Value = Double.Parse(txtamount_paid.Text)
            pn_payment.Visible = False
            'dtgrid_grpposting.Enabled = True
            dtgrid_grpposting.Focus()

            amntpost = 0
            ttlcf = 0
            ttlPS = 0
            ttlprin = 0
            ttlint = 0
            For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
                amntpost = amntpost + Double.Parse(dtgrid_grpposting.Rows(i).Cells(15).Value) '(((Double.Parse(dtgrid_grpposting.Rows(i).Cells(6).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(7).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(8).Value)) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(9).Value)) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(10).Value)) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(11).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(12).Value + Double.Parse(dtgrid_grpposting.Rows(i).Cells(13).Value))
                ttlprin = ttlprin + (Double.Parse(dtgrid_grpposting.Rows(i).Cells(6).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(7).Value))
                ttlint = ttlint + (Double.Parse(dtgrid_grpposting.Rows(i).Cells(8).Value) + Double.Parse(dtgrid_grpposting.Rows(i).Cells(9).Value))
                ttlcf = ttlcf + Double.Parse(dtgrid_grpposting.Rows(i).Cells(12).Value)
                ttlPS = ttlPS + Double.Parse(dtgrid_grpposting.Rows(i).Cells(11).Value)
            Next
            lblprn.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlprin)
            lblint.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlint)
            lblsa.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlPS)
            lblcenterfund.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ttlcf)
            lblamntpost.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", amntpost)
            'If Not productcode = "IL" Then
            '    If dtgrid_grpposting.CurrentRow.Cells(14).Value <> "" Then
            '        For i As Integer = 0 To dtgrid_grpposting.Rows.Count - 1
            '            If dtgrid_grpposting.Rows(i).Cells(3).Value = dtgrid_grpposting.CurrentRow.Cells(3).Value Then
            '                dtgrid_grpposting.Rows(i).Cells(14).Value = dtgrid_grpposting.CurrentRow.Cells(14).Value
            '            End If
            '        Next
            '    End If
            'End If
        End If
    End Sub

    Private Sub chksavings_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksavings.CheckedChanged
        If chksavings.Checked = False Then
            chkprndue.Checked = True
        Else
            chkprndue.Checked = False
        End If
        compute_payment()
    End Sub

    Private Sub chkprndue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkprndue.CheckedChanged
        If chkprndue.Checked = True Then
            chksavings.Checked = False
        Else
            chksavings.Checked = True
        End If
        compute_payment()
    End Sub

    Private Sub cbo_collections_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_collections.Validated
        gen_amounts()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        pn_payment.Visible = False
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        If grouptype = "Y" Then
            lbloption.Text = "Center :"
            select_center()
        Else
            lbloption.Text = "Product Assistant :"
            select_coll()
        End If
    End Sub

    Private Sub txtsss_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsss.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtsss.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtsss.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtsss.Text.Substring(dot + 1)
                If ch.Length > 1 Then
                    ' txtamount_paid.Clear()
                End If
                'e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            'If e.KeyChar = Chr(13) Then GetNextControl(txtamount_paid, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsss_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsss.KeyUp
        Try
            If Not txtamount_paid.Text.Contains(".") And Double.Parse(txtsss.Text) > 0 Then
                txtsss.Text = Format(Val(Replace(txtsss.Text, ",", "")), "#,###,###")
                txtsss.Select(txtsss.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try

        If e.KeyCode = Keys.Enter Then
            txtamount_paid.Focus()
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        pn_backdate.Visible = False
    End Sub

    Private Sub bttncont1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont1.Click
        Try
            'mysqlconn()
            'sql = "select * from access_temp where accesspass='" + txtpassword_rec.Text + "' and userid='" + user + "' and status='A'"
            'mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            'mysqlmyconn.Open()
            'mysqlrd = mysqlcmd.ExecuteReader
            'If mysqlrd.Read Then
            If txtpassword_rec.Text = adminpass Then
                txtdate.Enabled = True
                pn_backdate.Visible = False
            Else
                MessageBox.Show("Invalid password")
            End If
            'Else
            'MsgBox("Invalid access of user ID.", MsgBoxStyle.Exclamation, "Invalid User")
            'End If
            'mysqlrd.Close()
            'mysqlmyconn.Close()

            'update_accesstemp()
        Catch ex As Exception
            'MsgBox("Cannot connect to MySql Host.", MsgBoxStyle.Exclamation, "Failed to connect")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pn_backdate.Visible = True
    End Sub

    Private Sub txtloantype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloantype.SelectedIndexChanged

    End Sub
End Class