<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_due_to
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
        Me.cbo_chart = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.bttnok = New Telerik.WinControls.UI.RadButton
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        Me.gendate = New System.Windows.Forms.DateTimePicker
        CType(Me.cbo_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_chart.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_chart.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_chart
        '
        '
        'cbo_chart.NestedRadGridView
        '
        Me.cbo_chart.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cbo_chart.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_chart.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbo_chart.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'cbo_chart.NestedRadGridView
        '
        Me.cbo_chart.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cbo_chart.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cbo_chart.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cbo_chart.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cbo_chart.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cbo_chart.EditorControl.Name = "NestedRadGridView"
        Me.cbo_chart.EditorControl.ReadOnly = True
        Me.cbo_chart.EditorControl.ShowGroupPanel = False
        Me.cbo_chart.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cbo_chart.EditorControl.TabIndex = 0
        Me.cbo_chart.Location = New System.Drawing.Point(12, 44)
        Me.cbo_chart.Name = "cbo_chart"
        Me.cbo_chart.Size = New System.Drawing.Size(317, 25)
        Me.cbo_chart.TabIndex = 0
        Me.cbo_chart.TabStop = False
        '
        'bttnok
        '
        Me.bttnok.Location = New System.Drawing.Point(158, 82)
        Me.bttnok.Name = "bttnok"
        Me.bttnok.Size = New System.Drawing.Size(84, 24)
        Me.bttnok.TabIndex = 1
        Me.bttnok.Text = "OK"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(245, 82)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(84, 24)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Cancel"
        '
        'gendate
        '
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(12, 13)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(125, 20)
        Me.gendate.TabIndex = 3
        Me.gendate.Value = New Date(2015, 5, 12, 0, 0, 0, 0)
        '
        'frm_select_due_to
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(341, 118)
        Me.Controls.Add(Me.gendate)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.bttnok)
        Me.Controls.Add(Me.cbo_chart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_select_due_to"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select"
        CType(Me.cbo_chart.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_chart.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbo_chart As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bttnok As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents gendate As System.Windows.Forms.DateTimePicker
End Class
