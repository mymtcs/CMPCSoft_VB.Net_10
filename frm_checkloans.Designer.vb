<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_checkloans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_checkloans))
        Me.Label1 = New System.Windows.Forms.Label
        Me.bttnlogin = New System.Windows.Forms.Button
        Me.bttncancel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbdatabase = New System.Windows.Forms.ComboBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbserver = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Database Name :"
        '
        'bttnlogin
        '
        Me.bttnlogin.BackColor = System.Drawing.Color.Transparent
        Me.bttnlogin.BackgroundImage = CType(resources.GetObject("bttnlogin.BackgroundImage"), System.Drawing.Image)
        Me.bttnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnlogin.FlatAppearance.BorderSize = 0
        Me.bttnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttnlogin.Location = New System.Drawing.Point(84, 146)
        Me.bttnlogin.Name = "bttnlogin"
        Me.bttnlogin.Size = New System.Drawing.Size(90, 43)
        Me.bttnlogin.TabIndex = 6
        Me.bttnlogin.Text = "&Backup"
        Me.bttnlogin.UseVisualStyleBackColor = False
        '
        'bttncancel
        '
        Me.bttncancel.BackColor = System.Drawing.Color.Transparent
        Me.bttncancel.BackgroundImage = CType(resources.GetObject("bttncancel.BackgroundImage"), System.Drawing.Image)
        Me.bttncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttncancel.FlatAppearance.BorderSize = 0
        Me.bttncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttncancel.Location = New System.Drawing.Point(171, 146)
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(90, 43)
        Me.bttncancel.TabIndex = 7
        Me.bttncancel.Text = "&Close"
        Me.bttncancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Server Name :"
        '
        'cmbdatabase
        '
        Me.cmbdatabase.FormattingEnabled = True
        Me.cmbdatabase.Location = New System.Drawing.Point(39, 119)
        Me.cmbdatabase.Name = "cmbdatabase"
        Me.cmbdatabase.Size = New System.Drawing.Size(222, 21)
        Me.cmbdatabase.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(236, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 52)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'cmbserver
        '
        Me.cmbserver.FormattingEnabled = True
        Me.cmbserver.Location = New System.Drawing.Point(39, 68)
        Me.cmbserver.Name = "cmbserver"
        Me.cmbserver.Size = New System.Drawing.Size(222, 21)
        Me.cmbserver.TabIndex = 13
        '
        'frm_checkloans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(284, 193)
        Me.Controls.Add(Me.cmbserver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbdatabase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnlogin)
        Me.Controls.Add(Me.bttncancel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_checkloans"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Back up Database"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnlogin As System.Windows.Forms.Button
    Friend WithEvents bttncancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbdatabase As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbserver As System.Windows.Forms.ComboBox
End Class
