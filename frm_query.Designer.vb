<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_query
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_query))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttn_execute = New System.Windows.Forms.Button()
        Me.txtquery = New System.Windows.Forms.RichTextBox()
        Me.dtgrid_result = New System.Windows.Forms.DataGridView()
        Me.bttnexport = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblpercent = New System.Windows.Forms.Label()
        Me.prgbar = New System.Windows.Forms.ProgressBar()
        CType(Me.dtgrid_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Query"
        '
        'bttn_execute
        '
        Me.bttn_execute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttn_execute.BackColor = System.Drawing.Color.White
        Me.bttn_execute.ForeColor = System.Drawing.Color.Black
        Me.bttn_execute.Image = CType(resources.GetObject("bttn_execute.Image"), System.Drawing.Image)
        Me.bttn_execute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttn_execute.Location = New System.Drawing.Point(848, 12)
        Me.bttn_execute.Name = "bttn_execute"
        Me.bttn_execute.Size = New System.Drawing.Size(112, 35)
        Me.bttn_execute.TabIndex = 5
        Me.bttn_execute.Text = "     Execute Query"
        Me.bttn_execute.UseVisualStyleBackColor = False
        '
        'txtquery
        '
        Me.txtquery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtquery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquery.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquery.Location = New System.Drawing.Point(12, 49)
        Me.txtquery.Name = "txtquery"
        Me.txtquery.Size = New System.Drawing.Size(1074, 88)
        Me.txtquery.TabIndex = 0
        Me.txtquery.Text = ""
        '
        'dtgrid_result
        '
        Me.dtgrid_result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgrid_result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgrid_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_result.GridColor = System.Drawing.Color.DodgerBlue
        Me.dtgrid_result.Location = New System.Drawing.Point(12, 174)
        Me.dtgrid_result.Name = "dtgrid_result"
        Me.dtgrid_result.ReadOnly = True
        Me.dtgrid_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrid_result.Size = New System.Drawing.Size(1074, 355)
        Me.dtgrid_result.TabIndex = 138
        '
        'bttnexport
        '
        Me.bttnexport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnexport.BackColor = System.Drawing.Color.White
        Me.bttnexport.ForeColor = System.Drawing.Color.Black
        Me.bttnexport.Image = CType(resources.GetObject("bttnexport.Image"), System.Drawing.Image)
        Me.bttnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnexport.Location = New System.Drawing.Point(979, 12)
        Me.bttnexport.Name = "bttnexport"
        Me.bttnexport.Size = New System.Drawing.Size(107, 35)
        Me.bttnexport.TabIndex = 139
        Me.bttnexport.Text = "       Export Result"
        Me.bttnexport.UseVisualStyleBackColor = False
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Blue
        Me.lblerror.Location = New System.Drawing.Point(25, 142)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(16, 14)
        Me.lblerror.TabIndex = 140
        Me.lblerror.Text = "..."
        '
        'lblpercent
        '
        Me.lblpercent.AutoSize = True
        Me.lblpercent.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpercent.Location = New System.Drawing.Point(1046, 141)
        Me.lblpercent.Name = "lblpercent"
        Me.lblpercent.Size = New System.Drawing.Size(13, 13)
        Me.lblpercent.TabIndex = 142
        Me.lblpercent.Text = "0"
        Me.lblpercent.Visible = False
        '
        'prgbar
        '
        Me.prgbar.Location = New System.Drawing.Point(790, 142)
        Me.prgbar.Name = "prgbar"
        Me.prgbar.Size = New System.Drawing.Size(253, 10)
        Me.prgbar.TabIndex = 141
        Me.prgbar.Visible = False
        '
        'frm_query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1098, 541)
        Me.Controls.Add(Me.lblpercent)
        Me.Controls.Add(Me.prgbar)
        Me.Controls.Add(Me.bttn_execute)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.bttnexport)
        Me.Controls.Add(Me.dtgrid_result)
        Me.Controls.Add(Me.txtquery)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Query"
        CType(Me.dtgrid_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttn_execute As System.Windows.Forms.Button
    Friend WithEvents txtquery As System.Windows.Forms.RichTextBox
    Friend WithEvents dtgrid_result As System.Windows.Forms.DataGridView
    Friend WithEvents bttnexport As System.Windows.Forms.Button
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblpercent As System.Windows.Forms.Label
    Friend WithEvents prgbar As System.Windows.Forms.ProgressBar
End Class
