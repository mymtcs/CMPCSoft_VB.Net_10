Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_sss_remittance
    Dim postno As Integer = 0
    Dim runbal As Integer = 0

    Private Sub frm_sss_remittance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpdate.Value = systemdate
        dtasof.Text = systemdate
        'txtrmrks.Text = "Transfer from old account."
    End Sub


    Private Sub txtref_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtrmrks.Focus()
        End If
    End Sub

    Private Sub gen_sssremittance()
        dtgrdsss.Rows.Clear()
        conn()
        sql = "select  ROW_NUMBER() OVER (order by x.fullname ASC) as rownum, x.* from(select a.memcode,a.sssno,a.fullname,a.address,"
        sql += "sssbal=isnull((select sum(debit-credit) from sssledger where memcode=a.memcode and PostingDate<='" + dtasof.Value + "'),0)"
        sql += "from members a)x where x.sssbal>=330"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            dtgrdsss.Rows.Add(rd("rownum"), txtref.Text, "S", dtasof.Value, rd("fullname"), rd("sssno"), dtasof.Value.ToString("MMMM, yyyy"), rd("sssbal"), False, rd("memcode"))
        End While
        rd.Close()
        myConn.Close()

        txtamnt.Text = 0
        For i As Integer = 0 To dtgrdsss.Rows.Count - 1
            If dtgrdsss.Rows(i).Cells(8).Value = True Then
                txtamnt.Text = Double.Parse(txtamnt.Text) + Double.Parse(dtgrdsss.Rows(i).Cells(7).Value)
            End If
        Next
    End Sub

    Private Sub txtpmode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtamnt.Focus()
        End If
    End Sub



    Private Sub bttn_saveclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gen_sssremittance()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtrmrks.Text.Trim = "" Then
            MsgBox("Please input remarks", MsgBoxStyle.Exclamation, "Message")
        Else
            If MessageBox.Show("Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To dtgrdsss.Rows.Count - 1
                    If dtgrdsss.Rows(i).Cells(8).Value = True Then
                        conn()
                        sql = "SELECT MAX(postno) As postno FROM SSSledger WHERE memcode='" + dtgrdsss.Rows(i).Cells(9).Value + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        rd = cmd.ExecuteReader
                        If rd.Read Then
                            Try
                                postno = Double.Parse(rd("postno")) + 1
                            Catch ex As Exception
                                postno = 1
                            End Try
                        End If
                        myConn.Close()

                        conn()
                        sql = "INSERT INTO SSSLedger(Memcode,PostingDate,Postno,Postmode,Debit,Credit,Remarks,Reference,userid,tdate,Active) VALUES "
                        sql += "('" + dtgrdsss.Rows(i).Cells(9).Value + "'"
                        sql += ",'" + txtpdate.Value + "'"
                        sql += "," + postno.ToString + ""
                        sql += ",'Co'"
                        sql += ",0," + Double.Parse(dtgrdsss.Rows(i).Cells(7).Value).ToString + ""
                        sql += ",'" + txtrmrks.Text + "'"
                        sql += ",'" + txtref.Text + "'"
                        sql += ",'" + user.ToString + "'"
                        sql += ",'" + systemdate + "'"
                        sql += ",'Y'"
                        sql += ")"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                Next

                txtrmrks.Text = ""
                MsgBox("Posting Complete!", MsgBoxStyle.Information, "Message")
                frm_sss_masterFile.display_ledger()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For i As Integer = 0 To dtgrdsss.Rows.Count - 1
            dtgrdsss.Rows(i).Cells(8).Value = True
        Next
        txtamnt.Text = 0
        For i As Integer = 0 To dtgrdsss.Rows.Count - 1
            If dtgrdsss.Rows(i).Cells(8).Value = True Then
                txtamnt.Text = Double.Parse(txtamnt.Text) + Double.Parse(dtgrdsss.Rows(i).Cells(7).Value)
            End If
        Next
    End Sub

    Private Sub dtgrdsss_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrdsss.CellClick
        If e.ColumnIndex = 8 Then
            If dtgrdsss.CurrentRow.Cells(8).Value = True Then
                dtgrdsss.CurrentRow.Cells(8).Value = False
            Else
                dtgrdsss.CurrentRow.Cells(8).Value = True
            End If
            txtamnt.Text = 0
            For i As Integer = 0 To dtgrdsss.Rows.Count - 1
                If dtgrdsss.Rows(i).Cells(8).Value = True Then
                    txtamnt.Text = Double.Parse(txtamnt.Text) + Double.Parse(dtgrdsss.Rows(i).Cells(7).Value)
                End If
            Next
        End If
    End Sub
End Class