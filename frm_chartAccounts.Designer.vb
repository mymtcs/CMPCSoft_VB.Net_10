<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_chartAccounts
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.dtgrid_chartaccounts = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Normal_Balance = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.dtgridaccounts = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dtgrid_chartaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrid_chartaccounts
        '
        Me.dtgrid_chartaccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrid_chartaccounts.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgrid_chartaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_chartaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Normal_Balance})
        Me.dtgrid_chartaccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrid_chartaccounts.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgrid_chartaccounts.Location = New System.Drawing.Point(-1, 0)
        Me.dtgrid_chartaccounts.Name = "dtgrid_chartaccounts"
        Me.dtgrid_chartaccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_chartaccounts.Size = New System.Drawing.Size(1112, 153)
        Me.dtgrid_chartaccounts.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account Code"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 160
        '
        'Column2
        '
        Me.Column2.HeaderText = "Account Description"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Active"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.HeaderText = "Account Type"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Normal_Balance
        '
        Me.Normal_Balance.HeaderText = "Normal Balance"
        Me.Normal_Balance.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.Normal_Balance.Name = "Normal_Balance"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(240, 482)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(594, 29)
        Me.txtsearch.TabIndex = 1
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtgridaccounts
        '
        Me.dtgridaccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgridaccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgridaccounts.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgridaccounts.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtgridaccounts.ForeColor = System.Drawing.Color.Black
        Me.dtgridaccounts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgridaccounts.Location = New System.Drawing.Point(6, 159)
        '
        'dtgridaccounts
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "Account Code"
        GridViewTextBoxColumn1.HeaderText = "Account Code"
        GridViewTextBoxColumn1.Name = "Account Code"
        GridViewTextBoxColumn1.Width = 150
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Sub-Account Code"
        GridViewTextBoxColumn2.HeaderText = "Sub-Account Code"
        GridViewTextBoxColumn2.Name = "Sub-Account Code"
        GridViewTextBoxColumn2.Width = 100
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "Account Titles"
        GridViewTextBoxColumn3.HeaderText = "Account Titles"
        GridViewTextBoxColumn3.Name = "Account Titles"
        GridViewTextBoxColumn3.Width = 350
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "Account Type"
        GridViewTextBoxColumn4.HeaderText = "Account Type"
        GridViewTextBoxColumn4.Name = "Account Type"
        GridViewTextBoxColumn4.Width = 150
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "Sub-Account Type"
        GridViewTextBoxColumn5.HeaderText = "Sub-Account Type"
        GridViewTextBoxColumn5.Name = "Sub-Account Type"
        GridViewTextBoxColumn5.Width = 150
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "Normal Balance"
        GridViewTextBoxColumn6.HeaderText = "Normal Balance"
        GridViewTextBoxColumn6.Name = "Normal Balance"
        GridViewTextBoxColumn6.Width = 150
        Me.dtgridaccounts.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6})
        Me.dtgridaccounts.Name = "dtgridaccounts"
        Me.dtgridaccounts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtgridaccounts.Size = New System.Drawing.Size(1099, 294)
        Me.dtgridaccounts.TabIndex = 2
        Me.dtgridaccounts.Text = "dtgridchart"
        '
        'frm_chartAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 534)
        Me.Controls.Add(Me.dtgridaccounts)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.dtgrid_chartaccounts)
        Me.Name = "frm_chartAccounts"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart Account"
        CType(Me.dtgrid_chartaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgrid_chartaccounts As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Normal_Balance As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dtgridaccounts As Telerik.WinControls.UI.RadGridView
End Class

