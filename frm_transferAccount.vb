Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_transferAccount

    Private Sub frm_transferAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_loantype()
        select_province()
        select_municipal()
        select_barangay()
        select_sitio()
    End Sub

    Private Sub view_ctr()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT ctrname,ctrcode,ctrchief,ColDayNo from Center WHERE ColDayno between 1 and 5 and GL_loans='" + txtloantype.SelectedValue + "' ORDER BY ctrcode ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Center Code")
        table1.Columns.Add("Center Name")
        table1.Columns.Add("Center Cheif")
        table1.Columns.Add("ColDayNo")
        While (rd.Read())
            table1.Rows.Add(rd("ctrcode").ToString, rd("ctrname").ToString, rd("ctrchief").ToString, rd("ColDayNo").ToString)
        End While
        rd.Close()
        myConn.Close()
        cboctr.DataSource = table1
        Me.cboctr.AutoFilter = True
        cboctr.DisplayMember = "Center Name"
        cboctr.ValueMember = "Center Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.cboctr.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.cboctr.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.cboctr.EditorControl.Columns(0).Width = 100
        Me.cboctr.EditorControl.Columns(1).Width = 200
        Me.cboctr.EditorControl.Columns(2).Width = 200
        Me.cboctr.EditorControl.Columns(3).Width = 100
        Me.cboctr.MultiColumnComboBoxElement.DropDownWidth = 600
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub gen_loantype()
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

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer where status='A'  ORDER BY fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll.DataSource = table1
        Me.txtcoll.AutoFilter = True
        txtcoll.DisplayMember = "Fullname"
        txtcoll.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll.EditorControl.Columns(0).Width = 100
        Me.txtcoll.EditorControl.Columns(1).Width = 200
        Me.txtcoll.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub view_officer1()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer WHERE status='A'  ORDER BY fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll1.DataSource = table1
        Me.txtcoll1.AutoFilter = True
        txtcoll1.DisplayMember = "Fullname"
        txtcoll1.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll1.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll1.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll1.EditorControl.Columns(0).Width = 100
        Me.txtcoll1.EditorControl.Columns(1).Width = 200
        Me.txtcoll1.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub view_officer2()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer where status='A' ORDER BY fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll2.DataSource = table1
        Me.txtcoll2.AutoFilter = True
        txtcoll2.DisplayMember = "Fullname"
        txtcoll2.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll2.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll2.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll2.EditorControl.Columns(0).Width = 100
        Me.txtcoll2.EditorControl.Columns(1).Width = 200
        Me.txtcoll2.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub view_officer3()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer where status='A' ORDER BY fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        While (rd.Read())
            table1.Rows.Add(rd("CollCode").ToString, rd("fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcoll3.DataSource = table1
        Me.txtcoll3.AutoFilter = True
        txtcoll3.DisplayMember = "Fullname"
        txtcoll3.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcoll3.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcoll3.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcoll3.EditorControl.Columns(0).Width = 100
        Me.txtcoll3.EditorControl.Columns(1).Width = 200
        Me.txtcoll3.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub lnk_byctr_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_byctr.LinkClicked
        If MessageBox.Show("Are you sure you want to transfer this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            conn()
            sql = "UPDATE loans SET collcode='" + txtcoll.SelectedValue + "' WHERE ctrcode='" + cboctr.SelectedValue + "' AND GL_loans = '" & txtloantype.SelectedValue & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            conn()
            sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Transfering center " & cboctr.SelectedValue & " to " & txtcoll.SelectedValue & " ','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            cmd.ExecuteNonQuery()
            myConn.Close()

            MsgBox("Account was successfully transfered.", MsgBoxStyle.Information, "Transfer Complete")
        End If
    End Sub

    Private Sub lnkpa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkpa.LinkClicked
        If txtcoll1.SelectedValue = txtcoll2.SelectedValue Then
            MsgBox("Transfer destination is the same account. Please select another account to transfer", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If MessageBox.Show("Are you sure you want to transfer this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                conn()
                sql = "UPDATE loans SET collcode='" + txtcoll2.SelectedValue + "' WHERE collcode='" + txtcoll1.SelectedValue + "' AND GL_loans = '" & txtloantype.SelectedValue & "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Transfering account from " & txtcoll1.SelectedValue & " to " & txtcoll2.SelectedValue & " ','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                MsgBox("Account was successfully transfered.", MsgBoxStyle.Information, "Transfer Complete")
            End If
        End If
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        view_ctr()
        view_officer()
        view_officer1()
        view_officer2()
        view_officer3()
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txtcoll1.SelectedValue = "" Then
            MsgBox("Ivalid selection of account.", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If MessageBox.Show("Are you sure you want to transfer this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                conn()
                If chksitio.Checked = True Then
                    sql = "UPDATE loans SET collcode='" + txtcoll3.SelectedValue + "' WHERE status='A' and released='Y' and memcode in (select memcode from members where provcode='" + txtprov.SelectedValue + "' and muncode='" + txtmun.SelectedValue + "' and brgycode='" + txtbrgy.SelectedValue + "' and sitcode='" + txtsitio.SelectedValue + "')"
                Else
                    sql = "UPDATE loans SET collcode='" + txtcoll3.SelectedValue + "' WHERE status='A' and released='Y' and memcode in (select memcode from members where provcode='" + txtprov.SelectedValue + "' and muncode='" + txtmun.SelectedValue + "' and brgycode='" + txtbrgy.SelectedValue + "')"
                End If
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Transfering account of " & txtbrgy.Text & ", " & txtmun.Text & " to " & txtcoll3.SelectedValue & " ','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                MsgBox("Account was successfully transfered.", MsgBoxStyle.Information, "Transfer Complete")
            End If
        End If
    End Sub

    Private Sub chksitio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksitio.CheckedChanged
        If chksitio.Checked = True Then
            txtsitio.Enabled = True
        Else
            txtsitio.Enabled = False
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

    Private Sub select_sitio()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT * FROM sitio"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("sitcode").ToString, rd("sitdesc").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtsitio.DataSource = table1
        Me.txtsitio.AutoFilter = True
        txtsitio.DisplayMember = "Description"
        txtsitio.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtsitio.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtsitio.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtsitio.EditorControl.Columns(0).Width = 100
        Me.txtsitio.EditorControl.Columns(1).Width = 250
        Me.txtsitio.MultiColumnComboBoxElement.DropDownWidth = 500
    End Sub

End Class