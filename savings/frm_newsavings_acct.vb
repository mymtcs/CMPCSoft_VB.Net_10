Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_newsavings_acct
    Dim sanum As Integer
    Dim accountnumber As String

    Private Sub frm_newsavings_acct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_members()
        gen_saType()
    End Sub

    Private Sub gen_saType()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT accountcode,acct_description FROM chartaccounts where acct_description like 'savings deposit%'  ORDER BY acct_description ASC" '
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
        Dim dtTest As DataTable = New DataTable()
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
        conn()
        sql = "SELECT accountstatus FROM Accountmaster WHERE memcode='" + txtmember.SelectedValue + "' and gl_sa='" & txtsavingstype.SelectedValue & "' and accountstatus='Active'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            If MessageBox.Show("This member has already active savings account. Would you like to add another savings account on this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                GoTo 1
            End If
        Else
            rd.Close()
1:          gen_sacct()
            conn()
            sql = "SELECT accountnumber FROM Accountmaster WHERE accountnumber='" + txtsaacct.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            If rd.Read Then
                update_saving()
                GoTo 1
            Else
                insert_sa()
                update_saving()
            End If
            rd.Close()
            myConn.Close()
            MsgBox("New savings account was successfully added.", MsgBoxStyle.Information, "Information")
            frm_savings.txtsearch.Text = txtmember.Text
            'frm_savings.display_sa()
            Me.Close()
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub insert_sa()
        conn()
        sql = "INSERT INTO AccountMaster(Accountnumber,Dateopen,AccountType,userid,tdate,MemCode,AccountStatus,branchcode,GL_sa) values "
        sql += "('" + accountnumber.ToString + "',"
        sql += "'" + systemdate + "',"
        sql += "'" + txtacct_type.Text + "',"
        sql += "'" + user.ToString + "',"
        sql += "'" + systemdate + "',"
        sql += "'" + txtmemcode.Text + "',"
        sql += "'Active',"
        sql += "'" + branchcode.ToString + "',"
        sql += "'" + txtsavingstype.SelectedValue + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub gen_sacct()
1:      conn()
        sql = "SELECT * FROM SA_AcctnoSeries WHERE CYear='" + DateTime.Now.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            sanum = rd("LastLAcctno") + 1
            accountnumber = branchcode & "-" & rd("CYear").ToString.Substring(2, 2) & code_series & sanum.ToString("000000") & "-" & txtacct_type.Text
            txtsaacct.Text = accountnumber
        Else
            conn()
            sql = "INSERT INTO SA_AcctnoSeries(LastLAcctno,CYear)Values('000000','" + DateTime.Now.Year.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            GoTo 1
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub update_saving()
        conn()
        sql = "UPDATE SA_AcctnoSeries SET LastLAcctno='" + sanum.ToString("000000") + "' WHERE CYear='" + DateTime.Now.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
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