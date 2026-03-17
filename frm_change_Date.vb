Imports System.IO
'Imports System.Data.Sql
'Imports System.Data.SqlClient
Imports System.Data


Public Class frm_change_Date

    Private Sub bttnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsubmit.Click
        If txtpass.Text = adminpass Then
            'conn()
            'Dim reasons As String = "Accessed System Date Admin password"
            'sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','" + reasons + "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()
            admin_access()
        Else
            MessageBox.Show("Invalid password!")
            'Try
            '    mysqlconn()
            '    sql = "select * from access_temp where accesspass='" + txtpass.Text + "' and userid='" + user + "' and status='A'"
            '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            '    mysqlmyconn.Open()
            '    mysqlrd = mysqlcmd.ExecuteReader
            '    If mysqlrd.Read Then
            '        If txtpass.Text = mysqlrd("accesspass") Then
            '            systemdate = dtchange.Value
            '            MDIfrm.lblsysdate.Text = systemdate
            '            loginfrm.check = dtchange.Value
            '            txtpass.Clear()

            '            mysqlconn()
            '            sql = "update access_temp set status='X' where userid='" + user + "'"
            '            mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
            '            mysqlmyconn.Open()
            '            mysqlcmd.ExecuteNonQuery()
            '            mysqlmyconn.Close()
            '            Me.Hide()
            '        Else
            '            MsgBox("Invalid user access.", MsgBoxStyle.Exclamation, "Message")
            '        End If
            '    End If
            '    mysqlrd.Close()
            '    mysqlmyconn.Close()
            'Catch ex As Exception
            '    admin_access()
            'End Try
        End If

    End Sub

    Private Sub admin_access()
        systemdate = dtchange.Value
        MDIfrm.lblsysdate.Text = systemdate
        'loginfrm.check = dtchange.Value
        MessageBox.Show("System backdated to '" & systemdate & "'", "System Backdated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtpass.Clear()
        Me.Hide()
    End Sub

    Private Sub frm_change_Date_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = e.CloseReason
        If UnloadMode = CloseReason.UserClosing Then
            'Prevent it closing
            Cancel = True
        End If
        'Allow it to close if it wasn't the user's action
        e.Cancel = Cancel
    End Sub

    Private Sub frm_change_Date_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtchange.Value = DateTime.Today
        txtpass.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class