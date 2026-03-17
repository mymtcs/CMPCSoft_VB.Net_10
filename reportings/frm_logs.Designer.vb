<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logs
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
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.crv_loanrel = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.logs1 = New Gsoft.logs
        Me.SuspendLayout()
        '
        'dtfrom
        '
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(12, 12)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(130, 21)
        Me.dtfrom.TabIndex = 12
        Me.dtfrom.Value = New Date(2016, 9, 19, 0, 0, 0, 0)
        '
        'dtto
        '
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(159, 12)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(130, 21)
        Me.dtto.TabIndex = 13
        Me.dtto.Value = New Date(2016, 9, 19, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(298, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'crv_loanrel
        '
        Me.crv_loanrel.ActiveViewIndex = -1
        Me.crv_loanrel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv_loanrel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_loanrel.Location = New System.Drawing.Point(0, 48)
        Me.crv_loanrel.Name = "crv_loanrel"
        Me.crv_loanrel.Size = New System.Drawing.Size(1221, 448)
        Me.crv_loanrel.TabIndex = 11
        '
        'frm_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1222, 498)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.crv_loanrel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_logs"
        Me.Text = "System Logs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_loanrel As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents logs1 As Gsoft.logs
End Class
