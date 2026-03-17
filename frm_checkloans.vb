Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_checkloans
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader

    Private Sub bttnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnlogin.Click
        blank("backup")
        'If txtlntype.Text.Trim = "" Then
        '    MsgBox("Loantype is empty.", MsgBoxStyle.Exclamation, "Invalid")
        '    txtlntype.Focus()
        'ElseIf txtlncode.Text.Trim = "" Then
        '    MsgBox("Loancode is empty.", MsgBoxStyle.Exclamation, "Invalid")
        '    txtlncode.Focus()
        'Else
        '    conn()
        '    sql = "UPDATE loans SET loantype='" + txtlntype.Text + "',loancode='" + txtlncode.Text + "' WHERE pnnumber='" + txtpnnumber.Text + "'"
        '    cmd = New SqlCommand(sql, myConn)
        '    myConn.Open()
        '    cmd.ExecuteNonQuery()
        '    myConn.Close()
        '    MsgBox("Update completed.", MsgBoxStyle.Information, "Success")
        'End If
    End Sub

    Sub blank(ByVal str As String)
        If SaveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.Yes Then
            If cmbserver.Text = "" Or cmbdatabase.Text = "" Then
                MsgBox("Server Name & Database Blank Field")
                Exit Sub
            Else
                If str = "backup" Then
                    SaveFileDialog1.FileName = cmbdatabase.Text
                    SaveFileDialog1.ShowDialog()
                    Dim s As String
                    s = SaveFileDialog1.FileName
                    query("BACKUP DATABASE [" + cmbdatabase.Text + "] TO  DISK = N'" + s.ToString + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'" + cmbdatabase.Text + "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                    MsgBox("Backup Complete!", MsgBoxStyle.Information, "100 % Complete")
                ElseIf str = "restore" Then
                    OpenFileDialog1.ShowDialog()
                    'Timer1.Enabled = True
                    'ProgressBar1.Visible = True
                    query("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk='" & OpenFileDialog1.FileName & "'")
                End If
            End If
        End If
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        Me.Close()
    End Sub

    Private Sub frm_checkloans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        server(".")
        server(".\sqlexpress")
    End Sub

    Sub server(ByVal str As String)
        con = New SqlConnection("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
        con.Open()
        cmd = New SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con)
        dread = cmd.ExecuteReader
        While dread.Read
            cmbserver.Items.Add(dread(2))
        End While
        dread.Close()
    End Sub

    Sub connection()
        con = New SqlConnection("Data Source=" & Trim(cmbserver.Text) & ";Database=Master;integrated security=SSPI;")
        con.Open()
        cmbdatabase.Items.Clear()
        cmd = New SqlCommand("select * from sysdatabases", con)
        dread = cmd.ExecuteReader
        While dread.Read
            cmbdatabase.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub

    Sub query(ByVal que As String)
        On Error Resume Next
        cmd = New SqlCommand(que, con)
        cmd.ExecuteNonQuery()

        'view_member()
    End Sub


    'Private Sub txtfname_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Validated
    '    conn()
    '    sql = "SELECT * FROM loans where MemCode='" + txtfname.SelectedValue.ToString + "'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader
    '    If rd.Read Then
    '        txtpnnumber.Text = rd("pnnumber").ToString
    '        txtlntype.Text = rd("loantype").ToString
    '        txtlncode.Text = rd("loancode").ToString
    '    End If
    '    rd.Close()
    '    myConn.Close()
    'End Sub

    Private Sub cmbserver_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserver.SelectedIndexChanged
        connection()
    End Sub
End Class