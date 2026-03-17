Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_edit_savings_acct
    Dim sanum As Integer
    Dim accountnumber As String

    Private Sub frm_edit_savings_acct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' DISPLAY 
        ' MessageBox.Show("i am here at edit account")

        gen_members() ' ADD COLUMN MEMCODE AND FULLNAME
        gen_saType()


        txtsaacct.Text = frm_savings.dtgridsaving.CurrentRow.Cells(0).Value

        ' DISPLAY ACCOUNT NUMBER
        ' MessageBox.Show(txtsaacct.Text)

        conn()
        'sql = "SELECT * FROM accountmaster a, members b where a.memcode=b.memcode and a.accountnumber='" & txtsaacct.Text & "'"

        'modified: 9-27-2023, kay dili niya ma display ang tinoud na account type, karun ok na
        sql = "SELECT * FROM accountmaster a where a.accountnumber ='" & txtsaacct.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtmember.SelectedValue = rd("memcode")
            txtmemcode.Text = rd("memcode")


            txtacct_type.Text = rd("accounttype")

            txtsavingstype.SelectedValue = rd("GL_sa")
        End If
        'MsgBox(txtacct_type.Text)

        rd.Close()
        myConn.Close()
        view_peraccount()
    End Sub

    Private Sub view_peraccount()
        conn()
        sql = "select a.gl_sa,runbal=isnull((select sum(debit-credit) from accountledger where accountnumber=a.accountnumber and gl_sa=a.gl_sa and active='Y'),0) from accountledger a where a.accountnumber='" & txtsaacct.Text & "' group by a.gl_sa,a.accountnumber"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        dtgrd_acct.Rows.Clear()
        While rd.Read
            dtgrd_acct.Rows.Add(rd("gl_sa"), rd("runbal"))
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub gen_saType()
        ' DISPLAY SA TYPE
        ' MessageBox.Show("Gen saType")

        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM chartaccounts where Accttype='savings'  ORDER BY acct_description ASC" '
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsavingstype.DataSource = table1
        Me.txtsavingstype.AutoFilter = True
        txtsavingstype.DisplayMember = "Description"
        txtsavingstype.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsavingstype.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsavingstype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsavingstype.EditorControl.Columns(0).Width = 100
        Me.txtsavingstype.EditorControl.Columns(1).Width = 200
        Me.txtsavingstype.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub gen_members()
        ' DISPLAY GENERATE MEMBERS
        ' MessageBox.Show("Generate Members")

        Dim dtTest As DataTable = New DataTable()

        ' ADD COLUMN MEMBER CODE AND FULLNAME'
        dtTest.Columns.Add("Member Code", GetType(String))
        dtTest.Columns.Add("Fullname", GetType(String))

        conn()
        sql = "select * from members where status='A' order by fullname"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtTest.Rows.Add(rd("memcode"), rd("fullname"))
        End While
        rd.Close()
        myConn.Close()

        ' Bind the ComboBox to the DataTable
        Me.txtmember.DataSource = dtTest
        Me.txtmember.DisplayMember = "Fullname"
        Me.txtmember.ValueMember = "Member Code"

        ' Enable the owner draw on the ComboBox.
        Me.txtmember.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items.
    End Sub

    Private Sub txtmember_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles txtmember.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(txtmember.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("Member Code").ToString()
        Dim name As String = drv("Fullname").ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 2

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        insert_sa()
    End Sub

    Private Sub insert_sa()
        If MessageBox.Show("Updating this account may cause disbalances to savings masterlist. Please check savings balance per product after updating this account.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            conn()

            ' DISPLAY SAVINGS TYPE
            ' MessageBox.Show(txtsavingstype.SelectedValue)

            sql = "UPDATE AccountMaster SET AccountType='" + txtacct_type.Text + "',userid='" + user.ToString + "',tdate='" + systemdate + "',GL_sa='" + txtsavingstype.SelectedValue + "' WHERE Accountnumber='" & txtsaacct.Text & "' "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "UPDATE accountledger SET GL_sa='" + txtsavingstype.SelectedValue + "' WHERE Accountnumber='" & txtsaacct.Text & "' "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MsgBox("Savings Account was successfully updated.", MsgBoxStyle.Information, "Information")
            view_peraccount()
        End If
    End Sub


    Private Sub txtmember_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmember.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    Private Sub txtmember_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmember.Validated
        txtmemcode.Text = txtmember.SelectedValue
    End Sub
End Class