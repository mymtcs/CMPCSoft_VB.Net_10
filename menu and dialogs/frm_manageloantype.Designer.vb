<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manageloantype
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
        Me.dtgrid_deductions = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsavings = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcbu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtgrptype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmarkup = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtis_pension = New System.Windows.Forms.ComboBox()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.pnrate = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtno_ofcycle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtrate_per_t = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtp3 = New System.Windows.Forms.ComboBox()
        CType(Me.dtgrid_deductions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnrate.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgrid_deductions
        '
        Me.dtgrid_deductions.AllowUserToAddRows = False
        Me.dtgrid_deductions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrid_deductions.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgrid_deductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_deductions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dtgrid_deductions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrid_deductions.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgrid_deductions.Location = New System.Drawing.Point(0, 192)
        Me.dtgrid_deductions.Name = "dtgrid_deductions"
        Me.dtgrid_deductions.ReadOnly = True
        Me.dtgrid_deductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_deductions.Size = New System.Drawing.Size(985, 271)
        Me.dtgrid_deductions.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Rate"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.HeaderText = "Savings Percent"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "CF"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "CBU"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.HeaderText = "Penalty Rate"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "GL Loans"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Group Type"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Markup Type"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Is Pension"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Is P3"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code"
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(16, 29)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(123, 20)
        Me.txtcode.TabIndex = 3
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(145, 29)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(301, 20)
        Me.txtdescription.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(469, 29)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.ReadOnly = True
        Me.txtrate.Size = New System.Drawing.Size(105, 20)
        Me.txtrate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rate"
        '
        'txtsavings
        '
        Me.txtsavings.Location = New System.Drawing.Point(592, 29)
        Me.txtsavings.Name = "txtsavings"
        Me.txtsavings.Size = New System.Drawing.Size(105, 20)
        Me.txtsavings.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(589, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Savings %"
        '
        'txtcf
        '
        Me.txtcf.Location = New System.Drawing.Point(710, 29)
        Me.txtcf.Name = "txtcf"
        Me.txtcf.Size = New System.Drawing.Size(76, 20)
        Me.txtcf.TabIndex = 11
        Me.txtcf.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(707, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CF"
        '
        'txtcbu
        '
        Me.txtcbu.Location = New System.Drawing.Point(799, 29)
        Me.txtcbu.Name = "txtcbu"
        Me.txtcbu.Size = New System.Drawing.Size(76, 20)
        Me.txtcbu.TabIndex = 13
        Me.txtcbu.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(796, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CBU"
        '
        'txtpen
        '
        Me.txtpen.Location = New System.Drawing.Point(888, 29)
        Me.txtpen.Name = "txtpen"
        Me.txtpen.Size = New System.Drawing.Size(76, 20)
        Me.txtpen.TabIndex = 15
        Me.txtpen.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(885, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Penalty Rate"
        '
        'txtloantype
        '
        '
        'txtloantype.NestedRadGridView
        '
        Me.txtloantype.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtloantype.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloantype.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtloantype.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtloantype.NestedRadGridView
        '
        Me.txtloantype.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtloantype.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtloantype.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtloantype.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtloantype.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtloantype.EditorControl.Name = "NestedRadGridView"
        Me.txtloantype.EditorControl.ReadOnly = True
        Me.txtloantype.EditorControl.ShowGroupPanel = False
        Me.txtloantype.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtloantype.EditorControl.TabIndex = 0
        Me.txtloantype.Location = New System.Drawing.Point(16, 90)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(286, 22)
        Me.txtloantype.TabIndex = 16
        Me.txtloantype.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Loan Type"
        '
        'txtgrptype
        '
        Me.txtgrptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtgrptype.FormattingEnabled = True
        Me.txtgrptype.Items.AddRange(New Object() {"Y", "N"})
        Me.txtgrptype.Location = New System.Drawing.Point(592, 94)
        Me.txtgrptype.Name = "txtgrptype"
        Me.txtgrptype.Size = New System.Drawing.Size(80, 21)
        Me.txtgrptype.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(589, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Group Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(679, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Multi Product"
        '
        'txtmarkup
        '
        Me.txtmarkup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmarkup.FormattingEnabled = True
        Me.txtmarkup.Items.AddRange(New Object() {"Y", "N"})
        Me.txtmarkup.Location = New System.Drawing.Point(682, 94)
        Me.txtmarkup.Name = "txtmarkup"
        Me.txtmarkup.Size = New System.Drawing.Size(80, 21)
        Me.txtmarkup.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(769, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Is Pension"
        '
        'txtis_pension
        '
        Me.txtis_pension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtis_pension.FormattingEnabled = True
        Me.txtis_pension.Items.AddRange(New Object() {"Y", "N"})
        Me.txtis_pension.Location = New System.Drawing.Point(772, 94)
        Me.txtis_pension.Name = "txtis_pension"
        Me.txtis_pension.Size = New System.Drawing.Size(80, 21)
        Me.txtis_pension.TabIndex = 22
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.Location = New System.Drawing.Point(16, 147)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(89, 30)
        Me.bttnsave.TabIndex = 24
        Me.bttnsave.Text = "Save"
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.Location = New System.Drawing.Point(115, 147)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(89, 30)
        Me.bttnnew.TabIndex = 25
        Me.bttnnew.Text = "New"
        '
        'pnrate
        '
        Me.pnrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnrate.Controls.Add(Me.Button1)
        Me.pnrate.Controls.Add(Me.txtno_ofcycle)
        Me.pnrate.Controls.Add(Me.Label13)
        Me.pnrate.Controls.Add(Me.txtrate_per_t)
        Me.pnrate.Controls.Add(Me.Label12)
        Me.pnrate.Location = New System.Drawing.Point(380, 49)
        Me.pnrate.Name = "pnrate"
        Me.pnrate.Size = New System.Drawing.Size(194, 74)
        Me.pnrate.TabIndex = 26
        Me.pnrate.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(121, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 21)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = ">>>"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtno_ofcycle
        '
        Me.txtno_ofcycle.Location = New System.Drawing.Point(121, 25)
        Me.txtno_ofcycle.Name = "txtno_ofcycle"
        Me.txtno_ofcycle.Size = New System.Drawing.Size(61, 20)
        Me.txtno_ofcycle.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(117, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "No. of Cycle"
        '
        'txtrate_per_t
        '
        Me.txtrate_per_t.Location = New System.Drawing.Point(10, 25)
        Me.txtrate_per_t.Name = "txtrate_per_t"
        Me.txtrate_per_t.Size = New System.Drawing.Size(105, 20)
        Me.txtrate_per_t.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Rate per Term"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(859, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "P3 Program"
        '
        'txtp3
        '
        Me.txtp3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtp3.FormattingEnabled = True
        Me.txtp3.Items.AddRange(New Object() {"Y", "N"})
        Me.txtp3.Location = New System.Drawing.Point(862, 94)
        Me.txtp3.Name = "txtp3"
        Me.txtp3.Size = New System.Drawing.Size(80, 21)
        Me.txtp3.TabIndex = 27
        '
        'frm_manageloantype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(985, 463)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtp3)
        Me.Controls.Add(Me.pnrate)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtis_pension)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmarkup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtgrptype)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.txtpen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcbu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsavings)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgrid_deductions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_manageloantype"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Loan Type"
        CType(Me.dtgrid_deductions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnrate.ResumeLayout(False)
        Me.pnrate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents dtgrid_deductions As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsavings As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcf As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcbu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpen As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtgrptype As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmarkup As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtis_pension As System.Windows.Forms.ComboBox
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents pnrate As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtno_ofcycle As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtrate_per_t As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtp3 As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
