<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_deposit))
        Me.txtpmode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtrmrks = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamnt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsavings = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttn_save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttn_saveclose = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.LinkLabel()
        Me.pnAccess = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaccess = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavings.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavings.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnAccess.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtpmode.NestedRadGridView
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
        Me.txtpmode.Location = New System.Drawing.Point(319, 188)
        Me.txtpmode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpmode.Name = "txtpmode"
        Me.txtpmode.Size = New System.Drawing.Size(253, 31)
        Me.txtpmode.TabIndex = 1
        Me.txtpmode.TabStop = False
        '
        'txtrmrks
        '
        Me.txtrmrks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtrmrks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtrmrks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrmrks.FormattingEnabled = True
        Me.txtrmrks.Items.AddRange(New Object() {"CASH", "DM"})
        Me.txtrmrks.Location = New System.Drawing.Point(33, 132)
        Me.txtrmrks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrmrks.Name = "txtrmrks"
        Me.txtrmrks.Size = New System.Drawing.Size(539, 28)
        Me.txtrmrks.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Remarks :"
        '
        'txtamnt
        '
        Me.txtamnt.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamnt.ForeColor = System.Drawing.Color.Lime
        Me.txtamnt.Location = New System.Drawing.Point(319, 254)
        Me.txtamnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.Size = New System.Drawing.Size(249, 46)
        Me.txtamnt.TabIndex = 4
        Me.txtamnt.Text = "0"
        Me.txtamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(315, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(280, 78)
        Me.txtref.Margin = New System.Windows.Forms.Padding(4)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(292, 29)
        Me.txtref.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(276, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reference :"
        '
        'txtpdate
        '
        Me.txtpdate.Enabled = False
        Me.txtpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtpdate.Location = New System.Drawing.Point(33, 76)
        Me.txtpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdate.Name = "txtpdate"
        Me.txtpdate.Size = New System.Drawing.Size(233, 30)
        Me.txtpdate.TabIndex = 0
        Me.txtpdate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posting Date :"
        '
        'txtsavings
        '
        '
        'txtsavings.NestedRadGridView
        '
        Me.txtsavings.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtsavings.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsavings.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsavings.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtsavings.NestedRadGridView
        '
        Me.txtsavings.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtsavings.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtsavings.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtsavings.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtsavings.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtsavings.EditorControl.Name = "NestedRadGridView"
        Me.txtsavings.EditorControl.ReadOnly = True
        Me.txtsavings.EditorControl.ShowGroupPanel = False
        Me.txtsavings.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtsavings.EditorControl.TabIndex = 0
        Me.txtsavings.Location = New System.Drawing.Point(33, 188)
        Me.txtsavings.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsavings.Name = "txtsavings"
        Me.txtsavings.Size = New System.Drawing.Size(253, 32)
        Me.txtsavings.TabIndex = 11
        Me.txtsavings.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Savings Type :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttn_save, Me.ToolStripSeparator2, Me.bttn_saveclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(596, 27)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttn_save
        '
        Me.bttn_save.Image = CType(resources.GetObject("bttn_save.Image"), System.Drawing.Image)
        Me.bttn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttn_save.Name = "bttn_save"
        Me.bttn_save.Size = New System.Drawing.Size(56, 24)
        Me.bttn_save.Text = "Post"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'bttn_saveclose
        '
        Me.bttn_saveclose.Image = CType(resources.GetObject("bttn_saveclose.Image"), System.Drawing.Image)
        Me.bttn_saveclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttn_saveclose.Name = "bttn_saveclose"
        Me.bttn_saveclose.Size = New System.Drawing.Size(73, 24)
        Me.bttn_saveclose.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(315, 163)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Post Mode :"
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.Location = New System.Drawing.Point(142, 56)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(55, 16)
        Me.lblchange.TabIndex = 126
        Me.lblchange.TabStop = True
        Me.lblchange.Text = "Change"
        '
        'pnAccess
        '
        Me.pnAccess.BackColor = System.Drawing.Color.Teal
        Me.pnAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnAccess.Controls.Add(Me.Button2)
        Me.pnAccess.Controls.Add(Me.Button1)
        Me.pnAccess.Controls.Add(Me.Label6)
        Me.pnAccess.Controls.Add(Me.txtaccess)
        Me.pnAccess.Controls.Add(Me.PictureBox1)
        Me.pnAccess.Location = New System.Drawing.Point(85, 71)
        Me.pnAccess.Name = "pnAccess"
        Me.pnAccess.Size = New System.Drawing.Size(426, 170)
        Me.pnAccess.TabIndex = 219
        Me.pnAccess.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(336, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 37)
        Me.Button2.TabIndex = 212
        Me.Button2.Text = "GO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(389, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 24)
        Me.Button1.TabIndex = 211
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(63, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Enter Password"
        '
        'txtaccess
        '
        Me.txtaccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaccess.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaccess.Location = New System.Drawing.Point(64, 96)
        Me.txtaccess.MaxLength = 30
        Me.txtaccess.Name = "txtaccess"
        Me.txtaccess.Size = New System.Drawing.Size(281, 44)
        Me.txtaccess.TabIndex = 208
        Me.txtaccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtaccess.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(162, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 210
        Me.PictureBox1.TabStop = False
        '
        'frm_deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(596, 313)
        Me.Controls.Add(Me.pnAccess)
        Me.Controls.Add(Me.lblchange)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsavings)
        Me.Controls.Add(Me.txtpmode)
        Me.Controls.Add(Me.txtrmrks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpdate)
        Me.Controls.Add(Me.txtamnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_deposit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Deposit"
        CType(Me.txtpmode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavings.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavings.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnAccess.ResumeLayout(False)
        Me.pnAccess.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtrmrks As System.Windows.Forms.ComboBox
    Friend WithEvents txtpmode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtsavings As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttn_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttn_saveclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblchange As System.Windows.Forms.LinkLabel
    Friend WithEvents pnAccess As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtaccess As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
