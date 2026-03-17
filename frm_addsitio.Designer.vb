<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addsitio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addsitio))
        Me.bttnsave = New System.Windows.Forms.Button
        Me.txtbrgycode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtsitname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtprov = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmun = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtsitcode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.bttnsave.Location = New System.Drawing.Point(142, 179)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(113, 41)
        Me.bttnsave.TabIndex = 24
        Me.bttnsave.Text = "Save"
        Me.bttnsave.UseVisualStyleBackColor = False
        '
        'txtbrgycode
        '
        Me.txtbrgycode.Enabled = False
        Me.txtbrgycode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrgycode.Location = New System.Drawing.Point(115, 73)
        Me.txtbrgycode.Name = "txtbrgycode"
        Me.txtbrgycode.Size = New System.Drawing.Size(215, 24)
        Me.txtbrgycode.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Barangay Code :"
        '
        'txtsitname
        '
        Me.txtsitname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsitname.Location = New System.Drawing.Point(115, 121)
        Me.txtsitname.Name = "txtsitname"
        Me.txtsitname.Size = New System.Drawing.Size(215, 24)
        Me.txtsitname.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Sitio Code :"
        '
        'txtprov
        '
        Me.txtprov.Enabled = False
        Me.txtprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprov.Location = New System.Drawing.Point(115, 24)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(215, 24)
        Me.txtprov.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Province :"
        '
        'txtmun
        '
        Me.txtmun.Enabled = False
        Me.txtmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmun.Location = New System.Drawing.Point(115, 49)
        Me.txtmun.Name = "txtmun"
        Me.txtmun.Size = New System.Drawing.Size(215, 24)
        Me.txtmun.TabIndex = 201
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Municipal :"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.BackColor = System.Drawing.Color.Ivory
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(252, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 41)
        Me.Button3.TabIndex = 205
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtsitcode
        '
        Me.txtsitcode.Enabled = False
        Me.txtsitcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsitcode.Location = New System.Drawing.Point(115, 97)
        Me.txtsitcode.Name = "txtsitcode"
        Me.txtsitcode.Size = New System.Drawing.Size(215, 24)
        Me.txtsitcode.TabIndex = 206
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Sitio Name :"
        '
        'frm_addsitio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(385, 232)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsitcode)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtprov)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.txtmun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsitname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbrgycode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_addsitio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Sitio"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnsave As System.Windows.Forms.Button
    Friend WithEvents txtbrgycode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsitname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtprov As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmun As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtsitcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
