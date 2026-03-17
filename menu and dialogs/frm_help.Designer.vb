<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_help
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Click backup database on the upper side of the system then click ""yes"" button. No" & _
                "te you cannot back-up database if you are not in the server unit.")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to backup database?", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Click change password on the upper side of the system then enter your current pas" & _
                "sword and your new password.")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to change my password?", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add : Click ""Officer"" button on the master file tab. Enter new code (it must be s" & _
                "eries), then input complete name, address, mobile number and select loan product" & _
                " of the officer.")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit : Click the officer you want to edit then input text and save. ")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Note : You cannot edit officer if the officer have already active or paid-up memb" & _
                "ers.")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to add new officer or collector?", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Click ""Center"" button on master file tab click new, select member you want to mak" & _
                "e as center chief, inpute address and collection day number, then select loan pr" & _
                "oduct of the center and click save.")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Note : Collection day no. is a day of collection of the center and the first paym" & _
                "ent of the member on set-up new loan.")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to add new center?", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_help))
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(resources.GetString("TreeView1.Nodes"))
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Note : Priority on selecting members to merge option 1 : select the member with a" & _
                " greater cbu balance, option 2 : select member to merge with exact birthdate.")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Important : Confirm the officer or collector first before merging members if this" & _
                " member is the same.")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to merge members?", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search the name on members form, click loan product you want to cancel, select lo" & _
                "an number then right click then click ""Cancel Release"" add some reason why you w" & _
                "ant to cancel then click ""Submit""")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Note : you cannot cancel loans if the payment collection was already made.")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to cancel released loans?", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Select only loan officer with the same name and click the check box on the left s" & _
                "ide then click merge button on the upper side.")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to merge loan officers?", New System.Windows.Forms.TreeNode() {TreeNode19})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.Blue
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode1.Name = "Node6"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Text = "Click backup database on the upper side of the system then click ""yes"" button. No" & _
            "te you cannot back-up database if you are not in the server unit."
        TreeNode2.Name = "node1"
        TreeNode2.Text = "How to backup database?"
        TreeNode3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode3.Name = "Node7"
        TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode3.Text = "Click change password on the upper side of the system then enter your current pas" & _
            "sword and your new password."
        TreeNode4.Name = "Node1"
        TreeNode4.Tag = "Sample 1"
        TreeNode4.Text = "How to change my password?"
        TreeNode5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode5.Name = "Node8"
        TreeNode5.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode5.Text = "Add : Click ""Officer"" button on the master file tab. Enter new code (it must be s" & _
            "eries), then input complete name, address, mobile number and select loan product" & _
            " of the officer."
        TreeNode6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode6.Name = "Node13"
        TreeNode6.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode6.Text = "Edit : Click the officer you want to edit then input text and save. "
        TreeNode7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode7.Name = "Node14"
        TreeNode7.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode7.Text = "Note : You cannot edit officer if the officer have already active or paid-up memb" & _
            "ers."
        TreeNode8.Name = "Node2"
        TreeNode8.Text = "How to add new officer or collector?"
        TreeNode9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode9.Name = "Node9"
        TreeNode9.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode9.Text = "Click ""Center"" button on master file tab click new, select member you want to mak" & _
            "e as center chief, inpute address and collection day number, then select loan pr" & _
            "oduct of the center and click save."
        TreeNode10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode10.Name = "Node17"
        TreeNode10.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode10.Text = "Note : Collection day no. is a day of collection of the center and the first paym" & _
            "ent of the member on set-up new loan."
        TreeNode11.Name = "Node3"
        TreeNode11.Text = "How to add new center?"
        TreeNode12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode12.Name = "Node10"
        TreeNode12.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode12.Text = resources.GetString("TreeNode12.Text")
        TreeNode13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode13.Name = "Node16"
        TreeNode13.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode13.Text = "Note : Priority on selecting members to merge option 1 : select the member with a" & _
            " greater cbu balance, option 2 : select member to merge with exact birthdate."
        TreeNode14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode14.Name = "Node19"
        TreeNode14.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode14.Text = "Important : Confirm the officer or collector first before merging members if this" & _
            " member is the same."
        TreeNode15.Name = "Node4"
        TreeNode15.Text = "How to merge members?"
        TreeNode16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode16.Name = "Node11"
        TreeNode16.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode16.Text = "Search the name on members form, click loan product you want to cancel, select lo" & _
            "an number then right click then click ""Cancel Release"" add some reason why you w" & _
            "ant to cancel then click ""Submit"""
        TreeNode17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode17.Name = "Node20"
        TreeNode17.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode17.Text = "Note : you cannot cancel loans if the payment collection was already made."
        TreeNode18.Name = "Node5"
        TreeNode18.Text = "How to cancel released loans?"
        TreeNode19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TreeNode19.Name = "Node1"
        TreeNode19.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode19.Text = "Select only loan officer with the same name and click the check box on the left s" & _
            "ide then click merge button on the upper side."
        TreeNode20.Name = "Node0"
        TreeNode20.Text = "How to merge loan officers?"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode8, TreeNode11, TreeNode15, TreeNode18, TreeNode20})
        Me.TreeView1.Size = New System.Drawing.Size(700, 521)
        Me.TreeView1.TabIndex = 0
        '
        'frm_help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 521)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frm_help"
        Me.Text = "Help"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
