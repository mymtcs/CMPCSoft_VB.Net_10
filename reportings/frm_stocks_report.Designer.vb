<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stocks_report
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
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.collectionsheet1 = New Gsoft.collectionsheet
        Me.Label1 = New System.Windows.Forms.Label
        Me.bttngenerate = New System.Windows.Forms.Button
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crviewer.Location = New System.Drawing.Point(0, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(1226, 573)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(966, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "As of :"
        '
        'bttngenerate
        '
        Me.bttngenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttngenerate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttngenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttngenerate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.bttngenerate.FlatAppearance.BorderSize = 0
        Me.bttngenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttngenerate.ForeColor = System.Drawing.Color.Black
        Me.bttngenerate.Location = New System.Drawing.Point(1141, 4)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(78, 23)
        Me.bttngenerate.TabIndex = 34
        Me.bttngenerate.Text = "Generate"
        Me.bttngenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttngenerate.UseVisualStyleBackColor = False
        '
        'dtto
        '
        Me.dtto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(1009, 5)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(126, 21)
        Me.dtto.TabIndex = 33
        Me.dtto.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'frm_stocks_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1226, 573)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.crviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_stocks_report"
        Me.ShowIcon = False
        Me.Text = "Current Stocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents collectionsheet1 As Gsoft.collectionsheet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttngenerate As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
End Class
