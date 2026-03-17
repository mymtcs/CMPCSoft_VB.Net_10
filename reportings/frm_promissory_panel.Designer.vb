<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_promissory_panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_promissory_panel))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picmember = New System.Windows.Forms.PictureBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btn_printpreview = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bttn_print = New System.Windows.Forms.ToolStripButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.picmember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.picmember)
        Me.Panel1.Location = New System.Drawing.Point(246, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 464)
        Me.Panel1.TabIndex = 0
        '
        'picmember
        '
        Me.picmember.BackColor = System.Drawing.Color.Black
        Me.picmember.Location = New System.Drawing.Point(618, 22)
        Me.picmember.Name = "picmember"
        Me.picmember.Size = New System.Drawing.Size(144, 133)
        Me.picmember.TabIndex = 0
        Me.picmember.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttn_print, Me.ToolStripSeparator1, Me.btn_printpreview})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1254, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Image = CType(resources.GetObject("btn_printpreview.Image"), System.Drawing.Image)
        Me.btn_printpreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(96, 22)
        Me.btn_printpreview.Text = "Print Preview"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bttn_print
        '
        Me.bttn_print.Image = CType(resources.GetObject("bttn_print.Image"), System.Drawing.Image)
        Me.bttn_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttn_print.Name = "bttn_print"
        Me.bttn_print.Size = New System.Drawing.Size(52, 22)
        Me.bttn_print.Text = "Print"
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(706, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'frm_promissory_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1254, 504)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_promissory_panel"
        Me.ShowIcon = False
        Me.Text = "Promissory Note"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picmember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picmember As System.Windows.Forms.PictureBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_printpreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttn_print As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
