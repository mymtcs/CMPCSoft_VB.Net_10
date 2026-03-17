<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_performance_officer
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
        Me.bttngen = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ctrchief_incntvs1 = New loanprofileby_gender
        Me.SuspendLayout()
        '
        'bttngen
        '
        Me.bttngen.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bttngen.Location = New System.Drawing.Point(1126, 2)
        Me.bttngen.Name = "bttngen"
        Me.bttngen.Size = New System.Drawing.Size(76, 26)
        Me.bttngen.TabIndex = 8
        Me.bttngen.Text = "Generate.."
        Me.bttngen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(759, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From :"
        '
        'dtfrom
        '
        Me.dtfrom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(801, 4)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(132, 22)
        Me.dtfrom.TabIndex = 6
        Me.dtfrom.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(946, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To :"
        '
        'dtto
        '
        Me.dtto.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(988, 4)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(132, 22)
        Me.dtto.TabIndex = 9
        Me.dtto.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crviewer.Location = New System.Drawing.Point(0, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(1208, 559)
        Me.crviewer.TabIndex = 1
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'frm_ctr_inctv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1208, 559)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.bttngen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.crviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_ctr_inctv"
        Me.ShowIcon = False
        Me.Text = "Center Cheif Incentives"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents bttngen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents ctrchief_incntvs1 As loanprofileby_gender
End Class
