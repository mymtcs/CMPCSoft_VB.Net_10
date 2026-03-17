Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Microsoft.Office.Interop

Public Class frm_upload_sss

    Private Sub frm_upload_savings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpick.Value = systemdate
        view_contribution()
        check_uploaded()
    End Sub


    Private Sub view_contribution()
        conn()
        dtgridsavings_coll.Rows.Clear()
        sql = "select x.* from(select a.memcode,a.sssno,a.fullname,"
        sql += "Reference=isnull((select top 1 ornumber from LoanCollect where memcode=a.memcode and trnxdate='" + dtpick.Value + "'),0),"
        sql += "ttlcont=isnull((select sum(SSSCont) from LoanCollect where memcode=a.memcode and trnxdate='" + dtpick.Value + "'),0),"
        sql += "postno=isnull((select count(postno)+1 from SSSLedger where memcode=a.memcode),1)"
        sql += " from members a)x where x.ttlcont>0"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 120
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgridsavings_coll.Rows.Add
            dtgridsavings_coll.Rows(x).Cells(0).Value = rd("memcode").ToString
            dtgridsavings_coll.Rows(x).Cells(1).Value = rd("sssno").ToString
            dtgridsavings_coll.Rows(x).Cells(2).Value = rd("fullname")
            dtgridsavings_coll.Rows(x).Cells(3).Value = rd("postno").ToString
            dtgridsavings_coll.Rows(x).Cells(4).Value = rd("Reference").ToString
            dtgridsavings_coll.Rows(x).Cells(5).Value = rd("ttlcont").ToString
            If bttncancel.Enabled = True Then
                dtgridsavings_coll.Rows(x).Cells(6).Value = "Uploaded"
            Else
                dtgridsavings_coll.Rows(x).Cells(6).Value = ""
            End If
        End While
        myConn.Close()

        lblps.Text = 0
        For x As Integer = 0 To dtgridsavings_coll.Rows.Count - 1
            If x Mod 2 Then
                dtgridsavings_coll.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            If dtgridsavings_coll.Rows(x).Cells(2).Value = "PS" Then
                lblps.Text = Decimal.Parse(dtgridsavings_coll.Rows(x).Cells(5).Value) + Decimal.Parse(lblps.Text)
            End If
        Next
        'lblcf.Text = "0.00"
    End Sub

    Private Sub bttnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Else
        'End If
    End Sub

    Private Sub check_uploaded()
        conn()
        sql = "Select a.postmode from SSSLedger a where a.postmode='COLL' and a.postingdate='" + dtpick.Value + "' and active='Y'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            bttncancel.Enabled = True
        Else
            bttncancel.Enabled = False
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub upload_cont()
        For i As Integer = 0 To dtgridsavings_coll.Rows.Count - 1
            conn()
            sql = "INSERT INTO SSSledger(Memcode,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Reference,userid,tdate,Active) VALUES "
            sql += "('" + dtgridsavings_coll.Rows(i).Cells(0).Value + "'"
            sql += ",'" + dtpick.Value + "'"
            sql += "," + dtgridsavings_coll.Rows(i).Cells(3).Value + ""
            sql += ",'COLL'"
            sql += "," + dtgridsavings_coll.Rows(i).Cells(5).Value.ToString + ",0"
            sql += ",'SSS Cont. Collection'"
            sql += ",'" + dtgridsavings_coll.Rows(i).Cells(4).Value + "'"
            sql += ",'" + user.ToString + "'"
            sql += ",'" + systemdate + "','Y')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Next

        Try

            conn()
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Uploading sss contribution,'" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Catch ex As Exception

        End Try

        MsgBox("Upload complete", MsgBoxStyle.Information, "Message")
        check_uploaded()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        'Export the listview to an Excel spreadsheet
        SaveFileDialog1.Title = "Save Excel File"
        SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        SaveFileDialog1.ShowDialog()
        'exit if no file selected
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If


        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To dtgridsavings_coll.RowCount - 2
            For j = 0 To dtgridsavings_coll.ColumnCount - 1
                For k As Integer = 1 To dtgridsavings_coll.Columns.Count
                    xlWorkSheet.Cells(1, k) = dtgridsavings_coll.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dtgridsavings_coll(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Export Completed.", MsgBoxStyle.Information, "Completed")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        view_contribution()
        check_uploaded()
    End Sub

    Private Sub bttn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_save.Click
        If bttncancel.Enabled = True Then
            MsgBox("You have to remove uploaded conribution first before you upload.", MsgBoxStyle.Exclamation, "Message")
        Else
            If MessageBox.Show("Are you sure you want to upload members contribution?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                upload_cont()
            End If
        End If
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        If MessageBox.Show("Are you sure you want to remove members contribution?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "DELETE FROM sssledger  where postingdate='" + dtpick.Value + "' and postmode='COLL'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            Try
                conn()
                sql = "INSERT INTO logs (PnNumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Deleting savings ledger from date " & dtpick.Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Catch ex As Exception

            End Try

            MsgBox("Uploaded savings has been removed.", MsgBoxStyle.Information, "Message")
            view_contribution()
            check_uploaded()
        End If
    End Sub
End Class