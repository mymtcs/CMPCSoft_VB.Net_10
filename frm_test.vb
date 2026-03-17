Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_test
    Public comboCol As New GridViewMultiComboBoxColumn("Phone")
    Private Sub frm_test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        ''cbo_multibox.DataSource = table1
        ''cbo_multibox.DisplayMember = "OrderID"
        'Dim AccountTitles As GridViewMultiComboBoxColumn = New GridViewMultiComboBoxColumn()
        'AccountTitles.DataSource = table1 'orderDetailsBindingSource
        'AccountTitles.DisplayMember = "Quantity"
        'AccountTitles.ValueMember = "OrderID"
        'AccountTitles.FieldName = "remarks"
        'AccountTitles.HeaderText = "Remarks"
        'AccountTitles.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        'Me.Radgview.Columns.Add(AccountTitles)

        'Dim accttitles As GridViewTextBoxColumn = New GridViewTextBoxColumn()
        'accttitles.FieldName = "AccountTitles"
        'accttitles.HeaderText = "Account Titles"
        'Me.Radgview.Columns.Add(accttitles)
        'accttitles.ReadOnly = True

        'Dim remarks As GridViewMultiComboBoxColumn = New GridViewMultiComboBoxColumn()
        'remarks.DataSource = table1 'orderDetailsBindingSource
        'remarks.DisplayMember = "Quantity"
        'remarks.ValueMember = "OrderID"
        'remarks.FieldName = "remarks"
        'remarks.HeaderText = "Remarks"
        'remarks.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        'Me.Radgview.Columns.Add(remarks)
        'AddHandler Radgview.CellBeginEdit, AddressOf RadGridView1_CellBeginEdit

    End Sub

    'Private isColumnAdded As Boolean
    'Private Sub RadGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellCancelEventArgs) Handles Radgview.CellBeginEdit
    '    If TypeOf Me.Radgview.CurrentColumn Is GridViewMultiComboBoxColumn Then
    '        If (Not isColumnAdded) Then
    '            isColumnAdded = True
    '            Dim editor As RadMultiColumnComboBoxElement = CType(Me.Radgview.ActiveEditor, RadMultiColumnComboBoxElement)
    '            editor.EditorControl.MasterTemplate.AutoGenerateColumns = False
    '            editor.EditorControl.Columns.Add(New GridViewTextBoxColumn("OrderID"))
    '            editor.EditorControl.Columns.Add(New GridViewTextBoxColumn("Quantity"))
    '            editor.AutoSizeDropDownToBestFit = True
    '        End If
    '    End If
    'End Sub

    Public Sub New()
        InitializeComponent()
        Dim table1 As DataTable = New DataTable()

        table1.Columns.Add("Quantity")
        table1.Columns.Add("OrderID")

        table1.Rows.Add(1, "Ivan Petrov")
        table1.Rows.Add(2, "Stefan Muler")
        table1.Rows.Add(3, "Alexandro Ricco")


        Dim table As New DataTable()

        table.Columns.Add("Phone", GetType(String))
        table.Columns.Add("Text", GetType(String))
        table.Columns.Add("Another ComboBox column", GetType(Integer))

        table.Rows.Add("Text 1", "Mobile", 1)
        table.Rows.Add("Text 2", "Business", 1)
        table.Rows.Add("Text 3", "Business", 2)
        table.Rows.Add("Text 4", "Fax", 1)


        comboCol.DataSource = table1
        comboCol.FieldName = "Phone"
        comboCol.HeaderText = "Account Titles"
        comboCol.DisplayMember = "OrderID"
        comboCol.ValueMember = "Quantity"
        Radgview.Columns.Add(comboCol)

        Me.Radgview.MasterTemplate.AutoGenerateColumns = False
        Radgview.Columns.Add(New GridViewTextBoxColumn(comboCol.ValueMember.ToString))

        Dim colboCol2 As New GridViewComboBoxColumn("Another ComboBox column")
        colboCol2.FieldName = "Another ComboBox column"
        colboCol2.ValueMember = "Id"
        colboCol2.DisplayMember = "MyString"

        Dim list As New BindingList(Of ComboBoxDataSourceObject)()

        Dim object1 As New ComboBoxDataSourceObject()
        object1.Id = 1
        object1.MyString = "First object"
        list.Add(object1)

        Dim object2 As New ComboBoxDataSourceObject()
        object2.Id = 2
        object2.MyString = "Second object"
        list.Add(object2)

        colboCol2.DataSource = list
        Radgview.Columns.Add(colboCol2)
        Me.Radgview.DataSource = table
    End Sub

    Private Sub Radgview_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Radgview.CellEndEdit
       
    End Sub
End Class

Public Class ComboBoxDataSourceObject
    Private myString_ As String
    Public Property MyString() As String
        Get
            Return myString_
        End Get
        Set(ByVal value As String)
            myString_ = value
        End Set
    End Property

    Private m_id As Integer
    Public Property Id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property
End Class