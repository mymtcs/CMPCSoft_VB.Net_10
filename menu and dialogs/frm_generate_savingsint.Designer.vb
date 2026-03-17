<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_generate_savingsint
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
        Me.lstsa = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bttnupload = New System.Windows.Forms.Button()
        Me.cbo_remarks = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpmode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblttl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.lbldata = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bttn_export = New Telerik.WinControls.UI.RadButton()
        Me.txtsa = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.pncomputed = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotalcomp = New System.Windows.Forms.Label()
        Me.lblaccount = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lstadb = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.btnComputeInt = New System.Windows.Forms.Button()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttn_export, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsa.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsa.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pncomputed.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstsa
        '
        Me.lstsa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstsa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstsa.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstsa.FullRowSelect = True
        Me.lstsa.GridLines = True
        Me.lstsa.Location = New System.Drawing.Point(3, 70)
        Me.lstsa.Margin = New System.Windows.Forms.Padding(4)
        Me.lstsa.Name = "lstsa"
        Me.lstsa.Size = New System.Drawing.Size(1217, 449)
        Me.lstsa.TabIndex = 10
        Me.lstsa.UseCompatibleStateImageBehavior = False
        Me.lstsa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Account Number"
        Me.ColumnHeader7.Width = 272
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Account Name"
        Me.ColumnHeader8.Width = 268
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Savings Interest"
        Me.ColumnHeader3.Width = 131
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Post No"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Month Dormant"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance As of."
        Me.ColumnHeader6.Width = 120
        '
        'bttnupload
        '
        Me.bttnupload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnupload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttnupload.Enabled = False
        Me.bttnupload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnupload.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnupload.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttnupload.Location = New System.Drawing.Point(1140, 19)
        Me.bttnupload.Name = "bttnupload"
        Me.bttnupload.Size = New System.Drawing.Size(70, 35)
        Me.bttnupload.TabIndex = 13
        Me.bttnupload.Text = "Upload"
        Me.bttnupload.UseVisualStyleBackColor = False
        '
        'cbo_remarks
        '
        Me.cbo_remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_remarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_remarks.FormattingEnabled = True
        Me.cbo_remarks.Items.AddRange(New Object() {"1st Quarter Interest (Computer generated)", "2nd Quarter Interest (Computer generated)", "3rd Quarter Interest (Computer generated)", "4th Quarter Interest (Computer generated)"})
        Me.cbo_remarks.Location = New System.Drawing.Point(688, 30)
        Me.cbo_remarks.Name = "cbo_remarks"
        Me.cbo_remarks.Size = New System.Drawing.Size(264, 24)
        Me.cbo_remarks.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(688, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Remarks :"
        '
        'txtpmode
        '
        '
        'txtpmode.NestedRadGridView
        '
        Me.txtpmode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtpmode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpmode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpmode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtpmode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtpmode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtpmode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtpmode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtpmode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtpmode.EditorControl.Name = "NestedRadGridView"
        Me.txtpmode.EditorControl.ReadOnly = True
        Me.txtpmode.EditorControl.ShowGroupPanel = False
        Me.txtpmode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtpmode.EditorControl.TabIndex = 0
        Me.txtpmode.Location = New System.Drawing.Point(524, 30)
        Me.txtpmode.Name = "txtpmode"
        Me.txtpmode.Size = New System.Drawing.Size(155, 24)
        Me.txtpmode.TabIndex = 17
        Me.txtpmode.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(526, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Post Mode :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(935, 524)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Interest :"
        '
        'lblttl
        '
        Me.lblttl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblttl.AutoSize = True
        Me.lblttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblttl.ForeColor = System.Drawing.Color.Red
        Me.lblttl.Location = New System.Drawing.Point(1016, 526)
        Me.lblttl.Name = "lblttl"
        Me.lblttl.Size = New System.Drawing.Size(58, 25)
        Me.lblttl.TabIndex = 22
        Me.lblttl.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(389, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "To"
        '
        'dtto
        '
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(389, 32)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(129, 22)
        Me.dtto.TabIndex = 23
        Me.dtto.Value = New Date(2015, 10, 12, 0, 0, 0, 0)
        '
        'lbldata
        '
        Me.lbldata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldata.AutoSize = True
        Me.lbldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldata.ForeColor = System.Drawing.Color.Red
        Me.lbldata.Location = New System.Drawing.Point(851, 523)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(58, 25)
        Me.lbldata.TabIndex = 27
        Me.lbldata.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(770, 521)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Data Found :"
        '
        'bttn_export
        '
        Me.bttn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttn_export.Location = New System.Drawing.Point(3, 526)
        Me.bttn_export.Name = "bttn_export"
        Me.bttn_export.Size = New System.Drawing.Size(110, 24)
        Me.bttn_export.TabIndex = 28
        Me.bttn_export.Text = "Export to Excel"
        '
        'txtsa
        '
        '
        'txtsa.NestedRadGridView
        '
        Me.txtsa.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtsa.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsa.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsa.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtsa.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtsa.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtsa.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtsa.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtsa.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtsa.EditorControl.Name = "NestedRadGridView"
        Me.txtsa.EditorControl.ReadOnly = True
        Me.txtsa.EditorControl.ShowGroupPanel = False
        Me.txtsa.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtsa.EditorControl.TabIndex = 0
        Me.txtsa.Location = New System.Drawing.Point(12, 30)
        Me.txtsa.Name = "txtsa"
        Me.txtsa.Size = New System.Drawing.Size(212, 24)
        Me.txtsa.TabIndex = 29
        Me.txtsa.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Savings Type"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(937, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 35)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Compute (old)"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton1.Location = New System.Drawing.Point(132, 526)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(132, 24)
        Me.RadButton1.TabIndex = 32
        Me.RadButton1.Text = "Show Computation"
        '
        'pncomputed
        '
        Me.pncomputed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pncomputed.BackColor = System.Drawing.Color.Gray
        Me.pncomputed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pncomputed.Controls.Add(Me.Label7)
        Me.pncomputed.Controls.Add(Me.lbltotalcomp)
        Me.pncomputed.Controls.Add(Me.lblaccount)
        Me.pncomputed.Controls.Add(Me.Button4)
        Me.pncomputed.Controls.Add(Me.lstadb)
        Me.pncomputed.Location = New System.Drawing.Point(704, 42)
        Me.pncomputed.Name = "pncomputed"
        Me.pncomputed.Size = New System.Drawing.Size(516, 476)
        Me.pncomputed.TabIndex = 33
        Me.pncomputed.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(3, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Total Interest :"
        '
        'lbltotalcomp
        '
        Me.lbltotalcomp.AutoSize = True
        Me.lbltotalcomp.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcomp.ForeColor = System.Drawing.Color.White
        Me.lbltotalcomp.Location = New System.Drawing.Point(84, 444)
        Me.lbltotalcomp.Name = "lbltotalcomp"
        Me.lbltotalcomp.Size = New System.Drawing.Size(33, 18)
        Me.lbltotalcomp.TabIndex = 28
        Me.lbltotalcomp.Text = "0.00"
        '
        'lblaccount
        '
        Me.lblaccount.AutoSize = True
        Me.lblaccount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccount.ForeColor = System.Drawing.Color.White
        Me.lblaccount.Location = New System.Drawing.Point(13, 13)
        Me.lblaccount.Name = "lblaccount"
        Me.lblaccount.Size = New System.Drawing.Size(30, 23)
        Me.lblaccount.TabIndex = 13
        Me.lblaccount.Text = "...."
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(470, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 27)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lstadb
        '
        Me.lstadb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstadb.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader4})
        Me.lstadb.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstadb.FullRowSelect = True
        Me.lstadb.GridLines = True
        Me.lstadb.Location = New System.Drawing.Point(4, 48)
        Me.lstadb.Margin = New System.Windows.Forms.Padding(4)
        Me.lstadb.Name = "lstadb"
        Me.lstadb.Size = New System.Drawing.Size(506, 390)
        Me.lstadb.TabIndex = 11
        Me.lstadb.UseCompatibleStateImageBehavior = False
        Me.lstadb.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Post No."
        Me.ColumnHeader11.Width = 64
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Posting Date"
        Me.ColumnHeader12.Width = 110
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Day Range"
        Me.ColumnHeader13.Width = 73
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Balance"
        Me.ColumnHeader14.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ADI"
        Me.ColumnHeader4.Width = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(254, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "From"
        '
        'dtfrom
        '
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(254, 32)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(129, 22)
        Me.dtfrom.TabIndex = 34
        Me.dtfrom.Value = New Date(2015, 10, 12, 0, 0, 0, 0)
        '
        'btnComputeInt
        '
        Me.btnComputeInt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComputeInt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnComputeInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComputeInt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeInt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComputeInt.Location = New System.Drawing.Point(1036, 19)
        Me.btnComputeInt.Name = "btnComputeInt"
        Me.btnComputeInt.Size = New System.Drawing.Size(96, 35)
        Me.btnComputeInt.TabIndex = 36
        Me.btnComputeInt.Text = "Compute Now"
        Me.btnComputeInt.UseVisualStyleBackColor = False
        '
        'frm_generate_savingsint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 556)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.pncomputed)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsa)
        Me.Controls.Add(Me.bttn_export)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.lblttl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpmode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_remarks)
        Me.Controls.Add(Me.bttnupload)
        Me.Controls.Add(Me.lstsa)
        Me.Controls.Add(Me.btnComputeInt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_generate_savingsint"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Savings Interest Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtpmode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttn_export, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsa.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsa.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pncomputed.ResumeLayout(False)
        Me.pncomputed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lstsa As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnupload As System.Windows.Forms.Button
    Friend WithEvents cbo_remarks As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpmode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblttl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents bttn_export As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtsa As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents pncomputed As System.Windows.Forms.Panel
    Public WithEvents lstadb As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblaccount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotalcomp As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnComputeInt As System.Windows.Forms.Button
End Class
