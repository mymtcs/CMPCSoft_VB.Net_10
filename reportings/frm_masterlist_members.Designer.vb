<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_masterlist_members
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
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.cntxtmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewProductAssistantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.gendate = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cntxtmenu.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRviewer.Location = New System.Drawing.Point(0, 0)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(1241, 622)
        Me.CRviewer.TabIndex = 12
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'gendate
        '
        Me.gendate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(1045, 5)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(109, 21)
        Me.gendate.TabIndex = 13
        Me.gendate.Value = New Date(2015, 3, 15, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1160, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Gen Date"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(1000, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "As of :"
        '
        'frm_masterlist_members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1241, 622)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gendate)
        Me.Controls.Add(Me.CRviewer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_masterlist_members"
        Me.ShowIcon = False
        Me.Text = " Members Master List"
        Me.cntxtmenu.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gendate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
