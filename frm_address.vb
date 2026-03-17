Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_address

    Private Sub frm_barangay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_prov()
    End Sub

    Public Sub view_prov()
        Try
            conn()
            dtgrid_prov.Rows.Clear()
            sql = "SELECT * FROM province ORDER BY ProvCode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While rd.Read
                Dim x As Integer = dtgrid_prov.Rows.Add
                dtgrid_prov.Rows(x).Cells(0).Value = rd("ProvCode").ToString
                dtgrid_prov.Rows(x).Cells(1).Value = rd("Provdesc").ToString
            End While
            myConn.Close()

            For x As Integer = 0 To dtgrid_prov.Rows.Count - 1
                If x Mod 2 Then
                    dtgrid_prov.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub view_mun()
        Try
            conn()
            dtgrid_mun.Rows.Clear()
            sql = "SELECT * FROM municipal WHERE provcode='" + dtgrid_prov.CurrentRow.Cells(0).Value + "' and mundesc like'%" + txtmun.Text + "%' ORDER BY muncode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While rd.Read
                Dim x As Integer = dtgrid_mun.Rows.Add
                dtgrid_mun.Rows(x).Cells(0).Value = rd("provcode").ToString
                dtgrid_mun.Rows(x).Cells(1).Value = rd("muncode").ToString
                dtgrid_mun.Rows(x).Cells(2).Value = rd("mundesc").ToString
                dtgrid_mun.Rows(x).Cells(3).Value = rd("ZipCode").ToString
            End While
            myConn.Close()

            For x As Integer = 0 To dtgrid_mun.Rows.Count - 1
                If x Mod 2 Then
                    dtgrid_mun.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
                If dtgrid_mun.Rows(x).Cells(0).Value = "" Then
                    dtgrid_mun.Rows(x).Cells(0).Value = dtgrid_prov.CurrentRow.Cells(0).Value
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub view_barangays()
        Try
            conn()
            dtgridbrgy.Rows.Clear()
            sql = "SELECT * FROM Barangay where provcode='" + dtgrid_mun.CurrentRow.Cells(0).Value + "' and muncode='" + dtgrid_mun.CurrentRow.Cells(1).Value + "' and BrgyDesc like'%" + txtbrgy.Text + "%' ORDER BY BrgyCode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While rd.Read
                Dim x As Integer = dtgridbrgy.Rows.Add
                dtgridbrgy.Rows(x).Cells(0).Value = rd("ProvCode").ToString
                dtgridbrgy.Rows(x).Cells(1).Value = rd("MunCode").ToString
                dtgridbrgy.Rows(x).Cells(2).Value = rd("BrgyCode").ToString
                dtgridbrgy.Rows(x).Cells(3).Value = rd("BrgyDesc").ToString
            End While
            myConn.Close()

            For x As Integer = 0 To dtgridbrgy.Rows.Count - 1
                If x Mod 2 Then
                    dtgridbrgy.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If

                If dtgridbrgy.Rows(x).Cells(0).Value = "" Then
                    dtgridbrgy.Rows(x).Cells(0).Value = dtgrid_mun.CurrentRow.Cells(0).Value
                    dtgridbrgy.Rows(x).Cells(1).Value = dtgrid_mun.CurrentRow.Cells(1).Value
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub bttnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frm_addbrgy.ShowDialog()
    'End Sub

    Private Sub bttnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_editbrgy.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_addsitio.ShowDialog()
    End Sub

    Private Sub dtgridbrgy_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridbrgy.CellEndEdit
        If dtgridbrgy.CurrentRow.Cells(2).Value <> "" And dtgridbrgy.CurrentRow.Cells(3).Value <> "" Then
            conn()
            sql = "SELECT * FROM Barangay WHERE ProvCode='" + dtgrid_mun.CurrentRow.Cells(0).Value + "' and muncode='" + dtgrid_mun.CurrentRow.Cells(1).Value + "' and brgycode='" + dtgrid_mun.CurrentRow.Cells(3).Value + "' and BrgyDesc like'%" + txtsit.Text + "%' order by BrgyCode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE Barangay SET ProvCode='" + dtgridbrgy.CurrentRow.Cells(0).Value + "',MunCode='" + dtgridbrgy.CurrentRow.Cells(1).Value + "',BrgyCode='" + dtgridbrgy.CurrentRow.Cells(2).Value + "',BrgyDesc='" + dtgridbrgy.CurrentRow.Cells(3).Value + "' WHERE provcode='" + dtgridbrgy.CurrentRow.Cells(0).Value + "' and muncode='" + dtgridbrgy.CurrentRow.Cells(1).Value + "' and BrgyCode='" + dtgridbrgy.CurrentRow.Cells(2).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO Barangay (ProvCode,MunCode,BrgyCode,BrgyDesc) VALUES ('" + dtgridbrgy.CurrentRow.Cells(0).Value + "','" + dtgridbrgy.CurrentRow.Cells(1).Value + "','" + dtgridbrgy.CurrentRow.Cells(2).Value + "','" + dtgridbrgy.CurrentRow.Cells(3).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            rd.Close()
            myConn.Close()

            For x As Integer = 0 To dtgridbrgy.Rows.Count - 1
                If dtgridbrgy.Rows(x).Cells(0).Value = "" Then
                    dtgridbrgy.Rows(x).Cells(0).Value = dtgrid_mun.CurrentRow.Cells(0).Value
                    dtgridbrgy.Rows(x).Cells(1).Value = dtgrid_mun.CurrentRow.Cells(1).Value
                End If
            Next
        End If
    End Sub

    Private Sub dtgridbrgy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgridbrgy.Click
        view_sitio()
    End Sub

    Public Sub view_sitio()
        Try
            conn()
            dtgrid_sitio.Rows.Clear()
            sql = "SELECT * FROM sitio WHERE provcode='" + dtgridbrgy.CurrentRow.Cells(0).Value + "' and muncode='" + dtgridbrgy.CurrentRow.Cells(1).Value + "' and brgycode='" + dtgridbrgy.CurrentRow.Cells(2).Value + "' ORDER BY sitcode ASC"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            While rd.Read
                Dim x As Integer = dtgrid_sitio.Rows.Add
                dtgrid_sitio.Rows(x).Cells(0).Value = rd("ProvCode").ToString
                dtgrid_sitio.Rows(x).Cells(1).Value = rd("MunCode").ToString
                dtgrid_sitio.Rows(x).Cells(2).Value = rd("BrgyCode").ToString
                dtgrid_sitio.Rows(x).Cells(3).Value = rd("sitcode").ToString
                dtgrid_sitio.Rows(x).Cells(4).Value = rd("sitdesc").ToString
            End While
            myConn.Close()

            For x As Integer = 0 To dtgrid_sitio.Rows.Count - 1
                If x Mod 2 Then
                    dtgrid_sitio.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
                If dtgrid_sitio.Rows(x).Cells(0).Value = "" Then
                    dtgrid_sitio.Rows(x).Cells(0).Value = dtgridbrgy.CurrentRow.Cells(0).Value
                    dtgrid_sitio.Rows(x).Cells(1).Value = dtgridbrgy.CurrentRow.Cells(1).Value
                    dtgrid_sitio.Rows(x).Cells(2).Value = dtgridbrgy.CurrentRow.Cells(2).Value
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgridbrgy_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgridbrgy.KeyUp
        view_sitio()
    End Sub

    Private Sub dtgrid_mun_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_mun.CellEndEdit
        If dtgrid_mun.CurrentRow.Cells(1).Value <> "" And dtgrid_mun.CurrentRow.Cells(2).Value <> "" And dtgrid_mun.CurrentRow.Cells(3).Value <> "" Then
            conn()
            sql = "SELECT * FROM municipal WHERE provcode='" + dtgrid_mun.CurrentRow.Cells(0).Value + "' and MunCode='" + dtgrid_mun.CurrentRow.Cells(1).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE municipal SET ProvCode='" + dtgrid_mun.CurrentRow.Cells(0).Value + "',MunCode='" + dtgrid_mun.CurrentRow.Cells(1).Value + "',MunDesc='" + dtgrid_mun.CurrentRow.Cells(2).Value + "',ZipCode='" + dtgrid_mun.CurrentRow.Cells(3).Value + "' WHERE provcode='" + dtgrid_mun.CurrentRow.Cells(0).Value + "' and muncode='" + dtgrid_mun.CurrentRow.Cells(1).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO municipal (ProvCode,MunCode,MunDesc,ZipCode) VALUES ('" + dtgrid_mun.CurrentRow.Cells(0).Value + "','" + dtgrid_mun.CurrentRow.Cells(1).Value + "','" + dtgrid_mun.CurrentRow.Cells(2).Value + "','" + dtgrid_mun.CurrentRow.Cells(3).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            rd.Close()
            myConn.Close()

            For x As Integer = 0 To dtgrid_mun.Rows.Count - 1
                If dtgrid_mun.Rows(x).Cells(0).Value = "" Then
                    dtgrid_mun.Rows(x).Cells(0).Value = dtgrid_prov.CurrentRow.Cells(0).Value
                End If
            Next
        End If
    End Sub

    Private Sub dtgrid_mun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_mun.Click
        view_barangays()
    End Sub

    Private Sub dtgrid_mun_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgrid_mun.KeyUp
        view_barangays()
    End Sub

    Private Sub dtgrid_prov_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_prov.CellEndEdit
        If dtgrid_prov.CurrentRow.Cells(0).Value <> "" And dtgrid_prov.CurrentRow.Cells(1).Value <> "" Then
            conn()
            sql = "SELECT * FROM province WHERE provcode='" + dtgrid_prov.CurrentRow.Cells(0).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE province SET provdesc='" + dtgrid_prov.CurrentRow.Cells(1).Value + "' WHERE provcode='" + dtgrid_prov.CurrentRow.Cells(0).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO province (provcode,provdesc) VALUES ('" + dtgrid_prov.CurrentRow.Cells(0).Value + "','" + dtgrid_prov.CurrentRow.Cells(1).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            rd.Close()
            myConn.Close()
        End If
    End Sub

    Private Sub dtgrid_prov_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgrid_prov.Click
        view_mun()
    End Sub

    Private Sub dtgrid_sitio_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_sitio.CellEndEdit
        If dtgrid_sitio.CurrentRow.Cells(3).Value <> "" And dtgrid_sitio.CurrentRow.Cells(4).Value <> "" Then
            conn()
            sql = "SELECT * FROM sitio WHERE ProvCode='" + dtgrid_sitio.CurrentRow.Cells(0).Value + "' and muncode='" + dtgrid_sitio.CurrentRow.Cells(1).Value + "' and brgycode='" + dtgrid_sitio.CurrentRow.Cells(2).Value + "' and sitcode='" + dtgrid_sitio.CurrentRow.Cells(3).Value + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            If rd.Read Then
                conn()
                sql = "UPDATE sitio SET sitdesc='" + dtgrid_sitio.CurrentRow.Cells(4).Value + "' WHERE provcode='" + dtgrid_sitio.CurrentRow.Cells(0).Value + "' and muncode='" + dtgrid_sitio.CurrentRow.Cells(1).Value + "' and BrgyCode='" + dtgrid_sitio.CurrentRow.Cells(2).Value + "' and sitcode='" + dtgrid_sitio.CurrentRow.Cells(3).Value + "'"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            Else
                conn()
                sql = "INSERT INTO sitio (ProvCode,MunCode,brgycode,sitcode,sitdesc) VALUES ('" + dtgrid_sitio.CurrentRow.Cells(0).Value + "','" + dtgrid_sitio.CurrentRow.Cells(1).Value + "','" + dtgrid_sitio.CurrentRow.Cells(2).Value + "','" + dtgrid_sitio.CurrentRow.Cells(3).Value + "','" + dtgrid_sitio.CurrentRow.Cells(4).Value + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
            End If
            rd.Close()
            myConn.Close()

            For x As Integer = 0 To dtgridbrgy.Rows.Count - 1
                If dtgridbrgy.Rows(x).Cells(0).Value = "" Then
                    dtgridbrgy.Rows(x).Cells(0).Value = dtgrid_mun.CurrentRow.Cells(0).Value
                    dtgridbrgy.Rows(x).Cells(1).Value = dtgrid_mun.CurrentRow.Cells(1).Value
                End If
            Next
        End If
    End Sub

    Private Sub txtmun_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmun.KeyUp
        view_mun()
        dtgrid_mun.Rows(0).Selected = True
    End Sub

    Private Sub txtbrgy_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbrgy.KeyUp
        view_barangays()
        dtgridbrgy.Rows(0).Selected = True
    End Sub

    Private Sub txtsit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsit.KeyUp
        view_sitio()
        dtgrid_sitio.Rows(0).Selected = True
    End Sub

    Private Sub dtgrid_prov_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgrid_prov.CellContentClick

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class