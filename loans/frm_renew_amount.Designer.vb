<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_renew_amount
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpdi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprin = New System.Windows.Forms.TextBox()
        Me.bttnok = New System.Windows.Forms.Button()
        Me.lblterm = New System.Windows.Forms.Label()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.cboterms = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcycle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttncompute = New System.Windows.Forms.Button()
        Me.txtno_of_months = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpdp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalLoanBal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLHPayments = New System.Windows.Forms.TextBox()
        Me.txtRenewAmt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNetLoanAmt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLoanNum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.txtno_of_months, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(12, 118)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 191
        Me.Label8.Text = "Running Balance"
        '
        'txtpdi
        '
        Me.txtpdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdi.ForeColor = System.Drawing.Color.Lime
        Me.txtpdi.Location = New System.Drawing.Point(155, 48)
        Me.txtpdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdi.Name = "txtpdi"
        Me.txtpdi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpdi.Size = New System.Drawing.Size(160, 41)
        Me.txtpdi.TabIndex = 192
        Me.txtpdi.Text = "0"
        Me.txtpdi.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(158, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 20)
        Me.Label9.TabIndex = 193
        Me.Label9.Text = "PDI"
        Me.Label9.Visible = False
        '
        'txtprin
        '
        Me.txtprin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtprin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprin.ForeColor = System.Drawing.Color.White
        Me.txtprin.Location = New System.Drawing.Point(154, 105)
        Me.txtprin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprin.Name = "txtprin"
        Me.txtprin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtprin.Size = New System.Drawing.Size(167, 41)
        Me.txtprin.TabIndex = 190
        Me.txtprin.Text = "0"
        '
        'bttnok
        '
        Me.bttnok.Location = New System.Drawing.Point(233, 178)
        Me.bttnok.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnok.Name = "bttnok"
        Me.bttnok.Size = New System.Drawing.Size(132, 43)
        Me.bttnok.TabIndex = 194
        Me.bttnok.Text = "Continue"
        Me.bttnok.UseVisualStyleBackColor = True
        '
        'lblterm
        '
        Me.lblterm.AutoSize = True
        Me.lblterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterm.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblterm.Location = New System.Drawing.Point(24, 161)
        Me.lblterm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblterm.Name = "lblterm"
        Me.lblterm.Size = New System.Drawing.Size(136, 20)
        Me.lblterm.TabIndex = 196
        Me.lblterm.Text = "Payment Amount"
        '
        'txtpayment
        '
        Me.txtpayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtpayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayment.ForeColor = System.Drawing.Color.Lime
        Me.txtpayment.Location = New System.Drawing.Point(28, 185)
        Me.txtpayment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpayment.Size = New System.Drawing.Size(167, 41)
        Me.txtpayment.TabIndex = 195
        Me.txtpayment.Text = "0"
        '
        'cboterms
        '
        Me.cboterms.DropDownHeight = 80
        Me.cboterms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboterms.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboterms.FormattingEnabled = True
        Me.cboterms.IntegralHeight = False
        Me.cboterms.Items.AddRange(New Object() {"Daily", "Week(s)", "Semi-Monthly", "Month(s)", "Yearl(s)"})
        Me.cboterms.Location = New System.Drawing.Point(25, 52)
        Me.cboterms.Margin = New System.Windows.Forms.Padding(4)
        Me.cboterms.Name = "cboterms"
        Me.cboterms.Size = New System.Drawing.Size(359, 31)
        Me.cboterms.TabIndex = 197
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Term"
        '
        'txtcycle
        '
        Me.txtcycle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtcycle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcycle.ForeColor = System.Drawing.Color.Lime
        Me.txtcycle.Location = New System.Drawing.Point(27, 111)
        Me.txtcycle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcycle.Name = "txtcycle"
        Me.txtcycle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtcycle.Size = New System.Drawing.Size(167, 41)
        Me.txtcycle.TabIndex = 199
        Me.txtcycle.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(23, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "No. of Payment"
        '
        'bttncompute
        '
        Me.bttncompute.Location = New System.Drawing.Point(233, 109)
        Me.bttncompute.Margin = New System.Windows.Forms.Padding(4)
        Me.bttncompute.Name = "bttncompute"
        Me.bttncompute.Size = New System.Drawing.Size(132, 43)
        Me.bttncompute.TabIndex = 201
        Me.bttncompute.Text = "Compute"
        Me.bttncompute.UseVisualStyleBackColor = True
        '
        'txtno_of_months
        '
        Me.txtno_of_months.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtno_of_months.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_of_months.ForeColor = System.Drawing.Color.Lime
        Me.txtno_of_months.Location = New System.Drawing.Point(21, 52)
        Me.txtno_of_months.Margin = New System.Windows.Forms.Padding(4)
        Me.txtno_of_months.Name = "txtno_of_months"
        Me.txtno_of_months.Size = New System.Drawing.Size(126, 37)
        Me.txtno_of_months.TabIndex = 202
        Me.txtno_of_months.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtno_of_months.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(21, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "No. Of Months"
        Me.Label3.Visible = False
        '
        'txtpdp
        '
        Me.txtpdp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpdp.ForeColor = System.Drawing.Color.Lime
        Me.txtpdp.Location = New System.Drawing.Point(323, 47)
        Me.txtpdp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpdp.Name = "txtpdp"
        Me.txtpdp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpdp.Size = New System.Drawing.Size(193, 41)
        Me.txtpdp.TabIndex = 204
        Me.txtpdp.Text = "0"
        Me.txtpdp.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(321, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "PDP"
        Me.Label4.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 576)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 45)
        Me.Button1.TabIndex = 206
        Me.Button1.Text = "Print Agreement"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTotalLoanBal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLHPayments)
        Me.GroupBox1.Controls.Add(Me.txtRenewAmt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtpdp)
        Me.GroupBox1.Controls.Add(Me.txtprin)
        Me.GroupBox1.Controls.Add(Me.txtpdi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtno_of_months)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 59)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(526, 294)
        Me.GroupBox1.TabIndex = 207
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compute "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(174, 207)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 20)
        Me.Label11.TabIndex = 215
        Me.Label11.Text = "Total Loan Balance"
        '
        'txtTotalLoanBal
        '
        Me.txtTotalLoanBal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtTotalLoanBal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalLoanBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLoanBal.ForeColor = System.Drawing.Color.White
        Me.txtTotalLoanBal.Location = New System.Drawing.Point(341, 196)
        Me.txtTotalLoanBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalLoanBal.Name = "txtTotalLoanBal"
        Me.txtTotalLoanBal.ReadOnly = True
        Me.txtTotalLoanBal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalLoanBal.Size = New System.Drawing.Size(167, 41)
        Me.txtTotalLoanBal.TabIndex = 214
        Me.txtTotalLoanBal.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(16, 151)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 213
        Me.Label10.Text = "LH Remaining"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 212
        Me.Label5.Text = "# of Payments"
        '
        'txtLHPayments
        '
        Me.txtLHPayments.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtLHPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLHPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLHPayments.ForeColor = System.Drawing.Color.Lime
        Me.txtLHPayments.Location = New System.Drawing.Point(155, 151)
        Me.txtLHPayments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLHPayments.Name = "txtLHPayments"
        Me.txtLHPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLHPayments.Size = New System.Drawing.Size(167, 41)
        Me.txtLHPayments.TabIndex = 211
        Me.txtLHPayments.Text = "0"
        '
        'txtRenewAmt
        '
        Me.txtRenewAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtRenewAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRenewAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenewAmt.ForeColor = System.Drawing.Color.Lime
        Me.txtRenewAmt.Location = New System.Drawing.Point(341, 240)
        Me.txtRenewAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRenewAmt.Name = "txtRenewAmt"
        Me.txtRenewAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRenewAmt.Size = New System.Drawing.Size(167, 41)
        Me.txtRenewAmt.TabIndex = 209
        Me.txtRenewAmt.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(217, 360)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 211
        Me.Label7.Text = "Gross Proceeds"
        '
        'txtNetLoanAmt
        '
        Me.txtNetLoanAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtNetLoanAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNetLoanAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetLoanAmt.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.txtNetLoanAmt.Location = New System.Drawing.Point(356, 348)
        Me.txtNetLoanAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetLoanAmt.Name = "txtNetLoanAmt"
        Me.txtNetLoanAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNetLoanAmt.Size = New System.Drawing.Size(167, 41)
        Me.txtNetLoanAmt.TabIndex = 211
        Me.txtNetLoanAmt.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.bttnok)
        Me.GroupBox2.Controls.Add(Me.txtpayment)
        Me.GroupBox2.Controls.Add(Me.bttncompute)
        Me.GroupBox2.Controls.Add(Me.lblterm)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboterms)
        Me.GroupBox2.Controls.Add(Me.txtcycle)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 397)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(399, 242)
        Me.GroupBox2.TabIndex = 208
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Terms of Payment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(210, 311)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Renew Amount"
        '
        'txtLoanNum
        '
        Me.txtLoanNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtLoanNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLoanNum.Enabled = False
        Me.txtLoanNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanNum.ForeColor = System.Drawing.Color.White
        Me.txtLoanNum.Location = New System.Drawing.Point(171, 5)
        Me.txtLoanNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLoanNum.Name = "txtLoanNum"
        Me.txtLoanNum.ReadOnly = True
        Me.txtLoanNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLoanNum.Size = New System.Drawing.Size(371, 41)
        Me.txtLoanNum.TabIndex = 216
        Me.txtLoanNum.Text = "0"
        Me.txtLoanNum.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(21, 16)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 216
        Me.Label12.Text = "Loan Number"
        Me.Label12.Visible = False
        '
        'frm_renew_amount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(567, 647)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLoanNum)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNetLoanAmt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_renew_amount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Renew Loan"
        CType(Me.txtno_of_months, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpdi As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtprin As System.Windows.Forms.TextBox
    Friend WithEvents bttnok As System.Windows.Forms.Button
    Friend WithEvents lblterm As System.Windows.Forms.Label
    Friend WithEvents txtpayment As System.Windows.Forms.TextBox
    Friend WithEvents cboterms As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcycle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttncompute As System.Windows.Forms.Button
    Friend WithEvents txtno_of_months As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpdp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRenewAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNetLoanAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLoanBal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLHPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanNum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
