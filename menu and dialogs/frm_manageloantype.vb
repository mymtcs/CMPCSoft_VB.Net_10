Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_manageloantype
    Dim code As Integer = 1

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_manageloantype_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        pnrate.Visible = False
    End Sub

    Private Sub frm_manageloantype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_loantype()
        view_loantype()
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM ChartAccounts WHERE Accttype='Receivable'"
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
        txtloantype.DataSource = table1
        Me.txtloantype.AutoFilter = True
        txtloantype.DisplayMember = "Description"
        txtloantype.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtloantype.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtloantype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtloantype.EditorControl.Columns(0).Width = 90
        Me.txtloantype.EditorControl.Columns(1).Width = 290
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Private Sub view_loantype()
        dtgrid_deductions.Rows.Clear()
        conn()
        sql = "SELECT * FROM Loantype"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtgrid_deductions.Rows.Add(rd("loancode").ToString, rd("loandesc").ToString, rd("rate").ToString, rd("SavingsPrcnt").ToString, rd("CF").ToString, rd("CBU").ToString, rd("penaltyrate").ToString, rd("GL_loans").ToString, rd("GroupType").ToString, rd("MultiProduct").ToString, rd("isPension").ToString, rd("isp3").ToString)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub dtgrid_deductions_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_deductions.CellEndEdit
       
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtcode.Text.Trim = "" Then
            MsgBox("Loan code cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf txtdescription.Text.Trim = "" Then
            MsgBox("Loan description cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf txtrate.Text.Trim = "" Then
            MsgBox("Loan rate cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf IsNumeric(txtrate.Text) = False Then
            MsgBox("Loan rate must be numeric.", MsgBoxStyle.Exclamation)
        ElseIf txtsavings.Text.Trim = "" Then
            MsgBox("Savings percent cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf txtcf.Text.Trim = "" Then
            MsgBox("CF amount cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf txtcbu.Text.Trim = "" Then
            MsgBox("CBU amount cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf txtpen.Text.Trim = "" Then
            MsgBox("Penalty rate cannot be empty.", MsgBoxStyle.Exclamation)
        ElseIf txtgrptype.Text.Trim = "" Then
            MsgBox("Group type must be setup.", MsgBoxStyle.Exclamation)
        ElseIf txtmarkup.Text.Trim = "" Then
            MsgBox("Markup type must be setup.", MsgBoxStyle.Exclamation)
        ElseIf txtpen.Text.Trim = "" Then
            MsgBox("Pension type must be setup.", MsgBoxStyle.Exclamation)
        Else
            conn()
            sql = "SELECT * FROM Loantype WHERE loancode='" + txtcode.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If MessageBox.Show(txtcode.Text & " code has already exist. Would you like to update this loan?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    conn()
                    sql = "UPDATE Loantype SET loandesc='" + txtdescription.Text + "',rate=" + txtrate.Text + ",SavingsPrcnt=" + txtsavings.Text + ",CF=" + txtcf.Text + ",CBU=" + txtcbu.Text + ",penaltyrate=" + txtpen.Text + ",GL_loans='" + txtloantype.SelectedValue + "',GroupType='" + txtgrptype.Text + "',MultiProduct='" + txtmarkup.Text + "',isPension='" + txtis_pension.Text + "',isP3='" + txtp3.Text + "', userID='" + user + "' WHERE loancode='" + rd("loancode").ToString + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                End If
            Else
                conn()
                sql = "INSERT INTO Loantype (loancode,loandesc,rate,SavingsPrcnt,CF,CBU,penaltyrate,GL_loans,GroupType,MultiProduct,isPension,isP3,userID) VALUES ('" + txtcode.Text + "','" + txtdescription.Text + "'," + txtrate.Text + "," + txtsavings.Text + "," + txtcf.Text + "," + txtcbu.Text + ",'" + txtpen.Text + "','" + txtloantype.SelectedValue + "','" + txtgrptype.Text + "','" + txtmarkup.Text + "','" + txtis_pension.Text + "','" + txtp3.Text + "','" + user + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                txtcode.Clear()
                txtdescription.Clear()
                txtrate.Text = 0
                txtsavings.Text = 0
                txtpen.Text = 0
                txtcf.Text = 0
                txtrate_per_t.Text = 0
                txtno_ofcycle.Text = 0
                txtgrptype.Text = ""
                txtmarkup.Text = ""
                txtis_pension.Text = ""
            End If
            rd.Close()
            myConn.Close()

            view_loantype()
        End If
    End Sub

    Private Sub dtgrid_deductions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_deductions.Click
        Try
            txtcode.Text = dtgrid_deductions.CurrentRow.Cells(0).Value
            txtdescription.Text = dtgrid_deductions.CurrentRow.Cells(1).Value
            txtrate.Text = dtgrid_deductions.CurrentRow.Cells(2).Value
            txtsavings.Text = dtgrid_deductions.CurrentRow.Cells(3).Value
            txtcf.Text = dtgrid_deductions.CurrentRow.Cells(4).Value
            txtcbu.Text = dtgrid_deductions.CurrentRow.Cells(5).Value
            txtpen.Text = dtgrid_deductions.CurrentRow.Cells(6).Value
            txtloantype.SelectedValue = dtgrid_deductions.CurrentRow.Cells(7).Value
            txtgrptype.Text = dtgrid_deductions.CurrentRow.Cells(8).Value
            txtmarkup.Text = dtgrid_deductions.CurrentRow.Cells(9).Value
            txtis_pension.Text = dtgrid_deductions.CurrentRow.Cells(10).Value
            txtp3.Text = dtgrid_deductions.CurrentRow.Cells(11).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            txtrate.Text = Double.Parse(txtrate_per_t.Text) / Double.Parse(txtno_ofcycle.Text)
        Catch ex As Exception

        End Try
        pnrate.Visible = False
    End Sub

    Private Sub txtrate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrate.Click
        pnrate.Visible = True
        txtrate_per_t.Focus()
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        txtcode.Clear()
        txtdescription.Clear()
        txtrate.Text = 0
        txtsavings.Text = 0
        txtpen.Text = 0
        txtcf.Text = 0
        txtrate_per_t.Text = 0
        txtno_ofcycle.Text = 0
        txtgrptype.Text = ""
        txtmarkup.Text = ""
        txtis_pension.Text = ""
    End Sub
End Class