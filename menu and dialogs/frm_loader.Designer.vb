<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loader))
        Me.picload = New System.Windows.Forms.PictureBox()
        CType(Me.picload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picload
        '
        Me.picload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picload.Image = CType(resources.GetObject("picload.Image"), System.Drawing.Image)
        Me.picload.Location = New System.Drawing.Point(510, 31)
        Me.picload.Name = "picload"
        Me.picload.Size = New System.Drawing.Size(272, 233)
        Me.picload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picload.TabIndex = 1
        Me.picload.TabStop = False
        '
        'frm_loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1316, 328)
        Me.Controls.Add(Me.picload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_loader"
        Me.Text = "frm_loader"
        CType(Me.picload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picload As System.Windows.Forms.PictureBox
End Class
