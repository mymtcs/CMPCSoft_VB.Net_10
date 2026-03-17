<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_utilities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_utilities))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblmemcode = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttncancel_transfer = New System.Windows.Forms.Button()
        Me.bttntrnsfer = New System.Windows.Forms.Button()
        Me.lstmerge = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstmerge_members = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1259, 531)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.lblmemcode)
        Me.TabPage3.Controls.Add(Me.txtsearch)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.bttncancel_transfer)
        Me.TabPage3.Controls.Add(Me.bttntrnsfer)
        Me.TabPage3.Controls.Add(Me.lstmerge)
        Me.TabPage3.Controls.Add(Me.lstmerge_members)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1251, 505)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Merging Management Form"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1143, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 27)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblmemcode
        '
        Me.lblmemcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmemcode.AutoSize = True
        Me.lblmemcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmemcode.Location = New System.Drawing.Point(958, 239)
        Me.lblmemcode.Name = "lblmemcode"
        Me.lblmemcode.Size = New System.Drawing.Size(39, 20)
        Me.lblmemcode.TabIndex = 19
        Me.lblmemcode.Text = "000"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(7, 457)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(542, 24)
        Me.txtsearch.TabIndex = 18
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(674, 237)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 27)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Merge"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(670, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Merge Center"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "List of Members"
        '
        'bttncancel_transfer
        '
        Me.bttncancel_transfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttncancel_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttncancel_transfer.Location = New System.Drawing.Point(565, 143)
        Me.bttncancel_transfer.Name = "bttncancel_transfer"
        Me.bttncancel_transfer.Size = New System.Drawing.Size(92, 27)
        Me.bttncancel_transfer.TabIndex = 14
        Me.bttncancel_transfer.Text = "<="
        Me.bttncancel_transfer.UseVisualStyleBackColor = True
        '
        'bttntrnsfer
        '
        Me.bttntrnsfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttntrnsfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttntrnsfer.Location = New System.Drawing.Point(565, 110)
        Me.bttntrnsfer.Name = "bttntrnsfer"
        Me.bttntrnsfer.Size = New System.Drawing.Size(92, 27)
        Me.bttntrnsfer.TabIndex = 13
        Me.bttntrnsfer.Text = "=>"
        Me.bttntrnsfer.UseVisualStyleBackColor = True
        '
        'lstmerge
        '
        Me.lstmerge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstmerge.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader26})
        Me.lstmerge.FullRowSelect = True
        Me.lstmerge.GridLines = True
        Me.lstmerge.Location = New System.Drawing.Point(674, 41)
        Me.lstmerge.Name = "lstmerge"
        Me.lstmerge.Size = New System.Drawing.Size(577, 190)
        Me.lstmerge.TabIndex = 12
        Me.lstmerge.UseCompatibleStateImageBehavior = False
        Me.lstmerge.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Member Code"
        Me.ColumnHeader12.Width = 94
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fullname"
        Me.ColumnHeader13.Width = 128
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Address"
        Me.ColumnHeader14.Width = 173
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Birthdate"
        Me.ColumnHeader15.Width = 80
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "CBU Balance"
        Me.ColumnHeader26.Width = 84
        '
        'lstmerge_members
        '
        Me.lstmerge_members.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstmerge_members.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader19, Me.ColumnHeader25, Me.ColumnHeader27})
        Me.lstmerge_members.FullRowSelect = True
        Me.lstmerge_members.GridLines = True
        Me.lstmerge_members.Location = New System.Drawing.Point(3, 41)
        Me.lstmerge_members.Name = "lstmerge_members"
        Me.lstmerge_members.Size = New System.Drawing.Size(546, 410)
        Me.lstmerge_members.TabIndex = 11
        Me.lstmerge_members.UseCompatibleStateImageBehavior = False
        Me.lstmerge_members.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Member Code"
        Me.ColumnHeader8.Width = 94
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Fullname"
        Me.ColumnHeader9.Width = 165
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Address"
        Me.ColumnHeader10.Width = 181
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Birthdate"
        Me.ColumnHeader11.Width = 94
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "GL"
        Me.ColumnHeader19.Width = 75
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Satus"
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "CBU"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(797, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Member Code to set as original:"
        '
        'frm_utilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1259, 531)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_utilities"
        Me.Text = "Merging Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents bttntrnsfer As System.Windows.Forms.Button
    Friend WithEvents lstmerge As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstmerge_members As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttncancel_transfer As System.Windows.Forms.Button
    Friend WithEvents lblmemcode As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
