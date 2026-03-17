Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
'Imports North_soft_class

Public Class frm_savingsvalidation

    Private Sub frm_savingsvalidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'validate_account()
    End Sub

    Public Sub validate_account()
        Try
            'REPORT OBJECT
            Dim MyRpt As New savings_validation

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
                .Add("str4", Type.GetType("System.String"))
                .Add("date2", Type.GetType("System.DateTime"))
                .Add("str5", Type.GetType("System.String"))
                .Add("int1", Type.GetType("System.Double"))
                .Add("int2", Type.GetType("System.Double"))
                .Add("int3", Type.GetType("System.Double"))
                .Add("str6", Type.GetType("System.String"))
                .Add("int4", Type.GetType("System.Double"))
            End With

            'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
            'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
            row = DS.Tables(0).NewRow
            row(0) = usersname
            row(1) = cashier
            row(2) = frm_savings.dtgridsaving.CurrentRow.Cells(1).Value
            row(3) = systemdate
            row(4) = frm_savings.dtgridsaving.CurrentRow.Cells(0).Value
            row(5) = frm_savings.lstsavingledger.FocusedItem.SubItems(0).Text
            row(6) = frm_savings.lstsavingledger.FocusedItem.SubItems(6).Text
            row(7) = frm_savings.lstsavingledger.FocusedItem.SubItems(3).Text
            row(8) = frm_savings.lstsavingledger.FocusedItem.SubItems(4).Text
            conn()
            sql = "SELECT SUM(debit-credit) as bal from accountledger where accountnumber='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "' and Active<>'X'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                row(9) = rd("bal").ToString
            Else
                row(9) = 0
            End If
            rd.Close()
            myConn.Close()

            'MsgBox(frm_savings.lstsavingledger.FocusedItem.SubItems(4).Text)
            If Double.Parse(frm_savings.lstsavingledger.FocusedItem.SubItems(4).Text) > 0 Then
                row(10) = AmountInWords(frm_savings.lstsavingledger.FocusedItem.SubItems(4).Text)
                row(11) = frm_savings.lstsavingledger.FocusedItem.SubItems(4).Text
            ElseIf Double.Parse(frm_savings.lstsavingledger.FocusedItem.SubItems(3).Text) > 0 Then
                row(10) = AmountInWords(frm_savings.lstsavingledger.FocusedItem.SubItems(3).Text)
                row(11) = frm_savings.lstsavingledger.FocusedItem.SubItems(3).Text
            End If
            DS.Tables(0).Rows.Add(row)
            'Next

            'SET THE REPORT SOURCE TO THE DATABASE
            MyRpt.SetDataSource(DS)

            'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
            crviewer.ReportSource = MyRpt

            'DISPOSE OF THE DATASET
            DS.Dispose()
            DS = Nothing
            frm_savings.bttnvalidation.Enabled = False
        Catch ex As Exception
            MsgBox("Invalid selection of accounts.", MsgBoxStyle.Exclamation, "Invalid")
        End Try
    End Sub
End Class