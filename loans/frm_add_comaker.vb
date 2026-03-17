Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frm_add_comaker
    Public comboCol2 As New GridViewMultiComboBoxColumn("Beneficiary")

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn()
        sql = "delete from LoanComaker where PnNumber='" + loannumber + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        conn()
        sql = "INSERT INTO LoanComaker(PnNumber,CoMaker,CMkrAddress,ContactNumber,GL_loans) VALUES ('" + loannumber + "','" + txtcomaker.Text + "','" + txtcoaddress.Text + "','" + txtcocontact.Text + "','" + GL_loans + "')"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()

        insert_benefeciary()
        MsgBox("Savings complete.", MsgBoxStyle.Information, "Message")
    End Sub

    Private Sub insert_benefeciary()
        conn()
        sql = "DELETE FROM Beneficiary WHERE pnnumber='" + loannumber + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        cmd.ExecuteNonQuery()
        For i As Integer = 0 To dtgr_benefeciary.Rows.Count - 1
            If dtgr_benefeciary.Rows(i).Cells(0).Value <> "" Then
                conn()
                sql = "INSERT INTO Beneficiary(pnnumber,fullname,birthdate,relationship) VALUES ('" + loannumber + "','" + dtgr_benefeciary.Rows(i).Cells(0).Value + "','" + dtgr_benefeciary.Rows(i).Cells(1).Value + "','" + dtgr_benefeciary.Rows(i).Cells(2).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
        Next
    End Sub

    Private Sub frm_add_comaker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn()
        sql = "select a.* from loancomaker a, loans b where a.pnnumber=b.pnnumber and b.pnnumber='" + loannumber + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            txtcomaker.Text = rd("CoMaker").ToString
            txtcoaddress.Text = rd("CMkrAddress").ToString
            txtcocontact.Text = rd("ContactNumber").ToString
        End If
        rd.Close()
        myConn.Close()
        creategview_beneficiary()
    End Sub

    Public Sub creategview_beneficiary()
        'InitializeComponent()
        dtgr_benefeciary.Columns.Clear()
        dtgr_benefeciary.Rows.Clear()

        Dim beneficiary As DataTable = New DataTable()
        'conn()
        'sql = "SELECT * from deductionMF"
        'cmd = New SqlCommand(sql, myConn)
        'myConn.Open()
        'rd = cmd.ExecuteReader()
        beneficiary.Columns.Add("Code")
        beneficiary.Columns.Add("Relationship")
        'While (rd.Read())
        beneficiary.Rows.Add(1, "Father")
        beneficiary.Rows.Add(2, "Mother")
        beneficiary.Rows.Add(3, "Daughter")
        beneficiary.Rows.Add(4, "Son")
        beneficiary.Rows.Add(5, "Sister")
        beneficiary.Rows.Add(6, "Brother")
        beneficiary.Rows.Add(7, "Husband")
        beneficiary.Rows.Add(8, "Wife")
        'End While
        'rd.Close()
        'myConn.Close()

        '0
        Dim fullname As New GridViewTextBoxColumn("Fullname")
        Me.dtgr_benefeciary.MasterTemplate.AutoGenerateColumns = False
        dtgr_benefeciary.Columns.Add(fullname)
        fullname.Width = 250

        '1
        Dim bdate As New GridViewTextBoxColumn("Birthdate")
        Me.dtgr_benefeciary.MasterTemplate.AutoGenerateColumns = False
        dtgr_benefeciary.Columns.Add(bdate)
        bdate.Width = 250

        '2
        comboCol2.DataSource = beneficiary
        comboCol2.FieldName = "Relationship"
        comboCol2.DisplayMember = "Relationship"
        comboCol2.ValueMember = "Relationship"
        comboCol2.Width = 200
        comboCol2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        dtgr_benefeciary.Columns.Add(comboCol2)

        'If Me.Text = "Edit Loan" Or Me.Text = "View Loan" Then
        conn()
        sql = "SELECT * FROM Beneficiary WHERE pnnumber='" + loannumber + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            dtgr_benefeciary.Rows.Add(rd("fullname").ToString, rd("birthdate").ToString, rd("relationship").ToString)
        End While
        rd.Close()
        myConn.Close()
        'End If
    End Sub
End Class