Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_printID
    Dim memcode As String
    Dim myname As String
    Dim myaddress As String
    Dim mybirthdate As String
    'Dim picbox As PictureBox

    Public Sub genID()
        conn()
        memcode = frm_editmembers.txtmemcode.Text
        myname = frm_editmembers.txtlstname.Text & ", " & frm_editmembers.txtfname.Text & ", " & frm_editmembers.txtmname.Text
        myaddress = "Brgy. " & frm_editmembers.txtbrgy.Text & ", " & frm_editmembers.txtmun.Text & ", " & frm_editmembers.txtprov.Text
        mybirthdate = frm_editmembers.txtbdate.Value

        conn()
        myConn.Open()
        cmd.CommandText = "select blob from ImageFile where memcode='" + memcode + "'"
        cmd.Connection = myConn
        Dim da As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet()
        da.Fill(ds1, "blob")
        Dim c As Integer = ds1.Tables(0).Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte = _
                ds1.Tables(0).Rows(c - 1)("blob")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            picdummy.Image = Image.FromStream(stmBLOBData)
        Else
            picdummy.Image = Image.FromFile(strpath & "\Required\ImageFile\default.jpg")
        End If
        Dim FileToSaveAs As String = strpath & "\Required\ImageFile\profile_dummy.jpg"
        picdummy.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)

        conn()
        myConn.Open()
        cmd.CommandText = "select blob from SignatureFile where memcode='" + memcode + "'"
        cmd.Connection = myConn

        Dim da2 As New SqlDataAdapter(cmd)
        Dim ds2 As New DataSet()
        da2.Fill(ds2, "blob")
        Dim c2 As Integer = ds2.Tables(0).Rows.Count
        If c2 > 0 Then
            Dim bytBLOBData() As Byte = _
                ds2.Tables(0).Rows(c2 - 1)("blob")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            picdummy.Image = Image.FromStream(stmBLOBData)
        Else
            picdummy.Image = Image.FromFile(strpath & "\Required\ImageFile\default.jpg")
        End If
        Dim FileToSaveAssig As String = strpath & "\Required\ImageFile\signature_dummy.jpg"
        picdummy.Image.Save(FileToSaveAssig, System.Drawing.Imaging.ImageFormat.Jpeg)

        'REPORT OBJECT
        Dim MyRpt As New IDMaker

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("str15", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("str14", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items

        row = DS.Tables(0).NewRow
        row(0) = strpath & "\Required\ImageFile\profile_dummy.jpg"
        row(1) = strpath & "\Required\ImageFile\signature_dummy.jpg"
        row(2) = memcode.ToString
        row(3) = myname.ToString
        row(4) = mybirthdate
        row(5) = myaddress.ToString
        row(6) = CompName.ToString
        Try
            row(7) = frm_editmembers.trndate
        Catch ex As Exception
            row(7) = systemdate.ToString("MM/dd/yyyy")
        End Try
        row(8) = systemdate.AddYears(2).ToString("MM/dd/yyyy")
        row(9) = compaddress.ToString
        DS.Tables(0).Rows.Add(row)
        'Next
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub frm_printID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        genID()
    End Sub
End Class