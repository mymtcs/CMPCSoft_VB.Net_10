<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_export_payment_forSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_export_payment_forSMS))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bttnexport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lstcbu = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtpick = New System.Windows.Forms.DateTimePicker()
        Me.lstcrypt = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bttnexport, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(837, 25)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bttnexport
        '
        Me.bttnexport.Image = CType(resources.GetObject("bttnexport.Image"), System.Drawing.Image)
        Me.bttnexport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bttnexport.Name = "bttnexport"
        Me.bttnexport.Size = New System.Drawing.Size(60, 22)
        Me.bttnexport.Text = "Export"
        Me.bttnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "View"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'lstcbu
        '
        Me.lstcbu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstcbu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader15, Me.ColumnHeader6})
        Me.lstcbu.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcbu.FullRowSelect = True
        Me.lstcbu.GridLines = True
        Me.lstcbu.Location = New System.Drawing.Point(0, 27)
        Me.lstcbu.Name = "lstcbu"
        Me.lstcbu.Size = New System.Drawing.Size(837, 504)
        Me.lstcbu.TabIndex = 126
        Me.lstcbu.UseCompatibleStateImageBehavior = False
        Me.lstcbu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Contact No."
        Me.ColumnHeader10.Width = 148
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Content"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Account Name"
        Me.ColumnHeader12.Width = 127
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Amnt. Posted"
        Me.ColumnHeader15.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance"
        Me.ColumnHeader6.Width = 0
        '
        'dtpick
        '
        Me.dtpick.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpick.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpick.Location = New System.Drawing.Point(589, 1)
        Me.dtpick.Name = "dtpick"
        Me.dtpick.Size = New System.Drawing.Size(116, 23)
        Me.dtpick.TabIndex = 127
        Me.dtpick.Value = New Date(2018, 3, 22, 0, 0, 0, 0)
        '
        'lstcrypt
        '
        Me.lstcrypt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstcrypt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstcrypt.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcrypt.FullRowSelect = True
        Me.lstcrypt.GridLines = True
        Me.lstcrypt.Location = New System.Drawing.Point(0, 27)
        Me.lstcrypt.Name = "lstcrypt"
        Me.lstcrypt.Size = New System.Drawing.Size(837, 504)
        Me.lstcrypt.TabIndex = 128
        Me.lstcrypt.UseCompatibleStateImageBehavior = False
        Me.lstcrypt.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CBU Account"
        Me.ColumnHeader1.Width = 148
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Account Name"
        Me.ColumnHeader2.Width = 337
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Balance"
        Me.ColumnHeader3.Width = 127
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Average"
        Me.ColumnHeader4.Width = 118
        '
        'frm_export_payment_forSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(837, 531)
        Me.Controls.Add(Me.dtpick)
        Me.Controls.Add(Me.lstcbu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstcrypt)
        Me.MaximizeBox = False
        Me.Name = "frm_export_payment_forSMS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Amount Posted for SMS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bttnexport As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstcbu As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpick As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstcrypt As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
