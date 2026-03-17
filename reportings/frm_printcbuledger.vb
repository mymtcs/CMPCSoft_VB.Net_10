Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frm_printcbuledger
    Public postno As Integer
    Public lineno As Integer
    Public countline As Integer

    Private Sub frm_printcbuledger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        printSA_ledger()
        'Catch ex As Exception
        '    MsgBox("Invalid selection of accounts.", MsgBoxStyle.Exclamation, "Invalid")
        'End Try
    End Sub

    Public Sub printSA_ledger()
        'REPORT OBJECT
        Dim MyRpt As New CBUledger

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str6", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            'If lineno = 1 Then
            '    .Add("str5", Type.GetType("System.String"))
            '    .Add("str4", Type.GetType("System.String"))
            'End If
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        'sql = "SELECT TOP 150 a.cbuaccount,CONVERT(VARCHAR(10),a.postingdate,101) As postingdate,a.postno,a.postmode,a.debit,a.credit,b.fullname, "
        'sql += "(select SUM(debit)-SUM(credit) from cbuledger where postno<=a.postno and cbuaccount=a.cbuaccount and active<>'X')As runbalance,a.refrence,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate FROM AccountLedger a,members b,AccountMaster c WHERE b.MemCode=c.MemCode AND a.cbuaccount=c.cbuaccount  AND a.cbuaccount='" + frm_savings.dtgridsaving.CurrentRow.Cells(0).Value + "' and a.postno>='" + frm_psbkdtls.txtpostno.Text + "' and a.active<>'X' "
        'sql += "GROUP BY a.postingdate,b.fullname,a.postno,a.postmode,a.debit,a.credit,a.refrence,a.remarks,a.userid,a.tdate,a.cbuaccount ORDER BY a.postno"

        sql = "SELECT TOP 150 a.cbuaccount,CONVERT(VARCHAR(10),a.postingdate,101) As postingdate,a.postno,a.postmode,a.debit,a.credit,b.fullname, "
        sql += "(select SUM(debit)-SUM(credit) from cbuledger where postno<=a.postno and cbuaccount=a.cbuaccount and active<>'X')As runbalance,a.Reference,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate FROM cbuledger a,members b WHERE a.cbuaccount=b.cbuaccount  AND a.cbuaccount='" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "' and a.postno>=" + frm_cbudetails.txtpostno.Text.ToString + " and a.active='Y' "
        sql += " GROUP BY a.postingdate,b.fullname,a.postno,a.postmode,a.debit,a.credit,a.Reference,a.remarks,a.userid,a.tdate,a.cbuaccount ORDER BY a.postno"

        'sql = "SELECT a.Accountnumber,CONVERT(VARCHAR(10),a.postingdate,101) As postingdate,a.postno,a.postmode,a.debit,a.credit,b.fullname, "
        'sql += "(select SUM(debit)-SUM(credit) from AccountLedger where postno<=a.postno and Accountnumber=a.Accountnumber)As runbalance,a.refrence,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate FROM AccountLedger a,members b WHERE a.Accountnumber=b.Accountnumber AND a.Accountstatus='Active' AND a.Accountnumber='" + frm_savings.dtgridsavings.CurrentRow.Cells(0).Value + "' and a.postno>='" + frm_psbkdtls.txtpostno.Text + "' "
        'sql += " GROUP BY a.postingdate,b.fullname,a.postno,a.postmode,a.debit,a.credit,a.refrence,a.remarks,a.userid,a.tdate,a.Accountnumber ORDER BY a.postno"

        'sql = "SELECT CONVERT(VARCHAR(10),a.postingdate,101) As postingdate,a.postno,a.postmode,a.debit,a.credit,(sum(a.debit)-sum(a.credit)) As runbalance,a.refrence,a.remarks,a.userid,a.tdate,a.Accountnumber,a.Accountnumber,c.fullname FROM AccountLedger a, AccountMaster b,members c WHERE a.Accountnumber=b.Accountnumber and b.MemCode=c.MemCode and a.Accountnumber='" + frm_savings.dtgridsavings.CurrentRow.Cells(0).Value + "' and postno>='" + frm_psbkdtls.txtpostno.Text + "'"
        'sql += " GROUP BY a.postingdate,a.postno,a.postmode,a.debit,a.credit,a.refrence,a.remarks,a.userid,a.tdate,a.Accountnumber,a.Accountnumber,c.fullname ORDER BY Postno ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        'If lineno > 17 Then
        '    For i As Integer = 0 To 2
        '        row = DS.Tables(0).NewRow
        '        row(0) = ""
        '        DS.Tables(0).Rows.Add(row)
        '    Next
        'End If
        If lineno > 1 Then
            For i As Integer = 0 To 4
                row = DS.Tables(0).NewRow
                row(0) = ""
                DS.Tables(0).Rows.Add(row)
            Next
        End If

        For i As Integer = 0 To lineno
            row = DS.Tables(0).NewRow
            row(0) = ""
            DS.Tables(0).Rows.Add(row)
        Next

        Dim x As Integer = lineno - 1
        While rd.Read
            x = x + 1
            'If lineno = 17 Then
            '    For i As Integer = 0 To 2
            '        row = DS.Tables(0).NewRow
            '        row(0) = ""
            '        DS.Tables(0).Rows.Add(row)
            '    Next
            'End If
            If lineno = 1 Then
                x = 1
                For i As Integer = 0 To 4
                    row = DS.Tables(0).NewRow
                    If i = 2 Then
                        row(0) = rd("cbuaccount").ToString
                        row(1) = rd("fullname").ToString
                    Else
                        row(0) = ""
                    End If
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 17 Then
                For i As Integer = 0 To 2
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 37 Then
                For i As Integer = 0 To 4
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
                x = 1
                For i As Integer = 0 To 20
                    row = DS.Tables(0).NewRow
                    If i = 18 Then
                        row(0) = rd("cbuaccount").ToString
                        row(1) = rd("fullname").ToString
                    Else
                        row(0) = ""
                    End If
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 53 Then
                For i As Integer = 0 To 2
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 73 Then
                For i As Integer = 0 To 4
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
                x = 1
                For i As Integer = 0 To 20
                    row = DS.Tables(0).NewRow
                    If i = 18 Then
                        row(0) = rd("cbuaccount").ToString
                        row(1) = rd("fullname").ToString
                    Else
                        row(0) = ""
                    End If
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 89 Then
                For i As Integer = 0 To 2
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 109 Then
                For i As Integer = 0 To 4
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
                x = 1
                For i As Integer = 0 To 20
                    row = DS.Tables(0).NewRow
                    If i = 18 Then
                        row(0) = rd("cbuaccount").ToString
                        row(1) = rd("fullname").ToString
                    Else
                        row(0) = ""
                    End If
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            If lineno = 125 Then
                For i As Integer = 0 To 2
                    row = DS.Tables(0).NewRow
                    row(0) = ""
                    DS.Tables(0).Rows.Add(row)
                Next
            End If
            'If lineno = 180 Then
            '    For i As Integer = 0 To 2
            '        row = DS.Tables(0).NewRow
            '        row(0) = ""
            '        DS.Tables(0).Rows.Add(row)
            '    Next
            'End If
            row = DS.Tables(0).NewRow
            row(0) = ""
            row(1) = ""
            row(2) = rd("postingdate").ToString
            row(3) = rd("reference").ToString
            row(4) = user.ToString
            row(5) = rd("debit").ToString
            row(6) = rd("credit").ToString
            row(7) = rd("runbalance").ToString
            row(8) = x.ToString
            'If lineno = 1 Then
            '    row(9) = rd("Accountnumber").ToString
            '    row(10) = rd("fullname").ToString
            'End If

            DS.Tables(0).Rows.Add(row)
            lineno = lineno + 1
        End While
        'Next
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Public Sub printSA_cover()
        'REPORT OBJECT
        Dim MyRpt As New passbook_cover

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
            .Add("str4", Type.GetType("System.String"))
            .Add("str5", Type.GetType("System.String"))
            '.Add("str5", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            '.Add("date2", Type.GetType("System.DateTime"))
            '.Add("date3", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items

        row = DS.Tables(0).NewRow
        row(0) = frm_savings.dtgridsaving.CurrentRow.Cells(0).Value
        row(1) = frm_savings.dtgridsaving.CurrentRow.Cells(1).Value
        row(2) = frm_savings.dtgridsaving.CurrentRow.Cells(2).Value
        row(3) = frm_savings.dtgridsaving.CurrentRow.Cells(6).Value
        row(4) = productcode
        row(5) = frm_savings.dtgridsaving.CurrentRow.Cells(4).Value
        DS.Tables(0).Rows.Add(row)
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub
End Class