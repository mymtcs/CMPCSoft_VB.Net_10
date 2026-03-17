Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_abstractofcoll
    Dim ctrcode As String
    Dim collcode As String
    Dim ctrchief As String

    Private Sub generate_abstract_details()
        'REPORT OBJECT
        Dim MyRpt As New abstractofcoll

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))

            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int13", Type.GetType("System.Double"))
            .Add("date4", Type.GetType("System.DateTime"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str14", Type.GetType("System.String"))
            '.Add("str15", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "SELECT a.ctrcode,a.grpcode,b.prnum,b.remarks,b.trnxdate,b.collectiondate,(b.principal+b.AdvPrincipal) As prnpaid,(b.intpaid+b.advinterest) as intpaid,b.savings,b.CF,b.penpaid,lh=isnull((b.lh),0),SSSCont=isnull((b.SSSCont),0),b.id,"
        sql += "fullname=(select fullname from members where MemCode=a.MemCode)"
        sql += " from loans a,loancollect b where a.gl_loans='" + GL_loans + "' and a.pnnumber=b.pnnumber and b.cancel='N' and b.trnxdate between '" + dtfrom.Value + "' and '" + dtto.Value + "' "
        If cbotype.Text = "Restructured Loan" Then
            sql += " and a.Restructured='Yes'"
        Else
            sql += " and a.Restructured IS NULL"
        End If
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtfrom.Value
            row(3) = productcode.ToString
            row(4) = "0"
            row(5) = rd("ctrcode").ToString
            row(6) = rd("trnxdate").ToString
            row(7) = rd("collectiondate").ToString
            row(8) = rd("prnpaid").ToString
            row(9) = rd("intpaid").ToString
            row(10) = rd("savings").ToString
            row(11) = rd("CF").ToString
            'row(12) = rd("penpaid").ToString
            row(12) = 0 'temporary 1-15-2025
            row(13) = rd("LH").ToString
            row(14) = rd("SSSCont").ToString
            row(15) = rd("fullname").ToString
            Try
                row(16) = rd("grpcode").ToString
            Catch ex As Exception
                row(16) = 0
            End Try
            row(17) = dtto.Value.ToString
            row(18) = rd("prnum").ToString
            row(19) = rd("remarks").ToString
            ' row(20) = rd("comments").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        'Next
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub generate_abstract_summary()
        'REPORT OBJECT
        Dim MyRpt As New abstractofcoll_summary

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))

            .Add("date3", Type.GetType("System.DateTime"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("date4", Type.GetType("System.DateTime"))
            .Add("str1", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select sum(x.prnpaid) as ttlprnpaid,sum(x.intpaid) as ttlintpaid,sum(x.savings) as ttlsavings,sum(x.cf) as ttlcf,x.trnxdate from(SELECT a.ctrcode,a.grpcode,b.prnum,b.remarks,b.trnxdate,b.collectiondate,(b.principal+b.AdvPrincipal) As prnpaid,(b.intpaid+b.advinterest) as intpaid,b.savings,b.CF,b.penpaid,lh=isnull((b.lh),0),SSSCont=isnull((b.SSSCont),0),b.id,"
        sql += "fullname=(select fullname from members where MemCode=a.MemCode)"
        sql += " from loans a,loancollect b where a.gl_loans='" & GL_loans & "' and a.pnnumber=b.pnnumber and b.cancel='N' and b.trnxdate between '" + dtfrom.Value + "' and '" + dtto.Value + "'"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        If cbotype.Text = "Restructured Loan" Then
            sql += " and a.Restructured='Yes'"
        Else
            sql += " and a.Restructured IS NULL"
        End If
        sql += ")x group by x.trnxdate order by x.trnxdate"

        'sql = "SELECT x.trnxdate,(sum(ttlprnpaid)) as ttlprnpaid,(sum(ttlintpaid)) as ttlintpaid,(sum(ttlsavings)) as ttlsavings,(sum(ttlcf)) as ttlcf from(select a.trnxdate,"
        'sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where pnnumber=b.pnnumber and trnxdate=a.trnxdate),0),"
        'sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where pnnumber=b.pnnumber and trnxdate=a.trnxdate),0),"
        'sql += "ttlsavings=isnull((select sum(savings) from loancollect where pnnumber=b.pnnumber and trnxdate=a.trnxdate),0),"
        'sql += "ttlcf=isnull((select sum(cf) from loancollect where pnnumber=b.pnnumber and trnxdate=a.trnxdate),0)"
        'sql += " from loancollect a, loans b where a.pnnumber=b.pnnumber and b.GL_loans='" + GL_loans + "' "
        'If Not txtcoll.SelectedValue = "000" Then
        '    sql += " and b.collcode='" + txtcoll.SelectedValue.ToString + "'"
        'End If
        'sql += ")x WHERE x.trnxdate between '" + dtfrom.Value + "' and '" + dtto.Value + "' group by x.trnxdate order by x.trnxdate"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()

        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtfrom.Value
            row(3) = productcode.ToString
            row(4) = rd("trnxdate").ToString
            row(5) = rd("ttlprnpaid").ToString
            row(6) = rd("ttlintpaid").ToString
            row(7) = rd("ttlsavings").ToString
            row(8) = rd("ttlcf").ToString
            row(9) = dtto.Value
            row(10) = txtcoll.Text
            DS.Tables(0).Rows.Add(row)
        End While
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub frm_collectionsheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'select_center()
        cbotype.Text = "Normal Loan"
        dtfrom.Value = systemdate
        dtto.Value = systemdate
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
        thread = New Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        If chkdetails.IsChecked = True Then
            generate_abstract_details()
        Else
            generate_abstract_summary()
        End If
        pndialog.Visible = False
        SplashScreen.Close()
    End Sub

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer WHERE status='A' ORDER BY fullname ASC" 'WHERE  productcode='" + productcode.ToString + "'
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        table1.Rows.Add("000", "All")
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

    Private Sub bttnhide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnhide.Click
        If pndialog.Visible = False Then
            pndialog.Visible = True
        Else
            pndialog.Visible = False
        End If
    End Sub
End Class