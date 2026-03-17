Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_newmembers
    Dim provcode As String
    Dim muncode As String
    Dim brgycode As String
    Dim sitiocode As String
    Dim gender As String
    Dim memcode As Integer

    Private Sub txtbdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttell.Focus()
        End If
    End Sub

    Private Sub txtbdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbdate.KeyUp

    End Sub

    Private Sub txtbdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbdate.ValueChanged
        txtage.Text = DateDiff(DateInterval.Year, txtbdate.Value, systemdate)
    End Sub

    Private Sub txtlstname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlstname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfname.Focus()
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlstname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtlstname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub select_province()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM Province"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("provcode").ToString, rd("provdesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtprov.DataSource = table1
        Me.txtprov.AutoFilter = True
        txtprov.DisplayMember = "Description"
        txtprov.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtprov.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtprov.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtprov.EditorControl.Columns(0).Width = 100
        Me.txtprov.EditorControl.Columns(1).Width = 250
        Me.txtprov.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub select_municipal()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM municipal"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("MunCode").ToString, rd("MunDesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtmun.DataSource = table1
        Me.txtmun.AutoFilter = True
        txtmun.DisplayMember = "Description"
        txtmun.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtmun.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtmun.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtmun.EditorControl.Columns(0).Width = 100
        Me.txtmun.EditorControl.Columns(1).Width = 250
        Me.txtmun.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub select_barangay()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM barangay"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("BrgyCode").ToString, rd("BrgyDesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtbrgy.DataSource = table1
        Me.txtbrgy.AutoFilter = True
        txtbrgy.DisplayMember = "Description"
        txtbrgy.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtbrgy.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtbrgy.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtbrgy.EditorControl.Columns(0).Width = 100
        Me.txtbrgy.EditorControl.Columns(1).Width = 250
        Me.txtbrgy.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

    Private Sub frm_newmembers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_members.view_member()
    End Sub

    Private Sub frm_newmembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_province()
        select_municipal()
        select_barangay()
        append()
        gen_occupation()
        gen_src_ofIncome()
    End Sub

    Public Sub gen_occupation()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM occupation ORDER BY occupdesc ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("occupcode").ToString, rd("occupdesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtoccu.DataSource = table1
        Me.txtoccu.AutoFilter = True
        txtoccu.DisplayMember = "Description"
        txtoccu.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtoccu.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtoccu.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtoccu.EditorControl.Columns(0).Width = 100
        Me.txtoccu.EditorControl.Columns(1).Width = 250
        Me.txtoccu.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Public Sub gen_src_ofIncome()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM SourceofIncome ORDER BY SourceofIncome ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("ID").ToString, rd("SourceofIncome").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsrc_of_income.DataSource = table1
        Me.txtsrc_of_income.AutoFilter = True
        txtsrc_of_income.DisplayMember = "Description"
        txtsrc_of_income.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsrc_of_income.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsrc_of_income.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsrc_of_income.EditorControl.Columns(0).Width = 100
        Me.txtsrc_of_income.EditorControl.Columns(1).Width = 250
        Me.txtsrc_of_income.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub append()
        Dim MySource_lname As New AutoCompleteStringCollection()
        Dim MySource_fname As New AutoCompleteStringCollection()
        Dim MySource_mname As New AutoCompleteStringCollection()
        Dim MySource_occu As New AutoCompleteStringCollection()

        conn()
        sql = "SELECT DISTINCT lastname,firstname,midname,occupation FROM members"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read()
            MySource_lname.AddRange(New String() {rd("lastname").ToString})
            MySource_fname.AddRange(New String() {rd("firstname").ToString})
            MySource_mname.AddRange(New String() {rd("midname").ToString})
            MySource_occu.AddRange(New String() {rd("occupation").ToString})
        End While
        rd.Close()
        myConn.Close()
        With txtlstname
            .AutoCompleteCustomSource = MySource_lname
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .Height = 10
        End With
        With txtfname
            .AutoCompleteCustomSource = MySource_fname
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtmname
            .AutoCompleteCustomSource = MySource_mname
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub

    Private Sub gen_memcode()
1:      conn()
        '-ORIGINAL
        'sql = "SELECT Max(LastMemCode) As LastMemCode FROM Membercode WHERE CYear='" + DateTime.Now.Year.ToString + "'"

        '-NEW 1/6/22
        sql = "SELECT Max(LastMemCode) As LastMemCode FROM Membercode "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                'GET THE LAST MEMBER CODE
                memcode = rd("LastMemCode").ToString
                memcode = memcode + 1

                '2 CHAR YEAR + - 
                txtmemcode.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & code_series & memcode.ToString("000000") & "-" & branchcode.ToString
            Catch ex As Exception
                txtmemcode.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & code_series & "000001" & "-" & branchcode.ToString
            End Try
        Else
            conn()
            sql = "INSERT INTO Membercode(LastMemCode,CYear)Values('000000','" + DateTime.Now.Year.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
            GoTo 1
        End If
        rd.Close()
        myConn.Close()
        'txtsaacct.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & systemdate.Year.ToString.Substring(2, 2) & rd("sacctnum").ToString("00000000") & "-PS"
    End Sub

    Private Sub txtfname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmname.Focus()
        End If
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtfname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtmname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcivil.Focus()
        End If
    End Sub

    Private Sub txtmname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtmname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcivil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcivil.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtspouse.Focus()
        End If
    End Sub

    Private Sub txttell_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttell.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmobile.Focus()
        End If
    End Sub

    Private Sub txttell_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttell.KeyUp

    End Sub

    Private Sub txtmobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmemtype.Focus()
        End If
    End Sub

    Private Sub update_memcode()
        Dim nMemcode As Integer
        Dim nNewMemcode As Integer


        conn()

        '-GET THE LAST MEMCODE
        sql = "SELECT Max(LastMemCode) As LastMemCode FROM Membercode "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()

        If rd.Read Then
            Try
                'GET THE LAST MEMBER CODE
                nMemcode = rd("LastMemCode").ToString
                nNewMemcode = nMemcode + 1

            Catch ex As Exception

            End Try
        End If

        rd.Close()
        myConn.Close()


        'sql = "UPDATE Membercode SET LastMemCode='" + memcode.ToString("000000") + "' WHERE Cyear='" + systemdate.Year.ToString + "'"

        sql = "UPDATE Membercode SET LastMemCode='" + nNewMemcode.ToString("000000") + "' WHERE LastMemCode='" + nMemcode.ToString("000000") + "'"

        conn()
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub cleartxt()
        txtage.Clear()
        txtbdate.Value = systemdate
        txtcivil.Text = ""
        txtfname.Clear()
        txtlstname.Clear()
        txtmemcode.Clear()
        txtmname.Clear()
        txtoccu.Text = ""
        txttell.Clear()
        txtmemcode.Focus()
        gen_memcode()
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtprov_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprov.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmun.Focus()
        End If
    End Sub

    Private Sub txtmun_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmun.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbrgy.Focus()
        End If
    End Sub

    Private Sub txtbrgy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbrgy.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsit.Focus()
        End If
    End Sub

    Private Sub txtsit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
        End If
    End Sub

    Private Sub txtspouse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtspouse.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtoccu.Focus()
        End If
    End Sub

    Private Sub txtoccu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtoccu.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsrc_of_income.Focus()
        End If
    End Sub

    Private Sub txtspouse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtspouse.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtspouse.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frm_occupation.ShowDialog()
    End Sub

    Private Sub txtsrc_of_income_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsrc_of_income.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbdate.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_source_of_income.ShowDialog()
    End Sub

    Private Sub txtmemtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmemtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_tinno.Focus()
        End If
    End Sub

    Private Sub txt_tinno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_tinno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsss.Focus()
        End If
    End Sub

    Private Sub txtmother_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmother.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfather.Focus()
        End If
    End Sub

    Private Sub txtfather_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfather.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprov.Focus()
        End If
    End Sub

    Private Sub txtmname_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmname.Validated
        txtmname.Text = txtmname.Text.ToString.Replace(".", "")
    End Sub

    Private Sub pic_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_img.Click

    End Sub


    Private Sub txtsss_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsss.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmother.Focus()
        End If
    End Sub

    Private Sub bttn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_save.Click
        save()
    End Sub

    Private Sub save()
        Dim addrss As String
        If txtsit.Text = "Undefined" Or txtsit.Text = "undefined" Or txtsit.Text = "undefine" Or txtsit.Text = "UNDEFINED" _
            Or txtsit.Text = "None" Or txtsit.Text = "none" _
     Or txtsit.Text = "N/A" Or txtsit.Text = "n/a" Then
            addrss = txtbrgy.Text & "," & txtmun.Text & "," & txtprov.Text
            MsgBox(addrss)
        Else
            addrss = txtsit.Text & " " & txtbrgy.Text & "," & txtmun.Text & "," & txtprov.Text
        End If

        Dim fullname As String = txtlstname.Text & "," & txtfname.Text & "," & txtmname.Text

        If rdbxfemale.Checked = True Then
            gender = "Female"
        Else
            gender = "Male"
        End If

        If txtlstname.Text.Trim = "" Then
            MsgBox("Lastname field is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtlstname.Focus()
        ElseIf txtlstname.Text.Substring(0, 1) = " " Then
            MsgBox("Lastname field is does not allow spacing on first string.", MsgBoxStyle.Exclamation, "Invalid")
            txtlstname.Focus()
        ElseIf txtfname.Text.Trim = "" Then
            MsgBox("Firstname field is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtfname.Focus()
        ElseIf txtfname.Text.Substring(0, 1) = " " Then
            MsgBox("Firstname field is does not allow spacing on first string.", MsgBoxStyle.Exclamation, "Invalid")
            txtfname.Focus()
        ElseIf txtmname.Text.Trim = "" Then
            MsgBox("Middlename field is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtmname.Focus()
        ElseIf txtmname.Text.Substring(0, 1) = " " Then
            MsgBox("Middlename field is does not allow spacing on first string.", MsgBoxStyle.Exclamation, "Invalid")
            txtmname.Focus()
        ElseIf txtmname.Text.Length <= 1 Then
            MsgBox("Middlename must be greater than one character.", MsgBoxStyle.Exclamation, "Invalid")
            txtmname.Focus()
        ElseIf txtcivil.Text.Trim = "" Then
            MsgBox("Civil status field is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtcivil.Focus()
        ElseIf txtoccu.SelectedValue = "" Then
            MsgBox("Invalid selection of occupation.", MsgBoxStyle.Exclamation, "Invalid")
            txtoccu.Focus()
        ElseIf Double.Parse(txtage.Text) <= 17 Then
            MsgBox("Age must be 18 years and above.", MsgBoxStyle.Exclamation, "Invalid")
            txtbdate.Focus()
        ElseIf txtprov.SelectedValue = "" Then
            MsgBox("Invalid selection of province.", MsgBoxStyle.Exclamation, "Invalid")
            txtprov.Focus()
        ElseIf txtmun.SelectedValue = "" Then
            MsgBox("Invalid selection of municipal.", MsgBoxStyle.Exclamation, "Invalid")
            txtmun.Focus()
        ElseIf txtbrgy.SelectedValue = "" Then
            MsgBox("Invalid selection of barangay.", MsgBoxStyle.Exclamation, "Invalid")
            txtbrgy.Focus()
            'ElseIf txtsit.Text = "" Then
            '    MsgBox("Invalid selection of sitio.", MsgBoxStyle.Exclamation, "Invalid")
            '    txtbrgy.Focus()
        ElseIf txtsrc_of_income.SelectedValue = "" Then
            MsgBox("Invalid selection of source of income.", MsgBoxStyle.Exclamation, "Invalid")
            txtoccu.Focus()
        ElseIf txtmobile.Text.Trim = "" Then
            MsgBox("Mobile number field is required.", MsgBoxStyle.Exclamation, "Invalid")
            txtmobile.Focus()
        ElseIf txtmobile.Text.Length <> 11 Then
            MsgBox("Mobile number must be 11 numeric.", MsgBoxStyle.Exclamation, "Invalid")
            txtmobile.Focus()
        ElseIf IsNumeric(txtmobile.Text) = False Then
            MsgBox("Mobile number must be 11 numeric.", MsgBoxStyle.Exclamation, "Invalid")
            txtmobile.Focus()
        ElseIf txt_tinno.Text.Length < 15 Then
            If txtfather.Text.Trim = "" Or txtmother.Text.Trim = "" Then
                MsgBox("Please input mother's and father's maiden name. Or input correct TIN no.", MsgBoxStyle.Exclamation)
                txtmother.Focus()
            Else
                GoTo 1
            End If
        Else
1:          If MessageBox.Show("Click YES to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                gen_memcode()
                update_memcode()
                'conn()
                'sql = "INSERT INTO Members(MemCode,membertype,lastname,firstname,midname,gender,birthdate,age,address,spouse,telno,mobileno,occupcode,SourceofIncome,userid,tdate,ttime,provcode,muncode,brgycode,sitcode,civil_stat,GL_loans,tin,SSSNo,father,mother,status) VALUES "
                'sql += "('" + txtmemcode.Text + "',"
                'sql += "'" + txtmemtype.Text + "',"
                'sql += "'" + txtlstname.Text + "',"
                'sql += "'" + txtfname.Text + "',"
                'sql += "'" + txtmname.Text + "',"
                'sql += "'" + gender.ToString + "',"
                'sql += "'" + txtbdate.Value + "',"
                'sql += "" + txtage.Text + ","
                'sql += "'" + addrss.ToString + "',"
                'sql += "'" + txtspouse.Text + "',"
                'sql += "'" + txttell.Text + "',"
                'sql += "'" + txtmobile.Text + "',"
                'sql += "'" + txtoccu.SelectedValue + "',"
                'sql += "'" + txtsrc_of_income.SelectedValue + "',"
                'sql += "'" + user.ToString + "',"
                'sql += "'" + systemdate + "',"
                'sql += "'" + time.ToString + "',"
                'sql += "'" + txtprov.SelectedValue.ToString + "',"
                'sql += "'" + txtmun.SelectedValue.ToString + "',"
                'sql += "'" + txtbrgy.SelectedValue.ToString + "',"
                'sql += "'" + txtsit.SelectedValue.ToString + "',"
                'sql += "'" + txtcivil.Text + "',"
                'sql += "'" + GL_loans + "',"
                'sql += "'" + txt_tinno.Text + "',"
                'sql += "'" + txtsss.Text + "',"
                'sql += "'" + txtfather.Text + "',"
                'sql += "'" + txtmother.Text + "',"
                'sql += "'A'"
                'sql += ")"
                ''MsgBox(sql.ToString)
                'cmd = New SqlCommand(sql, myConn)
                'myConn.Open()
                'cmd.ExecuteNonQuery()
                'myConn.Close()

                conn()
                sql = "INSERT INTO Members(MemCode,membertype,lastname,firstname,midname,gender,birthdate,age,address,spouse,telno,mobileno,occupcode,SourceofIncome,userid,tdate,ttime,provcode,muncode,brgycode,sitcode,civil_stat,GL_loans,tin,SSSNo,father,mother,status) VALUES "
                sql += "(@MemCode,@membertype,@lastname,@firstname,@midname,@gender,@birthdate,@age,@address,@spouse,@telno,@mobileno,@occupcode,@SourceofIncome,@userid,@tdate,@ttime,@provcode,@muncode,@brgycode,@sitcode,@civil_stat,@GL_loans,@tin,@SSSNo,@father,@mother,@status)"
                cmd = New SqlCommand(sql, myConn)
                cmd.Parameters.AddWithValue("@Memcode", txtmemcode.Text)
                cmd.Parameters.AddWithValue("@membertype", systemdate)
                cmd.Parameters.AddWithValue("@lastname", txtlstname.Text)
                cmd.Parameters.AddWithValue("@firstname", txtfname.Text)
                cmd.Parameters.AddWithValue("@midname", txtmname.Text)
                cmd.Parameters.AddWithValue("@gender", gender.ToString)
                cmd.Parameters.AddWithValue("@birthdate", txtbdate.Value)
                cmd.Parameters.AddWithValue("@age", txtage.Text)
                cmd.Parameters.AddWithValue("@address", addrss)
                cmd.Parameters.AddWithValue("@spouse", txtspouse.Text)
                cmd.Parameters.AddWithValue("@telno", txttell.Text)
                cmd.Parameters.AddWithValue("@mobileno", txtmobile.Text)
                cmd.Parameters.AddWithValue("@occupcode", txtoccu.SelectedValue)
                cmd.Parameters.AddWithValue("@SourceofIncome", txtsrc_of_income.SelectedValue)
                cmd.Parameters.AddWithValue("@userid", user)
                cmd.Parameters.AddWithValue("@tdate", systemdate)
                cmd.Parameters.AddWithValue("@ttime", time.ToString)
                cmd.Parameters.AddWithValue("@provcode", txtprov.SelectedValue)
                cmd.Parameters.AddWithValue("@muncode", txtmun.SelectedValue)
                cmd.Parameters.AddWithValue("@brgycode", txtbrgy.SelectedValue)
                cmd.Parameters.AddWithValue("@sitcode", txtsit.Text)
                cmd.Parameters.AddWithValue("@civil_stat", txtcivil.Text)
                cmd.Parameters.AddWithValue("@GL_loans", "00")
                cmd.Parameters.AddWithValue("@tin", txt_tinno.Text)
                cmd.Parameters.AddWithValue("@SSSNo", txtsss.Text)
                cmd.Parameters.AddWithValue("@father", txtfather.Enabled)
                cmd.Parameters.AddWithValue("@mother", txtmother.Text)
                cmd.Parameters.AddWithValue("@status", "A")
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                'conn()
                'sql = "INSERT INTO logs (Reasons,date,userID,time) VALUES ('Saving " & fullname & " as new member','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                'cmd = New SqlCommand(sql, myConn)
                'myConn.Open()
                'cmd.ExecuteNonQuery()
                'myConn.Close()

                MsgBox("New record has susccessfully added.", MsgBoxStyle.Information, "Message")

                txtmemcode.Text = "(Auto Genereated)"
                gen_memcode()
                txtlstname.Focus()
            End If
        End If
    End Sub

    Private Sub bttn_saveclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save()
        Me.Close()
    End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        cleartxt()
    End Sub

    Private Sub txtmemcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmemcode.TextChanged

    End Sub
End Class