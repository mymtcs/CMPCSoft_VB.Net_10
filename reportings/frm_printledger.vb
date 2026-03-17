Imports System
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frm_printledger

    Private Sub frm_printledger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generate_delinquency()
    End Sub

    Private Sub generate_delinquency()
        'REPORT OBJECT
        Dim MyRpt As New loanledger

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))

            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int9", Type.GetType("System.Double"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("date4", Type.GetType("System.DateTime"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int8", Type.GetType("System.Double"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("int10", Type.GetType("System.Double"))
            .Add("int11", Type.GetType("System.Double"))
            .Add("int12", Type.GetType("System.Double"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("int13", Type.GetType("System.Double"))
            .Add("int14", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        For Each LVI As ListViewItem In frm_members.lstloanledger.Items
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString

            row(2) = frm_members.dtgridloan_list.CurrentRow.Cells(0).Value
            row(3) = frm_members.dtgridmember.CurrentRow.Cells(1).Value

            row(4) = LVI.SubItems(0).Text
            row(5) = LVI.SubItems(1).Text
            row(6) = LVI.SubItems(2).Text
            row(7) = LVI.SubItems(3).Text
            row(8) = LVI.SubItems(4).Text
            row(9) = LVI.SubItems(5).Text
            row(10) = LVI.SubItems(6).Text
            row(11) = LVI.SubItems(7).Text
            row(12) = LVI.SubItems(8).Text
            row(13) = LVI.SubItems(9).Text
            row(14) = LVI.SubItems(10).Text
            row(15) = LVI.SubItems(11).Text
            row(16) = LVI.SubItems(14).Text
            row(17) = LVI.SubItems(15).Text
            row(18) = LVI.SubItems(16).Text
            row(19) = LVI.SubItems(18).Text
            row(20) = LVI.SubItems(17).Text
            row(21) = frm_members.dtgridmember.CurrentRow.Cells(2).Value
            row(22) = frm_members.dtgridloan_list.CurrentRow.Cells(3).Value
            row(23) = frm_members.dtgridloan_list.CurrentRow.Cells(4).Value
            Try
                row(24) = LVI.SubItems(12).Text
            Catch ex As Exception
                row(24) = 0
            End Try
            Try
                row(25) = LVI.SubItems(13).Text
            Catch ex As Exception
                row(25) = 0
            End Try
            DS.Tables(0).Rows.Add(row)
            'End While

            'row(8) = MDIfrm.lblparval.Text

        Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub
End Class