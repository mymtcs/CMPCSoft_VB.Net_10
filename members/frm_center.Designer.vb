<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_center
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_center))
        Me.lst_center = New System.Windows.Forms.ListView
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.bttnedit = New Telerik.WinControls.UI.RadButton
        Me.bttnnew = New Telerik.WinControls.UI.RadButton
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.bttnedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_center
        '
        Me.lst_center.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lst_center.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_center.BackColor = System.Drawing.Color.AliceBlue
        Me.lst_center.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader6})
        Me.lst_center.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_center.FullRowSelect = True
        Me.lst_center.Location = New System.Drawing.Point(1, 0)
        Me.lst_center.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_center.Name = "lst_center"
        Me.lst_center.Size = New System.Drawing.Size(1195, 464)
        Me.lst_center.TabIndex = 11
        Me.lst_center.UseCompatibleStateImageBehavior = False
        Me.lst_center.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Center Code"
        Me.ColumnHeader17.Width = 139
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Center Name"
        Me.ColumnHeader2.Width = 333
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Center Cheif"
        Me.ColumnHeader3.Width = 194
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Center Deputy"
        Me.ColumnHeader4.Width = 169
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ColDayNo."
        Me.ColumnHeader5.Width = 106
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Address"
        Me.ColumnHeader1.Width = 186
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Accountnumber"
        Me.ColumnHeader6.Width = 101
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(284, 475)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(651, 29)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnedit
        '
        Me.bttnedit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnedit.Location = New System.Drawing.Point(1071, 473)
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(95, 33)
        Me.bttnedit.TabIndex = 15
        Me.bttnedit.Text = "Edit"
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.Location = New System.Drawing.Point(970, 473)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(95, 33)
        Me.bttnnew.TabIndex = 14
        Me.bttnnew.Text = "New"
        '
        'txtloantype
        '
        Me.txtloantype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.txtloantype.Location = New System.Drawing.Point(32, 478)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(235, 25)
        Me.txtloantype.TabIndex = 16
        Me.txtloantype.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 481)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox2.TabIndex = 205
        Me.PictureBox2.TabStop = False
        '
        'frm_center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1198, 535)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.bttnedit)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lst_center)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_center"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Center"
        CType(Me.bttnedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lst_center As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnedit As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
