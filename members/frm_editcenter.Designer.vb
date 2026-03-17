<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editcenter
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
        Me.txtctrname = New System.Windows.Forms.TextBox
        Me.txtctrcheif = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtctrcode = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcol_day_no = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtacctnumber = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtctrname
        '
        Me.txtctrname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtctrname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtctrname.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtctrname.Location = New System.Drawing.Point(112, 69)
        Me.txtctrname.MaxLength = 30
        Me.txtctrname.Name = "txtctrname"
        Me.txtctrname.Size = New System.Drawing.Size(272, 25)
        Me.txtctrname.TabIndex = 2
        '
        'txtctrcheif
        '
        Me.txtctrcheif.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtctrcheif.Location = New System.Drawing.Point(112, 44)
        Me.txtctrcheif.MaxLength = 30
        Me.txtctrcheif.Name = "txtctrcheif"
        Me.txtctrcheif.Size = New System.Drawing.Size(272, 25)
        Me.txtctrcheif.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Center Cheif :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Center Name :"
        '
        'txtctrcode
        '
        Me.txtctrcode.BackColor = System.Drawing.Color.White
        Me.txtctrcode.Enabled = False
        Me.txtctrcode.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtctrcode.Location = New System.Drawing.Point(112, 19)
        Me.txtctrcode.MaxLength = 30
        Me.txtctrcode.Name = "txtctrcode"
        Me.txtctrcode.Size = New System.Drawing.Size(67, 25)
        Me.txtctrcode.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(46, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Ctr Code :"
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(188, 191)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(95, 37)
        Me.bttnsave.TabIndex = 5
        Me.bttnsave.Text = "Save"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(289, 191)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(95, 37)
        Me.RadButton2.TabIndex = 6
        Me.RadButton2.Text = "Close"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Coll Day No."
        '
        'txtcol_day_no
        '
        Me.txtcol_day_no.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcol_day_no.Location = New System.Drawing.Point(112, 121)
        Me.txtcol_day_no.MaxLength = 30
        Me.txtcol_day_no.Name = "txtcol_day_no"
        Me.txtcol_day_no.Size = New System.Drawing.Size(107, 25)
        Me.txtcol_day_no.TabIndex = 4
        Me.txtcol_day_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Address :"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(112, 95)
        Me.txtaddress.MaxLength = 30
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(272, 25)
        Me.txtaddress.TabIndex = 41
        '
        'txtacctnumber
        '
        Me.txtacctnumber.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacctnumber.Location = New System.Drawing.Point(112, 146)
        Me.txtacctnumber.MaxLength = 30
        Me.txtacctnumber.Name = "txtacctnumber"
        Me.txtacctnumber.Size = New System.Drawing.Size(272, 25)
        Me.txtacctnumber.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Account No :"
        '
        'frm_editcenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(412, 240)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtacctnumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcol_day_no)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtctrcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtctrcheif)
        Me.Controls.Add(Me.txtctrname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_editcenter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Center"
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtctrname As System.Windows.Forms.TextBox
    Friend WithEvents txtctrcheif As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtctrcode As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcol_day_no As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtacctnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
