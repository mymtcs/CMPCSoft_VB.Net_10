<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cbuledger
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtgridsaving = New System.Windows.Forms.DataGridView()
        Me.rel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetToCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsActiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstsavingledger = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bttnedit = New Telerik.WinControls.UI.RadButton()
        Me.bttnrecompute = New Telerik.WinControls.UI.RadButton()
        Me.bttn_passbookledger = New Telerik.WinControls.UI.RadButton()
        Me.bttnpcover = New Telerik.WinControls.UI.RadButton()
        Me.bttnwithdrwls = New Telerik.WinControls.UI.RadButton()
        Me.bttndeposit = New Telerik.WinControls.UI.RadButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstclone = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.dtgridsaving, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bttnedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnrecompute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttn_passbookledger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnpcover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnwithdrwls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttndeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(279, 276)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(784, 29)
        Me.txtsearch.TabIndex = 0
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Full Name"
        Me.ColumnHeader22.Width = 287
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "PnNumber"
        Me.ColumnHeader21.Width = 87
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Interest"
        Me.ColumnHeader25.Width = 125
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Due Date"
        Me.ColumnHeader23.Width = 234
        '
        'dtgridsaving
        '
        Me.dtgridsaving.AllowUserToAddRows = False
        Me.dtgridsaving.AllowUserToDeleteRows = False
        Me.dtgridsaving.AllowUserToOrderColumns = True
        Me.dtgridsaving.AllowUserToResizeColumns = False
        Me.dtgridsaving.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgridsaving.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgridsaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridsaving.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rel, Me.memcode, Me.Column4, Me.amount, Me.Column8})
        Me.dtgridsaving.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtgridsaving.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgridsaving.Location = New System.Drawing.Point(0, 3)
        Me.dtgridsaving.MultiSelect = False
        Me.dtgridsaving.Name = "dtgridsaving"
        Me.dtgridsaving.ReadOnly = True
        Me.dtgridsaving.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridsaving.Size = New System.Drawing.Size(1250, 267)
        Me.dtgridsaving.TabIndex = 12
        '
        'rel
        '
        Me.rel.HeaderText = "CBU Account No."
        Me.rel.Name = "rel"
        Me.rel.ReadOnly = True
        Me.rel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rel.Width = 150
        '
        'memcode
        '
        Me.memcode.HeaderText = "Account Name"
        Me.memcode.Name = "memcode"
        Me.memcode.ReadOnly = True
        Me.memcode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.memcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.memcode.Width = 260
        '
        'Column4
        '
        Me.Column4.HeaderText = "Account Balance"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 130
        '
        'amount
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.amount.HeaderText = "Date Open"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.amount.Width = 140
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 130
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetToCloseToolStripMenuItem, Me.SetAsActiveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 48)
        '
        'SetToCloseToolStripMenuItem
        '
        Me.SetToCloseToolStripMenuItem.Name = "SetToCloseToolStripMenuItem"
        Me.SetToCloseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SetToCloseToolStripMenuItem.Text = "Set as Close Account"
        '
        'SetAsActiveToolStripMenuItem
        '
        Me.SetAsActiveToolStripMenuItem.Name = "SetAsActiveToolStripMenuItem"
        Me.SetAsActiveToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SetAsActiveToolStripMenuItem.Text = "Set as Active Account"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Amounts Recievable"
        Me.ColumnHeader24.Width = 155
        '
        'lstsavingledger
        '
        Me.lstsavingledger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstsavingledger.BackColor = System.Drawing.Color.AliceBlue
        Me.lstsavingledger.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lstsavingledger.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstsavingledger.FullRowSelect = True
        Me.lstsavingledger.Location = New System.Drawing.Point(4, 4)
        Me.lstsavingledger.Margin = New System.Windows.Forms.Padding(4)
        Me.lstsavingledger.MultiSelect = False
        Me.lstsavingledger.Name = "lstsavingledger"
        Me.lstsavingledger.Size = New System.Drawing.Size(1242, 247)
        Me.lstsavingledger.TabIndex = 9
        Me.lstsavingledger.UseCompatibleStateImageBehavior = False
        Me.lstsavingledger.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Posting Date"
        Me.ColumnHeader1.Width = 127
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Post No."
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Post Mode"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Deposit"
        Me.ColumnHeader10.Width = 151
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Withdrawal"
        Me.ColumnHeader11.Width = 123
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Running Balance"
        Me.ColumnHeader13.Width = 129
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Reference"
        Me.ColumnHeader14.Width = 102
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Remarks"
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "User"
        Me.ColumnHeader16.Width = 89
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "System Date"
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 0
        '
        'bttnedit
        '
        Me.bttnedit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnedit.Location = New System.Drawing.Point(220, 258)
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(87, 35)
        Me.bttnedit.TabIndex = 201
        Me.bttnedit.Text = "&Edit"
        '
        'bttnrecompute
        '
        Me.bttnrecompute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnrecompute.Location = New System.Drawing.Point(313, 258)
        Me.bttnrecompute.Name = "bttnrecompute"
        Me.bttnrecompute.Size = New System.Drawing.Size(87, 35)
        Me.bttnrecompute.TabIndex = 200
        Me.bttnrecompute.Text = "&Recompute"
        '
        'bttn_passbookledger
        '
        Me.bttn_passbookledger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttn_passbookledger.Location = New System.Drawing.Point(1105, 258)
        Me.bttn_passbookledger.Name = "bttn_passbookledger"
        Me.bttn_passbookledger.Size = New System.Drawing.Size(127, 35)
        Me.bttn_passbookledger.TabIndex = 199
        Me.bttn_passbookledger.Text = "Print Passbook Ledger"
        '
        'bttnpcover
        '
        Me.bttnpcover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnpcover.Location = New System.Drawing.Point(972, 258)
        Me.bttnpcover.Name = "bttnpcover"
        Me.bttnpcover.Size = New System.Drawing.Size(127, 35)
        Me.bttnpcover.TabIndex = 198
        Me.bttnpcover.Text = "Print Passbook Cover"
        '
        'bttnwithdrwls
        '
        Me.bttnwithdrwls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnwithdrwls.Location = New System.Drawing.Point(105, 258)
        Me.bttnwithdrwls.Name = "bttnwithdrwls"
        Me.bttnwithdrwls.Size = New System.Drawing.Size(87, 35)
        Me.bttnwithdrwls.TabIndex = 197
        Me.bttnwithdrwls.Text = "Withdrawal"
        '
        'bttndeposit
        '
        Me.bttndeposit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttndeposit.Location = New System.Drawing.Point(12, 258)
        Me.bttndeposit.Name = "bttndeposit"
        Me.bttndeposit.Size = New System.Drawing.Size(87, 35)
        Me.bttndeposit.TabIndex = 197
        Me.bttndeposit.Text = "Deposit"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtgridsaving)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstsavingledger)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttnedit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttndeposit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttnrecompute)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttnwithdrwls)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttn_passbookledger)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bttnpcover)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstclone)
        Me.SplitContainer1.Size = New System.Drawing.Size(1250, 617)
        Me.SplitContainer1.SplitterDistance = 308
        Me.SplitContainer1.TabIndex = 202
        '
        'lstclone
        '
        Me.lstclone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstclone.BackColor = System.Drawing.Color.AliceBlue
        Me.lstclone.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader12, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29})
        Me.lstclone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstclone.FullRowSelect = True
        Me.lstclone.Location = New System.Drawing.Point(4, 4)
        Me.lstclone.Margin = New System.Windows.Forms.Padding(4)
        Me.lstclone.MultiSelect = False
        Me.lstclone.Name = "lstclone"
        Me.lstclone.Size = New System.Drawing.Size(1217, 247)
        Me.lstclone.TabIndex = 202
        Me.lstclone.UseCompatibleStateImageBehavior = False
        Me.lstclone.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Posting Date"
        Me.ColumnHeader6.Width = 127
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Post No."
        Me.ColumnHeader7.Width = 112
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Post Mode"
        Me.ColumnHeader8.Width = 118
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Deposit"
        Me.ColumnHeader9.Width = 151
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Withdrawal"
        Me.ColumnHeader12.Width = 123
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Running Balance"
        Me.ColumnHeader18.Width = 129
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Reference"
        Me.ColumnHeader19.Width = 102
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Remarks"
        Me.ColumnHeader20.Width = 100
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "User"
        Me.ColumnHeader26.Width = 89
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "System Date"
        Me.ColumnHeader27.Width = 0
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Width = 0
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Width = 0
        '
        'frm_cbuledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 617)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_cbuledger"
        Me.ShowIcon = False
        Me.Text = "Capital Build-Up"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgridsaving, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bttnedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnrecompute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttn_passbookledger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnpcover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnwithdrwls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttndeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Public WithEvents lstsavingledger As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bttnwithdrwls As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttndeposit As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnpcover As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttn_passbookledger As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnrecompute As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtgridsaving As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnedit As Telerik.WinControls.UI.RadButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetToCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsActiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents memcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents lstclone As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
End Class
