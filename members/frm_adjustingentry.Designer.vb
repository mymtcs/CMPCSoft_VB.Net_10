<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adjustingentry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adjustingentry))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtlno = New System.Windows.Forms.TextBox
        Me.txtprnpaid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtintdue = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtsa_amount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcf = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtfullname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtref = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dttrn = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkprndue = New System.Windows.Forms.CheckBox
        Me.chksavings = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblprnbal = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtadvprn = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblintbal = New System.Windows.Forms.Label
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.bttnclose = New Telerik.WinControls.UI.RadButton
        Me.cbopay_type = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtcbu = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtadv_int = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtcoll_date = New System.Windows.Forms.DateTimePicker
        Me.dtgrid_gl = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtgl = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid_gl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loan Number :"
        '
        'txtlno
        '
        Me.txtlno.Enabled = False
        Me.txtlno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlno.Location = New System.Drawing.Point(14, 140)
        Me.txtlno.Name = "txtlno"
        Me.txtlno.Size = New System.Drawing.Size(237, 24)
        Me.txtlno.TabIndex = 1
        '
        'txtprnpaid
        '
        Me.txtprnpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprnpaid.Location = New System.Drawing.Point(16, 200)
        Me.txtprnpaid.Name = "txtprnpaid"
        Me.txtprnpaid.Size = New System.Drawing.Size(90, 24)
        Me.txtprnpaid.TabIndex = 3
        Me.txtprnpaid.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Principal Paid"
        '
        'txtintdue
        '
        Me.txtintdue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintdue.Location = New System.Drawing.Point(194, 200)
        Me.txtintdue.Name = "txtintdue"
        Me.txtintdue.Size = New System.Drawing.Size(93, 24)
        Me.txtintdue.TabIndex = 5
        Me.txtintdue.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Int Paid"
        '
        'txtsa_amount
        '
        Me.txtsa_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsa_amount.Location = New System.Drawing.Point(490, 200)
        Me.txtsa_amount.Name = "txtsa_amount"
        Me.txtsa_amount.Size = New System.Drawing.Size(56, 24)
        Me.txtsa_amount.TabIndex = 7
        Me.txtsa_amount.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(488, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PS"
        '
        'txtcf
        '
        Me.txtcf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcf.Location = New System.Drawing.Point(382, 200)
        Me.txtcf.Name = "txtcf"
        Me.txtcf.Size = New System.Drawing.Size(53, 24)
        Me.txtcf.TabIndex = 9
        Me.txtcf.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CF"
        '
        'txtfullname
        '
        Me.txtfullname.Enabled = False
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(257, 140)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(289, 24)
        Me.txtfullname.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fullname :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.ForeColor = System.Drawing.Color.Red
        Me.txtref.Location = New System.Drawing.Point(16, 85)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(530, 24)
        Me.txtref.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(13, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Reference :"
        '
        'dttrn
        '
        Me.dttrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttrn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttrn.Location = New System.Drawing.Point(306, 34)
        Me.dttrn.Name = "dttrn"
        Me.dttrn.Size = New System.Drawing.Size(110, 24)
        Me.dttrn.TabIndex = 16
        Me.dttrn.Value = New Date(2015, 2, 15, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(303, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Transaction Date :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Location = New System.Drawing.Point(-1, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(558, 11)
        Me.Panel2.TabIndex = 36
        '
        'chkprndue
        '
        Me.chkprndue.AutoSize = True
        Me.chkprndue.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkprndue.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.chkprndue.Location = New System.Drawing.Point(3, 230)
        Me.chkprndue.Name = "chkprndue"
        Me.chkprndue.Size = New System.Drawing.Size(108, 16)
        Me.chkprndue.TabIndex = 37
        Me.chkprndue.Text = "Add amount excided"
        Me.chkprndue.UseVisualStyleBackColor = True
        '
        'chksavings
        '
        Me.chksavings.AutoSize = True
        Me.chksavings.Checked = True
        Me.chksavings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksavings.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.chksavings.Location = New System.Drawing.Point(436, 230)
        Me.chksavings.Name = "chksavings"
        Me.chksavings.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chksavings.Size = New System.Drawing.Size(108, 16)
        Me.chksavings.TabIndex = 38
        Me.chksavings.Text = "Add amount excided"
        Me.chksavings.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblprnbal)
        Me.Panel1.Location = New System.Drawing.Point(-2, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 32)
        Me.Panel1.TabIndex = 39
        '
        'lblprnbal
        '
        Me.lblprnbal.AutoSize = True
        Me.lblprnbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprnbal.ForeColor = System.Drawing.Color.Lime
        Me.lblprnbal.Location = New System.Drawing.Point(7, 7)
        Me.lblprnbal.Name = "lblprnbal"
        Me.lblprnbal.Size = New System.Drawing.Size(25, 25)
        Me.lblprnbal.TabIndex = 41
        Me.lblprnbal.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(0, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 15)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Principal Balance :"
        '
        'txtadvprn
        '
        Me.txtadvprn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadvprn.Location = New System.Drawing.Point(107, 200)
        Me.txtadvprn.Name = "txtadvprn"
        Me.txtadvprn.Size = New System.Drawing.Size(86, 24)
        Me.txtadvprn.TabIndex = 43
        Me.txtadvprn.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(106, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Adv. Prn Paid"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(0, 369)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 15)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Interest Balance :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblintbal)
        Me.Panel3.Location = New System.Drawing.Point(-2, 385)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(177, 32)
        Me.Panel3.TabIndex = 44
        '
        'lblintbal
        '
        Me.lblintbal.AutoSize = True
        Me.lblintbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintbal.ForeColor = System.Drawing.Color.Lime
        Me.lblintbal.Location = New System.Drawing.Point(7, 7)
        Me.lblintbal.Name = "lblintbal"
        Me.lblintbal.Size = New System.Drawing.Size(25, 25)
        Me.lblintbal.TabIndex = 41
        Me.lblintbal.Text = "0"
        '
        'bttnsave
        '
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.Location = New System.Drawing.Point(362, 378)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(87, 37)
        Me.bttnsave.TabIndex = 49
        Me.bttnsave.Text = "Save"
        '
        'bttnclose
        '
        Me.bttnclose.Image = CType(resources.GetObject("bttnclose.Image"), System.Drawing.Image)
        Me.bttnclose.Location = New System.Drawing.Point(455, 378)
        Me.bttnclose.Name = "bttnclose"
        Me.bttnclose.Size = New System.Drawing.Size(87, 37)
        Me.bttnclose.TabIndex = 50
        Me.bttnclose.Text = "Close"
        '
        'cbopay_type
        '
        Me.cbopay_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopay_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopay_type.FormattingEnabled = True
        Me.cbopay_type.Items.AddRange(New Object() {"ADJUSTING ENTRY"})
        Me.cbopay_type.Location = New System.Drawing.Point(14, 34)
        Me.cbopay_type.Name = "cbopay_type"
        Me.cbopay_type.Size = New System.Drawing.Size(237, 23)
        Me.cbopay_type.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(11, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 15)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Payment Type :"
        '
        'txtcbu
        '
        Me.txtcbu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcbu.Location = New System.Drawing.Point(436, 200)
        Me.txtcbu.Name = "txtcbu"
        Me.txtcbu.Size = New System.Drawing.Size(53, 24)
        Me.txtcbu.TabIndex = 54
        Me.txtcbu.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(436, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 15)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "CBU"
        '
        'txtadv_int
        '
        Me.txtadv_int.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadv_int.Location = New System.Drawing.Point(288, 200)
        Me.txtadv_int.Name = "txtadv_int"
        Me.txtadv_int.Size = New System.Drawing.Size(93, 24)
        Me.txtadv_int.TabIndex = 56
        Me.txtadv_int.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(285, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 15)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Adv. Int Paid"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(431, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 15)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Collection Date :"
        '
        'txtcoll_date
        '
        Me.txtcoll_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoll_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtcoll_date.Location = New System.Drawing.Point(434, 34)
        Me.txtcoll_date.Name = "txtcoll_date"
        Me.txtcoll_date.Size = New System.Drawing.Size(110, 24)
        Me.txtcoll_date.TabIndex = 57
        Me.txtcoll_date.Value = New Date(2015, 2, 15, 0, 0, 0, 0)
        '
        'dtgrid_gl
        '
        Me.dtgrid_gl.AllowUserToAddRows = False
        Me.dtgrid_gl.AllowUserToDeleteRows = False
        Me.dtgrid_gl.AllowUserToOrderColumns = True
        Me.dtgrid_gl.AllowUserToResizeColumns = False
        Me.dtgrid_gl.AllowUserToResizeRows = False
        Me.dtgrid_gl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dtgrid_gl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_gl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dtgrid_gl.Location = New System.Drawing.Point(14, 419)
        Me.dtgrid_gl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgrid_gl.Name = "dtgrid_gl"
        Me.dtgrid_gl.ReadOnly = True
        Me.dtgrid_gl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_gl.Size = New System.Drawing.Size(515, 24)
        Me.dtgrid_gl.TabIndex = 214
        Me.dtgrid_gl.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "GL Account"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Debit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Credit"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(433, 271)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 15)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "GL Account :"
        '
        'txtgl
        '
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
        Me.txtgl.EditorControl.ShowGroupPanel = False
        Me.txtgl.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl.EditorControl.TabIndex = 0
        Me.txtgl.Location = New System.Drawing.Point(436, 287)
        Me.txtgl.Name = "txtgl"
        Me.txtgl.Size = New System.Drawing.Size(110, 26)
        Me.txtgl.TabIndex = 60
        Me.txtgl.TabStop = False
        '
        'frm_adjustingentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(556, 425)
        Me.Controls.Add(Me.dtgrid_gl)
        Me.Controls.Add(Me.txtgl)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtcoll_date)
        Me.Controls.Add(Me.txtadv_int)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtcbu)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbopay_type)
        Me.Controls.Add(Me.bttnclose)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtadvprn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkprndue)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.dttrn)
        Me.Controls.Add(Me.txtcf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsa_amount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtintdue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprnpaid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chksavings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_adjustingentry"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjusting Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_gl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlno As System.Windows.Forms.TextBox
    Friend WithEvents txtprnpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtintdue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsa_amount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcf As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dttrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkprndue As System.Windows.Forms.CheckBox
    Friend WithEvents chksavings As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblprnbal As System.Windows.Forms.Label
    Friend WithEvents txtadvprn As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblintbal As System.Windows.Forms.Label
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnclose As Telerik.WinControls.UI.RadButton
    Friend WithEvents cbopay_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcbu As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtadv_int As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcoll_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgrid_gl As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtgl As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class
