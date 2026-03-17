Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_sss_masterFile

   
    Private Sub bttnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frm_sss_masterFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_sssmaster()
    End Sub

    Public Sub view_sssmaster()
        lstsssmaster.Items.Clear()
        conn()
        sql = "SELECT top 200 a.SSSNo,CONVERT(varchar, a.birthdate, 105),a.fullname,a.memcode,bal=isnull((select sum(debit-credit) from sssledger where memcode=a.memcode),0) FROM members a WHERE a.fullname LIKE '%" + txtsearch.Text + "%' ORDER BY a.fullname"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstsssmaster.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        frm_post_ssspayment.Text = lstsssmaster.FocusedItem.SubItems(3).Text
        frm_post_ssspayment.ShowDialog()
    End Sub

    Private Sub bttnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnedit.Click
        member_code = lstsssmaster.FocusedItem.SubItems(3).Text
        frm_edit_sssinfo.Text = "Edit"
        frm_edit_sssinfo.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        view_sssmaster()
    End Sub

    Public Sub display_ledger()
        conn()
        lstsssledger.Items.Clear()
        sql = "select x.* from(SELECT CONVERT(VARCHAR(11),a.postingdate,101) As postingdate,postno,a.postmode,a.debit,a.credit,"
        sql += "isnull((select SUM(debit)-SUM(credit) from SSSLedger where postno<=a.postno and Memcode=a.Memcode and active='Y'),0)As runbal,a.reference,a.remarks,a.userid,a.Active,a.id FROM SSSLedger a WHERE a.memcode='" + lstsssmaster.FocusedItem.SubItems(3).Text + "'"
        sql += ")x GROUP BY x.postingdate,x.postmode,x.debit,x.credit,x.reference,x.remarks,x.userid,x.runbal,x.postno,x.Active,x.id ORDER BY x.postno"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstsssledger.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstsssledger.Items.Count - 1

            If i Mod 2 Then
                lstsssledger.Items(i).BackColor = Color.AliceBlue
            Else
                lstsssledger.Items(i).BackColor = Color.White
            End If

            If lstsssledger.Items(i).SubItems(9).Text <> "Y" Then
                lstsssledger.Items(i).ForeColor = Color.Gray
                If lstsssledger.Items(i).SubItems(9).Text = "X" Then
                    lstsssledger.Items(i).Font = myFont
                End If
            End If
        Next
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            view_sssmaster()
        End If
    End Sub

    Private Sub cboletter_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtsearch.Focus()
    End Sub

    Private Sub lstsssmaster_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstsssmaster.Click
        display_ledger()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frm_withdraw_ssspayment.Text = lstsssmaster.FocusedItem.SubItems(3).Text
        frm_withdraw_ssspayment.ShowDialog()
    End Sub

    Private Sub SSSRemitanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSSRemitanceToolStripMenuItem.Click
        frm_sss_remittance.ShowDialog()
    End Sub
End Class