Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class frm_releasestocks
    Public comboCol1 As New GridViewMultiComboBoxColumn("Descriptions")

    Private Sub frm_releasestocks_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_rel_stock_list.view_rel_stocks()
    End Sub

    Private Sub frm_receivestocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dttrn.Value = systemdate
        creategview()
        gen_reference()
    End Sub

    Private Sub gen_reference()
        conn()
        sql = "select (count(x.reference)+1) as code from(select reference from loanitems where trndate='" & dttrn.Value & "' and pnnumber='Direct Release' group by reference)x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtref.Text = dttrn.Value.ToString("M.d.yy") & "-" & rd("code")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    'Private Sub dtgriditems_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgriditems.CellEndEdit
    '    Try
    '        If dtgriditems.CurrentCell.ColumnIndex = 1 Then
    '            conn()
    '            sql = "SELECT * from itemsMF where itemdesc ='" + dtgriditems.CurrentRow.Cells(1).Value + "'"
    '            cmd = New SqlCommand(sql, myConn)
    '            myConn.Open()
    '            rd = cmd.ExecuteReader
    '            If rd.Read Then
    '                dtgriditems.CurrentRow.Cells(2).Value = rd("itemcode").ToString
    '            End If
    '            rd.Close()
    '            myConn.Close()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    'Public Sub addItems(ByVal col As AutoCompleteStringCollection)
    '    conn()
    '    sql = "SELECT * from itemsMF WHERE CategoryCode<>'0'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While rd.Read()
    '        col.Add(rd("itemdesc").ToString)
    '    End While
    '    rd.Close()
    '    myConn.Close()
    'End Sub

    'Private Sub dtgriditems_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgriditems.EditingControlShowing
    '    If dtgriditems.CurrentCell.ColumnIndex = 1 Then
    '        Dim autoText As TextBox = TryCast(e.Control, TextBox)
    '        If autoText IsNot Nothing Then
    '            autoText.AutoCompleteMode = AutoCompleteMode.Suggest
    '            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
    '            Dim DataCollection As New AutoCompleteStringCollection()
    '            addItems(DataCollection)
    '            autoText.AutoCompleteCustomSource = DataCollection
    '        End If
    '    End If

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtref.Text.Trim = "" Then
            MsgBox("Reference number cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf cbotype.Text.Trim = "" Then
            MsgBox("Release type cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
        ElseIf txtref.Text.Length < 3 Then
            MsgBox("Invalid reference name.", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf txtrel_to.Text.Trim = "" Then
            MsgBox("Release name cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf txt_remarks.Text.Trim = "" Then
            MsgBox("Remarks cannot be empty.", MsgBoxStyle.Exclamation, "Invalid")
            txtref.Focus()
        ElseIf Double.Parse(ttlstocks.Text) = 0 Then
            MsgBox("Invalid stock(s) release.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            gen_reference()
            For i As Integer = 0 To dtgrd_deduction.Rows.Count - 1
                If dtgrd_deduction.Rows(i).Cells(0).Value <> "" Then
                    conn()
                    sql = "INSERT INTO Loanitems(PnNumber,ItemCode,ItemPrice,qty,markup,remarks,trndate,reference,Code,userID) VALUES "
                    sql += "('Direct Release',"
                    sql += "'" + dtgrd_deduction.Rows(i).Cells(6).Value + "',"
                    sql += "" + dtgrd_deduction.Rows(i).Cells(3).Value + ","
                    sql += "" + dtgrd_deduction.Rows(i).Cells(1).Value + ","
                    sql += "" + dtgrd_deduction.Rows(i).Cells(4).Value + ","
                    sql += "'" + txtrel_to.Text & " (" & txt_remarks.Text & ")" + "',"
                    sql += "'" + dttrn.Value + "',"
                    sql += "'" + dtgrd_deduction.Rows(i).Cells(0).Value + "',"
                    sql += "'" + txtref.Text + "',"
                    sql += "'" + user.ToString + "'"
                    sql += ")"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                End If
            Next
            If cbotype.Text.Trim = "Cash" Then
                send_tocashiers()
            End If
            MsgBox("Item successfully release.", MsgBoxStyle.Information, "Success")
            gen_reference()
            txtrel_to.Clear()
            txt_remarks.Clear()
            dtgrd_deduction.Rows.Clear()
        End If
    End Sub

    Private Sub send_tocashiers()
        conn()
        sql = "INSERT INTO Cashiersdummy(Payee,Debit,Credit,Reference,Trndate,Ttime,UserID,GLaccount,Remarks,AcctReference,Status) VALUES ('" + txtrel_to.Text + "'," + Double.Parse(ttlamnt.Text).ToString + ",0,'" + txtref.Text + "','" + systemdate + "','" + time.ToString + "','" + user.ToString + "','1035','" & txt_remarks.Text & "','" + user + "','A')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        Me.Close()
    End Sub

    Public Sub creategview()
        'InitializeComponent()
        dtgrd_deduction.Columns.Clear()
        dtgrd_deduction.Rows.Clear()

        Dim deductionsMF As DataTable = New DataTable()
        conn()
        'sql = "select x.reference,x.itemcode,x.principal,x.itemdesc,x.warehouse,(x.ttlstcksrec-x.ttlstocksrel) As ttlstocks from(select a.reference,a.itemcode,a.principal,"
        'sql += "itemdesc=isnull((select itemdesc from itemsMF where itemcode=a.itemcode),0),"
        'sql += "warehouse=(select description from WareHouse where warehouseID=a.warehouseID),"
        'sql += "ttlstcksrec=isnull((select sum(qty) from Iteminventory where itemcode=a.itemcode),0),"
        'sql += "ttlstocksrel=isnull((select sum(qty) from LoanItems where itemcode=a.itemcode),0)"
        'sql += "from iteminventory a where a.grocery='N')x WHERE (x.ttlstcksrec-x.ttlstocksrel)>0"

        sql = "SELECT * FROM("
        sql += "select x.*,(x.qty-x.ttlqtyrel) As ttlstocks from (select b.description,a.itemcode,a.principal,a.reference,CONVERT(VARCHAR(10),a.trndate,101) as trndate,"
        sql += "ttlqtyrel=isnull((select sum(qty) from LoanItems where reference=a.reference and TrnDate <='" + systemdate + "'),0),"
        sql += "qty=isnull((select sum(qty) from ItemInventory where reference=a.reference and trndate <='" + systemdate + "'),0),"
        sql += "itemdesc=isnull((select ItemDesc from ItemsMF where  itemcode=a.itemcode),'Grocery')"
        sql += "from ItemInventory a, WareHouse b where a.warehouseID=b.warehouseID"
        sql += ")x"
        sql += ")y WHERE y.ttlstocks>0"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        deductionsMF.Columns.Add("Code")
        deductionsMF.Columns.Add("Descriptions")
        deductionsMF.Columns.Add("Item Price")
        deductionsMF.Columns.Add("Stocks")
        deductionsMF.Columns.Add("Warehouse")
        While (rd.Read())
            deductionsMF.Rows.Add(rd("reference").ToString, rd("itemdesc").ToString, rd("principal").ToString, rd("ttlstocks").ToString, rd("description").ToString)
        End While
        rd.Close()
        myConn.Close()

        '0
        comboCol1.DataSource = deductionsMF
        comboCol1.FieldName = "Descriptions"
        comboCol1.DisplayMember = "Descriptions"
        comboCol1.ValueMember = "Code"
        comboCol1.Width = 200
        comboCol1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgrd_deduction.Columns.Add(comboCol1)

        '1
        Dim qty As New GridViewTextBoxColumn("Qty")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(qty)
        qty.Width = 50

        '2
        Dim code As New GridViewTextBoxColumn("Code")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(code)
        code.ReadOnly = True
        code.Width = 80
        '3
        Dim amount As New GridViewTextBoxColumn("Item Price")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(amount)
        amount.Width = 100
        '4
        Dim markup As New GridViewTextBoxColumn("Markup")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(markup)
        markup.Width = 100
        '5
        Dim ttlamount As New GridViewTextBoxColumn("Total Price")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(ttlamount)
        ttlamount.Width = 100
        ttlamount.ReadOnly = True
        '6
        Dim Itemdesc As New GridViewTextBoxColumn("ItemCode")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(Itemdesc)
        Itemdesc.IsVisible = False

        Dim warehouse As New GridViewTextBoxColumn("Warehouse")
        Me.dtgrd_deduction.MasterTemplate.AutoGenerateColumns = False
        dtgrd_deduction.Columns.Add(warehouse)
        Itemdesc.IsVisible = True

    End Sub

    Private Sub dtgrd_deduction_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_deduction.CellEditorInitialized
        If dtgrd_deduction.CurrentCell.ColumnIndex = 0 Then
            Dim editor As RadMultiColumnComboBoxElement = CType(Me.dtgrd_deduction.ActiveEditor, RadMultiColumnComboBoxElement)
            editor.AutoFilter = True
            Dim filter As New FilterDescriptor()
            filter.PropertyName = comboCol1.DisplayMember
            filter.Operator = FilterOperator.Contains
            editor.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            editor.AutoSizeDropDownToBestFit = True
        End If
    End Sub

    Private Sub dtgrd_deduction_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dtgrd_deduction.CellEndEdit
        If dtgrd_deduction.CurrentCell.ColumnIndex = 1 Then
            conn()
            sql = "SELECT a.Reference,a.principal,b.ItemDesc,a.itemcode from ItemInventory a, ItemsMF b where a.itemcode=b.itemcode and a.Reference ='" + dtgrd_deduction.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                dtgrd_deduction.CurrentRow.Cells(2).Value = rd("Reference").ToString
                dtgrd_deduction.CurrentRow.Cells(6).Value = rd("itemcode").ToString
                dtgrd_deduction.CurrentRow.Cells(1).ReadOnly = False

                dtgrd_deduction.CurrentRow.Cells(3).Value = Double.Parse(rd("principal"))
                dtgrd_deduction.CurrentRow.Cells(4).Value = 0 ' Double.Parse(rd("markup"))
                'dtgrd_deduction.CurrentRow.Cells(5).Value = (rd("ItemPrice") + rd("markup"))
            End If
            rd.Close()
            myConn.Close()

            Try
                dtgrd_deduction.CurrentRow.Cells(3).Value = Double.Parse(dtgrd_deduction.CurrentRow.Cells(3).Value) * Double.Parse(dtgrd_deduction.CurrentRow.Cells(1).Value)
                dtgrd_deduction.CurrentRow.Cells(4).Value = Double.Parse(dtgrd_deduction.CurrentRow.Cells(4).Value) * Double.Parse(dtgrd_deduction.CurrentRow.Cells(1).Value)
            Catch ex As Exception

            End Try
        End If
        Try
            dtgrd_deduction.CurrentRow.Cells(5).Value = Double.Parse(dtgrd_deduction.CurrentRow.Cells(3).Value) + Double.Parse(dtgrd_deduction.CurrentRow.Cells(4).Value)

            ttlstocks.Text = 0
            ttlamnt.Text = 0
            For i As Integer = 0 To dtgrd_deduction.Rows.Count
                ttlstocks.Text = Double.Parse(dtgrd_deduction.Rows(i).Cells(1).Value) + Double.Parse(ttlstocks.Text)
                ttlamnt.Text = Double.Parse(dtgrd_deduction.Rows(i).Cells(5).Value) + Double.Parse(ttlamnt.Text)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgrd_deduction_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrd_deduction.Validated
        Try
            ttlstocks.Text = 0
            ttlamnt.Text = 0
            For i As Integer = 0 To dtgrd_deduction.Rows.Count
                ttlstocks.Text = Double.Parse(dtgrd_deduction.Rows(i).Cells(1).Value) + Double.Parse(ttlstocks.Text)
                ttlamnt.Text = Double.Parse(dtgrd_deduction.Rows(i).Cells(5).Value) + Double.Parse(ttlamnt.Text)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class