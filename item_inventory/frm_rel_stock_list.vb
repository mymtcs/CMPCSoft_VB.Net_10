Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization

Public Class frm_rel_stock_list

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        frm_releasestocks.ShowDialog()
    End Sub

    Private Sub frm_rel_stock_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtgen.Value = systemdate
        view_rel_stocks()
    End Sub

    Public Sub view_rel_stocks()
        Try
            conn()
            dtgrid_products.Rows.Clear()
            sql = "SELECT a.ID,a.Code,ttlqty=sum(a.qty),a.remarks,a.trndate FROM LoanItems a,itemsMF b, iteminventory c WHERE a.reference=c.reference and a.Itemcode=b.Itemcode and a.pnnumber='Direct Release' and a.remarks LIKE '%" & txtsearch.Text & "%' and a.trndate='" & dtgen.Value & "' group by a.qty,a.ID,a.Code,a.remarks,a.trndate "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While rd.Read
                dtgrid_products.Rows.Add(rd("ID").ToString, rd("Code").ToString, rd("ttlqty").ToString, rd("remarks").ToString, "X")
            End While
            rd.Close()
            myConn.Close()
            lblref_cb_rec.Text = dtgrid_products.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        'If e.KeyCode = Keys.Enter Then
        view_rel_stocks()
        ' If
    End Sub

    Private Sub dtgen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgen.Validated
        view_rel_stocks()
    End Sub

    Private Sub bttnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtgrid_products_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_products.CellClick
        If e.ColumnIndex = 4 Then
            If MessageBox.Show("Are you sure you want to delete this item released?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If dtgen.Value <> systemdate Then
                    pnadmin.Visible = True
                Else
                    delete_rel()
                End If
            End If
        End If
    End Sub

    Private Sub delete_rel()
        conn()
        sql = "DELETE FROM LoanItems WHERE ID='" + dtgrid_products.CurrentRow.Cells(0).Value.ToString + "' and trndate='" + dtgen.Value + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        conn()
        sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Deleted released stocks " & dtgrid_products.CurrentRow.Cells(0).Value & " qty of (" & dtgrid_products.CurrentRow.Cells(2).Value & ")','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        pnadmin.Visible = False
        lblalert.Visible = False
        view_rel_stocks()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        If txtpassword.Text.Trim = userpass Then
            delete_rel()
            'Else
            '    mysqlconn()
            '    sql = "select * from access_temp where accesspass='" + txtpassword.Text + "' and userid='" + user + "' and status='A'"
            '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            '    mysqlmyconn.Open()
            '    mysqlrd = mysqlcmd.ExecuteReader
            '    If mysqlrd.Read Then
            '        If txtpassword.Text = mysqlrd("accesspass") Then
            '            delete_rel()
            '            Try
            '                update_accesstemp()
            '            Catch ex As Exception

            '            End Try
            '        End If
            '    End If
            '    lblalert.Visible = True
        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        pnadmin.Visible = False
    End Sub
End Class