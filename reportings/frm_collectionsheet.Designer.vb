<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collectionsheet
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.matdate = New System.Windows.Forms.DateTimePicker()
        Me.checkoption = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_option = New System.Windows.Forms.ComboBox()
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton()
        Me.txtcenter = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.collectionsheet1 = New Gsoft.collectionsheet()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcenter.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcenter.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.matdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.checkoption)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtloantype)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbo_option)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bttngenerate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtcenter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblname)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.crviewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(1279, 573)
        Me.SplitContainer1.SplitterDistance = 224
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'matdate
        '
        Me.matdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.matdate.Location = New System.Drawing.Point(15, 276)
        Me.matdate.Name = "matdate"
        Me.matdate.Size = New System.Drawing.Size(150, 21)
        Me.matdate.TabIndex = 39
        Me.matdate.Value = New Date(2020, 3, 20, 0, 0, 0, 0)
        Me.matdate.Visible = False
        '
        'checkoption
        '
        Me.checkoption.AutoSize = True
        Me.checkoption.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoption.ForeColor = System.Drawing.Color.DodgerBlue
        Me.checkoption.Location = New System.Drawing.Point(15, 6)
        Me.checkoption.Name = "checkoption"
        Me.checkoption.Size = New System.Drawing.Size(124, 18)
        Me.checkoption.TabIndex = 38
        Me.checkoption.Text = "Mini Printer Mode"
        Me.checkoption.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Loan Type :"
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
        Me.txtloantype.Location = New System.Drawing.Point(15, 162)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(191, 24)
        Me.txtloantype.TabIndex = 36
        Me.txtloantype.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Collection by :"
        '
        'cbo_option
        '
        Me.cbo_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_option.FormattingEnabled = True
        Me.cbo_option.Items.AddRange(New Object() {"By Officer", "By Center"})
        Me.cbo_option.Location = New System.Drawing.Point(15, 114)
        Me.cbo_option.Name = "cbo_option"
        Me.cbo_option.Size = New System.Drawing.Size(162, 23)
        Me.cbo_option.TabIndex = 34
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(134, 241)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(72, 29)
        Me.bttngenerate.TabIndex = 33
        Me.bttngenerate.Text = "Generate"
        '
        'txtcenter
        '
        '
        'txtcenter.NestedRadGridView
        '
        Me.txtcenter.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtcenter.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcenter.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcenter.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtcenter.NestedRadGridView
        '
        Me.txtcenter.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtcenter.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtcenter.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtcenter.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtcenter.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtcenter.EditorControl.Name = "NestedRadGridView"
        Me.txtcenter.EditorControl.ReadOnly = True
        Me.txtcenter.EditorControl.ShowGroupPanel = False
        Me.txtcenter.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtcenter.EditorControl.TabIndex = 0
        Me.txtcenter.Location = New System.Drawing.Point(15, 210)
        Me.txtcenter.Name = "txtcenter"
        Me.txtcenter.Size = New System.Drawing.Size(191, 24)
        Me.txtcenter.TabIndex = 32
        Me.txtcenter.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(12, 193)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(43, 15)
        Me.lblname.TabIndex = 31
        Me.lblname.Text = "Center"
        '
        'txtdate
        '
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate.Location = New System.Drawing.Point(15, 63)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(150, 21)
        Me.txtdate.TabIndex = 1
        Me.txtdate.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Collection Date"
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crviewer.Location = New System.Drawing.Point(0, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(1054, 573)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'frm_collectionsheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1279, 573)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_collectionsheet"
        Me.ShowIcon = False
        Me.Text = "Collection Sheet"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcenter.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcenter.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents collectionsheet1 As Gsoft.collectionsheet
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtcenter As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_option As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents checkoption As System.Windows.Forms.CheckBox
    Friend WithEvents matdate As System.Windows.Forms.DateTimePicker
End Class
