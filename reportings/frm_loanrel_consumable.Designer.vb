<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loanrel_consumable
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
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.bttngenerate = New System.Windows.Forms.Button
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.txtcoll = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rd_details = New Telerik.WinControls.UI.RadRadioButton
        Me.rd_summary = New Telerik.WinControls.UI.RadRadioButton
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcoll.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcoll.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_summary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Location = New System.Drawing.Point(0, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(1258, 598)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(592, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "From :"
        '
        'dtfrom
        '
        Me.dtfrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(631, 4)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(108, 21)
        Me.dtfrom.TabIndex = 36
        Me.dtfrom.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(745, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "To :"
        '
        'bttngenerate
        '
        Me.bttngenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttngenerate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttngenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttngenerate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.bttngenerate.FlatAppearance.BorderSize = 0
        Me.bttngenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttngenerate.ForeColor = System.Drawing.Color.Black
        Me.bttngenerate.Location = New System.Drawing.Point(1168, 3)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(78, 24)
        Me.bttngenerate.TabIndex = 34
        Me.bttngenerate.Text = "Generate"
        Me.bttngenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttngenerate.UseVisualStyleBackColor = False
        '
        'dtto
        '
        Me.dtto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(777, 4)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(108, 21)
        Me.dtto.TabIndex = 33
        Me.dtto.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'txtcoll
        '
        Me.txtcoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txtcoll.Location = New System.Drawing.Point(964, 5)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(198, 20)
        Me.txtcoll.TabIndex = 37
        Me.txtcoll.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(891, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Coll. Officer :"
        '
        'rd_details
        '
        Me.rd_details.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rd_details.BackColor = System.Drawing.SystemColors.Control
        Me.rd_details.Location = New System.Drawing.Point(451, 7)
        Me.rd_details.Name = "rd_details"
        Me.rd_details.Size = New System.Drawing.Size(54, 18)
        Me.rd_details.TabIndex = 39
        Me.rd_details.TabStop = True
        Me.rd_details.Text = "Details"
        Me.rd_details.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rd_summary
        '
        Me.rd_summary.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rd_summary.BackColor = System.Drawing.SystemColors.Control
        Me.rd_summary.Location = New System.Drawing.Point(511, 6)
        Me.rd_summary.Name = "rd_summary"
        Me.rd_summary.Size = New System.Drawing.Size(67, 18)
        Me.rd_summary.TabIndex = 40
        Me.rd_summary.Text = "Summary"
        '
        'frm_loanrel_consumable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1258, 598)
        Me.Controls.Add(Me.rd_summary)
        Me.Controls.Add(Me.rd_details)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcoll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.CRviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_loanrel_consumable"
        Me.ShowIcon = False
        Me.Text = "Abstract of Loan Release"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtcoll.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcoll.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_summary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttngenerate As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcoll As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rd_details As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rd_summary As Telerik.WinControls.UI.RadRadioButton
End Class
