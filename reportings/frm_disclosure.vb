Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_disclosure

    Private Sub frm_disclosure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SplashScreen.count = 0
        'Control.CheckForIllegalCrossThreadCalls = False
        'thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        'thread.Start()
        'GL_loans = frm_loanProcess_indv.txtloantype.SelectedValue
        'select_grptype()
        If grouptype = "Y" Then
            'HAWAK KAMAY
            disclosureHL()
        Else
            If isPension = "Y" Then
                'PENSION LOAN
                disclosurePL()
            ElseIf isP3 = "Y" Then
                'P3 LOAN
                disclosureP3()
            Else
                'INDIVIDUAL LOAN
                disclosureIL()
            End If
        End If
        'SplashScreen.Close()
    End Sub

    Private Sub disclosureHL()

        'MsgBox(frm_loanProcess_grp.cboweeks.Text)

        'REPORT OBJECT
        Dim MyRpt As New disclosureHL

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")

        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str16", Type.GetType("System.String"))   '0
            .Add("int8", Type.GetType("System.Double"))    '1
            .Add("str12", Type.GetType("System.String"))   '2
            .Add("str13", Type.GetType("System.String"))   '3 Approved By:
            .Add("str14", Type.GetType("System.String"))   '4
            .Add("int1", Type.GetType("System.Double"))    '5
            .Add("date1", Type.GetType("System.DateTime")) '3
            .Add("date2", Type.GetType("System.DateTime")) '4
            .Add("str1", Type.GetType("System.String"))    '14
            .Add("str2", Type.GetType("System.String"))    '15
            .Add("str3", Type.GetType("System.String"))    '15
            .Add("str4", Type.GetType("System.String"))    '0
            .Add("str5", Type.GetType("System.String"))    '1
            .Add("int3", Type.GetType("System.Double"))    '1
            .Add("str9", Type.GetType("System.String"))    '1
            .Add("str10", Type.GetType("System.String"))   '1
            .Add("str7", Type.GetType("System.String"))    '15
            .Add("str11", Type.GetType("System.String"))   '15
            .Add("int2", Type.GetType("System.Double"))    '2
            .Add("str8", Type.GetType("System.String"))    '15
            .Add("str15", Type.GetType("System.String"))   '15
            .Add("str6", Type.GetType("System.String"))    '15
        End With

        Dim isdeduction As Boolean = False

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "SELECT pnnumber FROM LoansDeduction WHERE  pnnumber='" + loannumber + "' "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            isdeduction = True
        Else
            isdeduction = False
        End If
        rd.Close()
        myConn.Close()


        If isdeduction = True Then
            conn()
            ' ORGINAL
            'sql = "SELECT a.*,d.fullname,d.address,c.ModeofPayment,c.LoanAmnt,c.grpcode,c.ctrcode,c.Releasedate,c.Maturitydate,c.intrate,c.accountnumber FROM LoansDeduction a, deductionMF b, loans c, members d WHERE c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber"
            ' NEW 5/4/2022
            sql = "SELECT a.*,d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.LoanAmnt,c.grpcode,c.ctrcode,c.Releasedate,c.Maturitydate,c.intrate,c.accountnumber, c.LOANTYPE, e.LOANDESC FROM LoansDeduction a, deductionMF b, loans c, members d, LOANTYPE e WHERE c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber AND c.LOANTYPE = e.LOANCODE"
            'NOTE: ADDED  c.LOANTYPE, e.LOANDESC to queary and filter ( c.LOANTYPE = e.LOANCODE )
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                row = DS.Tables(0).NewRow
                row(0) = rd("Description").ToString
                row(1) = rd("Amount").ToString
                row(2) = usersname.ToString

                'change to blank name (04/12/2023)
                'row(3) = AreaSupervisor.ToString    'Approved By: Area Supervisor
                'change now to blank
                row(3) = ""                          'Approved By: Area Supervisor

                'change from cashier to bookeeper (04/12/2023)
                'row(4) = cashier.ToString           'Checked By: Cashier
                row(4) = bookkeeper.ToString           'Checked By: BookKeeper


                row(5) = rd("LoanAmnt")
                row(6) = rd("Releasedate")
                row(7) = rd("Maturitydate")
                row(8) = rd("pnnumber")
                row(9) = rd("fullname")
                row(10) = rd("address")
                row(11) = rd("LOANDESC") ' loan type
                row(12) = rd("ctrcode")
                row(13) = rd("grpcode")
                row(14) = compaddress.ToString
                row(15) = CompName.ToString
                row(16) = rd("ModeofPayment")
                row(17) = user.ToString
                row(18) = rd("intrate")
                '  row(19) =  AmountInWords(rd("LoanAmnt"))
                row(19) = AmountInWords(rd("LoanAmnt"))
                row(20) = "%"
                row(21) = rd("accountnumber")
                DS.Tables(0).Rows.Add(row)
                'row(11) = frm_newloanlist.txtloantype.Text
            End While
            rd.Close()
            myConn.Close()
        Else
            conn()
            ' ORIGINAL
            ' sql = "SELECT d.fullname,d.address,c.ModeofPayment,c.pnnumber,c.LoanAmnt,c.grpcode,c.ctrcode,c.Releasedate,c.Maturitydate,c.intrate,c.accountnumber FROM loans c, members d WHERE c.memcode=d.memcode and c.pnnumber='" + loannumber + "'"

            ' NEW 5/4/2022
            sql = "SELECT d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.pnnumber,c.LoanAmnt,c.grpcode,c.ctrcode,c.Releasedate,c.Maturitydate,c.intrate,c.accountnumber, c.LOANTYPE, e.LOANDESC FROM loans c, members d, LOANTYPE e WHERE c.LOANTYPE = e.LOANCODE AND c.memcode=d.memcode and c.pnnumber='" + loannumber + "'"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                row = DS.Tables(0).NewRow
                row(0) = "---"
                row(1) = 0
                row(2) = usersname.ToString
                row(3) = AreaSupervisor.ToString
                row(4) = cashier.ToString
                row(5) = rd("LoanAmnt")
                row(6) = rd("Releasedate")
                row(7) = rd("Maturitydate")
                row(8) = rd("pnnumber")
                row(9) = rd("fullname")
                row(10) = rd("address")
                'row(11) = frm_newloanlist.txtloantype.Text
                row(11) = rd("LOANDESC") ' loan type
                row(12) = rd("ctrcode")
                row(13) = rd("grpcode")
                row(14) = compaddress.ToString
                row(15) = CompName.ToString
                row(16) = rd("ModeofPayment")
                row(17) = user.ToString
                row(18) = rd("intrate")
                '  row(19) =  AmountInWords(rd("LoanAmnt"))
                row(19) = AmountInWords(rd("LoanAmnt"))
                row(20) = "%"
                row(21) = rd("accountnumber")
                DS.Tables(0).Rows.Add(row)
            End While
            rd.Close()
            myConn.Close()
        End If

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub disclosureIL()
        conn()
        ' ORIGINAL
        ' sql = "SELECT a.*,d.fullname,d.address,c.ModeofPayment,c.LoanAmnt,c.Releasedate,c.Maturitydate,c.intrate FROM LoansDeduction a, deductionMF b, loans c,  members d WHERE c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber"

        ' UPDATED 5/4/2022
        sql = "SELECT a.*,d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.LoanAmnt,c.Releasedate,c.Maturitydate,c.intrate, c.LOANTYPE, e.LOANDESC, e.rate FROM LoansDeduction a, deductionMF b, loans c,  members d, LOANTYPE e WHERE c.LOANTYPE = e.LOANCODE AND c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber"



        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            'REPORT OBJECT
            Dim MyRpt As New disclosureIL

            'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
            Dim row As DataRow = Nothing
            Dim DS As New DataSet

            'ADD A TABLE TO THE DATASET
            DS.Tables.Add("dummy")
            'ADD THE COLUMNS TO THE TABLE
            With DS.Tables(0).Columns
                .Add("str15", Type.GetType("System.String"))   '0
                .Add("str16", Type.GetType("System.String"))   '1
                .Add("int8", Type.GetType("System.Double"))    '2
                .Add("str12", Type.GetType("System.String"))   '3
                .Add("str13", Type.GetType("System.String"))   '4 'Checked by: Bookkeeper
                .Add("str14", Type.GetType("System.String"))   '5 'Approved by: Blank
                .Add("int1", Type.GetType("System.Double"))    '6
                .Add("date1", Type.GetType("System.DateTime")) '7
                .Add("date2", Type.GetType("System.DateTime")) '8
                .Add("str1", Type.GetType("System.String"))    '9
                .Add("str2", Type.GetType("System.String"))    '10
                .Add("str3", Type.GetType("System.String"))    '11
                .Add("str4", Type.GetType("System.String"))    '12

                '.Add("str5", Type.GetType("System.String"))   '13
                '.Add("str6", Type.GetType("System.String"))   '14

                .Add("str9", Type.GetType("System.String"))    '13
                .Add("str10", Type.GetType("System.String"))   '14
                .Add("str7", Type.GetType("System.String"))    '15
                .Add("str11", Type.GetType("System.String"))   '16
                .Add("int2", Type.GetType("System.Double"))    '17 - interest rate
                .Add("str5", Type.GetType("System.String"))    '18
                .Add("str6", Type.GetType("System.String"))    '19 - percent (%) sign
                .Add("str8", Type.GetType("System.String"))    '20
            End With

            'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
            conn()
            sql = "SELECT a.*,d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.LoanAmnt,c.Releasedate,c.Maturitydate,c.intrate,c.accountnumber, c.LOANTYPE, e.LOANDESC, e.rate FROM LoansDeduction a, deductionMF b, loans c, members d, LOANTYPE e WHERE c.LOANTYPE = e.LOANCODE AND c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                row = DS.Tables(0).NewRow
                row(0) = rd("code").ToString
                row(1) = rd("Description").ToString
                row(2) = rd("Amount").ToString
                row(3) = usersname.ToString

                'change area supervisor to bookkeeper (04/12/2023)
                'row(4) = AreaSupervisor.ToString '
                row(4) = bookkeeper.ToString '

                'row(5) = cashier.ToString
                row(5) = "" 'cashier.ToString

                row(6) = rd("LoanAmnt")
                row(7) = rd("Releasedate")
                row(8) = rd("Maturitydate")
                row(9) = rd("pnnumber")
                row(10) = rd("fullname")
                row(11) = rd("address")
                'row(12) = frm_newloanlist.txtloantype.Text
                row(12) = rd("LOANDESC")
                row(13) = compaddress.ToString
                row(14) = CompName.ToString
                row(15) = rd("ModeofPayment")
                row(16) = user.ToString
                'row(17) = rd("intrate") 'old rate data
                row(17) = rd("rate")
                row(18) = AmountInWords(frm_loanProcess_indv.txtlnamnt.Text)
                row(19) = " %"
                row(20) = rd("accountnumber")
                DS.Tables(0).Rows.Add(row)
            End While
            rd.Close()
            myConn.Close()

            'SET THE REPORT SOURCE TO THE DATABASE
            MyRpt.SetDataSource(DS)

            'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
            CRviewer.ReportSource = MyRpt

            'DISPOSE OF THE DATASET
            DS.Dispose()
            DS = Nothing
        Else
            'REPORT OBJECT
            Dim MyRpt As New disclosureIL_empty

            'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
            Dim row As DataRow = Nothing
            Dim DS As New DataSet

            'ADD A TABLE TO THE DATASET
            DS.Tables.Add("dummy")
            'ADD THE COLUMNS TO THE TABLE
            With DS.Tables(0).Columns
                .Add("str12", Type.GetType("System.String")) '0
                .Add("str13", Type.GetType("System.String")) '1
                .Add("str14", Type.GetType("System.String")) '2
                .Add("int1", Type.GetType("System.Double")) '3
                .Add("date1", Type.GetType("System.DateTime")) '4
                .Add("date2", Type.GetType("System.DateTime")) '5
                .Add("str1", Type.GetType("System.String")) '6
                .Add("str2", Type.GetType("System.String")) '7
                .Add("str3", Type.GetType("System.String")) '8
                .Add("str4", Type.GetType("System.String")) '9
                .Add("str9", Type.GetType("System.String")) '10
                .Add("str10", Type.GetType("System.String")) '11
                .Add("str7", Type.GetType("System.String")) '12
                .Add("str11", Type.GetType("System.String")) '13
                .Add("int2", Type.GetType("System.Double")) '14
                .Add("str5", Type.GetType("System.String")) '15
                .Add("str6", Type.GetType("System.String")) '16
                .Add("str15", Type.GetType("System.String")) '16
            End With

            'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
            conn()
            sql = "SELECT d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.pnnumber,c.Purpose,c.LoanAmnt,c.Releasedate,c.Maturitydate,c.intrate, c.LOANTYPE, e.LOANDESC, e.rate FROM  loans c ,members d, LOANTYPE e WHERE c.LOANTYPE = e.LOANCODE AND c.memcode=d.memcode and c.pnnumber='" + loannumber + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                row = DS.Tables(0).NewRow
                row(0) = usersname.ToString
                row(1) = AreaSupervisor.ToString
                row(2) = cashier.ToString
                row(3) = rd("LoanAmnt")
                row(4) = rd("Releasedate")
                row(5) = rd("Maturitydate")
                row(6) = rd("pnnumber")
                row(7) = rd("fullname")
                row(8) = rd("address")
                'row(9) = frm_newloanlist.txtloantype.Text
                row(9) = rd("LOANDESC")
                row(10) = compaddress.ToString
                row(11) = CompName.ToString
                row(12) = rd("ModeofPayment")
                row(13) = user.ToString
                'row(14) = rd("intrate")
                row(14) = rd("rate")
                row(15) = AmountInWords(frm_loanProcess_indv.txtlnamnt.Text)
                row(16) = " %"
                row(17) = rd("Purpose")
                DS.Tables(0).Rows.Add(row)
            End While
            rd.Close()
            myConn.Close()

            'SET THE REPORT SOURCE TO THE DATABASE
            MyRpt.SetDataSource(DS)

            'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
            CRviewer.ReportSource = MyRpt

            'DISPOSE OF THE DATASET
            DS.Dispose()
            DS = Nothing
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub disclosureP3()
        'REPORT OBJECT
        Dim MyRpt As New disclosureP3

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str15", Type.GetType("System.String"))    '0
            .Add("str16", Type.GetType("System.String"))    '1
            .Add("int8", Type.GetType("System.Double"))     '2
            .Add("str12", Type.GetType("System.String"))    '3
            .Add("str13", Type.GetType("System.String"))    '4
            .Add("str14", Type.GetType("System.String"))    '5
            .Add("int1", Type.GetType("System.Double"))     '6
            .Add("date1", Type.GetType("System.DateTime"))  '7
            .Add("date2", Type.GetType("System.DateTime"))  '8
            .Add("str1", Type.GetType("System.String"))     '9
            .Add("str2", Type.GetType("System.String"))     '10
            .Add("str3", Type.GetType("System.String"))     '11
            .Add("str4", Type.GetType("System.String"))     '12
            '.Add("str5", Type.GetType("System.String")) '1
            '.Add("str6", Type.GetType("System.String")) '1
            .Add("str9", Type.GetType("System.String"))     '13
            .Add("str10", Type.GetType("System.String"))    '14
            .Add("str7", Type.GetType("System.String"))     '15
            .Add("str11", Type.GetType("System.String"))    '16
            .Add("int2", Type.GetType("System.Double"))     '17
            .Add("str5", Type.GetType("System.String"))     '18
            .Add("str6", Type.GetType("System.String"))     '19
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "SELECT a.*,d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.LoanAmnt,c.Releasedate,c.Maturitydate,c.intrate, c.LOANTYPE, e.LOANDESC, e.rate FROM LoansDeduction a, deductionMF b, loans c,  members d, LOANTYPE e WHERE c.LOANTYPE = e.LOANCODE AND c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("code").ToString
            row(1) = rd("Description").ToString
            row(2) = rd("Amount").ToString
            row(3) = usersname.ToString
            'change area supervisor to bookkeeper
            'row(4) = AreaSupervisor.ToString
            row(4) = bookkeeper.ToString() 'checked by

            'chnage to blank for the approved by (04/12/2023)
            'row(5) = cashier.ToString 'approved by
            'change to blank
            row(5) = "" 'approved by

            row(6) = rd("LoanAmnt")
            row(7) = rd("Releasedate")
            row(8) = rd("Maturitydate")
            row(9) = rd("pnnumber")
            row(10) = rd("fullname")
            row(11) = rd("address")
            'row(12) = frm_newloanlist.txtloantype.Text
            row(12) = rd("LOANDESC")
            row(13) = compaddress.ToString
            row(14) = CompName.ToString
            '"Coolway Multipurpose Cooperative"
            row(15) = rd("ModeofPayment")
            row(16) = user.ToString
            'row(17) = rd("intrate")
            row(17) = rd("rate")
            row(18) = AmountInWords(frm_loanProcess_indv.txtlnamnt.Text)
            row(19) = " %"
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub disclosurePL()
        'REPORT OBJECT
        Dim MyRpt As New disclosurePL

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns                          'row #
            .Add("str15", Type.GetType("System.String"))   '0
            .Add("str16", Type.GetType("System.String"))   '1
            .Add("int8", Type.GetType("System.Double"))    '2
            .Add("str12", Type.GetType("System.String"))   '3
            .Add("str13", Type.GetType("System.String"))   '4
            .Add("str14", Type.GetType("System.String"))   '5
            .Add("int1", Type.GetType("System.Double"))    '6
            .Add("date1", Type.GetType("System.DateTime")) '7
            .Add("date2", Type.GetType("System.DateTime")) '8
            .Add("str1", Type.GetType("System.String"))    '9
            .Add("str2", Type.GetType("System.String"))    '10
            .Add("str3", Type.GetType("System.String"))    '11
            .Add("str4", Type.GetType("System.String"))    '12
            '.Add("str5", Type.GetType("System.String")) '1
            '.Add("str6", Type.GetType("System.String")) '1
            .Add("str9", Type.GetType("System.String"))    '13
            .Add("str10", Type.GetType("System.String"))   '14
            .Add("str7", Type.GetType("System.String"))    '15
            .Add("str11", Type.GetType("System.String"))   '16
            .Add("int2", Type.GetType("System.Double"))    '17
            .Add("str5", Type.GetType("System.String"))    '18
            .Add("strpercent", Type.GetType("System.String"))    '19
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "SELECT a.*,d.fullname,d.address,ltrim(str(c.Payno) ) + ' ' + c.ModeofPayment AS ModeofPayment,c.LoanAmnt,c.Releasedate,c.Maturitydate,c.intrate, c.LOANTYPE, e.LOANDESC FROM LoansDeduction a, deductionMF b, loans c,  members d, LOANTYPE e WHERE c.LOANTYPE = e.LOANCODE AND c.memcode=d.memcode and a.code=b.code and b.display='Y' and a.pnnumber='" + loannumber + "' and a.pnnumber=c.pnnumber"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("code").ToString
            row(1) = rd("Description").ToString
            row(2) = rd("Amount").ToString
            row(3) = usersname.ToString
            row(4) = AreaSupervisor.ToString
            row(5) = cashier.ToString
            row(6) = rd("LoanAmnt")
            row(7) = rd("Releasedate")
            row(8) = rd("Maturitydate")
            row(9) = rd("pnnumber")
            row(10) = rd("fullname")
            row(11) = rd("address")
            row(12) = frm_newloanlist.txtloantype.Text
            row(13) = compaddress.ToString
            row(14) = CompName.ToString
            row(15) = rd("ModeofPayment")
            row(16) = user.ToString
            row(17) = rd("intrate")
            row(18) = AmountInWords(frm_loanProcess_indv.txtlnamnt.Text)
            row(19) = " %"
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub Item_disc()
        'REPORT OBJECT
        Dim MyRpt As New disclosureCL

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str15", Type.GetType("System.String")) '0
            .Add("str16", Type.GetType("System.String")) '1
            .Add("int8", Type.GetType("System.Double")) '2
            .Add("str12", Type.GetType("System.String")) '13
            .Add("str13", Type.GetType("System.String")) '14
            .Add("str14", Type.GetType("System.String")) '15
            .Add("int1", Type.GetType("System.Double")) '2
            .Add("date1", Type.GetType("System.DateTime")) '3
            .Add("date2", Type.GetType("System.DateTime")) '4
            .Add("str1", Type.GetType("System.String")) '14
            .Add("str2", Type.GetType("System.String")) '15
            .Add("str3", Type.GetType("System.String")) '15
            .Add("str4", Type.GetType("System.String")) '0
            .Add("str5", Type.GetType("System.String")) '1
            .Add("str6", Type.GetType("System.String")) '1
            .Add("str9", Type.GetType("System.String")) '1
            .Add("str10", Type.GetType("System.String")) '1
            '.Add("date1", Type.GetType("System.DateTime")) '3
            '.Add("date2", Type.GetType("System.DateTime")) '4
            '.Add("int4", Type.GetType("System.Double")) '5
            '.Add("int5", Type.GetType("System.Double")) '6
            '.Add("date3", Type.GetType("System.DateTime")) '7
            '.Add("date4", Type.GetType("System.DateTime")) '8
            '.Add("int2", Type.GetType("System.Double")) '9
            '.Add("int3", Type.GetType("System.Double")) '10
            '.Add("str3", Type.GetType("System.String")) '11
            '.Add("str4", Type.GetType("System.String")) '12
            '.Add("str5", Type.GetType("System.String")) '13
            '.Add("str10", Type.GetType("System.String")) '14
            .Add("str7", Type.GetType("System.String")) '15
            .Add("str11", Type.GetType("System.String")) '15
            .Add("int2", Type.GetType("System.Double")) '9
            .Add("int4", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        sql = "SELECT a.pnnumber,a.itemcode,a.qty,a.Itemprice,a.markup,b.itemdesc FROM LoanItems a, ItemsMF b where a.Itemcode=b.categorycode and a.pnnumber='" + loannumber + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("itemcode").ToString
            row(1) = rd("itemdesc").ToString
            row(2) = Double.Parse(rd("qty")) * Double.Parse(rd("Itemprice"))
            row(3) = usersname.ToString
            row(4) = AreaSupervisor.ToString
            row(5) = AreaManager.ToString
            row(6) = frm_loanProcess_grp.txtlnamnt.Text
            row(7) = frm_loanProcess_grp.dtrel.Value
            row(8) = frm_loanProcess_grp.lblmatdate.Text
            row(9) = frm_loanProcess_grp.txtlno.Text
            row(10) = frm_loanProcess_grp.txtmember.Text
            row(11) = frm_loanProcess_grp.address.ToString
            row(12) = frm_loanProcess_grp.txtloantype.Text
            row(13) = frm_loanProcess_grp.txtctr.SelectedValue.ToString
            row(14) = frm_loanProcess_grp.cbogrpcode.Text
            row(15) = compaddress.ToString
            row(16) = CompName.ToString
            row(17) = frm_loanProcess_grp.cboterms.Text
            row(18) = user.ToString
            row(19) = rd("Itemprice").ToString
            row(20) = 0 'frm_loanProcess.ttlmarkup.ToString
            'row(6) = frm_newloan_HL.txtschdinterestperann.Text
            'row(7) = frm_newloan_HL.dtschedoffirst.Text
            'row(8) = frm_newloan_HL.lblmatdate.Text
            'row(9) = frm_newloan_HL.txtdays.Text
            'row(10) = frm_newloan_HL.txtlnamnt.Text
            'row(11) = (Double.Parse(frm_newloan_HL.txtlnamnt.Text) / Double.Parse(frm_newloan_HL.payable)) * Double.Parse(frm_newloan_HL.penaltyrate)
            'row(12) = frm_newloan_HL.txtlno.Text
            'row(13) = frm_newloan_HL.txtcomaker.Text
            'row(14) = CompName.ToString
            'row(15) = compaddress.ToString
            'row(16) = frm_newloan_HL.penaltyrate

            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub
End Class