Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class frm_receivestocks
    Public comboCol1 As New GridViewMultiComboBoxColumn("Descriptions")

    Private Sub frm_receivestocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dttrn.Value = systemdate
        select_warehouse()
        creategview()
        If Me.Text = "Edit Received Stocks" Then
            txtref.Enabled = False
            gen_stocks()
            dttrn.Enabled = False
        Else
            txtref.Enabled = True
        End If
    End Sub

    Private Sub gen_stocks()
        conn()
        sql = "SELECT a.*,b.ItemDesc FROM ItemInventory a, itemsMF b WHERE a.itemcode=b.itemcode and a.reference='" + frm_items.dtgrid_inv.CurrentRow.Cells(1).Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dttrn.Value = rd("trndate").ToString
            txtref.Text = rd("reference").ToString
            txtwarehouse1.SelectedValue = rd("warehouseID").ToString
            txtdist.Text = rd("distributor").ToString
            txtcontact.Text = rd("encharge").ToString
            dtgrd_deduction.Rows.Add(rd("qty").ToString, rd("ItemCode").ToString, rd("ItemCode").ToString, rd("principal").ToString, rd("markup").ToString, rd("ItemDesc").ToString)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub select_warehouse()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM WareHouse"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("warehouseID").ToString, rd("Description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtwarehouse1.DataSource = table1
        Me.txtwarehouse1.AutoFilter = True
        txtwarehouse1.DisplayMember = "Description"
        txtwarehouse1.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtwarehouse1.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtwarehouse1.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtwarehouse1.EditorControl.Columns(0).Width = 100
        Me.txtwarehouse1.EditorControl.Columns(1).Width = 200
        Me.txtwarehouse1.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Public Sub creategview()
        'InitializeComponent()
        dtgrd_deduction.Columns.Clear()
        dtgrd_deduction.Rows.Clear()

        Dim deductionsMF As DataTable = New DataTable()
        conn()
        sql = "select ItemCode,Itemdesc from ItemsMF"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        deductionsMF.Columns.Add("Code")
        deductionsMF.Columns.Add("Descriptions")
        deductionsMF.Columns.Add("Item Price")
        deductionsMF.Columns.Add("Stocks")
        While (rd.Read())
            deductionsMF.Rows.Add(rd("ItemCode").ToString, rd("Itemdesc").ToString)
        End While
        rd.Close()
        myConn.Close()

        '0
        Dim qty As New GridViewTextBoxColumn("Qty")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(qty)
        qty.Width = 50

        '1
        comboCol1.DataSource = deductionsMF
        comboCol1.FieldName = "Descriptions"
        comboCol1.DisplayMember = "Descriptions"
        comboCol1.ValueMember = "Code"
        comboCol1.Width = 200
        comboCol1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgrd_deduction.Columns.Add(comboCol1)

        '2
        Dim code As New GridViewTextBoxColumn("Code")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(code)
        code.IsVisible = False
        '3
        Dim amount As New GridViewTextBoxColumn("Office Price")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(amount)
        amount.Width = 100
        '4
        Dim markup As New GridViewTextBoxColumn("Markup")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        Me.dtgrd_deduction.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextCell
        dtgrd_deduction.Columns.Add(markup)
        markup.Width = 100

        '5
        Dim itemdesc As New GridViewTextBoxColumn("itemdesc")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        Me.dtgrd_deduction.EnterKeyMode = RadGridViewEnterKeyMode.EnterMovesToNextCell
        dtgrd_deduction.Columns.Add(itemdesc)
        itemdesc.IsVisible = False
    End Sub

    Private Sub dtgrd_deduction_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_deduction.CellEditorInitialized
        If dtgrd_deduction.CurrentCell.ColumnIndex = 1 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.dtgrd_deduction.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol1.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
        End If
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtref.Text.Trim = "" Then
            MsgBox("Distributor code cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtdist.Text.Trim = "" Then
            MsgBox("Distributor name cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If Me.Text = "Edit Received Stocks" Then
                conn()
                sql = "DELETE FROM ItemInventory WHERE reference='" + txtref.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
                    If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                        conn()
                        sql = "INSERT INTO ItemInventory (qty,ItemCode,principal,markup,trndate,encharge,distributor,reference,userID,warehouseID,grocery) VALUES "
                        sql += "(" + dtgrd_deduction.Rows(i).Cells(0).Value + ","
                        sql += "'" + dtgrd_deduction.Rows(i).Cells(1).Value + "',"
                        sql += "" + dtgrd_deduction.Rows(i).Cells(3).Value + ","
                        sql += "" + dtgrd_deduction.Rows(i).Cells(4).Value + ","
                        sql += "'" + dttrn.Value + "',"
                        sql += "'" + txtcontact.Text + "',"
                        sql += "'" + txtdist.Text + "',"
                        sql += "'" + txtref.Text + "',"
                        sql += "'" + user.ToString + "',"
                        sql += "" + txtwarehouse1.SelectedValue.ToString + ","
                        sql += "'N')"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                Next
                MsgBox("Reference " & txtref.Text & " was successfully updated.", MsgBoxStyle.Information, "Success")
            Else
                For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
                    If dtgrd_deduction.Rows(i).Cells(2).Value <> "" Then
                        conn()
                        sql = "INSERT INTO ItemInventory (qty,ItemCode,principal,markup,trndate,encharge,distributor,reference,userID,warehouseID,grocery) VALUES "
                        sql += "(" + dtgrd_deduction.Rows(i).Cells(0).Value + ","
                        sql += "'" + dtgrd_deduction.Rows(i).Cells(1).Value + "',"
                        sql += "" + dtgrd_deduction.Rows(i).Cells(3).Value + ","
                        sql += "" + dtgrd_deduction.Rows(i).Cells(4).Value + ","
                        sql += "'" + dttrn.Value + "',"
                        sql += "'" + txtcontact.Text + "',"
                        sql += "'" + txtdist.Text + "',"
                        sql += "'" + dtgrd_deduction.Rows(i).Cells(2).Value & "-" & txtref.Text + "',"
                        sql += "'" + user.ToString + "',"
                        sql += "" + txtwarehouse1.SelectedValue.ToString + ","
                        sql += "'N')"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                Next

                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Received stocks with reference " & txtref.Text & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                MsgBox("Item successfully received.", MsgBoxStyle.Information, "Success")
            End If
            txtref.Clear()
            txtdist.Clear()
            txtcontact.Clear()
            dtgrd_deduction.Rows.Clear()
        End If
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        Me.Close()
    End Sub

    Private Sub dtgrd_deduction_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_deduction.CellEndEdit
        If dtgrd_deduction.CurrentCell.ColumnIndex = 1 Then
            dtgrd_deduction.CurrentRow.Cells(2).Value = dtgrd_deduction.CurrentRow.Cells(1).Value
            conn()
            sql = "SELECT Itemdesc From ItemsMF WHERE itemCode='" + dtgrd_deduction.CurrentRow.Cells(1).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            If rd.Read Then
                dtgrd_deduction.CurrentRow.Cells(4).Value = 0
                dtgrd_deduction.CurrentRow.Cells(5).Value = rd("Itemdesc").ToString
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub
End Class