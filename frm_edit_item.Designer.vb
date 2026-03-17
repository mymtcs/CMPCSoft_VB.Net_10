<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_edit_item))
        Me.bttnsave = New System.Windows.Forms.Button
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcat = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttnsave.BackColor = System.Drawing.Color.Ivory
        Me.bttnsave.BackgroundImage = CType(resources.GetObject("bttnsave.BackgroundImage"), System.Drawing.Image)
        Me.bttnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnsave.FlatAppearance.BorderSize = 0
        Me.bttnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bttnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnsave.ForeColor = System.Drawing.Color.White
        Me.bttnsave.Location = New System.Drawing.Point(109, 180)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(113, 49)
        Me.bttnsave.TabIndex = 2
        Me.bttnsave.Text = "Save"
        Me.bttnsave.UseVisualStyleBackColor = False
        '
        'txtcode
        '
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(12, 48)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(155, 24)
        Me.txtcode.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Item Code :"
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(12, 150)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(318, 24)
        Me.txtdesc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Item Decription :"
        '
        'txtcat
        '
        Me.txtcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcat.FormattingEnabled = True
        Me.txtcat.Items.AddRange(New Object() {"Corn", "Rice"})
        Me.txtcat.Location = New System.Drawing.Point(12, 99)
        Me.txtcat.Name = "txtcat"
        Me.txtcat.Size = New System.Drawing.Size(155, 21)
        Me.txtcat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Category :"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(219, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 49)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_additem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(344, 236)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcat)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_additem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Item"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnsave As System.Windows.Forms.Button
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
