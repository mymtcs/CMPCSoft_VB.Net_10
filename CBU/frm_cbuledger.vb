Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frm_cbuledger
    Dim acctgnum As String
    Dim postno As Integer = 0

    Private Sub display_sa()
        conn()
        dtgridsaving.Rows.Clear()
        sql = "select * from(select top 50 a.CBUAccount,a.Fullname,CONVERT(VARCHAR(10),a.tdate,101) As dateopen,a.status, "
        sql += "ttlcbu_bal=isnull((select (SUM(debit)-SUM(credit)) from cbuledger where active='Y' and CBUAccount=a.CBUAccount),0)"
        sql += " FROM members a WHERE a.status = 'A' AND a.Fullname LIKE '%" + txtsearch.Text + "%'"
        sql += ")x ORDER BY x.Fullname ASC"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            dtgridsaving.Rows.Add(rd("CBUAccount").ToString, rd("Fullname").ToString, Double.Parse(rd("ttlcbu_bal").ToString), Date.Parse(rd("dateopen")), rd("status").ToString.Replace("A", "Active"))
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
    End Sub

    Private Sub frmsavings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'bttnwithdrwls.Enabled = False
        'bttndeposit.Enabled = False
        display_sa()
        txtsearch.Focus()
    End Sub

    Public Sub display_ledger()
        conn()
        lstsavingledger.Items.Clear()
        sql = "select x.* from(SELECT CONVERT(VARCHAR(11),a.postingdate,101) As postingdate,postno,a.postmode,a.debit,a.credit,"
        sql += "isnull((select SUM(debit)-SUM(credit) from CBUledger where postno<=a.postno and CBUAccount=a.CBUAccount and active='Y'),0)As runbal,a.reference,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate,a.Active, a.id"
        sql += " FROM CBULedger a WHERE a.CBUAccount='" + acctgnum + "')x WHERE x.Active = 'Y'"
        sql += " GROUP BY x.postingdate,x.postmode,x.debit,x.credit,x.reference,x.remarks,x.userid,x.tdate,x.runbal,x.postno,x.Active, x.id ORDER BY x.postno"

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

        For i As Integer = 0 To lstsavingledger.Items.Count - 1

            If i Mod 2 Then
                lstsavingledger.Items(i).BackColor = Color.AliceBlue
            Else
                lstsavingledger.Items(i).BackColor = Color.White
            End If

            If lstsavingledger.Items(i).SubItems(10).Text = "N" Then
                lstsavingledger.Items(i).ForeColor = Color.Gray
                If lstsavingledger.Items(i).SubItems(10).Text = "X" Then
                    lstsavingledger.Items(i).Font = myFont
                End If
            End If
        Next
    End Sub

    Public Sub compute_ledger()
        conn()
        lstclone.Items.Clear()
        sql = "select x.* from(SELECT CONVERT(VARCHAR(11),a.postingdate,101) As postingdate,(ROW_NUMBER() OVER (ORDER BY (SELECT 1))) AS postno,a.postmode,a.debit,a.credit,"
        sql += "(select SUM(debit)-SUM(credit) from CBULedger where postno<=a.postno and CBUAccount=a.CBUAccount)As runbal,a.reference,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate "
        sql += " FROM CBULedger a WHERE a.CBUAccount='" + acctgnum + "')x"
        sql += " GROUP BY x.postingdate,x.postmode,x.debit,x.credit,x.reference,x.remarks,x.userid,x.tdate,x.runbal,x.postno ORDER BY x.postno"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstclone.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    'Private Sub lstsavingledger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstsavingledger.Click
    '    bttn_passbookledger.Enabled = True
    '    'If lstsavingledger.FocusedItem.SubItems(0).Text = systemdate And Double.Parse(lstsavingledger.FocusedItem.SubItems(3).Text) <= 0 Then
    '    If lstsavingledger.FocusedItem.SubItems(0).Text = systemdate Then
    '        bttndelete.Enabled = True
    '    Else
    '        bttndelete.Enabled = False
    '    End If
    'End Sub

    Private Sub dtgridsavings_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        display_ledger()
        'If dtgridsaving.CurrentRow.Cells(5).Value <> "Closed" And usertype = "Cashier" Then
        '    'bttndeposit.Enabled = False
        '    bttnwithdrwls.Enabled = True
        'Else
        '    'bttndeposit.Enabled = True
        '    bttnwithdrwls.Enabled = False
        'End If
    End Sub

    Private Sub bttndeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndeposit.Click
        frm_CBUdeposit.ShowDialog()
    End Sub

    Private Sub bttnwithdrwls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnwithdrwls.Click
        'If Double.Parse(dtgridsaving.CurrentRow.Cells(3).Value) <= 500 Then
        '    If MessageBox.Show("Savings account is below minimum than required. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        '        frm_withdrawals.ShowDialog()
        '    End If
        'Else
        '    frm_withdrawals.ShowDialog()
        'End If
        If usertype = "Admin" Then
            frm_CBUwithdrawals.ShowDialog()
        Else
            'conn()
            'sql = "SELECT a.status FROM loans a, members b where b.CBUAccount='" + dtgridsaving.CurrentRow.Cells(0).Value + "' and a.memcode=b.memcode and a.status='A' and released='Y'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'rd = cmd.ExecuteReader()
            'If rd.Read Then
            '    MsgBox("Attempting faild. This member has an active loans.", MsgBoxStyle.Exclamation, "Message")
            'Else
            frm_CBUwithdrawals.ShowDialog()
            'End If
            'rd.Close()
            'myConn.Close()
        End If
    End Sub

    Private Sub bttnpcover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnpcover.Click
        frm_printsavings.printSA_cover()
        frm_printsavings.crviewer.PrintReport()
    End Sub

    Private Sub bttn_passbookledger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_passbookledger.Click
        frm_cbudetails.ShowDialog()
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

    Private Sub bttnrecompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrecompute.Click
        If MessageBox.Show("Are you sure you want to recompute the CBU ledger?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            lstsavingledger.Items.Clear()
            sql = "select x.* from(SELECT a.postingdate,postno,a.postmode,a.debit,a.credit,"
            sql += "a.reference,a.remarks,a.userid,CONVERT(VARCHAR(10),a.tdate,101) As tdate,a.Active,a.id FROM CBULedger a WHERE a.CBUAccount='" + acctgnum + "' and active<>'X' "
            sql += ")x GROUP BY x.postingdate,x.postmode,x.debit,x.credit,x.reference,x.remarks,x.userid,x.tdate,x.postno,x.Active,x.id ORDER BY x.postingdate,x.id ASC"

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
                sql = "UPDATE CBULedger SET Postno=" + payno.ToString + "  WHERE Active<>'X' and CBUAccount='" + dtgridsaving.CurrentRow.Cells(0).Value + "' AND PostingDate='" + lstsavingledger.Items(i).SubItems(0).Text + "' and id=" + lstsavingledger.Items(i).SubItems(10).Text + ""
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
        If usertype <> "Cashier" Then
            bttnedit.Enabled = True
        Else
            bttnedit.Enabled = False
        End If
    End Sub

    Private Sub dtgridsavings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridsaving.Click
        'Try
        acctgnum = dtgridsaving.CurrentRow.Cells(0).Value
        display_ledger()
        'Catch ex As Exception

        'End Try
        'If dtgridsaving.CurrentRow.Cells(5).Value <> "Closed" And usertype <> "Cashier" Then
        '    bttndeposit.Enabled = True
        '    bttnwithdrwls.Enabled = True
        '    bttn_passbookledger.Enabled = True
        'Else
        '    'bttndeposit.Enabled = True
        '    bttnwithdrwls.Enabled = False
        'End If
        'If dtgridsaving.CurrentRow.Cells(5).Value <> "Closed" And usertype = "Cashier" Then
        '    bttndeposit.Enabled = True
        'Else
        '    bttndeposit.Enabled = False
        'End If
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        display_sa()
        Try
            acctgnum = dtgridsaving.CurrentRow.Cells(0).Value
            display_ledger()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetToCloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToCloseToolStripMenuItem.Click
        If dtgridsaving.CurrentRow.Cells(4).Value = "Closed" Then
            MsgBox("This CBU account is already closed.", MsgBoxStyle.Exclamation)
        Else
            conn()
            sql = "UPDATE Members SET status='X' WHERE CBUAccount='" + dtgridsaving.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            Dim reasons As String = "Set " & dtgridsaving.CurrentRow.Cells(0).Value & " to inactive."
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            display_sa()
        End If
    End Sub

    Private Sub SetAsActiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsActiveToolStripMenuItem.Click
        'If Double.Parse(dtgridsaving.CurrentRow.Cells(3).Value) > 0 Then
        If dtgridsaving.CurrentRow.Cells(4).Value = "Active" Then
            MsgBox("This CBU account is already active.", MsgBoxStyle.Exclamation)
        Else
            conn()
            sql = "UPDATE Members SET status='A' WHERE CBUAccount='" + dtgridsaving.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            Dim reasons As String = "Set " & dtgridsaving.CurrentRow.Cells(0).Value & " to active"
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            display_sa()
        End If
        'Else
        'MsgBox("This Savings Account balance is greater than zero. Failed to update", MsgBoxStyle.Exclamation, "Update failed")
        'End If
    End Sub

    Private Sub bttnedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnedit.Click
        frm_edit_cbu_ledger.ShowDialog()
    End Sub
End Class