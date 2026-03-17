<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abstractsavings
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.loanrel1 = New Gsoft.loanrel
        Me.Label1 = New System.Windows.Forms.Label
        Me.crv_loantoberel = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.loantoberel1 = New Gsoft.loantoberel
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "From :"
        '
        'crv_loantoberel
        '
        Me.crv_loantoberel.ActiveViewIndex = -1
        Me.crv_loantoberel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv_loantoberel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_loantoberel.Location = New System.Drawing.Point(233, 0)
        Me.crv_loantoberel.Name = "crv_loantoberel"
        Me.crv_loantoberel.SelectionFormula = ""
        Me.crv_loantoberel.Size = New System.Drawing.Size(1044, 552)
        Me.crv_loantoberel.TabIndex = 16
        Me.crv_loantoberel.ViewTimeSelectionFormula = ""
        '
        'dtto
        '
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(12, 104)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(132, 22)
        Me.dtto.TabIndex = 33
        Me.dtto.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'dtfrom
        '
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(12, 49)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(132, 22)
        Me.dtfrom.TabIndex = 32
        Me.dtfrom.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
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
        Me.txtloantype.Location = New System.Drawing.Point(12, 159)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(215, 25)
        Me.txtloantype.TabIndex = 34
        Me.txtloantype.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Savings Type :"
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(12, 204)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(81, 33)
        Me.bttngenerate.TabIndex = 36
        Me.bttngenerate.Text = "Generate"
        '
        'frm_abstractsavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1277, 552)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crv_loantoberel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_abstractsavings"
        Me.ShowIcon = False
        Me.Text = "Abstract of Savings Collection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crv_loantoberel As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents loanrel1 As Gsoft.loanrel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loantoberel1 As Gsoft.loantoberel
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
End Class
