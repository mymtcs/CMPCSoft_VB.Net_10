<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_sssinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_edit_sssinfo))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttnsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttnclose = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsss = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbdate = New System.Windows.Forms.TextBox()
        Me.txtmember = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttnsave, Me.ToolStripSeparator1, Me.bttnclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(290, 25)
        Me.ToolStrip1.TabIndex = 126
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttnsave
        '
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(57, 22)
        Me.bttnsave.Text = "Save  "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bttnclose
        '
        Me.bttnclose.Image = CType(resources.GetObject("bttnclose.Image"), System.Drawing.Image)
        Me.bttnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnclose.Name = "bttnclose"
        Me.bttnclose.Size = New System.Drawing.Size(56, 22)
        Me.bttnclose.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Members Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "SSS No."
        '
        'txtsss
        '
        Me.txtsss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsss.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsss.Location = New System.Drawing.Point(12, 189)
        Me.txtsss.MaxLength = 11
        Me.txtsss.Name = "txtsss"
        Me.txtsss.Size = New System.Drawing.Size(266, 29)
        Me.txtsss.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Birthdate"
        '
        'txtbdate
        '
        Me.txtbdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbdate.Enabled = False
        Me.txtbdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbdate.Location = New System.Drawing.Point(12, 132)
        Me.txtbdate.Name = "txtbdate"
        Me.txtbdate.Size = New System.Drawing.Size(266, 29)
        Me.txtbdate.TabIndex = 131
        '
        'txtmember
        '
        Me.txtmember.DropDownWidth = 600
        Me.txtmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtmember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmember.FormattingEnabled = True
        Me.txtmember.Location = New System.Drawing.Point(12, 71)
        Me.txtmember.Name = "txtmember"
        Me.txtmember.Size = New System.Drawing.Size(266, 24)
        Me.txtmember.TabIndex = 133
        '
        'frm_edit_sssinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(290, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtmember)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsss)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_edit_sssinfo"
        Me.Text = "SSS Master"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttnclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsss As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbdate As System.Windows.Forms.TextBox
    Friend WithEvents txtmember As System.Windows.Forms.ComboBox
End Class
