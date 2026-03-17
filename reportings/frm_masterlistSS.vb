Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_masterlistSS


    Private Sub gen_masterlist()
        'REPORT OBJECT
        Dim MyRpt As New masterlistSSS

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
            .Add("int4", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select  x.* from(select a.sssno,a.fullname,a.address,"
        sql += "sssbal=isnull((select sum(debit-credit) from sssledger where memcode=a.memcode and PostingDate<='" + gendate.Value + "'),0)"
        sql += "from members a)x where x.sssbal>0"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = gendate.Value
            row(3) = productcode
            row(4) = rd("sssno").ToString
            row(5) = rd("fullname").ToString
            row(6) = rd("address").ToString
            row(7) = rd("sssbal").ToString
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

    Private Sub frm_masterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gendate.Value = systemdate
    End Sub

    Private Sub bttn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_generate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        gen_masterlist()
        SplashScreen.Close()
    End Sub
End Class