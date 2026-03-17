<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_importCBUdividen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_importCBUdividen))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttnimport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttncompute = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtgrd_cbu = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblfilename = New System.Windows.Forms.Label()
        Me.lstcbu = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtttlavg = New System.Windows.Forms.TextBox()
        Me.txtrecord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dtgrd_cbu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttnimport, Me.ToolStripSeparator1, Me.bttncompute, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(926, 25)
        Me.ToolStrip1.TabIndex = 127
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttnimport
        '
        Me.bttnimport.Image = CType(resources.GetObject("bttnimport.Image"), System.Drawing.Image)
        Me.bttnimport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnimport.Name = "bttnimport"
        Me.bttnimport.Size = New System.Drawing.Size(63, 22)
        Me.bttnimport.Text = "Import"
        Me.bttnimport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bttncompute
        '
        Me.bttncompute.Image = CType(resources.GetObject("bttncompute.Image"), System.Drawing.Image)
        Me.bttncompute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttncompute.Name = "bttncompute"
        Me.bttncompute.Size = New System.Drawing.Size(65, 22)
        Me.bttncompute.Text = "Upload"
        Me.bttncompute.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'dtgrd_cbu
        '
        Me.dtgrd_cbu.AllowUserToAddRows = False
        Me.dtgrd_cbu.AllowUserToDeleteRows = False
        Me.dtgrd_cbu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrd_cbu.BackgroundColor = System.Drawing.Color.White
        Me.dtgrd_cbu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrd_cbu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column1, Me.Column2, Me.Column3})
        Me.dtgrd_cbu.Location = New System.Drawing.Point(0, 29)
        Me.dtgrd_cbu.Name = "dtgrd_cbu"
        Me.dtgrd_cbu.ReadOnly = True
        Me.dtgrd_cbu.RowHeadersWidth = 30
        Me.dtgrd_cbu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrd_cbu.Size = New System.Drawing.Size(926, 537)
        Me.dtgrd_cbu.TabIndex = 128
        '
        'Column12
        '
        Me.Column12.HeaderText = "CBU Account"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 180
        '
        'Column13
        '
        Me.Column13.HeaderText = "Account Name"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 180
        '
        'Column14
        '
        Me.Column14.HeaderText = "Balance"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Average"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Dividen"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Remarks"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Reference"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblfilename
        '
        Me.lblfilename.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfilename.AutoSize = True
        Me.lblfilename.Location = New System.Drawing.Point(4, 597)
        Me.lblfilename.Name = "lblfilename"
        Me.lblfilename.Size = New System.Drawing.Size(65, 14)
        Me.lblfilename.TabIndex = 129
        Me.lblfilename.Text = "Filename.."
        '
        'lstcbu
        '
        Me.lstcbu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstcbu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader15, Me.ColumnHeader5})
        Me.lstcbu.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcbu.FullRowSelect = True
        Me.lstcbu.GridLines = True
        Me.lstcbu.Location = New System.Drawing.Point(743, 28)
        Me.lstcbu.Name = "lstcbu"
        Me.lstcbu.Size = New System.Drawing.Size(220, 515)
        Me.lstcbu.TabIndex = 130
        Me.lstcbu.UseCompatibleStateImageBehavior = False
        Me.lstcbu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CBU Account"
        Me.ColumnHeader10.Width = 107
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Account Name"
        Me.ColumnHeader11.Width = 170
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Balance"
        Me.ColumnHeader12.Width = 92
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Average"
        Me.ColumnHeader15.Width = 84
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Dividen"
        Me.ColumnHeader5.Width = 100
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(601, 572)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 14)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Total Average :"
        '
        'txtttlavg
        '
        Me.txtttlavg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtttlavg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtttlavg.Location = New System.Drawing.Point(604, 589)
        Me.txtttlavg.Name = "txtttlavg"
        Me.txtttlavg.ReadOnly = True
        Me.txtttlavg.Size = New System.Drawing.Size(97, 22)
        Me.txtttlavg.TabIndex = 132
        '
        'txtrecord
        '
        Me.txtrecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrecord.Location = New System.Drawing.Point(707, 589)
        Me.txtrecord.Name = "txtrecord"
        Me.txtrecord.ReadOnly = True
        Me.txtrecord.Size = New System.Drawing.Size(97, 22)
        Me.txtrecord.TabIndex = 134
        Me.txtrecord.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(704, 572)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 14)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Record Uploaded :"
        '
        'txtamount
        '
        Me.txtamount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount.Location = New System.Drawing.Point(810, 589)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(97, 22)
        Me.txtamount.TabIndex = 136
        Me.txtamount.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(807, 572)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 14)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Amount Uploaded :"
        '
        'frm_importCBUdividen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(926, 614)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrecord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtttlavg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblfilename)
        Me.Controls.Add(Me.dtgrd_cbu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstcbu)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_importCBUdividen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import CBU Dividen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dtgrd_cbu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttnimport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttncompute As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtgrd_cbu As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblfilename As System.Windows.Forms.Label
    Friend WithEvents lstcbu As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtttlavg As System.Windows.Forms.TextBox
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtrecord As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
