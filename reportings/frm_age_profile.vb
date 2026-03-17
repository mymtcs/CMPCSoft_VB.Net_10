Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_age_profile

    Private Sub gen_masterlist()
        Dim MyRpt As New age_profile

        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        DS.Tables.Add("dummy")

        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
        End With

        conn()
        sql = "SELECT COUNT(DISTINCT Members.Memcode) as members FROM Loans INNER JOIN Members on Loans.Memcode = Members.Memcode WHERE Members.age BETWEEN '" & age_from.Text & "' AND '" & age_to.Text & "' AND Loans.status = 'A' AND Loans.Released = 'Y'"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("members").ToString
            row(1) = "Ages " & age_from.Text & "-" & age_to.Text
            DS.Tables(0).Rows.Add(row)
        End While

        MyRpt.SetDataSource(DS)

        vwr_age_profile.ReportSource = MyRpt

        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gen_masterlist()
    End Sub

    Private Sub frm_age_profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 18 To 110
            age_from.Items.Add(i)
            age_to.Items.Add(i)
        Next
    End Sub
End Class