Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class frm_signature
    Private _Previous As System.Nullable(Of Point) = Nothing

    Private Sub frm_signature_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picbox.BackgroundImage = Nothing
    End Sub

    Private Sub bttnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclear.Click
        picbox.Image = Nothing
    End Sub

    Private Sub picbox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picbox.MouseDown
        _Previous = e.Location
        picbox_MouseMove(sender, e)
    End Sub

    Private Sub picbox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picbox.MouseMove
        If _Previous IsNot Nothing Then
            Dim X As Integer = Me.PointToClient(Cursor.Position).X
            Dim Y As Integer = Me.PointToClient(Cursor.Position).Y
            If X < 13 Then X = 13
            If X > 778 Then X = 778
            If Y < 40 Then Y = 40
            If Y > 390 Then Y = 390
            Cursor.Position = Me.PointToScreen(New Point(X, Y))
            If picbox.Image Is Nothing Then
                Dim bmp As New Bitmap(picbox.Width, picbox.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.Clear(Color.White)
                End Using
                picbox.Image = bmp
            End If
            Dim pen1 As New System.Drawing.Pen(Color.Black, 4)
            Using g As Graphics = Graphics.FromImage(picbox.Image)
                g.DrawLine(pen1, _Previous.Value, e.Location)
            End Using
            picbox.Invalidate()
            _Previous = e.Location
        End If
    End Sub

    Private Sub picbox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picbox.MouseUp
        _Previous = Nothing
    End Sub

    Private Sub bttndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndone.Click
        conn()
        sql = "DELETE FROM SignatureFile WHERE Memcode='" + frm_editmembers.txtmemcode.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()


        Dim FileToSaveAs As String = strpath & "\Required\ImageFile\signature.jpg"
        picbox.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)

        picbox.BackgroundImage = Image.FromFile(strpath & "\Required\ImageFile\signature.jpg")

        conn()
        sql = "INSERT INTO SignatureFile VALUES(@Memcode,@DateTaken,@path,@userID,@blob)"
        cmd = New SqlCommand(sql, myConn)
        cmd.Parameters.AddWithValue("@Memcode", frm_editmembers.txtmemcode.Text)
        cmd.Parameters.AddWithValue("@DateTaken", systemdate)
        cmd.Parameters.AddWithValue("@path", frm_editmembers.txtmemcode.Text & ".jpg")
        cmd.Parameters.AddWithValue("@userID", user)
        Dim ms As New MemoryStream()
        picbox.BackgroundImage.Save(ms, picbox.BackgroundImage.RawFormat)
        Dim dataBuff As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@blob", SqlDbType.Image)
        p.Value = dataBuff
        cmd.Parameters.Add(p)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        MsgBox("Adding signature complete.", MsgBoxStyle.Information, "Message")
        picbox.Image = Nothing
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Choose a Profile Photo"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fdlg.FilterIndex = 2
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = DialogResult.OK Then
            If File.Exists(fdlg.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                picbox.ImageLocation = fdlg.FileName
            End If
        End If
    End Sub
End Class