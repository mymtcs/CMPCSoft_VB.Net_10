Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_printvouch

    Private Sub frm_printvouch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generate_voucher()
    End Sub

    Public Sub generate_voucher()
        'Try
        'REPORT OBJECT
        Dim MyRpt As New printvoucher

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        Dim count As Integer = 0
        conn()
        sql = "select b.GLaccount,a.Amount,a.Description from LoansDeduction a, DeductionMF b where a.code=b.code and a.pnnumber='" + frm_newloanlist.dtgridloanlist.CurrentRow.Cells(2).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = frm_newloanlist.dtgridloanlist.CurrentRow.Cells(3).Value
            row(1) = "Loan Amount"
            row(2) = rd("Description").ToString
            row(3) = frm_newloanlist.dtgridloanlist.CurrentRow.Cells(4).Value
            row(4) = frm_newloanlist.dtgridloanlist.CurrentRow.Cells(5).Value
            row(5) = rd("Amount").ToString
            row(6) = usersname.ToString
            row(7) = cashier.ToString
            row(8) = AreaSupervisor.ToString
            row(9) = "Net Proceeds"
            count = count + 1
            DS.Tables(0).Rows.Add(row)
        End While
        'Next
        If count = 0 Then
            row = DS.Tables(0).NewRow
            row(0) = frm_newloanlist.dtgridloanlist.CurrentRow.Cells(3).Value
            row(1) = "Loan Amount"
            row(2) = "--"
            row(3) = frm_newloanlist.dtgridloanlist.CurrentRow.Cells(4).Value
            row(4) = frm_newloanlist.dtgridloanlist.CurrentRow.Cells(5).Value
            row(5) = 0
            row(6) = usersname.ToString
            'check by cashier to bookkeeer
            'row(7) = cashier.ToString
            row(7) = bookkeeper.ToString()

            'approved by blank
            'row(8) = AreaSupervisor.ToString
            row(8) = "" ' blankd


            row(9) = "Net Proceeds"
            count = count + 1
            DS.Tables(0).Rows.Add(row)
        End If

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
        'Catch ex As Exception
        '    MsgBox("Data is out of range.", MsgBoxStyle.Exclamation)
        'End Try
    End Sub
End Class