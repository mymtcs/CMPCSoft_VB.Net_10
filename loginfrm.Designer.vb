<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginfrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginfrm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lbltstconn = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblnotification = New System.Windows.Forms.Label()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtserver_pass = New System.Windows.Forms.TextBox()
        Me.txtdb = New System.Windows.Forms.TextBox()
        Me.txtserver = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblattempt = New System.Windows.Forms.Label()
        Me.piclogin = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblprogress = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bttncancel = New System.Windows.Forms.LinkLabel()
        Me.bttnlogin = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtqoutes = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lblupdate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password :"
        '
        'txtuser
        '
        Me.txtuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(54, 36)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(277, 26)
        Me.txtuser.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(55, 90)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(277, 26)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'lbltstconn
        '
        Me.lbltstconn.AutoSize = True
        Me.lbltstconn.BackColor = System.Drawing.Color.Transparent
        Me.lbltstconn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbltstconn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltstconn.ForeColor = System.Drawing.Color.Red
        Me.lbltstconn.Location = New System.Drawing.Point(216, 202)
        Me.lbltstconn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbltstconn.Name = "lbltstconn"
        Me.lbltstconn.Size = New System.Drawing.Size(110, 15)
        Me.lbltstconn.TabIndex = 12
        Me.lbltstconn.Text = "Test Connection"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(36, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Server Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(36, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DB Name :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1139, 691)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Forgot Password?"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(1038, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "LOGIN"
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'lblnotification
        '
        Me.lblnotification.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnotification.AutoSize = True
        Me.lblnotification.BackColor = System.Drawing.Color.White
        Me.lblnotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotification.ForeColor = System.Drawing.Color.Maroon
        Me.lblnotification.Location = New System.Drawing.Point(135, 182)
        Me.lblnotification.Name = "lblnotification"
        Me.lblnotification.Size = New System.Drawing.Size(180, 15)
        Me.lblnotification.TabIndex = 23
        Me.lblnotification.Text = "Invalid username or password..."
        Me.lblnotification.Visible = False
        '
        'picerror
        '
        Me.picerror.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picerror.BackColor = System.Drawing.Color.White
        Me.picerror.Image = CType(resources.GetObject("picerror.Image"), System.Drawing.Image)
        Me.picerror.Location = New System.Drawing.Point(103, 174)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(31, 26)
        Me.picerror.TabIndex = 24
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(40, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(40, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(40, 161)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'txtserver_pass
        '
        Me.txtserver_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserver_pass.Location = New System.Drawing.Point(67, 162)
        Me.txtserver_pass.Name = "txtserver_pass"
        Me.txtserver_pass.Size = New System.Drawing.Size(259, 24)
        Me.txtserver_pass.TabIndex = 33
        Me.txtserver_pass.UseSystemPasswordChar = True
        '
        'txtdb
        '
        Me.txtdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdb.Location = New System.Drawing.Point(67, 99)
        Me.txtdb.Name = "txtdb"
        Me.txtdb.Size = New System.Drawing.Size(259, 24)
        Me.txtdb.TabIndex = 32
        '
        'txtserver
        '
        Me.txtserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserver.Location = New System.Drawing.Point(67, 35)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(259, 24)
        Me.txtserver.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(36, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Server Password :"
        '
        'lblattempt
        '
        Me.lblattempt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblattempt.AutoSize = True
        Me.lblattempt.BackColor = System.Drawing.Color.White
        Me.lblattempt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblattempt.ForeColor = System.Drawing.Color.DarkRed
        Me.lblattempt.Location = New System.Drawing.Point(133, 204)
        Me.lblattempt.Name = "lblattempt"
        Me.lblattempt.Size = New System.Drawing.Size(16, 15)
        Me.lblattempt.TabIndex = 27
        Me.lblattempt.Text = "..."
        Me.lblattempt.Visible = False
        '
        'piclogin
        '
        Me.piclogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.piclogin.Image = CType(resources.GetObject("piclogin.Image"), System.Drawing.Image)
        Me.piclogin.Location = New System.Drawing.Point(0, 0)
        Me.piclogin.Name = "piclogin"
        Me.piclogin.Size = New System.Drawing.Size(1273, 719)
        Me.piclogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogin.TabIndex = 30
        Me.piclogin.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(1071, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 22)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "CMPCsoft"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblversion
        '
        Me.lblversion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblversion.AutoSize = True
        Me.lblversion.BackColor = System.Drawing.Color.White
        Me.lblversion.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversion.ForeColor = System.Drawing.Color.Gray
        Me.lblversion.Location = New System.Drawing.Point(1162, 411)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(56, 14)
        Me.lblversion.TabIndex = 32
        Me.lblversion.Text = "0.0.0.0"
        '
        'progressBar
        '
        Me.progressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.progressBar.Location = New System.Drawing.Point(0, 708)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(119, 11)
        Me.progressBar.TabIndex = 34
        Me.progressBar.Visible = False
        '
        'lblprogress
        '
        Me.lblprogress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblprogress.AutoSize = True
        Me.lblprogress.BackColor = System.Drawing.Color.White
        Me.lblprogress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblprogress.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogress.ForeColor = System.Drawing.Color.Blue
        Me.lblprogress.Location = New System.Drawing.Point(872, 408)
        Me.lblprogress.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblprogress.Name = "lblprogress"
        Me.lblprogress.Size = New System.Drawing.Size(22, 17)
        Me.lblprogress.TabIndex = 35
        Me.lblprogress.Text = "00"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(871, 428)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(374, 260)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.bttncancel)
        Me.TabPage1.Controls.Add(Me.bttnlogin)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtpassword)
        Me.TabPage1.Controls.Add(Me.txtuser)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.picerror)
        Me.TabPage1.Controls.Add(Me.lblattempt)
        Me.TabPage1.Controls.Add(Me.lblnotification)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(366, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "                     Login                     "
        '
        'bttncancel
        '
        Me.bttncancel.AutoSize = True
        Me.bttncancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bttncancel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bttncancel.Location = New System.Drawing.Point(21, 206)
        Me.bttncancel.Name = "bttncancel"
        Me.bttncancel.Size = New System.Drawing.Size(24, 13)
        Me.bttncancel.TabIndex = 40
        Me.bttncancel.TabStop = True
        Me.bttncancel.Text = "Exit"
        '
        'bttnlogin
        '
        Me.bttnlogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.bttnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnlogin.ForeColor = System.Drawing.Color.White
        Me.bttnlogin.Image = CType(resources.GetObject("bttnlogin.Image"), System.Drawing.Image)
        Me.bttnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnlogin.Location = New System.Drawing.Point(149, 123)
        Me.bttnlogin.Name = "bttnlogin"
        Me.bttnlogin.Size = New System.Drawing.Size(182, 35)
        Me.bttnlogin.TabIndex = 39
        Me.bttnlogin.Text = "Login"
        Me.bttnlogin.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.PictureBox5)
        Me.TabPage2.Controls.Add(Me.lbltstconn)
        Me.TabPage2.Controls.Add(Me.txtserver_pass)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtdb)
        Me.TabPage2.Controls.Add(Me.txtserver)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(366, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "                  Setup Server                 "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(47, 202)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 15)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Test SQL Connection"
        Me.Label9.Visible = False
        '
        'txtqoutes
        '
        Me.txtqoutes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtqoutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtqoutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtqoutes.Enabled = False
        Me.txtqoutes.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqoutes.ForeColor = System.Drawing.Color.Black
        Me.txtqoutes.Location = New System.Drawing.Point(1022, 46)
        Me.txtqoutes.Multiline = True
        Me.txtqoutes.Name = "txtqoutes"
        Me.txtqoutes.Size = New System.Drawing.Size(226, 164)
        Me.txtqoutes.TabIndex = 37
        Me.txtqoutes.Text = """If You Are Working On Something That You Really Care About, You Don’t Have To Be" & _
            " Pushed. The Vision Pulls You.""- Steve Jobs"
        Me.txtqoutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(966, -10)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(322, 270)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'lblupdate
        '
        Me.lblupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblupdate.AutoSize = True
        Me.lblupdate.BackColor = System.Drawing.Color.White
        Me.lblupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblupdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblupdate.Location = New System.Drawing.Point(825, 695)
        Me.lblupdate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblupdate.Name = "lblupdate"
        Me.lblupdate.Size = New System.Drawing.Size(65, 15)
        Me.lblupdate.TabIndex = 39
        Me.lblupdate.Text = "Re-update"
        '
        'loginfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1273, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblupdate)
        Me.Controls.Add(Me.txtqoutes)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblprogress)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.piclogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "loginfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents lbltstconn As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblnotification As System.Windows.Forms.Label
    Friend WithEvents picerror As System.Windows.Forms.PictureBox
    Friend WithEvents lblattempt As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtserver As System.Windows.Forms.TextBox
    Friend WithEvents txtdb As System.Windows.Forms.TextBox
    Friend WithEvents txtserver_pass As System.Windows.Forms.TextBox
    Friend WithEvents piclogin As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblversion As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblprogress As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtqoutes As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents bttncancel As System.Windows.Forms.LinkLabel
    Friend WithEvents bttnlogin As System.Windows.Forms.Button
    Friend WithEvents lblupdate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
