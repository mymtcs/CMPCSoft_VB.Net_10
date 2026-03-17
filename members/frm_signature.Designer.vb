<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_signature
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
        Me.bttnclear = New System.Windows.Forms.Button()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.bttndone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnclear
        '
        Me.bttnclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnclear.BackColor = System.Drawing.Color.White
        Me.bttnclear.Location = New System.Drawing.Point(592, 410)
        Me.bttnclear.Name = "bttnclear"
        Me.bttnclear.Size = New System.Drawing.Size(97, 35)
        Me.bttnclear.TabIndex = 0
        Me.bttnclear.Text = "Clear"
        Me.bttnclear.UseVisualStyleBackColor = False
        '
        'picbox
        '
        Me.picbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picbox.BackColor = System.Drawing.Color.Black
        Me.picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picbox.Location = New System.Drawing.Point(12, 40)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(774, 364)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox.TabIndex = 1
        Me.picbox.TabStop = False
        '
        'bttndone
        '
        Me.bttndone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttndone.BackColor = System.Drawing.Color.White
        Me.bttndone.Location = New System.Drawing.Point(689, 410)
        Me.bttndone.Name = "bttndone"
        Me.bttndone.Size = New System.Drawing.Size(97, 35)
        Me.bttndone.TabIndex = 2
        Me.bttndone.Text = "Done"
        Me.bttndone.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sign here :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(12, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 2)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(12, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 2)
        Me.Panel2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Upload finger print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_signature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(798, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttndone)
        Me.Controls.Add(Me.picbox)
        Me.Controls.Add(Me.bttnclear)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_signature"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signature"
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnclear As System.Windows.Forms.Button
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
    Friend WithEvents bttndone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
