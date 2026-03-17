<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_importdata
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
        Me.bttnok = New Telerik.WinControls.UI.RadButton
        Me.dtgrd_data = New System.Windows.Forms.DataGridView
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton
        CType(Me.bttnok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgrd_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnok
        '
        Me.bttnok.Location = New System.Drawing.Point(1041, 29)
        Me.bttnok.Name = "bttnok"
        Me.bttnok.Size = New System.Drawing.Size(143, 35)
        Me.bttnok.TabIndex = 0
        Me.bttnok.Text = "Import Data"
        '
        'dtgrd_data
        '
        Me.dtgrd_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrd_data.Location = New System.Drawing.Point(12, 70)
        Me.dtgrd_data.Name = "dtgrd_data"
        Me.dtgrd_data.Size = New System.Drawing.Size(1172, 396)
        Me.dtgrd_data.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Members", "Center", "Saving Masterlist", "Savings Ledger", "Loans", "Loan Schedule", "Loan Collect", "Loan Officer", "Province", "Municipal/City", "Barangay", "Sitio", "User"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(862, 26)
        Me.ComboBox1.TabIndex = 2
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(880, 29)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(143, 35)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "View Data"
        '
        'frm_importdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 497)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dtgrd_data)
        Me.Controls.Add(Me.bttnok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_importdata"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bttnok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgrd_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnok As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtgrd_data As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
