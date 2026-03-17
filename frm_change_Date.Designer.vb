<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_change_Date
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
        Me.bttnsubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtchange = New System.Windows.Forms.DateTimePicker()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnsubmit
        '
        Me.bttnsubmit.Location = New System.Drawing.Point(343, 88)
        Me.bttnsubmit.Name = "bttnsubmit"
        Me.bttnsubmit.Size = New System.Drawing.Size(86, 34)
        Me.bttnsubmit.TabIndex = 0
        Me.bttnsubmit.Text = "Submit"
        Me.bttnsubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Date"
        '
        'dtchange
        '
        Me.dtchange.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtchange.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtchange.Location = New System.Drawing.Point(12, 49)
        Me.dtchange.Name = "dtchange"
        Me.dtchange.Size = New System.Drawing.Size(150, 31)
        Me.dtchange.TabIndex = 2
        Me.dtchange.Value = New Date(2019, 6, 5, 0, 0, 0, 0)
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(168, 49)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(261, 31)
        Me.txtpass.TabIndex = 3
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(165, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_change_Date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.dtchange)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnsubmit)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_change_Date"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change System Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtchange As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
