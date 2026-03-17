Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_newcenter
    Dim memcode As Integer
    Dim provcode As String
    Dim muncode As String
    Dim brgycode As String
    Dim sitiocode As String
    Dim gender As String
    Dim sanum As Integer
    Dim ctrcode As Integer
    Dim collcode As String
    Dim sched As Integer = 1
    Dim addrss As String

    Private Sub select_province()
        conn()
        sql = "SELECT * FROM province ORDER BY provdesc ASC"
        cmd = New SqlCommand(sql, myConn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim bs1 As New BindingSource()
        bs1.DataSource = dt
        txtprovince.DataSource = bs1
        txtprovince.DisplayMember = "provdesc"
        txtprovince.ValueMember = "provcode"
    End Sub

    Private Sub select_municipal()
        conn()
        sql = "SELECT * FROM municipal WHERE provcode='" + txtprovince.SelectedValue.ToString + "' ORDER BY mundesc ASC"
        cmd = New SqlCommand(sql, myConn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim bs1 As New BindingSource()
        bs1.DataSource = dt
        txtmunicipal.DataSource = bs1
        txtmunicipal.DisplayMember = "mundesc"
        txtmunicipal.ValueMember = "muncode"
    End Sub

    Private Sub select_barangay()
        Try
            Call conn()
            sql = "SELECT * FROM barangay WHERE provcode='" + txtprovince.SelectedValue.ToString + "' AND muncode='" + txtmunicipal.SelectedValue.ToString + "' ORDER BY brgydesc ASC"
            cmd = New SqlCommand(sql, myConn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim bs1 As New BindingSource()
            bs1.DataSource = dt
            txtbarangay.DataSource = bs1
            txtbarangay.DisplayMember = "brgydesc"
            txtbarangay.ValueMember = "BrgyCode"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub select_sitio()
        conn()
        sql = "SELECT * FROM sitio WHERE provcode='" + txtprovince.SelectedValue.ToString + "' AND muncode='" + txtmunicipal.SelectedValue.ToString + "' AND brgycode='" + txtbarangay.SelectedValue.ToString + "' ORDER BY sitdesc ASC"
        cmd = New SqlCommand(sql, myConn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim bs1 As New BindingSource()
        bs1.DataSource = dt
        txtsitio.DataSource = bs1
        txtsitio.DisplayMember = "sitdesc"
        txtsitio.ValueMember = "sitcode"
    End Sub

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "select collcode,Fullname from Officer"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Account Code")
        table1.Columns.Add("Officer Name")
        While (rd.Read())
            table1.Rows.Add(rd("collcode").ToString, rd("Fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll.DataSource = table1
        Me.txtcoll.AutoFilter = True
        txtcoll.DisplayMember = "Officer Name"
        txtcoll.ValueMember = "Account Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll.EditorControl.Columns(0).Width = 100
        Me.txtcoll.EditorControl.Columns(1).Width = 200
        Me.txtcoll.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub gen_sacct()
        conn()
        sql = "SELECT * FROM SA_AcctnoSeries WHERE CYear='" + DateTime.Now.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            sanum = rd("LastLAcctno") + 1
            txtsaacct.Text = branchcode.ToString & "-" & code_series & rd("CYear").ToString.Substring(2, 2) & sanum.ToString("000000") & "-" & "CF"
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub txtprovince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprovince.SelectedIndexChanged
        select_municipal()
        txtmunicipal.Focus()
    End Sub

    Private Sub txtmunicipal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmunicipal.SelectedIndexChanged
        select_barangay()
        txtbarangay.Focus()
    End Sub

    Private Sub txtbarangay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbarangay.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsitio.Focus()
        End If
    End Sub

    Private Sub txtbarangay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarangay.SelectedIndexChanged
        select_sitio()
    End Sub

    Private Sub txtsitio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsitio.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    Private Sub txtsitio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsitio.SelectedIndexChanged
        bttnsave.Focus()
    End Sub

    Private Sub gen_ctrcode()
        conn()
        sql = "SELECT max(ctrcode) as ctrcode FROM Center"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                ctrcode = rd("ctrcode") + 1
                txtctrcode.Text = code_series & ctrcode.ToString("000")
            Catch ex As Exception
                ctrcode = 1
                txtctrcode.Text = code_series & ctrcode.ToString("000")
            End Try
        End If
        rd.Close()
        myConn.Close()
    End Sub

    
    Private Sub txtmobile_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtsched.Focus()
        End If
    End Sub

    Private Sub insert_center()
        Dim ctrname As String = txtbarangay.Text & "," & txtmunicipal.Text
        conn()
        sql = "INSERT INTO Center(ctrcode,ctrchief,ctrname,ColDayno,ctraddress,CollCode,Accountnumber,GL_loans,status) VALUES ('" + txtctrcode.Text + "','" + txtfullname.Text + "','" + ctrname.ToString + "'," + sched.ToString + ",'" + addrss.ToString + "','" + txtcoll.SelectedValue.ToString + "','" + txtsaacct.Text + "','" + GL_loans + "','A')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub update_memcode()
        conn()
        sql = "UPDATE Membercode SET LastMemCode='" + memcode.ToString("000000") + "' WHERE Cyear='" + systemdate.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub cleartxt()
        txtmemcode.Clear()
        txtfullname.Clear()
        txtctrcode.Clear()
        txtmunicipal.Text = ""
        txtprovince.Text = ""
        txtsitio.Text = ""
        txtsaacct.Clear()
        txtloantype.Focus()
    End Sub

    Private Sub cboproductcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            bttnsave.Focus()
        End If
    End Sub

    Private Sub txtsched_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsched.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprovince.Focus()
        End If
    End Sub

    Private Sub txtsched_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsched.SelectedIndexChanged
        If txtsched.Text = "Monday" Then
            sched = 1
        ElseIf txtsched.Text = "Tuesday" Then
            sched = 2
        ElseIf txtsched.Text = "Wednesday" Then
            sched = 3
        ElseIf txtsched.Text = "Thursday" Then
            sched = 4
        ElseIf txtsched.Text = "Friday" Then
            sched = 5
        ElseIf txtsched.Text = "Saturday" Then
            sched = 6
        ElseIf txtsched.Text = "Sunday" Then
            sched = 7
        End If
    End Sub

    Private Sub update_saving()
        conn()
        sql = "UPDATE SA_AcctnoSeries SET LastLAcctno='" + sanum.ToString("000000") + "' WHERE CYear='" + DateTime.Now.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnsave.Click
        If txtsitio.Text.Length < 1 Then
            addrss = txtbarangay.Text & "," & txtmunicipal.Text & "," & txtprovince.Text
        Else
            addrss = txtsitio.Text & "," & txtbarangay.Text & "," & txtmunicipal.Text & "," & txtprovince.Text
        End If

        If txtloantype.Text.Trim = "" Then
            MsgBox("Fullname field is required.", MsgBoxStyle.Exclamation)
            txtloantype.Focus()
        ElseIf txtprovince.Text.Trim = "" Then
            MsgBox("Province field is required.", MsgBoxStyle.Exclamation)
            txtprovince.Focus()
        ElseIf txtmunicipal.Text.Trim = "" Then
            MsgBox("Municipal field is required.", MsgBoxStyle.Exclamation)
            txtmunicipal.Focus()
        ElseIf txtbarangay.Text.Trim = "" Then
            MsgBox("Barangay field is required.", MsgBoxStyle.Exclamation)
            txtbarangay.Focus()
        ElseIf txtsched.Text.Trim = "" Then
            MsgBox("Schedule day of center is required.", MsgBoxStyle.Exclamation)
            txtsched.Focus()
        ElseIf txtcoll.Text.Trim = "" Then
            MsgBox("Account officer field is required.", MsgBoxStyle.Exclamation)
            txtcoll.Focus()
        Else
            If MessageBox.Show("Click YES to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                conn()
                sql = "SELECT ctrcode FROM Center WHERE ctrcode='" + txtctrcode.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If Not rd.Read Then
                    GL_loans = txtloantype.SelectedValue
                    select_grptype()
                    If multiproduct = "N" Then
                        gen_sacct()
                    Else
                        txtsaacct.Clear()
                        insert_center()
                    End If

                    If txtsaacct.Text.Trim <> "" Then
1:                      gen_sacct()
                        conn()
                        sql = "SELECT accountnumber FROM Accountmaster WHERE accountnumber='" + txtsaacct.Text + "'"
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        rd = cmd.ExecuteReader()
                        If rd.Read Then
                            update_saving()
                            GoTo 1
                        Else
                            insert_center()
                            insert_sa()
                            update_saving()
                        End If
                        rd.Close()
                        myConn.Close()
                    End If
                Else
                    MsgBox("Ctrcode No. has already exist.", MsgBoxStyle.Exclamation, "Invalid")
                End If
                rd.Close()
                myConn.Close()
                update_saving()
                cleartxt()
                'gen_sacct()
            End If
        End If
    End Sub

    Private Sub insert_sa()
        Dim addrss As String = txtsitio.Text & "," & txtbarangay.Text & "," & txtmunicipal.Text & "," & txtprovince.Text

        conn()
        sql = "INSERT INTO AccountMaster(Accountnumber,memcode,Address,Dateopen,AccountType,userid,tdate,AccountStatus,GL_sa) values "
        sql += "('" + txtsaacct.Text + "',"
        sql += "'" + txtctrcode.Text + "',"
        sql += "'" + addrss.ToString + "',"
        sql += "'" + systemdate + "',"
        sql += "'CF',"
        sql += "'" + user.ToString + "',"
        sql += "'" + systemdate + "',"
        sql += "'Active',"
        sql += "'2080'"
        sql += ")"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Me.Close()
        frm_center.gen_center()
    End Sub

    Private Sub frm_newcenter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtsaacct.Text = "(Auto generated)"
        view_gl()
        display_members()
        view_officer()
        select_province()
        txtloantype.SelectedValue = frm_center.txtloantype.SelectedValue
    End Sub

    Private Sub display_members()
        dtgridmembers.Rows.Clear()
        conn()
        'If Me.Text = "View Loan" Then
        '    sql = "SELECT MemCode,fullname,address FROM Members WHERE  MemCode in(select distinct MemCode from Loans where released ='Y')"
        'ElseIf Me.Text = "Edit Loan" Then
        '    sql = "SELECT MemCode,fullname,address FROM Members WHERE  MemCode in(select distinct MemCode from Loans where released ='N')"
        'Else
        sql = "SELECT Top 50 MemCode,fullname,address FROM Members WHERE fullname like '%" + txtsearch.Text + "%'  ORDER BY fullname ASC"
        'End If
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            Dim x As Integer = dtgridmembers.Rows.Add
            dtgridmembers.Rows(x).Cells(0).Value = rd("MemCode").ToString
            dtgridmembers.Rows(x).Cells(1).Value = rd("fullname").ToString
            dtgridmembers.Rows(x).Cells(2).Value = rd("address").ToString
        End While
        rd.Close()
        myConn.Close()
        For x As Integer = 0 To dtgridmembers.Rows.Count - 1
            If x Mod 2 Then
                dtgridmembers.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub view_gl()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT DISTINCT GL_loans,loandesc FROM Loantype WHERE gl_loans in(select gl_loans from UserAssigned where userID='" + user.ToString + "') order by loandesc"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("gl_loans").ToString, rd("loandesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtloantype.DataSource = table1
        Me.txtloantype.AutoFilter = True
        txtloantype.DisplayMember = "Description"
        txtloantype.ValueMember = "Code"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtloantype.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtloantype.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtloantype.EditorControl.Columns(0).Width = 90
        Me.txtloantype.EditorControl.Columns(1).Width = 200
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 320
    End Sub

    Private Sub lblgenerate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblgenerate.LinkClicked
        Dim code As Integer = 0
        conn()
        sql = "SELECT (count(ctrcode)+1) as code FROM center"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            code = rd("code").ToString
            txtctrcode.Text = code.ToString("000000")
        End If
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub lblclient_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblclient.LinkClicked
        If pn_members.Visible = False Then
            pn_members.Size = New Size(642, 200)
            pn_members.Visible = True
            txtsearch.Focus()
        Else
            pn_members.Visible = False
        End If
    End Sub

    Private Sub dtgridmembers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridmembers.CellClick
        txtmemcode.Text = dtgridmembers.CurrentRow.Cells(0).Value
        txtfullname.Text = dtgridmembers.CurrentRow.Cells(1).Value
        If multiproduct = "N" Then
            gen_sacct()
        End If
        pn_members.Visible = False
        txtctrcode.Focus()
    End Sub

    Private Sub dtgridmembers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridmembers.DoubleClick
      
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        display_members()
    End Sub
End Class