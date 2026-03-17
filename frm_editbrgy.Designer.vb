<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editbrgy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editbrgy))
        Me.bttnsave = New System.Windows.Forms.Button
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbrgyname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnprov = New System.Windows.Forms.Panel
        Me.lstprov = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtprov = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.pnmun = New System.Windows.Forms.Panel
        Me.lstmun = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.txtmun = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.pnprov.SuspendLayout()
        Me.pnmun.SuspendLayout()
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
        'txtcode
        '
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(78, 104)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(155, 24)
        Me.txtcode.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Barangay Code :"
        '
        'txtbrgyname
        '
        Me.txtbrgyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrgyname.Location = New System.Drawing.Point(78, 148)
        Me.txtbrgyname.Name = "txtbrgyname"
        Me.txtbrgyname.Size = New System.Drawing.Size(284, 24)
        Me.txtbrgyname.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Barangay Name :"
        '
        'pnprov
        '
        Me.pnprov.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnprov.Controls.Add(Me.lstprov)
        Me.pnprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnprov.Location = New System.Drawing.Point(15, 48)
        Me.pnprov.Name = "pnprov"
        Me.pnprov.Size = New System.Drawing.Size(347, 25)
        Me.pnprov.TabIndex = 199
        Me.pnprov.Visible = False
        '
        'lstprov
        '
        Me.lstprov.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstprov.FullRowSelect = True
        Me.lstprov.GridLines = True
        Me.lstprov.Location = New System.Drawing.Point(-1, -1)
        Me.lstprov.Name = "lstprov"
        Me.lstprov.Size = New System.Drawing.Size(347, 97)
        Me.lstprov.TabIndex = 3
        Me.lstprov.UseCompatibleStateImageBehavior = False
        Me.lstprov.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Province Code"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Province Name"
        Me.ColumnHeader2.Width = 249
        '
        'txtprov
        '
        Me.txtprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprov.Location = New System.Drawing.Point(78, 24)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(252, 24)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(329, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 24)
        Me.Button1.TabIndex = 200
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnmun
        '
        Me.pnmun.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnmun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnmun.Controls.Add(Me.lstmun)
        Me.pnmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnmun.Location = New System.Drawing.Point(15, 73)
        Me.pnmun.Name = "pnmun"
        Me.pnmun.Size = New System.Drawing.Size(347, 25)
        Me.pnmun.TabIndex = 203
        Me.pnmun.Visible = False
        '
        'lstmun
        '
        Me.lstmun.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstmun.FullRowSelect = True
        Me.lstmun.GridLines = True
        Me.lstmun.Location = New System.Drawing.Point(-1, -1)
        Me.lstmun.Name = "lstmun"
        Me.lstmun.Size = New System.Drawing.Size(347, 97)
        Me.lstmun.TabIndex = 3
        Me.lstmun.UseCompatibleStateImageBehavior = False
        Me.lstmun.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Municipal Code"
        Me.ColumnHeader3.Width = 84
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Municipal Name"
        Me.ColumnHeader4.Width = 249
        '
        'txtmun
        '
        Me.txtmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmun.Location = New System.Drawing.Point(78, 49)
        Me.txtmun.Name = "txtmun"
        Me.txtmun.Size = New System.Drawing.Size(252, 24)
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(329, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 24)
        Me.Button2.TabIndex = 204
        Me.Button2.UseVisualStyleBackColor = False
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
        'frm_editbrgy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(385, 232)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.pnmun)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnprov)
        Me.Controls.Add(Me.txtprov)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.txtmun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtbrgyname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_editbrgy"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Barangay"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnprov.ResumeLayout(False)
        Me.pnmun.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnsave As System.Windows.Forms.Button
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbrgyname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnprov As System.Windows.Forms.Panel
    Friend WithEvents lstprov As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtprov As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnmun As System.Windows.Forms.Panel
    Friend WithEvents lstmun As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtmun As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
