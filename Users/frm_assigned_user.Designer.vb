<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_assigned_user
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
        Me.txtuser = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.btnnsave = New Telerik.WinControls.UI.RadButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.bttncancel = New Telerik.WinControls.UI.RadButton
        Me.dtgrid_controls = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.txtuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuser.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuser.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid_controls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtuser
        '
        '
        'txtuser.NestedRadGridView
        '
        Me.txtuser.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtuser.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtuser.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtuser.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtuser.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtuser.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtuser.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtuser.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtuser.EditorControl.Name = "NestedRadGridView"
        Me.txtuser.EditorControl.ReadOnly = True
        Me.txtuser.EditorControl.ShowGroupPanel = False
        Me.txtuser.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtuser.EditorControl.TabIndex = 0
        Me.txtuser.Location = New System.Drawing.Point(14, 37)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(291, 27)
        Me.txtuser.TabIndex = 1
        Me.txtuser.TabStop = False
        '
        'btnnsave
        '
        Me.btnnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnsave.Location = New System.Drawing.Point(220, 327)
        Me.btnnsave.Name = "btnnsave"
        Me.btnnsave.Size = New System.Drawing.Size(106, 32)
        Me.btnnsave.TabIndex = 2
        Me.btnnsave.Text = "Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a user :"
        '
        'bttncancel
        '
        Me.bttncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttncancel.Location = New System.Drawing.Point(334, 327)
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(106, 32)
        Me.bttncancel.TabIndex = 6
        Me.bttncancel.Text = "Close"
        '
        'dtgrid_controls
        '
        Me.dtgrid_controls.AllowUserToAddRows = False
        Me.dtgrid_controls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrid_controls.BackgroundColor = System.Drawing.Color.White
        Me.dtgrid_controls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_controls.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dtgrid_controls.Location = New System.Drawing.Point(12, 85)
        Me.dtgrid_controls.Name = "dtgrid_controls"
        Me.dtgrid_controls.RowHeadersWidth = 4
        Me.dtgrid_controls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_controls.Size = New System.Drawing.Size(430, 225)
        Me.dtgrid_controls.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "Assigned Loans"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "gl_loans"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'frm_assigned_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(454, 384)
        Me.Controls.Add(Me.dtgrid_controls)
        Me.Controls.Add(Me.bttncancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnnsave)
        Me.Controls.Add(Me.txtuser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_assigned_user"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Control"
        CType(Me.txtuser.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuser.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_controls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtuser As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttncancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtgrid_controls As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
