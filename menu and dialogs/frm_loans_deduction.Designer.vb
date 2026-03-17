<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loans_deduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loans_deduction))
        Me.dtgrid_deductions = New System.Windows.Forms.DataGridView()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttnnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttnsave = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfxamount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpercentage = New System.Windows.Forms.TextBox()
        Me.txtvisible = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmbase = New System.Windows.Forms.ComboBox()
        Me.txtacro = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtgl = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgrid_deductions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtacro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrid_deductions
        '
        Me.dtgrid_deductions.AllowUserToAddRows = False
        Me.dtgrid_deductions.AllowUserToDeleteRows = False
        Me.dtgrid_deductions.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgrid_deductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_deductions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5, Me.Column8, Me.Column7})
        Me.dtgrid_deductions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrid_deductions.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgrid_deductions.Location = New System.Drawing.Point(0, 163)
        Me.dtgrid_deductions.Name = "dtgrid_deductions"
        Me.dtgrid_deductions.ReadOnly = True
        Me.dtgrid_deductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_deductions.Size = New System.Drawing.Size(928, 255)
        Me.dtgrid_deductions.TabIndex = 1
        '
        'txtcode
        '
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Location = New System.Drawing.Point(15, 59)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Description"
        '
        'txtdesc
        '
        Me.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesc.Location = New System.Drawing.Point(121, 59)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(777, 20)
        Me.txtdesc.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttnnew, Me.ToolStripSeparator1, Me.bttnsave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(928, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttnnew
        '
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(51, 22)
        Me.bttnnew.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bttnsave
        '
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(51, 22)
        Me.bttnsave.Text = "Save"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fixed Amount"
        '
        'txtfxamount
        '
        Me.txtfxamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfxamount.Location = New System.Drawing.Point(15, 121)
        Me.txtfxamount.Name = "txtfxamount"
        Me.txtfxamount.Size = New System.Drawing.Size(100, 20)
        Me.txtfxamount.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Percentage"
        '
        'txtpercentage
        '
        Me.txtpercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpercentage.Location = New System.Drawing.Point(121, 121)
        Me.txtpercentage.Name = "txtpercentage"
        Me.txtpercentage.Size = New System.Drawing.Size(109, 20)
        Me.txtpercentage.TabIndex = 9
        '
        'txtvisible
        '
        Me.txtvisible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtvisible.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtvisible.FormattingEnabled = True
        Me.txtvisible.Items.AddRange(New Object() {"Y", "N"})
        Me.txtvisible.Location = New System.Drawing.Point(238, 121)
        Me.txtvisible.Name = "txtvisible"
        Me.txtvisible.Size = New System.Drawing.Size(101, 21)
        Me.txtvisible.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Visible"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Acro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Monthly Base"
        '
        'txtmbase
        '
        Me.txtmbase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmbase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtmbase.FormattingEnabled = True
        Me.txtmbase.Items.AddRange(New Object() {"Y", "N"})
        Me.txtmbase.Location = New System.Drawing.Point(525, 121)
        Me.txtmbase.Name = "txtmbase"
        Me.txtmbase.Size = New System.Drawing.Size(121, 21)
        Me.txtmbase.TabIndex = 15
        '
        'txtacro
        '
        '
        'txtacro.NestedRadGridView
        '
        Me.txtacro.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtacro.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacro.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtacro.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtacro.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtacro.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtacro.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtacro.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtacro.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtacro.EditorControl.Name = "NestedRadGridView"
        Me.txtacro.EditorControl.ReadOnly = True
        Me.txtacro.EditorControl.ShowGroupPanel = False
        Me.txtacro.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtacro.EditorControl.TabIndex = 0
        Me.txtacro.Location = New System.Drawing.Point(345, 121)
        Me.txtacro.Name = "txtacro"
        Me.txtacro.Size = New System.Drawing.Size(169, 20)
        Me.txtacro.TabIndex = 17
        Me.txtacro.TabStop = False
        '
        'txtgl
        '
        '
        'txtgl.NestedRadGridView
        '
        Me.txtgl.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtgl.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgl.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgl.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtgl.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtgl.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtgl.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtgl.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtgl.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtgl.EditorControl.Name = "NestedRadGridView"
        Me.txtgl.EditorControl.ReadOnly = True
        Me.txtgl.EditorControl.ShowGroupPanel = False
        Me.txtgl.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl.EditorControl.TabIndex = 0
        Me.txtgl.Location = New System.Drawing.Point(653, 121)
        Me.txtgl.Name = "txtgl"
        Me.txtgl.Size = New System.Drawing.Size(245, 20)
        Me.txtgl.TabIndex = 18
        Me.txtgl.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(650, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "GL Account"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 170
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fixed Amount"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.HeaderText = "Percentage"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "Display"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Acro"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Monthly Base"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "GL Account"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'frm_loans_deduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(928, 418)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtgl)
        Me.Controls.Add(Me.txtacro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmbase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtvisible)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpercentage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfxamount)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.dtgrid_deductions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_loans_deduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Loans Deduction"
        CType(Me.dtgrid_deductions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtacro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents dtgrid_deductions As System.Windows.Forms.DataGridView
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfxamount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpercentage As System.Windows.Forms.TextBox
    Friend WithEvents txtvisible As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmbase As System.Windows.Forms.ComboBox
    Friend WithEvents txtacro As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtgl As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
