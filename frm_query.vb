Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frm_query
    Dim KeyWords As List(Of String) = New List(Of String)(New String() {"select", "from", "where", "and", "*", "like", "order", "group", "by", "%", "isnull", "delete", "update"})
    Dim KeyWordsColors As List(Of Color) = New List(Of Color)(New Color() {Color.Blue, Color.Blue, Color.Blue, Color.DimGray, Color.DimGray, Color.Blue, Color.Blue, Color.Blue, Color.DimGray, Color.Red, Color.Blue, Color.Red, Color.Red})

    Private Sub frm_query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    'Private Sub display_query()
    '    conn()
    '    sql = txtquery.Text
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader
    '    lstquery.Items.Clear()
    '    While (rd.Read())
    '        Dim lvitem As New ListViewItem(rd(0).ToString())
    '        'lvitem.SubItems.Add(0)
    '        For i As Integer = 1 To rd.FieldCount - 1
    '            lvitem.SubItems.Add(rd(i).ToString())
    '        Next
    '        lstquery.Items.Add(lvitem)
    '        lvitem.EnsureVisible()
    '    End While
    '    rd.Close()
    '    myConn.Close()
    'End Sub

    Private Sub bttn_execute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_execute.Click
        'dtgrid_result.Rows.Clear()
        If txtquery.Text.Contains("delete") Or txtquery.Text.Contains("update") Then
            'MsgBox("Delete or Update Query are Prohibited.", MsgBoxStyle.Exclamation, "Invalid Query")
            'txtquery.Clear()
            frm_override_query.ShowDialog()
        Else
            Try
                Dim da As New SqlClient.SqlDataAdapter
                Dim dt As New DataTable
                conn()
                myConn.Open() 'connects to the database
                cmd.Connection = myConn
                cmd.CommandType = CommandType.Text
                sql = txtquery.Text 'Sql to be executed
                cmd.CommandText = sql 'makes the string a command
                da.SelectCommand = cmd 'puts the command into the sqlDataAdapter
                da.Fill(dt) 'populates the dataTable by performing the command above
                Me.dtgrid_result.DataSource = dt 'Updates the grid using the populated dataTable
                lblerror.ForeColor = Color.Blue
                lblerror.Text = "Query executed with no error."
            Catch ex As Exception
                lblerror.ForeColor = Color.Red
                lblerror.Text = ex.Message
            End Try
        End If
        
    End Sub

    Private Sub txtquery_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtquery.TextChanged
        Dim words As IEnumerable(Of String) = txtquery.Text.Split(New Char() {" "c, ".", ",", "?", "!"})
        Dim index As Integer = 0
        Dim rtb As RichTextBox = sender 'to give normal color according to the base fore color
        For Each word As String In words
            'If the list contains the word, then color it specially. Else, color it normally
            'Edit: Trim() is added such that it may guarantee the empty space after word does not cause error
            coloringRTB(sender, index, word.Length, If(KeyWords.Contains(word.ToLower().Trim()), KeyWordsColors(KeyWords.IndexOf(word.ToLower().Trim())), rtb.ForeColor))
            index = index + word.Length + 1 '1 is for the whitespace, though Trimmed, original word.Length is still used to advance
        Next
    End Sub


    Private Sub coloringRTB(ByVal rtb As RichTextBox, ByVal index As Integer, ByVal length As Integer, ByVal color As Color)
        Dim selectionStartSave As Integer = rtb.SelectionStart 'to return this back to its original position
        rtb.SelectionStart = index
        rtb.SelectionLength = length
        rtb.SelectionColor = color
        rtb.SelectionLength = 0
        rtb.SelectionStart = selectionStartSave
        rtb.SelectionColor = rtb.ForeColor 'return back to the original color
    End Sub

    Private Sub bttnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnexport.Click
        'Export the listview to an Excel spreadsheet
        SaveFileDialog1.Title = "Save Excel File"
        SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        SaveFileDialog1.ShowDialog()
        'exit if no file selected
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        prgbar.Visible = True
        lblpercent.Visible = True
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf export_query)
        thread.Start()
    End Sub

    Private Sub export_query()
        prgbar.Value = 0
        Dim ttlrw As Integer = dtgrid_result.Rows.Count
        Dim val As Decimal = 100 / ttlrw
        Dim prgval As Decimal = 0
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To dtgrid_result.RowCount - 2
            For j = 0 To dtgrid_result.ColumnCount - 1
                For k As Integer = 1 To dtgrid_result.Columns.Count
                    xlWorkSheet.Cells(1, k) = dtgrid_result.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dtgrid_result(j, i).Value.ToString()
                Next
            Next
            prgval = prgval + val
            lblpercent.Text = prgval & " %"
            prgbar.Value = prgval
        Next

        xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        prgbar.Visible = False
        lblpercent.Visible = False

        MsgBox("Export Completed.", MsgBoxStyle.Information, "Completed")
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

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    
End Class