<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loan_terms
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor
        Me.txtcode = New Telerik.WinControls.UI.RadTextBox
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.Term = New System.Windows.Forms.Label
        Me.bttnclose = New Telerik.WinControls.UI.RadButton
        Me.dtgrd_term = New Telerik.WinControls.UI.RadGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdesc = New Telerik.WinControls.UI.RadTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtmode = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.bttndelete = New Telerik.WinControls.UI.RadButton
        Me.txtpayable = New Telerik.WinControls.UI.RadTextBox
        Me.bttnnew = New Telerik.WinControls.UI.RadButton
        CType(Me.txtcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrd_term, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrd_term.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttndelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpayable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcode
        '
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(11, 28)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(118, 23)
        Me.txtcode.TabIndex = 0
        Me.txtcode.TabStop = False
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(146, 127)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(88, 36)
        Me.bttnsave.TabIndex = 2
        Me.bttnsave.Text = "Save"
        '
        'Term
        '
        Me.Term.AutoSize = True
        Me.Term.Location = New System.Drawing.Point(12, 9)
        Me.Term.Name = "Term"
        Me.Term.Size = New System.Drawing.Size(65, 13)
        Me.Term.TabIndex = 3
        Me.Term.Text = "Term Code :"
        '
        'bttnclose
        '
        Me.bttnclose.Location = New System.Drawing.Point(430, 127)
        Me.bttnclose.Name = "bttnclose"
        Me.bttnclose.Size = New System.Drawing.Size(88, 36)
        Me.bttnclose.TabIndex = 5
        Me.bttnclose.Text = "&Close"
        '
        'dtgrd_term
        '
        Me.dtgrd_term.BackColor = System.Drawing.Color.AliceBlue
        Me.dtgrd_term.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgrd_term.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtgrd_term.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgrd_term.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgrd_term.Location = New System.Drawing.Point(11, 180)
        '
        'dtgrd_term
        '
        Me.dtgrd_term.MasterTemplate.AllowAddNewRow = False
        Me.dtgrd_term.MasterTemplate.AllowDeleteRow = False
        Me.dtgrd_term.MasterTemplate.AllowDragToGroup = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "Code"
        GridViewTextBoxColumn1.HeaderText = "Code"
        GridViewTextBoxColumn1.Name = "Code"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.Width = 78
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Description"
        GridViewTextBoxColumn2.HeaderText = "Description"
        GridViewTextBoxColumn2.Name = "Description"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.Width = 182
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "Payable Within"
        GridViewTextBoxColumn3.HeaderText = "Payable Within"
        GridViewTextBoxColumn3.Name = "Payable Within"
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewTextBoxColumn3.Width = 81
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "Mode"
        GridViewTextBoxColumn4.HeaderText = "Mode"
        GridViewTextBoxColumn4.Name = "Mode"
        GridViewTextBoxColumn4.ReadOnly = True
        GridViewTextBoxColumn4.Width = 119
        Me.dtgrd_term.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "Payable Within"
        Me.dtgrd_term.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.dtgrd_term.Name = "dtgrd_term"
        Me.dtgrd_term.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtgrd_term.Size = New System.Drawing.Size(507, 171)
        Me.dtgrd_term.TabIndex = 7
        Me.dtgrd_term.Text = "RadGridView1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Description :"
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(15, 83)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(503, 23)
        Me.txtdesc.TabIndex = 8
        Me.txtdesc.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Payable W/in :"
        '
        'txtmode
        '
        Me.txtmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmode.FormattingEnabled = True
        Me.txtmode.Items.AddRange(New Object() {"Daily", "Weekly", "Semi-Monthly", "Monthly"})
        Me.txtmode.Location = New System.Drawing.Point(339, 28)
        Me.txtmode.Name = "txtmode"
        Me.txtmode.Size = New System.Drawing.Size(179, 23)
        Me.txtmode.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mode :"
        '
        'bttndelete
        '
        Me.bttndelete.Location = New System.Drawing.Point(336, 127)
        Me.bttndelete.Name = "bttndelete"
        Me.bttndelete.Size = New System.Drawing.Size(88, 36)
        Me.bttndelete.TabIndex = 6
        Me.bttndelete.Text = "Delete"
        '
        'txtpayable
        '
        Me.txtpayable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayable.Location = New System.Drawing.Point(240, 28)
        Me.txtpayable.MaxLength = 3
        Me.txtpayable.Name = "txtpayable"
        Me.txtpayable.Size = New System.Drawing.Size(89, 23)
        Me.txtpayable.TabIndex = 10
        Me.txtpayable.TabStop = False
        '
        'bttnnew
        '
        Me.bttnnew.Location = New System.Drawing.Point(241, 127)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(88, 36)
        Me.bttnnew.TabIndex = 14
        Me.bttnnew.Text = "New"
        '
        'frm_loan_terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(528, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnnew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpayable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.dtgrd_term)
        Me.Controls.Add(Me.bttndelete)
        Me.Controls.Add(Me.bttnclose)
        Me.Controls.Add(Me.Term)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.txtcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_loan_terms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Loan Terms"
        CType(Me.txtcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrd_term.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrd_term, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttndelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpayable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Term As System.Windows.Forms.Label
    Friend WithEvents bttnclose As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtgrd_term As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttndelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtpayable As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
End Class
