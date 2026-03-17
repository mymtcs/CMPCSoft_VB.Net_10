Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_edit_cbu_ledger
    Dim postno As Integer = 0
    Dim runbal As Integer = 0

    Private Sub frm_edit_cbu_ledger_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_savings.display_ledger()
    End Sub

    Private Sub frm_edit_savings_ledger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_GL()

        Me.Text = "Edit Ledger(" & frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value & ")"
        txtpdate.Value = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(0).Text
        select_post_mode()
        select_GL()
        txtpdate.Value = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(0).Text
        txtrmrks.Text = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(7).Text
        txtref.Text = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(6).Text
        txtamntdept.Text = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(3).Text
        txtamountwdraw.Text = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(4).Text
        postno = frm_cbuledger.lstsavingledger.FocusedItem.SubItems(1).Text

    End Sub

    Private Sub select_GL()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("GL_loans").ToString, rd("loandesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsavingstype.DataSource = table1
        Me.txtsavingstype.AutoFilter = True
        txtsavingstype.DisplayMember = "Description"
        txtsavingstype.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsavingstype.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsavingstype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsavingstype.EditorControl.Columns(0).Width = 100
        Me.txtsavingstype.EditorControl.Columns(1).Width = 200
        Me.txtsavingstype.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub gen_ref()
        Call conn()
        sql = "SELECT MAX(postno) As postno FROM AccountLedger WHERE accountnumber='" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        Dim ref As Integer = 0
        If rd.Read Then
            Try
                ref = Double.Parse(rd("postno")) + 1
            Catch ex As Exception
                ref = 1
            End Try
        End If
        rd.Close()
        myConn.Close()
        txtref.Text = systemdate.Month & "-" & ref.ToString("000000")
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

    Private Sub select_remrks()
        'Try
        Call conn()
        sql = "SELECT DISTINCT Remarks FROM accountledger GROUP BY Remarks ORDER BY Remarks ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        txtrmrks.Items.Clear()
        While rd.Read()
            txtrmrks.Items.Add(rd.Item("Remarks"))
        End While
        rd.Close()
        myConn.Close()
        'Catch ex As Exception
        'myConn.Close()
        'End Try
    End Sub

    Private Sub compute_runbal()
        conn()
        sql = "SELECT (SUM(b.debit)-SUM(b.credit))As SaAmnt "
        sql += "FROM Members a, CBULedger b WHERE a.CBUAccount=b.CBUAccount and a.CBUAccount ='" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            runbal = Double.Parse(rd("SaAmnt")) + Double.Parse(txtamntdept.Text)
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtpmode.Text.Trim = "" Then
            MsgBox("Please input post mode", MsgBoxStyle.Exclamation, "Message")
        ElseIf txtref.Text.Trim = "" Then
            MsgBox("Please input reference", MsgBoxStyle.Exclamation, "Message")
        ElseIf txtamntdept.Text.Trim = "" Then
            MsgBox("Please input deposit amount", MsgBoxStyle.Exclamation, "Message")
        ElseIf txtrmrks.Text.Trim = "" Then
            MsgBox("Please input remarks", MsgBoxStyle.Exclamation, "Message")
        Else
            If MessageBox.Show("Are you sure you want to update this savings ledger?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                conn()
                sql = "UPDATE CBULedger SET PostingDate='" + txtpdate.Value + "',Postmode='" + txtpmode.SelectedValue.ToString + "',Debit=" + txtamntdept.Text + ",Credit=" + txtamountwdraw.Text + ",Remarks='" + txtrmrks.Text + "',Reference='" + txtref.Text + "',userid='" + user + "', gl_loans='" + txtsavingstype.SelectedValue + "' WHERE CBUAccount='" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "' and postno=" + postno.ToString + ""
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                Try
                    conn()
                    sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Editing cbu ledger of " & frm_cbuledger.dtgridsaving.CurrentRow.Cells(1).Value & " with debit " & txtamntdept.Text & " withdraw of " & txtamountwdraw.Text & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                Catch ex As Exception

                End Try

                'insert_GL()
                txtamntdept.Clear()
                txtpmode.Text = ""
                txtref.Clear()
                txtrmrks.Text = ""
                Me.Close()
                'frm_savings.display_ledger()
            End If
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub

    Private Sub txtpdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpmode.Focus()
        End If
    End Sub

    Private Sub txtref_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrmrks.Focus()
        End If
    End Sub

    Private Sub txtrmrks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrmrks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamntdept.Focus()
        End If
    End Sub

    Private Sub txtamnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamntdept.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    Private Sub txtpmode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpmode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtref.Focus()
        End If
    End Sub

    Private Sub bttndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndelete.Click
        If MessageBox.Show("Are you sure you want to delete this ledger?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "UPDATE CBULedger SET Active='X' WHERE CBUAccount='" + frm_cbuledger.dtgridsaving.CurrentRow.Cells(0).Value + "' and postno=" + postno.ToString + ""
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "INSERT INTO logs (PnNumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Deleting savings ledger of " & frm_cbuledger.dtgridsaving.CurrentRow.Cells(1).Value & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        End If
    End Sub
End Class