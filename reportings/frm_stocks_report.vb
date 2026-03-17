Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_stocks_report
    Dim ctrcode As String
    Dim collcode As String
    Dim ctrchief As String

    Private Sub generate_stocks()
        'REPORT OBJECT
        Dim MyRpt As New itemstocks

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
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "SELECT * FROM("
        sql += "select x.*,(x.qty-x.ttlqtyrel) As ttlstocks from (select c.itemdesc,c.itemcategory,b.description,a.itemcode,a.principal,a.reference,CONVERT(VARCHAR(10),a.trndate,101) as trndate,"
        sql += "ttlqtyrel=isnull((select sum(qty) from LoanItems where reference=a.reference and TrnDate <='" + dtto.Value + "'),0),"
        sql += "qty=isnull((select sum(qty) from ItemInventory where reference=a.reference and trndate <='" + dtto.Value + "'),0)"
        sql += "from ItemInventory a, WareHouse b, itemsmf c where a.itemcode=c.itemcode and a.warehouseID=b.warehouseID and a.grocery='N'"
        sql += ")x"
        sql += ")y WHERE y.ttlstocks>0"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtto.Value
            row(3) = productcode
            row(4) = rd("itemcode").ToString
            row(5) = rd("itemdesc").ToString
            row(6) = rd("reference").ToString
            row(7) = rd("trndate").ToString
            row(8) = rd("qty").ToString
            row(9) = rd("ttlqtyrel").ToString
            row(10) = rd("ttlstocks").ToString
            row(11) = rd("principal").ToString
            row(12) = rd("description").ToString
            row(13) = rd("itemcategory").ToString
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

    Private Sub frm_collectionsheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtto.Value = systemdate
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        generate_stocks()
        SplashScreen.Close()
    End Sub


End Class