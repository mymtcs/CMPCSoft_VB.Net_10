<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PAR
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
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.gendate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblcode = New System.Windows.Forms.Label
        Me.txtcoll = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cboption = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstpar = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crviewer.Location = New System.Drawing.Point(0, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(1257, 602)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'gendate
        '
        Me.gendate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.gendate.Location = New System.Drawing.Point(449, 5)
        Me.gendate.Name = "gendate"
        Me.gendate.Size = New System.Drawing.Size(132, 22)
        Me.gendate.TabIndex = 1
        Me.gendate.Value = New Date(2014, 11, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(381, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gen. Date :"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblcode.Location = New System.Drawing.Point(813, 10)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(13, 13)
        Me.lblcode.TabIndex = 3
        Me.lblcode.Text = ".."
        '
        'txtcoll
        '
        Me.txtcoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcoll.DropDownWidth = 151
        Me.txtcoll.FormattingEnabled = True
        Me.txtcoll.Location = New System.Drawing.Point(880, 6)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(121, 21)
        Me.txtcoll.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1023, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generate.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboption
        '
        Me.cboption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboption.FormattingEnabled = True
        Me.cboption.Items.AddRange(New Object() {"Center", "Product Assistant"})
        Me.cboption.Location = New System.Drawing.Point(662, 5)
        Me.cboption.Name = "cboption"
        Me.cboption.Size = New System.Drawing.Size(121, 21)
        Me.cboption.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(595, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search By :"
        '
        'lstpar
        '
        Me.lstpar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader1})
        Me.lstpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstpar.FullRowSelect = True
        Me.lstpar.GridLines = True
        Me.lstpar.Location = New System.Drawing.Point(241, 215)
        Me.lstpar.Name = "lstpar"
        Me.lstpar.Size = New System.Drawing.Size(499, 128)
        Me.lstpar.TabIndex = 8
        Me.lstpar.UseCompatibleStateImageBehavior = False
        Me.lstpar.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Total Members"
        Me.ColumnHeader12.Width = 103
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Loan Amount Over Due"
        Me.ColumnHeader13.Width = 157
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Outstanding Balance"
        Me.ColumnHeader14.Width = 112
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Days"
        Me.ColumnHeader1.Width = 109
        '
        'frm_PAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1257, 602)
        Me.Controls.Add(Me.cboption)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcoll)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gendate)
        Me.Controls.Add(Me.crviewer)
        Me.Controls.Add(Me.lstpar)
        Me.Name = "frm_PAR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portfolio at Risk Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents PARreports1 As CMPCsoft.PARreports
    Friend WithEvents gendate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcode As System.Windows.Forms.Label
    Friend WithEvents txtcoll As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboption As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstpar As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
