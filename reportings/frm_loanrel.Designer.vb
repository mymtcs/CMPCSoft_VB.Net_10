<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loanrel
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
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.loanrel1 = New Gsoft.loanrel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcoll = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.crv_loanrel = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkdetails = New Telerik.WinControls.UI.RadRadioButton
        Me.chksummary = New Telerik.WinControls.UI.RadRadioButton
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcoll.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcoll.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chksummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtfrom
        '
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(6, 107)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(125, 20)
        Me.dtfrom.TabIndex = 11
        Me.dtfrom.Value = New Date(2013, 9, 23, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "To :"
        '
        'dtto
        '
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(9, 156)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(125, 20)
        Me.dtto.TabIndex = 14
        Me.dtto.Value = New Date(2013, 9, 23, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Coll. Officer :"
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
        Me.txtcoll.Location = New System.Drawing.Point(9, 256)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(184, 25)
        Me.txtcoll.TabIndex = 17
        Me.txtcoll.TabStop = False
        '
        'crv_loanrel
        '
        Me.crv_loanrel.ActiveViewIndex = -1
        Me.crv_loanrel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv_loanrel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_loanrel.Location = New System.Drawing.Point(200, 0)
        Me.crv_loanrel.Name = "crv_loanrel"
        Me.crv_loanrel.SelectionFormula = ""
        Me.crv_loanrel.Size = New System.Drawing.Size(1066, 528)
        Me.crv_loanrel.TabIndex = 10
        Me.crv_loanrel.ViewTimeSelectionFormula = ""
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(9, 298)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(81, 31)
        Me.bttngenerate.TabIndex = 35
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
        Me.txtloantype.Location = New System.Drawing.Point(9, 204)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(184, 25)
        Me.txtloantype.TabIndex = 36
        Me.txtloantype.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Loan Type :"
        '
        'chkdetails
        '
        Me.chkdetails.Location = New System.Drawing.Point(12, 17)
        Me.chkdetails.Name = "chkdetails"
        Me.chkdetails.Size = New System.Drawing.Size(54, 18)
        Me.chkdetails.TabIndex = 38
        Me.chkdetails.TabStop = True
        Me.chkdetails.Text = "Details"
        Me.chkdetails.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chksummary
        '
        Me.chksummary.Location = New System.Drawing.Point(12, 41)
        Me.chksummary.Name = "chksummary"
        Me.chksummary.Size = New System.Drawing.Size(67, 18)
        Me.chksummary.TabIndex = 39
        Me.chksummary.Text = "Summary"
        '
        'frm_loanrel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1266, 528)
        Me.Controls.Add(Me.chksummary)
        Me.Controls.Add(Me.chkdetails)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.txtcoll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.crv_loanrel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_loanrel"
        Me.ShowIcon = False
        Me.Text = "Loan Releases"
        CType(Me.txtcoll.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcoll.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chksummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crv_loanrel As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents loanrel1 As Gsoft.loanrel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcoll As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkdetails As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents chksummary As Telerik.WinControls.UI.RadRadioButton
End Class
