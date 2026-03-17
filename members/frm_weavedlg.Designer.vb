<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_weavedlg
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
        Me.txtlno = New Telerik.WinControls.UI.RadTextBox
        Me.txtreasons = New Telerik.WinControls.UI.RadTextBoxControl
        Me.bttncont = New Telerik.WinControls.UI.RadButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bttnclose = New Telerik.WinControls.UI.RadButton
        Me.bttncancel = New Telerik.WinControls.UI.RadButton
        CType(Me.txtlno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtreasons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtlno
        '
        Me.txtlno.Enabled = False
        Me.txtlno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlno.Location = New System.Drawing.Point(11, 28)
        Me.txtlno.Name = "txtlno"
        Me.txtlno.Size = New System.Drawing.Size(371, 23)
        Me.txtlno.TabIndex = 0
        Me.txtlno.TabStop = False
        '
        'txtreasons
        '
        Me.txtreasons.Location = New System.Drawing.Point(11, 74)
        Me.txtreasons.Name = "txtreasons"
        Me.txtreasons.Size = New System.Drawing.Size(371, 53)
        Me.txtreasons.TabIndex = 1
        '
        'bttncont
        '
        Me.bttncont.Location = New System.Drawing.Point(104, 134)
        Me.bttncont.Name = "bttncont"
        Me.bttncont.Size = New System.Drawing.Size(88, 36)
        Me.bttncont.TabIndex = 2
        Me.bttncont.Text = "&Continue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PnNumber :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reasons :"
        '
        'bttnclose
        '
        Me.bttnclose.Location = New System.Drawing.Point(294, 134)
        Me.bttnclose.Name = "bttnclose"
        Me.bttnclose.Size = New System.Drawing.Size(88, 36)
        Me.bttnclose.TabIndex = 5
        Me.bttnclose.Text = "&Close"
        '
        'bttncancel
        '
        Me.bttncancel.Location = New System.Drawing.Point(200, 134)
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(88, 36)
        Me.bttncancel.TabIndex = 6
        Me.bttncancel.Text = "Cancel &Weave"
        '
        'frm_weavedlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(395, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttncancel)
        Me.Controls.Add(Me.bttnclose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttncont)
        Me.Controls.Add(Me.txtreasons)
        Me.Controls.Add(Me.txtlno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_weavedlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weave Loans"
        CType(Me.txtlno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtreasons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttncancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtreasons As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents bttncont As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttnclose As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttncancel As Telerik.WinControls.UI.RadButton
End Class
