<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abstractofstocks_rel
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
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.crviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.collectionsheet1 = New Gsoft.collectionsheet
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.chkdetails = New Telerik.WinControls.UI.RadRadioButton
        Me.chksummary = New Telerik.WinControls.UI.RadRadioButton
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton
        CType(Me.chkdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chksummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtto
        '
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(15, 154)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(161, 22)
        Me.dtto.TabIndex = 1
        Me.dtto.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To :"
        '
        'crviewer
        '
        Me.crviewer.ActiveViewIndex = -1
        Me.crviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crviewer.Location = New System.Drawing.Point(232, 0)
        Me.crviewer.Name = "crviewer"
        Me.crviewer.SelectionFormula = ""
        Me.crviewer.Size = New System.Drawing.Size(994, 573)
        Me.crviewer.TabIndex = 0
        Me.crviewer.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "From :"
        '
        'dtfrom
        '
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(12, 105)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(161, 22)
        Me.dtfrom.TabIndex = 31
        Me.dtfrom.Value = New Date(2014, 11, 27, 0, 0, 0, 0)
        '
        'chkdetails
        '
        Me.chkdetails.BackColor = System.Drawing.Color.Transparent
        Me.chkdetails.Location = New System.Drawing.Point(12, 30)
        Me.chkdetails.Name = "chkdetails"
        Me.chkdetails.Size = New System.Drawing.Size(54, 18)
        Me.chkdetails.TabIndex = 32
        Me.chkdetails.TabStop = True
        Me.chkdetails.Text = "Details"
        Me.chkdetails.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chksummary
        '
        Me.chksummary.BackColor = System.Drawing.Color.Transparent
        Me.chksummary.Location = New System.Drawing.Point(83, 30)
        Me.chksummary.Name = "chksummary"
        Me.chksummary.Size = New System.Drawing.Size(67, 18)
        Me.chksummary.TabIndex = 33
        Me.chksummary.Text = "Summary"
        '
        'bttngenerate
        '
        Me.bttngenerate.Location = New System.Drawing.Point(15, 203)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(81, 36)
        Me.bttngenerate.TabIndex = 37
        Me.bttngenerate.Text = "Generate"
        '
        'frm_abstractofstocks_rel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1226, 573)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.chksummary)
        Me.Controls.Add(Me.chkdetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.crviewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_abstractofstocks_rel"
        Me.ShowIcon = False
        Me.Text = "Abstract of Stock Releases"
        CType(Me.chkdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chksummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents collectionsheet1 As Gsoft.collectionsheet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkdetails As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents chksummary As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
End Class
