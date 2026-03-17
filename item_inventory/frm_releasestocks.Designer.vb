<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_releasestocks
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.dttrn = New System.Windows.Forms.DateTimePicker()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrel_to = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgrd_deduction = New Telerik.WinControls.UI.RadGridView()
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.ttlstocks = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ttlamnt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgrd_deduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Location = New System.Drawing.Point(-2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(838, 10)
        Me.Panel2.TabIndex = 198
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(14, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Transaction Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(133, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 15)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Reference No :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.ForeColor = System.Drawing.Color.Red
        Me.txtref.Location = New System.Drawing.Point(136, 32)
        Me.txtref.MaxLength = 100
        Me.txtref.Name = "txtref"
        Me.txtref.ReadOnly = True
        Me.txtref.Size = New System.Drawing.Size(233, 24)
        Me.txtref.TabIndex = 195
        '
        'dttrn
        '
        Me.dttrn.Enabled = False
        Me.dttrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttrn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttrn.Location = New System.Drawing.Point(17, 32)
        Me.dttrn.Name = "dttrn"
        Me.dttrn.Size = New System.Drawing.Size(113, 24)
        Me.dttrn.TabIndex = 196
        Me.dttrn.Value = New Date(2015, 2, 15, 0, 0, 0, 0)
        '
        'txt_remarks
        '
        Me.txt_remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(251, 85)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(573, 24)
        Me.txt_remarks.TabIndex = 202
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(248, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Remarks :"
        '
        'txtrel_to
        '
        Me.txtrel_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrel_to.Location = New System.Drawing.Point(12, 85)
        Me.txtrel_to.Name = "txtrel_to"
        Me.txtrel_to.Size = New System.Drawing.Size(233, 24)
        Me.txtrel_to.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Release To :"
        '
        'dtgrd_deduction
        '
        Me.dtgrd_deduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrd_deduction.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextCell
        Me.dtgrd_deduction.Location = New System.Drawing.Point(13, 119)
        Me.dtgrd_deduction.Name = "dtgrd_deduction"
        Me.dtgrd_deduction.Size = New System.Drawing.Size(810, 304)
        Me.dtgrd_deduction.TabIndex = 205
        Me.dtgrd_deduction.Text = "RadGridView1"
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.Location = New System.Drawing.Point(740, 438)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(83, 35)
        Me.bttnnew.TabIndex = 207
        Me.bttnnew.Text = "Close"
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.Location = New System.Drawing.Point(648, 438)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(86, 35)
        Me.bttnsave.TabIndex = 206
        Me.bttnsave.Text = "Save"
        '
        'ttlstocks
        '
        Me.ttlstocks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ttlstocks.AutoSize = True
        Me.ttlstocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlstocks.Location = New System.Drawing.Point(14, 438)
        Me.ttlstocks.Name = "ttlstocks"
        Me.ttlstocks.Size = New System.Drawing.Size(15, 16)
        Me.ttlstocks.TabIndex = 208
        Me.ttlstocks.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Total Stocks"
        '
        'ttlamnt
        '
        Me.ttlamnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ttlamnt.AutoSize = True
        Me.ttlamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlamnt.Location = New System.Drawing.Point(146, 438)
        Me.ttlamnt.Name = "ttlamnt"
        Me.ttlamnt.Size = New System.Drawing.Size(32, 16)
        Me.ttlamnt.TabIndex = 210
        Me.ttlamnt.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(144, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "Total Amount"
        '
        'cbotype
        '
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Cash", "Allowances"})
        Me.cbotype.Location = New System.Drawing.Point(375, 32)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(121, 23)
        Me.cbotype.TabIndex = 212
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(375, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Release Type :"
        '
        'frm_releasestocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(836, 485)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbotype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ttlamnt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ttlstocks)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.dtgrd_deduction)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrel_to)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.dttrn)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(531, 434)
        Me.Name = "frm_releasestocks"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Release Stocks"
        CType(Me.dtgrd_deduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents dttrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtrel_to As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgrd_deduction As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents ttlstocks As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ttlamnt As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
