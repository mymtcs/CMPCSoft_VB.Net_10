Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Microsoft.Office.Interop

Public Class frm_generate_savingsint
    Dim reference As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        display_user()
        SplashScreen.Close()
        bttnupload.Enabled = True
    End Sub

    Private Sub gen_saType()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM chartaccounts where Accttype='savings'  ORDER BY acct_description ASC" '
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsa.DataSource = table1
        Me.txtsa.AutoFilter = True
        txtsa.DisplayMember = "Description"
        txtsa.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsa.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsa.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsa.EditorControl.Columns(0).Width = 100
        Me.txtsa.EditorControl.Columns(1).Width = 280
        Me.txtsa.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub display_user()

        ' MsgBox(Msg, Style, Title, Help, Ctxt)
        MsgBox("I am here at Compute Savings Interest", MsgBoxStyle.Exclamation, "Compute")

        conn()
        lstsa.Items.Clear()
        sql = "select w.* from(select y.accountnumber,"
        sql += "accountname=isnull((select fullname from members where memcode=y.memcode),(select ctrname from center where accountnumber=y.accountnumber)),"
        sql += "ttlint=isnull((select sum(z.ttlint) as savint from(select ttlint=((case when (x.dtdiff<=730) then x.dtdiff else 0 end *adb)*(0.04/365)) from(select a.accountnumber,a.postno,a.postingdate,"

        ' test line here
        ' sql += "ttlint=isnull((select sum(z.ttlint) as savint from(select ttlint=((case when (x.dtdiff<=730) then x.dtdiff else 0 end *adb)*(0.09/365)) from(select a.accountnumber,a.postno,a.postingdate,"

        sql += "dtdiff=isnull((datediff(day,(select top 1 postingdate from accountledger where accountnumber=a.accountnumber and postingdate<a.postingdate order by postingdate desc),a.postingdate)),1),"
        sql += "adb=isnull((select sum(debit-credit) from accountledger where accountnumber=a.accountnumber and postingdate<=a.postingdate and active='Y'),0)"
        sql += " from accountledger a where postingdate between isnull((select top 1 postingdate from accountledger where postingdate<'" & dtfrom.Value & "' and accountnumber=y.accountnumber order by postingdate desc),(select top 1 postingdate from accountledger where accountnumber=y.accountnumber and postingdate>='" & dtfrom.Value & "' order by postingdate)) and '" & dtto.Value & "' and accountnumber=y.accountnumber)x)z),0),"

        sql += "postnum=isnull((select max(postno)+1 from accountledger where Accountnumber=y.Accountnumber),0),"
        sql += "monthdormant=isnull((select top 1 datediff(month,postingdate,getdate()) from accountledger where postmode<>'CM' and active='Y' and accountnumber=y.accountnumber order by postingdate desc),0),"
        sql += "runbalasof=isnull((select sum(debit-credit) from accountledger where accountnumber=y.accountnumber and active='Y' and postingdate<='" & dtto.Value & "'),0)"

        sql += " from accountmaster y where y.accountstatus='Active' and y.gl_sa='" & txtsa.SelectedValue & "')w where w.runbalasof>=1000 and w.ttlint>0 and w.monthdormant<=24 order by w.accountname"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()

        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstsa.Items.Add(lvitem)
            'reference = rd("ornumber")
        End While
        rd.Close()
        myConn.Close()
        lblttl.Text = 0

        For i As Integer = 0 To lstsa.Items.Count - 1

            If i Mod 2 Then
                lstsa.Items(i).BackColor = Color.AliceBlue
            Else
                lstsa.Items(i).BackColor = Color.White
            End If
            lblttl.Text = Decimal.Parse(lblttl.Text) + Decimal.Parse(lstsa.Items(i).SubItems(2).Text)
        Next
        lblttl.Text = String.Format("{0:C2}", Double.Parse(lblttl.Text))
        lblttl.Text = Replace(lblttl.Text, "$", "₱")
        lbldata.Text = lstsa.Items.Count

        MsgBox("Compute Savings Interest Done...", MsgBoxStyle.Exclamation, "Computation Done...")

    End Sub


    Private Sub ComputeInterest_user()

        ' MsgBox(Msg, Style, Title, Help, Ctxt)
        'MsgBox("I am here at Compute Savings Interest", MsgBoxStyle.Exclamation, "Compute")

        conn()
        lstsa.Items.Clear()
        sql = "select w.* from(select y.accountnumber,"
        sql += "accountname=isnull((select fullname from members where memcode=y.memcode),(select ctrname from center where accountnumber=y.accountnumber)),"
        sql += "ttlint=isnull((select sum(z.ttlint) as savint from(select ttlint=((case when (x.dtdiff<=730) then x.dtdiff else 0 end *adb)*(0.04/365)) from(select a.accountnumber,a.postno,a.postingdate,"

        ' test line here
        ' sql += "ttlint=isnull((select sum(z.ttlint) as savint from(select ttlint=((case when (x.dtdiff<=730) then x.dtdiff else 0 end *adb)*(0.09/365)) from(select a.accountnumber,a.postno,a.postingdate,"

        sql += "dtdiff=isnull((datediff(day,(select top 1 postingdate from accountledger where accountnumber=a.accountnumber and postingdate<a.postingdate order by postingdate desc),a.postingdate)),1),"
        sql += "adb=isnull((select sum(debit-credit) from accountledger where accountnumber=a.accountnumber and postingdate<=a.postingdate and active='Y'),0)"
        sql += " from accountledger a where postingdate between isnull((select top 1 postingdate from accountledger where postingdate<'" & dtfrom.Value & "' and accountnumber=y.accountnumber order by postingdate desc),(select top 1 postingdate from accountledger where accountnumber=y.accountnumber and postingdate>='" & dtfrom.Value & "' order by postingdate)) and '" & dtto.Value & "' and accountnumber=y.accountnumber)x)z),0),"

        sql += "postnum=isnull((select max(postno)+1 from accountledger where Accountnumber=y.Accountnumber),0),"
        sql += "monthdormant=isnull((select top 1 datediff(month,postingdate,getdate()) from accountledger where postmode<>'CM' and active='Y' and accountnumber=y.accountnumber order by postingdate desc),0),"
        sql += "runbalasof=isnull((select sum(debit-credit) from accountledger where accountnumber=y.accountnumber and active='Y' and postingdate<='" & dtto.Value & "'),0)"

        sql += " from accountmaster y where y.accountstatus='Active' and y.gl_sa='" & txtsa.SelectedValue & "')w where w.runbalasof>=1000 and w.ttlint>0 and w.monthdormant<=24 order by w.accountname"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100


        'Stored Procedure parameters
        '@dtfrom DATE, 
        '@dtto   DATE,
        '@gl_sa VARCHAR(MAX),
        '@InterestRate FLOAT,
        '@MaintainingBalance FLOAT

        'extract the date thru stored procedure
        Dim cmdComputeInterest As New SqlCommand

        cmdComputeInterest.Connection = myConn
        cmdComputeInterest.CommandTimeout = 300
        cmdComputeInterest.CommandType = CommandType.StoredProcedure
        cmdComputeInterest.CommandText = "usp_Compute_ADB_Interest"
        cmdComputeInterest.Parameters.AddWithValue("@dtfrom", dtfrom.Value.ToString)
        cmdComputeInterest.Parameters.AddWithValue("@dtto", dtto.Value.ToString)
        cmdComputeInterest.Parameters.AddWithValue("@gl_sa", txtsa.SelectedValue)
        cmdComputeInterest.Parameters.AddWithValue("@InterestRate", 0.04)
        cmdComputeInterest.Parameters.AddWithValue("@MaintainingBalance", 1000)

        myConn.Open()
        rd = cmdComputeInterest.ExecuteReader()

        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstsa.Items.Add(lvitem)
            'reference = rd("ornumber")
        End While
        rd.Close()
        myConn.Close()
        lblttl.Text = 0

        For i As Integer = 0 To lstsa.Items.Count - 1

            If i Mod 2 Then
                lstsa.Items(i).BackColor = Color.AliceBlue
            Else
                lstsa.Items(i).BackColor = Color.White
            End If
            lblttl.Text = Decimal.Parse(lblttl.Text) + Decimal.Parse(lstsa.Items(i).SubItems(2).Text)
        Next
        lblttl.Text = String.Format("{0:C2}", Double.Parse(lblttl.Text))
        lblttl.Text = Replace(lblttl.Text, "$", "₱")
        lbldata.Text = lstsa.Items.Count

        'MsgBox("Compute Savings Interest Done...", MsgBoxStyle.Exclamation, "Computation Done...")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnupload.Click
        If cbo_remarks.Text.Trim = "" Then
            MsgBox("Remarks cannot be empty", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtpmode.Text.Trim = "" Then
            MsgBox("Post mode cannot be empty", MsgBoxStyle.Exclamation, "Invalid")
        Else
            conn()
            sql = "DELETE FROM AccountLedger WHERE DATEPART(yyyy, postingdate)='" + dtto.Value.Year.ToString + "' and Remarks='" + cbo_remarks.Text + "' and gl_sa='" + txtsa.SelectedValue + "'"
            cmd = New SqlCommand(sql, myConn)
            cmd.CommandTimeout = 120
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            If MessageBox.Show("Are you sure you want to insert savings interest?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                conn()
                Control.CheckForIllegalCrossThreadCalls = False
                thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
                thread.Start()

                'lblttl.Text = 0
                reference = dtto.Value.ToString("M.dd.yy")
                For i As Integer = 0 To lstsa.Items.Count - 1
                    conn()
                    sql = "INSERT INTO AccountLedger(Accountnumber,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Refrence,userid,gl_sa,tdate,active) VALUES "
                    sql += "('" + lstsa.Items(i).SubItems(0).Text + "'"
                    sql += ",'" + dtto.Value + "'"
                    sql += "," + lstsa.Items(i).SubItems(3).Text + ""
                    sql += ",'" + txtpmode.SelectedValue.ToString + "'"
                    sql += "," + lstsa.Items(i).SubItems(2).Text + ""
                    sql += ",0"
                    sql += ",'" + cbo_remarks.Text + "'"
                    sql += ",'" + reference.ToString + "'"
                    sql += ",'" + user.ToString + "'"
                    sql += ",'" + txtsa.SelectedValue + "'"
                    sql += ",'" + dtto.Value + "'"
                    sql += ",'Y')"
                    cmd.CommandTimeout = 100
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                Next
                SplashScreen.Close()
                bttnupload.Enabled = False
                MsgBox("Savings interest was uploaded successfully.", MsgBoxStyle.Information, "Complete")
            End If
        End If
    End Sub

    Private Sub frm_generate_savingsint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bttnupload.Enabled = False
        dtfrom.Value = systemdate
        dtto.Value = systemdate
        select_post_mode()
        gen_saType()
    End Sub

    Private Sub select_post_mode()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT postID,postname FROM SA_postType"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("PostID")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("postID").ToString, rd("postname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtpmode.DataSource = table1
        Me.txtpmode.AutoFilter = True
        txtpmode.DisplayMember = "Description"
        txtpmode.ValueMember = "PostID"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtpmode.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtpmode.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtpmode.EditorControl.Columns(0).Width = 100
        Me.txtpmode.EditorControl.Columns(1).Width = 200
        Me.txtpmode.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub bttn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_export.Click
        'Export the listview to an Excel spreadsheet
        SaveFileDialog1.Title = "Save Excel File"
        SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        SaveFileDialog1.ShowDialog()
        'exit if no file selected
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        'create objects to interface to Excel
        Dim xls As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet
        'create a workbook and get reference to first worksheet
        xls.Workbooks.Add()
        book = xls.ActiveWorkbook
        sheet = book.ActiveSheet
        'step through rows and columns and copy data to worksheet
        Dim row As Integer = 1
        Dim col As Integer = 1
        For Each item As ListViewItem In lstsa.Items
            For i As Integer = 0 To item.SubItems.Count - 1
                sheet.Cells(row, col) = item.SubItems(i).Text
                col = col + 1
            Next
            row += 1
            col = 1
        Next
        'save the workbook and clean up
        book.SaveAs(SaveFileDialog1.FileName)
        xls.Workbooks.Close()
        xls.Quit()
        releaseObject(sheet)
        releaseObject(book)
        releaseObject(xls)
        MsgBox("Export completed.", MsgBoxStyle.Information, "Completed")
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        display_user()
        bttnupload.Enabled = True
        SplashScreen.Close()
    End Sub

    Private Sub compute()
        'lblttl.Text = 0
        'conn()
        'myConn.Open()
        'For i As Integer = 0 To lstsa.Items.Count - 1
        '    sql = "select sum(z.ttlint) as savint from(select ttlint=((x.dtdiff*runbal)*(0.04/365)) from(select a.accountnumber,"
        '    sql += "dtdiff=isnull((datediff(day,(select top 1 postingdate from accountledger where accountnumber=a.accountnumber and postingdate<a.postingdate order by postingdate desc),a.postingdate)),1),"
        '    sql += "runbal=isnull((select sum(debit-credit) from accountledger where accountnumber=a.accountnumber  and postingdate<=a.postingdate and gl_sa='" & txtsa.SelectedValue & "' and active='Y'),0)"
        '    sql += " from accountledger a where accountnumber='" & lstsa.Items(i).SubItems(0).Text & "')x)z"
        '    cmd = New SqlCommand(sql, myConn)
        '    cmd.CommandTimeout = 100
        '    rd = cmd.ExecuteReader()
        '    If rd.Read Then
        '        lstsa.Items(i).SubItems(3).Text = rd("savint")
        '    End If
        '    rd.Close()
        '    lblttl.Text = Double.Parse(lblttl.Text) + Double.Parse(lstsa.Items(i).SubItems(3).Text)
        'Next
        'lblttl.Text = String.Format("{0:C2}", Double.Parse(lblttl.Text))
        'lblttl.Text = Replace(lblttl.Text, "$", "₱")
        'lbldata.Text = lstsa.Items.Count
        'myConn.Close()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        pncomputed.Visible = True
        lblaccount.Text = lstsa.FocusedItem.SubItems(0).Text
        conn()
        sql = "select z.* from(select x.*,ttlint=((x.dtdiff*adb)*(0.04/365)) from(select a.postno,a.postingdate,"
        sql += "dtdiff=isnull((datediff(day,(select top 1 postingdate from accountledger where accountnumber=a.accountnumber and postingdate<a.postingdate order by postingdate desc),a.postingdate)),1),"
        sql += "adb=isnull((select sum(debit-credit) from accountledger where accountnumber=a.accountnumber and postingdate<=a.postingdate and gl_sa='" & txtsa.SelectedValue & "' and active='Y'),0)"
        sql += " from accountledger a where postingdate between "
        sql += " isnull((select top 1 postingdate from accountledger where postingdate<'" & dtfrom.Value & "' and accountnumber='" & lblaccount.Text & "' order by postingdate desc),(select top 1 postingdate from accountledger where accountnumber='" & lblaccount.Text & "' order by postingdate))"
        sql += " and '" & dtto.Value & "' and accountnumber='" & lblaccount.Text & "')x where x.dtdiff<=730)z"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        lstadb.Items.Clear()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstadb.Items.Add(lvitem)
            'reference = rd("ornumber")
        End While
        rd.Close()
        myConn.Close()

        lbltotalcomp.Text = 0
        For i As Integer = 0 To lstadb.Items.Count - 1
            lbltotalcomp.Text = Double.Parse(lbltotalcomp.Text) + Double.Parse(lstadb.Items(i).SubItems(4).Text)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pncomputed.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeInt.Click
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        'display_user() - old computation
        ComputeInterest_user() 'new computation with stored procedure
        bttnupload.Enabled = True
        SplashScreen.Close()
    End Sub
End Class