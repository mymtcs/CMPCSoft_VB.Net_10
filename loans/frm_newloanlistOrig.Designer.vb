<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newloanlist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_newloanlist))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.listcntxmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewByAccountNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitpanel = New System.Windows.Forms.SplitContainer()
        Me.pn_voucher = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.dtgrid_gl = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblsavings = New System.Windows.Forms.Label()
        Me.txtnetproceeds = New System.Windows.Forms.TextBox()
        Me.lblacct_code = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttn_cont = New Telerik.WinControls.UI.RadButton()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.txtvoucher_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgridloanlist = New System.Windows.Forms.DataGridView()
        Me.rel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttncancel = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.bttnprint = New Telerik.WinControls.UI.RadDropDownButton()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.bttnrefresh = New Telerik.WinControls.UI.RadButton()
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.bttnrel = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ttlamnt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel_vouch = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtvoucher = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.bttncont = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.panel_voucher = New Telerik.WinControls.UI.RadPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.bttnok = New Telerik.WinControls.UI.RadButton()
        Me.txtref = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.listcntxmenu.SuspendLayout()
        Me.splitpanel.Panel1.SuspendLayout()
        Me.splitpanel.Panel2.SuspendLayout()
        Me.splitpanel.SuspendLayout()
        Me.pn_voucher.SuspendLayout()
        CType(Me.dtgrid_gl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttn_cont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridloanlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnrefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnrel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.panel_vouch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_vouch.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_voucher.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listcntxmenu
        '
        Me.listcntxmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewByAccountNameToolStripMenuItem})
        Me.listcntxmenu.Name = "listcntxmenu"
        Me.listcntxmenu.Size = New System.Drawing.Size(167, 26)
        '
        'ViewByAccountNameToolStripMenuItem
        '
        Me.ViewByAccountNameToolStripMenuItem.Name = "ViewByAccountNameToolStripMenuItem"
        Me.ViewByAccountNameToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ViewByAccountNameToolStripMenuItem.Text = "Customize view..."
        '
        'splitpanel
        '
        Me.splitpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitpanel.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splitpanel.IsSplitterFixed = True
        Me.splitpanel.Location = New System.Drawing.Point(0, 0)
        Me.splitpanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.splitpanel.Name = "splitpanel"
        Me.splitpanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitpanel.Panel1
        '
        Me.splitpanel.Panel1.Controls.Add(Me.pn_voucher)
        Me.splitpanel.Panel1.Controls.Add(Me.dtgridloanlist)
        Me.splitpanel.Panel1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'splitpanel.Panel2
        '
        Me.splitpanel.Panel2.AutoScroll = True
        Me.splitpanel.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.splitpanel.Panel2.Controls.Add(Me.bttncancel)
        Me.splitpanel.Panel2.Controls.Add(Me.RadButton3)
        Me.splitpanel.Panel2.Controls.Add(Me.bttnprint)
        Me.splitpanel.Panel2.Controls.Add(Me.Label3)
        Me.splitpanel.Panel2.Controls.Add(Me.txtloantype)
        Me.splitpanel.Panel2.Controls.Add(Me.bttnrefresh)
        Me.splitpanel.Panel2.Controls.Add(Me.bttnnew)
        Me.splitpanel.Panel2.Controls.Add(Me.bttnrel)
        Me.splitpanel.Panel2.Controls.Add(Me.Panel1)
        Me.splitpanel.Size = New System.Drawing.Size(1317, 509)
        Me.splitpanel.SplitterDistance = 438
        Me.splitpanel.TabIndex = 1
        '
        'pn_voucher
        '
        Me.pn_voucher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pn_voucher.BackColor = System.Drawing.Color.PowderBlue
        Me.pn_voucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pn_voucher.Controls.Add(Me.Label5)
        Me.pn_voucher.Controls.Add(Me.txtfname)
        Me.pn_voucher.Controls.Add(Me.dtgrid_gl)
        Me.pn_voucher.Controls.Add(Me.lblsavings)
        Me.pn_voucher.Controls.Add(Me.txtnetproceeds)
        Me.pn_voucher.Controls.Add(Me.lblacct_code)
        Me.pn_voucher.Controls.Add(Me.Label7)
        Me.pn_voucher.Controls.Add(Me.bttn_cont)
        Me.pn_voucher.Controls.Add(Me.RadButton4)
        Me.pn_voucher.Controls.Add(Me.txtvoucher_no)
        Me.pn_voucher.Controls.Add(Me.Label2)
        Me.pn_voucher.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pn_voucher.Location = New System.Drawing.Point(385, 50)
        Me.pn_voucher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pn_voucher.MinimumSize = New System.Drawing.Size(513, 324)
        Me.pn_voucher.Name = "pn_voucher"
        Me.pn_voucher.Size = New System.Drawing.Size(553, 362)
        Me.pn_voucher.TabIndex = 2
        Me.pn_voucher.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(18, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Release to :"
        '
        'txtfname
        '
        Me.txtfname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Blue
        Me.txtfname.Location = New System.Drawing.Point(20, 26)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.ReadOnly = True
        Me.txtfname.Size = New System.Drawing.Size(518, 26)
        Me.txtfname.TabIndex = 213
        Me.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtgrid_gl
        '
        Me.dtgrid_gl.AllowUserToAddRows = False
        Me.dtgrid_gl.AllowUserToDeleteRows = False
        Me.dtgrid_gl.AllowUserToOrderColumns = True
        Me.dtgrid_gl.AllowUserToResizeColumns = False
        Me.dtgrid_gl.AllowUserToResizeRows = False
        Me.dtgrid_gl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrid_gl.BackgroundColor = System.Drawing.Color.White
        Me.dtgrid_gl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_gl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgrid_gl.GridColor = System.Drawing.Color.Teal
        Me.dtgrid_gl.Location = New System.Drawing.Point(20, 63)
        Me.dtgrid_gl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgrid_gl.Name = "dtgrid_gl"
        Me.dtgrid_gl.ReadOnly = True
        Me.dtgrid_gl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_gl.Size = New System.Drawing.Size(518, 179)
        Me.dtgrid_gl.TabIndex = 212
        '
        'Column1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "GL Account"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "Remarks"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 170
        '
        'Column3
        '
        Me.Column3.HeaderText = "Debit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Credit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'lblsavings
        '
        Me.lblsavings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblsavings.AutoSize = True
        Me.lblsavings.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsavings.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblsavings.Location = New System.Drawing.Point(6, 326)
        Me.lblsavings.Name = "lblsavings"
        Me.lblsavings.Size = New System.Drawing.Size(44, 20)
        Me.lblsavings.TabIndex = 211
        Me.lblsavings.Text = "0.00"
        Me.lblsavings.Visible = False
        '
        'txtnetproceeds
        '
        Me.txtnetproceeds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnetproceeds.BackColor = System.Drawing.Color.Black
        Me.txtnetproceeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnetproceeds.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnetproceeds.ForeColor = System.Drawing.Color.Lime
        Me.txtnetproceeds.Location = New System.Drawing.Point(20, 268)
        Me.txtnetproceeds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnetproceeds.Name = "txtnetproceeds"
        Me.txtnetproceeds.ReadOnly = True
        Me.txtnetproceeds.Size = New System.Drawing.Size(189, 33)
        Me.txtnetproceeds.TabIndex = 209
        Me.txtnetproceeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblacct_code
        '
        Me.lblacct_code.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblacct_code.AutoSize = True
        Me.lblacct_code.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblacct_code.Location = New System.Drawing.Point(7, 310)
        Me.lblacct_code.Name = "lblacct_code"
        Me.lblacct_code.Size = New System.Drawing.Size(20, 16)
        Me.lblacct_code.TabIndex = 208
        Me.lblacct_code.Text = "...."
        Me.lblacct_code.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(17, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "Net Proceeds :"
        '
        'bttn_cont
        '
        Me.bttn_cont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttn_cont.Enabled = False
        Me.bttn_cont.Image = CType(resources.GetObject("bttn_cont.Image"), System.Drawing.Image)
        Me.bttn_cont.Location = New System.Drawing.Point(307, 312)
        Me.bttn_cont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bttn_cont.Name = "bttn_cont"
        Me.bttn_cont.Size = New System.Drawing.Size(135, 34)
        Me.bttn_cont.TabIndex = 202
        Me.bttn_cont.Text = "Release Loan"
        '
        'RadButton4
        '
        Me.RadButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton4.Image = CType(resources.GetObject("RadButton4.Image"), System.Drawing.Image)
        Me.RadButton4.Location = New System.Drawing.Point(451, 312)
        Me.RadButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(87, 34)
        Me.RadButton4.TabIndex = 201
        Me.RadButton4.Text = "Close"
        '
        'txtvoucher_no
        '
        Me.txtvoucher_no.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvoucher_no.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvoucher_no.ForeColor = System.Drawing.Color.Red
        Me.txtvoucher_no.Location = New System.Drawing.Point(239, 268)
        Me.txtvoucher_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvoucher_no.Name = "txtvoucher_no"
        Me.txtvoucher_no.Size = New System.Drawing.Size(299, 31)
        Me.txtvoucher_no.TabIndex = 1
        Me.txtvoucher_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(236, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Voucher No :"
        '
        'dtgridloanlist
        '
        Me.dtgridloanlist.AllowUserToAddRows = False
        Me.dtgridloanlist.AllowUserToDeleteRows = False
        Me.dtgridloanlist.AllowUserToOrderColumns = True
        Me.dtgridloanlist.AllowUserToResizeColumns = False
        Me.dtgridloanlist.AllowUserToResizeRows = False
        Me.dtgridloanlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridloanlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridloanlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rel, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dtgridloanlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgridloanlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgridloanlist.Location = New System.Drawing.Point(0, 0)
        Me.dtgridloanlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgridloanlist.Name = "dtgridloanlist"
        Me.dtgridloanlist.ReadOnly = True
        Me.dtgridloanlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridloanlist.Size = New System.Drawing.Size(1317, 438)
        Me.dtgridloanlist.TabIndex = 213
        '
        'rel
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = False
        Me.rel.DefaultCellStyle = DataGridViewCellStyle2
        Me.rel.HeaderText = ""
        Me.rel.Name = "rel"
        Me.rel.ReadOnly = True
        Me.rel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.rel.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Member ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Loan ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Members Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 230
        '
        'Column5
        '
        Me.Column5.HeaderText = "Release Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Loan Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Savings Account"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 140
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 140
        '
        'Column9
        '
        Me.Column9.HeaderText = "Net Proceeds"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 120
        '
        'Column10
        '
        Me.Column10.HeaderText = "CBU"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "Sub Product"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 170
        '
        'bttncancel
        '
        Me.bttncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttncancel.Image = CType(resources.GetObject("bttncancel.Image"), System.Drawing.Image)
        Me.bttncancel.Location = New System.Drawing.Point(842, 15)
        Me.bttncancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(86, 34)
        Me.bttncancel.TabIndex = 210
        Me.bttncancel.Text = "Cancel"
        '
        'RadButton3
        '
        Me.RadButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton3.Image = CType(resources.GetObject("RadButton3.Image"), System.Drawing.Image)
        Me.RadButton3.Location = New System.Drawing.Point(592, 15)
        Me.RadButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(125, 34)
        Me.RadButton3.TabIndex = 209
        Me.RadButton3.Text = "Add Comaker"
        '
        'bttnprint
        '
        Me.bttnprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnprint.Enabled = False
        Me.bttnprint.Image = CType(resources.GetObject("bttnprint.Image"), System.Drawing.Image)
        Me.bttnprint.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItem2, Me.RadMenuItem3, Me.RadMenuItem4})
        Me.bttnprint.Location = New System.Drawing.Point(723, 14)
        Me.bttnprint.Name = "bttnprint"
        Me.bttnprint.Size = New System.Drawing.Size(113, 35)
        Me.bttnprint.TabIndex = 208
        Me.bttnprint.Text = "Print"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.AccessibleDescription = "Cash Voucher"
        Me.RadMenuItem1.AccessibleName = "Cash Voucher"
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "Cash Voucher"
        Me.RadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem2
        '
        Me.RadMenuItem2.AccessibleDescription = "Disclosure Statement"
        Me.RadMenuItem2.AccessibleName = "Disclosure Statement"
        Me.RadMenuItem2.Name = "RadMenuItem2"
        Me.RadMenuItem2.Text = "Disclosure Statement"
        Me.RadMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem3
        '
        Me.RadMenuItem3.AccessibleDescription = "Amortization Schedule"
        Me.RadMenuItem3.AccessibleName = "Amortization Schedule"
        Me.RadMenuItem3.Name = "RadMenuItem3"
        Me.RadMenuItem3.Text = "Amortization Schedule"
        Me.RadMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem4
        '
        Me.RadMenuItem4.AccessibleDescription = "Promissory Note"
        Me.RadMenuItem4.AccessibleName = "Promissory Note"
        Me.RadMenuItem4.Name = "RadMenuItem4"
        Me.RadMenuItem4.Text = "Promissory Note"
        Me.RadMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "Select Loan Type"
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
        Me.txtloantype.Location = New System.Drawing.Point(199, 20)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(196, 27)
        Me.txtloantype.TabIndex = 203
        Me.txtloantype.TabStop = False
        '
        'bttnrefresh
        '
        Me.bttnrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnrefresh.Image = CType(resources.GetObject("bttnrefresh.Image"), System.Drawing.Image)
        Me.bttnrefresh.Location = New System.Drawing.Point(106, 15)
        Me.bttnrefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bttnrefresh.Name = "bttnrefresh"
        Me.bttnrefresh.Size = New System.Drawing.Size(87, 34)
        Me.bttnrefresh.TabIndex = 202
        Me.bttnrefresh.Text = "&Refresh"
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.Location = New System.Drawing.Point(12, 15)
        Me.bttnnew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(87, 34)
        Me.bttnnew.TabIndex = 196
        Me.bttnnew.Text = "New"
        '
        'bttnrel
        '
        Me.bttnrel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnrel.Enabled = False
        Me.bttnrel.Image = CType(resources.GetObject("bttnrel.Image"), System.Drawing.Image)
        Me.bttnrel.Location = New System.Drawing.Point(407, 15)
        Me.bttnrel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bttnrel.Name = "bttnrel"
        Me.bttnrel.Size = New System.Drawing.Size(110, 34)
        Me.bttnrel.TabIndex = 200
        Me.bttnrel.Text = "       View Voucher "
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbl_ttlamnt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(980, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 38)
        Me.Panel1.TabIndex = 35
        '
        'lbl_ttlamnt
        '
        Me.lbl_ttlamnt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_ttlamnt.AutoSize = True
        Me.lbl_ttlamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ttlamnt.ForeColor = System.Drawing.Color.Lime
        Me.lbl_ttlamnt.Location = New System.Drawing.Point(134, 5)
        Me.lbl_ttlamnt.Name = "lbl_ttlamnt"
        Me.lbl_ttlamnt.Size = New System.Drawing.Size(58, 25)
        Me.lbl_ttlamnt.TabIndex = 0
        Me.lbl_ttlamnt.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total Amount :"
        '
        'panel_vouch
        '
        Me.panel_vouch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_vouch.BackColor = System.Drawing.Color.AliceBlue
        Me.panel_vouch.Controls.Add(Me.RadLabel1)
        Me.panel_vouch.Controls.Add(Me.txtvoucher)
        Me.panel_vouch.Controls.Add(Me.bttncont)
        Me.panel_vouch.Controls.Add(Me.RadButton2)
        Me.panel_vouch.Location = New System.Drawing.Point(480, 188)
        Me.panel_vouch.Name = "panel_vouch"
        Me.panel_vouch.Size = New System.Drawing.Size(313, 153)
        Me.panel_vouch.TabIndex = 1
        Me.panel_vouch.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(3, 3)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel1.TabIndex = 203
        Me.RadLabel1.Text = "Cash Voucher"
        '
        'txtvoucher
        '
        Me.txtvoucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvoucher.BackColor = System.Drawing.Color.AliceBlue
        Me.txtvoucher.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvoucher.Location = New System.Drawing.Point(16, 46)
        Me.txtvoucher.Name = "txtvoucher"
        Me.txtvoucher.Size = New System.Drawing.Size(281, 40)
        Me.txtvoucher.TabIndex = 202
        '
        'bttncont
        '
        Me.bttncont.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bttncont.Location = New System.Drawing.Point(117, 101)
        Me.bttncont.Name = "bttncont"
        Me.bttncont.Size = New System.Drawing.Size(87, 35)
        Me.bttncont.TabIndex = 201
        Me.bttncont.Text = "Continue"
        '
        'RadButton2
        '
        Me.RadButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadButton2.Location = New System.Drawing.Point(210, 101)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(87, 35)
        Me.RadButton2.TabIndex = 200
        Me.RadButton2.Text = "Cancel"
        '
        'panel_voucher
        '
        Me.panel_voucher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_voucher.BackColor = System.Drawing.Color.AliceBlue
        Me.panel_voucher.Controls.Add(Me.Label1)
        Me.panel_voucher.Controls.Add(Me.RadButton1)
        Me.panel_voucher.Controls.Add(Me.bttnok)
        Me.panel_voucher.Controls.Add(Me.txtref)
        Me.panel_voucher.Location = New System.Drawing.Point(443, 205)
        Me.panel_voucher.Name = "panel_voucher"
        Me.panel_voucher.Size = New System.Drawing.Size(459, 236)
        Me.panel_voucher.TabIndex = 0
        Me.panel_voucher.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Voucher Number :"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(93, 144)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(101, 52)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "CANCEL"
        '
        'bttnok
        '
        Me.bttnok.Location = New System.Drawing.Point(292, 144)
        Me.bttnok.Name = "bttnok"
        Me.bttnok.Size = New System.Drawing.Size(101, 52)
        Me.bttnok.TabIndex = 1
        Me.bttnok.Text = "RELEASE"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(93, 80)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(300, 39)
        Me.txtref.TabIndex = 0
        '
        'frm_newloanlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1317, 509)
        Me.Controls.Add(Me.splitpanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_newloanlist"
        Me.ShowIcon = False
        Me.Text = "List of New Loans"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.listcntxmenu.ResumeLayout(False)
        Me.splitpanel.Panel1.ResumeLayout(False)
        Me.splitpanel.Panel2.ResumeLayout(False)
        Me.splitpanel.Panel2.PerformLayout()
        Me.splitpanel.ResumeLayout(False)
        Me.pn_voucher.ResumeLayout(False)
        Me.pn_voucher.PerformLayout()
        CType(Me.dtgrid_gl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttn_cont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridloanlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnrefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnrel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.panel_vouch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_vouch.ResumeLayout(False)
        Me.panel_vouch.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_voucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_voucher.ResumeLayout(False)
        Me.panel_voucher.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitpanel As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_ttlamnt As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents listcntxmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewByAccountNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnrel As Telerik.WinControls.UI.RadButton
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents panel_voucher As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtref As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents bttnok As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panel_vouch As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtvoucher As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents bttncont As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents pn_voucher As System.Windows.Forms.Panel
    Friend WithEvents bttn_cont As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtvoucher_no As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblacct_code As System.Windows.Forms.Label
    Friend WithEvents txtnetproceeds As System.Windows.Forms.TextBox
    Friend WithEvents lblsavings As System.Windows.Forms.Label
    Friend WithEvents dtgrid_gl As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bttnrefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents dtgridloanlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttnprint As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem3 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem4 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttncancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents rel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
