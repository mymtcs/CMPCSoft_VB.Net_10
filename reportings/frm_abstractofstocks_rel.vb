Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_abstractofstocks_rel

    Private Sub generate_abstract_details()
        'REPORT OBJECT
        Dim MyRpt As New abstractofstocks_rel

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
            .Add("int13", Type.GetType("System.Double"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("str5", Type.GetType("System.String"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select * from(SELECT a.qty,a.trndate,a.remarks,b.reference,b.Itemcode,a.markup,a.itemprice,"
        sql += "itemdesc=isnull((select itemdesc from itemsMF where itemcode=b.itemcode),'Grocery')"
        sql += "FROM LoanItems a,ItemInventory b WHERE a.trndate between '" + dtfrom.Value + "' and '" + dtto.Value + "' and a.reference=b.reference"
        sql += ")x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtfrom.Value
            row(3) = productcode.ToString
            row(4) = rd("ItemDesc").ToString
            row(5) = rd("Itemcode").ToString
            row(6) = rd("reference").ToString
            row(7) = rd("qty").ToString
            row(8) = rd("trndate").ToString
            row(9) = rd("remarks").ToString
            row(10) = dtto.Value
            row(11) = rd("itemprice").ToString
            row(12) = rd("markup").ToString
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
        Dim MyRpt As New abstractofstocks_rel_summary

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
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("date3", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select * from(select c.description,a.reference,"
        sql += "itemdesc=isnull((select itemdesc from itemsMF where  itemcode=a.itemcode),'Grocery'),"
        sql += "ttlitemprice=isnull((select sum(ItemPrice) from loanitems where reference=a.reference and TrnDate between '" + dtfrom.Value + "' and '" + dtto.Value + "'),0),"
        sql += "ttlunit_price=isnull((select sum(ItemPrice+markup) from loanitems where reference=a.reference and TrnDate between '" + dtfrom.Value + "' and '" + dtto.Value + "'),0),"
        sql += "ttlstockrel=isnull((select sum(qty) from loanitems where reference=a.reference and TrnDate between '" + dtfrom.Value + "' and '" + dtto.Value + "'),0)"
        sql += " from Iteminventory a, Loanitems b, WareHouse c where a.reference=b.reference and a.warehouseID=c.warehouseID and b.TrnDate between '" + dtfrom.Value + "' and '" + dtto.Value + "'"
        sql += ")x where x.ttlstockrel>0  group by x.description,x.reference,x.itemdesc,x.ttlstockrel,x.ttlitemprice,x.ttlunit_price"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtfrom.Value
            row(3) = productcode.ToString
            row(4) = rd("description").ToString
            row(5) = rd("reference").ToString
            row(6) = rd("itemdesc").ToString
            row(7) = rd("ttlstockrel").ToString
            row(8) = rd("ttlitemprice")
            row(9) = rd("ttlunit_price")
            row(10) = dtto.Value
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

    Private Sub frm_abstractofstocks_rel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.Value = systemdate
        dtto.Value = systemdate
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        If chkdetails.IsChecked = True Then
            generate_abstract_details()
        Else
            generate_abstract_summary()
        End If
        SplashScreen.Close()
    End Sub
End Class