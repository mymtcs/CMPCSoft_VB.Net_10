<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_print_voucher
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
        Me.crv_voucher = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv_voucher
        '
        Me.crv_voucher.ActiveViewIndex = -1
        Me.crv_voucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_voucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_voucher.Location = New System.Drawing.Point(0, 0)
        Me.crv_voucher.Name = "crv_voucher"
        Me.crv_voucher.SelectionFormula = ""
        Me.crv_voucher.Size = New System.Drawing.Size(981, 521)
        Me.crv_voucher.TabIndex = 0
        Me.crv_voucher.ViewTimeSelectionFormula = ""
        '
        'frm_print_voucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(981, 521)
        Me.Controls.Add(Me.crv_voucher)
        Me.Name = "frm_print_voucher"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Voucher"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_voucher As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
