Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_members
    Dim c1 As Integer = 1
    Dim c2 As Integer = 4
    Public cLoanNumber As String




    Private Sub frmmembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboletter.Text = "A"
        view_member()
        If usertype = "Admin" Or usertype = "Bookkeeper" Then
            MergeThisMembersToolStripMenuItem.Enabled = True
        Else
            MergeThisMembersToolStripMenuItem.Enabled = False
        End If
        If usertype = "Audit" Then
            bttnpost.Enabled = False
            bttnnew.Enabled = False
            bttnedit.Enabled = False
            bttn_cancel.Enabled = False
        End If
    End Sub

    Public Sub view_member()
        conn()
        dtgridmember.Rows.Clear()
        If chkview.Checked = False Then
            sql = "SELECT a.MemCode,a.Fullname,a.Address,a.gender,CONVERT(VARCHAR(10),a.Birthdate,101) As Birthdate,"
            sql += "isnull((select occupdesc from occupation where occupcode=a.occupcode),'None') as occupdesc, "
            sql += "isnull((select COUNT(Memcode) FROM Loans WHERE Memcode=a.Memcode),0) as cloans"
            sql += " FROM Members a WHERE a.fullname LIKE '" + cboletter.Text + "%' and a.status='A' ORDER BY a.fullname ASC"
        Else
            sql = "SELECT a.MemCode,a.Fullname,a.Address,a.gender,CONVERT(VARCHAR(10),a.Birthdate,101) As Birthdate,isnull((select occupdesc from occupation where occupcode=a.occupcode),'None') as occupdesc FROM Members a WHERE a.fullname LIKE '" + cboletter.Text + "%' and a.status='X' ORDER BY a.fullname ASC"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            If rd("cloans").ToString >= 5 Then
                dtgridmember.Rows.Add(rd("MemCode").ToString, rd("Fullname").ToString, rd("Address").ToString.Replace("Undefined", ""), rd("gender").ToString, rd("Birthdate").ToString, rd("occupdesc").ToString)
            Else
                dtgridmember.Rows.Add(rd("MemCode").ToString, rd("Fullname").ToString, rd("Address").ToString.Replace("Undefined", ""), rd("gender").ToString, rd("Birthdate").ToString, rd("occupdesc").ToString)
            End If


        End While
        rd.Close()
        myConn.Close()
        For x As Integer = 0 To dtgridmember.Rows.Count - 1
            If x Mod 2 Then
                dtgridmember.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Dim row As DataGridViewRow = dtgridmember.Rows(x)
            row.Height = 30
        Next
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        view_member()
    End Sub

    Private Sub view_loan_products()
        'MessageBox.Show("view_loan_products")
        Try
            Dim row As DataRow = Nothing
            Dim connection As SqlConnection
            Dim adapter As SqlDataAdapter
            Dim command As New SqlCommand

            Dim ds As New DataSet
            Dim dsr As New DataSet

            connection = New SqlConnection(constr)

            connection.Open()
            command.Connection = connection
            command.CommandTimeout = 300
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "usp_gen_loantype"

            command.Parameters.AddWithValue("@memcode", dtgridmember.CurrentRow.Cells(0).Value)
            command.Parameters.AddWithValue("@trnxdate", DateTime.Today)

            adapter = New SqlDataAdapter(command)
            adapter.Fill(dsr)
            dtgrid_products.Rows.Clear()
            For i = 0 To dsr.Tables(0).Rows.Count - 1
                dtgrid_products.Rows.Add(dsr.Tables(0).Rows(i).Item(0), dsr.Tables(0).Rows(i).Item(1), dsr.Tables(0).Rows(i).Item(2), dsr.Tables(0).Rows(i).Item(3))
            Next
            connection.Close()

            For x As Integer = 0 To dtgrid_products.Rows.Count - 1
                If x Mod 2 Then
                    dtgrid_products.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
                Dim rows As DataGridViewRow = dtgrid_products.Rows(x)
                rows.Height = 35
            Next
            pn_load.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub view_loan_lists()
        'Try
        'note: modified this function becase of improper sorting...
        'add a additional ORDER BY command at the query...
        'requested by TOLEDO branch
        ' query added: " ORDER BY RowNumber ASC "

        'display the loan list data
        'MessageBox.Show("View_Loan_Lists()")
        'MessageBox.Show(c1.ToString)
        'MessageBox.Show(c2.ToString)

        'member code
        'MessageBox.Show(dtgridmember.CurrentRow.Cells(0).Value)

        'gl_loans
        'MessageBox.Show(dtgrid_products.CurrentRow.Cells(0).Value)
        'MessageBox.Show("view_loan_lists()")

        bttnperformace.Enabled = True
        dtgridloan_list.Rows.Clear()
        conn()
        sql = "select x.*,((x.principal+x.interest)-x.ttlamntpaid) as runningbal from(SELECT "
        sql += "ROW_NUMBER() OVER (ORDER BY a.status, releasedate desc) AS 'RowNumber',"
        sql += "a.pnnumber,a.loanamnt,a.Accountnumber,b.fullname,CONVERT(VARCHAR(10),a.releasedate,101) As reldate,a.releasedate,CONVERT(VARCHAR(10),a.maturitydate,101) As matdate,a.ctrcode,a.grpcode,a.status,a.released,a.interestdue, "
        sql += "subproduct=isnull((select Description from subproducts where code=a.subproductcode),''),"
        sql += "principal=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interest=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
        sql += "loancount=isnull((select count(memcode) from loans where memcode=a.memcode and gl_loans=a.gl_loans),0),"
        sql += "ttlamntpaid=isnull((select sum(principal+advprincipal+intpaid+advinterest) from loancollect where pnnumber=a.pnnumber),0)"
        sql += " FROM Loans a, members b WHERE a.MemCode=b.MemCode and b.MemCode='" + dtgridmember.CurrentRow.Cells(0).Value + "' and a.GL_loans='" + dtgrid_products.CurrentRow.Cells(0).Value + "' and a.Released='Y' "

        'added a ORDER QUERY to sort data
        sql += ")x WHERE RowNumber BETWEEN " + c1.ToString + " AND " + c2.ToString + "" + " ORDER BY RowNumber ASC "

        'display SQl query
        'MessageBox.Show(sql)

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            If rd("status") = "O" Then
                dtgridloan_list.Rows.Add(rd("pnnumber").ToString, rd("Fullname").ToString, String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("loanamnt")), rd("reldate").ToString, rd("matdate").ToString, rd("ctrcode").ToString, rd("subproduct").ToString, "Paid Up", rd("released").ToString, rd("interestdue").ToString, rd("Accountnumber").ToString, rd("runningbal").ToString)
            ElseIf Date.Parse(rd("DateClosed")).ToString("yyyyMdd") < systemdate.ToString("yyyyMdd") Then
                dtgridloan_list.Rows.Add(rd("pnnumber").ToString, rd("Fullname").ToString, String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("loanamnt")), rd("reldate").ToString, rd("matdate").ToString, rd("ctrcode").ToString, rd("subproduct").ToString, "Closed", rd("released").ToString, rd("interestdue").ToString, rd("Accountnumber").ToString, rd("runningbal").ToString)
                GoTo 1
            ElseIf rd("status") = "A" Then
                dtgridloan_list.Rows.Add(rd("pnnumber").ToString, rd("Fullname").ToString, String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("loanamnt")), rd("reldate").ToString, rd("matdate").ToString, rd("ctrcode").ToString, rd("subproduct").ToString, "Active", rd("released").ToString, rd("interestdue").ToString, rd("Accountnumber").ToString, rd("runningbal").ToString)
1:          ElseIf rd("status") = "X" Then
                dtgridloan_list.Rows.Add(rd("pnnumber").ToString, rd("Fullname").ToString, String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("loanamnt")), rd("reldate").ToString, rd("matdate").ToString, rd("ctrcode").ToString, rd("subproduct").ToString, "Closed", rd("released").ToString, rd("interestdue").ToString, rd("Accountnumber").ToString, rd("runningbal").ToString)
            End If
            If rd("loancount") > c2 Then
                bttnnext.Enabled = True
            Else
                bttnnext.Enabled = False
            End If
        End While
        rd.Close()
        myConn.Close()

        For x As Integer = 0 To dtgridloan_list.Rows.Count - 1
            If x Mod 2 Then
                dtgridloan_list.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Try
                dtgridloan_list.FirstDisplayedScrollingRowIndex = dtgridloan_list.FirstDisplayedScrollingRowIndex + 1
            Catch ex As Exception

            End Try
        Next
        dtgridloan_list.ClearSelection()
    End Sub

    Public Sub view_loanledger()
        Me.Cursor = Cursors.WaitCursor
        lstloanledger.Items.Clear()

        conn()
        sql = "select x.* from(select a.pnnumber,a.userID,"
        sql += "principal=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interest=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0)"
        sql += " from loans a where a.pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "')x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            Dim lvitem As New ListViewItem(0)
            lvitem.SubItems.Add(dtgridloan_list.CurrentRow.Cells(3).Value)
            lvitem.SubItems.Add(dtgridloan_list.CurrentRow.Cells(3).Value)
            lvitem.SubItems.Add("---")
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(0)
            lvitem.SubItems.Add(rd("principal").ToString)
            lvitem.SubItems.Add(rd("interest").ToString)
            lvitem.SubItems.Add(rd("principal") + rd("interest"))
            lvitem.SubItems.Add(rd("userID").ToString)
            lvitem.SubItems.Add("Loan release")
            lvitem.SubItems.Add("A")
            lstloanledger.Items.Add(lvitem)
        End If
        rd.Close()
        myConn.Close()

        'MsgBox("Delete the maximum pay number first.", MsgBoxStyle.Exclamation, "Failed to delete")

        conn()
        sql = "SELECT x.payno,x.trnxdate,x.collectiondate,x.prnum,x.prndue,x.principal,x.AdvPrincipal,x.intdue,x.intpaid,x.AdvInterest,x.savings,x.CF,x.LH,x.SSSCont,(x.principaldue-x.ttlprnpaid) as prnbal,(x.interestdue-x.ttlintpaid) as intbal,x.RunningBalance,x.userid,x.remarks from(select a.payno,CONVERT(VARCHAR(10),a.trnxdate,101) As trnxdate,CONVERT(VARCHAR(10),a.collectiondate,101) As collectiondate,a.prnum,a.prndue,a.principal,a.AdvPrincipal,a.intdue,a.intpaid,a.AdvInterest,a.savings,a.CF,a.SSSCont,a.LH,"
        sql += "ttlprnpaid=isnull((SELECT (SUM(principal+AdvPrincipal)) FROM LoanCollect WHERE payno<=a.payno and pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((SELECT (SUM(intpaid+AdvInterest)) FROM LoanCollect WHERE payno<=a.payno and pnnumber=a.pnnumber),0),"
        sql += "principaldue=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "(0)as RunningBalance,a.userid,a.remarks FROM LoanCollect a,loans b WHERE a.pnnumber=b.pnnumber and a.pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
        sql += ")x ORDER BY x.payno ASC"

        'sql = "SELECT a.payno,CONVERT(VARCHAR(10),a.trnxdate,101) As trnxdate,CONVERT(VARCHAR(10),a.collectiondate,101) As collectiondate,a.prnum,a.prndue,a.principal,a.AdvPrincipal,a.intdue,a.intpaid,a.AdvInterest,a.savings,a.CF,a.prnduebalance,a.intduebalance,a.runningbalance,a.userid,a.remarks FROM LoanCollect a ORDER BY payno"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstloanledger.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstloanledger.Items.Count - 1
            lstloanledger.Items(i).SubItems(14).Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(lstloanledger.Items(i).SubItems(14).Text))
            lstloanledger.Items(i).SubItems(15).Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(lstloanledger.Items(i).SubItems(15).Text))
            If lstloanledger.Items(i).SubItems(14).Text <> "" Then
                lstloanledger.Items(i).SubItems(16).Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(lstloanledger.Items(i).SubItems(14).Text) + Double.Parse(lstloanledger.Items(i).SubItems(15).Text))
            End If
            If i Mod 2 Then
                lstloanledger.Items(i).BackColor = Color.AliceBlue
            Else
                lstloanledger.Items(i).BackColor = Color.White
            End If
        Next
        Me.Cursor = Cursors.Default

        bttnviewloans.Enabled = True
    End Sub

    Private Sub lstloanledger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstloanledger.Click
        Dim payno As Integer = 0
        conn()
        sql = "SELECT isnull((MAX(payno)),0) as payno FROM LoanCollect WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            payno = rd("payno")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_client_status.Show()
    End Sub

    Private Sub bttnnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        frm_newmembers.ShowDialog()
    End Sub

    Private Sub bttnpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnpost.Click
        If dtgridloan_list.CurrentRow.Cells(7).Value = "Paid Up" Then
            MsgBox("Cannot post payment. This loan was already paid-up.", MsgBoxStyle.Exclamation, "Already Paid Up")
        ElseIf dtgridloan_list.CurrentRow.Cells(7).Value = "Closed" Then
            MsgBox("Cannot post payment. This loan was already closed.", MsgBoxStyle.Exclamation, "Already Closed")
        Else
            frm_postpayment.ShowDialog()
        End If
    End Sub

    Private Sub bttndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndeletepayment.Click
        Try
            If usertype = "Admin" Then
                If dtgridloan_list.CurrentRow.Cells(7).Value = "Active" Then
                    GoTo 2
                End If
            End If
            If Date.Parse(lstloanledger.FocusedItem.SubItems(1).Text).ToString("M/d/yyyy") = systemdate Then
2:              delete_payment()
            Else
                pn_backdate.Visible = True
                'MsgBox("You can only delete payment at the same date today.", MsgBoxStyle.Exclamation, "Message")
            End If
        Catch ex As Exception
            MsgBox("Please select PR # with a valid system date to delete.", MsgBoxStyle.Exclamation, "Empty PR #")
        End Try
    End Sub

    Private Sub delete_payment()
        If MessageBox.Show("Are you sure you want to delete this ledger " & lstloanledger.FocusedItem.SubItems(3).Text & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim payno As Integer = 0
            conn()
            sql = "SELECT max(payno) as payno FROM LoanCollect WHERE  pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                payno = rd("payno")
                If payno <= Double.Parse(lstloanledger.FocusedItem.SubItems(0).Text) Then
                    conn()
                    sql = "DELETE FROM LoanCollect WHERE prnum='" + lstloanledger.FocusedItem.SubItems(3).Text + "' and trnxdate='" + lstloanledger.FocusedItem.SubItems(1).Text + "' and pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    If lstloanledger.FocusedItem.SubItems(16).Text = "DM" Then
                        conn()
                        sql = "WITH  x AS"
                        sql += "("
                        sql += "SELECT TOP 1 * "
                        sql += "FROM     accountledger where accountnumber='" + dtgridloan_list.CurrentRow.Cells(10).Value + "' and postmode='DM' and postingdate='" + lstloanledger.FocusedItem.SubItems(1).Text + "' "
                        sql += "order by postno DESC"
                        sql += ")"
                        sql += " DELETE "
                        sql += "FROM    x"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If

                    conn()
                    sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Deleted the payment of " & dtgridmember.CurrentRow.Cells(1).Value & " payno (" & lstloanledger.FocusedItem.SubItems(0).Text & ")','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    view_loanledger()
                Else
                    MsgBox("Delete the maximum pay number first.", MsgBoxStyle.Exclamation, "Failed to delete")
                End If
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub bttnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnedit.Click
        frm_editmembers.ShowDialog()
    End Sub

    Private Sub bttn_recompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_recompute.Click
        If MsgBox("You are about to Recompute Ledger, Are you sure?", MsgBoxStyle.OkCancel, "Recompute Ledger") <> MsgBoxResult.Ok Then

            Exit Sub

        End If
        conn() ' OPEN CONNECTION

        ' LOAN NUMBER
        Dim cLoanNumber As String = dtgridloan_list.CurrentRow.Cells(0).Value

        ' SQL QUERY
        sql = "SELECT x.payno,x.trnxdate,x.collectiondate, x.pnnumber, x.id " & _
              "FROM loancollect x " & _
              "WHERE x.pnnumber = '" + cLoanNumber + "' " & _
              "ORDER BY x.trnxdate ASC"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        ' DECLARE ARRAY FOR DATA READER
        Dim result As New ArrayList()

        While (rd.Read())

            ' Insert each column into a dictionary
            Dim dict As New Dictionary(Of String, Object)
            For count As Integer = 0 To (rd.FieldCount - 1)
                dict.Add(rd.GetName(count), rd(count))
            Next

            ' Add the dictionary to the ArrayList
            result.Add(dict)

        End While

        ' CLOSE DATA AND CONNECTION
        rd.Close()
        myConn.Close()

        Dim nID As Integer        ' ID NUMBER
        Dim npayno As Integer = 1 ' NUMERIC PAY NUMBER

        ' So, now you could loop through result with a for loop like this:
        For Each dat As Dictionary(Of String, Object) In result

            'Console.Write(dat("id"))
            'MsgBox(dat("id"))

            nID = dat("id")

            sql = "UPDATE loancollect SET payno = " + npayno.ToString + " WHERE id= " + nID.ToString

            'SQL COMMAND
            conn()
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            ' INCREMENT PAY NUMBER
            npayno = npayno + 1

        Next

        view_loanledger()
    End Sub

    ' Private Sub UpdateLoanCollectPayNo(ByVal PayNumber As Integer, ByVal IDNumber As Integer)
    'Dim sql As String

    '   conn()
    '  sql_cmd = New SqlCommand(sql, myConn)
    ' myConn.Open()
    'sql_cmd.ExecuteNonQuery()
    'myConn.Close()

    ' End Sub

    ' THIS FUNCTION WILL ENUMERATE LIST
    Private Sub EnumerateLoanLedger()
        Dim i, j As Integer
        Dim LItem As ListViewItem

        For i = 0 To lstloanledger.Items.Count - 1

            LItem = lstloanledger.Items(i)

            Debug.WriteLine(LItem.Text)
            For j = 0 To LItem.SubItems.Count - 1
                MsgBox(" " & lstloanledger.Columns(j).Text & _
                                " " & LItem.SubItems(j).Text)
            Next
        Next
    End Sub



    Private Sub bttnviewloans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnviewloans.Click
        GL_loans = dtgrid_products.CurrentRow.Cells(0).Value
        member_code = dtgridmember.CurrentRow.Cells(0).Value
        loannumber = dtgridloan_list.CurrentRow.Cells(0).Value
        select_grptype()
        If grouptype = "N" And multiproduct = "N" Then
            frm_loanProcess_indv.Text = "View Loan"
            'frm_loanProcess_indv.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
            frm_loanProcess_indv.ShowDialog()
        ElseIf multiproduct = "Y" Then
            frm_loanProcess_commodity.Text = "View Loan"
            'frm_loanProcess_commodity.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
            frm_loanProcess_commodity.ShowDialog()
        Else
            frm_loanProcess_grp.Text = "View Loan"
            'frm_loanProcess_grp.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
            frm_loanProcess_grp.ShowDialog()
        End If
    End Sub

    Private Sub dtgridmembers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtsearch.Focus()
        End If
    End Sub

    Private Sub dtgridlistloans_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        view_loanledger()
        Try
            SplashScreen.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bttnperformace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnperformace.Click
        frm_client_status.ShowDialog()
    End Sub

    Private Sub bttn_printledger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_printledger.Click
        frm_printledger.ShowDialog()
    End Sub

    Private Sub rd_closed_acct_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        view_member()
        SplashScreen.Close()
    End Sub

    Private Sub rd_active_acct_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
        'SplashScreen.count = 0
        'Control.CheckForIllegalCrossThreadCalls = False
        'thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        'thread.Start()
        view_member()
        'SplashScreen.Close()
    End Sub

    Private Sub ViewByAccountNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewByAccountNameToolStripMenuItem.Click
        If usertype = "Admin" Then
            GoTo a
        End If
        If Double.Parse(dtgridloan_list.CurrentRow.Cells(11).Value) > 0 And dtgridloan_list.CurrentRow.Cells(7).Value = "Paid Up" Then
a:          conn()
            sql = "UPDATE Loans SET status='A',dateclosed=NULL WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "' and status='O'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            Try
                view_loan_lists()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Loan number cannot be set as active.", MsgBoxStyle.Exclamation, "Invalid")
        End If
    End Sub

    Private Sub bttnweave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnweave.Click
        If MessageBox.Show("Are you sure you want to weave this loan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            frm_weavedlg.ShowDialog()
        End If
    End Sub

    Private Sub CancelReleaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelReleaseToolStripMenuItem.Click
        If usertype = "Admin" Or Date.Parse(dtgridloan_list.CurrentRow.Cells(3).Value) = systemdate Then
            conn()
            sql = "SELECT TOP (1) payno FROM LoanCollect WHERE pnnumber = '" + dtgridloan_list.CurrentRow.Cells(0).Value + "' AND payno > 0"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If Not rd.Read Then
                pnreason.Visible = True
            Else
                MsgBox("This loan has already have payment. Please check loan ledger.", MsgBoxStyle.Exclamation, "Invalid")
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub bttn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cancel.Click
        pnreason.Visible = False
    End Sub

    Private Sub bttn_cont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_cont.Click
        If txtreason.Text.Trim.Length < 20 Then
            MsgBox("Input field must be greater than 20 characters.", MsgBoxStyle.Exclamation, "Invalid")
            txtreason.Focus()
        Else
            conn()
            sql = "UPDATE Loans SET Released='N' WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "UPDATE LoanItems SET TrnDate=NULL WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "DELETE FROM LoanCollect  WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "DELETE FROM LoansDeduction  WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            sql = "WITH CTE AS "
            sql += "( "
            sql += "SELECT TOP 1 * "
            sql += "FROM AccountLedger WHERE accountnumber='" + dtgridloan_list.CurrentRow.Cells(10).Value + "' and postmode='CM' "
            sql += "ORDER BY Postno DESC"
            sql += ") "
            sql += "UPDATE CTE SET Active='X'"

            conn()
            sql = "INSERT INTO logs (PnNumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Cancel loan number  " & dtgridloan_list.CurrentRow.Cells(0).Value & "  (" & txtreason.Text & ")','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            pnreason.Visible = False

            MsgBox("Note: Please check savings ledger of this member.", MsgBoxStyle.Information, "Information")
            view_loan_lists()
        End If
    End Sub

    Private Sub dtgridmember_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridmember.Click
        c1 = 1
        c2 = 4
        txtcount.Text = c1 & " - " & c2
        bttnprev.Enabled = False
        'Application.DoEvents()
        pn_load.Visible = True
        RadPageView2.SelectedPage = RadPageViewPage3
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf view_loan_products)
        thread.Start()
        'Try
        'view_loan_products()
        'view_loan_lists()
        'dtgridloan_list.ClearSelection()
        'dtgrid_products.Rows(0).Selected = True
        'RadPageViewPage4.Text = "List of Loans (" & dtgrid_products.CurrentRow.Cells(2).Value & ")"
        'frm_loader.Close()
        'Catch ex As Exception
        'frm_loader.Close()
        'End Try

    End Sub


    Private Sub dtgridloan_list_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridloan_list.Click
        Try
            If Date.Parse(dtgridloan_list.CurrentRow.Cells(4).Value) < systemdate And dtgridloan_list.CurrentRow.Cells(7).Value = "Active" Then
                bttn_recons.Enabled = True
            Else
                bttn_recons.Enabled = False
            End If
            'If dtgridloan_list.CurrentRow
            Me.Cursor = Cursors.WaitCursor
            view_loanledger()
            Me.Cursor = Cursors.Default
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetToPaidupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToPaidupToolStripMenuItem.Click
        If Double.Parse(dtgridloan_list.CurrentRow.Cells(11).Value) <= 0 And dtgridloan_list.CurrentRow.Cells(7).Value = "Active" Then
            conn()
            sql = "UPDATE Loans SET status='O' WHERE pnnumber='" + dtgridloan_list.CurrentRow.Cells(0).Value + "' and status='A'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            view_loan_lists()
        Else
            MsgBox("Loan number cannot be set as Paidup.", MsgBoxStyle.Exclamation, "Invalid")
        End If
    End Sub

    Private Sub RadPageView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadPageView2.Click

    End Sub

    Private Sub MergeThisMembersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MergeThisMembersToolStripMenuItem.Click
        If txtsearch.Text.Trim = "" Or txtsearch.Text.Length <= 3 Then
            frm_utilities.txtsearch.Text = dtgridmember.CurrentRow.Cells(1).Value.ToString.Substring(0, 6)
        Else
            frm_utilities.txtsearch.Text = txtsearch.Text
        End If
        frm_utilities.Show()
        frm_utilities.TabControl1.SelectedTab = frm_utilities.TabPage3
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        txtsearch.Clear()
        txtsearch.Focus()
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        view_loan_lists()
    End Sub

    Private Sub bttnloanavail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_loanavailment.Show()
    End Sub

    Private Sub dtgrid_products_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_products.Click
        Try
            c1 = 1
            c2 = 4
            txtcount.Text = c1 & " - " & c2
            bttnprev.Enabled = False
            RadPageViewPage4.Text = "List of Loans " & dtgrid_products.CurrentRow.Cells(1).Value & " (" & dtgrid_products.CurrentRow.Cells(2).Value & ")"
            view_loan_lists()
            GL_loans = dtgrid_products.CurrentRow.Cells(0).Value
            dtgridloan_list.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text.Length > 1 Then
            For Each row As DataGridViewRow In dtgridmember.Rows
                'If you want the results to be case sensitive then remove the 2 ".ToLower" references on the line below   
                If row.Cells(1).Value.ToString.ToLower.Contains(txtsearch.Text.ToLower) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            Next
        End If
        dtgridmember.ClearSelection()
    End Sub

    Private Sub cboletter_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboletter.Validated
        view_member()
        If txtsearch.Text.Length > 1 Then
            For Each row As DataGridViewRow In dtgridmember.Rows
                'If you want the results to be case sensitive then remove the 2 ".ToLower" references on the line below   
                If row.Cells(1).Value.ToString.ToLower.Contains(txtsearch.Text.ToLower) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            Next
        End If
        dtgridmember.ClearSelection()
    End Sub

    Private Sub cboletter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboletter.SelectedIndexChanged
        txtsearch.Focus()
    End Sub

    Private Sub InactiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InactiveToolStripMenuItem.Click
        conn()
        sql = "SELECT memcode FROM loans WHERE memcode='" + dtgridmember.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            MsgBox("This member has already used in loan tables.", MsgBoxStyle.Exclamation, "Message")
        Else
            pnadmin.Visible = True
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        If txtpassword.Text.Trim = "g$oft" Then
            If MessageBox.Show("Are you sure you want to inactive this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                conn()
                sql = "UPDATE members SET status='X' WHERE memcode='" + dtgridmember.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                pnadmin.Visible = False
                lblalert.Visible = False
            End If
        Else
            lblalert.Visible = True
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        pnadmin.Visible = False
    End Sub

    Private Sub chkview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkview.CheckedChanged
        view_member()
    End Sub

    Private Sub bttnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnext.Click
        c1 = c1 + 4
        c2 = c2 + 4
        txtcount.Text = c1 & " - " & c2
        view_loan_lists()
        bttnprev.Enabled = True
    End Sub

    Private Sub bttnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnprev.Click
        If c1 > 4 Then
            c1 = c1 - 4
            c2 = c2 - 4
            txtcount.Text = c1 & " - " & c2
            view_loan_lists()
        End If
        If c1 = 1 Then
            bttnprev.Enabled = False
        End If
    End Sub

    Private Sub bttn_recons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnrestruct.Visible = True
    End Sub

    Private Sub bttncont1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont1.Click
        Try
            'mysqlconn()
            'sql = "select * from access_temp where accesspass='" + txtpassword_rec.Text + "' and userid='" + user + "' and status='A'"
            'mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            'mysqlmyconn.Open()
            'mysqlrd = mysqlcmd.ExecuteReader
            'If mysqlrd.Read Then
            If txtpassword_rec.Text = adminpass Then
                delete_payment()
                pn_backdate.Visible = False
            Else
                MessageBox.Show("Invalid password")
            End If
            'Else
            'MsgBox("Invalid access of user ID.", MsgBoxStyle.Exclamation, "Invalid User")
            'End If
            'mysqlrd.Close()
            'mysqlmyconn.Close()

            'update_accesstemp()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        pn_backdate.Visible = False
    End Sub

    Private Sub RadButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton5.Click
        If txtrestruct_pass.Text = adminpass Then
            Label2.Visible = False
            'MessageBox.Show("call restruct_loan module")
            restruct_loan()
        Else
            MessageBox.Show("Invalid password")
            'Try
            '    mysqlconn()
            '    sql = "select * from access_temp where accesspass='" + txtrestruct_pass.Text + "' and userid='" + user + "' and status='A'"
            '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            '    mysqlmyconn.Open()
            '    mysqlrd = mysqlcmd.ExecuteReader
            '    If mysqlrd.Read Then
            '        'If txtpassword_rec.Text = mysqlrd("accesspass") Then
            '        Label2.Visible = False
            '        restruct_loan()
            '        'Else
            '        'lblinvalipassword.Visible = True
            '        'End If
            '    Else
            '        Label2.Visible = True
            '    End If
            '    mysqlrd.Close()
            '    mysqlmyconn.Close()

            '    update_accesstemp()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
        End If
    End Sub

    Private Sub restruct_loan()
        pnrestruct.Visible = False

        GL_loans = dtgrid_products.CurrentRow.Cells(0).Value
        member_code = dtgridmember.CurrentRow.Cells(0).Value
        'loannumber = dtgridloan_list.CurrentRow.Cells(0).Value
        select_grptype()
        MessageBox.Show("after select_grptype() ")

        'If grouptype = "N" And multiproduct = "N" Then
        frm_loanProcess_indv.Text = "Re-Construct Loan"
        'frm_loanProcess_indv.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
        frm_loanProcess_indv.ShowDialog()

        'test ---
        MsgBox("frm_loanProcess_indv.ShowDialog", MsgBoxStyle.Exclamation, "i am here")

        'ElseIf multiproduct = "Y" Then
        '    frm_loanProcess_commodity.Text = "Re-Construct Loan"
        '    'frm_loanProcess_commodity.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
        '    frm_loanProcess_commodity.ShowDialog()
        'Else
        '    frm_loanProcess_grp.Text = "Re-Construct Loan"
        '    'frm_loanProcess_grp.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
        '    frm_loanProcess_grp.ShowDialog()
        'End If
    End Sub

    'modified by Windel Tonacao - 9-25-2024
    Private Sub renew_loan()
        Dim cOldloannumber As Char


        pnrestruct.Visible = False
        GL_loans = dtgrid_products.CurrentRow.Cells(0).Value
        member_code = dtgridmember.CurrentRow.Cells(0).Value
        'loannumber = dtgridloan_list.CurrentRow.Cells(0).Value

        'store old loan number to variable
        cOldloannumber = dtgridloan_list.CurrentRow.Cells(0).Value

        select_grptype()

        If grouptype = "N" And multiproduct = "N" Then
            frm_loanProcess_indv.Text = "Renew Loan"
            'frm_loanProcess_indv.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
            frm_loanProcess_indv.ShowDialog()
        ElseIf multiproduct = "Y" Then
            frm_loanProcess_commodity.Text = "ReNew Loan"
            'frm_loanProcess_commodity.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
            frm_loanProcess_commodity.ShowDialog()
        Else
            frm_loanProcess_grp.Text = "ReNew Loan"
            'frm_loanProcess_grp.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
            frm_loanProcess_grp.ShowDialog()
        End If
    End Sub
    'modified by Windel Tonacao - 9-26-2024
    Private Sub renew_loan_orig()
        pnrestruct.Visible = False
        GL_loans = dtgrid_products.CurrentRow.Cells(0).Value
        member_code = dtgridmember.CurrentRow.Cells(0).Value
        'loannumber = dtgridloan_list.CurrentRow.Cells(0).Value
        select_grptype()
        'If grouptype = "N" And multiproduct = "N" Then
        frm_loanProcess_indv.Text = "Re-Construct Loan"
        'frm_loanProcess_indv.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
        frm_loanProcess_indv.ShowDialog()
        'ElseIf multiproduct = "Y" Then
        '    frm_loanProcess_commodity.Text = "Re-Construct Loan"
        '    'frm_loanProcess_commodity.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
        '    frm_loanProcess_commodity.ShowDialog()
        'Else
        '    frm_loanProcess_grp.Text = "Re-Construct Loan"
        '    'frm_loanProcess_grp.txtlno.Text = dtgridloan_list.CurrentRow.Cells(0).Value
        '    frm_loanProcess_grp.ShowDialog()
        'End If
    End Sub


    Private Sub bttn_printagreement_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_printagreement.Click

    End Sub

    Private Sub bttn_restruct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttn_restruct.Click
        pnrestruct.Visible = True
    End Sub

    Private Sub dtgridloan_list_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridloan_list.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub dtgridmember_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridmember.CellContentClick

    End Sub

    Private Sub RadMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem1.Click
        renew_loan()
    End Sub
End Class