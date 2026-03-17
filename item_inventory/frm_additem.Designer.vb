<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_additem
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
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtdesc.Location = New System.Drawing.Point(12, 99)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(318, 24)
        Me.txtdesc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Item Decription :"
        '
        'txtcat
        '
        Me.txtcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcat.FormattingEnabled = True
        Me.txtcat.Items.AddRange(New Object() {"Corn", "Rice", "Dishwashing", "Fabcon", "Other Items"})
        Me.txtcat.Location = New System.Drawing.Point(175, 48)
        Me.txtcat.Name = "txtcat"
        Me.txtcat.Size = New System.Drawing.Size(155, 24)
        Me.txtcat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Category :"
        '
        'bttnsave
        '
        Me.bttnsave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnsave.Location = New System.Drawing.Point(136, 141)
        Me.bttnsave.Name = "bttnsave"
        '
        '
        '
        Me.bttnsave.RootElement.AccessibleDescription = Nothing
        Me.bttnsave.RootElement.AccessibleName = Nothing
        Me.bttnsave.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.bttnsave.Size = New System.Drawing.Size(94, 35)
        Me.bttnsave.TabIndex = 32
        Me.bttnsave.Text = "Save"
        '
        'RadButton2
        '
        Me.RadButton2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton2.Location = New System.Drawing.Point(236, 141)
        Me.RadButton2.Name = "RadButton2"
        '
        '
        '
        Me.RadButton2.RootElement.AccessibleDescription = Nothing
        Me.RadButton2.RootElement.AccessibleName = Nothing
        Me.RadButton2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.RadButton2.Size = New System.Drawing.Size(94, 35)
        Me.RadButton2.TabIndex = 33
        Me.RadButton2.Text = "Close"
        '
        'frm_additem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(346, 188)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcat)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_additem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Item"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Private WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class
