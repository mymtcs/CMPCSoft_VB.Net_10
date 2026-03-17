<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_delinquency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_delinquency))
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.gendate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboption = New System.Windows.Forms.ComboBox()
        Me.txtcenter = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pndialog = New System.Windows.Forms.Panel()
        Me.bttnhide = New System.Windows.Forms.Button()
        CType(Me.txtcenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pndialog.SuspendLayout()
        Me.SuspendLayout()
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
        Me.crviewer.Size = New System.Drawing.Size(1257, 602)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'gendate
        '
        Me.gendate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(35, 36)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(132, 22)
        Me.gendate.TabIndex = 1
        Me.gendate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gen. Date :"
        '
        'cboption
        '
        Me.cboption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboption.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboption.FormattingEnabled = True
        Me.cboption.Items.AddRange(New Object() {"By Officer", "By Center"})
        Me.cboption.Location = New System.Drawing.Point(35, 94)
        Me.cboption.Name = "cboption"
        Me.cboption.Size = New System.Drawing.Size(129, 21)
        Me.cboption.TabIndex = 7
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
        Me.txtcenter.Location = New System.Drawing.Point(36, 194)
        Me.txtcenter.Name = "txtcenter"
        Me.txtcenter.Size = New System.Drawing.Size(196, 26)
        Me.txtcenter.TabIndex = 8
        Me.txtcenter.TabStop = False
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(151, 240)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(81, 31)
        Me.bttngenerate.TabIndex = 35
        Me.bttngenerate.Text = "Generate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(32, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Display Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Collecting Officer :"
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
        Me.txtloantype.Location = New System.Drawing.Point(35, 143)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(196, 27)
        Me.txtloantype.TabIndex = 37
        Me.txtloantype.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(32, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Loan Type :"
        '
        'pndialog
        '
        Me.pndialog.BackColor = System.Drawing.Color.AliceBlue
        Me.pndialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pndialog.Controls.Add(Me.Label1)
        Me.pndialog.Controls.Add(Me.gendate)
        Me.pndialog.Controls.Add(Me.Label4)
        Me.pndialog.Controls.Add(Me.Label3)
        Me.pndialog.Controls.Add(Me.txtloantype)
        Me.pndialog.Controls.Add(Me.cboption)
        Me.pndialog.Controls.Add(Me.Label2)
        Me.pndialog.Controls.Add(Me.txtcenter)
        Me.pndialog.Controls.Add(Me.bttngenerate)
        Me.pndialog.Location = New System.Drawing.Point(495, 25)
        Me.pndialog.Name = "pndialog"
        Me.pndialog.Size = New System.Drawing.Size(271, 301)
        Me.pndialog.TabIndex = 39
        Me.pndialog.Visible = False
        '
        'bttnhide
        '
        Me.bttnhide.BackgroundImage = CType(resources.GetObject("bttnhide.BackgroundImage"), System.Drawing.Image)
        Me.bttnhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnhide.Location = New System.Drawing.Point(495, 0)
        Me.bttnhide.Name = "bttnhide"
        Me.bttnhide.Size = New System.Drawing.Size(32, 26)
        Me.bttnhide.TabIndex = 40
        Me.bttnhide.UseVisualStyleBackColor = True
        '
        'frm_delinquency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1257, 602)
        Me.Controls.Add(Me.bttnhide)
        Me.Controls.Add(Me.pndialog)
        Me.Controls.Add(Me.crviewer)
        Me.Name = "frm_delinquency"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delinquecy Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtcenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pndialog.ResumeLayout(False)
        Me.pndialog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents PARreports1 As CMPCsoft.PARreports
    Friend WithEvents gendate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboption As System.Windows.Forms.ComboBox
    Friend WithEvents txtcenter As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pndialog As System.Windows.Forms.Panel
    Friend WithEvents bttnhide As System.Windows.Forms.Button
End Class
