<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_masterlist_loans
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_masterlist_loans))
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cntxtmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewProductAssistantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.gendate = New System.Windows.Forms.DateTimePicker()
        Me.txtcoll = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadMultiColumnComboBox1 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtsubproduct = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bttnhide = New System.Windows.Forms.Button()
        Me.pndialog = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.cntxtmenu.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pndialog.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Full Name"
        Me.ColumnHeader22.Width = 287
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Interest"
        Me.ColumnHeader25.Width = 125
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Due Date"
        Me.ColumnHeader23.Width = 234
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Amounts Recievable"
        Me.ColumnHeader24.Width = 155
        '
        'cntxtmenu
        '
        Me.cntxtmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProductAssistantToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.cntxtmenu.Name = "cntxtmenu"
        Me.cntxtmenu.Size = New System.Drawing.Size(191, 48)
        '
        'ViewProductAssistantToolStripMenuItem
        '
        Me.ViewProductAssistantToolStripMenuItem.Name = "ViewProductAssistantToolStripMenuItem"
        Me.ViewProductAssistantToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewProductAssistantToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ViewProductAssistantToolStripMenuItem.Text = "Export To excel"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "PnNumber"
        Me.ColumnHeader21.Width = 87
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRviewer.Location = New System.Drawing.Point(0, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(1237, 622)
        Me.CRviewer.TabIndex = 12
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'gendate
        '
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(29, 40)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(153, 21)
        Me.gendate.TabIndex = 13
        Me.gendate.Value = New Date(2015, 3, 15, 0, 0, 0, 0)
        '
        'txtcoll
        '
        '
        'txtcoll.NestedRadGridView
        '
        Me.txtcoll.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtcoll.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoll.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcoll.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtcoll.NestedRadGridView
        '
        Me.txtcoll.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtcoll.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtcoll.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtcoll.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtcoll.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtcoll.EditorControl.Name = "NestedRadGridView"
        Me.txtcoll.EditorControl.ReadOnly = True
        Me.txtcoll.EditorControl.ShowGroupPanel = False
        Me.txtcoll.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtcoll.EditorControl.TabIndex = 0
        Me.txtcoll.Location = New System.Drawing.Point(32, 197)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(213, 24)
        Me.txtcoll.TabIndex = 15
        Me.txtcoll.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(29, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Coll. Officer :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(29, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "As of :"
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(159, 287)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(86, 31)
        Me.bttngenerate.TabIndex = 18
        Me.bttngenerate.Text = "Generate"
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
        Me.txtloantype.Location = New System.Drawing.Point(32, 142)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(213, 24)
        Me.txtloantype.TabIndex = 19
        Me.txtloantype.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(29, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Loan Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(512, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Coll. Officer :"
        '
        'RadMultiColumnComboBox1
        '
        '
        'RadMultiColumnComboBox1.NestedRadGridView
        '
        Me.RadMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.RadMultiColumnComboBox1.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadMultiColumnComboBox1.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.RadMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
        Me.RadMultiColumnComboBox1.EditorControl.ReadOnly = True
        Me.RadMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
        Me.RadMultiColumnComboBox1.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.RadMultiColumnComboBox1.EditorControl.TabIndex = 0
        Me.RadMultiColumnComboBox1.Location = New System.Drawing.Point(515, 383)
        Me.RadMultiColumnComboBox1.Name = "RadMultiColumnComboBox1"
        Me.RadMultiColumnComboBox1.Size = New System.Drawing.Size(213, 24)
        Me.RadMultiColumnComboBox1.TabIndex = 22
        Me.RadMultiColumnComboBox1.TabStop = False
        '
        'txtsubproduct
        '
        '
        'txtsubproduct.NestedRadGridView
        '
        Me.txtsubproduct.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtsubproduct.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubproduct.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsubproduct.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtsubproduct.NestedRadGridView
        '
        Me.txtsubproduct.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtsubproduct.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtsubproduct.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtsubproduct.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtsubproduct.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtsubproduct.EditorControl.Name = "NestedRadGridView"
        Me.txtsubproduct.EditorControl.ReadOnly = True
        Me.txtsubproduct.EditorControl.ShowGroupPanel = False
        Me.txtsubproduct.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtsubproduct.EditorControl.TabIndex = 0
        Me.txtsubproduct.Location = New System.Drawing.Point(32, 251)
        Me.txtsubproduct.Name = "txtsubproduct"
        Me.txtsubproduct.Size = New System.Drawing.Size(213, 23)
        Me.txtsubproduct.TabIndex = 21
        Me.txtsubproduct.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(29, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sub Product :"
        '
        'bttnhide
        '
        Me.bttnhide.BackgroundImage = CType(resources.GetObject("bttnhide.BackgroundImage"), System.Drawing.Image)
        Me.bttnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnhide.Location = New System.Drawing.Point(491, 0)
        Me.bttnhide.Name = "bttnhide"
        Me.bttnhide.Size = New System.Drawing.Size(32, 26)
        Me.bttnhide.TabIndex = 23
        Me.bttnhide.UseVisualStyleBackColor = True
        '
        'pndialog
        '
        Me.pndialog.BackColor = System.Drawing.Color.AliceBlue
        Me.pndialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pndialog.Controls.Add(Me.Label6)
        Me.pndialog.Controls.Add(Me.cbotype)
        Me.pndialog.Controls.Add(Me.Label2)
        Me.pndialog.Controls.Add(Me.gendate)
        Me.pndialog.Controls.Add(Me.txtcoll)
        Me.pndialog.Controls.Add(Me.Label5)
        Me.pndialog.Controls.Add(Me.Label1)
        Me.pndialog.Controls.Add(Me.txtsubproduct)
        Me.pndialog.Controls.Add(Me.bttngenerate)
        Me.pndialog.Controls.Add(Me.Label3)
        Me.pndialog.Controls.Add(Me.txtloantype)
        Me.pndialog.Location = New System.Drawing.Point(491, 25)
        Me.pndialog.Name = "pndialog"
        Me.pndialog.Size = New System.Drawing.Size(288, 340)
        Me.pndialog.TabIndex = 24
        Me.pndialog.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(26, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Type :"
        '
        'cbotype
        '
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Normal Loan", "Restructured Loan"})
        Me.cbotype.Location = New System.Drawing.Point(29, 89)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(216, 23)
        Me.cbotype.TabIndex = 41
        '
        'frm_masterlist_loans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1237, 622)
        Me.Controls.Add(Me.pndialog)
        Me.Controls.Add(Me.bttnhide)
        Me.Controls.Add(Me.CRviewer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_masterlist_loans"
        Me.ShowIcon = False
        Me.Text = "(ACTIVE) Members Master List"
        Me.cntxtmenu.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pndialog.ResumeLayout(False)
        Me.pndialog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cntxtmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewProductAssistantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents gendate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcoll As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadMultiColumnComboBox1 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsubproduct As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents pndialog As System.Windows.Forms.Panel
    Friend WithEvents bttnhide As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
End Class
