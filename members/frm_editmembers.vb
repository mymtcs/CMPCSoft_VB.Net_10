Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_editmembers
    Dim gender As String
    Public trndate As String
    Dim sanum As Integer
    Dim memcode As Integer
    Dim memberID As String
    Dim fName As String

    Private Sub txtbdate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbdate.KeyUp
        If e.KeyCode = Keys.Enter Then
            txttell.Focus()
        End If
    End Sub

    Private Sub txtbdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbdate.ValueChanged
        txtage.Text = DateDiff(DateInterval.Year, txtbdate.Value, systemdate)
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

    Private Sub select_cbu()
        conn()
        sql = " select cbuaccount from members where status='x' and fullname=''"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        cbo_cbu.Items.Clear()
        While rd.Read
            cbo_cbu.Items.Add(rd("cbuaccount"))
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub frm_editmembers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_members.view_member()
        Me.Close()
    End Sub

    Private Sub frm_newmembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'gen_memcode()
        'gen_sacct()
        'pic_img.Image = Nothing
        Try
            txtmemcode.Text = frm_members.dtgridmember.CurrentRow.Cells(0).Value
        Catch ex As Exception
            MsgBox("Invalid selection of members. " & ex.ToString, MsgBoxStyle.Exclamation, "Message")
        End Try
        select_province()
        select_municipal()
        select_barangay()
        gen_occupation()
        gen_src_ofIncome()
        select_cbu()
        view_members()

        conn()
        If usertype = "Admin" Or usertype = "Bookkeeper" Then
            txtfname.ReadOnly = False
            txtlstname.ReadOnly = False
        Else
            sql = "SELECT memcode from loans where status='A'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                txtfname.ReadOnly = True
                txtlstname.ReadOnly = True
            Else
                txtfname.ReadOnly = False
                txtlstname.ReadOnly = False
            End If
            rd.Close()
            myConn.Close()
        End If

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

    Private Sub view_members()
        conn()
        sql = "SELECT * FROM members WHERE MemCode='" + txtmemcode.Text + "' "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtlstname.Text = rd("lastname").ToString
            txtfname.Text = rd("firstname").ToString
            txtmname.Text = rd("midname").ToString
            txtcivil.Text = rd("civil_stat").ToString
            txtoccu.SelectedValue = rd("occupcode").ToString
            txtbdate.Value = rd("birthdate").ToString
            txtage.Text = rd("age").ToString
            txttell.Text = rd("telno").ToString
            txtmobile.Text = rd("mobileno").ToString
            txtmemtype.Text = rd("membertype").ToString
            txtsrc_of_income.SelectedValue = rd("SourceofIncome").ToString
            txt_tinno.Text = rd("TIN").ToString
            txtfather.Text = rd("father").ToString
            txtmother.Text = rd("mother").ToString
            txtprov.SelectedValue = rd("provcode").ToString
            txtspouse.Text = rd("spouse").ToString
            cbo_cbu.Text = rd("cbuaccount")
            txtsss.Text = rd("sssno").ToString
            trndate = rd("tdate")
            Try
                txtmun.SelectedValue = rd("MunCode").ToString
            Catch ex As Exception
            End Try
            Try
                txtbrgy.SelectedValue = rd("BrgyCode").ToString
            Catch ex As Exception
            End Try
            Try
                txtsit.Text = rd("sitcode").ToString
            Catch ex As Exception

            End Try
        End If
        rd.Close()
        myConn.Close()

        'conn()
        'sql = "SELECT profile FROM imagefile WHERE MemCode='" + txtmemcode.Text + "' "
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        'If rd.HasRows Then
        '    rd.Read()
        '    Dim data As Byte() = DirectCast(rd("profile"), Byte())
        '    Dim ms As New MemoryStream(data)
        '    pic_img.Image = Image.FromStream(ms)
        'End If
        'rd.Close()
        'myConn.Close()
    End Sub

    Private Sub gen_memcode()
        conn()
        sql = "SELECT Max(LastMemCode) As LastMemCode FROM Membercode WHERE CYear='" + DateTime.Now.Year.ToString + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            Try
                memcode = rd("LastMemCode").ToString
                memcode = memcode + 1
                txtmemcode.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & memcode.ToString("000000")
            Catch ex As Exception
                txtmemcode.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & "000001"
            End Try
        Else
            txtmemcode.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & "000001"
        End If
        rd.Close()
        myConn.Close()
        'txtsaacct.Text = systemdate.Year.ToString.Substring(2, 2) & "-" & systemdate.Year.ToString.Substring(2, 2) & rd("sacctnum").ToString("00000000") & "-PS"
    End Sub

    Private Sub txtlstname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlstname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtfname.Focus()
        End If
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtfname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtmname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtmname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtfname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtmname.Focus()
        End If
    End Sub

    Private Sub txtmname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtcivil.Focus()
        End If
    End Sub

    Private Sub txtcivil_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcivil.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtoccu.Focus()
        End If
    End Sub

    Private Sub txtoccu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtbdate.Focus()
        End If
    End Sub

    Private Sub txttell_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttell.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtmobile.Focus()
        End If
    End Sub

    Private Sub txtmobile_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmobile.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtprov.Focus()
        End If
    End Sub

    Private Sub cleartxt()
        txtage.Clear()
        txtbdate.Value = systemdate
        txtcivil.Text = ""
        txtfname.Clear()
        txtlstname.Clear()
        txtmname.Clear()
        txttell.Clear()
        txtmemcode.Focus()
    End Sub

    Private Sub rdbxfemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbxfemale.CheckedChanged
        If rdbxfemale.Checked = True Then
            gender = "Female"
        Else
            gender = "Male"
        End If
    End Sub

    Private Sub bttnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub addimg()
        conn()
        sql = "delete from ImageFile where memcode='" + txtmemcode.Text + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        Try
            conn()
            sql = "INSERT INTO ImageFile VALUES(@Memcode,@DateTaken,@path,@Blob)"
            cmd = New SqlCommand(sql, myConn)
            cmd.Parameters.AddWithValue("@Memcode", txtmemcode.Text)
            cmd.Parameters.AddWithValue("@DateTaken", systemdate)
            cmd.Parameters.AddWithValue("@path", "path")
            Dim ms As New MemoryStream()
            pic_img.BackgroundImage.Save(ms, pic_img.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@Blob", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Function ImageToStream(ByVal fileName As String) As Byte()
        Dim stream As New MemoryStream()
tryagain:
        Try
            Dim image As New Bitmap(fileName)
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            GoTo tryagain
        End Try

        Return Stream.ToArray()
    End Function

    Private Sub bttnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pic_img.Image = Nothing
        frm_webcam.ShowDialog()
        'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    pic_img.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        'End If
    End Sub



    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frm_occupation.ShowDialog()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        frm_source_of_income.ShowDialog()
    End Sub

    Private Sub txtmname_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmname.Validated
        txtmname.Text = txtmname.Text.ToString.Replace(".", "")
    End Sub

    Private Sub bttnblacklist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bttn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_save.Click
        Dim addrss As String
        addrss = txtsit.Text & " " & txtbrgy.Text & "," & txtmun.Text & "," & txtprov.Text

        If rdbxfemale.Checked = True Then
            gender = "Female"
        Else
            gender = "Male"
        End If

        Dim fullname As String = txtlstname.Text & "," & txtfname.Text & "," & txtmname.Text

        If txtlstname.Text.Trim = "" Then
            MsgBox("Lastname field is required.", MsgBoxStyle.Exclamation)
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
        ElseIf txtcivil.Text.Trim = "" Then
            MsgBox("Civil status field is required.", MsgBoxStyle.Exclamation)
            txtcivil.Focus()
        ElseIf Double.Parse(txtage.Text) <= 17 Then
            MsgBox("Age must be 18 years and above.", MsgBoxStyle.Exclamation, "Invalid")
            txtbdate.Focus()
        ElseIf txtoccu.SelectedValue = "" Then
            MsgBox("Invalid selection of occupation.", MsgBoxStyle.Exclamation, "Invalid")
            txtoccu.Focus()
        ElseIf txtprov.SelectedValue = "" Then
            MsgBox("Invalid selection of province.", MsgBoxStyle.Exclamation, "Invalid")
            txtprov.Focus()
        ElseIf txtmun.SelectedValue = "" Then
            MsgBox("Invalid selection of municipal.", MsgBoxStyle.Exclamation, "Invalid")
            txtmun.Focus()
        ElseIf txtbrgy.SelectedValue = "" Then
            MsgBox("Invalid selection of barangay.", MsgBoxStyle.Exclamation, "Invalid")
            txtbrgy.Focus()
        ElseIf txtsit.Text = "" Then
            MsgBox("Please add some sitio or street or bldg. No.", MsgBoxStyle.Exclamation, "Invalid")
            txtsit.Focus()
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
                GoTo b
            End If
        Else
b:          If MessageBox.Show("Click YES to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                'conn()
                'sql = "UPDATE Members SET lastname='" + txtlstname.Text + "',firstname='" + txtfname.Text + "',midname='" + txtmname.Text + "'"
                'sql += ",gender='" + gender.ToString + "',birthdate='" + txtbdate.Value + "',age=" + txtage.Text + ",address='" + addrss.ToString + "',spouse='" + txtspouse.Text + "',telno='" + txttell.Text + "',mobileno='" + txtmobile.Text + "'"
                'sql += ",occupation='" + txtoccu.Text + "',membertype='" + txtmemtype.Text + "',tin='" + txt_tinno.Text + "',sssno='" + txtsss.Text + "',father='" + txtfather.Text + "',mother='" + txtmother.Text + "',SourceofIncome='" + txtsrc_of_income.SelectedValue + "',userid='" + user.ToString + "',tdate='" + systemdate + "',ttime='" + time.ToString + "',provcode='" + txtprov.SelectedValue + "',muncode='" + txtmun.SelectedValue + "',brgycode='" + txtbrgy.SelectedValue + "',sitcode='" + txtsit.Text + "', occupcode='" + txtoccu.SelectedValue + "' WHERE MemCode='" + txtmemcode.Text + "'"
                'cmd = New SqlCommand(sql, myConn)
                ''MsgBox(sql.ToString)
                'myConn.Open()
                'cmd.ExecuteNonQuery()
                'myConn.Close()
                update_members()
                addimg()

                Try
                    conn()
                    sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Editing the membercode " & txtmemcode.Text & " to " & fullname & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()
                Catch ex As Exception

                End Try

                cleartxt()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub update_members()
        Dim addrss As String
        addrss = txtsit.Text & " " & txtbrgy.Text & "," & txtmun.Text & "," & txtprov.Text

        If rdbxfemale.Checked = True Then
            gender = "Female"
        Else
            gender = "Male"
        End If

        conn()
        sql = "UPDATE Members set membertype=@membertype,lastname=@lastname,firstname=@firstname,midname=@midname,gender=@gender,birthdate=@birthdate,address=@address,"
        sql += "spouse=@spouse,telno=@telno,mobileno=@mobileno,occupcode=@occupcode,SourceofIncome=@SourceofIncome,userid=@userid,tdate=@tdate,ttime=@ttime,provcode=@provcode,muncode=@muncode,"
        sql += "brgycode=@brgycode,sitcode=@sitcode,civil_stat=@civil_stat,tin=@tin,SSSNo=@SSSNo,father=@father,mother=@mother WHERE MemCode='" & txtmemcode.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        cmd.Parameters.AddWithValue("@membertype", systemdate)
        cmd.Parameters.AddWithValue("@lastname", txtlstname.Text)
        cmd.Parameters.AddWithValue("@firstname", txtfname.Text)
        cmd.Parameters.AddWithValue("@midname", txtmname.Text)
        cmd.Parameters.AddWithValue("@gender", gender.ToString)
        cmd.Parameters.AddWithValue("@birthdate", txtbdate.Value)
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
        cmd.Parameters.AddWithValue("@tin", txt_tinno.Text)
        cmd.Parameters.AddWithValue("@SSSNo", txtsss.Text)
        cmd.Parameters.AddWithValue("@father", txtfather.Enabled)
        cmd.Parameters.AddWithValue("@mother", txtmother.Text)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub bttn_blacklist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_blacklist.Click
        conn()
        sql = "Select * from loans where memcode='" + txtmemcode.Text + "' and status='O'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            If MessageBox.Show("Are you sure you want to add " & txtlstname.Text & ", " & txtfname.Text & " to a blacklisted member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                conn()
                sql = "update members set midname='" + txtmname.Text & " (blacklisted)" + "'  where memcode='" + txtmemcode.Text + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Else
            MsgBox("You cannot blacklist member without loan avail.", MsgBoxStyle.Exclamation, "Message")
        End If
        rd.Close() '
        myConn.Close()
    End Sub

    Private Sub lnksig_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnksig.LinkClicked
        frm_signature.ShowDialog()
    End Sub
End Class