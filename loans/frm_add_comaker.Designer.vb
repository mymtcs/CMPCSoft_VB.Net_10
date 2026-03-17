<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_comaker
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtgr_benefeciary = New Telerik.WinControls.UI.RadGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtcoaddress = New System.Windows.Forms.TextBox()
        Me.txtcomaker = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbo_collateral = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtcocontact = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgr_benefeciary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtgr_benefeciary)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1115, 276)
        Me.GroupBox3.TabIndex = 198
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Beneficiary"
        '
        'dtgr_benefeciary
        '
        Me.dtgr_benefeciary.Location = New System.Drawing.Point(7, 21)
        Me.dtgr_benefeciary.Name = "dtgr_benefeciary"
        Me.dtgr_benefeciary.Size = New System.Drawing.Size(1102, 249)
        Me.dtgr_benefeciary.TabIndex = 9
        Me.dtgr_benefeciary.Text = "RadGridView1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtcoaddress)
        Me.Panel2.Controls.Add(Me.txtcomaker)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.cbo_collateral)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.txtcocontact)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Location = New System.Drawing.Point(8, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 137)
        Me.Panel2.TabIndex = 197
        '
        'txtcoaddress
        '
        Me.txtcoaddress.Location = New System.Drawing.Point(6, 79)
        Me.txtcoaddress.Name = "txtcoaddress"
        Me.txtcoaddress.Size = New System.Drawing.Size(598, 20)
        Me.txtcoaddress.TabIndex = 35
        '
        'txtcomaker
        '
        Me.txtcomaker.Location = New System.Drawing.Point(6, 33)
        Me.txtcomaker.Name = "txtcomaker"
        Me.txtcomaker.Size = New System.Drawing.Size(278, 20)
        Me.txtcomaker.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label29.Location = New System.Drawing.Point(732, 56)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 15)
        Me.Label29.TabIndex = 197
        Me.Label29.Text = "Collateral Type :"
        '
        'cbo_collateral
        '
        Me.cbo_collateral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_collateral.FormattingEnabled = True
        Me.cbo_collateral.Items.AddRange(New Object() {"None", "ATM", "Post Dated", "Chattel Mortgage", "Real Estate Mortgage"})
        Me.cbo_collateral.Location = New System.Drawing.Point(735, 74)
        Me.cbo_collateral.Name = "cbo_collateral"
        Me.cbo_collateral.Size = New System.Drawing.Size(212, 23)
        Me.cbo_collateral.TabIndex = 196
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(731, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(123, 15)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Co Maker's Contact #"
        '
        'txtcocontact
        '
        Me.txtcocontact.Location = New System.Drawing.Point(735, 31)
        Me.txtcocontact.Name = "txtcocontact"
        Me.txtcocontact.Size = New System.Drawing.Size(212, 20)
        Me.txtcocontact.TabIndex = 37
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label24.Location = New System.Drawing.Point(3, 59)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 15)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Co Maker's Address:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(3, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 15)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Co Maker :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1037, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 199
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(956, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 200
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_add_comaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 513)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_add_comaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Comaker"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtgr_benefeciary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgr_benefeciary As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtcoaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcomaker As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbo_collateral As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtcocontact As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
