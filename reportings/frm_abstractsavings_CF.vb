Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_abstractsavings_CF

    Private Sub frm_abstractsavings_CF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.Value = DateTime.Now
        dtto.Value = DateTime.Now
    End Sub

    Private Sub abstract_savings()
        'REPORT OBJECT
        Dim MyRpt As New abstractsavings_CF

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str15", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))

            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In lstloanrel.Items
        conn()
        sql = "select a.Debit,a.Credit,b.ctrcode,b.ctrname,a.Postmode,c.accountnumber from Accountledger a,Center b, Accountmaster c  where b.accountnumber=c.accountnumber and a.accountnumber=c.accountnumber  and a.PostingDate BETWEEN '" + dtfrom.Value + "' AND '" + dtto.Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtfrom.Value & " to " & dtto.Value
            row(3) = productcode.ToString

            row(4) = rd("ctrname").ToString & "-" & rd("ctrcode").ToString
            row(5) = rd("accountnumber").ToString
            row(6) = rd("Postmode").ToString
            row(7) = rd("Debit").ToString
            row(8) = rd("Credit").ToString
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
        abstract_savings()
        SplashScreen.Close()
    End Sub
End Class