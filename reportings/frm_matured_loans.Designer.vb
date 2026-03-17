<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_matured_loans
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
        CType(Me.txtcenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crviewer.Location = New System.Drawing.Point(217, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(1040, 602)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'gendate
        '
        Me.gendate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(15, 55)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(132, 22)
        Me.gendate.TabIndex = 1
        Me.gendate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 39)
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
        Me.cboption.Location = New System.Drawing.Point(15, 113)
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
        '
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
        Me.txtcenter.Location = New System.Drawing.Point(16, 213)
        Me.txtcenter.Name = "txtcenter"
        Me.txtcenter.Size = New System.Drawing.Size(196, 26)
        Me.txtcenter.TabIndex = 8
        Me.txtcenter.TabStop = False
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(130, 253)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(81, 31)
        Me.bttngenerate.TabIndex = 35
        Me.bttngenerate.Text = "Generate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Display Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 197)
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
        '
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
        Me.txtloantype.Size = New System.Drawing.Size(196, 27)
        Me.txtloantype.TabIndex = 37
        Me.txtloantype.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Loan Type :"
        '
        'frm_matured_loans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1257, 602)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.txtcenter)
        Me.Controls.Add(Me.cboption)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gendate)
        Me.Controls.Add(Me.crviewer)
        Me.Name = "frm_matured_loans"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matured Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtcenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
