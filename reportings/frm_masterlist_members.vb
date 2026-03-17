Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_masterlist_members

    Private Sub gen_masterlist()
        'REPORT OBJECT
        Dim MyRpt As New masterlist_members

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
            .Add("str8", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("str9", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select x.* from(select a.memcode,a.fullname,a.address,a.birthdate,a.tdate,a.gender,a.civil_stat,a.mobileno,a.occupation,a.membertype,"
        sql += "ttlcycle=isnull((select count(memcode) from loans where memcode=a.memcode),0),"
        sql += "status=isnull((select count(memcode) from loans where status='A' and memcode=a.memcode),0)"
        sql += " from members a"
        sql += ") x where x.tdate<='" + gendate.Value + "' order by x.fullname"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = gendate.Value
            row(3) = productcode
            row(4) = rd("memcode").ToString
            row(5) = rd("Fullname").ToString
            row(6) = rd("address").ToString
            row(7) = rd("ttlcycle").ToString
            row(8) = rd("tdate").ToString
            If rd("status") = 0 Then
                row(9) = "O"
            Else
                row(9) = "A"
            End If
            row(10) = rd("gender").ToString
            row(11) = rd("civil_stat").ToString
            row(12) = rd("mobileno").ToString
            row(13) = rd("occupation").ToString
            row(14) = rd("birthdate")
            row(15) = rd("membertype").ToString
            DS.Tables(0).Rows.Add(row)
        End While

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

    Private Sub frm_masterlist_members_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gendate.Value = systemdate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        gen_masterlist()
        SplashScreen.Close()
    End Sub
End Class