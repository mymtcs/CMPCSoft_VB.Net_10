<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_receivestocks
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtref = New System.Windows.Forms.TextBox
        Me.dttrn = New System.Windows.Forms.DateTimePicker
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdist = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtgrd_deduction = New Telerik.WinControls.UI.RadGridView
        Me.bttnnew = New Telerik.WinControls.UI.RadButton
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtwarehouse = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.txtwarehouse1 = New Telerik.WinControls.UI.RadMultiColumnComboBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dtgrd_deduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrd_deduction.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwarehouse.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwarehouse.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwarehouse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwarehouse1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtwarehouse1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Location = New System.Drawing.Point(-2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(683, 10)
        Me.Panel2.TabIndex = 198
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(9, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Transaction Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(162, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 15)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Delivery Code :"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.ForeColor = System.Drawing.Color.Red
        Me.txtref.Location = New System.Drawing.Point(165, 34)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(233, 24)
        Me.txtref.TabIndex = 195
        '
        'dttrn
        '
        Me.dttrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttrn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttrn.Location = New System.Drawing.Point(12, 34)
        Me.dttrn.Name = "dttrn"
        Me.dttrn.Size = New System.Drawing.Size(131, 24)
        Me.dttrn.TabIndex = 196
        Me.dttrn.Value = New Date(2015, 2, 15, 0, 0, 0, 0)
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(404, 85)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(262, 24)
        Me.txtcontact.TabIndex = 202
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(401, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Contact Person :"
        '
        'txtdist
        '
        Me.txtdist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdist.Location = New System.Drawing.Point(12, 85)
        Me.txtdist.Name = "txtdist"
        Me.txtdist.Size = New System.Drawing.Size(386, 24)
        Me.txtdist.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Distributor :"
        '
        'dtgrd_deduction
        '
        Me.dtgrd_deduction.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter
        Me.dtgrd_deduction.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextCell
        Me.dtgrd_deduction.Location = New System.Drawing.Point(13, 113)
        Me.dtgrd_deduction.Name = "dtgrd_deduction"
        Me.dtgrd_deduction.Size = New System.Drawing.Size(652, 186)
        Me.dtgrd_deduction.TabIndex = 206
        Me.dtgrd_deduction.Text = "RadGridView1"
        '
        'bttnnew
        '
        Me.bttnnew.Location = New System.Drawing.Point(582, 310)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(83, 35)
        Me.bttnnew.TabIndex = 209
        Me.bttnnew.Text = "Close"
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(490, 310)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(86, 35)
        Me.bttnsave.TabIndex = 208
        Me.bttnsave.Text = "Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "WareHouse :"
        '
        'txtwarehouse
        '
        '
        'txtwarehouse.NestedRadGridView
        '
        Me.txtwarehouse.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtwarehouse.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwarehouse.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtwarehouse.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtwarehouse.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtwarehouse.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtwarehouse.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtwarehouse.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtwarehouse.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtwarehouse.EditorControl.Name = "NestedRadGridView"
        Me.txtwarehouse.EditorControl.ReadOnly = True
        Me.txtwarehouse.EditorControl.ShowGroupPanel = False
        Me.txtwarehouse.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtwarehouse.EditorControl.TabIndex = 0
        Me.txtwarehouse.Location = New System.Drawing.Point(339, 137)
        Me.txtwarehouse.Name = "txtwarehouse"
        Me.txtwarehouse.Size = New System.Drawing.Size(251, 24)
        Me.txtwarehouse.TabIndex = 215
        Me.txtwarehouse.TabStop = False
        '
        'txtwarehouse1
        '
        '
        'txtwarehouse1.NestedRadGridView
        '
        Me.txtwarehouse1.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtwarehouse1.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwarehouse1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtwarehouse1.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtwarehouse1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtwarehouse1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtwarehouse1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtwarehouse1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtwarehouse1.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtwarehouse1.EditorControl.Name = "NestedRadGridView"
        Me.txtwarehouse1.EditorControl.ReadOnly = True
        Me.txtwarehouse1.EditorControl.ShowGroupPanel = False
        Me.txtwarehouse1.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtwarehouse1.EditorControl.TabIndex = 0
        Me.txtwarehouse1.Location = New System.Drawing.Point(404, 34)
        Me.txtwarehouse1.Name = "txtwarehouse1"
        Me.txtwarehouse1.Size = New System.Drawing.Size(262, 24)
        Me.txtwarehouse1.TabIndex = 210
        Me.txtwarehouse1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(401, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "WareHouse :"
        '
        'frm_receivestocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(678, 357)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtwarehouse1)
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.dtgrd_deduction)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.dttrn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_receivestocks"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Stocks"
        CType(Me.dtgrd_deduction.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrd_deduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwarehouse.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwarehouse.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwarehouse1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwarehouse1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtwarehouse1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents dttrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdist As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgrd_deduction As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtwarehouse As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtwarehouse1 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
