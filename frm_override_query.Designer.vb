<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_override_query
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_override_query))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtpassword_override = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.bttn_cancel = New System.Windows.Forms.Button()
        Me.bttn_override = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtuser_override = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.txtpassword_override)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(14, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(376, 59)
        Me.Panel5.TabIndex = 1
        '
        'txtpassword_override
        '
        Me.txtpassword_override.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpassword_override.BackColor = System.Drawing.Color.White
        Me.txtpassword_override.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword_override.Font = New System.Drawing.Font("Calibri", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword_override.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword_override.Location = New System.Drawing.Point(67, 8)
        Me.txtpassword_override.Name = "txtpassword_override"
        Me.txtpassword_override.Size = New System.Drawing.Size(300, 36)
        Me.txtpassword_override.TabIndex = 1
        Me.txtpassword_override.Text = "12345"
        Me.txtpassword_override.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'bttn_cancel
        '
        Me.bttn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttn_cancel.BackColor = System.Drawing.Color.White
        Me.bttn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.bttn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_cancel.ForeColor = System.Drawing.Color.Black
        Me.bttn_cancel.Location = New System.Drawing.Point(298, 165)
        Me.bttn_cancel.Name = "bttn_cancel"
        Me.bttn_cancel.Size = New System.Drawing.Size(92, 40)
        Me.bttn_cancel.TabIndex = 53
        Me.bttn_cancel.Text = "Cancel"
        Me.bttn_cancel.UseVisualStyleBackColor = False
        '
        'bttn_override
        '
        Me.bttn_override.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttn_override.BackColor = System.Drawing.Color.White
        Me.bttn_override.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.bttn_override.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_override.ForeColor = System.Drawing.Color.Black
        Me.bttn_override.Location = New System.Drawing.Point(200, 165)
        Me.bttn_override.Name = "bttn_override"
        Me.bttn_override.Size = New System.Drawing.Size(92, 40)
        Me.bttn_override.TabIndex = 3
        Me.bttn_override.Text = "Override"
        Me.bttn_override.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtuser_override)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 59)
        Me.Panel1.TabIndex = 0
        '
        'txtuser_override
        '
        Me.txtuser_override.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtuser_override.BackColor = System.Drawing.Color.White
        Me.txtuser_override.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser_override.Font = New System.Drawing.Font("Calibri", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser_override.ForeColor = System.Drawing.Color.Gray
        Me.txtuser_override.Location = New System.Drawing.Point(67, 8)
        Me.txtuser_override.Name = "txtuser_override"
        Me.txtuser_override.Size = New System.Drawing.Size(300, 36)
        Me.txtuser_override.TabIndex = 0
        Me.txtuser_override.Text = "12345"
        Me.txtuser_override.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frm_override_query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(406, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttn_cancel)
        Me.Controls.Add(Me.bttn_override)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_override_query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Override Query"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtpassword_override As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents bttn_cancel As System.Windows.Forms.Button
    Friend WithEvents bttn_override As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtuser_override As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
