Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data

Public Class frm_loanrel_consumable

    Private Sub frm_disclosure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.Value = systemdate
        dtto.Value = systemdate
        view_officer()
    End Sub

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer WHERE status='A'  ORDER BY fullname ASC"
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

    Private Sub loanrel_details()
        'REPORT OBJECT
        Dim MyRpt As New loanrel_consumables

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str15", Type.GetType("System.String")) '0
            .Add("str16", Type.GetType("System.String")) '1
            .Add("int2", Type.GetType("System.Double")) '2
            .Add("int3", Type.GetType("System.Double")) '3
            .Add("str1", Type.GetType("System.String")) '5
            .Add("str2", Type.GetType("System.String")) '6
            .Add("date1", Type.GetType("System.DateTime")) '7
            .Add("date2", Type.GetType("System.DateTime")) '8
            .Add("int1", Type.GetType("System.Double")) '9
            .Add("str12", Type.GetType("System.String")) '10
            .Add("str11", Type.GetType("System.String")) '11
            .Add("str10", Type.GetType("System.String")) '10
            .Add("str9", Type.GetType("System.String")) '11
            .Add("str14", Type.GetType("System.String")) '11
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "select x.* from(select a.pnnumber,a.loanamnt,a.releasedate,"
        sql += "subrate=(select rate from subproducts where Code=a.Subproductcode),"
        sql += "subproduct=(select Description from subproducts where Code=a.Subproductcode)"
        sql += "from loans a where a.gl_loans='" + +"')x"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += " and a.released='Y' and a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "')x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("reference").ToString
            row(1) = rd("itemname").ToString
            row(2) = rd("qty").ToString
            row(3) = rd("Itemprice").ToString
            row(4) = rd("pnnumber").ToString
            row(5) = rd("fullname").ToString
            row(6) = dtfrom.Value
            row(7) = dtto.Value
            row(8) = rd("Markup").ToString
            row(9) = usersname.ToString
            row(10) = user.ToString
            row(11) = CompName.ToString
            row(12) = compaddress.ToString
            row(13) = productcode
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub loanrel_summary()
        'REPORT OBJECT
        Dim MyRpt As New loanrel_consumables_summary

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str14", Type.GetType("System.String")) '0
            .Add("str10", Type.GetType("System.String")) '1
            .Add("str9", Type.GetType("System.String")) '1
            .Add("date1", Type.GetType("System.DateTime")) '7
            .Add("date2", Type.GetType("System.DateTime")) '8
            .Add("str1", Type.GetType("System.String")) '5
            .Add("str2", Type.GetType("System.String")) '6
            .Add("int1", Type.GetType("System.Double")) '2
            .Add("int2", Type.GetType("System.Double")) '3
            .Add("str11", Type.GetType("System.String")) '11
            .Add("str3", Type.GetType("System.String")) '11
            .Add("int3", Type.GetType("System.Double")) '3
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "select * from(select "
        sql += "a.memcode,a.pnnumber,b.fullname,a.cycle,"
        sql += "collname=isnull((select fullname from officer where collcode=a.collcode),0),"
        sql += "ttlitm_price=isnull((select sum(itemprice) from loanitems where pnnumber=a.pnnumber),0),"
        sql += "ttlmarkup = isnull((select sum(markup) from loanitems where pnnumber=a.pnnumber),0)"
        sql += "from loans a, members b where a.memcode=b.memcode"
        sql += " and a.releasedate between '" + dtfrom.Value + "' AND '" + dtto.Value + "' and a.released='Y' and a.GL_loans='" + GL_loans + "'"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ")x"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = productcode
            row(1) = CompName.ToString
            row(2) = compaddress.ToString
            row(3) = dtfrom.Value
            row(4) = dtto.Value
            row(5) = rd("pnnumber").ToString
            row(6) = rd("fullname").ToString
            row(7) = rd("ttlitm_price").ToString
            row(8) = rd("ttlmarkup").ToString
            row(9) = user.ToString
            row(10) = rd("collname").ToString
            row(11) = rd("cycle").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        If rd_details.IsChecked = True Then
            loanrel_details()
        Else
            loanrel_summary()
        End If
        SplashScreen.Close()
    End Sub
End Class