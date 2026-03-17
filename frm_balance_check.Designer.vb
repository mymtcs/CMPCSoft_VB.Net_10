<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_balance_check
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
        Me.dtgrid_balance_check = New Telerik.WinControls.UI.RadGridView
        Me.bttn_cont = New Telerik.WinControls.UI.RadButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_cashiers = New System.Windows.Forms.Label
        Me.lbl_accounting = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_balance = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        CType(Me.dtgrid_balance_check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrid_balance_check.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttn_cont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrid_balance_check
        '
        Me.dtgrid_balance_check.Location = New System.Drawing.Point(12, 12)
        Me.dtgrid_balance_check.Name = "dtgrid_balance_check"
        Me.dtgrid_balance_check.Size = New System.Drawing.Size(613, 159)
        Me.dtgrid_balance_check.TabIndex = 0
        Me.dtgrid_balance_check.Text = "RadGridView1"
        '
        'bttn_cont
        '
        Me.bttn_cont.Location = New System.Drawing.Point(536, 180)
        Me.bttn_cont.Name = "bttn_cont"
        Me.bttn_cont.Size = New System.Drawing.Size(89, 28)
        Me.bttn_cont.TabIndex = 1
        Me.bttn_cont.Text = "Continue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(147, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cahiers Cash Collection"
        '
        'lbl_cashiers
        '
        Me.lbl_cashiers.AutoSize = True
        Me.lbl_cashiers.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_cashiers.Location = New System.Drawing.Point(176, 198)
        Me.lbl_cashiers.Name = "lbl_cashiers"
        Me.lbl_cashiers.Size = New System.Drawing.Size(19, 13)
        Me.lbl_cashiers.TabIndex = 4
        Me.lbl_cashiers.Text = "00"
        '
        'lbl_accounting
        '
        Me.lbl_accounting.AutoSize = True
        Me.lbl_accounting.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_accounting.Location = New System.Drawing.Point(42, 198)
        Me.lbl_accounting.Name = "lbl_accounting"
        Me.lbl_accounting.Size = New System.Drawing.Size(19, 13)
        Me.lbl_accounting.TabIndex = 6
        Me.lbl_accounting.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Accounting's Collection"
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_balance.Location = New System.Drawing.Point(312, 198)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(19, 13)
        Me.lbl_balance.TabIndex = 8
        Me.lbl_balance.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(299, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Balance Checked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(293, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(131, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "--"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(431, 180)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(89, 28)
        Me.RadButton1.TabIndex = 11
        Me.RadButton1.Text = "Compute"
        '
        'frm_balance_check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(637, 220)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_balance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_accounting)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_cashiers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttn_cont)
        Me.Controls.Add(Me.dtgrid_balance_check)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_balance_check"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Check"
        CType(Me.dtgrid_balance_check.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrid_balance_check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttn_cont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgrid_balance_check As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bttn_cont As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cashiers As System.Windows.Forms.Label
    Friend WithEvents lbl_accounting As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_balance As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
