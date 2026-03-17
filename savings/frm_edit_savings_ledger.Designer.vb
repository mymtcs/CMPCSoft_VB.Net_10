<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_savings_ledger
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.txtamountwdraw = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsavingstype = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtpmode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtrmrks = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamntdept = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.bttndelete = New Telerik.WinControls.UI.RadButton()
        Me.Panel1.SuspendLayout()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavingstype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavingstype.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsavingstype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpmode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttndelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.bttnsave)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-1, 300)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 70)
        Me.Panel1.TabIndex = 0
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(296, 23)
        Me.bttnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(99, 38)
        Me.bttnsave.TabIndex = 6
        Me.bttnsave.Text = "&Save"
        '
        'txtamountwdraw
        '
        Me.txtamountwdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamountwdraw.Location = New System.Drawing.Point(173, 197)
        Me.txtamountwdraw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamountwdraw.Name = "txtamountwdraw"
        Me.txtamountwdraw.Size = New System.Drawing.Size(277, 22)
        Me.txtamountwdraw.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Amount Withdraw :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 241)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Savings Type :"
        '
        'txtsavingstype
        '
        '
        'txtsavingstype.NestedRadGridView
        '
        Me.txtsavingstype.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtsavingstype.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsavingstype.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsavingstype.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtsavingstype.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtsavingstype.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtsavingstype.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtsavingstype.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtsavingstype.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtsavingstype.EditorControl.Name = "NestedRadGridView"
        Me.txtsavingstype.EditorControl.ReadOnly = True
        Me.txtsavingstype.EditorControl.ShowGroupPanel = False
        Me.txtsavingstype.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtsavingstype.EditorControl.TabIndex = 0
        Me.txtsavingstype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsavingstype.Location = New System.Drawing.Point(173, 230)
        Me.txtsavingstype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsavingstype.Name = "txtsavingstype"
        Me.txtsavingstype.Size = New System.Drawing.Size(279, 27)
        Me.txtsavingstype.TabIndex = 5
        Me.txtsavingstype.TabStop = False
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
        Me.txtpmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpmode.Location = New System.Drawing.Point(173, 70)
        Me.txtpmode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpmode.Name = "txtpmode"
        Me.txtpmode.Size = New System.Drawing.Size(279, 25)
        Me.txtpmode.TabIndex = 1
        Me.txtpmode.TabStop = False
        '
        'txtrmrks
        '
        Me.txtrmrks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtrmrks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtrmrks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrmrks.FormattingEnabled = True
        Me.txtrmrks.Items.AddRange(New Object() {"CASH", "DM"})
        Me.txtrmrks.Location = New System.Drawing.Point(173, 133)
        Me.txtrmrks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrmrks.Name = "txtrmrks"
        Me.txtrmrks.Size = New System.Drawing.Size(277, 24)
        Me.txtrmrks.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Remarks :"
        '
        'txtamntdept
        '
        Me.txtamntdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamntdept.Location = New System.Drawing.Point(173, 165)
        Me.txtamntdept.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamntdept.Name = "txtamntdept"
        Me.txtamntdept.Size = New System.Drawing.Size(277, 22)
        Me.txtamntdept.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount Deposit :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(173, 101)
        Me.txtref.Margin = New System.Windows.Forms.Padding(4)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(277, 22)
        Me.txtref.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reference :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Post Mode :"
        '
        'txtpdate
        '
        Me.txtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtpdate.Location = New System.Drawing.Point(173, 37)
        Me.txtpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdate.Name = "txtpdate"
        Me.txtpdate.Size = New System.Drawing.Size(199, 22)
        Me.txtpdate.TabIndex = 0
        Me.txtpdate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posting Date :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 12)
        Me.Panel2.TabIndex = 35
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(402, 323)
        Me.RadButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(99, 38)
        Me.RadButton2.TabIndex = 7
        Me.RadButton2.Text = "&Close"
        '
        'bttndelete
        '
        Me.bttndelete.Location = New System.Drawing.Point(15, 323)
        Me.bttndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.bttndelete.Name = "bttndelete"
        Me.bttndelete.Size = New System.Drawing.Size(88, 38)
        Me.bttndelete.TabIndex = 36
        Me.bttndelete.Text = "&Delete"
        '
        'frm_edit_savings_ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(519, 367)
        Me.Controls.Add(Me.txtamountwdraw)
        Me.Controls.Add(Me.bttndelete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsavingstype)
        Me.Controls.Add(Me.txtpmode)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtrmrks)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtamntdept)
        Me.Controls.Add(Me.txtpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_edit_savings_ledger"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Ledger"
        Me.Panel1.ResumeLayout(False)
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavingstype.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavingstype.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsavingstype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpmode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttndelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtamntdept As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtrmrks As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtpmode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsavingstype As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtamountwdraw As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bttndelete As Telerik.WinControls.UI.RadButton
End Class
