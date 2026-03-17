Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_cb_reports

    Private Sub frm_cb_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If usertype = "Bookkeeper" Then
            dtgen.Enabled = True
            dtreceipts.Enabled = True
            dtsummtrn.Enabled = True
            dtdisburse.Enabled = True

            dtgen.Value = systemdate
            dtreceipts.Value = systemdate
            dtsummtrn.Value = systemdate
            dtdisburse.Value = systemdate
        Else
            dtgen.Value = frm_cashiering.dtden.Value
            dtreceipts.Value = frm_cashiering.dtden.Value
            dtsummtrn.Value = frm_cashiering.dtden.Value
            dtdisburse.Value = frm_cashiering.dtden.Value
        End If
    End Sub

    Private Sub generate_cbsum()
        conn()
        sql = "SELECT * FROM sysparmtr"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            bookkeeper = rd("Bookkeeper").ToString
        End If
        rd.Close()
        myConn.Close()

        'Try
        'REPORT OBJECT
        Dim MyRpt As New cashiersblotter

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("int8", Type.GetType("System.Double"))
            .Add("int9", Type.GetType("System.Double"))
            .Add("int10", Type.GetType("System.Double"))
            .Add("int11", Type.GetType("System.Double"))
            .Add("int12", Type.GetType("System.Double"))
            .Add("int13", Type.GetType("System.Double"))
            .Add("int15", Type.GetType("System.Double"))
            .Add("int16", Type.GetType("System.Double"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int14", Type.GetType("System.Double"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("str15", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "SELECT x.* FROM(select a.*,"
        If chktemp.Checked = True Then
            sql += "begbal=isnull((select sum(debit-credit)from CashiersTransaction where trndate >='7/3/2019' and trndate < a.den_date),0),"
        Else
            sql += "begbal=isnull((select sum(debit-credit)from CashiersTransaction where trndate < a.den_date),0),"
        End If
        sql += "ttlreceipts=isnull((select sum(debit)from CashiersTransaction where trndate = a.den_date),0),"
        sql += "ttldisburse=isnull((select sum(credit)from CashiersTransaction where trndate = a.den_date),0)"
        sql += " from denomination a where den_date='" + dtgen.Value + "')x"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtgen.Value
            row(3) = productcode.ToString
            row(4) = rd("begbal").ToString
            row(5) = rd("ttlreceipts").ToString
            row(6) = rd("ttldisburse").ToString
            row(7) = rd("onethousand").ToString
            row(8) = rd("fivehundred").ToString
            row(9) = rd("twohundred").ToString
            row(10) = rd("onehundred").ToString
            row(11) = rd("fifty").ToString
            row(12) = rd("twenty").ToString
            row(13) = rd("ten").ToString
            row(14) = rd("five").ToString
            row(15) = rd("peso").ToString
            row(16) = rd("centavo").ToString
            row(17) = rd("tencent").ToString
            row(18) = rd("fivecent").ToString
            row(19) = usersname.ToString
            row(20) = bookkeeper.ToString
            row(21) = rd("coci").ToString
            row(22) = systemdate
            Try
                row(23) = DateTime.Parse(rd("ttime")).ToString("hh:mm tt")
            Catch ex As Exception
                row(23) = DateTime.Parse("00:00").ToString("hh:mm tt")
            End Try
            DS.Tables(0).Rows.Add(row)
        End While
        'Next
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
        'Catch ex As Exception
        '    MsgBox("Data is out of range.", MsgBoxStyle.Exclamation)
        'End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'frmcheckby.ShowDialog()
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        generate_cbsum()
        SplashScreen.Close()
    End Sub

    Private Sub generate_cbdetails()
        'REPORT OBJECT
        Dim MyRpt As New cashreceipts

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str15", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "SELECT a.*,b.acct_description FROM CashiersTransaction a, ChartAccounts b WHERE a.GLaccount=b.accountcode AND a.trndate='" + dtreceipts.Value + "' and a.debit >0 ORDER BY a.reference ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtreceipts.Value
            row(3) = productcode.ToString
            row(4) = rd("reference").ToString
            row(5) = rd("payee").ToString
            row(6) = rd("debit").ToString
            row(7) = rd("acct_description").ToString
            row(8) = rd("remarks").ToString
            row(9) = DateTime.Parse(rd("ttime")).ToString("hh:mm tt")
            DS.Tables(0).Rows.Add(row)
        End While
        'Next
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crvdetailsreceipts.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        generate_cbdetails()
        SplashScreen.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        'REPORT OBJECT
        Dim MyRpt As New cashdisburse

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str15", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "SELECT a.*,b.acct_description FROM CashiersTransaction a, ChartAccounts b WHERE a.GLaccount=b.accountcode AND a.trndate='" + dtdisburse.Value + "' and a.credit >0 ORDER BY a.reference ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtdisburse.Value
            row(3) = productcode.ToString
            row(4) = rd("reference").ToString
            row(5) = rd("payee").ToString
            row(6) = rd("credit").ToString
            row(7) = rd("acct_description").ToString
            row(8) = rd("remarks").ToString
            row(9) = DateTime.Parse(rd("ttime")).ToString("hh:mm tt")
            DS.Tables(0).Rows.Add(row)
        End While
        'Next
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crvdetailsdesburse.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
        SplashScreen.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        'REPORT OBJECT
        Dim MyRpt As New cashier_summary_of_trn

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("date2", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select sum(a.debit) as debit,sum(a.credit) as credit,b.accountcode,b.acct_description from CashiersTransaction a, ChartAccounts b where a.trndate='" + dtsummtrn.Value + "' and a.GLaccount=b.accountcode group by b.accountcode,b.acct_description"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtsummtrn.Value
            row(3) = productcode.ToString
            row(4) = rd("accountcode").ToString
            row(5) = rd("acct_description").ToString
            row(6) = rd("Debit").ToString
            row(7) = rd("Credit").ToString
            row(8) = systemdate
            DS.Tables(0).Rows.Add(row)
        End While
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crvsumm_of_trn.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
        SplashScreen.Close()
    End Sub

    'Private Sub bttngl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SplashScreen.count = 0
    '    Control.CheckForIllegalCrossThreadCalls = False
    '    thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
    '    'REPORT OBJECT
    '    Dim MyRpt As New generalledger

    '    'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
    '    Dim row As DataRow = Nothing
    '    Dim DS As New DataSet

    '    'ADD A TABLE TO THE DATASET
    '    DS.Tables.Add("dummy")
    '    'ADD THE COLUMNS TO THE TABLE
    '    With DS.Tables(0).Columns
    '        .Add("str13", Type.GetType("System.String"))
    '        .Add("str12", Type.GetType("System.String"))
    '        .Add("date1", Type.GetType("System.DateTime"))
    '        .Add("str16", Type.GetType("System.String"))
    '        .Add("str1", Type.GetType("System.String"))
    '        .Add("str2", Type.GetType("System.String"))
    '        .Add("int1", Type.GetType("System.Double"))
    '        .Add("int2", Type.GetType("System.Double"))
    '    End With

    '    'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
    '    'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
    '    Call conn()
    '    sql = "select * from ("
    '    sql += "select x.*,(x.cashreceipts-x.cashdisburse) As ttlamount from ("
    '    sql += "select a.accountcode,acct_description,"
    '    sql += "cashreceipts=isnull((select sum(amount) from DistributionReceipts where accountcode=a.accountcode and trndate='" + dtgl.Value + "'),0),"
    '    sql += "cashdisburse=isnull((select sum(amountpaid) from DistributionPayment where accountcode=a.accountcode and date='" + dtgl.Value + "'),0)"
    '    sql += " from ChartAccounts a "
    '    sql += ") x"
    '    sql += ") y where y.ttlamount <>0 order by y.acct_description asc"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While rd.Read
    '        row = DS.Tables(0).NewRow
    '        row(0) = CompName.ToString
    '        row(1) = compaddress.ToString
    '        row(2) = dtsummtrn.Value
    '        row(3) = branch.ToString
    '        row(4) = rd("accountcode").ToString
    '        row(5) = rd("acct_description").ToString
    '        row(6) = rd("cashreceipts").ToString
    '        row(7) = rd("cashdisburse").ToString
    '        DS.Tables(0).Rows.Add(row)
    '    End While
    '    'Next

    '    'SET THE REPORT SOURCE TO THE DATABASE
    '    MyRpt.SetDataSource(DS)

    '    'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
    '    crv_gl.ReportSource = MyRpt

    '    'DISPOSE OF THE DATASET
    '    DS.Dispose()
    '    DS = Nothing
    '    SplashScreen.Close()
    'End Sub

    'Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
    '    SplashScreen.count = 0
    '    Control.CheckForIllegalCrossThreadCalls = False
    '    thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
    '    'REPORT OBJECT
    '    Dim MyRpt As New printc

    '    'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
    '    Dim row As DataRow = Nothing
    '    Dim DS As New DataSet

    '    'ADD A TABLE TO THE DATASET
    '    DS.Tables.Add("dummy")
    '    'ADD THE COLUMNS TO THE TABLE
    '    With DS.Tables(0).Columns
    '        .Add("str13", Type.GetType("System.String"))
    '        .Add("str12", Type.GetType("System.String"))
    '        .Add("date1", Type.GetType("System.DateTime"))
    '        .Add("str16", Type.GetType("System.String"))
    '        .Add("str1", Type.GetType("System.String"))
    '        .Add("str2", Type.GetType("System.String"))
    '        .Add("int1", Type.GetType("System.Double"))
    '        .Add("int2", Type.GetType("System.Double"))
    '        .Add("date2", Type.GetType("System.DateTime"))
    '    End With

    '    'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
    '    'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
    '    conn()
    '    sql = "select sum(a.debit) as debit,sum(a.credit) as credit,b.accountcode,b.acct_description from CashiersTransaction a, ChartAccounts b where a.trndate='" + dtsummtrn.Value + "' and a.GLaccount=b.accountcode group by b.accountcode,b.acct_description"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While rd.Read
    '        row = DS.Tables(0).NewRow
    '        row(0) = CompName.ToString
    '        row(1) = compaddress.ToString
    '        row(2) = dtsummtrn.Value
    '        row(3) = productcode.ToString
    '        row(4) = rd("accountcode").ToString
    '        row(5) = rd("acct_description").ToString
    '        row(6) = rd("Debit").ToString
    '        row(7) = rd("Credit").ToString
    '        row(8) = systemdate
    '        DS.Tables(0).Rows.Add(row)
    '    End While
    '    'Next

    '    'SET THE REPORT SOURCE TO THE DATABASE
    '    MyRpt.SetDataSource(DS)

    '    'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
    '    crvsumm_of_trn.ReportSource = MyRpt

    '    'DISPOSE OF THE DATASET
    '    DS.Dispose()
    '    DS = Nothing
    '    SplashScreen.Close()
    'End Sub
End Class