Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization

Public Class frm_savings
    Dim acctgnum As String = ""
    Dim postno As Integer = 0
    Dim c1 As Integer = 1
    Dim c2 As Integer = 200

    Private Sub display_sa()
        conn()
        dtgridsaving.Rows.Clear()
        sql = "select  x.* from(select a.Accountnumber,CONVERT(VARCHAR(10),a.dateopen,101) As dateopen,a.accountstatus,a.gl_sa,a.AccountType, "
        sql += "accountname=isnull((select fullname from members where memcode=a.memcode),(select (ctrname+' '+ctrcode) from center where accountnumber=a.accountnumber and gl_loans='1050-03')),"
        sql += "DateClosed=isnull((select DateClosed from accountmaster where accountnumber=a.accountnumber),'" + systemdate.AddYears(999) + "'),"
        sql += "Address=isnull((select address from members where memcode=a.memcode),(select ctraddress from center where accountnumber=a.accountnumber and a.accountnumber<>'')),"
        sql += "acctbalance=isnull((select sum(debit-credit) from accountledger where accountnumber=a.Accountnumber and active='Y'),0)"
        sql += " FROM AccountMaster a  "
        sql += ")x WHERE x.accountname LIKE '" + cboletter.Text + "%' GROUP BY x.DateClosed,x.acctbalance,x.Accountnumber,x.accountname,x.Address,x.dateopen,x.accountstatus,x.gl_sa,x.AccountType ORDER BY x.AccountType,x.accountname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        Dim dateclosed As String
        While rd.Read
            If Date.Parse(rd("DateClosed")).ToString("yyyyMdd") <= systemdate.ToString("yyyyMdd") Then
                dateclosed = "Closed"
            Else
                dateclosed = "Active"
            End If
            dtgridsaving.Rows.Add(rd("Accountnumber").ToString, rd("accountname").ToString, rd("Address").ToString.Replace("Undefined", ""), String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("acctbalance")), Date.Parse(rd("dateopen")), rd("AccountStatus"), rd("AccountType").ToString, rd("gl_sa"))
        End While
        rd.Close()
        myConn.Close()

        For x As Integer = 0 To dtgridsaving.Rows.Count - 1
            If x Mod 2 Then
                dtgridsaving.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Dim row As DataGridViewRow = dtgridsaving.Rows(x)
            row.Height = 30
        Next
        dtgridsaving.ClearSelection()
    End Sub

    Private Sub frmsavings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboletter.Text = "A"
        display_sa()
        txtsearch.Focus()
    End Sub

    Public Sub display_ledger()
        conn()
        lstsavingledger.Items.Clear()
        sql = "select x.* from(SELECT CONVERT(VARCHAR(11),a.postingdate,101) As postingdate,postno,a.postmode,a.debit,a.credit,"
        sql += "isnull((select SUM(debit-credit) from AccountLedger where postno<=a.postno and Accountnumber=a.Accountnumber and active='Y'),0)As runbal,a.refrence,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate,a.Active,a.gl_sa,a.id,ROW_NUMBER() OVER (ORDER BY postno) AS RowNumber FROM AccountLedger a WHERE a.Accountnumber='" + acctgnum + "' "
        sql += ")x where x.rownumber between " & c1.ToString & " and " & c2.ToString & " GROUP BY x.RowNumber,x.postingdate,x.postmode,x.debit,x.credit,x.refrence,x.remarks,x.userid,x.tdate,x.runbal,x.postno,x.Active,x.gl_sa,x.id ORDER BY x.postno"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstsavingledger.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstsavingledger.Items.Count - 1

            If i Mod 2 Then
                lstsavingledger.Items(i).BackColor = Color.AliceBlue
            Else
                lstsavingledger.Items(i).BackColor = Color.White
            End If

            If lstsavingledger.Items(i).SubItems(10).Text <> "Y" Then
                lstsavingledger.Items(i).ForeColor = Color.Gray
                If lstsavingledger.Items(i).SubItems(10).Text = "X" Then
                    lstsavingledger.Items(i).Font = myFont
                End If
            End If
        Next
    End Sub

    Private Sub dtgridsavings_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        display_ledger()
    End Sub

    Private Sub bttndeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndeposit.Click
        If dtgridsaving.CurrentRow.Cells(5).Value = "Active" Then
            frm_deposit.ShowDialog()
        Else
            MsgBox("This savings account was already closed.", MsgBoxStyle.Exclamation, "Invalid")
        End If
    End Sub

    Private Sub bttnwithdrwls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnwithdrwls.Click
        If dtgridsaving.CurrentRow.Cells(5).Value = "Active" Then
            'If Double.Parse(dtgridsaving.CurrentRow.Cells(3).Value) <= 1000 Then
            '    If MessageBox.Show("Savings account is below minimum than required. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            '        frm_withdrawals.ShowDialog()
            '    End If
            'Else
            frm_withdrawals.ShowDialog()
            'End If
        Else
            MsgBox("This savings account was already closed.", MsgBoxStyle.Exclamation, "Invalid")
        End If
    End Sub

    Private Sub bttnpcover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnpcover.Click
        frm_printsavings.printSA_cover()
        frm_printsavings.crviewer.PrintReport()
    End Sub

    Private Sub bttn_passbookledger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_passbookledger.Click
        frm_psbkdtls.ShowDialog()
    End Sub

    Private Sub rd_cf_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
        Try
            SplashScreen.count = 0
            Control.CheckForIllegalCrossThreadCalls = False
            thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
            thread.Start()
            display_sa()
            SplashScreen.Close()
        Catch ex As Exception
            SplashScreen.Close()
        End Try
    End Sub

    Private Sub rd_ps_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
        'SplashScreen.count = 0
        'Control.CheckForIllegalCrossThreadCalls = False
        'thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        'thread.Start()
        display_sa()
        'SplashScreen.Close()
    End Sub

    Private Sub bttndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrecompute.Click
        If MessageBox.Show("Are you sure you want to recompute this ledger?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            lstsavingledger.Items.Clear()
            sql = "select x.* from(SELECT a.postingdate,postno,a.postmode,a.debit,a.credit,"
            sql += "a.refrence,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate,a.Active,a.gl_sa,a.id FROM AccountLedger a WHERE a.Accountnumber='" + acctgnum + "' and active<>'X' "
            sql += ")x GROUP BY x.postingdate,x.postmode,x.debit,x.credit,x.refrence,x.remarks,x.userid,x.tdate,x.postno,x.Active,x.gl_sa,x.id ORDER BY x.postingdate,x.id ASC"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While (rd.Read())
                Dim lvitem As New ListViewItem(rd(0).ToString())
                For i As Integer = 1 To rd.FieldCount - 1
                    lvitem.SubItems.Add(rd(i).ToString())
                Next
                lstsavingledger.Items.Add(lvitem)
            End While
            rd.Close()
            myConn.Close()

            Dim payno As Integer = 1
            For i As Integer = 0 To lstsavingledger.Items.Count - 1
                conn()
                sql = "UPDATE AccountLedger SET Postno=" + payno.ToString + "  WHERE Active<>'X' and Accountnumber='" + dtgridsaving.CurrentRow.Cells(0).Value + "' AND PostingDate='" + lstsavingledger.Items(i).SubItems(0).Text + "' and id=" + lstsavingledger.Items(i).SubItems(11).Text + ""
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                payno = payno + 1
            Next
            display_ledger()
        End If
    End Sub

    Private Sub lstsavingledger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstsavingledger.Click
        If usertype <> "Cashier" And lstsavingledger.FocusedItem.SubItems(10).Text = "N" Then
            'disable this button kay maka edit bisan kinsa
            '03/08/2023
            'bttnedit.Enabled = True
            bttnedit.Enabled = False

            bttnvalidation.Enabled = True
        Else
            bttnedit.Enabled = False
            bttnvalidation.Enabled = False
        End If
        If lstsavingledger.FocusedItem.SubItems(2).Text = "CHK" And lstsavingledger.FocusedItem.SubItems(0).Text = systemdate Then
            'disable this button kay maka edit bisan kinsa
            '03/08/2023
            'bttnedit.Enabled = True
            bttnedit.Enabled = False ' new 
        End If
        If usertype = "Admin" Then 'Or usertype = "Bookkeeper" Then
            bttnedit.Enabled = True
        End If
    End Sub

    Private Sub SetToCloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToCloseToolStripMenuItem.Click
        If dtgridsaving.CurrentRow.Cells(5).Value = "Closed" Then
            MsgBox("This savings account is already closed.", MsgBoxStyle.Exclamation)
        ElseIf Double.Parse(dtgridsaving.CurrentRow.Cells(3).Value) >= 0 Then
            If MessageBox.Show("Account balance is greater than zero. Are you sure you want to update this account?", "Update Savings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                conn()
                sql = "UPDATE Accountmaster SET accountstatus='Closed',DateClosed='" + systemdate + "' WHERE Accountnumber='" + dtgridsaving.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                display_sa()

                conn()
                Dim reasons As String = "Closed the savings account " & dtgridsaving.CurrentRow.Cells(0).Value & ""
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else

            End If    
        Else
            'MsgBox("This Savings Account balance is greater than zero. Failed to update", MsgBoxStyle.Exclamation, "Update failed")
        End If
    End Sub

    Private Sub SetAsActiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsActiveToolStripMenuItem.Click
        'If Double.Parse(dtgridsaving.CurrentRow.Cells(3).Value) > 0 Then
        'If dtgridsaving.CurrentRow.Cells(5).Value = "Active" Then
        '    MsgBox("This savings account is already active.", MsgBoxStyle.Exclamation)
        'ElseIf MessageBox.Show("Note: Please check the Account No. of this member if there are any active account to avoid runtime error. Click yes if already checked", "Important", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
        conn()
        sql = "UPDATE Accountmaster SET accountstatus='Active', dateclosed=NULL WHERE Accountnumber='" + dtgridsaving.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        display_sa()

        conn()
        Dim reasons As String = "Activated the savings account " & dtgridsaving.CurrentRow.Cells(0).Value & ""
        sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        'End If
        'Else
        'MsgBox("This Savings Account balance is greater than zero. Failed to update", MsgBoxStyle.Exclamation, "Update failed")
        'End If
    End Sub

    Private Sub bttnedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnedit.Click
        frm_edit_savings_ledger.ShowDialog()
    End Sub

    Private Sub dtgridsaving_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridsaving.Click
        Try
            Cursor = Cursors.AppStarting
            acctgnum = dtgridsaving.CurrentRow.Cells(0).Value
            display_ledger()
            Cursor = Cursors.Default
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgrid_savings_type_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Cursor = Cursors.AppStarting
        display_ledger()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_new.Click
        frm_newsavings_acct.ShowDialog()
    End Sub

    Private Sub bttnvalidation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnvalidation.Click
        frm_savingsvalidation.validate_account()
        frm_savingsvalidation.crviewer.PrintReport()
    End Sub

    Private Sub SetAccountAsCenterFundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are you sure you want update this account as CF?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "UPDATE accountmaster set Accounttype='CF', memcode='NULL' where accountnumber='" + dtgridsaving.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            display_sa()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        For Each row As DataGridViewRow In dtgridsaving.Rows
            'If you want the results to be case sensitive then remove the 2 ".ToLower" references on the line below   
            If row.Cells(1).Value.ToString.ToLower.Contains(txtsearch.Text.ToLower) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub cboletter_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboletter.Validated
        display_sa()
    End Sub

    Private Sub cboletter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboletter.SelectedIndexChanged
        txtsearch.Focus()
    End Sub

    Private Sub bttnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnext.Click
        c1 = c1 + 200
        c2 = c2 + 200
        txtcount.Text = c1.ToString & " - " & c2.ToString
        display_ledger()
        bttnprev.Enabled = True
        If lstsavingledger.Items.Count < 200 Then
            bttnnext.Enabled = False
        End If
    End Sub

    Private Sub bttnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnprev.Click
        If c1 > 1 Then
            c1 = c1 - 200
            c2 = c2 - 200
            txtcount.Text = c1.ToString & " - " & c2.ToString
            display_ledger()
            bttnnext.Enabled = True
        End If
        If c1 = 1 Then
            bttnprev.Enabled = False
        End If
    End Sub

    Private Sub bttn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_edit.Click
        frm_edit_savings_acct.ShowDialog()
    End Sub
End Class