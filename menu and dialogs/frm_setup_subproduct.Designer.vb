<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_setup_subproduct
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
        Me.dtgrd_subproducts = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GL_loans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenaltyRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgrd_subproducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgrd_subproducts
        '
        Me.dtgrd_subproducts.AllowUserToAddRows = False
        Me.dtgrd_subproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrd_subproducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Description, Me.GL_loans, Me.Column2, Me.PenaltyRate, Me.Column3})
        Me.dtgrd_subproducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgrd_subproducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgrd_subproducts.Location = New System.Drawing.Point(0, 0)
        Me.dtgrd_subproducts.Name = "dtgrd_subproducts"
        Me.dtgrd_subproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrd_subproducts.Size = New System.Drawing.Size(612, 300)
        Me.dtgrd_subproducts.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 160
        '
        'GL_loans
        '
        Me.GL_loans.HeaderText = "GL Loans"
        Me.GL_loans.Name = "GL_loans"
        Me.GL_loans.ReadOnly = True
        Me.GL_loans.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Rate"
        Me.Column2.Name = "Column2"
        '
        'PenaltyRate
        '
        Me.PenaltyRate.HeaderText = "Penalty Rate"
        Me.PenaltyRate.Name = "PenaltyRate"
        Me.PenaltyRate.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Group"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'frm_setup_subproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(612, 300)
        Me.Controls.Add(Me.dtgrd_subproducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_setup_subproduct"
        Me.Text = "Setup Subproduct"
        CType(Me.dtgrd_subproducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgrd_subproducts As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GL_loans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenaltyRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
