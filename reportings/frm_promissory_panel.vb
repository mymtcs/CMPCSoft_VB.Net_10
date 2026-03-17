Imports System.Drawing.Printing


Public Class frm_promissory_panel
    Private WithEvents pndocument As PrintDocument

    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
  Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, _
 ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
    End Function
    'get the screenshot
    Private memoryImage As Bitmap
    Private Sub CaptureScreen()
        Dim mygraphics As Graphics = Me.Panel1.CreateGraphics()
        Dim s As Size = Me.Panel1.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.Panel1.ClientRectangle.Width, Me.Panel1.ClientRectangle.Height, dc1, _
         0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub



    Private Sub frm_promissory_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_print.Click
        CaptureScreen()
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
      e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub
End Class