Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_loantoberel

    Private Sub frm_loantoberel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.Value = systemdate
        dtto.Value = systemdate
    End Sub

    Private Sub loantoberel()
        'REPORT OBJECT
        Dim MyRpt As New loantoberel

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
            .Add("int1", Type.GetType("System.Double"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str6", Type.GetType("System.String"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str13", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In lstloanrel.Items
        conn()
        sql = "select x.*,(x.loanamnt-x.ttldeduction) as netproceeds from(select a.fullname,a.MemCode,b.pnnumber,b.loanamnt,b.releasedate,"
        sql += "PA=(select fullname from officer where collcode=b.collcode),"
        sql += "ttldeduction=isnull((select sum(Amount) from LoansDeduction where pnnumber=b.pnnumber),b.loanamnt) "
        sql += "from members a,loans b where b.releasedate BETWEEN '" + dtfrom.Value + "' AND '" + dtto.Value + "' AND b.Released='N' AND b.status='A' AND a.MemCode=b.MemCode"
        sql += ")x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("pnnumber").ToString
            row(1) = rd("MemCode").ToString
            row(2) = dtfrom.Text & " - " & dtto.Text
            row(3) = rd("fullname").ToString
            row(4) = rd("loanamnt").ToString
            row(5) = rd("releasedate").ToString
            row(6) = rd("PA").ToString
            row(7) = rd("netproceeds").ToString
            row(8) = compaddress.ToString
            row(9) = CompName.ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_loantoberel.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub bttnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsearch.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        loantoberel()
        SplashScreen.Close()
    End Sub
End Class