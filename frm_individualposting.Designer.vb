<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_individualposting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_individualposting))
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bttngnerate = New System.Windows.Forms.Button
        Me.bttnnew = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.bttnedit = New System.Windows.Forms.Button
        Me.txtcoll = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column6
        '
        Me.Column6.HeaderText = "Principal Paid"
        Me.Column6.Name = "Column6"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1133, 456)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Member Code"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Group #"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Loan Number"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 170
        '
        'Column4
        '
        Me.Column4.HeaderText = "FullName"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Amount Due"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Interest Paid"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "PrNumber"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amount Paid"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Principal Balance"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Interest Balance"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Interest Balance"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Running Balance"
        Me.Column13.Name = "Column13"
        '
        'bttngnerate
        '
        Me.bttngnerate.BackColor = System.Drawing.Color.Ivory
        Me.bttngnerate.BackgroundImage = CType(resources.GetObject("bttngnerate.BackgroundImage"), System.Drawing.Image)
        Me.bttngnerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttngnerate.FlatAppearance.BorderSize = 0
        Me.bttngnerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttngnerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttngnerate.ForeColor = System.Drawing.Color.White
        Me.bttngnerate.Image = CType(resources.GetObject("bttngnerate.Image"), System.Drawing.Image)
        Me.bttngnerate.Location = New System.Drawing.Point(388, 19)
        Me.bttngnerate.Name = "bttngnerate"
        Me.bttngnerate.Size = New System.Drawing.Size(122, 50)
        Me.bttngnerate.TabIndex = 32
        Me.bttngnerate.Text = "Generate"
        Me.bttngnerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttngnerate.UseVisualStyleBackColor = False
        '
        'bttnnew
        '
        Me.bttnnew.BackColor = System.Drawing.Color.Ivory
        Me.bttnnew.BackgroundImage = CType(resources.GetObject("bttnnew.BackgroundImage"), System.Drawing.Image)
        Me.bttnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnnew.FlatAppearance.BorderSize = 0
        Me.bttnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnnew.ForeColor = System.Drawing.Color.White
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.Location = New System.Drawing.Point(625, 19)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(122, 50)
        Me.bttnnew.TabIndex = 31
        Me.bttnnew.Text = "Cancel"
        Me.bttnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttnnew.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.SplitContainer1.Panel1.Controls.Add(Me.bttngnerate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bttnnew)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bttnedit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtcoll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(1133, 531)
        Me.SplitContainer1.SplitterDistance = 74
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 1
        '
        'bttnedit
        '
        Me.bttnedit.BackColor = System.Drawing.Color.Ivory
        Me.bttnedit.BackgroundImage = CType(resources.GetObject("bttnedit.BackgroundImage"), System.Drawing.Image)
        Me.bttnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnedit.FlatAppearance.BorderSize = 0
        Me.bttnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnedit.ForeColor = System.Drawing.Color.White
        Me.bttnedit.Image = CType(resources.GetObject("bttnedit.Image"), System.Drawing.Image)
        Me.bttnedit.Location = New System.Drawing.Point(506, 19)
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(122, 50)
        Me.bttnedit.TabIndex = 30
        Me.bttnedit.Text = "Save"
        Me.bttnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttnedit.UseVisualStyleBackColor = False
        '
        'txtcoll
        '
        Me.txtcoll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtcoll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtcoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoll.FormattingEnabled = True
        Me.txtcoll.Location = New System.Drawing.Point(179, 37)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(200, 23)
        Me.txtcoll.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Collector  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date Collected :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 21)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2014, 11, 26, 0, 0, 0, 0)
        '
        'frm_individualposting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 531)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_individualposting"
        Me.ShowIcon = False
        Me.Text = "Individual Posting"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bttngnerate As System.Windows.Forms.Button
    Friend WithEvents bttnnew As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents bttnedit As System.Windows.Forms.Button
    Friend WithEvents txtcoll As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
