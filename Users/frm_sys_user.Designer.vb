<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sys_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sys_user))
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lstdropdown = New System.Windows.Forms.ListView()
        Me.ItemCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.txtusertype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_replace = New Telerik.WinControls.UI.RadButton()
        Me.grp_replace = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rp_txtusertype = New System.Windows.Forms.ComboBox()
        Me.rp_txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rp_txtname = New System.Windows.Forms.TextBox()
        Me.btn_expired = New Telerik.WinControls.UI.RadButton()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_replace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_replace.SuspendLayout()
        CType(Me.btn_expired, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(636, 88)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(222, 22)
        Me.txtid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(633, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(633, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Complete Name"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(636, 36)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(222, 22)
        Me.txtname.TabIndex = 0
        '
        'lstdropdown
        '
        Me.lstdropdown.BackColor = System.Drawing.Color.AliceBlue
        Me.lstdropdown.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemCode, Me.ItemName, Me.ItemPrice, Me.ColumnHeader1})
        Me.lstdropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstdropdown.FullRowSelect = True
        Me.lstdropdown.Location = New System.Drawing.Point(7, 11)
        Me.lstdropdown.Name = "lstdropdown"
        Me.lstdropdown.Size = New System.Drawing.Size(623, 504)
        Me.lstdropdown.TabIndex = 25
        Me.lstdropdown.UseCompatibleStateImageBehavior = False
        Me.lstdropdown.View = System.Windows.Forms.View.Details
        '
        'ItemCode
        '
        Me.ItemCode.Text = "Complete Name"
        Me.ItemCode.Width = 151
        '
        'ItemName
        '
        Me.ItemName.Text = "User ID"
        Me.ItemName.Width = 106
        '
        'ItemPrice
        '
        Me.ItemPrice.Text = "Type"
        Me.ItemPrice.Width = 95
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Workstation"
        Me.ColumnHeader1.Width = 147
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.Location = New System.Drawing.Point(783, 393)
        Me.bttnnew.Name = "bttnnew"
        '
        '
        '
        Me.bttnnew.RootElement.ControlBounds = New System.Drawing.Rectangle(783, 434, 110, 24)
        Me.bttnnew.Size = New System.Drawing.Size(75, 35)
        Me.bttnnew.TabIndex = 204
        Me.bttnnew.Text = "New"
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.Location = New System.Drawing.Point(701, 393)
        Me.bttnsave.Name = "bttnsave"
        '
        '
        '
        Me.bttnsave.RootElement.ControlBounds = New System.Drawing.Rectangle(701, 434, 110, 24)
        Me.bttnsave.Size = New System.Drawing.Size(75, 35)
        Me.bttnsave.TabIndex = 203
        Me.bttnsave.Text = "Save"
        '
        'txtusertype
        '
        Me.txtusertype.FormattingEnabled = True
        Me.txtusertype.Items.AddRange(New Object() {"Admin", "Cashier", "Bookkeeper", "Accounting", "Audit"})
        Me.txtusertype.Location = New System.Drawing.Point(636, 138)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.Size = New System.Drawing.Size(222, 21)
        Me.txtusertype.TabIndex = 205
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(633, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "User Type :"
        '
        'btn_replace
        '
        Me.btn_replace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_replace.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_replace.Image = CType(resources.GetObject("btn_replace.Image"), System.Drawing.Image)
        Me.btn_replace.Location = New System.Drawing.Point(783, 434)
        Me.btn_replace.Name = "btn_replace"
        '
        '
        '
        Me.btn_replace.RootElement.ControlBounds = New System.Drawing.Rectangle(783, 475, 110, 24)
        Me.btn_replace.Size = New System.Drawing.Size(75, 35)
        Me.btn_replace.TabIndex = 205
        Me.btn_replace.Text = "      Replace"
        '
        'grp_replace
        '
        Me.grp_replace.Controls.Add(Me.Label2)
        Me.grp_replace.Controls.Add(Me.Label3)
        Me.grp_replace.Controls.Add(Me.rp_txtusertype)
        Me.grp_replace.Controls.Add(Me.rp_txtid)
        Me.grp_replace.Controls.Add(Me.Label5)
        Me.grp_replace.Controls.Add(Me.rp_txtname)
        Me.grp_replace.Location = New System.Drawing.Point(636, 183)
        Me.grp_replace.Name = "grp_replace"
        Me.grp_replace.Size = New System.Drawing.Size(222, 187)
        Me.grp_replace.TabIndex = 207
        Me.grp_replace.TabStop = False
        Me.grp_replace.Text = "Replacement form"
        Me.grp_replace.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "User Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "Complete Name"
        '
        'rp_txtusertype
        '
        Me.rp_txtusertype.FormattingEnabled = True
        Me.rp_txtusertype.Items.AddRange(New Object() {"Admin", "Cashier", "Bookkeeper", "Accounting", "Audit"})
        Me.rp_txtusertype.Location = New System.Drawing.Point(9, 145)
        Me.rp_txtusertype.Name = "rp_txtusertype"
        Me.rp_txtusertype.Size = New System.Drawing.Size(207, 21)
        Me.rp_txtusertype.TabIndex = 212
        '
        'rp_txtid
        '
        Me.rp_txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rp_txtid.Location = New System.Drawing.Point(9, 95)
        Me.rp_txtid.Name = "rp_txtid"
        Me.rp_txtid.Size = New System.Drawing.Size(207, 22)
        Me.rp_txtid.TabIndex = 209
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "User ID"
        '
        'rp_txtname
        '
        Me.rp_txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rp_txtname.Location = New System.Drawing.Point(9, 43)
        Me.rp_txtname.Name = "rp_txtname"
        Me.rp_txtname.Size = New System.Drawing.Size(207, 22)
        Me.rp_txtname.TabIndex = 208
        '
        'btn_expired
        '
        Me.btn_expired.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_expired.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_expired.Location = New System.Drawing.Point(701, 475)
        Me.btn_expired.Name = "btn_expired"
        '
        '
        '
        Me.btn_expired.RootElement.ControlBounds = New System.Drawing.Rectangle(783, 393, 110, 24)
        Me.btn_expired.Size = New System.Drawing.Size(157, 35)
        Me.btn_expired.TabIndex = 205
        Me.btn_expired.Text = "Delete Expired Users"
        '
        'frm_sys_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(870, 527)
        Me.Controls.Add(Me.btn_expired)
        Me.Controls.Add(Me.grp_replace)
        Me.Controls.Add(Me.btn_replace)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtusertype)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.lstdropdown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_sys_user"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New User"
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_replace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_replace.ResumeLayout(False)
        Me.grp_replace.PerformLayout()
        CType(Me.btn_expired, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents lstdropdown As System.Windows.Forms.ListView
    Friend WithEvents ItemCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtusertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Private WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Private WithEvents btn_replace As Telerik.WinControls.UI.RadButton
    Friend WithEvents grp_replace As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rp_txtusertype As System.Windows.Forms.ComboBox
    Friend WithEvents rp_txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rp_txtname As System.Windows.Forms.TextBox
    Private WithEvents btn_expired As Telerik.WinControls.UI.RadButton
End Class
