<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sss_masterFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sss_masterFile))
        Me.lstsssmaster = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpaname = New System.Windows.Forms.Label()
        Me.lblpano = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttnnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttnedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lstsssledger = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.NewMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSSRemitanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstsssmaster
        '
        Me.lstsssmaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstsssmaster.BackColor = System.Drawing.Color.White
        Me.lstsssmaster.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstsssmaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstsssmaster.FullRowSelect = True
        Me.lstsssmaster.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstsssmaster.Location = New System.Drawing.Point(0, 28)
        Me.lstsssmaster.Name = "lstsssmaster"
        Me.lstsssmaster.Size = New System.Drawing.Size(1232, 226)
        Me.lstsssmaster.TabIndex = 5
        Me.lstsssmaster.UseCompatibleStateImageBehavior = False
        Me.lstsssmaster.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SSS No."
        Me.ColumnHeader5.Width = 166
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BirthDate"
        Me.ColumnHeader6.Width = 235
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Members Name"
        Me.ColumnHeader7.Width = 300
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SSS Balance"
        Me.ColumnHeader2.Width = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PA No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(726, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PA Name"
        '
        'lblpaname
        '
        Me.lblpaname.AutoSize = True
        Me.lblpaname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpaname.Location = New System.Drawing.Point(805, 4)
        Me.lblpaname.Name = "lblpaname"
        Me.lblpaname.Size = New System.Drawing.Size(320, 16)
        Me.lblpaname.TabIndex = 9
        Me.lblpaname.Text = "COOLWAY MULTI-PURPOSE COOPERATIVE"
        '
        'lblpano
        '
        Me.lblpano.AutoSize = True
        Me.lblpano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpano.Location = New System.Drawing.Point(613, 4)
        Me.lblpano.Name = "lblpano"
        Me.lblpano.Size = New System.Drawing.Size(88, 16)
        Me.lblpano.TabIndex = 8
        Me.lblpano.Text = "6400000455"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttnnew, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.bttnedit, Me.ToolStripSeparator2, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1235, 25)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttnnew
        '
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(67, 22)
        Me.bttnnew.Text = "Deposit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bttnedit
        '
        Me.bttnedit.Image = CType(resources.GetObject("bttnedit.Image"), System.Drawing.Image)
        Me.bttnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(71, 22)
        Me.bttnedit.Text = "Edit Info"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(394, 260)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(481, 26)
        Me.txtsearch.TabIndex = 11
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstsssledger
        '
        Me.lstsssledger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstsssledger.BackColor = System.Drawing.Color.AliceBlue
        Me.lstsssledger.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader9})
        Me.lstsssledger.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstsssledger.FullRowSelect = True
        Me.lstsssledger.Location = New System.Drawing.Point(0, 293)
        Me.lstsssledger.Margin = New System.Windows.Forms.Padding(4)
        Me.lstsssledger.MultiSelect = False
        Me.lstsssledger.Name = "lstsssledger"
        Me.lstsssledger.Size = New System.Drawing.Size(1235, 207)
        Me.lstsssledger.TabIndex = 207
        Me.lstsssledger.UseCompatibleStateImageBehavior = False
        Me.lstsssledger.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Posting Date"
        Me.ColumnHeader3.Width = 127
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Post No."
        Me.ColumnHeader4.Width = 112
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Post Mode"
        Me.ColumnHeader8.Width = 118
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Debit"
        Me.ColumnHeader10.Width = 128
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Credit"
        Me.ColumnHeader11.Width = 123
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Running Balance"
        Me.ColumnHeader13.Width = 129
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Reference"
        Me.ColumnHeader14.Width = 131
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Remarks"
        Me.ColumnHeader15.Width = 235
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "User"
        Me.ColumnHeader16.Width = 89
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "System Date"
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Active"
        Me.ColumnHeader9.Width = 0
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton1.Text = "Withdraw"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMembersToolStripMenuItem, Me.SSSRemitanceToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripSplitButton1.Text = "Export"
        '
        'NewMembersToolStripMenuItem
        '
        Me.NewMembersToolStripMenuItem.Name = "NewMembersToolStripMenuItem"
        Me.NewMembersToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewMembersToolStripMenuItem.Text = "New Members"
        '
        'SSSRemitanceToolStripMenuItem
        '
        Me.SSSRemitanceToolStripMenuItem.Name = "SSSRemitanceToolStripMenuItem"
        Me.SSSRemitanceToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SSSRemitanceToolStripMenuItem.Text = "SSS Remittance"
        '
        'frm_sss_masterFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1235, 502)
        Me.Controls.Add(Me.lstsssledger)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lblpaname)
        Me.Controls.Add(Me.lblpano)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstsssmaster)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_sss_masterFile"
        Me.Text = "SSS Master File"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstsssmaster As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblpaname As System.Windows.Forms.Label
    Friend WithEvents lblpano As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents lstsssledger As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents NewMembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSSRemitanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
