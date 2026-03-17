<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_masterlist
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
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.General_masterlist1 = New Gsoft.General_masterlist()
        Me.dtgridcolumn = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttngen = New System.Windows.Forms.Button()
        Me.lstdata = New System.Windows.Forms.ListView()
        Me.dtpick = New System.Windows.Forms.DateTimePicker()
        Me.bttnexport = New System.Windows.Forms.Button()
        Me.bttnprint = New System.Windows.Forms.Button()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dtgridcolumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.Location = New System.Drawing.Point(389, 247)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(825, 252)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'dtgridcolumn
        '
        Me.dtgridcolumn.AllowUserToAddRows = False
        Me.dtgridcolumn.AllowUserToDeleteRows = False
        Me.dtgridcolumn.AllowUserToOrderColumns = True
        Me.dtgridcolumn.AllowUserToResizeColumns = False
        Me.dtgridcolumn.AllowUserToResizeRows = False
        Me.dtgridcolumn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtgridcolumn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridcolumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridcolumn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dtgridcolumn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgridcolumn.Location = New System.Drawing.Point(1, 1)
        Me.dtgridcolumn.Name = "dtgridcolumn"
        Me.dtgridcolumn.RowHeadersWidth = 5
        Me.dtgridcolumn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridcolumn.Size = New System.Drawing.Size(230, 498)
        Me.dtgridcolumn.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 160
        '
        'Column3
        '
        Me.Column3.HeaderText = "Value"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'bttngen
        '
        Me.bttngen.Location = New System.Drawing.Point(686, 11)
        Me.bttngen.Name = "bttngen"
        Me.bttngen.Size = New System.Drawing.Size(75, 23)
        Me.bttngen.TabIndex = 5
        Me.bttngen.Text = "Generate"
        Me.bttngen.UseVisualStyleBackColor = True
        '
        'lstdata
        '
        Me.lstdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstdata.FullRowSelect = True
        Me.lstdata.GridLines = True
        Me.lstdata.Location = New System.Drawing.Point(247, 49)
        Me.lstdata.Name = "lstdata"
        Me.lstdata.Size = New System.Drawing.Size(965, 450)
        Me.lstdata.TabIndex = 3
        Me.lstdata.UseCompatibleStateImageBehavior = False
        Me.lstdata.View = System.Windows.Forms.View.Details
        '
        'dtpick
        '
        Me.dtpick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick.Location = New System.Drawing.Point(569, 12)
        Me.dtpick.Name = "dtpick"
        Me.dtpick.Size = New System.Drawing.Size(111, 21)
        Me.dtpick.TabIndex = 6
        Me.dtpick.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'bttnexport
        '
        Me.bttnexport.Location = New System.Drawing.Point(781, 11)
        Me.bttnexport.Name = "bttnexport"
        Me.bttnexport.Size = New System.Drawing.Size(75, 23)
        Me.bttnexport.TabIndex = 7
        Me.bttnexport.Text = "Export"
        Me.bttnexport.UseVisualStyleBackColor = True
        '
        'bttnprint
        '
        Me.bttnprint.Location = New System.Drawing.Point(878, 11)
        Me.bttnprint.Name = "bttnprint"
        Me.bttnprint.Size = New System.Drawing.Size(75, 23)
        Me.bttnprint.TabIndex = 8
        Me.bttnprint.Text = "Print"
        Me.bttnprint.UseVisualStyleBackColor = True
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
        Me.txtloantype.Location = New System.Drawing.Point(320, 12)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(166, 20)
        Me.txtloantype.TabIndex = 9
        Me.txtloantype.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Loan Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Gen Date :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_masterlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 499)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.bttnprint)
        Me.Controls.Add(Me.bttnexport)
        Me.Controls.Add(Me.dtpick)
        Me.Controls.Add(Me.bttngen)
        Me.Controls.Add(Me.dtgridcolumn)
        Me.Controls.Add(Me.lstdata)
        Me.Controls.Add(Me.CRviewer)
        Me.Name = "frm_masterlist"
        Me.Text = "Active Members"
        CType(Me.dtgridcolumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents General_masterlist1 As Gsoft.General_masterlist
    Friend WithEvents dtgridcolumn As System.Windows.Forms.DataGridView
    Friend WithEvents bttngen As System.Windows.Forms.Button
    Friend WithEvents lstdata As System.Windows.Forms.ListView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpick As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttnexport As System.Windows.Forms.Button
    Friend WithEvents bttnprint As System.Windows.Forms.Button
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
