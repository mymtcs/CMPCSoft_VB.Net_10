<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cb_reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cb_reports))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtreceipts = New System.Windows.Forms.DateTimePicker()
        Me.crvdetailsreceipts = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtdisburse = New System.Windows.Forms.DateTimePicker()
        Me.crvdetailsdesburse = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.chktemp = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtgen = New System.Windows.Forms.DateTimePicker()
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtsummtrn = New System.Windows.Forms.DateTimePicker()
        Me.crvsumm_of_trn = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1098, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "               Cashiers Detailed Reports               "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1092, 501)
        Me.TabControl2.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.dtreceipts)
        Me.TabPage3.Controls.Add(Me.crvdetailsreceipts)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1084, 473)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Cash Reciepts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(630, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dtreceipts
        '
        Me.dtreceipts.Enabled = False
        Me.dtreceipts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtreceipts.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtreceipts.Location = New System.Drawing.Point(482, 7)
        Me.dtreceipts.Name = "dtreceipts"
        Me.dtreceipts.Size = New System.Drawing.Size(144, 22)
        Me.dtreceipts.TabIndex = 4
        Me.dtreceipts.Value = New Date(2015, 2, 9, 0, 0, 0, 0)
        '
        'crvdetailsreceipts
        '
        Me.crvdetailsreceipts.ActiveViewIndex = -1
        Me.crvdetailsreceipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvdetailsreceipts.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvdetailsreceipts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvdetailsreceipts.Location = New System.Drawing.Point(3, 3)
        Me.crvdetailsreceipts.Name = "crvdetailsreceipts"
        Me.crvdetailsreceipts.SelectionFormula = ""
        Me.crvdetailsreceipts.Size = New System.Drawing.Size(1078, 467)
        Me.crvdetailsreceipts.TabIndex = 2
        Me.crvdetailsreceipts.ToolPanelWidth = 150
        Me.crvdetailsreceipts.ViewTimeSelectionFormula = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.dtdisburse)
        Me.TabPage4.Controls.Add(Me.crvdetailsdesburse)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1084, 473)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Cash Disburse"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(630, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 27)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "View"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dtdisburse
        '
        Me.dtdisburse.Enabled = False
        Me.dtdisburse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdisburse.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdisburse.Location = New System.Drawing.Point(482, 7)
        Me.dtdisburse.Name = "dtdisburse"
        Me.dtdisburse.Size = New System.Drawing.Size(144, 22)
        Me.dtdisburse.TabIndex = 7
        Me.dtdisburse.Value = New Date(2015, 2, 9, 0, 0, 0, 0)
        '
        'crvdetailsdesburse
        '
        Me.crvdetailsdesburse.ActiveViewIndex = -1
        Me.crvdetailsdesburse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvdetailsdesburse.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvdetailsdesburse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvdetailsdesburse.Location = New System.Drawing.Point(3, 3)
        Me.crvdetailsdesburse.Name = "crvdetailsdesburse"
        Me.crvdetailsdesburse.SelectionFormula = ""
        Me.crvdetailsdesburse.Size = New System.Drawing.Size(1078, 467)
        Me.crvdetailsdesburse.TabIndex = 6
        Me.crvdetailsdesburse.ViewTimeSelectionFormula = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1098, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "               Cashiers Summary Reports               "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(3, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1092, 501)
        Me.TabControl3.TabIndex = 4
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.chktemp)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.dtgen)
        Me.TabPage5.Controls.Add(Me.CRviewer)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1084, 473)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "         General Report         "
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'chktemp
        '
        Me.chktemp.AutoSize = True
        Me.chktemp.Location = New System.Drawing.Point(728, 6)
        Me.chktemp.Name = "chktemp"
        Me.chktemp.Size = New System.Drawing.Size(123, 19)
        Me.chktemp.TabIndex = 4
        Me.chktemp.Text = "From July 1, 2019"
        Me.chktemp.UseVisualStyleBackColor = True
        Me.chktemp.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(634, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtgen
        '
        Me.dtgen.Enabled = False
        Me.dtgen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtgen.Location = New System.Drawing.Point(486, 6)
        Me.dtgen.Name = "dtgen"
        Me.dtgen.Size = New System.Drawing.Size(144, 22)
        Me.dtgen.TabIndex = 2
        Me.dtgen.Value = New Date(2015, 2, 9, 0, 0, 0, 0)
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRviewer.Location = New System.Drawing.Point(3, 3)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(1078, 467)
        Me.CRviewer.TabIndex = 1
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Button5)
        Me.TabPage6.Controls.Add(Me.Button4)
        Me.TabPage6.Controls.Add(Me.dtsummtrn)
        Me.TabPage6.Controls.Add(Me.crvsumm_of_trn)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1084, 473)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Summary of Transaction"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(716, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Create Journal"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(635, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 27)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "View"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dtsummtrn
        '
        Me.dtsummtrn.Enabled = False
        Me.dtsummtrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsummtrn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtsummtrn.Location = New System.Drawing.Point(487, 6)
        Me.dtsummtrn.Name = "dtsummtrn"
        Me.dtsummtrn.Size = New System.Drawing.Size(144, 22)
        Me.dtsummtrn.TabIndex = 4
        Me.dtsummtrn.Value = New Date(2015, 2, 9, 0, 0, 0, 0)
        '
        'crvsumm_of_trn
        '
        Me.crvsumm_of_trn.ActiveViewIndex = -1
        Me.crvsumm_of_trn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvsumm_of_trn.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvsumm_of_trn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvsumm_of_trn.Location = New System.Drawing.Point(3, 3)
        Me.crvsumm_of_trn.Name = "crvsumm_of_trn"
        Me.crvsumm_of_trn.SelectionFormula = ""
        Me.crvsumm_of_trn.Size = New System.Drawing.Size(1078, 467)
        Me.crvsumm_of_trn.TabIndex = 2
        Me.crvsumm_of_trn.ToolPanelWidth = 267
        Me.crvsumm_of_trn.ViewTimeSelectionFormula = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1106, 538)
        Me.TabControl1.TabIndex = 4
        '
        'frm_cb_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1106, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_cb_reports"
        Me.ShowIcon = False
        Me.Text = "Cashiers Blotter"
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtreceipts As System.Windows.Forms.DateTimePicker
    Friend WithEvents crvdetailsreceipts As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtdisburse As System.Windows.Forms.DateTimePicker
    Friend WithEvents crvdetailsdesburse As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtgen As System.Windows.Forms.DateTimePicker
    Friend WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dtsummtrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents crvsumm_of_trn As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents chktemp As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
