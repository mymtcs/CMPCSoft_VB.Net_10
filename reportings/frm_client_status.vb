Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_client_status
    Dim ctrcode As String
    Dim collcode As String
    Dim ctrchief As String

    Private Sub generate_client_status()
        'REPORT OBJECT
        Dim MyRpt As New client_status

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("str4", Type.GetType("System.String"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int7", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select x.* from( select ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number,a.pnnumber,a.MemCode,a.releasedate,a.loanamnt,a.status,"
        sql += "Fullname=(select fullname from members where MemCode=a.MemCode),"
        sql += "Address=(select address from members where MemCode=a.MemCode),"
        sql += "Totalsched=isnull((select count(duedate) from loansched where pnnumber=a.pnnumber and duedate<='" + systemdate + "'),0), "
        sql += "TtlPaidOnTime=isnull((select count(collectiondate) from loancollect where trnxdate<=collectiondate and pnnumber=a.pnnumber),0),"
        sql += "TtlLatePaidOnTime=isnull((select count(collectiondate) from loancollect where trnxdate<>collectiondate and pnnumber=a.pnnumber),0),"
        sql += "MaxDateLate=isnull((select max(datediff(day,collectiondate,trnxdate)) from loancollect where pnnumber=a.pnnumber),0) "
        sql += "from loans a where a.MemCode='" + frm_members.dtgridmember.CurrentRow.Cells(0).Value + "'"
        sql += ")x order by x.pnnumber"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = productcode.ToString
            row(3) = rd("MemCode").ToString
            row(4) = rd("Fullname").ToString
            row(5) = rd("Address").ToString
            row(6) = rd("number").ToString
            If rd("status") = "A" Then
                row(7) = rd("pnnumber").ToString & " (current)"
            Else
                row(7) = rd("pnnumber").ToString
            End If
            row(8) = rd("releasedate").ToString
            row(9) = rd("loanamnt").ToString
            row(10) = rd("Totalsched").ToString
            row(11) = rd("TtlPaidOnTime").ToString
            row(12) = rd("TtlLatePaidOnTime").ToString
            row(13) = rd("MaxDateLate").ToString
            row(14) = (rd("TtlPaidOnTime") / rd("Totalsched")) * 100
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
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        generate_client_status()
        SplashScreen.Close()
    End Sub

End Class