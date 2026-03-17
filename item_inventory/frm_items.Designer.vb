<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_items
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtgriditems = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.bttnedit = New Telerik.WinControls.UI.RadButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bttnreceive = New Telerik.WinControls.UI.RadButton()
        Me.dtgrid_inv = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtgriditems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnedit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.bttnreceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid_inv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtgriditems)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Ivory
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttnnew)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttnedit)
        Me.SplitContainer1.Size = New System.Drawing.Size(1241, 557)
        Me.SplitContainer1.SplitterDistance = 503
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'dtgriditems
        '
        Me.dtgriditems.AllowUserToAddRows = False
        Me.dtgriditems.AllowUserToDeleteRows = False
        Me.dtgriditems.AllowUserToResizeRows = False
        Me.dtgriditems.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgriditems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgriditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgriditems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column6, Me.Column7})
        Me.dtgriditems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgriditems.Location = New System.Drawing.Point(0, 0)
        Me.dtgriditems.Name = "dtgriditems"
        Me.dtgriditems.ReadOnly = True
        Me.dtgriditems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgriditems.RowHeadersVisible = False
        Me.dtgriditems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgriditems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgriditems.Size = New System.Drawing.Size(1241, 503)
        Me.dtgriditems.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Item Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 370
        '
        'Column6
        '
        Me.Column6.HeaderText = "Category"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 250
        '
        'Column7
        '
        Me.Column7.HeaderText = "Status"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttnnew.Location = New System.Drawing.Point(9, 5)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(93, 36)
        Me.bttnnew.TabIndex = 9
        Me.bttnnew.Text = "&New"
        '
        'bttnedit
        '
        Me.bttnedit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttnedit.Enabled = False
        Me.bttnedit.Location = New System.Drawing.Point(108, 5)
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(93, 36)
        Me.bttnedit.TabIndex = 10
        Me.bttnedit.Text = "&Edit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1255, 591)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1247, 563)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "                    Items                    "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bttnreceive)
        Me.TabPage2.Controls.Add(Me.dtgrid_inv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1247, 563)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "                 Inventory                 "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bttnreceive
        '
        Me.bttnreceive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnreceive.Location = New System.Drawing.Point(6, 521)
        Me.bttnreceive.Name = "bttnreceive"
        Me.bttnreceive.Size = New System.Drawing.Size(93, 36)
        Me.bttnreceive.TabIndex = 11
        Me.bttnreceive.Text = "&Receive Stocks"
        '
        'dtgrid_inv
        '
        Me.dtgrid_inv.AllowUserToAddRows = False
        Me.dtgrid_inv.AllowUserToDeleteRows = False
        Me.dtgrid_inv.AllowUserToResizeRows = False
        Me.dtgrid_inv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrid_inv.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgrid_inv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgrid_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_inv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column2})
        Me.dtgrid_inv.Location = New System.Drawing.Point(3, 3)
        Me.dtgrid_inv.Name = "dtgrid_inv"
        Me.dtgrid_inv.ReadOnly = True
        Me.dtgrid_inv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgrid_inv.RowHeadersVisible = False
        Me.dtgrid_inv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgrid_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_inv.Size = New System.Drawing.Size(1241, 514)
        Me.dtgrid_inv.TabIndex = 11
        '
        'Column4
        '
        Me.Column4.HeaderText = "Transaction Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Delivery Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item Markup"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty Delivered"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Action"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 50
        '
        'frm_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_items"
        Me.ShowIcon = False
        Me.Text = "Items/Stocks"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtgriditems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnedit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.bttnreceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_inv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtgriditems As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtgrid_inv As System.Windows.Forms.DataGridView
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnedit As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnreceive As Telerik.WinControls.UI.RadButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
End Class
