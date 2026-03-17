<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_upload_sss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_upload_sss))
        Me.dtgridsavings_coll = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblps = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpick = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttnnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttn_save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttncancel = New System.Windows.Forms.ToolStripButton()
        CType(Me.dtgridsavings_coll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgridsavings_coll
        '
        Me.dtgridsavings_coll.AllowUserToAddRows = False
        Me.dtgridsavings_coll.AllowUserToDeleteRows = False
        Me.dtgridsavings_coll.AllowUserToResizeRows = False
        Me.dtgridsavings_coll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgridsavings_coll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridsavings_coll.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgridsavings_coll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridsavings_coll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column6, Me.Column2, Me.Column7, Me.Column5})
        Me.dtgridsavings_coll.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtgridsavings_coll.Location = New System.Drawing.Point(1, 32)
        Me.dtgridsavings_coll.Name = "dtgridsavings_coll"
        Me.dtgridsavings_coll.ReadOnly = True
        Me.dtgridsavings_coll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgridsavings_coll.RowHeadersVisible = False
        Me.dtgridsavings_coll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgridsavings_coll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridsavings_coll.Size = New System.Drawing.Size(1223, 424)
        Me.dtgridsavings_coll.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "memcode"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "SSS No."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fullname"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "Post No."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Reference"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Amount"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Satus"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 26)
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'lblps
        '
        Me.lblps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblps.AutoSize = True
        Me.lblps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblps.ForeColor = System.Drawing.Color.Lime
        Me.lblps.Location = New System.Drawing.Point(76, 27)
        Me.lblps.Name = "lblps"
        Me.lblps.Size = New System.Drawing.Size(24, 16)
        Me.lblps.TabIndex = 15
        Me.lblps.Text = "00"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total Contribution :"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblps)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(1030, 476)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 46)
        Me.Panel3.TabIndex = 20
        '
        'dtpick
        '
        Me.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick.Location = New System.Drawing.Point(15, 486)
        Me.dtpick.Name = "dtpick"
        Me.dtpick.Size = New System.Drawing.Size(117, 21)
        Me.dtpick.TabIndex = 26
        Me.dtpick.Value = New Date(2016, 5, 10, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Date :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttnnew, Me.ToolStripSeparator1, Me.bttn_save, Me.ToolStripSeparator2, Me.bttncancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1222, 25)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttnnew
        '
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(66, 22)
        Me.bttnnew.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bttn_save
        '
        Me.bttn_save.Image = CType(resources.GetObject("bttn_save.Image"), System.Drawing.Image)
        Me.bttn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttn_save.Name = "bttn_save"
        Me.bttn_save.Size = New System.Drawing.Size(132, 22)
        Me.bttn_save.Text = "Upload Conribution"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bttncancel
        '
        Me.bttncancel.Image = CType(resources.GetObject("bttncancel.Image"), System.Drawing.Image)
        Me.bttncancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(149, 22)
        Me.bttncancel.Text = "Cancel Uploaded Cont."
        '
        'frm_upload_sss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1222, 521)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpick)
        Me.Controls.Add(Me.dtgridsavings_coll)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_upload_sss"
        Me.ShowIcon = False
        Me.Text = "Upload SSS Collection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgridsavings_coll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgridsavings_coll As System.Windows.Forms.DataGridView
    Friend WithEvents lblps As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttn_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttncancel As System.Windows.Forms.ToolStripButton
End Class
