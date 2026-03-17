<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_masterlistSS
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
        Me.components = New System.ComponentModel.Container()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cntxtmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewProductAssistantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.gendate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttn_generate = New Telerik.WinControls.UI.RadButton()
        Me.cntxtmenu.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttn_generate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Full Name"
        Me.ColumnHeader22.Width = 287
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Interest"
        Me.ColumnHeader25.Width = 125
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Due Date"
        Me.ColumnHeader23.Width = 234
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Amounts Recievable"
        Me.ColumnHeader24.Width = 155
        '
        'cntxtmenu
        '
        Me.cntxtmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProductAssistantToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.cntxtmenu.Name = "cntxtmenu"
        Me.cntxtmenu.Size = New System.Drawing.Size(191, 48)
        '
        'ViewProductAssistantToolStripMenuItem
        '
        Me.ViewProductAssistantToolStripMenuItem.Name = "ViewProductAssistantToolStripMenuItem"
        Me.ViewProductAssistantToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewProductAssistantToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ViewProductAssistantToolStripMenuItem.Text = "Export To excel"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "PnNumber"
        Me.ColumnHeader21.Width = 87
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.Location = New System.Drawing.Point(213, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(1028, 622)
        Me.CRviewer.TabIndex = 12
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'gendate
        '
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(15, 64)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(179, 21)
        Me.gendate.TabIndex = 13
        Me.gendate.Value = New Date(2015, 3, 15, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "As of :"
        '
        'bttn_generate
        '
        Me.bttn_generate.Location = New System.Drawing.Point(15, 108)
        Me.bttn_generate.Name = "bttn_generate"
        Me.bttn_generate.Size = New System.Drawing.Size(179, 24)
        Me.bttn_generate.TabIndex = 22
        Me.bttn_generate.Text = "Generate"
        '
        'frm_masterlistSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1241, 622)
        Me.Controls.Add(Me.CRviewer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gendate)
        Me.Controls.Add(Me.bttn_generate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_masterlistSS"
        Me.ShowIcon = False
        Me.Text = "Savings Masterlist"
        Me.cntxtmenu.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttn_generate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cntxtmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewProductAssistantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents gendate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttn_generate As Telerik.WinControls.UI.RadButton
End Class
