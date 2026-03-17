<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cashiering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cashiering))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtgl_view1 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.chkrec_remarks = New Telerik.WinControls.UI.RadRadioButton()
        Me.chkrec_payee = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblref_cb_rec = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_cb_rec = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_receiptsamnt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_receipts = New System.Windows.Forms.DateTimePicker()
        Me.pnadd = New System.Windows.Forms.Panel()
        Me.lstcbu = New System.Windows.Forms.ListView()
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblnotcbu = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lst_stockrel = New System.Windows.Forms.ListView()
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblstock = New System.Windows.Forms.Label()
        Me.lbleditamnt = New System.Windows.Forms.LinkLabel()
        Me.lbleditgl = New System.Windows.Forms.LinkLabel()
        Me.lstnot = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblnot = New System.Windows.Forms.Label()
        Me.txtgl = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtacctref = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtpayee = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.bttnsave_receipt = New Telerik.WinControls.UI.RadButton()
        Me.bttnclose_rec = New Telerik.WinControls.UI.RadButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_ref = New System.Windows.Forms.TextBox()
        Me.pnreceipts = New System.Windows.Forms.Panel()
        Me.lblalert_pass1 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.bttncont1 = New Telerik.WinControls.UI.RadButton()
        Me.txtpassword_rec = New System.Windows.Forms.TextBox()
        Me.dtgridblotter = New System.Windows.Forms.DataGridView()
        Me.rel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnnumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txtgl_view2 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.chkdis_remarks = New Telerik.WinControls.UI.RadRadioButton()
        Me.chkdis_payee = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblref_cb_dis = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cb_dis = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblpaymentamnt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_disburse = New System.Windows.Forms.DateTimePicker()
        Me.pnadd1 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lstcbu1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblcbu1 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lbleditamnt1 = New System.Windows.Forms.LinkLabel()
        Me.lbleditgl1 = New System.Windows.Forms.LinkLabel()
        Me.lstnot1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblnot1 = New System.Windows.Forms.Label()
        Me.txtgl1 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtacct_ref1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtremarks1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtamount1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtpayee1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.bttnsave_dis = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtref1 = New System.Windows.Forms.TextBox()
        Me.pndes = New System.Windows.Forms.Panel()
        Me.lblalert_des = New System.Windows.Forms.Label()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bttncont2 = New Telerik.WinControls.UI.RadButton()
        Me.txtpass_dess = New System.Windows.Forms.TextBox()
        Me.dtgrid_disburse = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnunclose_password = New System.Windows.Forms.Panel()
        Me.lblinvalipassword = New System.Windows.Forms.Label()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.txt_trnpassword = New System.Windows.Forms.TextBox()
        Me.lnkunclosed = New System.Windows.Forms.LinkLabel()
        Me.bttnview = New Telerik.WinControls.UI.RadButton()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.bttnclose_trnx = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bttncompute = New Telerik.WinControls.UI.RadButton()
        Me.txtonethousand = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_centfive = New System.Windows.Forms.TextBox()
        Me.txtfivehundred = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_tencent = New System.Windows.Forms.TextBox()
        Me.txttwohundred = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtonehundred = New System.Windows.Forms.TextBox()
        Me.lblvariance = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtfifty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.txttwenty = New System.Windows.Forms.TextBox()
        Me.txtcheck = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.lbltotalden = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtfive = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcent = New System.Windows.Forms.TextBox()
        Me.txtone = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bttnprintCB = New Telerik.WinControls.UI.RadButton()
        Me.dtden = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView2 = New Telerik.WinControls.UI.RadPageView()
        Me.rad_reciepts = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rad_disburse = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rad_summary = New Telerik.WinControls.UI.RadPageViewPage()
        Me.bttnrefresh = New Telerik.WinControls.UI.RadButton()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblcredit = New System.Windows.Forms.Label()
        Me.lbldebit = New System.Windows.Forms.Label()
        Me.dtgrd_summary = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtgl_view1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl_view1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl_view1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkrec_remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkrec_payee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnadd.SuspendLayout()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave_receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnclose_rec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnreceipts.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncont1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridblotter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.txtgl_view2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl_view2.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl_view2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdis_remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdis_payee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnadd1.SuspendLayout()
        CType(Me.txtgl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave_dis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pndes.SuspendLayout()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncont2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid_disburse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnunclose_password.SuspendLayout()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        CType(Me.bttnclose_trnx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncompute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnprintCB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.RadPageView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView2.SuspendLayout()
        Me.rad_reciepts.SuspendLayout()
        Me.rad_disburse.SuspendLayout()
        Me.rad_summary.SuspendLayout()
        CType(Me.bttnrefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrd_summary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtgl_view1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label40)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkrec_remarks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkrec_payee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblref_cb_rec)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label26)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_cb_rec)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dt_receipts)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnadd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnreceipts)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtgridblotter)
        Me.SplitContainer1.Size = New System.Drawing.Size(2232, 732)
        Me.SplitContainer1.SplitterDistance = 67
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'txtgl_view1
        '
        Me.txtgl_view1.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        'txtgl_view1.NestedRadGridView
        '
        Me.txtgl_view1.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtgl_view1.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgl_view1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgl_view1.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtgl_view1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtgl_view1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtgl_view1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtgl_view1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtgl_view1.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtgl_view1.EditorControl.Name = "NestedRadGridView"
        Me.txtgl_view1.EditorControl.ReadOnly = True
        '
        '
        '
        Me.txtgl_view1.EditorControl.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 240, 150)
        Me.txtgl_view1.EditorControl.ShowGroupPanel = False
        Me.txtgl_view1.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl_view1.EditorControl.TabIndex = 0
        Me.txtgl_view1.Location = New System.Drawing.Point(761, 20)
        Me.txtgl_view1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtgl_view1.Name = "txtgl_view1"
        '
        '
        '
        Me.txtgl_view1.RootElement.ControlBounds = New System.Drawing.Rectangle(571, 16, 100, 20)
        Me.txtgl_view1.Size = New System.Drawing.Size(305, 30)
        Me.txtgl_view1.TabIndex = 49
        Me.txtgl_view1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(876, 0)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(51, 17)
        Me.LinkLabel1.TabIndex = 222
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(757, 6)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(100, 17)
        Me.Label40.TabIndex = 50
        Me.Label40.Text = "View by account"
        '
        'chkrec_remarks
        '
        Me.chkrec_remarks.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrec_remarks.Location = New System.Drawing.Point(256, 0)
        Me.chkrec_remarks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkrec_remarks.Name = "chkrec_remarks"
        '
        '
        '
        Me.chkrec_remarks.RootElement.ControlBounds = New System.Drawing.Rectangle(192, 0, 110, 18)
        Me.chkrec_remarks.RootElement.StretchHorizontally = True
        Me.chkrec_remarks.RootElement.StretchVertically = True
        Me.chkrec_remarks.Size = New System.Drawing.Size(135, 22)
        Me.chkrec_remarks.TabIndex = 48
        Me.chkrec_remarks.Text = "Search by remarks"
        '
        'chkrec_payee
        '
        Me.chkrec_payee.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrec_payee.Location = New System.Drawing.Point(413, -1)
        Me.chkrec_payee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkrec_payee.Name = "chkrec_payee"
        '
        '
        '
        Me.chkrec_payee.RootElement.ControlBounds = New System.Drawing.Rectangle(310, -1, 110, 18)
        Me.chkrec_payee.RootElement.StretchHorizontally = True
        Me.chkrec_payee.RootElement.StretchVertically = True
        Me.chkrec_payee.Size = New System.Drawing.Size(123, 22)
        Me.chkrec_payee.TabIndex = 47
        Me.chkrec_payee.TabStop = True
        Me.chkrec_payee.Text = "Search by payee"
        Me.chkrec_payee.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblref_cb_rec
        '
        Me.lblref_cb_rec.AutoSize = True
        Me.lblref_cb_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblref_cb_rec.ForeColor = System.Drawing.Color.Olive
        Me.lblref_cb_rec.Location = New System.Drawing.Point(680, 4)
        Me.lblref_cb_rec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblref_cb_rec.Name = "lblref_cb_rec"
        Me.lblref_cb_rec.Size = New System.Drawing.Size(32, 17)
        Me.lblref_cb_rec.TabIndex = 46
        Me.lblref_cb_rec.Text = "000"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Olive
        Me.Label26.Location = New System.Drawing.Point(580, 2)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 17)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Ref #. Found :"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(179, 28)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 18)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Search :"
        '
        'txt_cb_rec
        '
        Me.txt_cb_rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cb_rec.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cb_rec.Location = New System.Drawing.Point(256, 22)
        Me.txt_cb_rec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cb_rec.Name = "txt_cb_rec"
        Me.txt_cb_rec.Size = New System.Drawing.Size(418, 27)
        Me.txt_cb_rec.TabIndex = 40
        Me.txt_cb_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbl_receiptsamnt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(1842, 17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 38)
        Me.Panel1.TabIndex = 34
        '
        'lbl_receiptsamnt
        '
        Me.lbl_receiptsamnt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_receiptsamnt.AutoSize = True
        Me.lbl_receiptsamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_receiptsamnt.ForeColor = System.Drawing.Color.Lime
        Me.lbl_receiptsamnt.Location = New System.Drawing.Point(163, 7)
        Me.lbl_receiptsamnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_receiptsamnt.Name = "lbl_receiptsamnt"
        Me.lbl_receiptsamnt.Size = New System.Drawing.Size(62, 29)
        Me.lbl_receiptsamnt.TabIndex = 0
        Me.lbl_receiptsamnt.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total Amount :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Gen Date :"
        '
        'dt_receipts
        '
        Me.dt_receipts.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dt_receipts.Enabled = False
        Me.dt_receipts.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_receipts.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_receipts.Location = New System.Drawing.Point(5, 28)
        Me.dt_receipts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dt_receipts.Name = "dt_receipts"
        Me.dt_receipts.Size = New System.Drawing.Size(148, 27)
        Me.dt_receipts.TabIndex = 36
        Me.dt_receipts.Value = New Date(2015, 2, 6, 0, 0, 0, 0)
        '
        'pnadd
        '
        Me.pnadd.BackColor = System.Drawing.Color.White
        Me.pnadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnadd.Controls.Add(Me.lstcbu)
        Me.pnadd.Controls.Add(Me.lblnotcbu)
        Me.pnadd.Controls.Add(Me.Label44)
        Me.pnadd.Controls.Add(Me.Label43)
        Me.pnadd.Controls.Add(Me.Label42)
        Me.pnadd.Controls.Add(Me.lst_stockrel)
        Me.pnadd.Controls.Add(Me.lblstock)
        Me.pnadd.Controls.Add(Me.lbleditamnt)
        Me.pnadd.Controls.Add(Me.lbleditgl)
        Me.pnadd.Controls.Add(Me.lstnot)
        Me.pnadd.Controls.Add(Me.lblnot)
        Me.pnadd.Controls.Add(Me.txtgl)
        Me.pnadd.Controls.Add(Me.Panel7)
        Me.pnadd.Controls.Add(Me.Label27)
        Me.pnadd.Controls.Add(Me.txtacctref)
        Me.pnadd.Controls.Add(Me.Label36)
        Me.pnadd.Controls.Add(Me.txtremarks)
        Me.pnadd.Controls.Add(Me.Label35)
        Me.pnadd.Controls.Add(Me.txtamount)
        Me.pnadd.Controls.Add(Me.Label34)
        Me.pnadd.Controls.Add(Me.txtpayee)
        Me.pnadd.Controls.Add(Me.Label33)
        Me.pnadd.Controls.Add(Me.bttnsave_receipt)
        Me.pnadd.Controls.Add(Me.bttnclose_rec)
        Me.pnadd.Controls.Add(Me.Label30)
        Me.pnadd.Controls.Add(Me.txt_ref)
        Me.pnadd.Location = New System.Drawing.Point(561, 5)
        Me.pnadd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnadd.Name = "pnadd"
        Me.pnadd.Size = New System.Drawing.Size(563, 411)
        Me.pnadd.TabIndex = 49
        Me.pnadd.Visible = False
        '
        'lstcbu
        '
        Me.lstcbu.BackColor = System.Drawing.Color.Ivory
        Me.lstcbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstcbu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32})
        Me.lstcbu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcbu.FullRowSelect = True
        Me.lstcbu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstcbu.Location = New System.Drawing.Point(35, 75)
        Me.lstcbu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstcbu.Name = "lstcbu"
        Me.lstcbu.Size = New System.Drawing.Size(387, 307)
        Me.lstcbu.TabIndex = 69
        Me.lstcbu.UseCompatibleStateImageBehavior = False
        Me.lstcbu.View = System.Windows.Forms.View.Details
        Me.lstcbu.Visible = False
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Width = 70
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Payee"
        Me.ColumnHeader26.Width = 120
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Width = 100
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Width = 100
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Width = 0
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Width = 0
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Width = 0
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Width = 0
        '
        'lblnotcbu
        '
        Me.lblnotcbu.AutoSize = True
        Me.lblnotcbu.BackColor = System.Drawing.Color.Red
        Me.lblnotcbu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblnotcbu.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotcbu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblnotcbu.Location = New System.Drawing.Point(403, 55)
        Me.lblnotcbu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnotcbu.Name = "lblnotcbu"
        Me.lblnotcbu.Size = New System.Drawing.Size(19, 21)
        Me.lblnotcbu.TabIndex = 68
        Me.lblnotcbu.Text = "0"
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(399, 37)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 17)
        Me.Label44.TabIndex = 67
        Me.Label44.Text = "CBU"
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(367, 37)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(22, 17)
        Me.Label43.TabIndex = 66
        Me.Label43.Text = "SR"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(331, 37)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(22, 17)
        Me.Label42.TabIndex = 65
        Me.Label42.Text = "SA"
        '
        'lst_stockrel
        '
        Me.lst_stockrel.BackColor = System.Drawing.Color.Ivory
        Me.lst_stockrel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_stockrel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.lst_stockrel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_stockrel.FullRowSelect = True
        Me.lst_stockrel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lst_stockrel.Location = New System.Drawing.Point(4, 75)
        Me.lst_stockrel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_stockrel.Name = "lst_stockrel"
        Me.lst_stockrel.Size = New System.Drawing.Size(387, 307)
        Me.lst_stockrel.TabIndex = 64
        Me.lst_stockrel.UseCompatibleStateImageBehavior = False
        Me.lst_stockrel.View = System.Windows.Forms.View.Details
        Me.lst_stockrel.Visible = False
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Payee"
        Me.ColumnHeader18.Width = 50
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Width = 110
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Width = 100
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Width = 0
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Width = 0
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Width = 0
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Width = 0
        '
        'lblstock
        '
        Me.lblstock.AutoSize = True
        Me.lblstock.BackColor = System.Drawing.Color.Red
        Me.lblstock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblstock.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblstock.Location = New System.Drawing.Point(369, 55)
        Me.lblstock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(19, 21)
        Me.lblstock.TabIndex = 63
        Me.lblstock.Text = "0"
        '
        'lbleditamnt
        '
        Me.lbleditamnt.AutoSize = True
        Me.lbleditamnt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleditamnt.Location = New System.Drawing.Point(504, 310)
        Me.lbleditamnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbleditamnt.Name = "lbleditamnt"
        Me.lbleditamnt.Size = New System.Drawing.Size(32, 19)
        Me.lbleditamnt.TabIndex = 62
        Me.lbleditamnt.TabStop = True
        Me.lbleditamnt.Text = "Edit"
        '
        'lbleditgl
        '
        Me.lbleditgl.AutoSize = True
        Me.lbleditgl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleditgl.Location = New System.Drawing.Point(504, 245)
        Me.lbleditgl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbleditgl.Name = "lbleditgl"
        Me.lbleditgl.Size = New System.Drawing.Size(32, 19)
        Me.lbleditgl.TabIndex = 61
        Me.lbleditgl.TabStop = True
        Me.lbleditgl.Text = "Edit"
        '
        'lstnot
        '
        Me.lstnot.BackColor = System.Drawing.Color.Ivory
        Me.lstnot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstnot.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader13, Me.ColumnHeader15})
        Me.lstnot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstnot.FullRowSelect = True
        Me.lstnot.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstnot.Location = New System.Drawing.Point(4, 75)
        Me.lstnot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstnot.Name = "lstnot"
        Me.lstnot.Size = New System.Drawing.Size(343, 307)
        Me.lstnot.TabIndex = 60
        Me.lstnot.UseCompatibleStateImageBehavior = False
        Me.lstnot.View = System.Windows.Forms.View.Details
        Me.lstnot.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Payee"
        Me.ColumnHeader2.Width = 185
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Width = 0
        '
        'lblnot
        '
        Me.lblnot.AutoSize = True
        Me.lblnot.BackColor = System.Drawing.Color.Red
        Me.lblnot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblnot.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblnot.Location = New System.Drawing.Point(337, 55)
        Me.lblnot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnot.Name = "lblnot"
        Me.lblnot.Size = New System.Drawing.Size(19, 21)
        Me.lblnot.TabIndex = 49
        Me.lblnot.Text = "0"
        '
        'txtgl
        '
        Me.txtgl.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        'txtgl.NestedRadGridView
        '
        Me.txtgl.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtgl.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgl.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgl.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtgl.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtgl.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtgl.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtgl.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtgl.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtgl.EditorControl.Name = "NestedRadGridView"
        Me.txtgl.EditorControl.ReadOnly = True
        '
        '
        '
        Me.txtgl.EditorControl.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 240, 150)
        Me.txtgl.EditorControl.ShowGroupPanel = False
        Me.txtgl.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl.EditorControl.TabIndex = 0
        Me.txtgl.Location = New System.Drawing.Point(53, 242)
        Me.txtgl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtgl.Name = "txtgl"
        '
        '
        '
        Me.txtgl.RootElement.ControlBounds = New System.Drawing.Rectangle(40, 197, 100, 20)
        Me.txtgl.Size = New System.Drawing.Size(451, 31)
        Me.txtgl.TabIndex = 59
        Me.txtgl.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel7.Location = New System.Drawing.Point(0, 1)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(563, 16)
        Me.Panel7.TabIndex = 50
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label27.Location = New System.Drawing.Point(49, 288)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 18)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Account Reference :"
        '
        'txtacctref
        '
        Me.txtacctref.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacctref.Location = New System.Drawing.Point(53, 310)
        Me.txtacctref.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtacctref.Name = "txtacctref"
        Me.txtacctref.Size = New System.Drawing.Size(201, 29)
        Me.txtacctref.TabIndex = 45
        Me.txtacctref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label36.Location = New System.Drawing.Point(49, 164)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 18)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "Remarks :"
        '
        'txtremarks
        '
        Me.txtremarks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(53, 186)
        Me.txtremarks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(449, 29)
        Me.txtremarks.TabIndex = 44
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label35.Location = New System.Drawing.Point(347, 288)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 18)
        Me.Label35.TabIndex = 54
        Me.Label35.Text = "Amount Receive:"
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtamount.Location = New System.Drawing.Point(265, 310)
        Me.txtamount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(232, 39)
        Me.txtamount.TabIndex = 46
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label34.Location = New System.Drawing.Point(49, 100)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 18)
        Me.Label34.TabIndex = 52
        Me.Label34.Text = "Payee :"
        '
        'txtpayee
        '
        Me.txtpayee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayee.Location = New System.Drawing.Point(53, 122)
        Me.txtpayee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpayee.Name = "txtpayee"
        Me.txtpayee.Size = New System.Drawing.Size(449, 29)
        Me.txtpayee.TabIndex = 42
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label33.Location = New System.Drawing.Point(49, 220)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 18)
        Me.Label33.TabIndex = 50
        Me.Label33.Text = "GL Account :"
        '
        'bttnsave_receipt
        '
        Me.bttnsave_receipt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnsave_receipt.Location = New System.Drawing.Point(265, 359)
        Me.bttnsave_receipt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnsave_receipt.Name = "bttnsave_receipt"
        '
        '
        '
        Me.bttnsave_receipt.RootElement.ControlBounds = New System.Drawing.Rectangle(199, 292, 110, 24)
        Me.bttnsave_receipt.Size = New System.Drawing.Size(113, 38)
        Me.bttnsave_receipt.TabIndex = 47
        Me.bttnsave_receipt.Text = "Save"
        '
        'bttnclose_rec
        '
        Me.bttnclose_rec.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnclose_rec.Location = New System.Drawing.Point(387, 359)
        Me.bttnclose_rec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnclose_rec.Name = "bttnclose_rec"
        '
        '
        '
        Me.bttnclose_rec.RootElement.ControlBounds = New System.Drawing.Rectangle(290, 292, 110, 24)
        Me.bttnclose_rec.Size = New System.Drawing.Size(113, 38)
        Me.bttnclose_rec.TabIndex = 48
        Me.bttnclose_rec.Text = "Close"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label30.Location = New System.Drawing.Point(49, 34)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 18)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "Reference :"
        '
        'txt_ref
        '
        Me.txt_ref.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ref.Location = New System.Drawing.Point(53, 57)
        Me.txt_ref.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Size = New System.Drawing.Size(277, 29)
        Me.txt_ref.TabIndex = 41
        Me.txt_ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnreceipts
        '
        Me.pnreceipts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnreceipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnreceipts.Controls.Add(Me.lblalert_pass1)
        Me.pnreceipts.Controls.Add(Me.RadButton1)
        Me.pnreceipts.Controls.Add(Me.PictureBox3)
        Me.pnreceipts.Controls.Add(Me.bttncont1)
        Me.pnreceipts.Controls.Add(Me.txtpassword_rec)
        Me.pnreceipts.Location = New System.Drawing.Point(621, 43)
        Me.pnreceipts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnreceipts.Name = "pnreceipts"
        Me.pnreceipts.Size = New System.Drawing.Size(425, 360)
        Me.pnreceipts.TabIndex = 51
        Me.pnreceipts.Visible = False
        '
        'lblalert_pass1
        '
        Me.lblalert_pass1.AutoSize = True
        Me.lblalert_pass1.ForeColor = System.Drawing.Color.Red
        Me.lblalert_pass1.Location = New System.Drawing.Point(53, 219)
        Me.lblalert_pass1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblalert_pass1.Name = "lblalert_pass1"
        Me.lblalert_pass1.Size = New System.Drawing.Size(120, 19)
        Me.lblalert_pass1.TabIndex = 4
        Me.lblalert_pass1.Text = "* invalid password"
        Me.lblalert_pass1.Visible = False
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadButton1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton1.Location = New System.Drawing.Point(107, 278)
        Me.RadButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButton1.Name = "RadButton1"
        '
        '
        '
        Me.RadButton1.RootElement.ControlBounds = New System.Drawing.Rectangle(80, 226, 110, 24)
        Me.RadButton1.Size = New System.Drawing.Size(124, 36)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "C&ancel"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(151, 60)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 98)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'bttncont1
        '
        Me.bttncont1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttncont1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttncont1.Location = New System.Drawing.Point(239, 278)
        Me.bttncont1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttncont1.Name = "bttncont1"
        '
        '
        '
        Me.bttncont1.RootElement.ControlBounds = New System.Drawing.Rectangle(179, 226, 110, 24)
        Me.bttncont1.Size = New System.Drawing.Size(124, 36)
        Me.bttncont1.TabIndex = 1
        Me.bttncont1.Text = "&Continue"
        '
        'txtpassword_rec
        '
        Me.txtpassword_rec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword_rec.Location = New System.Drawing.Point(57, 180)
        Me.txtpassword_rec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpassword_rec.Name = "txtpassword_rec"
        Me.txtpassword_rec.Size = New System.Drawing.Size(299, 30)
        Me.txtpassword_rec.TabIndex = 0
        Me.txtpassword_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpassword_rec.UseSystemPasswordChar = True
        '
        'dtgridblotter
        '
        Me.dtgridblotter.AllowUserToAddRows = False
        Me.dtgridblotter.AllowUserToDeleteRows = False
        Me.dtgridblotter.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgridblotter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridblotter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rel, Me.memcode, Me.pnnumber, Me.Column4, Me.Column5, Me.Column8, Me.Column1, Me.Column6})
        Me.dtgridblotter.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtgridblotter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgridblotter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgridblotter.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgridblotter.Location = New System.Drawing.Point(0, 0)
        Me.dtgridblotter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgridblotter.Name = "dtgridblotter"
        Me.dtgridblotter.ReadOnly = True
        Me.dtgridblotter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridblotter.Size = New System.Drawing.Size(2232, 664)
        Me.dtgridblotter.TabIndex = 1
        '
        'rel
        '
        Me.rel.HeaderText = "Reference No."
        Me.rel.Name = "rel"
        Me.rel.ReadOnly = True
        Me.rel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rel.Width = 130
        '
        'memcode
        '
        Me.memcode.HeaderText = "Payee"
        Me.memcode.Name = "memcode"
        Me.memcode.ReadOnly = True
        Me.memcode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.memcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.memcode.Width = 200
        '
        'pnnumber
        '
        Me.pnnumber.HeaderText = "Remarks"
        Me.pnnumber.Name = "pnnumber"
        Me.pnnumber.ReadOnly = True
        Me.pnnumber.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pnnumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.pnnumber.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 90
        '
        'Column5
        '
        Me.Column5.HeaderText = "Account Reference"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "GL Account"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "User ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 76)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtgl_view2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label41)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chkdis_remarks)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chkdis_payee)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblref_cb_dis)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label28)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txt_cb_dis)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dt_disburse)
        Me.SplitContainer2.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnadd1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.pndes)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dtgrid_disburse)
        Me.SplitContainer2.Size = New System.Drawing.Size(2232, 732)
        Me.SplitContainer2.SplitterDistance = 69
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 1
        '
        'txtgl_view2
        '
        Me.txtgl_view2.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        'txtgl_view2.NestedRadGridView
        '
        Me.txtgl_view2.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtgl_view2.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgl_view2.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgl_view2.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtgl_view2.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtgl_view2.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtgl_view2.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtgl_view2.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtgl_view2.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtgl_view2.EditorControl.Name = "NestedRadGridView"
        Me.txtgl_view2.EditorControl.ReadOnly = True
        '
        '
        '
        Me.txtgl_view2.EditorControl.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 240, 150)
        Me.txtgl_view2.EditorControl.ShowGroupPanel = False
        Me.txtgl_view2.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl_view2.EditorControl.TabIndex = 0
        Me.txtgl_view2.Location = New System.Drawing.Point(772, 21)
        Me.txtgl_view2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtgl_view2.Name = "txtgl_view2"
        '
        '
        '
        Me.txtgl_view2.RootElement.ControlBounds = New System.Drawing.Rectangle(579, 17, 100, 20)
        Me.txtgl_view2.Size = New System.Drawing.Size(303, 30)
        Me.txtgl_view2.TabIndex = 51
        Me.txtgl_view2.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(879, 4)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(51, 17)
        Me.LinkLabel2.TabIndex = 223
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Refresh"
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(768, 9)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 17)
        Me.Label41.TabIndex = 52
        Me.Label41.Text = "View by account"
        '
        'chkdis_remarks
        '
        Me.chkdis_remarks.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkdis_remarks.Location = New System.Drawing.Point(429, -2)
        Me.chkdis_remarks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkdis_remarks.Name = "chkdis_remarks"
        '
        '
        '
        Me.chkdis_remarks.RootElement.ControlBounds = New System.Drawing.Rectangle(322, -2, 110, 18)
        Me.chkdis_remarks.RootElement.StretchHorizontally = True
        Me.chkdis_remarks.RootElement.StretchVertically = True
        Me.chkdis_remarks.Size = New System.Drawing.Size(135, 22)
        Me.chkdis_remarks.TabIndex = 50
        Me.chkdis_remarks.Text = "Search by remarks"
        '
        'chkdis_payee
        '
        Me.chkdis_payee.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkdis_payee.Location = New System.Drawing.Point(263, -1)
        Me.chkdis_payee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkdis_payee.Name = "chkdis_payee"
        '
        '
        '
        Me.chkdis_payee.RootElement.ControlBounds = New System.Drawing.Rectangle(197, -1, 110, 18)
        Me.chkdis_payee.RootElement.StretchHorizontally = True
        Me.chkdis_payee.RootElement.StretchVertically = True
        Me.chkdis_payee.Size = New System.Drawing.Size(123, 22)
        Me.chkdis_payee.TabIndex = 49
        Me.chkdis_payee.TabStop = True
        Me.chkdis_payee.Text = "Search by payee"
        Me.chkdis_payee.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblref_cb_dis
        '
        Me.lblref_cb_dis.AutoSize = True
        Me.lblref_cb_dis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblref_cb_dis.ForeColor = System.Drawing.Color.Olive
        Me.lblref_cb_dis.Location = New System.Drawing.Point(695, 2)
        Me.lblref_cb_dis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblref_cb_dis.Name = "lblref_cb_dis"
        Me.lblref_cb_dis.Size = New System.Drawing.Size(32, 17)
        Me.lblref_cb_dis.TabIndex = 48
        Me.lblref_cb_dis.Text = "000"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Olive
        Me.Label28.Location = New System.Drawing.Point(596, 2)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(98, 17)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Ref #. Found :"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(185, 29)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 18)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Search :"
        '
        'txt_cb_dis
        '
        Me.txt_cb_dis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cb_dis.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cb_dis.Location = New System.Drawing.Point(263, 22)
        Me.txt_cb_dis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cb_dis.Name = "txt_cb_dis"
        Me.txt_cb_dis.Size = New System.Drawing.Size(423, 27)
        Me.txt_cb_dis.TabIndex = 42
        Me.txt_cb_dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lblpaymentamnt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(1846, 17)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 38)
        Me.Panel2.TabIndex = 34
        '
        'lblpaymentamnt
        '
        Me.lblpaymentamnt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblpaymentamnt.AutoSize = True
        Me.lblpaymentamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymentamnt.ForeColor = System.Drawing.Color.Lime
        Me.lblpaymentamnt.Location = New System.Drawing.Point(171, 6)
        Me.lblpaymentamnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaymentamnt.Name = "lblpaymentamnt"
        Me.lblpaymentamnt.Size = New System.Drawing.Size(62, 29)
        Me.lblpaymentamnt.TabIndex = 0
        Me.lblpaymentamnt.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Total Amount :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Gen Date :"
        '
        'dt_disburse
        '
        Me.dt_disburse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dt_disburse.Enabled = False
        Me.dt_disburse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_disburse.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_disburse.Location = New System.Drawing.Point(9, 27)
        Me.dt_disburse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dt_disburse.Name = "dt_disburse"
        Me.dt_disburse.Size = New System.Drawing.Size(160, 27)
        Me.dt_disburse.TabIndex = 2
        Me.dt_disburse.Value = New Date(2015, 2, 6, 0, 0, 0, 0)
        '
        'pnadd1
        '
        Me.pnadd1.BackColor = System.Drawing.Color.White
        Me.pnadd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnadd1.Controls.Add(Me.Label47)
        Me.pnadd1.Controls.Add(Me.lstcbu1)
        Me.pnadd1.Controls.Add(Me.lblcbu1)
        Me.pnadd1.Controls.Add(Me.Label46)
        Me.pnadd1.Controls.Add(Me.lbleditamnt1)
        Me.pnadd1.Controls.Add(Me.lbleditgl1)
        Me.pnadd1.Controls.Add(Me.lstnot1)
        Me.pnadd1.Controls.Add(Me.lblnot1)
        Me.pnadd1.Controls.Add(Me.txtgl1)
        Me.pnadd1.Controls.Add(Me.Panel5)
        Me.pnadd1.Controls.Add(Me.Label7)
        Me.pnadd1.Controls.Add(Me.txtacct_ref1)
        Me.pnadd1.Controls.Add(Me.Label19)
        Me.pnadd1.Controls.Add(Me.txtremarks1)
        Me.pnadd1.Controls.Add(Me.Label20)
        Me.pnadd1.Controls.Add(Me.txtamount1)
        Me.pnadd1.Controls.Add(Me.Label22)
        Me.pnadd1.Controls.Add(Me.txtpayee1)
        Me.pnadd1.Controls.Add(Me.Label24)
        Me.pnadd1.Controls.Add(Me.bttnsave_dis)
        Me.pnadd1.Controls.Add(Me.RadButton2)
        Me.pnadd1.Controls.Add(Me.Label25)
        Me.pnadd1.Controls.Add(Me.txtref1)
        Me.pnadd1.Location = New System.Drawing.Point(552, 2)
        Me.pnadd1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnadd1.Name = "pnadd1"
        Me.pnadd1.Size = New System.Drawing.Size(562, 430)
        Me.pnadd1.TabIndex = 50
        Me.pnadd1.Visible = False
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(339, 49)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(23, 17)
        Me.Label47.TabIndex = 73
        Me.Label47.Text = "SD"
        '
        'lstcbu1
        '
        Me.lstcbu1.BackColor = System.Drawing.Color.Ivory
        Me.lstcbu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstcbu1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader39, Me.ColumnHeader40})
        Me.lstcbu1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcbu1.FullRowSelect = True
        Me.lstcbu1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstcbu1.Location = New System.Drawing.Point(1, 84)
        Me.lstcbu1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstcbu1.Name = "lstcbu1"
        Me.lstcbu1.Size = New System.Drawing.Size(387, 295)
        Me.lstcbu1.TabIndex = 72
        Me.lstcbu1.UseCompatibleStateImageBehavior = False
        Me.lstcbu1.View = System.Windows.Forms.View.Details
        Me.lstcbu1.Visible = False
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Width = 70
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Payee"
        Me.ColumnHeader34.Width = 120
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Width = 100
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Width = 100
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Width = 0
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Width = 0
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Width = 0
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Width = 0
        '
        'lblcbu1
        '
        Me.lblcbu1.AutoSize = True
        Me.lblcbu1.BackColor = System.Drawing.Color.Red
        Me.lblcbu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblcbu1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcbu1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcbu1.Location = New System.Drawing.Point(369, 64)
        Me.lblcbu1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcbu1.Name = "lblcbu1"
        Me.lblcbu1.Size = New System.Drawing.Size(19, 21)
        Me.lblcbu1.TabIndex = 71
        Me.lblcbu1.Text = "0"
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(365, 49)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(32, 17)
        Me.Label46.TabIndex = 70
        Me.Label46.Text = "CBU"
        '
        'lbleditamnt1
        '
        Me.lbleditamnt1.AutoSize = True
        Me.lbleditamnt1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleditamnt1.Location = New System.Drawing.Point(501, 324)
        Me.lbleditamnt1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbleditamnt1.Name = "lbleditamnt1"
        Me.lbleditamnt1.Size = New System.Drawing.Size(32, 19)
        Me.lbleditamnt1.TabIndex = 64
        Me.lbleditamnt1.TabStop = True
        Me.lbleditamnt1.Text = "Edit"
        '
        'lbleditgl1
        '
        Me.lbleditgl1.AutoSize = True
        Me.lbleditgl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleditgl1.Location = New System.Drawing.Point(501, 258)
        Me.lbleditgl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbleditgl1.Name = "lbleditgl1"
        Me.lbleditgl1.Size = New System.Drawing.Size(32, 19)
        Me.lbleditgl1.TabIndex = 63
        Me.lbleditgl1.TabStop = True
        Me.lbleditgl1.Text = "Edit"
        '
        'lstnot1
        '
        Me.lstnot1.BackColor = System.Drawing.Color.Ivory
        Me.lstnot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstnot1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader14, Me.ColumnHeader16})
        Me.lstnot1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstnot1.FullRowSelect = True
        Me.lstnot1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstnot1.Location = New System.Drawing.Point(4, 82)
        Me.lstnot1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstnot1.Name = "lstnot1"
        Me.lstnot1.Size = New System.Drawing.Size(347, 296)
        Me.lstnot1.TabIndex = 62
        Me.lstnot1.UseCompatibleStateImageBehavior = False
        Me.lstnot1.View = System.Windows.Forms.View.Details
        Me.lstnot1.Visible = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Payee"
        Me.ColumnHeader8.Width = 185
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Width = 40
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Width = 0
        '
        'lblnot1
        '
        Me.lblnot1.AutoSize = True
        Me.lblnot1.BackColor = System.Drawing.Color.Red
        Me.lblnot1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnot1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblnot1.Location = New System.Drawing.Point(341, 64)
        Me.lblnot1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnot1.Name = "lblnot1"
        Me.lblnot1.Size = New System.Drawing.Size(17, 20)
        Me.lblnot1.TabIndex = 61
        Me.lblnot1.Text = "0"
        '
        'txtgl1
        '
        Me.txtgl1.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        'txtgl1.NestedRadGridView
        '
        Me.txtgl1.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtgl1.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgl1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgl1.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtgl1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtgl1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtgl1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtgl1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtgl1.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtgl1.EditorControl.Name = "NestedRadGridView"
        Me.txtgl1.EditorControl.ReadOnly = True
        '
        '
        '
        Me.txtgl1.EditorControl.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 240, 150)
        Me.txtgl1.EditorControl.ShowGroupPanel = False
        Me.txtgl1.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl1.EditorControl.TabIndex = 0
        Me.txtgl1.Location = New System.Drawing.Point(53, 256)
        Me.txtgl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtgl1.Name = "txtgl1"
        '
        '
        '
        Me.txtgl1.RootElement.ControlBounds = New System.Drawing.Rectangle(40, 208, 100, 20)
        Me.txtgl1.Size = New System.Drawing.Size(447, 31)
        Me.txtgl1.TabIndex = 59
        Me.txtgl1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(561, 16)
        Me.Panel5.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(49, 299)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 18)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Account Reference :"
        '
        'txtacct_ref1
        '
        Me.txtacct_ref1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct_ref1.Location = New System.Drawing.Point(53, 321)
        Me.txtacct_ref1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtacct_ref1.Name = "txtacct_ref1"
        Me.txtacct_ref1.Size = New System.Drawing.Size(191, 29)
        Me.txtacct_ref1.TabIndex = 45
        Me.txtacct_ref1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(49, 165)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 18)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Remarks :"
        '
        'txtremarks1
        '
        Me.txtremarks1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks1.Location = New System.Drawing.Point(53, 187)
        Me.txtremarks1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtremarks1.Name = "txtremarks1"
        Me.txtremarks1.Size = New System.Drawing.Size(445, 29)
        Me.txtremarks1.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(320, 299)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 18)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Amount Disburse :"
        '
        'txtamount1
        '
        Me.txtamount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtamount1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount1.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtamount1.Location = New System.Drawing.Point(265, 321)
        Me.txtamount1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtamount1.Name = "txtamount1"
        Me.txtamount1.Size = New System.Drawing.Size(233, 39)
        Me.txtamount1.TabIndex = 46
        Me.txtamount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label22.Location = New System.Drawing.Point(49, 101)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 18)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Payee :"
        '
        'txtpayee1
        '
        Me.txtpayee1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayee1.Location = New System.Drawing.Point(53, 123)
        Me.txtpayee1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtpayee1.Name = "txtpayee1"
        Me.txtpayee1.Size = New System.Drawing.Size(445, 29)
        Me.txtpayee1.TabIndex = 42
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label24.Location = New System.Drawing.Point(49, 234)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 18)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "GL Account :"
        '
        'bttnsave_dis
        '
        Me.bttnsave_dis.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnsave_dis.Location = New System.Drawing.Point(265, 383)
        Me.bttnsave_dis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnsave_dis.Name = "bttnsave_dis"
        '
        '
        '
        Me.bttnsave_dis.RootElement.ControlBounds = New System.Drawing.Rectangle(199, 311, 110, 24)
        Me.bttnsave_dis.Size = New System.Drawing.Size(113, 38)
        Me.bttnsave_dis.TabIndex = 47
        Me.bttnsave_dis.Text = "Save"
        '
        'RadButton2
        '
        Me.RadButton2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton2.Location = New System.Drawing.Point(387, 383)
        Me.RadButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButton2.Name = "RadButton2"
        '
        '
        '
        Me.RadButton2.RootElement.ControlBounds = New System.Drawing.Rectangle(290, 311, 110, 24)
        Me.RadButton2.Size = New System.Drawing.Size(113, 38)
        Me.RadButton2.TabIndex = 48
        Me.RadButton2.Text = "Close"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label25.Location = New System.Drawing.Point(49, 36)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 18)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Reference :"
        '
        'txtref1
        '
        Me.txtref1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref1.Location = New System.Drawing.Point(53, 58)
        Me.txtref1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtref1.Name = "txtref1"
        Me.txtref1.Size = New System.Drawing.Size(279, 29)
        Me.txtref1.TabIndex = 41
        Me.txtref1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pndes
        '
        Me.pndes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pndes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pndes.Controls.Add(Me.lblalert_des)
        Me.pndes.Controls.Add(Me.RadButton4)
        Me.pndes.Controls.Add(Me.PictureBox1)
        Me.pndes.Controls.Add(Me.bttncont2)
        Me.pndes.Controls.Add(Me.txtpass_dess)
        Me.pndes.Location = New System.Drawing.Point(621, 28)
        Me.pndes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pndes.Name = "pndes"
        Me.pndes.Size = New System.Drawing.Size(453, 419)
        Me.pndes.TabIndex = 52
        Me.pndes.Visible = False
        '
        'lblalert_des
        '
        Me.lblalert_des.AutoSize = True
        Me.lblalert_des.ForeColor = System.Drawing.Color.Red
        Me.lblalert_des.Location = New System.Drawing.Point(57, 284)
        Me.lblalert_des.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblalert_des.Name = "lblalert_des"
        Me.lblalert_des.Size = New System.Drawing.Size(120, 19)
        Me.lblalert_des.TabIndex = 4
        Me.lblalert_des.Text = "* invalid password"
        Me.lblalert_des.Visible = False
        '
        'RadButton4
        '
        Me.RadButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadButton4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton4.Location = New System.Drawing.Point(115, 309)
        Me.RadButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButton4.Name = "RadButton4"
        '
        '
        '
        Me.RadButton4.RootElement.ControlBounds = New System.Drawing.Rectangle(86, 251, 110, 24)
        Me.RadButton4.Size = New System.Drawing.Size(124, 36)
        Me.RadButton4.TabIndex = 3
        Me.RadButton4.Text = "C&ancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 126)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'bttncont2
        '
        Me.bttncont2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttncont2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttncont2.Location = New System.Drawing.Point(247, 309)
        Me.bttncont2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttncont2.Name = "bttncont2"
        '
        '
        '
        Me.bttncont2.RootElement.ControlBounds = New System.Drawing.Rectangle(185, 251, 110, 24)
        Me.bttncont2.Size = New System.Drawing.Size(124, 36)
        Me.bttncont2.TabIndex = 1
        Me.bttncont2.Text = "&Continue"
        '
        'txtpass_dess
        '
        Me.txtpass_dess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpass_dess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass_dess.Location = New System.Drawing.Point(61, 245)
        Me.txtpass_dess.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtpass_dess.Name = "txtpass_dess"
        Me.txtpass_dess.Size = New System.Drawing.Size(327, 30)
        Me.txtpass_dess.TabIndex = 0
        Me.txtpass_dess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpass_dess.UseSystemPasswordChar = True
        '
        'dtgrid_disburse
        '
        Me.dtgrid_disburse.AllowUserToAddRows = False
        Me.dtgrid_disburse.AllowUserToDeleteRows = False
        Me.dtgrid_disburse.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgrid_disburse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_disburse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column2, Me.DataGridViewTextBoxColumn3, Me.date_col, Me.DataGridViewTextBoxColumn4, Me.Column3, Me.Column7})
        Me.dtgrid_disburse.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dtgrid_disburse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgrid_disburse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrid_disburse.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgrid_disburse.Location = New System.Drawing.Point(0, 0)
        Me.dtgrid_disburse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgrid_disburse.Name = "dtgrid_disburse"
        Me.dtgrid_disburse.ReadOnly = True
        Me.dtgrid_disburse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_disburse.Size = New System.Drawing.Size(2232, 662)
        Me.dtgrid_disburse.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reference No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Payee"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Remarks"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount Paid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_col
        '
        Me.date_col.HeaderText = "Account Reference"
        Me.date_col.Name = "date_col"
        Me.date_col.ReadOnly = True
        Me.date_col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.date_col.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "GL Account"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "User ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(123, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(122, 24)
        Me.ToolStripMenuItem1.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(122, 24)
        Me.ToolStripMenuItem2.Text = "Edit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(122, 24)
        Me.ToolStripMenuItem3.Text = "Delete"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Ivory
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.pnunclose_password)
        Me.Panel4.Controls.Add(Me.lnkunclosed)
        Me.Panel4.Controls.Add(Me.bttnview)
        Me.Panel4.Controls.Add(Me.grp1)
        Me.Panel4.Controls.Add(Me.bttnprintCB)
        Me.Panel4.Controls.Add(Me.dtden)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Location = New System.Drawing.Point(360, 25)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1123, 484)
        Me.Panel4.TabIndex = 0
        '
        'pnunclose_password
        '
        Me.pnunclose_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnunclose_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnunclose_password.Controls.Add(Me.lblinvalipassword)
        Me.pnunclose_password.Controls.Add(Me.RadButton5)
        Me.pnunclose_password.Controls.Add(Me.PictureBox2)
        Me.pnunclose_password.Controls.Add(Me.RadButton6)
        Me.pnunclose_password.Controls.Add(Me.txt_trnpassword)
        Me.pnunclose_password.Location = New System.Drawing.Point(347, 4)
        Me.pnunclose_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnunclose_password.Name = "pnunclose_password"
        Me.pnunclose_password.Size = New System.Drawing.Size(425, 472)
        Me.pnunclose_password.TabIndex = 224
        Me.pnunclose_password.Visible = False
        '
        'lblinvalipassword
        '
        Me.lblinvalipassword.AutoSize = True
        Me.lblinvalipassword.ForeColor = System.Drawing.Color.Red
        Me.lblinvalipassword.Location = New System.Drawing.Point(64, 273)
        Me.lblinvalipassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinvalipassword.Name = "lblinvalipassword"
        Me.lblinvalipassword.Size = New System.Drawing.Size(120, 19)
        Me.lblinvalipassword.TabIndex = 4
        Me.lblinvalipassword.Text = "* invalid password"
        Me.lblinvalipassword.Visible = False
        '
        'RadButton5
        '
        Me.RadButton5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadButton5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton5.Location = New System.Drawing.Point(96, 303)
        Me.RadButton5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButton5.Name = "RadButton5"
        '
        '
        '
        Me.RadButton5.RootElement.ControlBounds = New System.Drawing.Rectangle(72, 246, 110, 24)
        Me.RadButton5.Size = New System.Drawing.Size(124, 36)
        Me.RadButton5.TabIndex = 3
        Me.RadButton5.Text = "C&ancel"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(161, 114)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'RadButton6
        '
        Me.RadButton6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadButton6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton6.Location = New System.Drawing.Point(228, 303)
        Me.RadButton6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadButton6.Name = "RadButton6"
        '
        '
        '
        Me.RadButton6.RootElement.ControlBounds = New System.Drawing.Rectangle(171, 246, 110, 24)
        Me.RadButton6.Size = New System.Drawing.Size(124, 36)
        Me.RadButton6.TabIndex = 1
        Me.RadButton6.Text = "&Continue"
        '
        'txt_trnpassword
        '
        Me.txt_trnpassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_trnpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_trnpassword.Location = New System.Drawing.Point(68, 234)
        Me.txt_trnpassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_trnpassword.Name = "txt_trnpassword"
        Me.txt_trnpassword.Size = New System.Drawing.Size(299, 30)
        Me.txt_trnpassword.TabIndex = 0
        Me.txt_trnpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_trnpassword.UseSystemPasswordChar = True
        '
        'lnkunclosed
        '
        Me.lnkunclosed.AutoSize = True
        Me.lnkunclosed.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkunclosed.Location = New System.Drawing.Point(840, 47)
        Me.lnkunclosed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkunclosed.Name = "lnkunclosed"
        Me.lnkunclosed.Size = New System.Drawing.Size(130, 18)
        Me.lnkunclosed.TabIndex = 223
        Me.lnkunclosed.TabStop = True
        Me.lnkunclosed.Text = "Unclose Transaction"
        '
        'bttnview
        '
        Me.bttnview.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bttnview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnview.Location = New System.Drawing.Point(745, 31)
        Me.bttnview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnview.Name = "bttnview"
        '
        '
        '
        Me.bttnview.RootElement.ControlBounds = New System.Drawing.Rectangle(559, 25, 110, 24)
        Me.bttnview.Size = New System.Drawing.Size(87, 36)
        Me.bttnview.TabIndex = 39
        Me.bttnview.Text = "View"
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.bttnclose_trnx)
        Me.grp1.Controls.Add(Me.Label6)
        Me.grp1.Controls.Add(Me.bttncompute)
        Me.grp1.Controls.Add(Me.txtonethousand)
        Me.grp1.Controls.Add(Me.Label8)
        Me.grp1.Controls.Add(Me.txt_centfive)
        Me.grp1.Controls.Add(Me.txtfivehundred)
        Me.grp1.Controls.Add(Me.Label37)
        Me.grp1.Controls.Add(Me.Label9)
        Me.grp1.Controls.Add(Me.txt_tencent)
        Me.grp1.Controls.Add(Me.txttwohundred)
        Me.grp1.Controls.Add(Me.Label32)
        Me.grp1.Controls.Add(Me.Label10)
        Me.grp1.Controls.Add(Me.Label31)
        Me.grp1.Controls.Add(Me.txtonehundred)
        Me.grp1.Controls.Add(Me.lblvariance)
        Me.grp1.Controls.Add(Me.Label11)
        Me.grp1.Controls.Add(Me.Label29)
        Me.grp1.Controls.Add(Me.txtfifty)
        Me.grp1.Controls.Add(Me.Label5)
        Me.grp1.Controls.Add(Me.Label12)
        Me.grp1.Controls.Add(Me.lblbalance)
        Me.grp1.Controls.Add(Me.txttwenty)
        Me.grp1.Controls.Add(Me.txtcheck)
        Me.grp1.Controls.Add(Me.Label13)
        Me.grp1.Controls.Add(Me.Label18)
        Me.grp1.Controls.Add(Me.txtten)
        Me.grp1.Controls.Add(Me.lbltotalden)
        Me.grp1.Controls.Add(Me.Label14)
        Me.grp1.Controls.Add(Me.txtfive)
        Me.grp1.Controls.Add(Me.Label15)
        Me.grp1.Controls.Add(Me.txtcent)
        Me.grp1.Controls.Add(Me.txtone)
        Me.grp1.Controls.Add(Me.Label16)
        Me.grp1.Location = New System.Drawing.Point(16, 90)
        Me.grp1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp1.Name = "grp1"
        Me.grp1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp1.Size = New System.Drawing.Size(1081, 315)
        Me.grp1.TabIndex = 39
        Me.grp1.TabStop = False
        '
        'bttnclose_trnx
        '
        Me.bttnclose_trnx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttnclose_trnx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnclose_trnx.Enabled = False
        Me.bttnclose_trnx.Location = New System.Drawing.Point(156, 247)
        Me.bttnclose_trnx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnclose_trnx.Name = "bttnclose_trnx"
        '
        '
        '
        Me.bttnclose_trnx.RootElement.ControlBounds = New System.Drawing.Rectangle(117, 201, 110, 24)
        Me.bttnclose_trnx.RootElement.Enabled = False
        Me.bttnclose_trnx.Size = New System.Drawing.Size(145, 43)
        Me.bttnclose_trnx.TabIndex = 40
        Me.bttnclose_trnx.Text = "Close Transaction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(20, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Php. 1000"
        '
        'bttncompute
        '
        Me.bttncompute.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bttncompute.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttncompute.Enabled = False
        Me.bttncompute.Location = New System.Drawing.Point(24, 247)
        Me.bttncompute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttncompute.Name = "bttncompute"
        '
        '
        '
        Me.bttncompute.RootElement.ControlBounds = New System.Drawing.Rectangle(18, 201, 110, 24)
        Me.bttncompute.RootElement.Enabled = False
        Me.bttncompute.Size = New System.Drawing.Size(124, 43)
        Me.bttncompute.TabIndex = 38
        Me.bttncompute.Text = "Compute"
        '
        'txtonethousand
        '
        Me.txtonethousand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtonethousand.Location = New System.Drawing.Point(24, 47)
        Me.txtonethousand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtonethousand.Name = "txtonethousand"
        Me.txtonethousand.Size = New System.Drawing.Size(132, 34)
        Me.txtonethousand.TabIndex = 1
        Me.txtonethousand.Text = "0"
        Me.txtonethousand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(20, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Php. 500"
        '
        'txt_centfive
        '
        Me.txt_centfive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_centfive.Location = New System.Drawing.Point(543, 176)
        Me.txt_centfive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_centfive.Name = "txt_centfive"
        Me.txt_centfive.Size = New System.Drawing.Size(132, 34)
        Me.txt_centfive.TabIndex = 36
        Me.txt_centfive.Text = "0"
        Me.txt_centfive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfivehundred
        '
        Me.txtfivehundred.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfivehundred.Location = New System.Drawing.Point(24, 111)
        Me.txtfivehundred.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfivehundred.Name = "txtfivehundred"
        Me.txtfivehundred.Size = New System.Drawing.Size(132, 34)
        Me.txtfivehundred.TabIndex = 3
        Me.txtfivehundred.Text = "0"
        Me.txtfivehundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label37.Location = New System.Drawing.Point(539, 153)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 18)
        Me.Label37.TabIndex = 35
        Me.Label37.Text = "0.05"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(20, 153)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Php. 200"
        '
        'txt_tencent
        '
        Me.txt_tencent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tencent.Location = New System.Drawing.Point(543, 111)
        Me.txt_tencent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_tencent.Name = "txt_tencent"
        Me.txt_tencent.Size = New System.Drawing.Size(132, 34)
        Me.txt_tencent.TabIndex = 34
        Me.txt_tencent.Text = "0"
        Me.txt_tencent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttwohundred
        '
        Me.txttwohundred.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttwohundred.Location = New System.Drawing.Point(24, 176)
        Me.txttwohundred.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttwohundred.Name = "txttwohundred"
        Me.txttwohundred.Size = New System.Drawing.Size(132, 34)
        Me.txttwohundred.TabIndex = 5
        Me.txttwohundred.Text = "0"
        Me.txttwohundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label32.Location = New System.Drawing.Point(539, 87)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(36, 18)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "0.10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(200, 23)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Php. 100"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(857, 214)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(85, 20)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Variance :"
        '
        'txtonehundred
        '
        Me.txtonehundred.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtonehundred.Location = New System.Drawing.Point(204, 47)
        Me.txtonehundred.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtonehundred.Name = "txtonehundred"
        Me.txtonehundred.Size = New System.Drawing.Size(132, 34)
        Me.txtonehundred.TabIndex = 7
        Me.txtonehundred.Text = "0"
        Me.txtonehundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblvariance
        '
        Me.lblvariance.AutoSize = True
        Me.lblvariance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvariance.ForeColor = System.Drawing.Color.Red
        Me.lblvariance.Location = New System.Drawing.Point(876, 246)
        Me.lblvariance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvariance.Name = "lblvariance"
        Me.lblvariance.Size = New System.Drawing.Size(54, 25)
        Me.lblvariance.TabIndex = 31
        Me.lblvariance.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(200, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Php. 50"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(857, 151)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 20)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "Balance End :"
        '
        'txtfifty
        '
        Me.txtfifty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfifty.Location = New System.Drawing.Point(204, 112)
        Me.txtfifty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfifty.Name = "txtfifty"
        Me.txtfifty.Size = New System.Drawing.Size(132, 34)
        Me.txtfifty.TabIndex = 9
        Me.txtfifty.Text = "0"
        Me.txtfifty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(857, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Total Denomenation :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(200, 153)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Php. 20"
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.ForeColor = System.Drawing.Color.Red
        Me.lblbalance.Location = New System.Drawing.Point(876, 181)
        Me.lblbalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(54, 25)
        Me.lblbalance.TabIndex = 28
        Me.lblbalance.Text = "0.00"
        '
        'txttwenty
        '
        Me.txttwenty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttwenty.Location = New System.Drawing.Point(204, 176)
        Me.txttwenty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttwenty.Name = "txttwenty"
        Me.txttwenty.Size = New System.Drawing.Size(132, 34)
        Me.txttwenty.TabIndex = 11
        Me.txttwenty.Text = "0"
        Me.txttwenty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcheck
        '
        Me.txtcheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheck.Location = New System.Drawing.Point(684, 47)
        Me.txtcheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcheck.Name = "txtcheck"
        Me.txtcheck.Size = New System.Drawing.Size(132, 34)
        Me.txtcheck.TabIndex = 27
        Me.txtcheck.Text = "0"
        Me.txtcheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(376, 23)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Php. 10"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(680, 23)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 18)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "COCI"
        '
        'txtten
        '
        Me.txtten.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten.Location = New System.Drawing.Point(380, 47)
        Me.txtten.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(132, 34)
        Me.txtten.TabIndex = 13
        Me.txtten.Text = "0"
        Me.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltotalden
        '
        Me.lbltotalden.AutoSize = True
        Me.lbltotalden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalden.ForeColor = System.Drawing.Color.Red
        Me.lbltotalden.Location = New System.Drawing.Point(876, 117)
        Me.lbltotalden.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalden.Name = "lbltotalden"
        Me.lbltotalden.Size = New System.Drawing.Size(54, 25)
        Me.lbltotalden.TabIndex = 25
        Me.lbltotalden.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(376, 87)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Php. 5"
        '
        'txtfive
        '
        Me.txtfive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfive.Location = New System.Drawing.Point(380, 111)
        Me.txtfive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfive.Name = "txtfive"
        Me.txtfive.Size = New System.Drawing.Size(132, 34)
        Me.txtfive.TabIndex = 15
        Me.txtfive.Text = "0"
        Me.txtfive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(376, 153)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 18)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Php. 1"
        '
        'txtcent
        '
        Me.txtcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcent.Location = New System.Drawing.Point(543, 47)
        Me.txtcent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcent.Name = "txtcent"
        Me.txtcent.Size = New System.Drawing.Size(132, 34)
        Me.txtcent.TabIndex = 19
        Me.txtcent.Text = "0"
        Me.txtcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtone
        '
        Me.txtone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtone.Location = New System.Drawing.Point(380, 176)
        Me.txtone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtone.Name = "txtone"
        Me.txtone.Size = New System.Drawing.Size(132, 34)
        Me.txtone.TabIndex = 17
        Me.txtone.Text = "0"
        Me.txtone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(539, 23)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 18)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "0.25"
        '
        'bttnprintCB
        '
        Me.bttnprintCB.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bttnprintCB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnprintCB.Location = New System.Drawing.Point(877, 412)
        Me.bttnprintCB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnprintCB.Name = "bttnprintCB"
        '
        '
        '
        Me.bttnprintCB.RootElement.ControlBounds = New System.Drawing.Rectangle(658, 335, 110, 24)
        Me.bttnprintCB.Size = New System.Drawing.Size(145, 43)
        Me.bttnprintCB.TabIndex = 39
        Me.bttnprintCB.Text = "Cashiers Blotter"
        '
        'dtden
        '
        Me.dtden.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtden.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtden.Location = New System.Drawing.Point(543, 31)
        Me.dtden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtden.Name = "dtden"
        Me.dtden.Size = New System.Drawing.Size(193, 34)
        Me.dtden.TabIndex = 23
        Me.dtden.Value = New Date(2015, 2, 6, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(261, 22)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(250, 49)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Transaction Of"
        '
        'RadPageView1
        '
        Me.RadPageView1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage3)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadPageView1.Name = "RadPageView1"
        '
        '
        '
        Me.RadPageView1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 400, 300)
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage1
        Me.RadPageView1.Size = New System.Drawing.Size(1711, 689)
        Me.RadPageView1.TabIndex = 1
        Me.RadPageView1.Text = "RadPageView1"
        '
        'RadPageViewPage1
        '
        'TODO: Code generation for 'Me.RadPageViewPage1.Context' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.RadPageViewPage1.Controls.Add(Me.RadPageView2)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(13, 50)
        Me.RadPageViewPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(2253, 784)
        Me.RadPageViewPage1.Text = "Cashiers Blotter"
        '
        'RadPageView2
        '
        Me.RadPageView2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadPageView2.Controls.Add(Me.rad_reciepts)
        Me.RadPageView2.Controls.Add(Me.rad_disburse)
        Me.RadPageView2.Controls.Add(Me.rad_summary)
        Me.RadPageView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView2.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadPageView2.Name = "RadPageView2"
        '
        '
        '
        Me.RadPageView2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 400, 300)
        Me.RadPageView2.SelectedPage = Me.rad_summary
        Me.RadPageView2.Size = New System.Drawing.Size(2253, 784)
        Me.RadPageView2.TabIndex = 0
        Me.RadPageView2.Text = "Summary of Transaction"
        '
        'rad_reciepts
        '
        'TODO: Code generation for 'Me.rad_reciepts.Context' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.rad_reciepts.Controls.Add(Me.SplitContainer1)
        Me.rad_reciepts.Location = New System.Drawing.Point(10, 41)
        Me.rad_reciepts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rad_reciepts.Name = "rad_reciepts"
        Me.rad_reciepts.Size = New System.Drawing.Size(2232, 732)
        Me.rad_reciepts.Text = "Cash Receipts"
        '
        'rad_disburse
        '
        'TODO: Code generation for 'Me.rad_disburse.Context' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.rad_disburse.Controls.Add(Me.SplitContainer2)
        Me.rad_disburse.Location = New System.Drawing.Point(10, 41)
        Me.rad_disburse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rad_disburse.Name = "rad_disburse"
        Me.rad_disburse.Size = New System.Drawing.Size(2232, 732)
        Me.rad_disburse.Text = "Cash Disbursement"
        '
        'rad_summary
        '
        'TODO: Code generation for 'Me.rad_summary.Context' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.rad_summary.Controls.Add(Me.bttnrefresh)
        Me.rad_summary.Controls.Add(Me.Label38)
        Me.rad_summary.Controls.Add(Me.Label39)
        Me.rad_summary.Controls.Add(Me.lblcredit)
        Me.rad_summary.Controls.Add(Me.lbldebit)
        Me.rad_summary.Controls.Add(Me.dtgrd_summary)
        Me.rad_summary.Location = New System.Drawing.Point(10, 41)
        Me.rad_summary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rad_summary.Name = "rad_summary"
        Me.rad_summary.Size = New System.Drawing.Size(2232, 732)
        Me.rad_summary.Text = "Summary of Transaction"
        '
        'bttnrefresh
        '
        Me.bttnrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnrefresh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnrefresh.Location = New System.Drawing.Point(4, 690)
        Me.bttnrefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnrefresh.Name = "bttnrefresh"
        '
        '
        '
        Me.bttnrefresh.RootElement.ControlBounds = New System.Drawing.Rectangle(3, 430, 110, 24)
        Me.bttnrefresh.Size = New System.Drawing.Size(124, 36)
        Me.bttnrefresh.TabIndex = 35
        Me.bttnrefresh.Text = "Refresh"
        '
        'Label38
        '
        Me.Label38.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(469, 698)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(64, 20)
        Me.Label38.TabIndex = 34
        Me.Label38.Text = "Credit :"
        '
        'Label39
        '
        Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(177, 698)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(59, 20)
        Me.Label39.TabIndex = 33
        Me.Label39.Text = "Debit :"
        '
        'lblcredit
        '
        Me.lblcredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcredit.AutoSize = True
        Me.lblcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredit.ForeColor = System.Drawing.Color.Red
        Me.lblcredit.Location = New System.Drawing.Point(536, 696)
        Me.lblcredit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(54, 25)
        Me.lblcredit.TabIndex = 32
        Me.lblcredit.Text = "0.00"
        '
        'lbldebit
        '
        Me.lbldebit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbldebit.AutoSize = True
        Me.lbldebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebit.ForeColor = System.Drawing.Color.Red
        Me.lbldebit.Location = New System.Drawing.Point(243, 696)
        Me.lbldebit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldebit.Name = "lbldebit"
        Me.lbldebit.Size = New System.Drawing.Size(54, 25)
        Me.lbldebit.TabIndex = 31
        Me.lbldebit.Text = "0.00"
        '
        'dtgrd_summary
        '
        Me.dtgrd_summary.AllowUserToAddRows = False
        Me.dtgrd_summary.AllowUserToDeleteRows = False
        Me.dtgrd_summary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrd_summary.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtgrd_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrd_summary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dtgrd_summary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrd_summary.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgrd_summary.Location = New System.Drawing.Point(0, 0)
        Me.dtgrd_summary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgrd_summary.Name = "dtgrd_summary"
        Me.dtgrd_summary.ReadOnly = True
        Me.dtgrd_summary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrd_summary.Size = New System.Drawing.Size(2238, 514)
        Me.dtgrd_summary.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Account Titles"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 500
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Debit"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 90
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Credit"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'RadPageViewPage3
        '
        'TODO: Code generation for 'Me.RadPageViewPage3.Context' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.RadPageViewPage3.Controls.Add(Me.Panel4)
        Me.RadPageViewPage3.Location = New System.Drawing.Point(13, 46)
        Me.RadPageViewPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadPageViewPage3.Name = "RadPageViewPage3"
        Me.RadPageViewPage3.Size = New System.Drawing.Size(1683, 630)
        Me.RadPageViewPage3.Text = "End Day (Denomination & Reports)"
        '
        'frm_cashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1711, 689)
        Me.Controls.Add(Me.RadPageView1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_cashiering"
        Me.ShowIcon = False
        Me.Text = "Cashier/Teller"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtgl_view1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl_view1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl_view1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkrec_remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkrec_payee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnadd.ResumeLayout(False)
        Me.pnadd.PerformLayout()
        CType(Me.txtgl.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave_receipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnclose_rec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnreceipts.ResumeLayout(False)
        Me.pnreceipts.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncont1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridblotter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.txtgl_view2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl_view2.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl_view2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdis_remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdis_payee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnadd1.ResumeLayout(False)
        Me.pnadd1.PerformLayout()
        CType(Me.txtgl1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave_dis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pndes.ResumeLayout(False)
        Me.pndes.PerformLayout()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncont2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_disburse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnunclose_password.ResumeLayout(False)
        Me.pnunclose_password.PerformLayout()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.bttnclose_trnx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncompute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnprintCB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        CType(Me.RadPageView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView2.ResumeLayout(False)
        Me.rad_reciepts.ResumeLayout(False)
        Me.rad_disburse.ResumeLayout(False)
        Me.rad_summary.ResumeLayout(False)
        Me.rad_summary.PerformLayout()
        CType(Me.bttnrefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrd_summary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtgridblotter As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_receiptsamnt As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtgrid_disburse As System.Windows.Forms.DataGridView
    Friend WithEvents lblpaymentamnt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_disburse As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_receipts As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txttwohundred As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfivehundred As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtonethousand As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcent As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtone As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtfive As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttwenty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtfifty As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtonehundred As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtden As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbltotalden As System.Windows.Forms.Label
    Friend WithEvents txtcheck As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_cb_rec As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_cb_dis As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblref_cb_rec As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblref_cb_dis As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents pnadd As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtpayee As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtacctref As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnadd1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtacct_ref1 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtremarks1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtamount1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtpayee1 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtref1 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblnot As System.Windows.Forms.Label
    Friend WithEvents lstnot As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstnot1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblnot1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblvariance As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_centfive As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txt_tencent As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents rel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents memcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnnumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnreceipts As System.Windows.Forms.Panel
    Friend WithEvents lblalert_pass1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpassword_rec As System.Windows.Forms.TextBox
    Friend WithEvents pndes As System.Windows.Forms.Panel
    Friend WithEvents lblalert_des As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpass_dess As System.Windows.Forms.TextBox
    Friend WithEvents lbleditamnt As System.Windows.Forms.LinkLabel
    Friend WithEvents lbleditgl As System.Windows.Forms.LinkLabel
    Friend WithEvents lbleditamnt1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbleditgl1 As System.Windows.Forms.LinkLabel
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgrd_summary As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents lbldebit As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents pnunclose_password As System.Windows.Forms.Panel
    Friend WithEvents lblinvalipassword As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_trnpassword As System.Windows.Forms.TextBox
    Friend WithEvents lnkunclosed As System.Windows.Forms.LinkLabel
    Friend WithEvents lst_stockrel As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblstock As System.Windows.Forms.Label
    Friend WithEvents lblnotcbu As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents lstcbu As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents lstcbu1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblcbu1 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Private WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Private WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents RadPageView2 As Telerik.WinControls.UI.RadPageView
    Private WithEvents rad_reciepts As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents rad_disburse As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents RadPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents chkrec_remarks As Telerik.WinControls.UI.RadRadioButton
    Private WithEvents chkrec_payee As Telerik.WinControls.UI.RadRadioButton
    Private WithEvents chkdis_remarks As Telerik.WinControls.UI.RadRadioButton
    Private WithEvents chkdis_payee As Telerik.WinControls.UI.RadRadioButton
    Private WithEvents bttnclose_rec As Telerik.WinControls.UI.RadButton
    Private WithEvents bttnsave_receipt As Telerik.WinControls.UI.RadButton
    Private WithEvents bttnsave_dis As Telerik.WinControls.UI.RadButton
    Private WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Private WithEvents txtgl As Telerik.WinControls.UI.RadMultiColumnComboBox
    Private WithEvents txtgl1 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Private WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Private WithEvents bttncont1 As Telerik.WinControls.UI.RadButton
    Private WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Private WithEvents bttncont2 As Telerik.WinControls.UI.RadButton
    Private WithEvents bttncompute As Telerik.WinControls.UI.RadButton
    Private WithEvents bttnprintCB As Telerik.WinControls.UI.RadButton
    Private WithEvents bttnclose_trnx As Telerik.WinControls.UI.RadButton
    Private WithEvents rad_summary As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents bttnrefresh As Telerik.WinControls.UI.RadButton
    Private WithEvents bttnview As Telerik.WinControls.UI.RadButton
    Private WithEvents txtgl_view1 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Private WithEvents txtgl_view2 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Private WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Private WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
End Class
