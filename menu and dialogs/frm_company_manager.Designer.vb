<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_company_manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_company_manager))
        Me.txtpsupervisor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbookkeeper = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtareamanager = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcashier = New System.Windows.Forms.TextBox
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.txtglloans = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtglsavings = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.txtglinterest = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtglcf = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglloans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglloans.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglloans.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglsavings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglsavings.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglsavings.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglinterest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglinterest.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglinterest.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglcf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglcf.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglcf.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpsupervisor
        '
        Me.txtpsupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpsupervisor.Location = New System.Drawing.Point(15, 138)
        Me.txtpsupervisor.Name = "txtpsupervisor"
        Me.txtpsupervisor.Size = New System.Drawing.Size(222, 22)
        Me.txtpsupervisor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Supervisor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bookkeeper"
        '
        'txtbookkeeper
        '
        Me.txtbookkeeper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookkeeper.Location = New System.Drawing.Point(15, 238)
        Me.txtbookkeeper.Name = "txtbookkeeper"
        Me.txtbookkeeper.Size = New System.Drawing.Size(222, 22)
        Me.txtbookkeeper.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Area Manager"
        '
        'txtareamanager
        '
        Me.txtareamanager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtareamanager.Location = New System.Drawing.Point(15, 86)
        Me.txtareamanager.Name = "txtareamanager"
        Me.txtareamanager.Size = New System.Drawing.Size(222, 22)
        Me.txtareamanager.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Cashier"
        '
        'txtcashier
        '
        Me.txtcashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcashier.Location = New System.Drawing.Point(15, 187)
        Me.txtcashier.Name = "txtcashier"
        Me.txtcashier.Size = New System.Drawing.Size(222, 22)
        Me.txtcashier.TabIndex = 26
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.Location = New System.Drawing.Point(158, 433)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(75, 35)
        Me.bttnsave.TabIndex = 203
        Me.bttnsave.Text = "Save"
        '
        'txtglloans
        '
        '
        'txtglloans.NestedRadGridView
        '
        Me.txtglloans.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtglloans.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglloans.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtglloans.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtglloans.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtglloans.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtglloans.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtglloans.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtglloans.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtglloans.EditorControl.Name = "NestedRadGridView"
        Me.txtglloans.EditorControl.ReadOnly = True
        Me.txtglloans.EditorControl.ShowGroupPanel = False
        Me.txtglloans.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtglloans.EditorControl.TabIndex = 0
        Me.txtglloans.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglloans.Location = New System.Drawing.Point(15, 30)
        Me.txtglloans.Name = "txtglloans"
        Me.txtglloans.Size = New System.Drawing.Size(219, 25)
        Me.txtglloans.TabIndex = 205
        Me.txtglloans.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "Loan Type :"
        '
        'txtglsavings
        '
        '
        'txtglsavings.NestedRadGridView
        '
        Me.txtglsavings.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtglsavings.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglsavings.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtglsavings.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtglsavings.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtglsavings.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtglsavings.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtglsavings.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtglsavings.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtglsavings.EditorControl.Name = "NestedRadGridView"
        Me.txtglsavings.EditorControl.ReadOnly = True
        Me.txtglsavings.EditorControl.ShowGroupPanel = False
        Me.txtglsavings.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtglsavings.EditorControl.TabIndex = 0
        Me.txtglsavings.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglsavings.Location = New System.Drawing.Point(14, 286)
        Me.txtglsavings.Name = "txtglsavings"
        Me.txtglsavings.Size = New System.Drawing.Size(219, 26)
        Me.txtglsavings.TabIndex = 207
        Me.txtglsavings.TabStop = False
        '
        'txtglinterest
        '
        '
        'txtglinterest.NestedRadGridView
        '
        Me.txtglinterest.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtglinterest.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglinterest.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtglinterest.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtglinterest.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtglinterest.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtglinterest.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtglinterest.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtglinterest.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtglinterest.EditorControl.Name = "NestedRadGridView"
        Me.txtglinterest.EditorControl.ReadOnly = True
        Me.txtglinterest.EditorControl.ShowGroupPanel = False
        Me.txtglinterest.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtglinterest.EditorControl.TabIndex = 0
        Me.txtglinterest.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglinterest.Location = New System.Drawing.Point(17, 337)
        Me.txtglinterest.Name = "txtglinterest"
        Me.txtglinterest.Size = New System.Drawing.Size(216, 25)
        Me.txtglinterest.TabIndex = 208
        Me.txtglinterest.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "GL savings"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "GL Interest"
        '
        'txtglcf
        '
        '
        'txtglcf.NestedRadGridView
        '
        Me.txtglcf.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtglcf.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglcf.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtglcf.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtglcf.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtglcf.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtglcf.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtglcf.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtglcf.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtglcf.EditorControl.Name = "NestedRadGridView"
        Me.txtglcf.EditorControl.ReadOnly = True
        Me.txtglcf.EditorControl.ShowGroupPanel = False
        Me.txtglcf.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtglcf.EditorControl.TabIndex = 0
        Me.txtglcf.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglcf.Location = New System.Drawing.Point(17, 385)
        Me.txtglcf.Name = "txtglcf"
        Me.txtglcf.Size = New System.Drawing.Size(216, 25)
        Me.txtglcf.TabIndex = 211
        Me.txtglcf.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(14, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 212
        Me.Label9.Text = "GL center fund"
        '
        'frm_company_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(245, 480)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtglcf)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtglinterest)
        Me.Controls.Add(Me.txtglsavings)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtglloans)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcashier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtareamanager)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbookkeeper)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpsupervisor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_company_manager"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Names"
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglloans.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglloans.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglloans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglsavings.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglsavings.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglsavings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglinterest.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglinterest.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglinterest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglcf.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglcf.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglcf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpsupervisor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbookkeeper As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtareamanager As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcashier As System.Windows.Forms.TextBox
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtglloans As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtglsavings As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtglinterest As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtglcf As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
