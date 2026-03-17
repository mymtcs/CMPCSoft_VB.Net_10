<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newsavings_acct
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtmember = New System.Windows.Forms.ComboBox
        Me.txtsaacct = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.txtacct_type = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmemcode = New System.Windows.Forms.TextBox
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        Me.txtsavingstype = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavingstype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavingstype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavingstype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Name :"
        '
        'txtmember
        '
        Me.txtmember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtmember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtmember.BackColor = System.Drawing.Color.White
        Me.txtmember.DropDownHeight = 180
        Me.txtmember.DropDownWidth = 580
        Me.txtmember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtmember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmember.FormattingEnabled = True
        Me.txtmember.IntegralHeight = False
        Me.txtmember.Location = New System.Drawing.Point(111, 26)
        Me.txtmember.Name = "txtmember"
        Me.txtmember.Size = New System.Drawing.Size(238, 23)
        Me.txtmember.TabIndex = 0
        '
        'txtsaacct
        '
        Me.txtsaacct.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtsaacct.Enabled = False
        Me.txtsaacct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaacct.Location = New System.Drawing.Point(110, 91)
        Me.txtsaacct.Name = "txtsaacct"
        Me.txtsaacct.Size = New System.Drawing.Size(238, 24)
        Me.txtsaacct.TabIndex = 2
        Me.txtsaacct.Text = "(Auto Generated)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Account Number :"
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(168, 196)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(87, 35)
        Me.bttnsave.TabIndex = 4
        Me.bttnsave.Text = "Save"
        '
        'txtacct_type
        '
        Me.txtacct_type.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtacct_type.Enabled = False
        Me.txtacct_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct_type.Location = New System.Drawing.Point(110, 121)
        Me.txtacct_type.Name = "txtacct_type"
        Me.txtacct_type.Size = New System.Drawing.Size(106, 24)
        Me.txtacct_type.TabIndex = 3
        Me.txtacct_type.Text = "PS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Account Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "Member Code :"
        '
        'txtmemcode
        '
        Me.txtmemcode.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtmemcode.Enabled = False
        Me.txtmemcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmemcode.Location = New System.Drawing.Point(110, 58)
        Me.txtmemcode.Name = "txtmemcode"
        Me.txtmemcode.Size = New System.Drawing.Size(238, 24)
        Me.txtmemcode.TabIndex = 1
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(261, 196)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(87, 35)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "Close"
        '
        'txtsavingstype
        '
        '
        'txtsavingstype.NestedRadGridView
        '
        Me.txtsavingstype.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtsavingstype.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsavingstype.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsavingstype.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtsavingstype.NestedRadGridView
        '
        Me.txtsavingstype.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtsavingstype.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtsavingstype.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtsavingstype.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtsavingstype.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtsavingstype.EditorControl.Name = "NestedRadGridView"
        Me.txtsavingstype.EditorControl.ReadOnly = True
        Me.txtsavingstype.EditorControl.ShowGroupPanel = False
        Me.txtsavingstype.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtsavingstype.EditorControl.TabIndex = 0
        Me.txtsavingstype.Location = New System.Drawing.Point(110, 151)
        Me.txtsavingstype.Name = "txtsavingstype"
        Me.txtsavingstype.Size = New System.Drawing.Size(238, 26)
        Me.txtsavingstype.TabIndex = 204
        Me.txtsavingstype.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 205
        Me.Label5.Text = "Savings Type :"
        '
        'frm_newsavings_acct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(365, 258)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsavingstype)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmemcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtacct_type)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsaacct)
        Me.Controls.Add(Me.txtmember)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_newsavings_acct"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Account"
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavingstype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavingstype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavingstype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmember As System.Windows.Forms.ComboBox
    Friend WithEvents txtsaacct As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtacct_type As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmemcode As System.Windows.Forms.TextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtsavingstype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
