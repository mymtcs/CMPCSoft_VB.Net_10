Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_masterlist_loans

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer WHERE status='A' ORDER BY fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        table1.Rows.Add("All", "All")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll.DataSource = table1
        Me.txtcoll.AutoFilter = True
        txtcoll.DisplayMember = "Fullname"
        txtcoll.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll.EditorControl.Columns(0).Width = 100
        Me.txtcoll.EditorControl.Columns(1).Width = 200
        Me.txtcoll.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub view_subproducts()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * from SubProducts where gl_loans='" + txtloantype.SelectedValue + "'  order by description" '
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Columns.Add("Rate")
        table1.Rows.Add("All", "All", "--")
        While (rd.Read())
            table1.Rows.Add(rd("Code").ToString, rd("Description").ToString, rd("Rate").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsubproduct.DataSource = table1
        Me.txtsubproduct.AutoFilter = True
        txtsubproduct.DisplayMember = "Description"
        txtsubproduct.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsubproduct.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsubproduct.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsubproduct.EditorControl.Columns(0).Width = 100
        Me.txtsubproduct.EditorControl.Columns(1).Width = 200
        Me.txtsubproduct.EditorControl.Columns(2).Width = 100
        Me.txtsubproduct.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub gen_masterlist()
        'REPORT OBJECT
        Dim MyRpt As New masterlist_by_product

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))
            '.Add("int2", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("str4", Type.GetType("System.String"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("str5", Type.GetType("System.String"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int8", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        If cbotype.Text = "Restructured Loan" Then
            conn()
            sql = "select * from(select x.*,(x.prnamnt-x.ttlprnpaid) As LoanBal, (x.intamnt-x.ttlintpaid) As intBal from (SELECT a.collcode,a.pnnumber,a.releasedate,a.maturitydate,b.fullname,b.address,a.loanamnt,"
            sql += "savingsBal=isnull((select sum(debit)-sum(credit) from Accountledger where PostingDate<='" + gendate.Value + "' and active='Y' and accountnumber=a.accountnumber),0),"
            sql += "PA=(select fullname from officer where collcode=a.collcode),"
            sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
            sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
            sql += "matdays=isnull((select datediff(day, maturitydate,'" & gendate.Value & "') from loans where pnnumber=a.pnnumber),0),"
            sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
            sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<='" + gendate.Value + "' and cancel='N' and pnnumber=a.pnnumber),0),"
            sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where trnxdate<='" + gendate.Value + "' and cancel='N' and pnnumber=a.pnnumber),0) "
            sql += " FROM Loans a,members b WHERE a.MemCode=b.MemCode and a.Restructured='Yes' AND a.released='Y' and a.status<>'X' and a.releasedate<='" + gendate.Value + "' and a.gl_loans='" + txtloantype.SelectedValue + "'"
        
            If txtcoll.SelectedValue <> "All" Then
                sql += " and a.collcode='" + txtcoll.SelectedValue + "' "
            End If
            sql += ")x)y WHERE (y.LoanBal+y.intBal)>0 and y.releasedate<='" + gendate.Value + "' "

            sql += "ORDER BY y.matdays,y.fullname ASC"
        Else
            conn()
            sql = "select * from(select x.*,(x.prnamnt-x.ttlprnpaid) As LoanBal, (x.intamnt-x.ttlintpaid) As intBal from (SELECT a.collcode,a.pnnumber,a.releasedate,a.maturitydate,b.fullname,b.address,a.loanamnt,"
            sql += "savingsBal=isnull((select sum(debit)-sum(credit) from Accountledger where PostingDate<='" + gendate.Value + "' and active='Y' and accountnumber=a.accountnumber),0),"
            sql += "PA=(select fullname from officer where collcode=a.collcode),"
            sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
            sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
            sql += "matdays=isnull((select datediff(day, maturitydate,'" & gendate.Value & "') from loans where pnnumber=a.pnnumber),0),"
            sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
            sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<='" + gendate.Value + "' and cancel='N' and pnnumber=a.pnnumber),0),"
            sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where trnxdate<='" + gendate.Value + "' and cancel='N' and pnnumber=a.pnnumber),0) "
            sql += " FROM Loans a,members b WHERE a.MemCode=b.MemCode and a.Restructured IS NULL AND a.released='Y' and a.status<>'X' and a.releasedate<='" + gendate.Value + "' and a.gl_loans='" + txtloantype.SelectedValue + "'"
      
            If txtcoll.SelectedValue <> "All" Then
                sql += " and a.collcode='" + txtcoll.SelectedValue + "' "
            End If
            sql += ")x WHERE x.DateClosed>'" & gendate.Value & "')y WHERE (y.LoanBal+y.intBal)>0 and y.releasedate<='" + gendate.Value + "' "

            sql += "ORDER BY y.matdays,y.fullname ASC"
        End If
        

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = gendate.Value
            row(3) = txtloantype.Text
            row(4) = rd("pnnumber").ToString
            row(5) = rd("Fullname").ToString
            row(6) = rd("address").ToString.Replace("Undefined", "")
            row(7) = rd("prnamnt")
            row(8) = rd("releasedate").ToString
            row(9) = rd("maturitydate").ToString
            row(10) = rd("ttlprnpaid").ToString
            row(11) = rd("LoanBal").ToString
            If rd("maturitydate") <= gendate.Value Then
                row(12) = "Matured Loans"
            Else
                row(12) = "Current Loans"
            End If
            row(13) = rd("LoanBal") + rd("intBal")
            row(14) = rd("PA")
            row(15) = rd("savingsBal").ToString
            row(16) = rd("matdays").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        'row(8) = MDIfrm.lblparval.Text

        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub


    Private Sub gen_masterlist_withsubproduct()
        'REPORT OBJECT
        Dim MyRpt As New masterlist_by_multi_product

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))
            '.Add("int2", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select y.* from ("
        sql += "select x.*,(x.prnamount-x.TotalPrnPaid) loanbal,(x.intamount-x.TotalintPaid) intbal  from ("
        sql += "select a.memcode,a.gl_loans,Subproductcode=isnull((a.Subproductcode),'SP-001'),a.pnnumber,a.CollCode,a.releasedate,a.maturitydate,b.fullname,b.address,"
        sql += "remarks=isnull((select Description from SubProducts where code=a.Subproductcode),'Basic Needs'),"
        sql += "PA=(select fullname from officer where collcode=a.collcode),"
        sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + gendate.Value.AddYears(1) + "'),"
        sql += "prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intamount=isnull((select sum(Interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<'" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0)"
        sql += " from Loans a, members b where a.memcode=b.memcode and a.status<>'X' and a.released='Y' "
        sql += ") x where x.DateClosed>'" + gendate.Value + "' and x.releasedate<='" + gendate.Value + "' "
        If txtsubproduct.SelectedValue = "All" Then
            sql += " and x.gl_loans in (select distinct gl_loans from subproducts where grouptype=1)"
        Else
            sql += " and x.gl_loans='" + txtloantype.SelectedValue + "' and x.Subproductcode='" + txtsubproduct.SelectedValue + "' "
        End If
        If txtcoll.SelectedValue <> "All" Then
            sql += " and x.CollCode ='" + txtcoll.SelectedValue + "'"
        End If
        sql += ") y where y.loanbal>0 "
        sql += "ORDER BY y.fullname ASC"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = gendate.Value
            row(3) = txtloantype.Text
            row(4) = rd("pnnumber").ToString
            row(5) = rd("Fullname").ToString
            row(6) = rd("address").ToString.Replace("Undefined", "")
            row(7) = rd("prnamount")
            row(8) = rd("releasedate").ToString
            row(9) = rd("maturitydate").ToString
            'row(10) = rd("ttlmatmem").ToString
            row(10) = rd("TotalPrnPaid").ToString
            row(11) = rd("loanbal").ToString
            row(12) = rd("LoanBal") + rd("intBal")
            row(13) = rd("PA")
            row(14) = rd("remarks")
            row(15) = txtsubproduct.Text
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        'row(8) = MDIfrm.lblparval.Text

        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub frm_masterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbotype.Text = "Normal Loan"
        gendate.Value = systemdate
        gen_loantype()
        view_officer()
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype WHERE gl_loans in(select gl_loans from UserAssigned where userID='" + user.ToString + "') order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("--select--", "--select--")
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

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        If multiproduct = "Y" Then
                gen_masterlist_withsubproduct()
        Else
            gen_masterlist()
        End If
        pndialog.Visible = False
        SplashScreen.Close()
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        view_officer()
        view_subproducts()
    End Sub

    Private Sub bttnhide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnhide.Click
        If pndialog.Visible = False Then
            pndialog.Visible = True
        Else
            pndialog.Visible = False
        End If
    End Sub
End Class