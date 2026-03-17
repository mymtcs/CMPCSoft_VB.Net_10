<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newcenter
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsitio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbarangay = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmunicipal = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprovince = New System.Windows.Forms.ComboBox()
        Me.txtsaacct = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtctrcode = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtsched = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtloantype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtcoll = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.lblgenerate = New System.Windows.Forms.LinkLabel()
        Me.pn_members = New System.Windows.Forms.Panel()
        Me.txtsearch = New Telerik.WinControls.UI.RadTextBox()
        Me.dtgridmembers = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblclient = New System.Windows.Forms.LinkLabel()
        Me.txtmemcode = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtfullname = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_members.SuspendLayout()
        CType(Me.txtsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgridmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmemcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfullname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(24, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Loantype  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtsitio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtbarangay)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtmunicipal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtprovince)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 85)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(430, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Sitio :"
        '
        'txtsitio
        '
        Me.txtsitio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtsitio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtsitio.DropDownHeight = 170
        Me.txtsitio.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsitio.FormattingEnabled = True
        Me.txtsitio.IntegralHeight = False
        Me.txtsitio.Location = New System.Drawing.Point(475, 46)
        Me.txtsitio.Name = "txtsitio"
        Me.txtsitio.Size = New System.Drawing.Size(200, 25)
        Me.txtsitio.TabIndex = 21
        Me.txtsitio.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(401, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Barangay :"
        '
        'txtbarangay
        '
        Me.txtbarangay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtbarangay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtbarangay.DropDownHeight = 170
        Me.txtbarangay.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarangay.FormattingEnabled = True
        Me.txtbarangay.IntegralHeight = False
        Me.txtbarangay.Location = New System.Drawing.Point(475, 19)
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(200, 25)
        Me.txtbarangay.TabIndex = 19
        Me.txtbarangay.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(15, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Municipal/Town :"
        '
        'txtmunicipal
        '
        Me.txtmunicipal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtmunicipal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtmunicipal.DropDownHeight = 170
        Me.txtmunicipal.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmunicipal.FormattingEnabled = True
        Me.txtmunicipal.IntegralHeight = False
        Me.txtmunicipal.Location = New System.Drawing.Point(126, 49)
        Me.txtmunicipal.Name = "txtmunicipal"
        Me.txtmunicipal.Size = New System.Drawing.Size(246, 25)
        Me.txtmunicipal.TabIndex = 17
        Me.txtmunicipal.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(56, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Province :"
        '
        'txtprovince
        '
        Me.txtprovince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtprovince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtprovince.DropDownHeight = 70
        Me.txtprovince.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprovince.FormattingEnabled = True
        Me.txtprovince.IntegralHeight = False
        Me.txtprovince.Location = New System.Drawing.Point(126, 22)
        Me.txtprovince.Name = "txtprovince"
        Me.txtprovince.Size = New System.Drawing.Size(246, 25)
        Me.txtprovince.TabIndex = 15
        Me.txtprovince.TabStop = False
        '
        'txtsaacct
        '
        Me.txtsaacct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsaacct.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaacct.Location = New System.Drawing.Point(389, 196)
        Me.txtsaacct.MaxLength = 30
        Me.txtsaacct.Name = "txtsaacct"
        Me.txtsaacct.ReadOnly = True
        Me.txtsaacct.Size = New System.Drawing.Size(305, 25)
        Me.txtsaacct.TabIndex = 30
        Me.txtsaacct.Text = "(Auto generated)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(384, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Savings Account :"
        '
        'txtctrcode
        '
        Me.txtctrcode.BackColor = System.Drawing.Color.White
        Me.txtctrcode.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtctrcode.Location = New System.Drawing.Point(288, 46)
        Me.txtctrcode.MaxLength = 30
        Me.txtctrcode.Name = "txtctrcode"
        Me.txtctrcode.Size = New System.Drawing.Size(95, 25)
        Me.txtctrcode.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(285, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 15)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Code :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(585, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 15)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Schedule :"
        '
        'txtsched
        '
        Me.txtsched.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtsched.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtsched.DropDownHeight = 70
        Me.txtsched.Font = New System.Drawing.Font("Perpetua", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsched.FormattingEnabled = True
        Me.txtsched.IntegralHeight = False
        Me.txtsched.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.txtsched.Location = New System.Drawing.Point(588, 46)
        Me.txtsched.Name = "txtsched"
        Me.txtsched.Size = New System.Drawing.Size(99, 25)
        Me.txtsched.TabIndex = 39
        Me.txtsched.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(384, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 15)
        Me.Label19.TabIndex = 205
        Me.Label19.Text = "Account Officer :"
        '
        'txtloantype
        '
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
        Me.txtloantype.Location = New System.Drawing.Point(27, 197)
        Me.txtloantype.Name = "txtloantype"
        Me.txtloantype.Size = New System.Drawing.Size(245, 24)
        Me.txtloantype.TabIndex = 209
        Me.txtloantype.TabStop = False
        '
        'txtcoll
        '
        '
        'txtcoll.NestedRadGridView
        '
        Me.txtcoll.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtcoll.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoll.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcoll.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtcoll.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtcoll.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtcoll.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtcoll.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtcoll.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtcoll.EditorControl.Name = "NestedRadGridView"
        Me.txtcoll.EditorControl.ReadOnly = True
        Me.txtcoll.EditorControl.ShowGroupPanel = False
        Me.txtcoll.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtcoll.EditorControl.TabIndex = 0
        Me.txtcoll.Location = New System.Drawing.Point(389, 46)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(190, 25)
        Me.txtcoll.TabIndex = 210
        Me.txtcoll.TabStop = False
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(515, 247)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(87, 34)
        Me.bttnsave.TabIndex = 211
        Me.bttnsave.Text = "Save"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(608, 247)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(87, 34)
        Me.RadButton1.TabIndex = 34
        Me.RadButton1.Text = "Close"
        '
        'lblgenerate
        '
        Me.lblgenerate.AutoSize = True
        Me.lblgenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblgenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgenerate.Location = New System.Drawing.Point(285, 29)
        Me.lblgenerate.Name = "lblgenerate"
        Me.lblgenerate.Size = New System.Drawing.Size(49, 13)
        Me.lblgenerate.TabIndex = 212
        Me.lblgenerate.TabStop = True
        Me.lblgenerate.Text = "generate"
        '
        'pn_members
        '
        Me.pn_members.BackColor = System.Drawing.Color.Gray
        Me.pn_members.Controls.Add(Me.txtsearch)
        Me.pn_members.Controls.Add(Me.dtgridmembers)
        Me.pn_members.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pn_members.Location = New System.Drawing.Point(27, 72)
        Me.pn_members.Name = "pn_members"
        Me.pn_members.Size = New System.Drawing.Size(280, 11)
        Me.pn_members.TabIndex = 215
        Me.pn_members.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(0, -17)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(280, 27)
        Me.txtsearch.TabIndex = 3
        Me.txtsearch.TabStop = False
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtgridmembers
        '
        Me.dtgridmembers.AllowUserToAddRows = False
        Me.dtgridmembers.AllowUserToDeleteRows = False
        Me.dtgridmembers.AllowUserToResizeColumns = False
        Me.dtgridmembers.AllowUserToResizeRows = False
        Me.dtgridmembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgridmembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgridmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgridmembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dtgridmembers.Location = New System.Drawing.Point(0, 0)
        Me.dtgridmembers.Name = "dtgridmembers"
        Me.dtgridmembers.ReadOnly = True
        Me.dtgridmembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridmembers.Size = New System.Drawing.Size(280, 3)
        Me.dtgridmembers.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Member Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fullname"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Address"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 280
        '
        'lblclient
        '
        Me.lblclient.AutoSize = True
        Me.lblclient.Location = New System.Drawing.Point(27, 29)
        Me.lblclient.Name = "lblclient"
        Me.lblclient.Size = New System.Drawing.Size(82, 13)
        Me.lblclient.TabIndex = 214
        Me.lblclient.TabStop = True
        Me.lblclient.Text = "Select Member*"
        '
        'txtmemcode
        '
        Me.txtmemcode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtmemcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmemcode.IsReadOnly = True
        Me.txtmemcode.Location = New System.Drawing.Point(27, 46)
        Me.txtmemcode.Name = "txtmemcode"
        Me.txtmemcode.Size = New System.Drawing.Size(87, 24)
        Me.txtmemcode.TabIndex = 213
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtfullname.Enabled = False
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.IsReadOnly = True
        Me.txtfullname.Location = New System.Drawing.Point(115, 46)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(165, 24)
        Me.txtfullname.TabIndex = 216
        '
        'frm_newcenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(711, 300)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.pn_members)
        Me.Controls.Add(Me.lblclient)
        Me.Controls.Add(Me.txtmemcode)
        Me.Controls.Add(Me.lblgenerate)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.txtcoll)
        Me.Controls.Add(Me.txtloantype)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtsched)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtctrcode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtsaacct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_newcenter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtloantype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_members.ResumeLayout(False)
        Me.pn_members.PerformLayout()
        CType(Me.txtsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgridmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmemcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfullname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsitio As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbarangay As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmunicipal As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprovince As System.Windows.Forms.ComboBox
    Friend WithEvents txtsaacct As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtctrcode As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtsched As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtloantype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtcoll As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblgenerate As System.Windows.Forms.LinkLabel
    Friend WithEvents pn_members As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtgridmembers As System.Windows.Forms.DataGridView
    Friend WithEvents lblclient As System.Windows.Forms.LinkLabel
    Friend WithEvents txtmemcode As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtfullname As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
