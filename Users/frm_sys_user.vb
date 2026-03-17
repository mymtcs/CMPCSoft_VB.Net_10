Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_sys_user

    Private Sub frm_changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_user()
    End Sub

    Private Sub display_user()
        conn()
        lstdropdown.Items.Clear()
        sql = "SELECT fullname,userid,Type,wrkstnID from users order by fullname"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstdropdown.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lstdropdown.Items.Count - 1
            If i Mod 2 Then
                lstdropdown.Items(i).BackColor = Color.AliceBlue
            Else
                lstdropdown.Items(i).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub lstdropdown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstdropdown.Click
        txtname.Text = lstdropdown.FocusedItem.SubItems(0).Text
        txtid.Text = lstdropdown.FocusedItem.SubItems(1).Text
        txtusertype.Text = lstdropdown.FocusedItem.SubItems(2).Text
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If grp_replace.Visible = False Then
            If txtname.Text.Trim = "" Then
                MsgBox("Complete name cannot be emtpy.", MsgBoxStyle.Exclamation)
                txtname.Focus()
            ElseIf txtusertype.Text.Trim = "" Then
                MsgBox("User Type cannot be emtpy.", MsgBoxStyle.Exclamation)
                txtusertype.Focus()
            Else
                conn()
                sql = "SELECT * FROM users where userid='" + txtid.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    If MessageBox.Show("UserID already exists in database. Do you wish to update?", "User Already Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        conn()
                        sql = "UPDATE users SET type=@type, wrkstnID=@workstation WHERE userid = '" & txtid.Text & "'"
                        cmd = New SqlCommand(sql, myConn)
                        cmd.Parameters.AddWithValue("@type", txtusertype.Text)
                        cmd.Parameters.AddWithValue("@workstation", "n/a")
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                        MsgBox("You have successfully updated the user!", MsgBoxStyle.Information, "Success")

                        conn()
                        Dim reasons As String = "User " & txtid.Text & " has been updated."
                        sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                        Clear()
                    Else

                    End If
                Else
                    conn()
                    sql = "INSERT INTO users(fullname,userid,pwd,Type,pwddateexpiration,AlreadyExpired,wrkstnID) VALUES('" + txtname.Text + "','" + txtid.Text + "','" + txtid.Text + "','" + txtusertype.Text + "','" + systemdate.AddYears(2) + "','N','n/a')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    MsgBox("You have successfully added a new user.", MsgBoxStyle.Information, "Success")

                    conn()
                    Dim reasons As String = "New user " & txtid.Text & " has been added."
                    sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                    Clear()
                End If
                rd.Close()
                myConn.Close()
            End If
        Else
            Replace()
        End If
        grp_replace.Visible = False
        display_user()
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        txtid.Clear()
        txtname.Clear()
    End Sub

    Private Sub btn_replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_replace.Click
        If txtname.Text = "" And txtusertype.Text = "" And txtid.Text = "" Then
            MessageBox.Show("Please select a user to replace.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            rp_txtusertype.Text = txtusertype.Text
            grp_replace.Visible = True
        End If
    End Sub

    Private Sub Replace()
        If txtname.Text.Trim = "" Then
            MsgBox("Complete name cannot be emtpy.", MsgBoxStyle.Exclamation)
            txtname.Focus()
        ElseIf txtusertype.Text.Trim = "" Then
            MsgBox("User Type cannot be emtpy.", MsgBoxStyle.Exclamation)
            txtusertype.Focus()
        Else
            conn()
            sql = "SELECT * FROM users where userid='" + rp_txtid.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                MessageBox.Show("Such user already exists!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                conn()
                sql = "UPDATE users SET userid=@user, fullname=@name, pwd=@pwd, pwddateexpiration=@expire, wrkstnID=@station WHERE userid = '" & txtid.Text & "'"
                cmd = New SqlCommand(sql, myConn)
                cmd.Parameters.AddWithValue("@user", rp_txtid.Text)
                cmd.Parameters.AddWithValue("@name", rp_txtname.Text)
                cmd.Parameters.AddWithValue("@pwd", rp_txtid.Text)
                cmd.Parameters.AddWithValue("@expire", systemdate.AddYears(1))
                cmd.Parameters.AddWithValue("@station", "n/a")
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                conn()
                sql = "UPDATE UserAssigned SET userID=@user WHERE userID = '" & txtid.Text & "'"
                cmd = New SqlCommand(sql, myConn)
                cmd.Parameters.AddWithValue("@user", rp_txtid.Text)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("You have successfully replaced the user!", MsgBoxStyle.Information, "Success")

                conn()
                Dim reasons As String = "Replace user " & txtid.Text & " with " & rp_txtid.Text & ""
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                Clear()
            End If
            rd.Close()
            myConn.Close()
        End If
        display_user()
    End Sub

    Private Sub Clear()
        txtid.Text = ""
        txtname.Text = ""
        txtusertype.Text = ""
        rp_txtid.Text = ""
        rp_txtname.Text = ""
        rp_txtusertype.Text = ""
    End Sub

    Private Sub btn_expired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_expired.Click
        If MessageBox.Show("This will delete expired users on the database. Are you sure?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            conn()
            sql = "DELETE FROM users WHERE pwddateexpiration < '" & systemdate & "' AND userid <> 'renz'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            MessageBox.Show("Successfully deleted expired user credentials!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            conn()
            Dim reasons As String = "Deleted expired accounts"
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" & usertype & "','" & reasons & "','" & systemdate & "','" & user.ToString & "','" & time.ToString & "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Else

        End If
        display_user()
    End Sub
End Class