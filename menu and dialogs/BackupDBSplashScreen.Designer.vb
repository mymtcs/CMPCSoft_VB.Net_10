<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupDBSplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackupDBSplashScreen))
        Me.lblprocess = New System.Windows.Forms.Label()
        Me.tmrsplah = New System.Windows.Forms.Timer(Me.components)
        Me.picload = New System.Windows.Forms.PictureBox()
        Me.lbl_back = New System.Windows.Forms.Label()
        Me.bttnok = New System.Windows.Forms.LinkLabel()
        CType(Me.picload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblprocess
        '
        Me.lblprocess.AutoSize = True
        Me.lblprocess.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblprocess.Location = New System.Drawing.Point(526, 420)
        Me.lblprocess.Name = "lblprocess"
        Me.lblprocess.Size = New System.Drawing.Size(85, 13)
        Me.lblprocess.TabIndex = 0
        Me.lblprocess.Text = "Analyzing data..."
        '
        'tmrsplah
        '
        Me.tmrsplah.Interval = 1000
        '
        'picload
        '
        Me.picload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picload.Image = CType(resources.GetObject("picload.Image"), System.Drawing.Image)
        Me.picload.Location = New System.Drawing.Point(423, 121)
        Me.picload.Name = "picload"
        Me.picload.Size = New System.Drawing.Size(808, 249)
        Me.picload.TabIndex = 2
        Me.picload.TabStop = False
        '
        'lbl_back
        '
        Me.lbl_back.AutoSize = True
        Me.lbl_back.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_back.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_back.Location = New System.Drawing.Point(522, 373)
        Me.lbl_back.Name = "lbl_back"
        Me.lbl_back.Size = New System.Drawing.Size(257, 39)
        Me.lbl_back.TabIndex = 3
        Me.lbl_back.Text = "backup database..."
        '
        'bttnok
        '
        Me.bttnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnok.AutoSize = True
        Me.bttnok.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnok.Location = New System.Drawing.Point(1193, 8)
        Me.bttnok.Name = "bttnok"
        Me.bttnok.Size = New System.Drawing.Size(43, 19)
        Me.bttnok.TabIndex = 5
        Me.bttnok.TabStop = True
        Me.bttnok.Text = "Close"
        Me.bttnok.Visible = False
        '
        'BackupDBSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1248, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnok)
        Me.Controls.Add(Me.lblprocess)
        Me.Controls.Add(Me.lbl_back)
        Me.Controls.Add(Me.picload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackupDBSplashScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblprocess As System.Windows.Forms.Label
    Friend WithEvents tmrsplah As System.Windows.Forms.Timer
    Friend WithEvents picload As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_back As System.Windows.Forms.Label
    Friend WithEvents bttnok As System.Windows.Forms.LinkLabel

End Class
