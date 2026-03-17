<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printID
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
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.collectionsheet1 = New Gsoft.collectionsheet()
        Me.picdummy = New System.Windows.Forms.PictureBox()
        CType(Me.picdummy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crviewer.Location = New System.Drawing.Point(0, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(677, 405)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'picdummy
        '
        Me.picdummy.Location = New System.Drawing.Point(0, 281)
        Me.picdummy.Name = "picdummy"
        Me.picdummy.Size = New System.Drawing.Size(79, 73)
        Me.picdummy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picdummy.TabIndex = 1
        Me.picdummy.TabStop = False
        Me.picdummy.Visible = False
        '
        'frm_printID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(677, 405)
        Me.Controls.Add(Me.picdummy)
        Me.Controls.Add(Me.crviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_printID"
        Me.ShowIcon = False
        Me.Text = "Membership ID"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picdummy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents collectionsheet1 As Gsoft.collectionsheet
    Friend WithEvents picdummy As System.Windows.Forms.PictureBox
End Class
