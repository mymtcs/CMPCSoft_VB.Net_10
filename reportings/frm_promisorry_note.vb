Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_promisorry_note
    Dim picbox As PictureBox
    Dim bmap As Bitmap
    Dim path As String = System.IO.Path.GetDirectoryName( _
               System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
    Dim strpath As String = path & "\Required\ImageFile\dummy.jpg"

    Public Sub viewIMG()
        'conn()
        'sql = "select path from ImageFile where Memcode='" + txtmemcode.Text + "'"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader
        'If rd.Read Then
        '    Dim path As String = System.IO.Path.GetDirectoryName( _
        '        System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        '    Dim strpath As String = path.Replace("file:\", "") & "\Required\ImageFile\" & rd("path")
        '    Try
        '        pic_img.Image = Image.FromFile(strpath)
        '    Catch ex As Exception

        '    End Try
        'End If
        'rd.Close()
        'myConn.Close()
        conn()
        myConn.Open()
        cmd.CommandText = "select blob from imagefile where memcode='" + frm_newloanlist.dtgridloanlist.CurrentRow.Cells(1).Value + "'"
        cmd.Connection = myConn
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds, "blob")
        Dim c As Integer = ds.Tables(0).Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte = _
                ds.Tables(0).Rows(c - 1)("blob")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            pic_img.Image = Image.FromStream(stmBLOBData)
            pic_img.BackgroundImageLayout = ImageLayout.Zoom
        End If
     
        pic_img.Image.Save("D:\dummy.jpg", Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub frmmaster_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        'viewIMG()

        If grouptype = "N" Then
            If isPension = "Y" Then
                PN_pension()
            Else
                PN_indv()
            End If
        ElseIf grouptype = "Y" Then
            PN_grp()
        Else
            PN_indv()
        End If
        SplashScreen.Close()
    End Sub

    Private Sub PN_pension()
        'REPORT OBJECT
        Dim MyRpt As New PromissoryNotePension

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String")) '0
            .Add("str2", Type.GetType("System.String")) '1
            .Add("int1", Type.GetType("System.Double")) '2
            .Add("date1", Type.GetType("System.DateTime")) '3
            .Add("date2", Type.GetType("System.DateTime")) '4
            .Add("int4", Type.GetType("System.Double")) '5
            .Add("int5", Type.GetType("System.Double")) '6
            .Add("date3", Type.GetType("System.DateTime")) '7
            .Add("date4", Type.GetType("System.DateTime")) '8
            .Add("int2", Type.GetType("System.Double")) '9
            .Add("int3", Type.GetType("System.Double")) '10
            .Add("int8", Type.GetType("System.Double")) '11
            .Add("str4", Type.GetType("System.String")) '12
            .Add("str5", Type.GetType("System.String")) '13
            .Add("str10", Type.GetType("System.String")) '14
            .Add("str11", Type.GetType("System.String")) '15
            .Add("int6", Type.GetType("System.Double")) '16
            .Add("int7", Type.GetType("System.Double")) '17
            .Add("str9", Type.GetType("System.String")) '18
            .Add("str6", Type.GetType("System.String")) '19
            '.Add("str3", Type.GetType("System.String")) '20
        End With
        conn()
        sql = "select a.*,b.fullname,b.address,comaker=isnull((select comaker from LoanComaker where pnnumber=a.pnnumber),'not Applicable') from loans a,members b where a.memcode=b.memcode and pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
            row = DS.Tables(0).NewRow
            row(0) = rd("pnnumber")
            row(1) = rd("fullname")
            row(2) = rd("LoanAmnt")
            row(3) = rd("maturitydate")
            row(4) = rd("Releasedate")
            row(5) = rd("LoanAmnt")
            row(6) = rd("IntRate")
            row(7) = rd("Firstpaymentdate")
            row(8) = rd("maturitydate")
            row(9) = rd("PayNo")
            row(10) = rd("LoanAmnt")
            row(11) = (Double.Parse(rd("LoanAmnt")) / Double.Parse(rd("PayNo"))) * Double.Parse(rd("PenaltyRate"))
            row(12) = rd("pnnumber")
            row(13) = rd("CoMaker")
            row(14) = CompName.ToString
            row(15) = compaddress.ToString
            row(16) = rd("PenaltyRate").ToString
            row(17) = DateDiff(DateInterval.Day, rd("Releasedate"), rd("Firstpaymentdate"))
            row(18) = AmountInWords(rd("LoanAmnt"))
            row(19) = rd("ModeOfPayment")
            'row(20) = "D:\dummy.jpg"
            DS.Tables(0).Rows.Add(row)
        End If
        rd.Close()
        myConn.Close()
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
        CRviewer.Refresh()
    End Sub

    Private Sub PN_indv()
        'REPORT OBJECT
        Dim MyRpt As New Promissory_Notes

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String")) '0
            .Add("str2", Type.GetType("System.String")) '1
            .Add("int1", Type.GetType("System.Double")) '2
            .Add("date1", Type.GetType("System.DateTime")) '3
            .Add("date2", Type.GetType("System.DateTime")) '4
            .Add("int4", Type.GetType("System.Double")) '5
            .Add("int5", Type.GetType("System.Double")) '6
            .Add("date3", Type.GetType("System.DateTime")) '7
            .Add("date4", Type.GetType("System.DateTime")) '8
            .Add("int2", Type.GetType("System.Double")) '9
            .Add("int3", Type.GetType("System.Double")) '10
            .Add("int8", Type.GetType("System.Double")) '11
            .Add("str4", Type.GetType("System.String")) '12
            .Add("str5", Type.GetType("System.String")) '13
            .Add("str10", Type.GetType("System.String")) '14
            .Add("str11", Type.GetType("System.String")) '15
            .Add("int6", Type.GetType("System.Double")) '16
            .Add("int7", Type.GetType("System.Double")) '17
            .Add("str9", Type.GetType("System.String")) '18
            .Add("str6", Type.GetType("System.String")) '19
            '.Add("str16", Type.GetType("System.String")) '20
            '.Add("img", Type.GetType("System.Byte[]")) '20
            ' .Add("str3", Type.GetType("System.String")) '13
        End With
        conn()
        sql = "select a.*,b.fullname,b.address,comaker=isnull((select comaker from LoanComaker where pnnumber=a.pnnumber),'not Applicable') from loans a,members b where a.memcode=b.memcode and pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then

            'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
            row = DS.Tables(0).NewRow
            row(0) = rd("pnnumber")
            row(1) = rd("fullname")
            row(2) = rd("LoanAmnt")
            row(3) = rd("maturitydate")
            row(4) = rd("Releasedate")
            row(5) = rd("LoanAmnt")
            row(6) = rd("IntRate")
            row(7) = rd("Firstpaymentdate")
            row(8) = rd("maturitydate")
            row(9) = rd("PayNo")
            row(10) = rd("LoanAmnt")
            row(11) = (Double.Parse(rd("LoanAmnt")) / Double.Parse(rd("PayNo"))) * Double.Parse(rd("PenaltyRate"))
            row(12) = rd("pnnumber")
            row(13) = rd("CoMaker")
            row(14) = CompName.ToString
            row(15) = compaddress.ToString
            row(16) = rd("PenaltyRate").ToString
            row(17) = DateDiff(DateInterval.Day, rd("Releasedate"), rd("Firstpaymentdate"))
            row(18) = AmountInWords(rd("LoanAmnt"))
            row(19) = rd("ModeOfPayment")
            'row(20) = "C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"
            'row(21) = System.Text.Encoding.ASCII.GetBytes("D:\My Projects\CMPCsoft\CMPCsoft\bin\Debug\Required\ImageFile\16-03000004-17.jpg")
            DS.Tables(0).Rows.Add(row)
        End If
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub PN_grp()
        'REPORT OBJECT
        Dim MyRpt As New Promissory_Notes

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String")) '0
            .Add("str2", Type.GetType("System.String")) '1
            .Add("int1", Type.GetType("System.Double")) '2
            .Add("date1", Type.GetType("System.DateTime")) '3
            .Add("date2", Type.GetType("System.DateTime")) '4
            .Add("int4", Type.GetType("System.Double")) '5
            .Add("int5", Type.GetType("System.Double")) '6
            .Add("date3", Type.GetType("System.DateTime")) '7
            .Add("date4", Type.GetType("System.DateTime")) '8
            .Add("int2", Type.GetType("System.Double")) '9
            .Add("int3", Type.GetType("System.Double")) '10
            .Add("str3", Type.GetType("System.String")) '11
            .Add("str4", Type.GetType("System.String")) '12
            .Add("str5", Type.GetType("System.String")) '13
            .Add("str10", Type.GetType("System.String")) '14
            .Add("str11", Type.GetType("System.String")) '15
            .Add("int6", Type.GetType("System.Double")) '16
            .Add("int7", Type.GetType("System.Double")) '17
            .Add("str9", Type.GetType("System.String")) '18
            .Add("str6", Type.GetType("System.String")) '19
            ' .Add("str7", Type.GetType("System.String")) '20
            '.Add("img", Type.GetType("System.Byte[]")) '20
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        conn()
        sql = "select a.*,b.fullname,b.address,comaker=isnull((select comaker from LoanComaker where pnnumber=a.pnnumber),'not Applicable') from loans a,members b where a.memcode=b.memcode and pnnumber='" & loannumber & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then

            'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
            row = DS.Tables(0).NewRow
            row(0) = rd("pnnumber")
            row(1) = rd("fullname")
            row(2) = rd("LoanAmnt")
            row(3) = rd("maturitydate")
            row(4) = rd("Releasedate")
            row(5) = rd("LoanAmnt")
            row(6) = rd("IntRate")
            row(7) = rd("Firstpaymentdate")
            row(8) = rd("maturitydate")
            row(9) = rd("PayNo")
            row(10) = rd("LoanAmnt")
            row(11) = (Double.Parse(rd("LoanAmnt")) / Double.Parse(rd("PayNo"))) * Double.Parse(rd("PenaltyRate"))
            row(12) = rd("pnnumber")
            row(13) = rd("CoMaker")
            row(14) = CompName.ToString
            row(15) = compaddress.ToString
            row(16) = rd("PenaltyRate").ToString
            row(17) = DateDiff(DateInterval.Day, rd("Releasedate"), rd("Firstpaymentdate"))
            row(18) = AmountInWords(rd("LoanAmnt"))
            row(19) = rd("ModeOfPayment")
            'row(20) = "C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"
            'row(21) = System.Text.Encoding.ASCII.GetBytes("D:\My Projects\CMPCsoft\CMPCsoft\bin\Debug\Required\ImageFile\16-03000004-17.jpg")
            DS.Tables(0).Rows.Add(row)
        End If
        rd.Close()
        myConn.Close()

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofd As New OpenFileDialog()

        ofd.Multiselect = False

        ofd.Filter = "Images|*.jpg;*gif;*.bmp"

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.createReports(Me.savepic(ofd.FileName))

        Else

            MessageBox.Show("Please select a Picture")

        End If
    End Sub

    Public Function savepic(ByVal fsource As String) As Byte()

        Dim arrImage() As Byte = Nothing

        If File.Exists(fsource) = False Then

            Return arrImage

        End If

        Dim img As Image = Image.FromFile(fsource)

        Dim ms As New IO.MemoryStream

        img.Save(ms, img.RawFormat)

        arrImage = ms.GetBuffer

        ms.Close()

        Return arrImage

    End Function


    Private Sub createReports(ByVal image() As Byte)
        'REPORT OBJECT
        Dim MyRpt As New Promissory_Notesample

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String")) '0
            '.Add("img", Type.GetType("System.Byte()")) '0
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        row = DS.Tables(0).NewRow
        row(0) = compaddress.ToString
        DS.Tables(0).Rows.Add(row)
        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        CRviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

End Class