Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_center

    Private Sub frm_accountype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_loantype()
        gen_center()
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

    Public Sub gen_center()
        lst_center.Items.Clear()
        conn()
        sql = "SELECT ctrcode,ctrname,ctrchief,ctrdeputy,Coldayno,ctraddress,Accountnumber FROM Center WHERE ctrname LIKE'%" + txtsearch.Text.Trim + "%' or ctrcode LIKE'%" + txtsearch.Text.Trim + "%' and gl_loans='" + txtloantype.SelectedValue + "' ORDER BY ctrname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lst_center.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()

        For i As Integer = 0 To lst_center.Items.Count - 1
            If i Mod 2 Then
                lst_center.Items(i).BackColor = Color.AliceBlue
            Else
                lst_center.Items(i).BackColor = Color.White
            End If
        Next
    End Sub

    'Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        gen_center()
    '    End If
    'End Sub

    Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnnew.Click
        GL_loans = txtloantype.SelectedValue
        frm_newcenter.ShowDialog()
    End Sub

    Private Sub bttnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnedit.Click
        frm_editcenter.ShowDialog()
    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        gen_center()
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        gen_center()
    End Sub
End Class