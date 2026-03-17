<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usercontrols
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
        Me.txtuser = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnnsave = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnuncheckall = New Telerik.WinControls.UI.RadButton()
        Me.bttncancel = New Telerik.WinControls.UI.RadButton()
        Me.dtgrid_controls = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnkassigned = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.txtuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnuncheckall, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtuser.Size = New System.Drawing.Size(229, 27)
        Me.txtuser.TabIndex = 1
        Me.txtuser.TabStop = False
        '
        'btnnsave
        '
        Me.btnnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnsave.Location = New System.Drawing.Point(535, 486)
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
        'bttnuncheckall
        '
        Me.bttnuncheckall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnuncheckall.Location = New System.Drawing.Point(14, 486)
        Me.bttnuncheckall.Name = "bttnuncheckall"
        Me.bttnuncheckall.Size = New System.Drawing.Size(106, 32)
        Me.bttnuncheckall.TabIndex = 5
        Me.bttnuncheckall.Text = "Uncheck  All"
        '
        'bttncancel
        '
        Me.bttncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttncancel.Location = New System.Drawing.Point(649, 486)
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
        Me.dtgrid_controls.Size = New System.Drawing.Size(741, 381)
        Me.dtgrid_controls.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 600
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'cbotype
        '
        Me.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Accounting", "Bookeeper", "Cashier", "Administrator"})
        Me.cbotype.Location = New System.Drawing.Point(494, 41)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(261, 23)
        Me.cbotype.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(491, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Type :"
        '
        'lnkassigned
        '
        Me.lnkassigned.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkassigned.AutoSize = True
        Me.lnkassigned.Location = New System.Drawing.Point(133, 500)
        Me.lnkassigned.Name = "lnkassigned"
        Me.lnkassigned.Size = New System.Drawing.Size(86, 15)
        Me.lnkassigned.TabIndex = 10
        Me.lnkassigned.TabStop = True
        Me.lnkassigned.Text = "Assigned User"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(235, 500)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(119, 15)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Password Expiration"
        '
        'frm_usercontrols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(769, 543)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lnkassigned)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbotype)
        Me.Controls.Add(Me.dtgrid_controls)
        Me.Controls.Add(Me.bttncancel)
        Me.Controls.Add(Me.bttnuncheckall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnnsave)
        Me.Controls.Add(Me.txtuser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_usercontrols"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Control"
        CType(Me.txtuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnuncheckall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_controls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtuser As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnuncheckall As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttncancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtgrid_controls As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lnkassigned As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
