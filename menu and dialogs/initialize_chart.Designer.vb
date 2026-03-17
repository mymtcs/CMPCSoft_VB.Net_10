<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class initialize_chart
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
        Me.components = New System.ComponentModel.Container
        Me.tmrsplah = New System.Windows.Forms.Timer(Me.components)
        Me.lblchck = New System.Windows.Forms.Label
        Me.progress_updates = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'tmrsplah
        '
        '
        'lblchck
        '
        Me.lblchck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblchck.AutoSize = True
        Me.lblchck.BackColor = System.Drawing.Color.White
        Me.lblchck.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchck.ForeColor = System.Drawing.Color.DimGray
        Me.lblchck.Location = New System.Drawing.Point(7, 2)
        Me.lblchck.Name = "lblchck"
        Me.lblchck.Size = New System.Drawing.Size(176, 17)
        Me.lblchck.TabIndex = 36
        Me.lblchck.Text = "Initializing chart..."
        '
        'progress_updates
        '
        Me.progress_updates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progress_updates.Location = New System.Drawing.Point(10, 21)
        Me.progress_updates.Name = "progress_updates"
        Me.progress_updates.Size = New System.Drawing.Size(212, 12)
        Me.progress_updates.TabIndex = 35
        '
        'initialize_chart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(229, 37)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblchck)
        Me.Controls.Add(Me.progress_updates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "initialize_chart"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrsplah As System.Windows.Forms.Timer
    Friend WithEvents lblchck As System.Windows.Forms.Label
    Friend WithEvents progress_updates As System.Windows.Forms.ProgressBar

End Class
