Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_print_voucher
    Public ref As String
    Public evtype As String

    Private Sub frm_print_voucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If evtype = "cashdisburse_vouch" Then
        '    print_voucher_disburse()
        'ElseIf evtype = "cashreceipts_vouch" Then
        print_voucher_receipts()
        'End If
    End Sub

    Private Sub print_voucher_disburse()
        'REPORT OBJECT
        Dim MyRpt As New voucher

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
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("str10", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        Call conn()
        sql = "SELECT a.date,a.ref_no,a.amountpaid,a.accountcode,a.description,a.payee,b.acct_description FROM DistributionPayment a, ChartAccounts b WHERE a.accountcode=b.accountcode and a.ref_no='" + ref.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = "COOLWAY MULTIPURPOSE COOPERATIVE"
            row(1) = "Cantecson, Gairan, Bogo City, Cebu"
            row(2) = rd("date").ToString
            row(3) = rd("acct_description").ToString
            row(4) = "COH"
            row(5) = rd("amountpaid").ToString
            row(6) = "Cash Disbursement"
            DS.Tables(0).Rows.Add(row)
        End While
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_voucher.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub print_voucher_receipts()
        'REPORT OBJECT
        Dim MyRpt As New voucher

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        Call conn()
        sql = "select a.particulars,a.trndate,a.amount,a.ref_no,a.description,b.acct_description"
        sql += " from DistributionReceipts a ,ChartAccounts b where a.accountcode='2020' and a.trndate='" + frm_cashiering.dt_receipts.Value + "' and a.accountcode=b.accountcode"
        sql += " group by a.particulars,a.amount,a.ref_no,a.description,b.acct_description,a.trndate"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = rd("trndate").ToString
            row(3) = rd("ref_no").ToString
            row(4) = rd("particulars").ToString
            row(5) = rd("amount").ToString
            row(6) = rd("acct_description").ToString
            row(7) = rd("description").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_voucher.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub
End Class