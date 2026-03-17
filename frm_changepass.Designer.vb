<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sys_users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sys_users))
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnewpass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtrepass = New System.Windows.Forms.TextBox
        Me.bttnnew = New Telerik.WinControls.UI.RadButton
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(36, 57)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(222, 24)
        Me.txtpass.TabIndex = 0
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Old Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter New Password:"
        '
        'txtnewpass
        '
        Me.txtnewpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpass.Location = New System.Drawing.Point(36, 107)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(222, 24)
        Me.txtnewpass.TabIndex = 2
        Me.txtnewpass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Re-Type New Password:"
        '
        'txtrepass
        '
        Me.txtrepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepass.Location = New System.Drawing.Point(36, 157)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.Size = New System.Drawing.Size(222, 24)
        Me.txtrepass.TabIndex = 4
        Me.txtrepass.UseSystemPasswordChar = True
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.Location = New System.Drawing.Point(183, 201)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(75, 35)
        Me.bttnnew.TabIndex = 206
        Me.bttnnew.Text = "Close"
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.Location = New System.Drawing.Point(102, 201)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(75, 35)
        Me.bttnsave.TabIndex = 205
        Me.bttnsave.Text = "Save"
        '
        'frm_sys_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(284, 248)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrepass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_sys_users"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtrepass As System.Windows.Forms.TextBox
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
End Class
