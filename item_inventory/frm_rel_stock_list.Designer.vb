<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rel_stock_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rel_stock_list))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkrec_remarks = New Telerik.WinControls.UI.RadRadioButton()
        Me.chkrec_item = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblref_cb_rec = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgen = New System.Windows.Forms.DateTimePicker()
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.pnadmin = New System.Windows.Forms.Panel()
        Me.lblalert = New System.Windows.Forms.Label()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.dtgrid_products = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.chkrec_remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkrec_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnadmin.SuspendLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkrec_remarks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkrec_item)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblref_cb_rec)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label26)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtgen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bttnnew)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnadmin)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtgrid_products)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(1229, 552)
        Me.SplitContainer1.SplitterDistance = 60
        Me.SplitContainer1.TabIndex = 0
        '
        'chkrec_remarks
        '
        Me.chkrec_remarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkrec_remarks.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrec_remarks.Location = New System.Drawing.Point(395, 8)
        Me.chkrec_remarks.Name = "chkrec_remarks"
        '
        '
        '
        Me.chkrec_remarks.RootElement.AccessibleDescription = Nothing
        Me.chkrec_remarks.RootElement.AccessibleName = Nothing
        Me.chkrec_remarks.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 18)
        Me.chkrec_remarks.RootElement.StretchHorizontally = True
        Me.chkrec_remarks.RootElement.StretchVertically = True
        Me.chkrec_remarks.Size = New System.Drawing.Size(101, 18)
        Me.chkrec_remarks.TabIndex = 57
        Me.chkrec_remarks.TabStop = True
        Me.chkrec_remarks.Text = "Search by remarks"
        Me.chkrec_remarks.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chkrec_item
        '
        Me.chkrec_item.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkrec_item.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrec_item.Location = New System.Drawing.Point(270, 9)
        Me.chkrec_item.Name = "chkrec_item"
        '
        '
        '
        Me.chkrec_item.RootElement.AccessibleDescription = Nothing
        Me.chkrec_item.RootElement.AccessibleName = Nothing
        Me.chkrec_item.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 18)
        Me.chkrec_item.RootElement.StretchHorizontally = True
        Me.chkrec_item.RootElement.StretchVertically = True
        Me.chkrec_item.Size = New System.Drawing.Size(86, 18)
        Me.chkrec_item.TabIndex = 56
        Me.chkrec_item.Text = "Search by Item"
        '
        'lblref_cb_rec
        '
        Me.lblref_cb_rec.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblref_cb_rec.AutoSize = True
        Me.lblref_cb_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblref_cb_rec.ForeColor = System.Drawing.Color.Olive
        Me.lblref_cb_rec.Location = New System.Drawing.Point(667, 13)
        Me.lblref_cb_rec.Name = "lblref_cb_rec"
        Me.lblref_cb_rec.Size = New System.Drawing.Size(25, 13)
        Me.lblref_cb_rec.TabIndex = 55
        Me.lblref_cb_rec.Text = "000"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Olive
        Me.Label26.Location = New System.Drawing.Point(585, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "Data Found :"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(212, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 15)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Search :"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtsearch.Location = New System.Drawing.Point(270, 29)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(425, 20)
        Me.txtsearch.TabIndex = 52
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Gen Date :"
        '
        'dtgen
        '
        Me.dtgen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtgen.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtgen.Location = New System.Drawing.Point(86, 29)
        Me.dtgen.Name = "dtgen"
        Me.dtgen.Size = New System.Drawing.Size(112, 23)
        Me.dtgen.TabIndex = 50
        Me.dtgen.Value = New Date(2015, 2, 6, 0, 0, 0, 0)
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bttnnew.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnnew.Location = New System.Drawing.Point(734, 21)
        Me.bttnnew.Name = "bttnnew"
        '
        '
        '
        Me.bttnnew.RootElement.AccessibleDescription = Nothing
        Me.bttnnew.RootElement.AccessibleName = Nothing
        Me.bttnnew.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.bttnnew.Size = New System.Drawing.Size(93, 34)
        Me.bttnnew.TabIndex = 0
        Me.bttnnew.Text = "&New"
        '
        'pnadmin
        '
        Me.pnadmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnadmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnadmin.Controls.Add(Me.lblalert)
        Me.pnadmin.Controls.Add(Me.RadButton2)
        Me.pnadmin.Controls.Add(Me.PictureBox1)
        Me.pnadmin.Controls.Add(Me.RadButton1)
        Me.pnadmin.Controls.Add(Me.txtpassword)
        Me.pnadmin.Location = New System.Drawing.Point(466, 93)
        Me.pnadmin.Name = "pnadmin"
        Me.pnadmin.Size = New System.Drawing.Size(293, 165)
        Me.pnadmin.TabIndex = 14
        Me.pnadmin.Visible = False
        '
        'lblalert
        '
        Me.lblalert.AutoSize = True
        Me.lblalert.ForeColor = System.Drawing.Color.Red
        Me.lblalert.Location = New System.Drawing.Point(16, 74)
        Me.lblalert.Name = "lblalert"
        Me.lblalert.Size = New System.Drawing.Size(106, 15)
        Me.lblalert.TabIndex = 5
        Me.lblalert.Text = "* invalid password"
        Me.lblalert.Visible = False
        '
        'RadButton2
        '
        Me.RadButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadButton2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton2.Location = New System.Drawing.Point(172, 124)
        Me.RadButton2.Name = "RadButton2"
        '
        '
        '
        Me.RadButton2.RootElement.AccessibleDescription = Nothing
        Me.RadButton2.RootElement.AccessibleName = Nothing
        Me.RadButton2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.RadButton2.Size = New System.Drawing.Size(93, 29)
        Me.RadButton2.TabIndex = 3
        Me.RadButton2.Text = "C&ancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadButton1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadButton1.Location = New System.Drawing.Point(23, 124)
        Me.RadButton1.Name = "RadButton1"
        '
        '
        '
        Me.RadButton1.RootElement.AccessibleDescription = Nothing
        Me.RadButton1.RootElement.AccessibleName = Nothing
        Me.RadButton1.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.RadButton1.Size = New System.Drawing.Size(93, 29)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "&Continue"
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(23, 92)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(242, 26)
        Me.txtpassword.TabIndex = 0
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'dtgrid_products
        '
        Me.dtgrid_products.AllowUserToAddRows = False
        Me.dtgrid_products.AllowUserToDeleteRows = False
        Me.dtgrid_products.AllowUserToOrderColumns = True
        Me.dtgrid_products.AllowUserToResizeColumns = False
        Me.dtgrid_products.BackgroundColor = System.Drawing.Color.White
        Me.dtgrid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column3, Me.Column4, Me.Column5})
        Me.dtgrid_products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgrid_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrid_products.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgrid_products.Location = New System.Drawing.Point(0, 0)
        Me.dtgrid_products.MultiSelect = False
        Me.dtgrid_products.Name = "dtgrid_products"
        Me.dtgrid_products.ReadOnly = True
        Me.dtgrid_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_products.Size = New System.Drawing.Size(1229, 488)
        Me.dtgrid_products.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Reference"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Remarks"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "X"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'frm_rel_stock_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1229, 552)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_rel_stock_list"
        Me.ShowIcon = False
        Me.Text = "List of Stocks Release"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.chkrec_remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkrec_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnadmin.ResumeLayout(False)
        Me.pnadmin.PerformLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblref_cb_rec As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtgen As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgrid_products As System.Windows.Forms.DataGridView
    Friend WithEvents pnadmin As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblalert As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewButtonColumn
    Private WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Private WithEvents chkrec_remarks As Telerik.WinControls.UI.RadRadioButton
    Private WithEvents chkrec_item As Telerik.WinControls.UI.RadRadioButton
    Private WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Private WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class
