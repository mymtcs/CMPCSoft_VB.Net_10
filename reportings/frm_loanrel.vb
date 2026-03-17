Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data

Public Class frm_loanrel
    Private total_savings As Integer = 0
    Private total_cgf As Integer = 0
    Private kf As Integer = 0


    Private Sub loanrel_general()
        'MessageBox.Show("loanrel_general loanrel_general loanrel_general loanrel_general loanrel_general")

        'REPORT OBJECT
        Dim MyRpt As New loanrel_PL

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str2", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("int8", Type.GetType("System.Double"))
            .Add("int9", Type.GetType("System.Double"))
            .Add("int10", Type.GetType("System.Double"))
            .Add("str15", Type.GetType("System.String"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("int11", Type.GetType("System.Double"))
            .Add("int12", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In lstloanrel.Items
        conn()
        sql = "select cycle,PA,Pnnumber,fullname, loanamnt,Releasedate,"
        sql += "processingfee=isnull(([PF]),0),"
        sql += "cgf=isnull(([CGF]),0),"
        sql += "savings = isnull(([SV]), 0),"
        sql += "cbu = isnull(([CBU]), 0),"
        sql += "insurance = isnull(([INS]), 0),"
        sql += "bci = isnull(([BCI]), 0),"
        sql += "servicecharge = isnull(([SC]), 0),"
        sql += "karamayfund = isnull(([KF]), 0),"
        sql += "lh = isnull(([LH]), 0),"
        sql += "ofs = isnull(([OFS]), 0)"
        sql += "from "
        sql += "("
        sql += "select a.cycle,PA=(select fullname from officer where collcode=a.collcode),a.Pnnumber,a.loanamnt,a.Releasedate,b.Amount, b.acro,c.fullname"
        sql += " from loans a, LoansDeduction b, members c where a.memcode=c.memcode and a.Pnnumber=b.Pnnumber and a.released='Y' and a.GL_loans='" + GL_loans.ToString + "' and a.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "'"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ") a"
        sql += " pivot "
        sql += "("
        sql += "sum(Amount)"
        sql += " for acro in ([PF],[CGF],[SV],[CBU],[INS],[SC],[KF],[BCI],[LH],[OFS])"
        sql += ") piv"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.CommandTimeout = 5000
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("Pnnumber").ToString
            row(1) = rd("fullname").ToString
            row(2) = rd("loanamnt").ToString
            row(3) = rd("cycle").ToString
            row(4) = rd("processingfee").ToString
            row(5) = rd("savings").ToString
            row(6) = rd("cbu").ToString
            row(7) = dtfrom.Value
            row(8) = dtto.Value
            row(9) = CompName.ToString
            row(10) = compaddress.ToString
            row(11) = productcode
            row(12) = rd("PA").ToString
            row(13) = rd("insurance").ToString
            row(14) = rd("servicecharge").ToString
            row(15) = rd("karamayfund").ToString
            row(16) = rd("cgf").ToString
            row(17) = rd("bci").ToString
            row(18) = "(" & txtloantype.Text & ")"
            row(19) = rd("Releasedate")
            row(20) = rd("lh").ToString
            row(21) = rd("ofs").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_loanrel.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "select collcode,fullname from officer where status='A' order by fullname ASC"
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


    Private Sub frm_loanrel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        If grouptype = "Y" And multiproduct = "Y" Then
            If chkdetails.IsChecked = True Then
                loanrel_details()
            Else
                loanrel_summary()
            End If
        Else
            loanrel_general()
        End If
        SplashScreen.Close()
    End Sub

    Private Sub loanrel_details()
        'REPORT OBJECT
        Dim MyRpt As New loanrel_consumables

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet
        Dim cCollcode = "%%"

        'MessageBox.Show("loanrel_details")

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str16", Type.GetType("System.String")) '1
            .Add("int2", Type.GetType("System.Double")) '2
            .Add("str1", Type.GetType("System.String")) '5
            .Add("str2", Type.GetType("System.String")) '6
            .Add("date1", Type.GetType("System.DateTime")) '7
            .Add("date2", Type.GetType("System.DateTime")) '8
            .Add("date3", Type.GetType("System.DateTime")) '8
            .Add("str11", Type.GetType("System.String")) '10
            .Add("str10", Type.GetType("System.String")) '10
            .Add("str9", Type.GetType("System.String")) '11
            .Add("str14", Type.GetType("System.String")) '11

        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()

        'this is the original script, modified 6-4-2024
        'sql = "select x.* from(select a.pnnumber,a.collcode,a.gl_loans,a.released,a.loanamnt,a.releasedate,"
        'sql += "fullname=(select fullname from members where memcode=a.memcode),"
        'sql += "subrate=(select rate from subproducts where Code=a.Subproductcode),"
        'sql += "subproduct=isnull((select Description from subproducts where Code=a.Subproductcode),'Basic Needs')"
        'sql += " from loans a)x WHERE x.gl_loans='" + txtloantype.SelectedValue + "' "

        'this is the new script, modified 6-4-2024
        sql = "select x.* from(select a.pnnumber,a.collcode,a.gl_loans,a.released,a.loanamnt,a.releasedate,"
        sql += " members.fullname, "
        sql += " ISNULL(subproducts.rate,0)  AS subrate, "
        sql += " ISNULL(subproducts.Description,'Basic Needs') AS subproduct "
        sql += " from loans a LEFT JOIN members ON a.memcode = members.memcode LEFT JOIN subproducts ON subproducts.code = a.Subproductcode "
        sql += " WHERE a.gl_loans='" + txtloantype.SelectedValue + "' AND x.released='Y' and x.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "' ) x WHERE  "

        If Not txtcoll.SelectedValue = "000" Then
            sql += "  x.collcode='" + txtcoll.SelectedValue.ToString + "'"
            cCollcode = "%000%"
        End If
        'sql += "  x.released='Y' and x.releasedate between '" + dtfrom.Value + "' and '" + dtto.Value + "'"




        Dim cmd As New SqlCommand

        cmd.Connection = myConn
        cmd.CommandTimeout = 300
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.usp_Loanrel_Details"
        cmd.Parameters.AddWithValue("@gl_loansValue", txtloantype.SelectedValue)
        cmd.Parameters.AddWithValue("@dtfrom", dtfrom.Value)
        cmd.Parameters.AddWithValue("@dtto", dtto.Value)
        cmd.Parameters.AddWithValue("@collcode", cCollcode)

        myConn.Open()
        rd = cmd.ExecuteReader()

        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'cmd.CommandTimeout = 5000
        'rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("fullname").ToString
            row(1) = rd("loanamnt").ToString
            row(2) = rd("subproduct").ToString
            row(3) = rd("pnnumber").ToString
            row(4) = dtfrom.Value
            row(5) = dtto.Value
            row(6) = rd("releasedate").ToString
            row(7) = user.ToString
            row(8) = CompName.ToString
            row(9) = compaddress.ToString
            row(10) = productcode
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_loanrel.ReportSource = MyRpt

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

        MessageBox.Show("loanrel_summary loanrel_summary loanrel_summary loanrel_summary loanrel_summary")

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
            .Add("date3", Type.GetType("System.DateTime")) '8
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "select * from(select "
        sql += "a.memcode,a.pnnumber,b.fullname,a.cycle,a.releasedate,"
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
            row(12) = rd("Releasedate")
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_loanrel.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub
End Class