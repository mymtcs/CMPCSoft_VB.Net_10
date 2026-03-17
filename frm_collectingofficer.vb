Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_collectingofficer
    ' FOR CONNECTION
    Private cSQL As New SQLControl

    Dim code As Integer = 0

    Private Sub gencode()
        'conn()
        'sql = "SELECT MAX(substring(CollCode,3,6)) As code FROM Officer"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.Read Then
        '    Try
        '        code = Double.Parse(rd("code")) + 2
        '    Catch ex As Exception
        '        code = 1
        '    End Try
        'Else
        '    code = 1
        'End If
        'rd.Close()
        'myConn.Close()
        For i As Integer = 0 To dtgrid_collector.Rows.Count - 1
            If dtgrid_collector.Rows(i).Cells(0).Value = "" Then
                txtcode.Text = branchcode.ToString & "-"
            End If
        Next
    End Sub

    Private Sub frm_collectingofficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_collecting_officer()
        ';gen_loantype()
        gencode()
    End Sub

    'Private Sub gen_loantype()
    '    Dim table1 As DataTable = New DataTable()
    '    conn()
    '    sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype WHERE gl_loans in(select gl_loans from UserAssigned where userID='" + user.ToString + "') order by loandesc"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    table1.Columns.Add("Code")
    '    table1.Columns.Add("Description")
    '    While (rd.Read())
    '        table1.Rows.Add(rd("gl_loans").ToString, rd("loandesc").ToString)
    '    End While
    '    rd.Close()
    '    myConn.Close()
    '    txtloantype.DataSource = table1
    '    Me.txtloantype.AutoFilter = True
    '    txtloantype.DisplayMember = "Description"
    '    txtloantype.ValueMember = "Code"

    '    Dim filter As New FilterDescriptor()
    '    filter.PropertyName = Me.txtloantype.DisplayMember
    '    filter.Operator = FilterOperator.Contains
    '    Me.txtloantype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
    '    Me.txtloantype.EditorControl.Columns(0).Width = 90
    '    Me.txtloantype.EditorControl.Columns(1).Width = 200
    '    Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 320
    'End Sub

    Public Sub view_collecting_officer()
        dtgrid_collector.Rows.Clear()
        conn()
        sql = "SELECT * FROM officer WHERE  fullname LIKE '%" + txtsearch.Text + "%' and status='A'  ORDER BY CollCode"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgrid_collector.Rows.Add
            dtgrid_collector.Rows(x).Cells(0).Value = rd("CollCode").ToString
            dtgrid_collector.Rows(x).Cells(1).Value = rd("Fullname").ToString
            dtgrid_collector.Rows(x).Cells(2).Value = rd("Address").ToString
            dtgrid_collector.Rows(x).Cells(3).Value = rd("Contactno").ToString
            dtgrid_collector.Rows(x).Cells(4).Value = rd("GL_loans").ToString
        End While
        rd.Close()
        myConn.Close()

        For x As Integer = 0 To dtgrid_collector.Rows.Count - 1
            If x Mod 2 Then
                dtgrid_collector.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        view_collecting_officer()
    End Sub

    Private Sub dtgrid_collector_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_collector.CellClick
        If e.ColumnIndex = 5 Then
            If dtgrid_collector.CurrentRow.Cells(5).Value = False Then
                dtgrid_collector.CurrentRow.Cells(5).Value = True
            Else
                dtgrid_collector.CurrentRow.Cells(5).Value = False
            End If
        End If
    End Sub


    Private Sub dtgrid_collector_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_collector.Click
        txtcode.Text = dtgrid_collector.CurrentRow.Cells(0).Value
        txtfullname.Text = dtgrid_collector.CurrentRow.Cells(1).Value
        txtaddress.Text = dtgrid_collector.CurrentRow.Cells(2).Value
        txtcontact.Text = dtgrid_collector.CurrentRow.Cells(3).Value
        ' txtloantype.SelectedValue = dtgrid_collector.CurrentRow.Cells(4).Value
    End Sub

    Private Sub txtfullname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtfullname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        'If dtgrid_collector.CurrentRow.Cells(0).Value <> "" And dtgrid_collector.CurrentRow.Cells(1).Value <> "" Then
        conn()
        sql = "SELECT * FROM officer WHERE CollCode='" + txtcode.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            conn()
            sql = "SELECT count(pnnumber) as num FROM loans WHERE CollCode='" + txtcode.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                If rd("num") = 0 Then
                    'conn()
                    'sql = "UPDATE officer SET Fullname='" + txtfullname.Text + "',Address='" + txtaddress.Text + "',Contactno='" + txtcontact.Text + "' WHERE CollCode='" + txtcode.Text + "'"
                    'cmd = New SqlCommand(sql, myConn)
                    'myConn.Open()
                    'cmd.ExecuteNonQuery()
                    'myConn.Close()
                    'MsgBox(txtcode.Text & " code was successfully updated.", MsgBoxStyle.Information, "Success")

                    ' NEW METHOD
                    UpdateOfficer()
                Else
                    MsgBox(txtcode.Text & " officer's code cannot be updated.", MsgBoxStyle.Information, "Success")
                End If
            End If
            rd.Close()
            myConn.Close()
        Else
            'conn()
            'sql = "INSERT INTO officer (CollCode,Fullname,Address,Contactno,GL_loans,status) VALUES ('" + txtcode.Text + "','" + txtfullname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','0','A')"
            'cmd = New SqlCommand(sql, myConn)
            'myConn.Open()
            'cmd.ExecuteNonQuery()
            'myConn.Close()
            'MsgBox("New collector was successfully added.", MsgBoxStyle.Information, "Success")

            ' NEW METHOD
            InsertOfficer()

        End If
        rd.Close()
        myConn.Close()
        gencode()
        view_collecting_officer()
        '
        ' Else
        'MsgBox("Fields with (*) are required. This collector will not be added to a database.", MsgBoxStyle.Exclamation, "Invalid")
        ' End If
    End Sub
    Private Sub InsertOfficer()
        ' ADD SQL PARAMS & RUN THE COMMAND
        cSQL.AddParam("@CollCode", txtcode.Text)
        cSQL.AddParam("@Fullname", txtfullname.Text)
        cSQL.AddParam("@Address", txtaddress.Text)
        cSQL.AddParam("@Contactno", txtcontact.Text)
        cSQL.AddParam("@GL_loans", "0")
        cSQL.AddParam("@status", "A")

        cSQL.ExecQuery("INSERT INTO officer (CollCode,Fullname,Address,Contactno,GL_loans,status) " & _
                       "VALUES (@CollCode, @Fullname, @Address, @Contactno, @GL_loans, @status);")

        ' REPORT & ABORT ON ERRORS
        If cSQL.HasException(True) Then Exit Sub


        MsgBox("Officer created successfully!")

    End Sub
    Private Sub UpdateOfficer()
        cSQL.AddParam("@CollCode", txtcode.Text)
        cSQL.AddParam("@Fullname", txtfullname.Text)
        cSQL.AddParam("@Address", txtaddress.Text)
        cSQL.AddParam("@Contactno", txtcontact.Text)

        cSQL.ExecQuery("UPDATE officer " & _
                       "SET Fullname=@Fullname, Address=@Address, Contactno=@Contactno " & _
                       "WHERE CollCode=@CollCode;")

        If cSQL.HasException Then Exit Sub

        MsgBox("Officer " & txtfullname.Text & " has been updated.")

    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        txtcode.Clear()
        txtfullname.Clear()
        txtaddress.Clear()
        txtcontact.Clear()
        txtcode.Focus()
    End Sub

    Private Sub bttnmerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnmerge.Click
        If MessageBox.Show("Are you sure you want to merger this account officer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim code_array As String = ""
            Dim collcode As String = ""
            For i As Integer = 0 To dtgrid_collector.Rows.Count - 1
                If dtgrid_collector.Rows(i).Cells(5).Value = True Then
                    code_array = dtgrid_collector.Rows(i).Cells(0).Value
                    If collcode = "" Then
                        collcode = dtgrid_collector.Rows(i).Cells(0).Value
                        conn()
                        sql = "UPDATE Officer set collcode='" + collcode + "' WHERE collcode='" + code_array + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    Else
                        conn()
                        sql = "UPDATE Officer set status='X' WHERE collcode='" + code_array + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                    'MsgBox(collcode & ", " & code_array)
                    conn()
                    sql = "UPDATE loans set collcode='" + collcode + "' WHERE collcode='" + code_array + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "UPDATE Center set collcode='" + collcode + "' WHERE collcode='" + code_array + "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                End If
            Next

            MsgBox("Merging completed", MsgBoxStyle.Information, "Success")
            view_collecting_officer()
        End If
    End Sub

    Private Sub bttndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndelete.Click
        If MessageBox.Show("Are you sure you want to delete " & dtgrid_collector.CurrentRow.Cells(1).Value & " from list of Officers?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "DELETE FROM Officer WHERE collcode = '" & dtgrid_collector.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully deleted an officer!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            myConn.Close()
        End If
        view_collecting_officer()
    End Sub
End Class
