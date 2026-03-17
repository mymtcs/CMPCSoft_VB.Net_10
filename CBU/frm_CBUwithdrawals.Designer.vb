<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CBUwithdrawals
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrmrks = New System.Windows.Forms.ComboBox()
        Me.txtamnt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.txtgl = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbotpost = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgl.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Remarks :"
        '
        'txtrmrks
        '
        Me.txtrmrks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtrmrks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtrmrks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.txtrmrks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrmrks.FormattingEnabled = True
        Me.txtrmrks.Location = New System.Drawing.Point(43, 145)
        Me.txtrmrks.Name = "txtrmrks"
        Me.txtrmrks.Size = New System.Drawing.Size(282, 28)
        Me.txtrmrks.TabIndex = 3
        '
        'txtamnt
        '
        Me.txtamnt.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamnt.ForeColor = System.Drawing.Color.Lime
        Me.txtamnt.Location = New System.Drawing.Point(186, 237)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.Size = New System.Drawing.Size(139, 34)
        Me.txtamnt.TabIndex = 4
        Me.txtamnt.Text = "0"
        Me.txtamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(43, 98)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(282, 30)
        Me.txtref.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reference :"
        '
        'txtpdate
        '
        Me.txtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtpdate.Location = New System.Drawing.Point(43, 41)
        Me.txtpdate.Name = "txtpdate"
        Me.txtpdate.Size = New System.Drawing.Size(132, 30)
        Me.txtpdate.TabIndex = 0
        Me.txtpdate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posting Date :"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(147, 281)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(86, 39)
        Me.RadButton1.TabIndex = 6
        Me.RadButton1.Text = "&Save"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(239, 281)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(86, 39)
        Me.RadButton2.TabIndex = 7
        Me.RadButton2.Text = "&Close"
        '
        'txtgl
        '
        '
        'txtgl.NestedRadGridView
        '
        Me.txtgl.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtgl.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgl.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgl.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'txtgl.NestedRadGridView
        '
        Me.txtgl.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtgl.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtgl.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtgl.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtgl.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtgl.EditorControl.Name = "NestedRadGridView"
        Me.txtgl.EditorControl.ReadOnly = True
        Me.txtgl.EditorControl.ShowGroupPanel = False
        Me.txtgl.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtgl.EditorControl.TabIndex = 0
        Me.txtgl.Location = New System.Drawing.Point(43, 191)
        Me.txtgl.Name = "txtgl"
        Me.txtgl.Size = New System.Drawing.Size(282, 27)
        Me.txtgl.TabIndex = 11
        Me.txtgl.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Account Type :"
        '
        'cbotpost
        '
        Me.cbotpost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotpost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotpost.FormattingEnabled = True
        Me.cbotpost.Items.AddRange(New Object() {"Cash", "DM", "CM"})
        Me.cbotpost.Location = New System.Drawing.Point(204, 41)
        Me.cbotpost.Name = "cbotpost"
        Me.cbotpost.Size = New System.Drawing.Size(121, 30)
        Me.cbotpost.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Post Mode :"
        '
        'frm_CBUwithdrawals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(373, 338)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbotpost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtgl)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtrmrks)
        Me.Controls.Add(Me.txtpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtamnt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtref)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CBUwithdrawals"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CBU Withdrawals"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrmrks As System.Windows.Forms.ComboBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtgl As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbotpost As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
