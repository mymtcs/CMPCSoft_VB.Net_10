Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_amortsched
    Dim ctrcode As String
    Dim collcode As String
    Dim ctrchief As String

    Private Sub amortsched_GRP()
        'REPORT OBJECT
        Dim MyRpt As New amortsched

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))    '0
            .Add("str12", Type.GetType("System.String"))    '1
            .Add("str16", Type.GetType("System.String"))    '2 
            .Add("str5", Type.GetType("System.String"))     '3 
            .Add("str6", Type.GetType("System.String"))     '4
            .Add("str7", Type.GetType("System.String"))     '5
            .Add("date1", Type.GetType("System.DateTime"))  '6
            .Add("int2", Type.GetType("System.Double"))     '7
            .Add("int3", Type.GetType("System.Double"))     '8

            .Add("str9", Type.GetType("System.String"))     '9
            .Add("str10", Type.GetType("System.String"))    '10
            .Add("str11", Type.GetType("System.String"))    '11

            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("int8", Type.GetType("System.Double"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("date2", Type.GetType("System.DateTime"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select c.LnNum,a.fullname,b.pnnumber,(d.fullname) as collname,b.firstpaymentdate,c.duedate,c.Principal,c.Interest,c.savings,c.CF,c.LH from members a, loans b,loansched c, officer d where b.pnnumber='" + loannumber + "' AND b.pnnumber=c.pnnumber AND a.MemCode=b.MemCode AND b.collcode=d.collcode "
        sql += "GROUP BY c.LnNum,a.fullname,b.pnnumber,d.fullname,b.firstpaymentdate,c.duedate,c.Principal,c.Interest,c.savings,c.CF,c.LH ORDER BY c.duedate ASC"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = productcode.ToString
            row(3) = rd("pnnumber").ToString
            row(4) = rd("fullname").ToString
            row(5) = rd("collname").ToString
            row(6) = rd("duedate").ToString
            row(7) = rd("Principal").ToString
            row(8) = rd("Interest").ToString

            row(9) = usersname.ToString
            'change to bookker
            'row(10) = AreaSupervisor.ToString
            row(10) = bookkeeper.ToString

            'change to blank
            'row(11) = cashier.ToString
            row(11) = "" ' blank now

            Try
                row(12) = rd("savings").ToString
            Catch ex As Exception
                row(12) = 0
            End Try
            Try
                row(13) = rd("CF").ToString
            Catch ex As Exception
                row(13) = 0
            End Try
            Try
                row(14) = rd("LH").ToString
            Catch ex As Exception
                row(14) = 0
            End Try
            row(15) = rd("LnNum").ToString
            row(16) = rd("firstpaymentdate").ToString
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


    Private Sub amortsched_IL()
        'REPORT OBJECT
        Dim MyRpt As New amortsched_IL

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

            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))

            .Add("str9", Type.GetType("System.String"))
            .Add("str10", Type.GetType("System.String"))
            .Add("str11", Type.GetType("System.String"))

            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("int8", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select c.LnNum,a.fullname,b.pnnumber,(d.fullname) as collname,b.firstpaymentdate,c.duedate,c.Principal,c.Interest,c.savings,c.LH from members a, loans b,loansched c, officer d where b.pnnumber='" + loannumber + "' AND b.pnnumber=c.pnnumber AND a.MemCode=b.MemCode AND b.collcode=d.collcode "
        sql += "GROUP BY c.LnNum,a.fullname,b.pnnumber,d.fullname,b.firstpaymentdate,c.duedate,c.Principal,c.Interest,c.savings,c.LH ORDER BY c.duedate ASC"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = productcode.ToString
            row(3) = rd("pnnumber").ToString
            row(4) = rd("fullname").ToString
            row(5) = rd("collname").ToString
            row(6) = rd("duedate").ToString
            row(7) = rd("Principal").ToString
            row(8) = rd("Interest").ToString

            row(9) = usersname.ToString
            'row(10) = AreaSupervisor.ToString
            'row(10) = AreaSupervisor.ToString
            row(10) = bookkeeper.ToString

            row(11) = cashier.ToString
            'row(11) = cashier.ToString
            row(11) = "" ' blank now

            row(12) = rd("savings").ToString
            row(13) = rd("LnNum").ToString
            row(14) = rd("firstpaymentdate").ToString
            Try
                row(15) = rd("LH").ToString
            Catch ex As Exception
                row(15) = 0
            End Try
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
        'SplashScreen.count = 0
        'Control.CheckForIllegalCrossThreadCalls = False
        'thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        'thread.Start()
        GL_loans = frm_newloanlist.txtloantype.SelectedValue
        select_grptype()
        If grouptype = "N" Then
            amortsched_IL()
        Else
            amortsched_GRP()
        End If
        'SplashScreen.Close()
    End Sub

End Class