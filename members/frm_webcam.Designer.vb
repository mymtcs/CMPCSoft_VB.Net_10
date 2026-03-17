<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_webcam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_webcam))
        Me.pic_sel_img = New System.Windows.Forms.PictureBox()
        Me.btnStart = New Telerik.WinControls.UI.RadButton()
        Me.lstDevices = New System.Windows.Forms.ComboBox()
        Me.sfdImage = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_capture = New System.Windows.Forms.PictureBox()
        Me.bttncapture = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttnsave = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pic_sel_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_capture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic_sel_img
        '
        Me.pic_sel_img.BackColor = System.Drawing.Color.Black
        Me.pic_sel_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_sel_img.Location = New System.Drawing.Point(12, 73)
        Me.pic_sel_img.Name = "pic_sel_img"
        Me.pic_sel_img.Size = New System.Drawing.Size(301, 245)
        Me.pic_sel_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_sel_img.TabIndex = 0
        Me.pic_sel_img.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(319, 19)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(101, 30)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        '
        'lstDevices
        '
        Me.lstDevices.BackColor = System.Drawing.SystemColors.InfoText
        Me.lstDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lstDevices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDevices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.Location = New System.Drawing.Point(9, 25)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(304, 24)
        Me.lstDevices.TabIndex = 3
        '
        'sfdImage
        '
        Me.sfdImage.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Camera Source :"
        '
        'pic_capture
        '
        Me.pic_capture.BackColor = System.Drawing.Color.Black
        Me.pic_capture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_capture.Location = New System.Drawing.Point(316, 73)
        Me.pic_capture.Name = "pic_capture"
        Me.pic_capture.Size = New System.Drawing.Size(301, 245)
        Me.pic_capture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_capture.TabIndex = 7
        Me.pic_capture.TabStop = False
        '
        'bttncapture
        '
        Me.bttncapture.BackColor = System.Drawing.Color.White
        Me.bttncapture.BackgroundImage = CType(resources.GetObject("bttncapture.BackgroundImage"), System.Drawing.Image)
        Me.bttncapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttncapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttncapture.Location = New System.Drawing.Point(266, 1)
        Me.bttncapture.Name = "bttncapture"
        Me.bttncapture.Size = New System.Drawing.Size(32, 28)
        Me.bttncapture.TabIndex = 8
        Me.bttncapture.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(269, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bttnsave
        '
        Me.bttnsave.Location = New System.Drawing.Point(435, 19)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(101, 30)
        Me.bttnsave.TabIndex = 10
        Me.bttnsave.Text = "Save && Close"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bttncapture)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 28)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(152, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Capture Photo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(316, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 28)
        Me.Panel2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(170, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Upload Photo"
        '
        'frm_webcam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(629, 343)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttnsave)
        Me.Controls.Add(Me.pic_capture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pic_sel_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_webcam"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture Image"
        CType(Me.pic_sel_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_capture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_sel_img As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As Telerik.WinControls.UI.RadButton
    Friend WithEvents lstDevices As System.Windows.Forms.ComboBox
    Friend WithEvents sfdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic_capture As System.Windows.Forms.PictureBox
    Friend WithEvents bttncapture As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
