Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Microsoft.Office.Interop

Public Class frm_upload_savings

    Private Sub frm_upload_savings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpick.Value = systemdate
        dtpick.Enabled = False
        gen_loantype()
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        check_uploaded()
        view_savings_CFcoll()
        view_savings_PScoll()
        If usertype = "Admin" Then
            dtpick.Enabled = True
        End If
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

    Private Sub check_uploaded()
        conn()
        sql = "Select a.postmode from accountledger a where a.postmode='COLL' and a.postingdate='" + dtpick.Value + "' and a.gl_sa='" + GL_sa + "' and active='Y'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            bttncancel_uploaded.Enabled = True
        Else
            bttncancel_uploaded.Enabled = False
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub view_savings_CFcoll()
        conn()
        dtgridsavings_coll.Rows.Clear()
        sql = "select x.accountname,x.accountnumber,x.ornumber,cf=sum(x.cf),postno = isnull((select count(postno)+1 from accountledger where accountnumber=x.accountnumber),0) from(select "
        sql += "accountname=(select top 1 ctrname from center where ctrcode=a.ctrcode),"
        sql += "accountnumber=(select top 1 accountnumber from center where ctrcode=a.ctrcode),"
        sql += "convert (varchar(8),getdate(),2) as ornumber,"
        sql += "cf=isnull((select sum(cf) from loancollect where pnnumber=a.pnnumber and trnxdate='" & dtpick.Value & "'),0)"
        sql += " from loans a where gl_loans='" & txtloantype.SelectedValue & "')x where x.cf>0 group by x.accountname,x.accountnumber,x.ornumber"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 60
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            For i As Integer = 0 To dtgridsavings_coll.Rows.Count - 1
                If rd("accountnumber") = dtgridsavings_coll.Rows(i).Cells(0).Value Then
                    dtgridsavings_coll.Rows(i).Cells(5).Value = Double.Parse(dtgridsavings_coll.Rows(i).Cells(5).Value) + rd("cf")
                    GoTo a
                End If
            Next
            If bttncancel_uploaded.Enabled = True Then
                dtgridsavings_coll.Rows.Add(rd("accountnumber").ToString, rd("accountname").ToString, "CF", rd("postno").ToString, dtpick.Value.ToString("M.d.yy") & "-CF", rd("cf").ToString, "Uploaded")
            Else
                dtgridsavings_coll.Rows.Add(rd("accountnumber").ToString, rd("accountname").ToString, "CF", rd("postno").ToString, dtpick.Value.ToString("M.d.yy") & "-CF", rd("cf").ToString, "")
            End If
a:
        End While
        myConn.Close()

        lblcf.Text = 0

        Dim r As Integer = 0
        For x As Integer = 0 To dtgridsavings_coll.Rows.Count - 1
            If dtgridsavings_coll.Rows(x).Cells(2).Value = "CF" Then
                lblcf.Text = Decimal.Parse(dtgridsavings_coll.Rows(x).Cells(5).Value) + Decimal.Parse(lblcf.Text)
            End If
        Next
    End Sub

    Private Sub view_savings_PScoll()
        conn()
        'dtgridsavings_coll.Rows.Clear()
        sql = "select x.* from(select b.memcode,b.pnnumber,b.accountnumber,convert (varchar(8),getdate(),2) as ornumber,"
        sql += "accountname=(select fullname from members where memcode=b.memcode),"
        sql += "savings=isnull((select sum(savings) from loancollect where pnnumber=b.pnnumber  and trnxdate=a.trnxdate),0),"
        sql += "postno = isnull((select count(postno)+1 from accountledger where accountnumber=b.accountnumber),0)"
        sql += " from loancollect a,loans b where a.trnxdate='" + dtpick.Value + "' and a.savings>0 and a.pnnumber=b.pnnumber and b.gl_loans='" + GL_loans + "' and a.memcode is not null)x "
        sql += "group by x.memcode,x.accountnumber,x.pnnumber,x.ornumber,x.accountname,x.savings,x.postno order by x.accountname"
        cmd = New SqlCommand(sql, myConn)
        'cmd.CommandTimeout = 120
        cmd.CommandTimeout = 240
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgridsavings_coll.Rows.Add
            dtgridsavings_coll.Rows(x).Cells(0).Value = rd("accountnumber").ToString
            dtgridsavings_coll.Rows(x).Cells(1).Value = rd("accountname").ToString
            dtgridsavings_coll.Rows(x).Cells(2).Value = "PS"
            dtgridsavings_coll.Rows(x).Cells(3).Value = rd("postno").ToString
            dtgridsavings_coll.Rows(x).Cells(4).Value = rd("ornumber").ToString & "-PS"
            dtgridsavings_coll.Rows(x).Cells(5).Value = rd("savings").ToString
            If bttncancel_uploaded.Enabled = True Then
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

    Private Sub bttnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrefresh.Click
        'If chksa.IsChecked = True Then
        GL_loans = txtloantype.SelectedValue 'Hawak Kamay = 1050-03, Individual 
        select_grptype()
        check_uploaded()
        view_savings_CFcoll()
        view_savings_PScoll()
        check_uploaded()
        'Else
        'End If
    End Sub

    Private Sub bttnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnupload.Click
        If bttncancel_uploaded.Enabled = True Then
            MsgBox("You have to remove uploaded savings first before you upload.", MsgBoxStyle.Exclamation, "Message")
        Else
            frm_balance_check.ShowDialog()
        End If
    End Sub

    Public Sub upload_savings()
        For i As Integer = 0 To dtgridsavings_coll.Rows.Count - 1

            'GET THE SAVINGS ACCOUNT TYPE
            '--------------------on testing ---------------------
            'GET THE GL_SA CODE HERE - 07/12/2022
            ' GET THE accountmaster table GL_sa field
            conn()
            sql = "SELECT a.GL_sa, a.AccountNumber  FROM accountmaster a where a.accountnumber='" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "
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
            'insert data'

            ' display data
            'MsgBox("Account #: " & dtgridsavings_coll.Rows(i).Cells(0).Value & Chr(10) & Chr(13) _
            '       & dtpick.Value & Chr(10) & Chr(13) _
            '       & dtgridsavings_coll.Rows(i).Cells(3).Value & Chr(10) & Chr(13) _
            '       & "COLL" & Chr(10) & Chr(13) _
            '       & dtgridsavings_coll.Rows(i).Cells(5).Value.ToString & Chr(10) & Chr(13) _
            '       & dtgridsavings_coll.Rows(i).Cells(4).Value & Chr(10) & Chr(13) _
            '       & user.ToString & Chr(10) & Chr(13) _
            '       & AccountMaster_GL_sa, MsgBoxStyle.Information, "Amount")

            'MsgBox("Amount: " & dtgridsavings_coll.Rows(i).Cells(5).Value.ToString, MsgBoxStyle.Information, "Amount")

            conn()
            sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,GL_sa,tdate,Active) VALUES "
            sql += "('" + dtgridsavings_coll.Rows(i).Cells(0).Value + "'"
            sql += ",'" + dtpick.Value + "'"
            sql += "," + dtgridsavings_coll.Rows(i).Cells(3).Value + ""
            sql += ",'COLL'"
            sql += "," + dtgridsavings_coll.Rows(i).Cells(5).Value.ToString + ",0"
            sql += ",'Collections'"
            sql += ",'" + dtgridsavings_coll.Rows(i).Cells(4).Value + "'"
            sql += ",'" + user.ToString + "'"
            'sql += ",'" + GL_sa + "'"
            sql += ",'" + AccountMaster_GL_sa + "'" 'ADDED 7/13/2022
            sql += ",'" + systemdate + "','Y')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Next

        conn()
        sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Uploading savings " & txtloantype.SelectedValue & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        dtpick.Enabled = False
        MsgBox("Upload complete", MsgBoxStyle.Information, "Message")
        check_uploaded()
    End Sub

    Public Sub cancel_uploaded_savings()
        For i As Integer = 0 To dtgridsavings_coll.Rows.Count - 1
            conn()
            'sql = "UPDATE AccountLedger SET Active = 'X' WHERE Accountnumber = '" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "
            'sql += " AND PostingDate BETWEEN " + "'" + dtpick.Value + "',"
            'sql += "Postmode = " + "'COLL',"
            'sql += "Debit = " + dtgridsavings_coll.Rows(i).Cells(5).Value.ToString + "," '+ "'"
            'sql += "Credit = " + "0,"
            'sql += "Remarks = " + "'Collections',"
            'sql += "Refrence = " + "'" + dtgridsavings_coll.Rows(i).Cells(4).Value + "',"
            'sql += "Active = " + "'Y'"


            'sql += " AND PostingDate BETWEEN " + "'" + dtpick.Value + " 00:00:00' AND " + "'" + dtpick.Value + " 23:59:59' "

            ' ORIGINAL COMMAND
            '--sql = "UPDATE AccountLedger SET Active = 'X' WHERE Accountnumber = '" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "
            'sql = "DELETE FROM AccountLedger WHERE Accountnumber = '" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "
            'sql += " AND PostingDate = '" + dtpick.Value + "'"
            'sql += " AND Postmode = " + "'COLL' "
            'sql += " AND Debit = " + dtgridsavings_coll.Rows(i).Cells(5).Value.ToString + " "
            'sql += " AND Credit = " + "0 "
            'sql += " AND Remarks = " + "'Collections' "
            '--sql += " AND Refrence = " + "'" + dtgridsavings_coll.Rows(i).Cells(4).Value + "' "
            '--sql += " AND Active = " + "'Y'"


            ' ORIGINAL COMMAND
            '--sql = "UPDATE AccountLedger SET Active = 'X' WHERE Accountnumber = '" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "

            'ato ni e remarks kay dili 
            'sql = "DELETE FROM AccountLedger WHERE Accountnumber = '" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "
            sql = "UPDATE AccountLedger SET Active = 'X' WHERE Accountnumber = '" + dtgridsavings_coll.Rows(i).Cells(0).Value + "' "
            sql += " AND PostingDate = '" + dtpick.Value + "'"
            sql += " AND Postmode = " + "'COLL' "
            ' e remarks sa ni para tanang na debit, iya e cancel 05/03/2023
            'sql += " AND Debit = " + dtgridsavings_coll.Rows(i).Cells(5).Value.ToString + " "
            sql += " AND Credit = " + "0 "
            sql += " AND Remarks = " + "'Collections' "
            '--sql += " AND Refrence = " + "'" + dtgridsavings_coll.Rows(i).Cells(4).Value + "' "
            '--sql += " AND Active = " + "'Y'"

            'TEMP
            'GL_loans = txtloantype.SelectedValue

            'conn()
            'sql = "DELETE FROM Accountledger  where postingdate='" + dtpick.Value + "' and gl_sa='" + GL_sa + "' and postmode='COLL'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()



            'MsgBox(sql)

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            ' cancel below
            'conn()
            'sql = "DELETE FROM Accountledger  where postingdate='" + dtpick.Value + "' and gl_sa='" + GL_sa + "' and postmode='COLL'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()

        Next

        dtpick.Enabled = False
        MsgBox("Uploaded Savings Cancelled complete", MsgBoxStyle.Information, "Message")

        check_uploaded()

        view_savings_CFcoll()
        view_savings_PScoll()

    End Sub


    Private Sub bttncancel_uploaded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel_uploaded.Click
        If MessageBox.Show("Are you sure you want to delete savings ledger of " & systemdate & "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            cancel_uploaded_savings() 'new updated cancel upload savings 7/15/2022

            ' cancel below
            'conn()
            'sql = "DELETE FROM Accountledger  where postingdate='" + dtpick.Value + "' and gl_sa='" + GL_sa + "' and postmode='COLL'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()

            'conn()
            'sql = "INSERT INTO logs (PnNumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Deleting savings ledger from date " & dtpick.Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()

            'MsgBox("Uploaded savings has been removed.", MsgBoxStyle.Information, "Message")
            'check_uploaded()

            'view_savings_CFcoll()
            'view_savings_PScoll()
        End If
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

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        pn_backdate.Visible = False
    End Sub

    Private Sub bttncont1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont1.Click
        'Try
        '    mysqlconn()
        '    sql = "select * from access_temp where accesspass='" + txtpassword_rec.Text + "' and userid='" + user + "' and status='A'"
        '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
        '    mysqlmyconn.Open()
        '    mysqlrd = mysqlcmd.ExecuteReader
        '    If mysqlrd.Read Then
        If txtpassword_rec.Text = adminpass Then
            dtpick.Enabled = True
            pn_backdate.Visible = False
        Else
            MessageBox.Show("Invalid password")
        End If
        '    Else
        'MsgBox("Invalid access of user ID.", MsgBoxStyle.Exclamation, "Invalid User")
        '    End If
        'mysqlrd.Close()
        'mysqlmyconn.Close()

        'update_accesstemp()
        'Catch ex As Exception
        '    MsgBox("Cannot connect to MySql Host.", MsgBoxStyle.Exclamation, "Failed to connect")
        'End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pn_backdate.Visible = True
    End Sub
End Class