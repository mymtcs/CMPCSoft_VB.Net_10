<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_test
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
        Me.cbo_multibox = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Radgview = New Telerik.WinControls.UI.RadGridView
        CType(Me.cbo_multibox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_multibox.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_multibox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Radgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Radgview.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_multibox
        '
        Me.cbo_multibox.AutoFilter = True
        Me.cbo_multibox.AutoSizeDropDownToBestFit = True
        '
        'cbo_multibox.NestedRadGridView
        '
        Me.cbo_multibox.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cbo_multibox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbo_multibox.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbo_multibox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbo_multibox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_multibox.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cbo_multibox.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cbo_multibox.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cbo_multibox.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cbo_multibox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.cbo_multibox.EditorControl.MasterTemplate.EnableFiltering = True
        Me.cbo_multibox.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cbo_multibox.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cbo_multibox.EditorControl.Name = "NestedRadGridView"
        Me.cbo_multibox.EditorControl.ReadOnly = True
        Me.cbo_multibox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbo_multibox.EditorControl.ShowGroupPanel = False
        Me.cbo_multibox.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cbo_multibox.EditorControl.TabIndex = 0
        Me.cbo_multibox.Location = New System.Drawing.Point(12, 56)
        Me.cbo_multibox.Name = "cbo_multibox"
        Me.cbo_multibox.Size = New System.Drawing.Size(260, 24)
        Me.cbo_multibox.TabIndex = 0
        Me.cbo_multibox.TabStop = False
        '
        'Radgview
        '
        Me.Radgview.BackColor = System.Drawing.SystemColors.Control
        Me.Radgview.Cursor = System.Windows.Forms.Cursors.Default
        Me.Radgview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Radgview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Radgview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radgview.Location = New System.Drawing.Point(12, 123)
        '
        'Radgview
        '
        Me.Radgview.MasterTemplate.AutoGenerateColumns = False
        Me.Radgview.Name = "Radgview"
        Me.Radgview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Radgview.Size = New System.Drawing.Size(632, 171)
        Me.Radgview.TabIndex = 1
        Me.Radgview.Text = "RadGridView1"
        '
        'frm_test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 372)
        Me.Controls.Add(Me.Radgview)
        Me.Controls.Add(Me.cbo_multibox)
        Me.Name = "frm_test"
        Me.Text = "frm_test"
        CType(Me.cbo_multibox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_multibox.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_multibox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Radgview.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Radgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbo_multibox As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Radgview As Telerik.WinControls.UI.RadGridView
End Class
