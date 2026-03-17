<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_upload_savings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_upload_savings))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcf = New System.Windows.Forms.Label()
        Me.lblps = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bttnrefresh = New Telerik.WinControls.UI.RadButton()
        Me.bttnupload = New Telerik.WinControls.UI.RadButton()
        Me.bttncancel_uploaded = New Telerik.WinControls.UI.RadButton()
        Me.dtpick = New System.Windows.Forms.DateTimePicker()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pn_backdate = New System.Windows.Forms.Panel()
        Me.lblalert_pass1 = New System.Windows.Forms.Label()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.bttncont1 = New Telerik.WinControls.UI.RadButton()
        Me.txtpassword_rec = New System.Windows.Forms.TextBox()
        CType(Me.dtgridsavings_coll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.bttnrefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnupload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncancel_uploaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_backdate.SuspendLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncont1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dtgridsavings_coll.Location = New System.Drawing.Point(1, 0)
        Me.dtgridsavings_coll.Name = "dtgridsavings_coll"
        Me.dtgridsavings_coll.ReadOnly = True
        Me.dtgridsavings_coll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgridsavings_coll.RowHeadersVisible = False
        Me.dtgridsavings_coll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgridsavings_coll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridsavings_coll.Size = New System.Drawing.Size(1223, 404)
        Me.dtgridsavings_coll.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Account Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "Account Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Post No."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total CF :"
        '
        'lblcf
        '
        Me.lblcf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcf.AutoSize = True
        Me.lblcf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcf.ForeColor = System.Drawing.Color.Lime
        Me.lblcf.Location = New System.Drawing.Point(82, 9)
        Me.lblcf.Name = "lblcf"
        Me.lblcf.Size = New System.Drawing.Size(24, 16)
        Me.lblcf.TabIndex = 13
        Me.lblcf.Text = "00"
        '
        'lblps
        '
        Me.lblps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblps.AutoSize = True
        Me.lblps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblps.ForeColor = System.Drawing.Color.Lime
        Me.lblps.Location = New System.Drawing.Point(82, 9)
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
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total PS :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Product :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblcf)
        Me.Panel2.Location = New System.Drawing.Point(854, 424)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 46)
        Me.Panel2.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblps)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(1050, 424)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 46)
        Me.Panel3.TabIndex = 20
        '
        'bttnrefresh
        '
        Me.bttnrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnrefresh.Location = New System.Drawing.Point(409, 424)
        Me.bttnrefresh.Name = "bttnrefresh"
        Me.bttnrefresh.Size = New System.Drawing.Size(83, 32)
        Me.bttnrefresh.TabIndex = 21
        Me.bttnrefresh.Text = "Refresh"
        '
        'bttnupload
        '
        Me.bttnupload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnupload.Location = New System.Drawing.Point(513, 424)
        Me.bttnupload.Name = "bttnupload"
        Me.bttnupload.Size = New System.Drawing.Size(83, 32)
        Me.bttnupload.TabIndex = 24
        Me.bttnupload.Text = "Upload"
        '
        'bttncancel_uploaded
        '
        Me.bttncancel_uploaded.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttncancel_uploaded.Location = New System.Drawing.Point(612, 424)
        Me.bttncancel_uploaded.Name = "bttncancel_uploaded"
        Me.bttncancel_uploaded.Size = New System.Drawing.Size(148, 32)
        Me.bttncancel_uploaded.TabIndex = 25
        Me.bttncancel_uploaded.Text = "Remove Uploaded Savings"
        '
        'dtpick
        '
        Me.dtpick.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpick.Enabled = False
        Me.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick.Location = New System.Drawing.Point(272, 429)
        Me.dtpick.Name = "dtpick"
        Me.dtpick.Size = New System.Drawing.Size(117, 21)
        Me.dtpick.TabIndex = 26
        Me.dtpick.Value = New Date(2016, 5, 10, 0, 0, 0, 0)
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
        Me.txtloantype.Location = New System.Drawing.Point(15, 430)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(205, 23)
        Me.txtloantype.TabIndex = 28
        Me.txtloantype.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(269, 412)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 15)
        Me.LinkLabel1.TabIndex = 223
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Transaction Date"
        '
        'pn_backdate
        '
        Me.pn_backdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pn_backdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pn_backdate.Controls.Add(Me.lblalert_pass1)
        Me.pn_backdate.Controls.Add(Me.RadButton2)
        Me.pn_backdate.Controls.Add(Me.PictureBox3)
        Me.pn_backdate.Controls.Add(Me.bttncont1)
        Me.pn_backdate.Controls.Add(Me.txtpassword_rec)
        Me.pn_backdate.Location = New System.Drawing.Point(452, 136)
        Me.pn_backdate.Name = "pn_backdate"
        Me.pn_backdate.Size = New System.Drawing.Size(319, 196)
        Me.pn_backdate.TabIndex = 224
        Me.pn_backdate.Visible = False
        '
        'lblalert_pass1
        '
        Me.lblalert_pass1.AutoSize = True
        Me.lblalert_pass1.ForeColor = System.Drawing.Color.Red
        Me.lblalert_pass1.Location = New System.Drawing.Point(36, 132)
        Me.lblalert_pass1.Name = "lblalert_pass1"
        Me.lblalert_pass1.Size = New System.Drawing.Size(106, 15)
        Me.lblalert_pass1.TabIndex = 4
        Me.lblalert_pass1.Text = "* invalid password"
        Me.lblalert_pass1.Visible = False
        '
        'RadButton2
        '
        Me.RadButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadButton2.Location = New System.Drawing.Point(72, 152)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(93, 29)
        Me.RadButton2.TabIndex = 3
        Me.RadButton2.Text = "C&ancel"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(109, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'bttncont1
        '
        Me.bttncont1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttncont1.Location = New System.Drawing.Point(171, 152)
        Me.bttncont1.Name = "bttncont1"
        Me.bttncont1.Size = New System.Drawing.Size(93, 29)
        Me.bttncont1.TabIndex = 1
        Me.bttncont1.Text = "&Continue"
        '
        'txtpassword_rec
        '
        Me.txtpassword_rec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword_rec.Location = New System.Drawing.Point(39, 100)
        Me.txtpassword_rec.Name = "txtpassword_rec"
        Me.txtpassword_rec.Size = New System.Drawing.Size(225, 26)
        Me.txtpassword_rec.TabIndex = 0
        Me.txtpassword_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpassword_rec.UseSystemPasswordChar = True
        '
        'frm_upload_savings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1222, 469)
        Me.Controls.Add(Me.pn_backdate)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpick)
        Me.Controls.Add(Me.bttncancel_uploaded)
        Me.Controls.Add(Me.bttnupload)
        Me.Controls.Add(Me.bttnrefresh)
        Me.Controls.Add(Me.dtgridsavings_coll)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_upload_savings"
        Me.ShowIcon = False
        Me.Text = "Upload Savings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgridsavings_coll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.bttnrefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnupload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncancel_uploaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_backdate.ResumeLayout(False)
        Me.pn_backdate.PerformLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncont1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgridsavings_coll As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcf As System.Windows.Forms.Label
    Friend WithEvents lblps As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bttnrefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnupload As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttncancel_uploaded As Telerik.WinControls.UI.RadButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpick As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents pn_backdate As System.Windows.Forms.Panel
    Friend WithEvents lblalert_pass1 As System.Windows.Forms.Label
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents bttncont1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtpassword_rec As System.Windows.Forms.TextBox
End Class
