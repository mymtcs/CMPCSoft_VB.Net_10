Imports System.Data
Imports System.Linq
Imports System.Configuration
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Web.UI.WebControls
Imports Telerik.WinControls.Data
Imports Microsoft.Office.Interop

Public Class frm_masterlist

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        gen_loantype()
        ' gen_masterlist()
        dtgridcolumn.Rows.Clear()
        dtgridcolumn.Rows.Add(True, "Member Code", "memcode")
        dtgridcolumn.Rows(0).ReadOnly = True
        dtgridcolumn.Rows.Add(True, "Loan Number", "pnnumber")
        dtgridcolumn.Rows.Add(True, "Member Type", "membertype")
        dtgridcolumn.Rows.Add(True, "Firstname", "firstname")
        dtgridcolumn.Rows.Add(True, "Lastname", "lastname")
        dtgridcolumn.Rows.Add(True, "Middlename", "midname")
        dtgridcolumn.Rows.Add(True, "Gender", "gender")
        dtgridcolumn.Rows.Add(True, "Birthdate", "birthdate")
        dtgridcolumn.Rows.Add(True, "Age", "age")
        dtgridcolumn.Rows.Add(True, "Address", "address")
        dtgridcolumn.Rows.Add(True, "Telephone No.", "telno")
        dtgridcolumn.Rows.Add(True, "Mobile No.", "mobileno")
        dtgridcolumn.Rows.Add(True, "Spouse Name", "spouse")
        dtgridcolumn.Rows.Add(True, "Dat Mod", "tdate")
        dtgridcolumn.Rows.Add(True, "Occupation", "occupdesc")
        dtgridcolumn.Rows.Add(True, "Collector's Code", "Collcode")
        dtgridcolumn.Rows.Add(True, "Collector's Name", "Collname")
        dtgridcolumn.Rows.Add(True, "Released Date", "releasedate")
        dtgridcolumn.Rows.Add(True, "Loan Date", "loandate")
        dtgridcolumn.Rows.Add(True, "Maturity Date", "maturitydate")
        dtgridcolumn.Rows.Add(True, "Principal Loan", "prnloan")
        dtgridcolumn.Rows.Add(True, "loan Amount", "loanamnt")
        dtgridcolumn.Rows.Add(True, "Interest Due", "interestdue")
        dtgridcolumn.Rows.Add(True, "Total Principal Due", "Totalprndue")
        dtgridcolumn.Rows.Add(True, "Total Int Due", "Totalintdue")
        dtgridcolumn.Rows.Add(True, "Total Principal Paid", "TotalPrnPaid")
        dtgridcolumn.Rows.Add(True, "Total Int Paid", "TotalintPaid")
        dtgridcolumn.Rows.Add(True, "Holdout", "holdout")
        dtgridcolumn.Rows.Add(True, "Duedate", "Duedate")
        dtgridcolumn.Rows.Add(True, "No of PAR days", "PARDays")
        dtgridcolumn.Rows.Add(True, "Loan Balance", "Loanbal")
        dtgridcolumn.Rows.Add(True, "Running Balance", "runbal")
        dtgridcolumn.Rows.Add(True, "Pricipal Par", "PrnPar")
        dtgridcolumn.Rows.Add(True, "Interest Par", "IntPar")
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        'sql = "SELECT DISTINCT GL_loans,description FROM products order by description"
        sql = "SELECT DISTINCT GL_loans,loandesc FROM loantype order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("gl_loans").ToString, rd("loandesc").ToString)
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
        Me.txtloantype.EditorControl.Columns(1).Width = 200
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub



    Private Sub display_data()
        lstdata.Columns.Clear()
        For i As Integer = 0 To dtgridcolumn.Rows.Count - 1
            If dtgridcolumn.Rows(i).Cells(0).Value = True Then
                lstdata.Columns.Add(dtgridcolumn.Rows(i).Cells(1).Value, 90, HorizontalAlignment.Left)
            End If
        Next
        conn()
        sql = "select * from ("
        sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,((x.loanamnt+x.interestdue)-(x.TotalPrnPaid+x.TotalintPaid))as runbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.totalintdue-x.TotalIntPaid) >1) then datediff(day,x.Duedate,'" + dtpick.Value + "') else (case when ((x.totalprndue-x.TotalPrnPaid)>1) then datediff(day,x.Duedate,'" + dtpick.Value + "') else 0 end)  end as PARDays from ("
        sql += "select a.pnnumber,a.memcode,b.membertype,b.firstname,b.lastname,b.midname,b.address,b.gender,b.birthdate,b.age,b.mobileno,b.telno,b.spouse,b.SourceofIncome,b.civil_stat,b.tdate,"
        sql += "occupdesc=isnull((select occupdesc from occupation where occupcode=b.occupcode),''),"
        sql += "a.Collcode,a.releasedate,a.loandate,a.maturitydate,a.ctrcode,a.loanamnt,"
        sql += "prnloan=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Collname=(select fullname from officer where CollCode=a.collcode),"
        sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + dtpick.Value.AddYears(1) + "'),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtpick.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtpick.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where  trnxdate<='" + dtpick.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<='" + dtpick.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "holdout=isnull((select SUM(debit-credit) from AccountLedger where Accountnumber=a.Accountnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtpick.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += "from Loans a,Members b where  a.status<>'X' and a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + txtloantype.SelectedValue + "') x WHERE x.DateClosed>'" + dtpick.Value + "' "
        sql += ") y where y.runbal>0"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        lstdata.Items.Clear()
        While rd.Read
            Dim lvitem As New ListViewItem(rd(0).ToString)
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To dtgridcolumn.Rows.Count - 1
                If dtgridcolumn.Rows(i).Cells(0).Value = True Then
                    lvitem.SubItems.Add(rd(dtgridcolumn.Rows(i).Cells(2).Value.ToString).ToString())
                End If
            Next
            lstdata.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_masterlist()
        'REPORT OBJECT
        Dim MyRpt As New General_masterlist

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("date4", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select  * from loans "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("Memcode").ToString
            row(1) = rd("Pnnumber").ToString
            row(2) = rd("Termcode").ToString
            row(3) = rd("ModeOfPayment").ToString
            row(4) = rd("Releasedate").ToString
            row(5) = rd("Firstpaymentdate").ToString
            row(6) = rd("Maturitydate").ToString
            row(7) = rd("Loandate").ToString
            DS.Tables(0).Rows.Add(row)
        End While

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    'Private Sub BindReport()

    '    Dim query As String = "SELECT TOP 10 "
    '    'Dim isSelected As Boolean = chkColumns.Items.Cast(Of ListItem)().Count(Function(i) i.Selected = True) > 0
    '    'If Not isSelected Then
    '    '    chkColumns.Items(0).Selected = True
    '    'End If
    '    For Each item As ListItem In chkColumns.Items
    '        If item.Selected Then
    '            query += item.Value + ","
    '            'isSelected = True
    '        End If
    '    Next

    '    query = query.Substring(0, query.Length - 1)
    '    query += " FROM Myds"
    '    Dim crystalReport As New ReportDocument()
    '    crystalReport.Load(System.Web.HttpContext.Current.Server.MapPath("~/General_masterlist.rpt"))
    '    Dim dsCustomers As myds = GetData(query, crystalReport)
    '    crystalReport.SetDataSource(dsCustomers)
    '    CRviewer.ReportSource = crystalReport

    'End Sub

    'Private Function GetData(ByVal query As String, ByVal crystalReport As ReportDocument) As myds
    '    Dim conString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Dim cmd As New SqlCommand(query)
    '    Using con As New SqlConnection(conString)
    '        Dim dsCustomers As New myds()
    '        cmd.Connection = con
    '        con.Open()
    '        Using sdr As SqlDataReader = cmd.ExecuteReader()
    '            'Get the List of all TextObjects in Section2.
    '            Dim textObjects As List(Of TextObject) = crystalReport.ReportDefinition.Sections("Section2").ReportObjects.OfType(Of TextObject)().ToList()
    '            For i As Integer = 0 To textObjects.Count - 1
    '                'Set the name of Column in TextObject.
    '                textObjects(i).Text = String.Empty
    '                If sdr.FieldCount > i Then
    '                    textObjects(i).Text = sdr.GetName(i)
    '                End If
    '            Next
    '            'Load all the data rows in the Dataset.
    '            While sdr.Read()
    '                Dim dr As DataRow = dsCustomers.Tables(0).Rows.Add()
    '                For i As Integer = 0 To sdr.FieldCount - 1
    '                    dr(i) = sdr(i)
    '                Next
    '            End While
    '        End Using
    '        con.Close()
    '        Return dsCustomers
    '    End Using
    'End Function

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.BindReport()
    'End Sub

    Private Sub dtgridcolumn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridcolumn.Click
        If dtgridcolumn.CurrentRow.Cells(0).Value = True Then
            dtgridcolumn.CurrentRow.Cells(0).Value = False
        Else
            dtgridcolumn.CurrentRow.Cells(0).Value = True
        End If
    End Sub

    Private Sub bttngen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngen.Click
        display_data()
    End Sub

    Private Sub export_click()
        'Export the listview to an Excel spreadsheet
        SaveFileDialog1.Title = "Save Excel File"
        SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        SaveFileDialog1.ShowDialog()
        'exit if no file selected
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If

        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf export_process)
        thread.Start()
    End Sub

    Private Sub export_process()
        'create objects to interface to Excel
        Dim xls As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet
        'create a workbook and get reference to first worksheet
        xls.Workbooks.Add()
        book = xls.ActiveWorkbook
        sheet = book.ActiveSheet
        'step through rows and columns and copy data to worksheet
        Dim row As Integer = 2
        Dim col As Integer = 1

        Dim columns As New List(Of String)
        Dim columncount As Integer = lstdata.Columns.Count - 1

        For i = 0 To lstdata.Columns.Count - 1
            sheet.Cells(1, i + 1) = lstdata.Columns(i).Text
        Next

        For Each item As ListViewItem In lstdata.Items
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

    Private Sub bttnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnexport.Click
        export_click()
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


End Class