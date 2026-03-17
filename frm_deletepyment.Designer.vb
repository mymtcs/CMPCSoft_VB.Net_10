<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_deletepyment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_deletepyment))
        Me.bttnsearch = New System.Windows.Forms.Button
        Me.txtprnumber = New System.Windows.Forms.TextBox
        Me.lstmembers = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.bttndel = New System.Windows.Forms.Button
        Me.lblname = New System.Windows.Forms.Label
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'bttnsearch
        '
        Me.bttnsearch.Location = New System.Drawing.Point(678, 40)
        Me.bttnsearch.Margin = New System.Windows.Forms.Padding(6)
        Me.bttnsearch.Name = "bttnsearch"
        Me.bttnsearch.Size = New System.Drawing.Size(107, 33)
        Me.bttnsearch.TabIndex = 0
        Me.bttnsearch.Text = "Search"
        Me.bttnsearch.UseVisualStyleBackColor = True
        '
        'txtprnumber
        '
        Me.txtprnumber.Location = New System.Drawing.Point(143, 42)
        Me.txtprnumber.Margin = New System.Windows.Forms.Padding(6)
        Me.txtprnumber.Name = "txtprnumber"
        Me.txtprnumber.Size = New System.Drawing.Size(534, 29)
        Me.txtprnumber.TabIndex = 1
        '
        'lstmembers
        '
        Me.lstmembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstmembers.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstmembers.FullRowSelect = True
        Me.lstmembers.GridLines = True
        Me.lstmembers.Location = New System.Drawing.Point(27, 89)
        Me.lstmembers.Margin = New System.Windows.Forms.Padding(4)
        Me.lstmembers.Name = "lstmembers"
        Me.lstmembers.Size = New System.Drawing.Size(936, 462)
        Me.lstmembers.TabIndex = 9
        Me.lstmembers.UseCompatibleStateImageBehavior = False
        Me.lstmembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Pay No"
        Me.ColumnHeader6.Width = 191
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Prnumber"
        Me.ColumnHeader7.Width = 204
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Fullname"
        Me.ColumnHeader8.Width = 337
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Amount"
        Me.ColumnHeader1.Width = 184
        '
        'bttndel
        '
        Me.bttndel.Image = CType(resources.GetObject("bttndel.Image"), System.Drawing.Image)
        Me.bttndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttndel.Location = New System.Drawing.Point(870, 40)
        Me.bttndel.Margin = New System.Windows.Forms.Padding(6)
        Me.bttndel.Name = "bttndel"
        Me.bttndel.Size = New System.Drawing.Size(93, 33)
        Me.bttndel.TabIndex = 10
        Me.bttndel.Text = "Delete"
        Me.bttndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttndel.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(12, 9)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(25, 24)
        Me.lblname.TabIndex = 11
        Me.lblname.Text = "..."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        '
        'frm_deletepyment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 564)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.bttndel)
        Me.Controls.Add(Me.lstmembers)
        Me.Controls.Add(Me.txtprnumber)
        Me.Controls.Add(Me.bttnsearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frm_deletepyment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnsearch As System.Windows.Forms.Button
    Friend WithEvents txtprnumber As System.Windows.Forms.TextBox
    Public WithEvents lstmembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttndel As System.Windows.Forms.Button
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
