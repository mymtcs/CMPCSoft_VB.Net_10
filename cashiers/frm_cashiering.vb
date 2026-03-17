Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_cashiering
    Dim id As Integer = 0
    Dim IDreceipt As Integer = 0
    Dim IDdisburse As Integer = 0
    Dim delete As Boolean
    Dim editgl As Boolean
    Dim editamount As Boolean
    Dim editgl1 As Boolean
    Dim editamount1 As Boolean

    Private Sub frm_cashiering_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            popup_add_rec()
            RadPageView1.SelectedPage = RadPageViewPage1
            RadPageView2.SelectedPage = rad_reciepts
        ElseIf e.KeyCode = Keys.F5 Then
            popup_add_dis()
            RadPageView1.SelectedPage = RadPageViewPage1
            RadPageView2.SelectedPage = rad_disburse
        End If
    End Sub

    Private Sub frm_cashiering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bttnprintCB.Enabled = False
        dtden.Value = systemdate
        select_GL()
        select_GL1()
        select_GLview1()
        select_GLview2()
        dt_receipts.Value = systemdate
        dt_disburse.Value = systemdate

        gen_distribution_of_receipts()
        gen_distribution_of_payments()

        gen_summary()
        append()
        check_den()
    End Sub

    Private Sub select_GL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("accttype").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtgl.DataSource = table1
        Me.txtgl.AutoFilter = True
        txtgl.DisplayMember = "Acct. Description"
        txtgl.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtgl.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtgl.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtgl.EditorControl.Columns(0).Width = 100
        Me.txtgl.EditorControl.Columns(1).Width = 250
        Me.txtgl.EditorControl.Columns(1).Width = 200
        Me.txtgl.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub select_GL1()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM CHARTACCOUNTS"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("accttype").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtgl1.DataSource = table1
        Me.txtgl1.AutoFilter = True
        txtgl1.DisplayMember = "Acct. Description"
        txtgl1.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtgl1.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtgl1.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtgl1.EditorControl.Columns(0).Width = 100
        Me.txtgl1.EditorControl.Columns(1).Width = 250
        Me.txtgl1.EditorControl.Columns(1).Width = 200
        Me.txtgl1.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub select_GLview1()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT distinct accountcode,acct_description,accttype FROM CHARTACCOUNTS where accountcode in (select GLaccount from CashiersTransaction where Debit>0 and Trndate ='" & dt_receipts.Value & "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        table1.Rows.Add("All", "-All-", "--")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("accttype").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtgl_view1.DataSource = table1
        Me.txtgl_view1.AutoFilter = True
        txtgl_view1.DisplayMember = "Acct. Description"
        txtgl_view1.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtgl_view1.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtgl_view1.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtgl_view1.EditorControl.Columns(0).Width = 100
        Me.txtgl_view1.EditorControl.Columns(1).Width = 250
        Me.txtgl_view1.EditorControl.Columns(1).Width = 200
        Me.txtgl_view1.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub select_GLview2()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT distinct accountcode,acct_description,accttype FROM CHARTACCOUNTS where accountcode in (select GLaccount from CashiersTransaction where Credit>0 and Trndate ='" & dt_receipts.Value & "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Acct. Code")
        table1.Columns.Add("Acct. Description")
        table1.Columns.Add("Acct. Type")
        table1.Rows.Add("All", "-All-", "--")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString, rd("accttype").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtgl_view2.DataSource = table1
        Me.txtgl_view2.AutoFilter = True
        txtgl_view2.DisplayMember = "Acct. Description"
        txtgl_view2.ValueMember = "Acct. Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtgl_view2.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtgl_view2.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtgl_view2.EditorControl.Columns(0).Width = 100
        Me.txtgl_view2.EditorControl.Columns(1).Width = 250
        Me.txtgl_view2.EditorControl.Columns(1).Width = 200
        Me.txtgl_view2.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub gen_denomination()
        conn()
        sql = "SELECT * FROM denomination WHERE den_date='" + dtden.Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtonethousand.Text = rd("").ToString
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Public Sub gen_distribution_of_payments()
        dtgrid_disburse.Rows.Clear()
        conn()
        If chkrec_payee.IsChecked = True Then
            sql = "SELECT * FROM CashiersTransaction WHERE Trndate='" + dt_disburse.Value + "' and Payee like'%" + txt_cb_dis.Text + "%' and credit >0 "
            If Not txtgl_view2.SelectedValue = "All" Then
                sql += " and GLaccount='" & txtgl_view2.SelectedValue & "' "
            End If
            sql += " ORDER BY Reference ASC"
        Else
            sql = "SELECT * FROM CashiersTransaction WHERE Trndate='" + dt_disburse.Value + "' and Remarks like'%" + txt_cb_dis.Text + "%' and credit >0 "
            If Not txtgl_view2.SelectedValue = "All" Then
                sql += " and GLaccount='" & txtgl_view2.SelectedValue & "' "
            End If
            sql += " ORDER BY Reference ASC"
        End If

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            Dim x As Integer = dtgrid_disburse.Rows.Add
            dtgrid_disburse.Rows(x).Cells(0).Value = rd("Reference").ToString
            dtgrid_disburse.Rows(x).Cells(1).Value = rd("Payee").ToString
            dtgrid_disburse.Rows(x).Cells(2).Value = rd("Remarks").ToString
            dtgrid_disburse.Rows(x).Cells(3).Value = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("Credit"))
            dtgrid_disburse.Rows(x).Cells(4).Value = rd("AcctReference").ToString
            dtgrid_disburse.Rows(x).Cells(5).Value = rd("GLaccount").ToString
            dtgrid_disburse.Rows(x).Cells(6).Value = rd("ID").ToString
            dtgrid_disburse.Rows(x).Cells(7).Value = rd("UserID").ToString
        End While
        rd.Close()
        myConn.Close()

        lblpaymentamnt.Text = 0
        Try
            For x As Integer = 0 To dtgrid_disburse.Rows.Count - 1
                If x Mod 2 Then
                    dtgrid_disburse.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
                lblpaymentamnt.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(dtgrid_disburse.Rows(x).Cells(3).Value) + Double.Parse(lblpaymentamnt.Text))
                Dim row As DataGridViewRow = dtgrid_disburse.Rows(x)
                row.Height = 30
            Next
        Catch ex As Exception

        End Try

        conn()
        If chkdis_payee.IsChecked = True Then
            sql = "select top 1 ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number from CashiersTransaction where Trndate='" + dt_disburse.Value + "' and payee like'%" + txt_cb_dis.Text + "%' and credit > 0 group by Reference order by (ROW_NUMBER() OVER (ORDER BY (SELECT 1))) desc"
        Else
            sql = "select top 1 ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number from CashiersTransaction where Trndate='" + dt_disburse.Value + "' and Remarks like'%" + txt_cb_dis.Text + "%' and credit > 0  group by Reference order by (ROW_NUMBER() OVER (ORDER BY (SELECT 1))) desc"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            lblref_cb_dis.Text = rd("number").ToString
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Public Sub gen_distribution_of_receipts()
        dtgridblotter.Rows.Clear()
        conn()
        If chkrec_payee.IsChecked = True Then
            sql = "SELECT * FROM CashiersTransaction WHERE Trndate='" + dt_receipts.Value + "' and Payee like'%" + txt_cb_rec.Text + "%' and debit >0 "
            If Not txtgl_view1.SelectedValue = "All" Then
                sql += " and GLaccount='" & txtgl_view1.SelectedValue & "' "
            End If
            sql += " ORDER BY Reference ASC"
        Else
            sql = "SELECT * FROM CashiersTransaction WHERE Trndate='" + dt_receipts.Value + "' and Remarks like'%" + txt_cb_rec.Text + "%'  and debit >0 "
            If Not txtgl_view1.SelectedValue = "All" Then
                sql += " and GLaccount='" & txtgl_view1.SelectedValue & "' "
            End If
            sql += " ORDER BY Reference ASC"
        End If

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            Dim x As Integer = dtgridblotter.Rows.Add
            dtgridblotter.Rows(x).Cells(0).Value = rd("Reference").ToString
            dtgridblotter.Rows(x).Cells(1).Value = rd("Payee").ToString
            dtgridblotter.Rows(x).Cells(2).Value = rd("Remarks").ToString
            dtgridblotter.Rows(x).Cells(3).Value = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("Debit"))
            dtgridblotter.Rows(x).Cells(4).Value = rd("AcctReference").ToString
            dtgridblotter.Rows(x).Cells(5).Value = rd("GLaccount").ToString
            dtgridblotter.Rows(x).Cells(6).Value = rd("ID").ToString
            dtgridblotter.Rows(x).Cells(7).Value = rd("UserID").ToString
        End While
        rd.Close()
        myConn.Close()

        lbl_receiptsamnt.Text = 0
        For x As Integer = 0 To dtgridblotter.Rows.Count - 1
            If x Mod 2 Then
                dtgridblotter.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Try
                lbl_receiptsamnt.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(dtgridblotter.Rows(x).Cells(3).Value) + Double.Parse(lbl_receiptsamnt.Text))
                lblref_cb_rec.Text = dtgridblotter.Rows.Count

                Dim row As DataGridViewRow = dtgridblotter.Rows(x)
                row.Height = 30
            Catch ex As Exception

            End Try
        Next

        conn()
        If chkrec_payee.IsChecked = True Then
            sql = "select top 1 ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number from CashiersTransaction where trndate='" + dt_receipts.Value + "' and Payee like'%" + txt_cb_rec.Text + "%' and debit >0 group by Reference order by (ROW_NUMBER() OVER (ORDER BY (SELECT 1))) desc"
        Else
            sql = "select top 1 ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number from CashiersTransaction where trndate='" + dt_receipts.Value + "' and Remarks like'%" + txt_cb_rec.Text + "%' and debit >0 group by Reference order by (ROW_NUMBER() OVER (ORDER BY (SELECT 1))) desc"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            lblref_cb_rec.Text = rd("number").ToString
        End If
        rd.Close()
        myConn.Close()
    End Sub


    Private Sub gendate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_disburse.Validated
        gen_distribution_of_payments()
    End Sub

    Private Sub genreceiptdate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_receipts.Validated
        gen_distribution_of_receipts()
    End Sub


    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtonethousand.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtonethousand.Focus()
        ElseIf txtfivehundred.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtfivehundred.Focus()
        ElseIf txttwohundred.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txttwohundred.Focus()
        ElseIf txtonehundred.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtonehundred.Focus()
        ElseIf txtfifty.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtfifty.Focus()
        ElseIf txttwenty.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txttwenty.Focus()
        ElseIf txtten.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtten.Focus()
        ElseIf txtfive.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtfive.Focus()
        ElseIf txtone.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtone.Focus()
        ElseIf txtcent.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtcent.Focus()
        Else
            conn()
            sql = "select * from denomination where den_date='" & dtden.Value & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE denomination SET onethousand=" + txtonethousand.Text + ",fivehundred=" + txtfivehundred.Text + ",twohundred=" + txttwohundred.Text + ""
                sql += ",onehundred=" + txtonehundred.Text + ",fifty=" + txtfifty.Text + ",twenty=" + txttwenty.Text + ",ten=" + txtten.Text + ",five=" + txtfive.Text + ",peso=" + txtone.Text + ",centavo=" + txtcent.Text + ",CoCi='" + txtcheck.Text + "',tencent=" + txt_tencent.Text + ",fivecent=" + txt_centfive.Text + ",Ttime='" & time.ToString & "' where  den_date='" & dtden.Value & "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Denomination of " & dtden.Value & " was successfully updated.", MsgBoxStyle.Information)
            Else
                conn()
                sql = "INSERT INTO denomination(den_date,onethousand,fivehundred,twohundred,onehundred,fifty,twenty,ten,five,peso,centavo,CoCi,tencent,fivecent,den_type,Ttime) VALUES "
                sql += "('" + dtden.Value + "',"
                sql += "" + txtonethousand.Text + ","
                sql += "" + txtfivehundred.Text + ","
                sql += "" + txttwohundred.Text + ","
                sql += "" + txtonehundred.Text + ","
                sql += "" + txtfifty.Text + ","
                sql += "" + txttwenty.Text + ","
                sql += "" + txtten.Text + ","
                sql += "" + txtfive.Text + ","
                sql += "" + txtone.Text + ","
                sql += "" + txtcent.Text + ","
                sql += "'" + txtcheck.Text + "',"
                sql += "" + txt_tencent.Text + ","
                sql += "" + txt_centfive.Text + ","
                sql += "'ACTIVE',"
                sql += "'" + time.ToString + "'"
                sql += ")"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Denomination of " & dtden.Value & " was successfully saved.", MsgBoxStyle.Information)
            End If
            rd.Close()
            myConn.Close()

            'If dtden.Value = systemdate Then
            'conn()
            'sql = "DELETE FROM denomination WHERE den_date='" + dtden.Value + "'"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()


            '    Else
            '    MsgBox("Previous date denomination cannot be change.", MsgBoxStyle.Exclamation, "Invalid")
            'End If
        End If
    End Sub

    Private Sub txtonethousand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtonethousand.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfivehundred.Focus()
        End If
    End Sub

    Private Sub txtfivehundred_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfivehundred.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttwohundred.Focus()
        End If
    End Sub

    Private Sub txttwohundred_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttwohundred.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtonehundred.Focus()
        End If
    End Sub

    Private Sub txtonehundred_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtonehundred.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfifty.Focus()
        End If
    End Sub

    Private Sub txtfifty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfifty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttwenty.Focus()
        End If
    End Sub

    Private Sub txttwenty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttwenty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtten.Focus()
        End If
    End Sub

    Private Sub txtten_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtten.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfive.Focus()
        End If
    End Sub

    Private Sub txtfive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfive.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtone.Focus()
        End If
    End Sub

    Private Sub txtone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcent.Focus()
        End If
    End Sub

    Private Sub txtcent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcent.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttncompute.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncompute.Click
        lbltotalden.Text = 0
        If txtonethousand.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtonethousand.Focus()
        ElseIf txtfivehundred.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtfivehundred.Focus()
        ElseIf txttwohundred.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txttwohundred.Focus()
        ElseIf txtonehundred.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtonehundred.Focus()
        ElseIf txtfifty.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtfifty.Focus()
        ElseIf txttwenty.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txttwenty.Focus()
        ElseIf txtten.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtten.Focus()
        ElseIf txtfive.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtfive.Focus()
        ElseIf txtone.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtone.Focus()
        ElseIf txtcent.Text.Trim = "" Then
            MsgBox("Text field must be numeric zero and above", MsgBoxStyle.Exclamation)
            txtcent.Focus()
        Else
            compute_blotter()
            save_denomination()
            bttnclose_trnx.Enabled = True
        End If
    End Sub

    Private Sub compute_blotter()
        'check_den()
        lblbalance.Text = 0
        lblvariance.Text = 0

        lbltotalden.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", (((Double.Parse(txtonethousand.Text) * 1000) + (Double.Parse(txtfivehundred.Text) * 500)) + (Double.Parse(txtonehundred.Text) * 100)) + (Double.Parse(txttwohundred.Text) * 200) + (Double.Parse(txtfifty.Text) * 50) + (Double.Parse(txttwenty.Text) * 20) + (Double.Parse(txtten.Text) * 10) + (Double.Parse(txtfive.Text) * 5) + (Double.Parse(txtone.Text) * 1) + (Double.Parse(txtcent.Text) * 0.25) + (Double.Parse(txt_tencent.Text) * 0.1) + (Double.Parse(txt_centfive.Text) * 0.05))
        conn()
        sql = "SELECT x.* FROM(select a.*,"
        sql += "begbal=isnull((select sum(debit-credit)from CashiersTransaction where trndate < a.den_date),0),"
        sql += "ttlreceipts=isnull((select sum(debit)from CashiersTransaction where trndate = a.den_date),0),"
        sql += "ttldisburse=isnull((select sum(credit)from CashiersTransaction where trndate = a.den_date),0)"
        sql += " from denomination a where den_date='" + dtden.Value + "')x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            lblbalance.Text = rd("begbal") + rd("ttlreceipts") - rd("ttldisburse")
            lblvariance.Text = Decimal.Parse(lbltotalden.Text) - Decimal.Parse(lblbalance.Text)
            'If Double.Parse(lbltotalden.Text) <> Double.Parse(rd("ttlbal")) Then
            '    Dim def As Integer = rd("ttlbal") - Double.Parse(lbltotalden.Text)
            '    MsgBox("Denomination amount is not equal to the total balance. Amount diff. " & def.ToString, MsgBoxStyle.Exclamation, "")
            'End If
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub save_denomination()
        conn()
        sql = "select * from denomination where den_date='" & dtden.Value & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            conn()
            sql = "UPDATE denomination SET onethousand=" + txtonethousand.Text + ",fivehundred=" + txtfivehundred.Text + ",twohundred=" + txttwohundred.Text + ""
            sql += ",onehundred=" + txtonehundred.Text + ",fifty=" + txtfifty.Text + ",twenty=" + txttwenty.Text + ",ten=" + txtten.Text + ",five=" + txtfive.Text + ",peso=" + txtone.Text + ",centavo=" + txtcent.Text + ",CoCi='" + txtcheck.Text + "',tencent=" + txt_tencent.Text + ",fivecent=" + txt_centfive.Text + ",Ttime='" & time.ToString & "' where  den_date='" & dtden.Value & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            'MsgBox("Denomination of " & dtden.Value & " was successfully updated.", MsgBoxStyle.Information)
        Else
            conn()
            sql = "INSERT INTO denomination(den_date,onethousand,fivehundred,twohundred,onehundred,fifty,twenty,ten,five,peso,centavo,CoCi,tencent,fivecent,den_type,Ttime) VALUES "
            sql += "('" + dtden.Value + "',"
            sql += "" + txtonethousand.Text + ","
            sql += "" + txtfivehundred.Text + ","
            sql += "" + txttwohundred.Text + ","
            sql += "" + txtonehundred.Text + ","
            sql += "" + txtfifty.Text + ","
            sql += "" + txttwenty.Text + ","
            sql += "" + txtten.Text + ","
            sql += "" + txtfive.Text + ","
            sql += "" + txtone.Text + ","
            sql += "" + txtcent.Text + ","
            sql += "'" + txtcheck.Text + "',"
            sql += "" + txt_tencent.Text + ","
            sql += "" + txt_centfive.Text + ","
            sql += "'ACTIVE',"
            sql += "'" + time.ToString + "'"
            sql += ")"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox("Denomination of " & dtden.Value & " was successfully saved.", MsgBoxStyle.Information)
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub check_den()
        conn()
        sql = "select * from denomination where den_date='" & dtden.Value & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            TRNX = rd("den_type").ToString.Trim
            If TRNX.ToString.Trim = "CLOSED" Then
                bttnprintCB.Enabled = True
                grp1.Enabled = False
                lnkunclosed.Enabled = True
            Else
                grp1.Enabled = True
                bttnprintCB.Enabled = False
                lnkunclosed.Enabled = False
            End If
        Else
            grp1.Enabled = True
            bttnprintCB.Enabled = False
            lnkunclosed.Enabled = False
        End If
        rd.Close()
        myConn.Close()
        Me.Text = "Cashiers Transaction (" & TRNX & ")"

        contxt_disburse()
        contxt_receipt()
        'If dtden.Value.ToString("M/d/yyyy") = systemdate And TRNX <> "CLOSED" Then
        '    grp1.Enabled = True
        'Else
        '    grp1.Enabled = False
        'End If
    End Sub

    Private Sub contxt_receipt()
        'If usertype <> "Admin" Then
        If TRNX = "ACTIVE" Then
            NewToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
            EditToolStripMenuItem.Enabled = True

            txt_ref.Enabled = True
            txtamount.Enabled = True
            txtacctref.Enabled = True
        Else
            NewToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
            'EditToolStripMenuItem.Enabled = False

            txt_ref.Enabled = False
            txtamount.Enabled = False
            txtacctref.Enabled = False

            txt_ref.Clear()
            txtamount.Text = 0
            txtacctref.Clear()
            txtremarks.Clear()
            txtpayee.Clear()
            DeleteToolStripMenuItem.Enabled = False
        End If
        'Else
        'NewToolStripMenuItem.Enabled = True
        'DeleteToolStripMenuItem.Enabled = True
        'EditToolStripMenuItem.Enabled = True
        'End If
    End Sub

    Private Sub contxt_disburse()
        'If usertype <> "Admin" Then
        If TRNX = "ACTIVE" Then
            txtref1.Enabled = True
            txtamount1.Enabled = True
            txtacct_ref1.Enabled = True

            ToolStripMenuItem1.Enabled = True
            ToolStripMenuItem2.Enabled = True
            ToolStripMenuItem3.Enabled = True
        Else
            ToolStripMenuItem1.Enabled = False
            'ToolStripMenuItem2.Enabled = False
            ToolStripMenuItem3.Enabled = False

            txtref1.Enabled = False
            txtamount1.Enabled = False
            txtacct_ref1.Enabled = False

            txtref1.Clear()
            txtamount1.Text = 0
            txtacct_ref1.Clear()
            txtremarks1.Clear()
            txtpayee1.Clear()
        End If
        'Else
        'ToolStripMenuItem1.Enabled = True
        'ToolStripMenuItem2.Enabled = True
        'ToolStripMenuItem3.Enabled = True
        'End If
    End Sub


    Private Sub dtden_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtden.Validated

    End Sub

    Private Sub txtfind_cb_rec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cb_rec.KeyDown
        If e.KeyCode = Keys.Enter Then
            gen_distribution_of_receipts()
        End If
    End Sub

    Private Sub txt_cb_dis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cb_dis.KeyDown
        If e.KeyCode = Keys.Enter Then
            gen_distribution_of_payments()
        End If
    End Sub

    Private Sub bttn_voucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_print_voucher.Show()
    End Sub

    Private Sub txtview_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bttnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnadd.Visible = False
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnadd.Visible = False
    End Sub

    Private Sub txt_receipt_ref_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpayee.Focus()
        End If
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose_rec.Click
        pnadd.Visible = False
    End Sub

    'Private Sub dtgrid_dis_ofpayment_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dtgrid_disburse.CellPainting
    '    If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 Then
    '        e.Paint(e.CellBounds, DataGridViewPaintParts.All)
    '        Dim img As Image = Image.FromFile("search.png")
    '        e.Graphics.DrawImage(img, e.CellBounds.Left + 10, e.CellBounds.Top + 5, 10, 10)
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub dtgrid_disburse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_disburse.DoubleClick
        popup_add_dis()
    End Sub

    Public Sub addItemsREF_dis(ByVal col As AutoCompleteStringCollection)
        For i As Integer = 0 To dtgrid_disburse.Rows.Count - 1
            If dtgrid_disburse.Rows(i).Cells(0).Value <> "" Then
                col.Add(dtgrid_disburse.Rows(i).Cells(0).Value)
            End If
        Next
    End Sub

    Public Sub addItemsPAYEE_dis(ByVal col As AutoCompleteStringCollection)
        For i As Integer = 0 To dtgrid_disburse.Rows.Count - 1
            If dtgrid_disburse.Rows(i).Cells(1).Value <> "" Then
                col.Add(dtgrid_disburse.Rows(i).Cells(1).Value)
            End If
        Next
    End Sub

    Public Sub addItemsREMARKS_dis(ByVal col As AutoCompleteStringCollection)
        For i As Integer = 0 To dtgrid_disburse.Rows.Count - 1
            If dtgrid_disburse.Rows(i).Cells(2).Value <> "" Then
                col.Add(dtgrid_disburse.Rows(i).Cells(2).Value)
            End If
        Next
    End Sub

    Private Sub dtgrid_disburse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgrid_disburse.KeyDown
        If e.KeyCode = Keys.Enter Then
            popup_add_dis()
        End If
    End Sub

    Private Sub RadButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave_receipt.Click
        time = DateTime.Now.Hour & ":" & DateTime.Now.Minute
        If txt_ref.Text.Trim = "" Then
            'MsgBox("Reference cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txt_ref.BackColor = Color.Red
            txt_ref.ForeColor = Color.White
            txt_ref.Focus()
        ElseIf txtpayee.Text.Trim = "" Then
            'MsgBox("Payee cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtpayee.BackColor = Color.Red
            txtpayee.ForeColor = Color.White
            txtpayee.Focus()
        ElseIf txtremarks.Text.Trim = "" Then
            'MsgBox("Remarks cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtremarks.BackColor = Color.Red
            txtremarks.ForeColor = Color.White
            txtremarks.Focus()
        ElseIf txtpayee.Text.Trim = "" Then
            'MsgBox("Payee cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtpayee.BackColor = Color.Red
            txtpayee.ForeColor = Color.White
            txtpayee.Focus()
        ElseIf txtgl.Text.Trim = "" Then
            'MsgBox("GL account cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            'txtgl.BackColor = Color.Red
            'txtgl.ForeColor = Color.White
            txtgl.Focus()
        ElseIf txtacctref.Text.Trim = "" Then
            'MsgBox("Account reference cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtacctref.BackColor = Color.Red
            txtacctref.ForeColor = Color.White
            txtacctref.Focus()
        ElseIf txtamount.Text.Trim = "" Then
            'MsgBox("Amount cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtamount.BackColor = Color.Red
            txtamount.ForeColor = Color.White
            txtamount.Focus()
        ElseIf Decimal.Parse(txtamount.Text) <= 0 Then
            If MessageBox.Show("Amount is receive is a zero value. Would like to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                GoTo 3
            Else
                txtamount.BackColor = Color.Red
                txtamount.ForeColor = Color.White
                txtamount.Focus()
            End If
        Else
3:          If IDreceipt = 0 Then
                editgl = False
                editamount = False

                conn()
                sql = "INSERT INTO CashiersTransaction (Payee,Debit,Credit,Reference,Remarks,GLaccount,AcctReference,Trndate,Ttime,UserID) "
                sql += "VALUES('" + txtpayee.Text + "','" + Double.Parse(txtamount.Text).ToString + "',0,'" + txt_ref.Text + "','" + txtremarks.Text + "','" + txtgl.SelectedValue + "','" + txtacctref.Text + "','" + dt_receipts.Value + "','" + time + "','" + user + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                txtamount.Text = 0

                conn()
                sql = "DELETE FROM Cashiersdummy where ID=" & id.ToString & " "
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                Try
                    conn()
                    sql = "UPDATE Accountledger set Active='Y' WHERE Accountnumber='" + txtacctref.Text + "' and postno=" + lstnot.FocusedItem.SubItems(3).Text + ""
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                Catch ex As Exception

                End Try
                Try
                    conn()
                    sql = "UPDATE CBUledger set Active='Y' WHERE CBUAccount='" + txtacctref.Text + "' and postno=" + lstcbu.FocusedItem.SubItems(3).Text + ""
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                Catch ex As Exception

                End Try
            Else
                conn()
                sql = "UPDATE CashiersTransaction set Payee='" + txtpayee.Text + "',Debit=" + Decimal.Parse(txtamount.Text).ToString + ",Credit=0,Reference='" + txt_ref.Text + "',Remarks='" + txtremarks.Text + "',GLaccount='" + txtgl.SelectedValue + "',AcctReference='" + txtacctref.Text + "',Trndate='" + dt_receipts.Value + "',Ttime='" + time + "',UserID='" + user + "' WHERE ID=" + id.ToString + ""
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                'conn()
                'Dim reasons As String = "Editing cashiers transaction of reference " & txt_ref.Text & " amount of " & txtamount.Text & " gl account of " & txtgl.SelectedValue
                'sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','" + reasons + "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                'cmd = New SqlCommand(sql, myConn)
                'myConn.Open()
                'cmd.ExecuteNonQuery()
                'myConn.Close()
                'Try
                '    'update_accesstemp()
                'Catch ex As Exception

                'End Try
            End If
            pnadd.Visible = False
            append()
            gen_distribution_of_receipts()
            dtgridblotter.Focus()
        End If
    End Sub

    Private Sub gen_not()
        lstnot.Items.Clear()
        Dim notif As Integer = 0
        conn()
        sql = "SELECT a.accountnumber,isnull((select fullname from members where memcode=b.memcode),(select ctrname from center where accountnumber=a.accountnumber)) as fullname,a.debit,a.postno,a.refrence,a.remarks,a.gl_sa,a.postmode FROM Accountledger a, Accountmaster b WHERE a.Active='N' and a.accountnumber=b.accountnumber and a.debit>0"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        While (rd.Read())
            notif = notif + 1
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstnot.Items.Add(lvitem)
        End While
        lblnot.Text = notif
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_not1()
        Dim notif As Integer = 0
        conn()
        sql = "SELECT a.accountnumber,isnull((select fullname from members where memcode=b.memcode),(select ctrname from center where accountnumber=a.accountnumber)) as fullname,a.credit,a.postno,a.refrence,a.remarks,a.gl_sa,a.postmode FROM Accountledger a, Accountmaster b WHERE a.Active='N' and a.accountnumber=b.accountnumber and a.credit>0"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        lstnot1.Items.Clear()
        While (rd.Read())
            notif = notif + 1
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstnot1.Items.Add(lvitem)
        End While
        lblnot1.Text = notif
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub dtgridblotter_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridblotter.DoubleClick
        popup_add_rec()
    End Sub

    Private Sub dtgridblotter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgridblotter.KeyDown
        If e.KeyCode = Keys.Enter Then
            popup_add_rec()
        End If
    End Sub

    Private Sub txt_rf_rec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtpayee.Focus()
        End If
    End Sub

    Private Sub txtpayee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayee.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgl.Focus()
            txtremarks.Focus()
        End If
    End Sub

    Private Sub txtremarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgl.Focus()
        End If
    End Sub

    Private Sub txtacctref_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtacctref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Focus()
        End If
    End Sub

    Private Sub txtamount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave_receipt.Focus()
        End If
    End Sub


    Private Sub bttnsave_dis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave_dis.Click
        'declare variables
        'Dim cAccountNumber As String = lstnot1.FocusedItem.SubItems(0).Text
        'Dim cPostNumber As String = lstnot1.FocusedItem.SubItems(3).Text

        time = DateTime.Now.Hour & ":" & DateTime.Now.Minute
        If txtref1.Text.Trim = "" Then
            'MsgBox("Reference cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtref1.BackColor = Color.Red
            txtref1.ForeColor = Color.White
            txtref1.Focus()
        ElseIf txtpayee1.Text.Trim = "" Then
            'MsgBox("Payee cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtpayee1.BackColor = Color.Red
            txtpayee1.ForeColor = Color.White
            txtpayee1.Focus()
        ElseIf txtremarks1.Text.Trim = "" Then
            'MsgBox("Remarks cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtremarks1.BackColor = Color.Red
            txtremarks1.ForeColor = Color.White
            txtremarks1.Focus()
        ElseIf txtpayee1.Text.Trim = "" Then
            'MsgBox("Payee cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtpayee1.BackColor = Color.Red
            txtpayee1.ForeColor = Color.White
            txtpayee1.Focus()
        ElseIf txtgl1.Text.Trim = "" Then
            txtgl1.Focus()
        ElseIf txtacct_ref1.Text.Trim = "" Then
            'MsgBox("Account reference cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtacct_ref1.BackColor = Color.Red
            txtacct_ref1.ForeColor = Color.White
            txtacct_ref1.Focus()
        ElseIf txtamount1.Text.Trim = "" Then
            'MsgBox("Amount cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtamount1.BackColor = Color.Red
            txtamount1.ForeColor = Color.White
            txtamount1.Focus()
        ElseIf Decimal.Parse(txtamount1.Text) <= 0 Then
            'MsgBox("Invalid input amount.", MsgBoxStyle.Exclamation, "Invalid")
            If MessageBox.Show("Amount disburse is a zero value. Would like to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                GoTo 3
            Else
                txtamount1.BackColor = Color.Red
                txtamount1.ForeColor = Color.White
                txtamount1.Focus()
            End If
        Else
3:          If IDdisburse = 0 Then
                conn()
                sql = "INSERT INTO CashiersTransaction (Payee,Debit,Credit,Reference,Remarks,GLaccount,AcctReference,Trndate,Ttime,UserID) "
                sql += "VALUES('" + txtpayee1.Text + "',0," + Double.Parse(txtamount1.Text).ToString + ",'" + txtref1.Text + "','" + txtremarks1.Text + "','" + txtgl1.SelectedValue + "','" + txtacct_ref1.Text + "','" + dt_disburse.Value + "','" + time + "','" + user + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                txtamount1.Text = 0
                Try
                    'check the value 
                    'MsgBox("Account#:" + lstnot1.FocusedItem.SubItems(0).Text + " post #:" + lstnot1.FocusedItem.SubItems(3).Text, MsgBoxStyle.Exclamation, "Message")

                    conn()

                    'deactivated 07/26/2023
                    'sql = "UPDATE Accountledger set Active='Y' WHERE Accountnumber='" + lstnot1.FocusedItem.SubItems(0).Text + "' and postno=" + lstnot1.FocusedItem.SubItems(3).Text + ""
                    'cmd = New SqlCommand(sql, myConn)
                    'myConn.Open()
                    'cmd.ExecuteNonQuery()
                    'myConn.Close()


                    'updated 07/26/2023
                    'extract the date thru stored procedure
                    Dim cmdLedgerSetActive As New SqlCommand

                    cmdLedgerSetActive.Connection = myConn
                    cmdLedgerSetActive.CommandTimeout = 300
                    cmdLedgerSetActive.CommandType = CommandType.StoredProcedure
                    cmdLedgerSetActive.CommandText = "usp_AccountLedger_Set_Active"
                    cmdLedgerSetActive.Parameters.AddWithValue("@AccountNumber", lstnot1.FocusedItem.SubItems(0).Text)
                    cmdLedgerSetActive.Parameters.AddWithValue("@PostNumber", lstnot1.FocusedItem.SubItems(3).Text)

                    myConn.Open()
                    rd = cmdLedgerSetActive.ExecuteReader()

                    'remarks here as no need data to retrieve
                    'While (rd.Read())
                    'Dim lvitem As New ListViewItem(rd(0).ToString())
                    'For i As Integer = 1 To rd.FieldCount - 1
                    'lvitem.SubItems.Add(rd(i).ToString())
                    'Next
                    'lstsa.Items.Add(lvitem)
                    'reference = rd("ornumber")
                    'End While

                    'close connection
                    rd.Close()
                    myConn.Close()

                Catch ex As Exception

                End Try
                Try
                    conn()
                    sql = "UPDATE CBUledger set Active='Y' WHERE CBUAccount='" + txtacct_ref1.Text + "' and postno=" + lstcbu1.FocusedItem.SubItems(3).Text + ""
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                Catch ex As Exception

                End Try

            Else
                conn()
                sql = "UPDATE CashiersTransaction set Payee='" + txtpayee1.Text + "',Credit=" + Decimal.Parse(txtamount1.Text).ToString + ",Debit=0,Reference='" + txtref1.Text + "',Remarks='" + txtremarks1.Text + "',GLaccount='" + txtgl1.SelectedValue + "',AcctReference='" + txtacct_ref1.Text + "',Trndate='" + dt_disburse.Value + "',Ttime='" + time + "',UserID='" + user + "' WHERE ID=" + dtgrid_disburse.CurrentRow.Cells(6).Value + ""
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                conn()
                Dim reasons As String = "Editing cashiers transaction of reference " & txt_ref.Text & " amount of " & txtamount.Text & " gl account of " & txtgl.SelectedValue
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','" + reasons + "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                'Try
                '    'update_accesstemp()
                'Catch ex As Exception

                'End Try
            End If

            pnadd1.Visible = False
            append()
            gen_distribution_of_payments()
            dtgrid_disburse.Focus()
        End If
    End Sub

    Private Sub RadButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        pnadd1.Visible = False
    End Sub
    Private Sub txtsearchGL1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub txtref1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpayee1.Focus()
        End If
    End Sub

    Private Sub txtpayee1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayee1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtremarks1.Focus()
        End If
    End Sub

    Private Sub txtremarks1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremarks1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgl1.Focus()
        End If
    End Sub

    Private Sub txtacct_ref1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtacct_ref1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount1.Focus()
        End If

    End Sub

    Private Sub txtamount1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount1.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave_dis.Focus()
        End If
    End Sub

    Private Sub txtgl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtacct_ref1.Focus()
        End If
    End Sub

    Private Sub txtgl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtacctref.Focus()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        pnadd.Visible = True
        If TRNX = "CLOSED" Then
            txtgl.Enabled = False
            txtamount.Enabled = False
        End If

        IDreceipt = 1
        If dtgridblotter.CurrentRow.Cells(6).Value <> "" Then
            id = dtgridblotter.CurrentRow.Cells(6).Value
            lbleditgl.Enabled = True
            lbleditamnt.Enabled = True
            pnreceipts.Visible = False
            txt_ref.Text = dtgridblotter.CurrentRow.Cells(0).Value
            txtpayee.Text = dtgridblotter.CurrentRow.Cells(1).Value
            txtremarks.Text = dtgridblotter.CurrentRow.Cells(2).Value
            txtamount.Text = dtgridblotter.CurrentRow.Cells(3).Value
            txtacctref.Text = dtgridblotter.CurrentRow.Cells(4).Value
            txtgl.SelectedValue = dtgridblotter.CurrentRow.Cells(5).Value
            pnadd.Visible = True
            txt_ref.Focus()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If TRNX = "CLOSED" Then
            delete = True
            pnreceipts.Visible = True
            txtpassword_rec.Focus()
        Else
            del_receipts()
        End If
    End Sub

    Private Sub popup_add_rec()
        If TRNX = "ACTIVE" Then
            IDreceipt = 0
            gen_not()
            gen_not_stocks()
            gen_notif_cbu()
            pnadd.Visible = True
            'txt_ref.Clear()
            txtpayee.Clear()
            txtremarks.Clear()
            txtacctref.Clear()
            txtamount.Text = 0
            txt_ref.Focus()
            txt_ref.BackColor = Color.White
            txt_ref.ForeColor = Color.Black
            txtpayee.BackColor = Color.White
            txtpayee.ForeColor = Color.Black
            txtremarks.BackColor = Color.White
            txtremarks.ForeColor = Color.Black
            txtacctref.BackColor = Color.White
            txtacctref.ForeColor = Color.Black
            txtamount.BackColor = Color.White
            txtamount.ForeColor = Color.Black
            txtgl.Enabled = True
            txtamount.Enabled = True
            lbleditamnt.Enabled = False
            lbleditgl.Enabled = False
        End If
    End Sub

    Private Sub popup_add_dis()
        If TRNX = "ACTIVE" Then
            IDdisburse = 0
            gen_not1()
            gen_notif_cbu1()
            pnadd1.Visible = True
            'txtref1.Clear()
            txtpayee1.Clear()
            txtremarks1.Clear()
            txtacct_ref1.Clear()
            txtamount1.Text = 0
            txtref1.Focus()
            txtref1.BackColor = Color.White
            txtref1.ForeColor = Color.Black
            txtpayee1.BackColor = Color.White
            txtpayee1.ForeColor = Color.Black
            txtacct_ref1.BackColor = Color.White
            txtacct_ref1.ForeColor = Color.Black
            txtremarks1.BackColor = Color.White
            txtremarks1.ForeColor = Color.Black
            txtamount1.BackColor = Color.White
            txtamount1.ForeColor = Color.Black
            txtgl1.Enabled = True
            txtamount1.Enabled = True
            lbleditamnt1.Enabled = False
            lbleditgl1.Enabled = False
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        popup_add_rec()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        popup_add_dis()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If TRNX = "CLOSED" Then
            delete = True
            pndes.Visible = True
            txtpass_dess.Focus()
        Else
            del_disbursed()
        End If
    End Sub

    Private Sub dt_receipts_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_receipts.ValueChanged

    End Sub

    Private Sub dt_cb_disburse_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_disburse.ValueChanged

    End Sub

    Private Sub txtacctref_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtacctref.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtacctref.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtacct_ref1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtacct_ref1.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtacct_ref1.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtpayee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayee.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtpayee.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtpayee1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayee1.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtpayee1.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub append()
        Dim MySource_payee As New AutoCompleteStringCollection()
        Dim MySource_acctref As New AutoCompleteStringCollection()

        conn()
        sql = "SELECT DISTINCT Payee,AcctReference FROM CashiersTransaction"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read()
            MySource_payee.AddRange(New String() {rd("Payee").ToString})
            MySource_acctref.AddRange(New String() {rd("AcctReference").ToString})
        End While
        rd.Close()
        myConn.Close()
        With txtpayee
            .AutoCompleteCustomSource = MySource_payee
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .Height = 10
        End With
        With txtpayee1
            .AutoCompleteCustomSource = MySource_payee
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtacctref
            .AutoCompleteCustomSource = MySource_acctref
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtacct_ref1
            .AutoCompleteCustomSource = MySource_acctref
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub

    Private Sub lblnot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnot.Click
        If IDreceipt = 0 Then
            If lstnot.Visible = False Then
                lstnot.Visible = True
            Else
                lstnot.Visible = False
            End If
        End If
    End Sub

    Private Sub pnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnadd.Click
        lstnot.Visible = False
    End Sub

    Private Sub lstnot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstnot.Click
        lstnot.Visible = False
        txtacctref.Text = lstnot.FocusedItem.SubItems(0).Text
        txtpayee.Text = lstnot.FocusedItem.SubItems(1).Text
        txtremarks.Text = lstnot.FocusedItem.SubItems(5).Text & "(" & lstnot.FocusedItem.SubItems(7).Text & ")"
        txtamount.Text = lstnot.FocusedItem.SubItems(2).Text
        txt_ref.Text = lstnot.FocusedItem.SubItems(4).Text
        txtgl.SelectedValue = lstnot.FocusedItem.SubItems(6).Text
    End Sub

    Private Sub lblnot1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnot1.Click
        If IDdisburse = 0 Then
            If lstnot1.Visible = False Then
                lstnot1.Visible = True
            Else
                lstnot1.Visible = False
            End If
        End If
    End Sub

    Private Sub lstnot1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstnot1.Click
        lstnot1.Visible = False
        txtacct_ref1.Text = lstnot1.FocusedItem.SubItems(0).Text
        txtpayee1.Text = lstnot1.FocusedItem.SubItems(1).Text
        txtremarks1.Text = lstnot1.FocusedItem.SubItems(5).Text & " (" & lstnot1.FocusedItem.SubItems(7).Text & ")"
        txtamount1.Text = lstnot1.FocusedItem.SubItems(2).Text
        txtref1.Text = lstnot1.FocusedItem.SubItems(4).Text
        txtgl1.SelectedValue = lstnot1.FocusedItem.SubItems(6).Text
        bttnsave_dis.Focus()
    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtamount.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtamount.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtamount.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            ''If e.KeyChar = Chr(13) Then GetNextControl(bttnsave_receipt, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount.KeyUp
        Try
            If Not txtamount.Text.Contains(".") And Double.Parse(txtamount.Text) > 0 Then
                txtamount.Text = Format(Val(Replace(txtamount.Text, ",", "")), "#,###,###")
                txtamount.Select(txtamount.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount1.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtamount1.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtamount1.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtamount1.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            'If e.KeyChar = Chr(13) Then GetNextControl(bttnsave_dis, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamount1.KeyUp
        Try
            If Not txtamount1.Text.Contains(".") And Double.Parse(txtamount1.Text) > 0 Then
                txtamount1.Text = Format(Val(Replace(txtamount1.Text, ",", "")), "#,###,###")
                txtamount1.Select(txtamount1.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub del_receipts()
        If MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "DELETE FROM CashiersTransaction WHERE ID=" + dtgridblotter.CurrentRow.Cells(6).Value + ""
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            delete = False
            conn()
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Delete receipt " & dtgridblotter.CurrentRow.Cells(0).Value & " from " & dtgridblotter.CurrentRow.Cells(1).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            pnreceipts.Visible = False

            gen_distribution_of_receipts()
        End If
    End Sub

    Private Sub RadButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont1.Click
        If delete = True Then
            If txtpassword_rec.Text = adminpass Then
                If MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    del_receipts()
                Else
                    MessageBox.Show("Invalid password")
                End If
                'Else
                '    Try
                '        mysqlconn()
                '        sql = "select * from access_temp where accesspass='" + txtpassword_rec.Text + "' and userid='" + user + "' and status='A'"
                '        mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
                '        mysqlmyconn.Open()
                '        mysqlrd = mysqlcmd.ExecuteReader
                '        If mysqlrd.Read Then
                '            If txtpassword_rec.Text = mysqlrd("accesspass") Then
                '                del_receipts()
                '            End If
                '        End If
                '        mysqlrd.Close()
                '        mysqlmyconn.Close()

                '        update_accesstemp()
                '    Catch ex As Exception
                '        MsgBox("Cant connect to Mysql host.", MsgBoxStyle.Exclamation, "Message")
                '    End Try
            End If
        Else
            Cursor = Cursors.AppStarting
            access1()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub access1()
        Try
            'mysqlconn()
            'sql = "select * from access_temp where accesspass='" + txtpassword_rec.Text + "' and userid='" + user + "' and status='A'"
            'mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            'mysqlmyconn.Open()
            'mysqlrd = mysqlcmd.ExecuteReader
            'If mysqlrd.Read Then
            If txtpassword_rec.Text = adminpass Then
                IDreceipt = 1
                If dtgridblotter.CurrentRow.Cells(6).Value <> "" Then
                    If editgl = True Then
                        txtgl.Enabled = True
                        txtamount.Enabled = False
                    End If
                    If editamount = True Then
                        txtamount.Enabled = True
                        txtgl.Enabled = False
                    End If
                    pnreceipts.Visible = False
                    txt_ref.Focus()
                End If
                lblalert_pass1.Visible = False
                txtpassword_rec.Clear()
            Else
                MessageBox.Show("Invalid password")
                lblalert_pass1.Visible = True '
                txtpassword_rec.Focus()
            End If
            'Else
            'If txtpassword_rec.Text = userpass Then
            '    IDreceipt = 1
            '    If dtgridblotter.CurrentRow.Cells(6).Value <> "" Then
            '        If editgl = True Then
            '            txtgl.Enabled = True
            '            txtamount.Enabled = False
            '        End If
            '        If editamount = True Then
            '            txtamount.Enabled = True
            '            txtgl.Enabled = False
            '        End If
            '        pnreceipts.Visible = False
            '        txt_ref.Focus()
            '    End If
            '    lblalert_pass1.Visible = False
            '    txtpassword_rec.Clear()
            'Else
            '    lblalert_pass1.Visible = True
            '    txtpassword_rec.Focus()
            'End If
            'End If
            'mysqlrd.Close()
            'mysqlmyconn.Close()
        Catch ex As Exception
            If txtpassword_rec.Text = userpass Then
                IDreceipt = 1
                If dtgridblotter.CurrentRow.Cells(6).Value <> "" Then
                    If editgl = True Then
                        txtgl.Enabled = True
                        txtamount.Enabled = False
                    End If
                    If editamount = True Then
                        txtamount.Enabled = True
                        txtgl.Enabled = False
                    End If
                    pnreceipts.Visible = False
                    txt_ref.Focus()
                End If
                lblalert_pass1.Visible = False
                txtpassword_rec.Clear()
            Else
                lblalert_pass1.Visible = True
                txtpassword_rec.Focus()
            End If
        End Try
    End Sub

    Private Sub RadButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        pnreceipts.Visible = False
    End Sub

    Private Sub del_disbursed()
        If MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "DELETE FROM CashiersTransaction WHERE ID=" + dtgrid_disburse.CurrentRow.Cells(6).Value + ""
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            delete = False
            conn()
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Delete disbursed " & dtgrid_disburse.CurrentRow.Cells(0).Value & " from " & dtgrid_disburse.CurrentRow.Cells(1).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            pndes.Visible = False
            gen_distribution_of_payments()
        End If
    End Sub

    Private Sub bttncont2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncont2.Click
        If delete = True Then
            If txtpass_dess.Text = adminpass Then
                del_disbursed()
                'Else
                '    mysqlconn()
                '    sql = "select * from access_temp where accesspass='" + txtpass_dess.Text + "' and userid='" + user + "' and status='A'"
                '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
                '    mysqlmyconn.Open()
                '    mysqlrd = mysqlcmd.ExecuteReader
                '    If mysqlrd.Read Then
                '        If txtpass_dess.Text = mysqlrd("accesspass") Then
                '            del_disbursed()
                '        End If
                '        Try
                '            update_accesstemp()
                '        Catch ex As Exception

                '        End Try
                '    End If
            Else
                MessageBox.Show("Invalid password")
            End If
        Else
            Cursor = Cursors.AppStarting
            access2()
            Cursor = Cursors.Default
        End If
        txtpass_dess.Clear()
    End Sub

    Private Sub access2()
        Try '
            'mysqlconn()
            'sql = "select * from access_temp where accesspass='" + txtpass_dess.Text + "' and userid='" + user + "' and status='A'"
            'mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            'mysqlmyconn.Open()
            'mysqlrd = mysqlcmd.ExecuteReader
            'If mysqlrd.Read Then
            If txtpass_dess.Text = adminpass Then
                pndes.Visible = False
                IDdisburse = 1
                If dtgrid_disburse.CurrentRow.Cells(6).Value <> "" Then
                    If editgl1 = True Then
                        txtgl1.Enabled = True
                        txtamount1.Enabled = False
                    End If
                    If editamount1 = True Then
                        txtamount1.Enabled = True
                        txtgl1.Enabled = False
                    End If
                    txtref1.Focus()
                End If
                lblalert_des.Visible = False
                txtpass_dess.Clear()
            Else
                MessageBox.Show("Invalid password")
                lblalert_des.Visible = True
                txtpassword_rec.Focus()
            End If
            'Else
            'If txtpass_dess.Text = userpass Then
            '    pndes.Visible = False
            '    IDdisburse = 1
            '    If dtgrid_disburse.CurrentRow.Cells(6).Value <> "" Then
            '        If editgl1 = True Then
            '            txtgl1.Enabled = True
            '            txtamount1.Enabled = False
            '        End If
            '        If editamount1 = True Then
            '            txtamount1.Enabled = True
            '            txtgl1.Enabled = False
            '        End If
            '        txtref1.Focus()
            '    End If
            '    lblalert_des.Visible = False
            '    txtpass_dess.Clear()
            'Else
            '    lblalert_des.Visible = True
            '    txtpassword_rec.Focus()
            'End If
            'End If
            'mysqlrd.Close()
            'mysqlmyconn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            If txtpass_dess.Text = userpass Then
                pndes.Visible = False
                IDdisburse = 1
                If dtgrid_disburse.CurrentRow.Cells(6).Value <> "" Then
                    If editgl1 = True Then
                        txtgl1.Enabled = True
                        txtamount1.Enabled = False
                    End If
                    If editamount1 = True Then
                        txtamount1.Enabled = True
                        txtgl1.Enabled = False
                    End If
                    txtref1.Focus()
                End If
                lblalert_des.Visible = False
                txtpass_dess.Clear()
            Else
                lblalert_des.Visible = True
                txtpassword_rec.Focus()
            End If
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        pndes.Visible = True
        If TRNX = "CLOSED" Then
            txtgl1.Enabled = False
            txtamount1.Enabled = False
        End If

        IDdisburse = 1
        If dtgrid_disburse.CurrentRow.Cells(6).Value <> "" Then
            lbleditgl1.Enabled = True
            lbleditamnt1.Enabled = True
            pndes.Visible = False
            txtref1.Text = dtgrid_disburse.CurrentRow.Cells(0).Value
            txtpayee1.Text = dtgrid_disburse.CurrentRow.Cells(1).Value
            txtremarks1.Text = dtgrid_disburse.CurrentRow.Cells(2).Value
            txtamount1.Text = dtgrid_disburse.CurrentRow.Cells(3).Value
            txtacct_ref1.Text = dtgrid_disburse.CurrentRow.Cells(4).Value
            txtgl1.SelectedValue = dtgrid_disburse.CurrentRow.Cells(5).Value
            pnadd1.Visible = True
            txtref1.Focus()
        End If
    End Sub

    Private Sub RadButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton4.Click
        pndes.Visible = False
    End Sub

    Private Sub txtpassword_rec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword_rec.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttncont1.Focus()
        End If
    End Sub

    Private Sub txtpass2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass_dess.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttncont2.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleditgl.LinkClicked
        editgl = True
        editamount = False
        pnreceipts.Visible = True
        txtpassword_rec.Focus()
        pnreceipts.BringToFront()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleditamnt.LinkClicked
        editamount = True
        editgl = False
        pnreceipts.Visible = True
        txtpassword_rec.Focus()
        pnreceipts.BringToFront()
    End Sub

    Private Sub lbleditgl1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleditgl1.LinkClicked
        editgl1 = True
        editamount1 = False
        pndes.Visible = True
        txtpass_dess.Focus()
        pndes.BringToFront()
    End Sub

    Private Sub lbleditamnt1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbleditamnt1.LinkClicked
        editgl1 = False
        editamount1 = True
        pndes.Visible = True
        txtpass_dess.Focus()
        pndes.BringToFront()
    End Sub

    Private Sub bttnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnprintCB.Click
        frm_cb_reports.Show()
        frm_cb_reports.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub gen_summary()
        lblcredit.Text = 0
        lbldebit.Text = 0
        dtgrd_summary.Rows.Clear()
        conn()
        sql = "select sum(a.debit) as debit,sum(a.credit) as credit,b.accountcode,b.acct_description from CashiersTransaction a, ChartAccounts b where a.trndate='" + dtden.Value + "' and a.GLaccount=b.accountcode group by b.accountcode,b.acct_description"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            dtgrd_summary.Rows.Add(rd("accountcode"), rd("acct_description"), rd("debit"), rd("credit"))
        End While
        rd.Close()
        myConn.Close()

        Try
            For x As Integer = 0 To dtgrd_summary.Rows.Count - 1
                If x Mod 2 Then
                    dtgrd_summary.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
                lbldebit.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(dtgrd_summary.Rows(x).Cells(2).Value) + Double.Parse(lbldebit.Text))
                lblcredit.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Double.Parse(dtgrd_summary.Rows(x).Cells(3).Value) + Double.Parse(lblcredit.Text))
                Dim row As DataGridViewRow = dtgrd_summary.Rows(x)
                row.Height = 30
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose_trnx.Click
        If Double.Parse(lblvariance.Text) = 0 Then
            If MessageBox.Show("Are you sure you want to close cashier's transaction?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                conn()
                sql = "UPDATE denomination SET den_type='CLOSED' WHERE den_date='" + dtden.Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox(dtden.Value & " Transaction was successfully closed.", MsgBoxStyle.Information, "Completed")
                check_den()
            End If
        Else
            MsgBox("Variance must be a zero value to close this transaction.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub bttnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnrefresh.Click
        gen_summary()
    End Sub

    Private Sub bttnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnview.Click
        dt_receipts.Value = dtden.Value
        dt_disburse.Value = dtden.Value
        gen_distribution_of_payments()
        gen_distribution_of_receipts()
        gen_summary()
        check_den()
        conn()
        sql = "SELECT * FROM denomination WHERE den_date='" + dtden.Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtonethousand.Text = rd("onethousand").ToString
            txtfivehundred.Text = rd("fivehundred").ToString
            txttwohundred.Text = rd("twohundred").ToString
            txtonehundred.Text = rd("onehundred").ToString
            txtfifty.Text = rd("fifty").ToString
            txttwenty.Text = rd("twenty").ToString
            txtten.Text = rd("ten").ToString
            txtfive.Text = rd("five").ToString
            txtone.Text = rd("peso").ToString
            txtcent.Text = rd("centavo").ToString
            txt_tencent.Text = rd("tencent").ToString
            txt_centfive.Text = rd("fivecent").ToString
            lbltotalden.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", (((Double.Parse(txtonethousand.Text) * 1000) + (Double.Parse(txtfivehundred.Text) * 500)) + (Double.Parse(txtonehundred.Text) * 100)) + (Double.Parse(txttwohundred.Text) * 200) + (Double.Parse(txtfifty.Text) * 50) + (Double.Parse(txttwenty.Text) * 20) + (Double.Parse(txtten.Text) * 10) + (Double.Parse(txtfive.Text) * 5) + (Double.Parse(txtone.Text) * 1) + (Double.Parse(txtcent.Text) * 0.25))
        Else
            If MessageBox.Show("No data found. Would you like to reset all input field?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                txtonethousand.Text = 0
                txtfivehundred.Text = 0
                txttwohundred.Text = 0
                txtonehundred.Text = 0
                txtfifty.Text = 0
                txttwenty.Text = 0
                txtten.Text = 0
                txtfive.Text = 0
                txtone.Text = 0
                txtcent.Text = 0
                lbltotalden.Text = 0
                txt_tencent.Text = 0
                txt_centfive.Text = 0
            End If
        End If
        rd.Close()
        myConn.Close()
        compute_blotter()
        bttncompute.Enabled = True
        If usertype = "Audit" Then
            bttnprintCB.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        select_GLview1()
        txtgl_view1.Focus()
    End Sub

    Private Sub LinkLabel2_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        select_GLview2()
        txtgl_view2.Focus()
    End Sub

    Private Sub txtgl_view1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgl_view1.Validated
        gen_distribution_of_receipts()
    End Sub

    Private Sub txtgl_view2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgl_view2.Validated
        gen_distribution_of_payments()
    End Sub

    Private Sub dtden_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtden.ValueChanged
        bttncompute.Enabled = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkunclosed.LinkClicked
        pnunclose_password.Visible = True
        txt_trnpassword.Focus()
    End Sub

    Private Sub RadButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton5.Click
        pnunclose_password.Visible = False
    End Sub

    Private Sub RadButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton6.Click
        If txt_trnpassword.Text = adminpass Then
            unclosed_transaction()
            'Else
            '    Try
            '        mysqlconn()
            '        sql = "select * from access_temp where accesspass='" + txt_trnpassword.Text + "' and userid='" + user + "' and status='A'"
            '        mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            '        mysqlmyconn.Open()
            '        mysqlrd = mysqlcmd.ExecuteReader
            '        If mysqlrd.Read Then
            '            If txt_trnpassword.Text = mysqlrd("accesspass") Then
            '                unclosed_transaction()
            '            End If
            '        End If
            '        mysqlrd.Close()
            '        mysqlmyconn.Close()

            '        update_accesstemp()
            '    Catch ex As Exception
            '        MsgBox("Cant connect to Mysql host.", MsgBoxStyle.Exclamation, "Message")
            '    End Try
        Else
            MessageBox.Show("Invalid password")
        End If
    End Sub

    Private Sub unclosed_transaction()
        conn()
        sql = "UPDATE denomination SET den_type='ACTIVE' WHERE den_date='" + dtden.Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        TRNX = "ACTIVE"
        bttnprintCB.Enabled = False
        grp1.Enabled = True
        pnunclose_password.Visible = False
        MsgBox(dtden.Value & " Transaction was successfully active.", MsgBoxStyle.Information, "Message")
        check_den()
        txt_trnpassword.Clear()
    End Sub

    Private Sub lblstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstock.Click
        If IDreceipt = 0 Then
            If lst_stockrel.Visible = False Then
                lst_stockrel.Visible = True
            Else
                lst_stockrel.Visible = False
            End If
        End If
    End Sub

    Private Sub gen_not_stocks()
        Dim notif As Integer = 0
        conn()
        sql = "SELECT ID,Reference,Payee,Remarks,Debit,Credit,GLaccount,AcctReference,Trndate from Cashiersdummy WHERE status='A'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        lst_stockrel.Items.Clear()
        While (rd.Read())
            notif = notif + 1
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lst_stockrel.Items.Add(lvitem)
        End While
        lblstock.Text = notif
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub lst_stockrel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_stockrel.Click
        lstnot.Visible = False
        id = lst_stockrel.FocusedItem.SubItems(0).Text
        txt_ref.Text = lst_stockrel.FocusedItem.SubItems(1).Text
        txtacctref.Text = 0
        txtpayee.Text = lst_stockrel.FocusedItem.SubItems(2).Text
        txtremarks.Text = lst_stockrel.FocusedItem.SubItems(3).Text
        txtamount.Text = lst_stockrel.FocusedItem.SubItems(4).Text
        txtgl.SelectedValue = lst_stockrel.FocusedItem.SubItems(6).Text
        lst_stockrel.Visible = False
    End Sub

    Private Sub lblnotcbu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnotcbu.Click
        If IDreceipt = 0 Then
            If lstcbu.Visible = False Then
                lstcbu.Visible = True
            Else
                lstcbu.Visible = False
            End If
        End If
    End Sub

    Private Sub gen_notif_cbu()
        lstcbu.Items.Clear()
        Dim notif As Integer = 0
        conn()
        sql = "SELECT a.CBUAccount,b.fullname,a.debit,a.postno,a.reference,a.remarks,a.postmode,a.GL_loans FROM cbuledger a, members b WHERE a.Active='N' and a.CBUAccount=b.CBUAccount and a.debit>0"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        While (rd.Read())
            notif = notif + 1
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstcbu.Items.Add(lvitem)
        End While
        lblnotcbu.Text = notif
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub lstcbu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstcbu.Click
        lstcbu.Visible = False
        txtacctref.Text = lstcbu.FocusedItem.SubItems(0).Text
        txtpayee.Text = lstcbu.FocusedItem.SubItems(1).Text
        txtremarks.Text = lstcbu.FocusedItem.SubItems(5).Text
        txtamount.Text = lstcbu.FocusedItem.SubItems(2).Text
        txt_ref.Text = lstcbu.FocusedItem.SubItems(4).Text
        txtgl.SelectedValue = lstcbu.FocusedItem.SubItems(7).Text
    End Sub

    Private Sub gen_notif_cbu1()
        lstcbu1.Items.Clear()
        Dim notif As Integer = 0
        conn()
        sql = "SELECT a.CBUAccount,b.fullname,a.credit,a.postno,a.reference,a.remarks,a.postmode,a.GL_loans FROM cbuledger a, members b WHERE a.Active='N' and a.CBUAccount=b.CBUAccount and a.credit>0"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        While (rd.Read())
            notif = notif + 1
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstcbu1.Items.Add(lvitem)
        End While
        lblcbu1.Text = notif
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub lblcbu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcbu1.Click
        If IDdisburse = 0 Then
            If lstcbu1.Visible = False Then
                lstcbu1.Visible = True
            Else
                lstcbu1.Visible = False
            End If
        End If
    End Sub

    Private Sub lstcbu1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstcbu1.Click
        lstcbu1.Visible = False
        txtacct_ref1.Text = lstcbu1.FocusedItem.SubItems(0).Text
        txtpayee1.Text = lstcbu1.FocusedItem.SubItems(1).Text
        txtremarks1.Text = lstcbu1.FocusedItem.SubItems(5).Text
        txtamount1.Text = lstcbu1.FocusedItem.SubItems(2).Text
        txtref1.Text = lstcbu1.FocusedItem.SubItems(4).Text
        txtgl1.SelectedValue = lstcbu1.FocusedItem.SubItems(7).Text
    End Sub


End Class