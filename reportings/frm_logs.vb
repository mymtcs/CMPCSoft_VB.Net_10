Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_logs

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        amortsched_GRP()
    End Sub

    Private Sub amortsched_GRP()
        'REPORT OBJECT
        Dim MyRpt As New logs

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "SELECT * FROM LOGS WHERE date BETWEEN '" + dtfrom.Value + "' and '" + dtto.Value + "'"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = rd("pnnumber").ToString
            row(3) = rd("reasons").ToString
            row(4) = rd("time").ToString
            row(5) = rd("userID").ToString
            row(6) = rd("date").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_loanrel.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub frm_logs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtfrom.Value = systemdate
        dtto.Value = systemdate
    End Sub
End Class