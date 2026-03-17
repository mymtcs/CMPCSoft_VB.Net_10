Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization

Public Class frm_select_savingsACC
    Public membercode As String = ""

    Private Sub frm_select_savingsACC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_sa()
        bttnselect.Enabled = True
    End Sub

    Private Sub display_sa()
        conn()
        'MessageBox.Show(GL_sa, "GL_sa")
        'MessageBox.Show(membercode, "membercode")

        dtgridsaving.Rows.Clear()
        sql = "select x.* from(select a.memcode,a.Accountnumber,CONVERT(VARCHAR(10),a.dateopen,101) As dateopen,a.accountstatus,a.AccountType, "
        sql += "accountname=(select fullname from members where memcode=a.memcode),"
        sql += "DateClosed=isnull((select DateClosed from accountmaster where accountnumber=a.accountnumber),'" + systemdate.AddYears(999) + "'),"
        sql += "Address=isnull((select address from members where memcode=a.memcode),(select ctraddress from center where accountnumber=a.accountnumber and a.accountnumber<>'')),"
        sql += "acctbalance=isnull((select sum(debit-credit) from accountledger where accountnumber=a.Accountnumber and active='Y'),0)"
        sql += " FROM AccountMaster a where a.gl_sa='" & GL_sa & "' "
        sql += ")x WHERE x.memcode = '" & membercode & "' GROUP BY x.memcode,x.DateClosed,x.acctbalance,x.Accountnumber,x.accountname,x.Address,x.dateopen,x.accountstatus,x.AccountType ORDER BY x.AccountType,x.accountname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            If rd("DateClosed") <= systemdate Then
                dtgridsaving.Rows.Add(rd("Accountnumber").ToString, rd("accountname").ToString, String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("acctbalance")), Date.Parse(rd("dateopen")), "Closed", rd("AccountType").ToString)
            Else
                dtgridsaving.Rows.Add(rd("Accountnumber").ToString, rd("accountname").ToString, String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", rd("acctbalance")), Date.Parse(rd("dateopen")), "Active", rd("AccountType").ToString)
            End If
        End While
        rd.Close()
        myConn.Close()

        For x As Integer = 0 To dtgridsaving.Rows.Count - 1
            If x Mod 2 Then
                dtgridsaving.Rows(x).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
            Dim row As DataGridViewRow = dtgridsaving.Rows(x)
            row.Height = 25 '30
        Next
        dtgridsaving.ClearSelection()
    End Sub

    Private Sub bttnselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnselect.Click
        If dtgridsaving.CurrentRow.Cells(4).Value = "Active" And dtgridsaving.CurrentRow.Cells(5).Value = "PS" Then
            frm_loanProcess_grp.txtsaacct.Text = dtgridsaving.CurrentRow.Cells(0).Value
            frm_loanProcess_indv.txtsaacct.Text = dtgridsaving.CurrentRow.Cells(0).Value
            Me.Close()
        Else
            MsgBox("Invalid savings selection.")
        End If
    End Sub

    Private Sub bttncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_Validated(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboletter_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        display_sa()
    End Sub

    Private Sub dtgridsaving_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridsaving.CellClick
        bttnselect.Enabled = True
    End Sub

    Private Sub dtgridsaving_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgridsaving.CellContentClick

    End Sub
End Class