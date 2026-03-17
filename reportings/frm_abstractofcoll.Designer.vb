<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abstractofcoll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_abstractofcoll))
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.collectionsheet1 = New Gsoft.collectionsheet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.txtcoll = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton()
        Me.chksummary = New Telerik.WinControls.UI.RadRadioButton()
        Me.chkdetails = New Telerik.WinControls.UI.RadRadioButton()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pndialog = New System.Windows.Forms.Panel()
        Me.bttnhide = New System.Windows.Forms.Button()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chksummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pndialog.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfrom
        '
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(28, 77)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(108, 22)
        Me.dtfrom.TabIndex = 1
        Me.dtfrom.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(25, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crviewer.Location = New System.Drawing.Point(-2, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(1289, 573)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(141, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "To :"
        '
        'dtto
        '
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(144, 77)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(105, 22)
        Me.dtto.TabIndex = 31
        Me.dtto.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
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
        Me.txtcoll.Location = New System.Drawing.Point(28, 241)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(221, 25)
        Me.txtcoll.TabIndex = 32
        Me.txtcoll.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(25, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Collecting Officer :"
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(55, 284)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(81, 34)
        Me.bttngenerate.TabIndex = 34
        Me.bttngenerate.Text = "Generate"
        '
        'chksummary
        '
        Me.chksummary.BackColor = System.Drawing.Color.Transparent
        Me.chksummary.Location = New System.Drawing.Point(131, 22)
        Me.chksummary.Name = "chksummary"
        Me.chksummary.Size = New System.Drawing.Size(67, 18)
        Me.chksummary.TabIndex = 36
        Me.chksummary.Text = "Summary"
        '
        'chkdetails
        '
        Me.chkdetails.BackColor = System.Drawing.Color.Transparent
        Me.chkdetails.Location = New System.Drawing.Point(55, 22)
        Me.chkdetails.Name = "chkdetails"
        Me.chkdetails.Size = New System.Drawing.Size(54, 18)
        Me.chkdetails.TabIndex = 35
        Me.chkdetails.TabStop = True
        Me.chkdetails.Text = "Details"
        Me.chkdetails.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
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
        Me.txtloantype.Location = New System.Drawing.Point(28, 187)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(221, 26)
        Me.txtloantype.TabIndex = 37
        Me.txtloantype.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(25, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Loan Type :"
        '
        'pndialog
        '
        Me.pndialog.BackColor = System.Drawing.Color.AliceBlue
        Me.pndialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pndialog.Controls.Add(Me.Label5)
        Me.pndialog.Controls.Add(Me.cbotype)
        Me.pndialog.Controls.Add(Me.chkdetails)
        Me.pndialog.Controls.Add(Me.dtfrom)
        Me.pndialog.Controls.Add(Me.Label4)
        Me.pndialog.Controls.Add(Me.Label1)
        Me.pndialog.Controls.Add(Me.txtloantype)
        Me.pndialog.Controls.Add(Me.dtto)
        Me.pndialog.Controls.Add(Me.chksummary)
        Me.pndialog.Controls.Add(Me.Label2)
        Me.pndialog.Controls.Add(Me.txtcoll)
        Me.pndialog.Controls.Add(Me.bttngenerate)
        Me.pndialog.Controls.Add(Me.Label3)
        Me.pndialog.Location = New System.Drawing.Point(493, 25)
        Me.pndialog.Name = "pndialog"
        Me.pndialog.Size = New System.Drawing.Size(288, 347)
        Me.pndialog.TabIndex = 40
        Me.pndialog.Visible = False
        '
        'bttnhide
        '
        Me.bttnhide.BackgroundImage = CType(resources.GetObject("bttnhide.BackgroundImage"), System.Drawing.Image)
        Me.bttnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnhide.Location = New System.Drawing.Point(493, 0)
        Me.bttnhide.Name = "bttnhide"
        Me.bttnhide.Size = New System.Drawing.Size(32, 26)
        Me.bttnhide.TabIndex = 39
        Me.bttnhide.UseVisualStyleBackColor = True
        '
        'cbotype
        '
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Normal Loan", "Restructured Loan"})
        Me.cbotype.Location = New System.Drawing.Point(28, 134)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(221, 21)
        Me.cbotype.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(25, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Type :"
        '
        'frm_abstractofcoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1286, 573)
        Me.Controls.Add(Me.pndialog)
        Me.Controls.Add(Me.bttnhide)
        Me.Controls.Add(Me.crviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_abstractofcoll"
        Me.ShowIcon = False
        Me.Text = "Abstract of Collection"
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chksummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pndialog.ResumeLayout(False)
        Me.pndialog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents collectionsheet1 As Gsoft.collectionsheet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcoll As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents chksummary As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents chkdetails As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pndialog As System.Windows.Forms.Panel
    Friend WithEvents bttnhide As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
End Class
