<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_savingsACC
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgridsaving = New System.Windows.Forms.DataGridView()
        Me.rel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttnselect = New System.Windows.Forms.Button()
        Me.bttncancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgridsaving, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgridsaving
        '
        Me.dtgridsaving.AllowUserToAddRows = False
        Me.dtgridsaving.AllowUserToDeleteRows = False
        Me.dtgridsaving.AllowUserToOrderColumns = True
        Me.dtgridsaving.AllowUserToResizeColumns = False
        Me.dtgridsaving.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgridsaving.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridsaving.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dtgridsaving.ColumnHeadersHeight = 25
        Me.dtgridsaving.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rel, Me.memcode, Me.Column1, Me.amount, Me.Column8, Me.id})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgridsaving.DefaultCellStyle = DataGridViewCellStyle19
        Me.dtgridsaving.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgridsaving.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgridsaving.Location = New System.Drawing.Point(1, 4)
        Me.dtgridsaving.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgridsaving.MultiSelect = False
        Me.dtgridsaving.Name = "dtgridsaving"
        Me.dtgridsaving.ReadOnly = True
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridsaving.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dtgridsaving.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgridsaving.Size = New System.Drawing.Size(827, 300)
        Me.dtgridsaving.TabIndex = 13
        '
        'rel
        '
        Me.rel.HeaderText = "Account No."
        Me.rel.Name = "rel"
        Me.rel.ReadOnly = True
        Me.rel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rel.Width = 130
        '
        'memcode
        '
        Me.memcode.HeaderText = "Account Name"
        Me.memcode.Name = "memcode"
        Me.memcode.ReadOnly = True
        Me.memcode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.memcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.memcode.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account Balance"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 130
        '
        'amount
        '
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.NullValue = Nothing
        Me.amount.DefaultCellStyle = DataGridViewCellStyle18
        Me.amount.HeaderText = "Date Open"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.amount.Visible = False
        Me.amount.Width = 140
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "Account Type"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 120
        '
        'bttnselect
        '
        Me.bttnselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnselect.BackColor = System.Drawing.Color.White
        Me.bttnselect.Enabled = False
        Me.bttnselect.ForeColor = System.Drawing.Color.Blue
        Me.bttnselect.Location = New System.Drawing.Point(527, 308)
        Me.bttnselect.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnselect.Name = "bttnselect"
        Me.bttnselect.Size = New System.Drawing.Size(119, 36)
        Me.bttnselect.TabIndex = 15
        Me.bttnselect.Text = "Select"
        Me.bttnselect.UseVisualStyleBackColor = False
        '
        'bttncancel
        '
        Me.bttncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttncancel.BackColor = System.Drawing.Color.White
        Me.bttncancel.ForeColor = System.Drawing.Color.Blue
        Me.bttncancel.Location = New System.Drawing.Point(654, 308)
        Me.bttncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(123, 36)
        Me.bttncancel.TabIndex = 16
        Me.bttncancel.Text = "Cancel"
        Me.bttncancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "..."
        '
        'frm_select_savingsACC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(812, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttncancel)
        Me.Controls.Add(Me.bttnselect)
        Me.Controls.Add(Me.dtgridsaving)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm_select_savingsACC"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Account Number"
        CType(Me.dtgridsaving, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgridsaving As System.Windows.Forms.DataGridView
    Friend WithEvents bttnselect As System.Windows.Forms.Button
    Friend WithEvents bttncancel As System.Windows.Forms.Button
    Friend WithEvents rel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents memcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
