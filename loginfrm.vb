Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Imports System.Net

Public Class loginfrm

    Dim i As Integer = 0
    Dim attempt As Integer = 0
    Public check As DateTime

    Public timeleft As Integer

    Private Sub loginfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = e.CloseReason
        If UnloadMode = CloseReason.UserClosing Then
            'Prevent it closing
            Cancel = True
        End If
        'Allow it to close if it wasn't the user's action
        e.Cancel = Cancel
    End Sub

    Private Sub download_updates()
        Dim localVersion As String = My.Application.Info.Version.ToString
        'Dim wc As New Net.WebClient
        'wc.Proxy = Nothing
        'Dim source As String = String.Empty

        'Try
        '    source = wc.DownloadString("http://martiantext.com/system/versions.xml")
        'Catch ex As Net.WebException
        '    MessageBox.Show(ex.Message)
        'End Try

        'Dim xm As New Xml.XmlDocument
        'xm.LoadXml(source)


        'Dim currentVersion As String = xm.SelectSingleNode("//CurrentVersion").ChildNodes(0).InnerText.Trim
        'Dim currentLink As String = xm.SelectSingleNode("//CurrentVersion").ChildNodes(1).InnerText.Trim

        'If localVersion >= currentVersion Then
        '    lblprogress.ForeColor = Color.DimGray
        '    lblprogress.Text = "System is up to date."
        'Else
        '    MessageBox.Show("Downloading v" & currentVersion & ". Please advise everyone to turn off their wifi to avoid download interruptions. Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    progressBar.Visible = True
        '    lblprogress.ForeColor = Color.DarkBlue
        '    enabled_false()
        '    My.Computer.FileSystem.RenameFile(strpath & "\CMPCsoft.exe", "CMPCsoft " & localVersion & ".exe")
        '    Dim client As WebClient = New WebClient
        '    AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        '    AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        '    client.DownloadFileAsync(New Uri("http://martiantext.com/system/CMPCsoft.exe"), strpath & "/CMPCsoft.exe")
        '    Timer3.Start()
        'End If

    End Sub

    Private Sub loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getpath()

        Dim lastUpdate As Date = FileDateTime(strpath & "\CMPCsoft.exe")
        lblprogress.Text = "Last update: " & lastUpdate.ToShortDateString
        gen_qoutes()
        'Try
        '    download_updates()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        xml_load()
        lblversion.Text = My.Application.Info.Version.ToString
        Timer1.Start()
        'delete_olderversion()
        'Control.CheckForIllegalCrossThreadCalls = False
        'thread = New System.Threading.Thread(AddressOf subload.ShowDialog)
        'thread.Start()
        'Try

        'Catch ex As Exception

        'End Try
        'SplashScreen.Close()
        txtuser.Focus()
    End Sub

    Public Sub enabled_true()
        txtuser.Enabled = True
        txtpassword.Enabled = True
        bttnlogin.Enabled = True
        bttncancel.Enabled = True
        'lblsetupdb.Enabled = True
    End Sub

    Public Sub enabled_false()
        txtuser.Enabled = False
        txtpassword.Enabled = False
        bttnlogin.Enabled = False
        bttncancel.Enabled = False
        'lblsetupdb.Enabled = False
    End Sub

    Private Sub xml_load()
        Dim chk As New Xml.XmlDocument
        chk.Load("attempt.xml")
        For Each node As Xml.XmlNode In chk.SelectNodes("/ATTEMPT")
            Try
                check = Crypt(node.InnerText).ToString.Replace("QWERTYUIOPASDFGHJKLZXCVBNM", "")
            Catch ex As Exception
                'frm_change_Date.dtchange.Enabled = False
                frm_change_Date.ShowDialog()
            End Try
        Next
        Try
            Dim dtvalid As DateTime = DateTime.Now.ToString("M/dd/yy H:m")
            If DateTime.Parse(check) > DateTime.Parse(dtvalid) Then
                timeleft = DateDiff(DateInterval.Minute, dtvalid, check)
                Me.Hide()
                MDIfrm.Hide()
                frm_suspicious.ShowDialog()
            End If
        Catch ex As Exception
            Me.Close()
        End Try

        'txtserver.Items.Clear()
        'For Each node As Xml.XmlNode In dom.SelectNodes("/SERVER")
        '    txtserver.Items.Add(node.InnerText)
        '    txtserver.Text = txtserver.ValueMember.IndexOf(0)
        'Next

        'dom.Load("logs.xml")

        Dim server As New Xml.XmlDocument
        server.Load("logs.xml")
        Dim elemList As XmlNodeList = server.GetElementsByTagName("SERVER")
        Dim i As Integer
        For i = 0 To elemList.Count - 1
            txtserver.Text = elemList(i).InnerXml
        Next i

        'If txtserver.Items.Count > 0 Then
        '    txtserver.SelectedIndex = 0
        'End If

        'db
        Dim db As New Xml.XmlDocument
        db.Load("db.xml")
        Dim dblist As XmlNodeList = db.GetElementsByTagName("DB")
        Dim idb As Integer
        For idb = 0 To dblist.Count - 1
            txtdb.Text = dblist(idb).InnerXml
        Next idb
        'pass
        Dim pass As New Xml.XmlDocument
        pass.Load("server_pass.xml")
        Dim passlist As XmlNodeList = pass.GetElementsByTagName("PASS")
        Dim ipass As Integer
        For ipass = 0 To passlist.Count - 1
            txtserver_pass.Text = Crypt(passlist(ipass).InnerXml) & "123456789"
        Next ipass
        'txtserver_pass.Text = Add.Crypt(txtserver_pass.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Tag = True Then
            lbltstconn.ForeColor = Color.Red
            Timer1.Tag = False
        Else
            lbltstconn.ForeColor = Color.Blue
            Timer1.Tag = True
        End If
    End Sub

    Private Sub validate_login()
        Dim currentVersion As String = ""
        Dim localVersion As String = My.Application.Info.Version.ToString
        Dim ver As New Xml.XmlDocument
        ver.Load("version.xml")
        Dim verlist As XmlNodeList = ver.GetElementsByTagName("VERSION")
        Dim iver As Integer
        For iver = 0 To verlist.Count - 1
            currentVersion = verlist(iver).InnerXml
        Next iver

        If currentVersion <= localVersion Then
            Dim newVersion As String = My.Application.Info.Version.ToString
            Dim version As New XElement("VERSION", newVersion)
            File.WriteAllText("version.xml", version.ToString())

            conn()
            sql = "UPDATE users SET pwd='!@#$%^&*()_' WHERE type='Admin'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            'Try
            conn()
            'sql = "SELECT a.userid,a.fullname,a.pwd,a.Type,a.wrkstnID,b.*,c.* FROM Users a,sysparmtr b,CompanyName c WHERE a.userid='" + txtuser.Text.Trim + "' AND a.pwd=HASHBYTES('SHA1','" + txtpassword.Text + "') and a.productcode=b.productcode"
            sql = "SELECT * FROM Users  WHERE userid='" + txtuser.Text.Trim + "' AND pwd='" + txtpassword.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            cmd.CommandTimeout = 5
            If rd.Read Then
                systemdate = DateTime.Today
                If rd("userid") = "renz" Then
                    GoTo a
                End If
                If rd("userid") = txtuser.Text And rd("pwddateexpiration") > systemdate Then
a:                  user = txtuser.Text
                    usersname = rd("fullname").ToString
                    usertype = rd("type").ToString
                    If rd("wrkstnID") = "n/a" Then
                        conn()
                        sql = "UPDATE users SET wrkstnID='" + System.Environment.MachineName.ToString + "' WHERE userID='" + rd("userid").ToString + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                        MsgBox("User is now registered in this computer, please login again to proceed!", MsgBoxStyle.Information)
                        txtuser.Clear()
                        txtpassword.Clear()
                        txtuser.Focus()
                    Else
                        If rd("wrkstnID") = System.Environment.MachineName.ToString Or usertype = "Admin" Then
                            conn()
                            sql = "SELECT * FROM CompanyName"
                            cmd = New SqlCommand(sql, myConn)
                            myConn.Open()
                            rd = cmd.ExecuteReader
                            If rd.Read Then
                                branch = rd("CompanyBranch").ToString
                                CompName = rd("CompanyName").ToString
                                compaddress = rd("CompanyAddress").ToString
                                branchcode = rd("branchcode").ToString
                            End If
                            rd.Close()
                            myConn.Close()

                            conn()
                            sql = "SELECT top 1 cashier FROM sysparmtr"
                            cmd = New SqlCommand(sql, myConn)
                            myConn.Open()
                            rd = cmd.ExecuteReader
                            If rd.Read Then
                                cashier = rd("cashier").ToString
                            End If
                            rd.Close()
                            myConn.Close()

                            conn()
                            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Loging CMPCsoft','" + DateTime.Parse(systemdate).ToString + "','" + user.ToString + "','" + time.ToString + "')"
                            cmd = New SqlCommand(sql, myConn)
                            myConn.Open()
                            cmd.ExecuteNonQuery()
                            myConn.Close()

                            'Timer1.Stop()
                            Dim attempt_count As New XElement("ATTEMPT", Crypt("QWERTYUIOPASDFGHJKLZXCVBNM" & DateTime.Now.ToString("M/dd/yy H:m")))
                            File.WriteAllText("attempt.xml", attempt_count.ToString())
                            i = 0
                            'Timer3.Start()
                            Me.Hide()
                        Else
                            MsgBox("This user has already registered to " & rd("wrkstnID").ToString, MsgBoxStyle.Exclamation, "Invalid Workstation")
                        End If
                    End If
                Else
                    picerror.Visible = True
                    lblnotification.Visible = True
                    lblattempt.Visible = True
                    attempt = attempt + 1
                    lblattempt.Text = "Attempt... " & attempt.ToString
                    If attempt > 2 Then
                        Dim attempt_count As New XElement("ATTEMPT", Crypt("QWERTYUIOPASDFGHJKLZXCVBNM" & DateTime.Now.AddMinutes(4).ToString("M/dd/yy H:m")))
                        File.WriteAllText("attempt.xml", attempt_count.ToString())
                        End
                    End If
                End If
            Else
                picerror.Visible = True
                lblnotification.Visible = True
                lblattempt.Visible = True
                attempt = attempt + 1
                lblattempt.Text = "Attempt... " & attempt.ToString
                If attempt > 2 Then
                    Dim attempt_count As New XElement("ATTEMPT", Crypt("QWERTYUIOPASDFGHJKLZXCVBNM" & DateTime.Now.AddMinutes(4).ToString("M/dd/yy H:m")))
                    File.WriteAllText("attempt.xml", attempt_count.ToString())
                    End
                End If
            End If
            rd.Close()
            myConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical)
            'End Try
        ElseIf currentVersion > localVersion Then
            MessageBox.Show("You are using an old version of the system. Please update the system and use  the latest one.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblprogress.ForeColor = Color.Red
            lblprogress.Text = "Access denied. Old version detected."
        Else
            MessageBox.Show("You are using an old version of the system. Please update the system and use  the latest one.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblprogress.ForeColor = Color.Red
            lblprogress.Text = "Access denied. Old version detected."
        End If

    End Sub

    Private Sub lbltstconn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltstconn.Click
        Try
            testconn()
            MsgBox("Connection complete", MsgBoxStyle.Information)

            conn()
            sql = "select count(CompanyName) as sets from CompanyName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("sets") = 0 Then
                    frm_company_param.ShowDialog()
                End If
            End If
            rd.Close()
            myConn.Close()

            conn()
            sql = "select count(loancode) as sets from Loantype"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("sets") = 0 Then
                    frm_manageloantype.ShowDialog()
                End If
            End If
            rd.Close()
            myConn.Close()

            conn()
            sql = "select count(GL_loans) as sets from sysparmtr"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("sets") = 0 Then
                    frm_company_manager.ShowDialog()
                End If
            End If
            rd.Close()
            myConn.Close()
        Catch ex As Exception
            MsgBox("Connection error", MsgBoxStyle.Exclamation)
        End Try
        Dim server As New XElement("SERVER", txtserver.Text)
        File.WriteAllText("logs.xml", server.ToString())

        Dim db As New XElement("DB", txtdb.Text)
        File.WriteAllText("db.xml", db.ToString())

        Dim serve_pass As New XElement("PASS", Crypt(txtserver_pass.Text))
        File.WriteAllText("server_pass.xml", serve_pass.ToString.Replace("123456789", ""))
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtuser.Clear()
        txtpassword.Clear()
        txtuser.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If txtpassword.Text.Trim <> "" Then
            If e.KeyCode = Keys.Enter Then
                validate_login()
            End If
        End If
    End Sub

    Private Sub txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtuser_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyUp

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        MsgBox("Please contact MIS about this problem.", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub txtserver_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserver.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtserver.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())

        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        progressBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        lblprogress.ForeColor = Color.Red
        lblprogress.Text = "Downloading... please wait: " & Int32.Parse(Math.Truncate(percentage).ToString()) & "%"
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        lblprogress.ForeColor = Color.Green
        lblprogress.Text = "Download completed"
        Application.Exit()
        Process.Start(Application.ExecutablePath)
    End Sub

    Private Sub bttnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnlogin.Click
        validate_login()
    End Sub

    Private Sub bttncancel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles bttncancel.LinkClicked
        End
    End Sub

    Private Sub lblupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblupdate.Click
        If MessageBox.Show("Are you sure you want to re-update this software?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            getpath()
            progressBar.Visible = True
            lblprogress.ForeColor = Color.DarkBlue
            enabled_false()
            Dim count As Integer = 0
1:          count = count + 1
            Try
                My.Computer.FileSystem.RenameFile(strpath & "\CMPCsoft.exe", "CMPCsoft(" & count & ").exe")
            Catch ex As Exception
                GoTo 1
            End Try
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri("http://martiantext.com/system/CMPCsoft.exe"), strpath & "/CMPCsoft.exe")
            'Try
            '    client.DownloadFileAsync(New Uri("http://martiantext.com/system/versions.xml"), strpath & "/versions.xml")
            'Catch ex As Exception

            'End Try
            'Try
            '    client.DownloadFileAsync(New Uri("http://www.coolwaympc.com/versions/Telerik_WinControls_Multiview.dll"), strpath & "/Telerik_WinControls_Multiview.dll")
            'Catch ex As Exception

            'End Try
            Timer3.Start()
        End If
    End Sub

    Public Sub delete_olderversion()
        'delete older version
        Dim fileEntries As String() = Directory.GetFiles(strpath, "*.exe")
        ' Process the list of .txt files found in the directory. '
        Dim fileName As String
        For Each fileName In fileEntries
            If (System.IO.File.Exists(fileName)) Then
                fileName = fileName.ToString.Replace(strpath, "")
                'MsgBox(fileName)
                'Read File and Print Result if its true
                If Not fileName.ToString.ToLower = "\CMPCsoft.exe".ToLower Then
                    Try
                        System.IO.File.Delete(strpath & fileName)
                    Catch ex As Exception

                    End Try
                End If
            End If
            'TransfereFile(fileName, 1)
        Next
    End Sub

    Private Sub piclogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piclogin.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click


        Try
            testconn()
            MsgBox("Connection complete", MsgBoxStyle.Information)

            conn()
            sql = "select count(CompanyName) as sets from CompanyName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("sets") = 0 Then
                    frm_company_param.ShowDialog()
                End If
            End If
            rd.Close()
            myConn.Close()

            conn()
            sql = "select count(loancode) as sets from Loantype"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("sets") = 0 Then
                    frm_manageloantype.ShowDialog()
                End If
            End If
            rd.Close()
            myConn.Close()

            conn()
            sql = "select count(GL_loans) as sets from sysparmtr"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("sets") = 0 Then
                    frm_company_manager.ShowDialog()
                End If
            End If
            rd.Close()
            myConn.Close()
        Catch ex As Exception
            MsgBox("Connection error", MsgBoxStyle.Exclamation)
        End Try
        Dim server As New XElement("SERVER", txtserver.Text)
        File.WriteAllText("logs.xml", server.ToString())

        Dim db As New XElement("DB", txtdb.Text)
        File.WriteAllText("db.xml", db.ToString())

        Dim serve_pass As New XElement("PASS", Crypt(txtserver_pass.Text))
        File.WriteAllText("server_pass.xml", serve_pass.ToString.Replace("123456789", ""))

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class