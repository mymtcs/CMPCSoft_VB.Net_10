Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class frm_edit_sssinfo

    Private Sub frm_edit_sssinfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        gen_members()
    End Sub

    Private Sub frm_edit_sssinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm_sss_masterFile.view_sssmaster()
    End Sub

    Private Sub txtmembers_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles txtmember.DrawItem
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

    Private Sub gen_members()
        Dim dtTest As DataTable = New DataTable()
        dtTest.Columns.Add("Member Code", GetType(String))
        dtTest.Columns.Add("Fullname", GetType(String))

        conn()
        If Me.Text = "Edit" Then
            sql = "select * from members where memcode='" + member_code + "'"
        Else
            sql = "select * from members order by fullname"
        End If
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

    Private Sub txtmember_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmember.Validated
        conn()
        sql = "select * from members where memcode='" + txtmember.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtbdate.Text = rd("birthdate")
            Try
                txtsss.Text = rd("sssno")
            Catch ex As Exception

            End Try
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnclose.Click
        Me.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        conn()
        sql = "UPDATE members SET sssno='" + txtsss.Text + "' where memcode='" + txtmember.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub
End Class