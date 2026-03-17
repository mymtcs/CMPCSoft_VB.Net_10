<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_promisorry_note
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_promisorry_note))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.pic_img = New System.Windows.Forms.PictureBox()
        CType(Me.pic_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRviewer.Location = New System.Drawing.Point(0, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(1134, 598)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'pic_img
        '
        Me.pic_img.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pic_img.Image = CType(resources.GetObject("pic_img.Image"), System.Drawing.Image)
        Me.pic_img.Location = New System.Drawing.Point(28, 53)
        Me.pic_img.Name = "pic_img"
        Me.pic_img.Size = New System.Drawing.Size(144, 116)
        Me.pic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_img.TabIndex = 1
        Me.pic_img.TabStop = False
        Me.pic_img.Visible = False
        '
        'frm_promisorry_note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1134, 598)
        Me.Controls.Add(Me.pic_img)
        Me.Controls.Add(Me.CRviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_promisorry_note"
        Me.ShowIcon = False
        Me.Text = "Promissory Note"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pic_img As System.Windows.Forms.PictureBox
End Class
