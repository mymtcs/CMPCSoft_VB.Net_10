<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loantoberel
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
        Me.bttnsearch = New System.Windows.Forms.Button
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.loanrel1 = New Gsoft.loanrel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.crv_loantoberel = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.loantoberel1 = New Gsoft.loantoberel
        Me.SuspendLayout()
        '
        'bttnsearch
        '
        Me.bttnsearch.Location = New System.Drawing.Point(756, 2)
        Me.bttnsearch.Name = "bttnsearch"
        Me.bttnsearch.Size = New System.Drawing.Size(60, 23)
        Me.bttnsearch.TabIndex = 21
        Me.bttnsearch.Text = "Search.."
        Me.bttnsearch.UseVisualStyleBackColor = True
        '
        'dtto
        '
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(626, 4)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(125, 20)
        Me.dtto.TabIndex = 20
        Me.dtto.Value = New Date(2013, 9, 23, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "From :"
        '
        'dtfrom
        '
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(453, 4)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(125, 20)
        Me.dtfrom.TabIndex = 17
        Me.dtfrom.Value = New Date(2013, 9, 23, 0, 0, 0, 0)
        '
        'crv_loantoberel
        '
        Me.crv_loantoberel.ActiveViewIndex = -1
        Me.crv_loantoberel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_loantoberel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_loantoberel.Location = New System.Drawing.Point(0, 0)
        Me.crv_loantoberel.Name = "crv_loantoberel"
        Me.crv_loantoberel.Size = New System.Drawing.Size(1235, 552)
        Me.crv_loantoberel.TabIndex = 16
        '
        'frm_loantoberel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1235, 552)
        Me.Controls.Add(Me.bttnsearch)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.crv_loantoberel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_loantoberel"
        Me.ShowIcon = False
        Me.Text = "Loan to be Release"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnsearch As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crv_loantoberel As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents loanrel1 As Gsoft.loanrel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents loantoberel1 As Gsoft.loantoberel
End Class
