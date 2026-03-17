<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sss_remittance
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
        Me.txtamnt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrmrks = New System.Windows.Forms.TextBox()
        Me.dtgrdsss = New System.Windows.Forms.DataGridView()
        Me.dtasof = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgrdsss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 583)
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
        Me.txtamnt.Location = New System.Drawing.Point(851, 601)
        Me.txtamnt.Name = "txtamnt"
        Me.txtamnt.ReadOnly = True
        Me.txtamnt.Size = New System.Drawing.Size(156, 38)
        Me.txtamnt.TabIndex = 3
        Me.txtamnt.Text = "0"
        Me.txtamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(848, 583)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount :"
        '
        'txtpdate
        '
        Me.txtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtpdate.Location = New System.Drawing.Point(177, 42)
        Me.txtpdate.Name = "txtpdate"
        Me.txtpdate.Size = New System.Drawing.Size(130, 24)
        Me.txtpdate.TabIndex = 0
        Me.txtpdate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posting Date :"
        '
        'txtrmrks
        '
        Me.txtrmrks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrmrks.Location = New System.Drawing.Point(29, 601)
        Me.txtrmrks.Multiline = True
        Me.txtrmrks.Name = "txtrmrks"
        Me.txtrmrks.Size = New System.Drawing.Size(584, 38)
        Me.txtrmrks.TabIndex = 1
        '
        'dtgrdsss
        '
        Me.dtgrdsss.AllowUserToAddRows = False
        Me.dtgrdsss.AllowUserToDeleteRows = False
        Me.dtgrdsss.AllowUserToResizeColumns = False
        Me.dtgrdsss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrdsss.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column7, Me.Column3, Me.Column4, Me.Column8, Me.Column9, Me.Column5, Me.Column10})
        Me.dtgrdsss.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgrdsss.Location = New System.Drawing.Point(29, 72)
        Me.dtgrdsss.Name = "dtgrdsss"
        Me.dtgrdsss.Size = New System.Drawing.Size(1004, 493)
        Me.dtgrdsss.TabIndex = 126
        '
        'dtasof
        '
        Me.dtasof.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtasof.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtasof.Location = New System.Drawing.Point(29, 42)
        Me.dtasof.Name = "dtasof"
        Me.dtasof.Size = New System.Drawing.Size(130, 24)
        Me.dtasof.TabIndex = 128
        Me.dtasof.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "As of :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(587, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 129
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(921, 645)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 42)
        Me.Button2.TabIndex = 130
        Me.Button2.Text = "Post"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(339, 41)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(220, 24)
        Me.txtref.TabIndex = 131
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "TRN No. :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(951, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 23)
        Me.Button3.TabIndex = 133
        Me.Button3.Text = "Check All"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "SN"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "TRN No."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        Me.Column2.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Payor Type"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Post Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Members Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "SSS Number"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "Applicable Month"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 190
        '
        'Column9
        '
        Me.Column9.HeaderText = "Cont.  Amount"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 40
        '
        'Column10
        '
        Me.Column10.HeaderText = "memcode"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'frm_sss_remittance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1045, 699)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtasof)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgrdsss)
        Me.Controls.Add(Me.txtrmrks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpdate)
        Me.Controls.Add(Me.txtamnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sss_remittance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SSS Remittance"
        CType(Me.dtgrdsss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtamnt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtrmrks As System.Windows.Forms.TextBox
    Friend WithEvents dtgrdsss As System.Windows.Forms.DataGridView
    Friend WithEvents dtasof As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
