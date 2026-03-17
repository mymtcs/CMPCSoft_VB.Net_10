<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_checkloanno
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
        Me.txtloan_num = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.bttnsubmit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtloan_num
        '
        Me.txtloan_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloan_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloan_num.Location = New System.Drawing.Point(37, 27)
        Me.txtloan_num.Name = "txtloan_num"
        Me.txtloan_num.Size = New System.Drawing.Size(285, 24)
        Me.txtloan_num.TabIndex = 0
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(37, 57)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(285, 24)
        Me.txtpass.TabIndex = 1
        Me.txtpass.UseSystemPasswordChar = True
        '
        'bttnsubmit
        '
        Me.bttnsubmit.Location = New System.Drawing.Point(166, 87)
        Me.bttnsubmit.Name = "bttnsubmit"
        Me.bttnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.bttnsubmit.TabIndex = 2
        Me.bttnsubmit.Text = "Submit"
        Me.bttnsubmit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.ForeColor = System.Drawing.Color.Red
        Me.lblpass.Location = New System.Drawing.Point(228, 61)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(89, 13)
        Me.lblpass.TabIndex = 4
        Me.lblpass.Text = "*invalid password"
        Me.lblpass.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Note : Stop other loan transaction before continuing this process."
        '
        'frm_checkloanno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(367, 122)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bttnsubmit)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtloan_num)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_checkloanno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Loan Num."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtloan_num As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents bttnsubmit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
