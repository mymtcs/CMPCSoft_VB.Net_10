<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_progres_bar
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
        Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim CartesianArea2 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_progres_bar))
        Me.progress_chartview = New Telerik.WinControls.UI.RadChartView()
        Me.lbllp_title = New System.Windows.Forms.Label()
        Me.txtcoll = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.bttngenerate = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtasof = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.memberschartview = New Telerik.WinControls.UI.RadChartView()
        Me.lblmembers_title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.txtdaymode = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.progress_chartview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.progress_chartview.SuspendLayout()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memberschartview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.memberschartview.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtdaymode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progress_chartview
        '
        Me.progress_chartview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CartesianArea1.ShowGrid = True
        Me.progress_chartview.AreaDesign = CartesianArea1
        Me.progress_chartview.Controls.Add(Me.lbllp_title)
        Me.progress_chartview.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progress_chartview.LegendTitle = "LEGEND"
        Me.progress_chartview.Location = New System.Drawing.Point(515, 69)
        Me.progress_chartview.Name = "progress_chartview"
        Me.progress_chartview.ShowLegend = True
        Me.progress_chartview.Size = New System.Drawing.Size(750, 405)
        Me.progress_chartview.TabIndex = 0
        Me.progress_chartview.Text = "RadChartView1"
        '
        'lbllp_title
        '
        Me.lbllp_title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbllp_title.AutoSize = True
        Me.lbllp_title.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllp_title.Location = New System.Drawing.Point(524, 11)
        Me.lbllp_title.Name = "lbllp_title"
        Me.lbllp_title.Size = New System.Drawing.Size(220, 20)
        Me.lbllp_title.TabIndex = 7
        Me.lbllp_title.Text = "LOANS && COLLECTIONS STATUS"
        '
        'txtcoll
        '
        Me.txtcoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'txtcoll.NestedRadGridView
        '
        Me.txtcoll.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtcoll.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcoll.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcoll.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.txtcoll.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.txtcoll.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.txtcoll.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.txtcoll.EditorControl.MasterTemplate.EnableGrouping = False
        Me.txtcoll.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.txtcoll.EditorControl.Name = "NestedRadGridView"
        Me.txtcoll.EditorControl.ReadOnly = True
        Me.txtcoll.EditorControl.ShowGroupPanel = False
        Me.txtcoll.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.txtcoll.EditorControl.TabIndex = 0
        Me.txtcoll.Location = New System.Drawing.Point(937, 12)
        Me.txtcoll.Name = "txtcoll"
        Me.txtcoll.Size = New System.Drawing.Size(223, 23)
        Me.txtcoll.TabIndex = 1
        Me.txtcoll.TabStop = False
        '
        'bttngenerate
        '
        Me.bttngenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttngenerate.Location = New System.Drawing.Point(1166, 12)
        Me.bttngenerate.Name = "bttngenerate"
        Me.bttngenerate.Size = New System.Drawing.Size(86, 23)
        Me.bttngenerate.TabIndex = 2
        Me.bttngenerate.Text = "Generate"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(844, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Collecting Officer"
        '
        'dtasof
        '
        Me.dtasof.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtasof.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtasof.Location = New System.Drawing.Point(452, 15)
        Me.dtasof.Name = "dtasof"
        Me.dtasof.Size = New System.Drawing.Size(151, 20)
        Me.dtasof.TabIndex = 4
        Me.dtasof.Value = New Date(2015, 4, 12, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(409, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "As of"
        '
        'memberschartview
        '
        Me.memberschartview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CartesianArea2.ShowGrid = True
        Me.memberschartview.AreaDesign = CartesianArea2
        Me.memberschartview.Controls.Add(Me.lblmembers_title)
        Me.memberschartview.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberschartview.LegendTitle = "LEGEND"
        Me.memberschartview.Location = New System.Drawing.Point(3, 69)
        Me.memberschartview.Name = "memberschartview"
        Me.memberschartview.ShowLegend = True
        Me.memberschartview.Size = New System.Drawing.Size(471, 321)
        Me.memberschartview.TabIndex = 6
        Me.memberschartview.Text = "RadChartView1"
        '
        'lblmembers_title
        '
        Me.lblmembers_title.AutoSize = True
        Me.lblmembers_title.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmembers_title.Location = New System.Drawing.Point(0, 11)
        Me.lblmembers_title.Name = "lblmembers_title"
        Me.lblmembers_title.Size = New System.Drawing.Size(132, 20)
        Me.lblmembers_title.TabIndex = 8
        Me.lblmembers_title.Text = "MEMBERS STATUS"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblheader)
        Me.Panel1.Controls.Add(Me.memberschartview)
        Me.Panel1.Controls.Add(Me.progress_chartview)
        Me.Panel1.Location = New System.Drawing.Point(3, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 474)
        Me.Panel1.TabIndex = 7
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(507, 3)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(198, 30)
        Me.lblheader.TabIndex = 9
        Me.lblheader.Text = "PROGRESS REPORT"
        Me.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdaymode
        '
        Me.txtdaymode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        RadListDataItem1.Text = "Weekly"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Monthly"
        RadListDataItem2.TextWrap = True
        Me.txtdaymode.Items.Add(RadListDataItem1)
        Me.txtdaymode.Items.Add(RadListDataItem2)
        Me.txtdaymode.Location = New System.Drawing.Point(649, 15)
        Me.txtdaymode.Name = "txtdaymode"
        Me.txtdaymode.Size = New System.Drawing.Size(175, 20)
        Me.txtdaymode.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(609, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mode"
        '
        'PrintDocument1
        '
        '
        'RadButton1
        '
        Me.RadButton1.Enabled = False
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.Location = New System.Drawing.Point(3, 28)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(51, 29)
        Me.RadButton1.TabIndex = 12
        Me.RadButton1.Text = "&Print"
        Me.RadButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_progres_bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1264, 539)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdaymode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtasof)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttngenerate)
        Me.Controls.Add(Me.txtcoll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_progres_bar"
        Me.ShowIcon = False
        Me.Text = "Progress Report"
        CType(Me.progress_chartview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.progress_chartview.ResumeLayout(False)
        Me.progress_chartview.PerformLayout()
        CType(Me.txtcoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttngenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memberschartview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.memberschartview.ResumeLayout(False)
        Me.memberschartview.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtdaymode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents progress_chartview As Telerik.WinControls.UI.RadChartView
    Friend WithEvents txtcoll As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bttngenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtasof As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents memberschartview As Telerik.WinControls.UI.RadChartView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbllp_title As System.Windows.Forms.Label
    Friend WithEvents lblmembers_title As System.Windows.Forms.Label
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents txtdaymode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
