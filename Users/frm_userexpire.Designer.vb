<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userexpire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_userexpire))
        Me.lstdropdown = New System.Windows.Forms.ListView()
        Me.ItemCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemSpecs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bttnnew = New Telerik.WinControls.UI.RadButton()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtexpire = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstdropdown
        '
        Me.lstdropdown.BackColor = System.Drawing.Color.AliceBlue
        Me.lstdropdown.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemCode, Me.ItemName, Me.ItemSpecs, Me.ItemPrice, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstdropdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstdropdown.FullRowSelect = True
        Me.lstdropdown.Location = New System.Drawing.Point(7, 11)
        Me.lstdropdown.Name = "lstdropdown"
        Me.lstdropdown.Size = New System.Drawing.Size(644, 254)
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
        'ItemSpecs
        '
        Me.ItemSpecs.Text = "Password"
        Me.ItemSpecs.Width = 0
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
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.Location = New System.Drawing.Point(578, 280)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(75, 35)
        Me.bttnnew.TabIndex = 204
        Me.bttnnew.Text = "New"
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.Location = New System.Drawing.Point(497, 280)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(75, 35)
        Me.bttnsave.TabIndex = 203
        Me.bttnsave.Text = "Save"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password Expiration"
        Me.ColumnHeader2.Width = 124
        '
        'dtexpire
        '
        Me.dtexpire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtexpire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtexpire.Location = New System.Drawing.Point(12, 288)
        Me.dtexpire.Name = "dtexpire"
        Me.dtexpire.Size = New System.Drawing.Size(119, 21)
        Me.dtexpire.TabIndex = 205
        Me.dtexpire.Value = New Date(2018, 10, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Date Expire"
        '
        'frm_userexpire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(665, 327)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtexpire)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.lstdropdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_userexpire"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New User"
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstdropdown As System.Windows.Forms.ListView
    Friend WithEvents ItemCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemSpecs As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtexpire As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
