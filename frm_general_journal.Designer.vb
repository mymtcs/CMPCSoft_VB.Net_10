<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_general_journal_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_general_journal_report))
        Me.txtref = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dttrn = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Radgview = New Telerik.WinControls.UI.RadGridView
        Me.bttnsave = New Telerik.WinControls.UI.RadButton
        Me.bttnnew = New Telerik.WinControls.UI.RadButton
        Me.bttnclose = New Telerik.WinControls.UI.RadButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbldebit = New System.Windows.Forms.Label
        Me.lblcredit = New System.Windows.Forms.Label
        Me.lbloutbal = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.bttnprint = New Telerik.WinControls.UI.RadButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.Radgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Radgview.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bttnprint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(147, 35)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(243, 26)
        Me.txtref.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reference No. :"
        '
        'dttrn
        '
        Me.dttrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttrn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttrn.Location = New System.Drawing.Point(9, 35)
        Me.dttrn.Name = "dttrn"
        Me.dttrn.Size = New System.Drawing.Size(114, 24)
        Me.dttrn.TabIndex = 15
        Me.dttrn.Value = New Date(2015, 2, 6, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Date :"
        '
        'Radgview
        '
        Me.Radgview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radgview.BackColor = System.Drawing.SystemColors.Control
        Me.Radgview.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter
        Me.Radgview.Cursor = System.Windows.Forms.Cursors.Default
        Me.Radgview.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextCell
        Me.Radgview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Radgview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Radgview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Radgview.Location = New System.Drawing.Point(7, 80)
        '
        'Radgview
        '
        Me.Radgview.MasterTemplate.AutoGenerateColumns = False
        Me.Radgview.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.Radgview.Name = "Radgview"
        Me.Radgview.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell
        Me.Radgview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Radgview.Size = New System.Drawing.Size(794, 221)
        Me.Radgview.TabIndex = 85
        '
        'bttnsave
        '
        Me.bttnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnsave.Image = CType(resources.GetObject("bttnsave.Image"), System.Drawing.Image)
        Me.bttnsave.Location = New System.Drawing.Point(534, 10)
        Me.bttnsave.Name = "bttnsave"
        Me.bttnsave.Size = New System.Drawing.Size(84, 37)
        Me.bttnsave.TabIndex = 86
        Me.bttnsave.Text = "Save"
        '
        'bttnnew
        '
        Me.bttnnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnnew.Image = CType(resources.GetObject("bttnnew.Image"), System.Drawing.Image)
        Me.bttnnew.Location = New System.Drawing.Point(624, 10)
        Me.bttnnew.Name = "bttnnew"
        Me.bttnnew.Size = New System.Drawing.Size(84, 37)
        Me.bttnnew.TabIndex = 87
        Me.bttnnew.Text = "New"
        '
        'bttnclose
        '
        Me.bttnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnclose.Image = CType(resources.GetObject("bttnclose.Image"), System.Drawing.Image)
        Me.bttnclose.Location = New System.Drawing.Point(714, 10)
        Me.bttnclose.Name = "bttnclose"
        Me.bttnclose.Size = New System.Drawing.Size(84, 37)
        Me.bttnclose.TabIndex = 88
        Me.bttnclose.Text = "Close"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(592, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Total :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(537, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 14)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Out of balance :"
        '
        'lbldebit
        '
        Me.lbldebit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldebit.AutoSize = True
        Me.lbldebit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebit.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbldebit.Location = New System.Drawing.Point(657, 325)
        Me.lbldebit.Name = "lbldebit"
        Me.lbldebit.Size = New System.Drawing.Size(32, 14)
        Me.lbldebit.TabIndex = 91
        Me.lbldebit.Text = "0.00"
        '
        'lblcredit
        '
        Me.lblcredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcredit.AutoSize = True
        Me.lblcredit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredit.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblcredit.Location = New System.Drawing.Point(742, 325)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(32, 14)
        Me.lblcredit.TabIndex = 92
        Me.lblcredit.Text = "0.00"
        '
        'lbloutbal
        '
        Me.lbloutbal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbloutbal.AutoSize = True
        Me.lbloutbal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutbal.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbloutbal.Location = New System.Drawing.Point(657, 354)
        Me.lbloutbal.Name = "lbloutbal"
        Me.lbloutbal.Size = New System.Drawing.Size(32, 14)
        Me.lbloutbal.TabIndex = 93
        Me.lbloutbal.Text = "0.00"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.bttnclose)
        Me.Panel1.Controls.Add(Me.bttnsave)
        Me.Panel1.Controls.Add(Me.bttnnew)
        Me.Panel1.Location = New System.Drawing.Point(-3, 395)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 54)
        Me.Panel1.TabIndex = 94
        '
        'bttnprint
        '
        Me.bttnprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnprint.Location = New System.Drawing.Point(738, 28)
        Me.bttnprint.Name = "bttnprint"
        Me.bttnprint.Size = New System.Drawing.Size(63, 31)
        Me.bttnprint.TabIndex = 89
        Me.bttnprint.Text = "Print"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(654, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 14)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "_________________"
        '
        'txtdesc
        '
        Me.txtdesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(7, 329)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(423, 39)
        Me.txtdesc.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Description :"
        '
        'frm_general_journal_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(807, 448)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.bttnprint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbloutbal)
        Me.Controls.Add(Me.lblcredit)
        Me.Controls.Add(Me.lbldebit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Radgview)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dttrn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_general_journal_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New General Journal"
        CType(Me.Radgview.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Radgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bttnprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dttrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Radgview As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bttnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents bttnclose As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbldebit As System.Windows.Forms.Label
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents lbloutbal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bttnprint As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
