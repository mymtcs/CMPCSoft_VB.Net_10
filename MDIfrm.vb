Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Public Class MDIfrm
    ' NEW ADD SQL CONTROL
    Public cSQL As New SQLControl



    Public Tray As NotifyIcon
    Const marqueeText As String = " We Make Things Happen..        "
    Dim sb As New System.Text.StringBuilder
    Dim direction As Boolean = True 'true = left to right, false = right to left
    Dim count As Integer = 0
    Dim path As String
    Dim int As Integer = 0
    Public Event InfoMessage As SqlInfoMessageEventHandler
    'Usage
    Dim instance As SqlConnection
    Dim handler As SqlInfoMessageEventHandler

    Private Sub view_member()
        ListView1.Items.Clear()
        conn()
        sql = "SELECT a.pnnumber,b.pnnumber,b.markup FROM loans a, loanitems b where a.pnnumber=b.pnnumber"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            ListView1.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub view_savings()
        ListView3.Items.Clear()
        conn()
        sql = "SELECT * FROM dummy"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            ListView3.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub MDIfrm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

    End Sub

    'Private Sub view_point()
    '    ListView2.Items.Clear()
    '    conn()
    '    sql = "select * from("
    '    sql += "select x.pnnumber,x.LnNum,x.lastprndue,x.lastintdue,(x.loanamnt-(x.ttlamntdue+x.ItemMarkup)) as prnpoint,(x.Itemmarkup-(x.ttlintdue-x.interestdue)) as intpoint from(select a.loanamnt,a.ItemMarkup,a.pnnumber,a.fullname,a.interestdue,"
    '    sql += "ttlamntdue=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
    '    sql += "lastprndue=isnull((select top 1 principal from loansched where pnnumber=a.pnnumber order by duedate desc),0),"
    '    sql += "lastintdue=isnull((select top 1 interest from loansched where pnnumber=a.pnnumber order by duedate desc),0),"
    '    sql += "LnNum=isnull((select top 1 LnNum from loansched where pnnumber=a.pnnumber order by duedate desc),0),"
    '    sql += "ttlintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0)"
    '    sql += " from loans a where a.status='O'"
    '    sql += ")x"
    '    sql += ")y where y.intpoint between -0.4 and 0.4 or y.prnpoint between -0.4 and 0.4"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While (rd.Read())
    '        If rd("prnpoint") <> 0 Or rd("intpoint") <> 0 Then
    '            Dim lvitem As New ListViewItem(rd(0).ToString())
    '            For i As Integer = 1 To rd.FieldCount - 1
    '                lvitem.SubItems.Add(rd(i).ToString())
    '            Next
    '            ListView2.Items.Add(lvitem)
    '        End If

    '    End While
    '    Button1.Text = ListView2.Items.Count
    '    rd.Close()
    '    myConn.Close()
    'End Sub

    'Private Sub view_loancollect()
    '    ListView2.Items.Clear()
    '    conn()
    '    sql = "select pnnumber,payno,principal,advprincipal,prnpaid from loancollect"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While (rd.Read())
    '        Dim lvitem As New ListViewItem(rd(0).ToString())
    '        For i As Integer = 1 To rd.FieldCount - 1
    '            lvitem.SubItems.Add(rd(i).ToString())
    '        Next
    '        ListView2.Items.Add(lvitem)
    '    End While
    '    Button1.Text = ListView2.Items.Count
    '    rd.Close()
    '    myConn.Close()
    'End Sub

    Private Sub MDIfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If usertype = "Administrator" Or usertype = "Bookkeeper" Then
            link_duplicates.Enabled = True
        End If

        'If My.Computer.Registry.GetValue("HKEY_USERS\.DEFAULT", "isInstalled", Nothing) Is Nothing Then
        '    MsgBox("There are missing files in registry. Reinstalling this software could fix this problem.", MsgBoxStyle.Information, "Message")
        '    Me.Close()
        'End If

        '// show login screen
        loginfrm.ShowDialog()

        lblserver.Text = loginfrm.txtserver.Text
        lbluser.Text = loginfrm.txtuser.Text
        'lblloantype.Text = GL_loans.ToString
        lblbranch.Text = branch.ToString
        lblsysdate.Text = DateTime.Today ' loginfrm.check.ToString("MM/dd/yyyy")
        systemdate = Date.Parse(lblsysdate.Text).ToString("M/d/yyyy")
        lblusertype.Text = usertype.ToString

        setup_user_controls()
        'update_status()
        'update_loanded()
        'view_point()
        'view_loancollect()
        Me.Text = "CMPCsoft Ver. " & My.Application.Info.Version.ToString
        timer_capslockstatus.Start()
        'Control.CheckForIllegalCrossThreadCalls = False
        'thread = New System.Threading.Thread(AddressOf InitializePie1)
        'thread.Start()
        InitializePie1()
        'InitializePie2()
        m_user.Enabled = True
        m_user_controls.Enabled = True
        If usertype = "Cashier" Then
            bttn_comp_savings_int.Enabled = False
        End If
        If usertype = "Bookkeeper" Then
            rp_cashiersblotter.Enabled = True
            bttn_cahier_teller.Enabled = False
            frm_cashiering.grp1.Enabled = False
            frm_cashiering.ContextMenuStrip1.Enabled = False
            frm_cashiering.ContextMenuStrip2.Enabled = False
        End If
        If usertype = "Accounting" Then
            bttn_cahier_teller.Enabled = False
            rp_cashiersblotter.Enabled = False
        End If
        If usertype = "Admin" Then
            bttn_query.Enabled = True
            bttn_cahier_teller.Enabled = True
        Else
            bttn_query.Enabled = False
        End If
        If usertype = "Audit" Then
            'bttn_cahier_teller.Enabled = False
            'bttn_menu.Enabled = False
            bttnloan_entry.Enabled = False
            bttnitem_stocks.Enabled = False
            bttnofficer.Enabled = False
            bttngrp_posting.Enabled = False
            bttnrel_stocks.Enabled = False
        End If

        ' BUTTON FOR BACKUP DATABASE
        'bttn_backup_db.Enabled = False
        bttn_backup_db.Enabled = True

        If loginfrm.txtserver.Text = System.Environment.MachineName.ToString Or loginfrm.txtserver.Text = System.Environment.MachineName.ToString & "\SQLEXPRESS" _
            Or loginfrm.txtserver.Text = System.Environment.MachineName.ToString & "\MYSERVER" Then
            bttn_backup_db.Enabled = True
        End If
    End Sub

    Private Sub update_loanded()
        conn()
        sql = "UPDATE deductionMF set description='Credit Insurance' WHERE description like '%Ben life%'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub setup_user_controls()
        Dim dgv As New DataGridView
        Dim nc As New DataGridViewTextBoxColumn
        nc.Name = "Column"
        dgv.Columns.Add(nc)

        conn()
        sql = "select * from UserControls WHERE userID='" + user + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            dgv.Rows.Add(rd("navigationID"))
            Me.Controls.Add(dgv)
        End While
        rd.Close()
        myConn.Close()
        For i As Integer = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = 1 Then
                frm_collectingofficer.dtgrid_collector.ReadOnly = True
            End If
            If dgv.Rows(i).Cells(0).Value = 2 Then
                bttnmembers.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 3 Then
                bttncenter.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 4 Then
                bttnitem_stocks.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 5 Then
                bttnprovince.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 6 Then
                frm_chartAccounts.dtgrid_chartaccounts.ReadOnly = True
            End If
            If dgv.Rows(i).Cells(0).Value = 7 Then
                bttnrel_stocks.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 8 Then
                bttnloan_entry.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 9 Then
                bttngrp_posting.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 10 Then
                bttnsavings.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 11 Then
                bttn_cahier_teller.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 12 Then
                bttnbanking.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 13 Then
                rp_members.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 14 Then
                rp_loans.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 15 Then
                rp_savings.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 16 Then
                rp_par.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 17 Then
                rp_delenq_payment.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 18 Then
                rp_collsheet.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 19 Then
                rp_currentstocks.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 20 Then
                rp_stockrelease.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 21 Then
                rpt_progressreport.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 22 Then
                rp_cashiersblotter.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 23 Then
                rp_rev_fund.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 24 Then
                rp_loans_forapprv.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 25 Then
                rp_loanrel.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 26 Then
                'rp_incentives.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 27 Then
                rp_progress_rep.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 28 Then
                rp_stocks_status.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 29 Then
                rp_collstatus.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 30 Then
                rp_journal.Enabled = False
            End If

            If dgv.Rows(i).Cells(0).Value = 31 Then
                rp_gledger.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 32 Then
                rp_trialbal.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 33 Then
                frm_members.bttndeletepayment.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 34 Then
                bttnchangepass.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 35 Then
                bttn_backup_db.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 36 Then
                frm_savings.bttndeposit.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 37 Then
                frm_savings.bttnwithdrwls.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 38 Then
                frm_newloanlist.bttnrel.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 39 Then
                frm_members.bttndeletepayment.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 40 Then
                frm_savings.bttnrecompute.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 41 Then
                'frm_savings.bttnrecompute.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 42 Then
                frm_members.bttnpost.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 43 Then
                frm_members.bttnnew.Enabled = False
                frm_members.bttnedit.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 44 Then
                frm_newloanlist.bttnnew.Enabled = False
            End If

            If dgv.Rows(i).Cells(0).Value = 45 Then
                'm_loandeduction.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 46 Then
                'bttn_cbu.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 47 Then
                'm_loantype.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 48 Then
                m_user_controls.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 49 Then
                m_user.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 50 Then
                m_transferacct.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 51 Then
                frm_members.bttnweave.Enabled = False
            End If
            If dgv.Rows(i).Cells(0).Value = 52 Then
                ' bttnnew_genjournal.Enabled = False
            End If
        Next
    End Sub

    Private Sub ProductAssistantToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PARAgingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frm_prov.Show()
    End Sub

    Private Sub MDIfrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If MessageBox.Show("Are you sure you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        '    e.Cancel = True
        'End If
        End
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub marquee_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marquee.Tick
        If sb.Length = 0 Then sb.Append(marqueeText)
        If direction Then
            sb.Insert(0, sb(sb.Length - 1))
            sb.Remove(sb.Length - 1, 1)
        Else
            sb.Append(sb(0))
            sb.Remove(0, 1)
        End If
        Me.Text = "Coolway MultiPurpose Cooperative   " & sb.ToString
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_deletepyment.Show()
    End Sub

    Private Sub lblchangepass_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        frm_sys_users.ShowDialog()
    End Sub

    Private Sub bttnofficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnofficer.Click
        frm_collectingofficer.MdiParent = Me
        pnmain.Controls.Add(frm_collectingofficer)
        frm_collectingofficer.Show()
        'collfrm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_collectingofficer.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnmembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnmembers.Click
        'select_paidup()
        'update_status()
        frm_members.MdiParent = Me
        pnmain.Controls.Add(frm_members)
        frm_members.Show()
        'frm_members.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_members.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttngrp_posting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngrp_posting.Click
        frm_grpposting.MdiParent = Me
        pnmain.Controls.Add(frm_grpposting)
        frm_grpposting.Show()
        'frm_grpposting.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_grpposting.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttncenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncenter.Click
        frm_center.MdiParent = Me
        pnmain.Controls.Add(frm_center)
        frm_center.Show()
        'frm_center.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_center.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub update_status()
        conn()
        sql = "UPDATE loans SET status='O' WHERE pnnumber in(select y.pnnumber from("
        sql += "select x.pnnumber,x.status,((x.prnamnt+x.intamnt)-(x.TotalPrnPaid+x.TotalintPaid))as Loanbal from ("
        sql += " select a.pnnumber,a.status,(a.loanamnt) As loanamnt,a.interestdue,"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<=getdate() and cancel='N' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<=getdate() and cancel='N' AND pnnumber=a.pnnumber),0)"
        sql += "from Loans a where a.status='A' and a.released='Y')x )y where y.Loanbal <=0)"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub bttnitem_stocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnitem_stocks.Click
        frm_items.MdiParent = Me
        pnmain.Controls.Add(frm_items)
        frm_items.Show()
        'frm_items.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_items.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnprovince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnprovince.Click
        frm_address.MdiParent = Me
        pnmain.Controls.Add(frm_address)
        frm_address.Show()
        'frm_barangay.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_address.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnaccount_titles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnaccount_titles.Click
        'frm_chartAccounts.MdiParent = Me
        'pnmain.Controls.Add(frm_chartAccounts)
        'frm_chartAccounts.Show()
        ''frm_accountype.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'frm_chartAccounts.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnrel_stocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrel_stocks.Click
        frm_rel_stock_list.MdiParent = Me
        pnmain.Controls.Add(frm_rel_stock_list)
        frm_rel_stock_list.Show()
        'frm_accountype.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_rel_stock_list.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnsavings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsavings.Click
        frm_savings.MdiParent = Me
        pnmain.Controls.Add(frm_savings)
        frm_savings.Show()
        'frm_savings.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_savings.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_cahier_teller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cahier_teller.Click
        frm_cashiering.MdiParent = Me
        pnmain.Controls.Add(frm_cashiering)
        frm_cashiering.Show()
        'frm_cashiering.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_cashiering.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnchangepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnchangepass.Click
        frm_sys_users.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        view_member()
    End Sub

    Private Sub update_point()
        'For i As Integer = 0 To ListView2.Items.Count - 1
        '    Dim prn As Decimal = Double.Parse(ListView2.Items(i).SubItems(2).Text) + Double.Parse(ListView2.Items(i).SubItems(4).Text)
        '    Dim int As Decimal = Double.Parse(ListView2.Items(i).SubItems(3).Text) + Double.Parse(ListView2.Items(i).SubItems(5).Text)
        '    conn()
        '    sql = "update loansched set principal=" + prn.ToString + ",interest=" + int.ToString + " where pnnumber='" + ListView2.Items(i).SubItems(0).Text + "' and lnnum=" + ListView2.Items(i).SubItems(1).Text + ""
        '    cmd = New SqlCommand(sql, myConn)
        '    myConn.Open()
        '    cmd.ExecuteNonQuery()
        '    myConn.Close()
        'Next

        For i As Integer = 0 To ListView2.Items.Count - 1
            Dim prn As Decimal = Double.Parse(ListView2.Items(i).SubItems(3).Text) + Double.Parse(ListView2.Items(i).SubItems(4).Text)
            conn()
            sql = "update loancollect set principal=" + prn.ToString + ",advprincipal=0 where pnnumber='" + ListView2.Items(i).SubItems(0).Text + "' and payno=" + ListView2.Items(i).SubItems(1).Text + ""
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Next
    End Sub

    Private Sub RadButtonElement2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_backup_db.Click
        If MessageBox.Show("Click yes to backup database.", "Database Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            SplashScreen.count = 0
            Control.CheckForIllegalCrossThreadCalls = False

            thread = New System.Threading.Thread(AddressOf BackupDBSplashScreen.ShowDialog)
            thread.Start()
            'Try
            Dim strpath As String
            Dim backupfull As String
            Dim backupinit As String

            path = System.IO.Path.GetDirectoryName( _
              System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
            strpath = path & "\Backup"
            strpath = strpath.ToString.Replace("file:\", "")

            Try
                backupfull = strpath & "\#Coolw@yDB.bak"
                conn()
                sql = "BACKUP DATABASE #Coolw@yDB"
                sql += " TO DISK = '" + backupfull.ToString + "' "
                sql += "with STATS = 1 "
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.CommandTimeout = 1000
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Error on backuping full database from date " & lblsysdate.Text & "','" + lblsysdate.Text + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End Try

            Try
                backupinit = strpath & "\#Coolw@yDB_init.bak"
                conn()
                sql = "BACKUP DATABASE #Coolw@yDB"
                sql += " TO DISK = '" + backupinit.ToString + "' "
                sql += "WITH INIT "
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.CommandTimeout = 1000
                cmd.ExecuteNonQuery()
                'MsgBox("Backup complete", MsgBoxStyle.Information, "Completed")
                'BackupDBSplashScreen.Close()
                BackupDBSplashScreen.lbl_back.Text = "Backup Completed..."
                BackupDBSplashScreen.bttnok.Visible = True
                BackupDBSplashScreen.lblprocess.Visible = False
                BackupDBSplashScreen.picload.Enabled = False
            Catch ex As Exception
                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Error on initial database from date " & lblsysdate.Text & "','" + lblsysdate.Text + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                BackupDBSplashScreen.lblprocess.Text = "Error :" & ex.Message
                BackupDBSplashScreen.bttnok.Visible = True
            End Try
            myConn.Close()


            'AddHandler myConn.InfoMessage, New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)
        End If

    End Sub

    Private Sub OnInfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)
        MsgBox(e.Message, MsgBoxStyle.Information, "Backup Complete")
    End Sub

    Private Sub rp_loans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_loans.Click
        frm_masterlist_loans.MdiParent = Me
        pnmain.Controls.Add(frm_masterlist_loans)
        frm_masterlist_loans.Show()
        frm_masterlist_loans.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_par_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_par.Click
        'frm_PAR.MdiParent = Me
        'pnmain.Controls.Add(frm_PAR)
        'frm_PAR.Show()
        'frm_PAR.WindowState = FormWindowState.Maximized
        frm_matured_loans.MdiParent = Me
        pnmain.Controls.Add(frm_matured_loans)
        frm_matured_loans.Show()
        frm_matured_loans.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_delenq_payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_delenq_payment.Click
        frm_delinquency.MdiParent = Me
        pnmain.Controls.Add(frm_delinquency)
        frm_delinquency.Show()
        frm_delinquency.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_collsheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_collsheet.Click
        frm_collectionsheet.MdiParent = Me
        pnmain.Controls.Add(frm_collectionsheet)
        frm_collectionsheet.Show()
        frm_collectionsheet.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_currentstocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_currentstocks.Click
        frm_stocks_report.MdiParent = Me
        pnmain.Controls.Add(frm_stocks_report)
        frm_stocks_report.Show()
        frm_stocks_report.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_cashiersblotter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_cashiersblotter.Click
        If usertype = "Bookkeeper" Or usertype = "Admin" Or usertype = "Accounting" Then
            frm_cb_reports.MdiParent = Me
            pnmain.Controls.Add(frm_cb_reports)
            frm_cb_reports.Show()
            frm_cb_reports.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub rp_loans_forapprv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_loans_forapprv.Click
        frm_loantoberel.MdiParent = Me
        pnmain.Controls.Add(frm_loantoberel)
        frm_loantoberel.Show()
        frm_loantoberel.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_loanrel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_loanrel.Click
        'conn()
        'sql = "select a.pnnumber from loansdeduction a,loans b where a.pnnumber=b.pnnumber and b.gl_loans='" + GL_loans + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader
        'If rd.Read Then
        frm_loanrel.MdiParent = Me
        pnmain.Controls.Add(frm_loanrel)
        frm_loanrel.Show()
        frm_loanrel.WindowState = FormWindowState.Maximized
        'Else
        '    frm_loanrel_consumable.MdiParent = Me
        '    pnmain.Controls.Add(frm_loanrel_consumable)
        '    frm_loanrel_consumable.Show()
        '    frm_loanrel_consumable.WindowState = FormWindowState.Maximized
        'End If
        'rd.Close()
        'myConn.Close()
    End Sub

    Private Sub rp_incentives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_profile_by_gender.MdiParent = Me
        pnmain.Controls.Add(frm_profile_by_gender)
        frm_profile_by_gender.Show()
        frm_profile_by_gender.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_loanscoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_loanscoll.Click
        frm_abstractofcoll.MdiParent = Me
        pnmain.Controls.Add(frm_abstractofcoll)
        frm_abstractofcoll.Show()
        frm_abstractofcoll.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_savingscoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_savingscoll.Click
        frm_abstractsavings.MdiParent = Me
        pnmain.Controls.Add(frm_abstractsavings)
        frm_abstractsavings.Show()
        frm_abstractsavings.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_progress_rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_progress_rep.Click
        frm_progres_bar.MdiParent = Me
        pnmain.Controls.Add(frm_progres_bar)
        frm_progres_bar.Show()
        frm_progres_bar.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_stockrelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_stockrelease.Click
        frm_abstractofstocks_rel.MdiParent = Me
        pnmain.Controls.Add(frm_abstractofstocks_rel)
        frm_abstractofstocks_rel.Show()
        frm_abstractofstocks_rel.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_manageloanterms.ShowDialog()
    End Sub

    Private Sub RadMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_loandeduction.Click
        frm_loans_deduction.ShowDialog()
    End Sub

    Private Sub rp_savings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_savings.Click
        frm_masterlistSA.MdiParent = Me
        pnmain.Controls.Add(frm_masterlistSA)
        frm_masterlistSA.Show()
        frm_masterlistSA.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_members_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_members.Click
        frm_masterlist_members.MdiParent = Me
        pnmain.Controls.Add(frm_masterlist_members)
        frm_masterlist_members.Show()
        frm_masterlist_members.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub RadMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_loantype.Click
        frm_manageloantype.ShowDialog()
    End Sub

    Private Sub RadMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_user.Click
        frm_sys_user.ShowDialog()
    End Sub

    Private Sub bttn_user_controls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_user_controls.Click
        check_usercontrol_password.ShowDialog()
    End Sub

    Private Sub m_importdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_importdata.Click
        frm_importdata.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For i As Integer = 0 To ListView3.Items.Count - 1
    '        If ListView3.Items(i).SubItems(0).Text <> "" Then
    '            conn()
    '            sql = "update loans set grpcode=" + ListView3.Items(i).SubItems(0).Text.ToString + " where pnnumber ='" + ListView3.Items(i).SubItems(1).Text + "'"
    '            cmd = New SqlCommand(sql, myConn)
    '            myConn.Open()
    '            cmd.ExecuteNonQuery()
    '            myConn.Close()
    '        End If
    '    Next
    'End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i As Integer = 0 To ListView3.Items.Count - 1
            If ListView3.Items(i).SubItems(0).Text <> "" Then
                conn()
                sql = "update loans set grpcode=" + ListView3.Items(i).SubItems(0).Text.ToString + " where pnnumber ='" + ListView3.Items(i).SubItems(1).Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub rp_progressreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem1.Click
        'frm_utilities.Show()
        frm_utilities.MdiParent = Me
        pnmain.Controls.Add(frm_utilities)
        frm_utilities.Show()
        frm_utilities.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_uploadsavings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_uploadsavings.Click
        frm_upload_savings.MdiParent = Me
        pnmain.Controls.Add(frm_upload_savings)
        frm_upload_savings.Show()
        'frm_accountype.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_upload_savings.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnareaname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnareaname.Click
        frm_company_manager.ShowDialog()
    End Sub

    Private Sub pie_members_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pie_members.Click
        InitializePie1()
    End Sub

    Private Sub bttn_cbu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_cbu.Click
        frm_cbuledger.MdiParent = Me
        pnmain.Controls.Add(frm_cbuledger)
        frm_cbuledger.Show()
        frm_cbuledger.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_gen_savingsint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rp_bygender_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rp_bygender.Click
        frm_profile_by_gender.MdiParent = Me
        pnmain.Controls.Add(frm_profile_by_gender)
        frm_profile_by_gender.Show()
        frm_profile_by_gender.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_byage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rp_byage.Click
        frm_profile_by_age.MdiParent = Me
        pnmain.Controls.Add(frm_profile_by_age)
        frm_profile_by_age.Show()
        frm_profile_by_age.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rp_byincome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rp_byincome.Click
        frm_profile_by_occupation.MdiParent = Me
        pnmain.Controls.Add(frm_profile_by_occupation)
        frm_profile_by_occupation.Show()
        frm_profile_by_occupation.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub timer_capslockstatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_capslockstatus.Tick
        capslock_status()
    End Sub

    Private Sub rp_membersloans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rp_membersloans.Click
        frm_loanavailment.MdiParent = Me
        pnmain.Controls.Add(frm_loanavailment)
        frm_loanavailment.Show()
        frm_loanavailment.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_savings.Show()
    End Sub

    Private Sub rp_collstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_collstatus.Click
        frm_masterlist.MdiParent = Me
        pnmain.Controls.Add(frm_masterlist)
        frm_masterlist.Show()
        frm_masterlist.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub picmain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmain.Click

    End Sub

    Private Sub RadButtonElement12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement12.Click
        frm_logs.MdiParent = Me
        pnmain.Controls.Add(frm_logs)
        frm_logs.Show()
        frm_logs.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_cbu_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cbu_report.Click
        frm_masterlistCBU.MdiParent = Me
        pnmain.Controls.Add(frm_masterlistCBU)
        frm_masterlistCBU.Show()
        frm_masterlistCBU.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub viewupdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewhelp.Click
        frm_help.MdiParent = Me
        pnmain.Controls.Add(frm_help)
        frm_help.Show()
        frm_help.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub rpt_progressreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_progressreport.Click
        frm_progress_report.MdiParent = Me
        pnmain.Controls.Add(frm_progress_report)
        frm_progress_report.Show()
        frm_progress_report.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub m_setup_subproduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_setup_subproduct.Click
        frm_setup_subproduct.ShowDialog()
    End Sub

    Private Sub bttn_ssscont_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_ssscont.Click
        frm_upload_sss.MdiParent = Me
        pnmain.Controls.Add(frm_upload_sss)
        frm_upload_sss.Show()
        frm_upload_sss.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_sssmaster_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_sssmaster.Click
        frm_sss_masterFile.MdiParent = Me
        pnmain.Controls.Add(frm_sss_masterFile)
        frm_sss_masterFile.Show()
        frm_sss_masterFile.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnsssmasterlist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnsssmasterlist.Click
        frm_masterlistSS.MdiParent = Me
        pnmain.Controls.Add(frm_masterlistSS)
        frm_masterlistSS.Show()
        frm_masterlistSS.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_randompassword.ShowDialog()
    End Sub

    Private Sub RadButtonElement14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement14.Click
        frm_LHcoll.MdiParent = Me
        pnmain.Controls.Add(frm_LHcoll)
        frm_LHcoll.Show()
        frm_LHcoll.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_exportcbuavg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_exportcbuavg.Click
        frm_CBUavg.ShowDialog()
    End Sub

    Private Sub bttnimportcbudividen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnimportcbudividen.Click
        frm_importCBUdividen.ShowDialog()
    End Sub

    Private Sub rpt_ctrincentives_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpt_ctrincentives.Click
        frm_ctr_incentives.MdiParent = Me
        pnmain.Controls.Add(frm_ctr_incentives)
        frm_ctr_incentives.Show()
        frm_ctr_incentives.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_query_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_query.Click
        frm_query.ShowDialog()
    End Sub

    Private Sub RadButtonElement15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement15.Click
        frm_updates.MdiParent = Me
        pnmain.Controls.Add(frm_updates)
        frm_updates.Show()
        frm_updates.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_comp_savings_int_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_comp_savings_int.Click
        check_savingsinterest_password.ShowDialog()
    End Sub

    Private Sub lblsysdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsysdate.Click
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then
            frm_change_Date.ShowDialog()
        End If
    End Sub

    Private Sub bttnloan_entry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnloan_entry.Click

    End Sub

    Private Sub bttn_newloan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_newloan.Click
        'select_paidup()
        'update_status()
        frm_newloanlist.MdiParent = Me
        pnmain.Controls.Add(frm_newloanlist)
        frm_newloanlist.Show()
        'frm_newloanlist.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_newloanlist.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttn_restructuring_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_restructuring.Click
        frm_restructured_loan.MdiParent = Me
        pnmain.Controls.Add(frm_restructured_loan)
        frm_restructured_loan.Show()
        frm_restructured_loan.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadButtonElement17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement17.Click
        'select_paidup()
        'update_status()
        frm_newloanlist.MdiParent = Me
        pnmain.Controls.Add(frm_newloanlist)
        frm_newloanlist.Show()
        'frm_newloanlist.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm_newloanlist.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bttnexport_SMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnexport_SMS.Click
        frm_export_payment_forSMS.ShowDialog()
    End Sub

    Private Sub link_duplicates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles link_duplicates.Click
        frm_duplicates.ShowDialog()
    End Sub

    Private Sub rp_trialbal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_trialbal.Click

    End Sub

    Private Sub rp_age_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp_age_profile.Click
        frm_age_profile.MdiParent = Me
        pnmain.Controls.Add(frm_age_profile)
        frm_age_profile.Show()
        frm_age_profile.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_transferacct.Click
        frm_transferAccount.ShowDialog()
    End Sub

    Private Sub RadMenuItem3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem3.Click
        conn()
        sql = "SELECT CYear FROM MemberCode WHERE CYear = '" & DateTime.Now.Year.ToString & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            MessageBox.Show("Operation failed. This problem is already fixed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            rd.Close()
            myConn.Close()
            conn()
            sql = "INSERT INTO Membercode(LastMemCode,CYear)Values('000000','" + DateTime.Now.Year.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Problem fixed! You can now create a new member.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myConn.Close()
        End If
    End Sub

    Private Sub RadMenuItem4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem4.Click
        conn()
        sql = "USE #Coolw@yDB; EXEC sp_updatestats"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Problem fixed! You can now generate a newly transferred Product Assistant!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        myConn.Close()
    End Sub

    Private Sub bttnbanking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnbanking.Click

    End Sub

    Private Sub mainribbon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainribbon.Click

    End Sub
End Class
