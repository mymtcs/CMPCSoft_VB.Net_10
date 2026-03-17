<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_withdraw_ssspayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_withdraw_ssspayment))
        Me.txtpmode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamnt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttn_save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bttn_saveclose = New System.Windows.Forms.ToolStripButton()
        Me.txtrmrks = New System.Windows.Forms.TextBox()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtpmode
        '
        '
        'txtpmode.NestedRadGridView
        '
        Me.txtpmode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtpmode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpmode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpmode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtpmode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtpmode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtpmode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtpmode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtpmode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtpmode.EditorControl.Name = "NestedRadGridView"
        Me.txtpmode.EditorControl.ReadOnly = True
        Me.txtpmode.EditorControl.ShowGroupPanel = False
        Me.txtpmode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtpmode.EditorControl.TabIndex = 0
        Me.txtpmode.Location = New System.Drawing.Point(25, 162)
        Me.txtpmode.Name = "txtpmode"
        Me.txtpmode.Size = New System.Drawing.Size(190, 25)
        Me.txtpmode.TabIndex = 2
        Me.txtpmode.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Remarks :"
        '
        'txtamnt
        '
        Me.txtamnt.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamnt.ForeColor = System.Drawing.Color.Lime
        Me.txtamnt.Location = New System.Drawing.Point(222, 161)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.Size = New System.Drawing.Size(205, 38)
        Me.txtamnt.TabIndex = 3
        Me.txtamnt.Text = "0"
        Me.txtamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(210, 63)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(220, 24)
        Me.txtref.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reference :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Post Mode :"
        '
        'txtpdate
        '
        Me.txtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtpdate.Location = New System.Drawing.Point(25, 62)
        Me.txtpdate.Name = "txtpdate"
        Me.txtpdate.Size = New System.Drawing.Size(176, 24)
        Me.txtpdate.TabIndex = 0
        Me.txtpdate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posting Date :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttn_save, Me.ToolStripSeparator2, Me.bttn_saveclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(447, 25)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttn_save
        '
        Me.bttn_save.Image = CType(resources.GetObject("bttn_save.Image"), System.Drawing.Image)
        Me.bttn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttn_save.Name = "bttn_save"
        Me.bttn_save.Size = New System.Drawing.Size(50, 22)
        Me.bttn_save.Text = "Post"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bttn_saveclose
        '
        Me.bttn_saveclose.Image = CType(resources.GetObject("bttn_saveclose.Image"), System.Drawing.Image)
        Me.bttn_saveclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttn_saveclose.Name = "bttn_saveclose"
        Me.bttn_saveclose.Size = New System.Drawing.Size(63, 22)
        Me.bttn_saveclose.Text = "Cancel"
        '
        'txtrmrks
        '
        Me.txtrmrks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrmrks.Location = New System.Drawing.Point(25, 107)
        Me.txtrmrks.Name = "txtrmrks"
        Me.txtrmrks.Size = New System.Drawing.Size(405, 24)
        Me.txtrmrks.TabIndex = 1
        '
        'frm_withdraw_ssspayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(447, 220)
        Me.Controls.Add(Me.txtrmrks)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtpmode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpdate)
        Me.Controls.Add(Me.txtamnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_withdraw_ssspayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SSS Withdraw"
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpmode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bttn_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttn_saveclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtrmrks As System.Windows.Forms.TextBox
End Class
