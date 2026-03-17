Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_restructured_loan

    Private Sub frm_restructured_loan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_members()
    End Sub

    Private Sub display_members()
        conn()
        sql = "select x.*,(x.runbal-x.TotalamntPaid) as runbal,x.monthno from (select a.memcode,a.fullname,a.address,b.pnnumber,b.releasedate,b.maturitydate,"
        sql += "monthno=isnull((datediff(month, b.maturitydate,'" & systemdate & "')),0),"
        sql += "runbal=isnull((select sum(Principal+Interest) from loansched where pnnumber=b.pnnumber),0),"
        sql += "TotalamntPaid=isnull((SELECT SUM(principal+advprincipal+intpaid+advinterest) from LoanCollect where trnxdate<='" & systemdate & "' and cancel='N' AND pnnumber=b.pnnumber),0)"
        sql += " from members a, loans b where a.memcode=b.memcode and b.gl_loans='1050-04')x where x.monthno>12 and (x.runbal-x.TotalamntPaid)>0 and x.fullname like '%" & txtsearch.Text.Trim & "%' order by x.monthno"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        dtgrd_members.Rows.Clear()
        While rd.Read
            dtgrd_members.Rows.Add(rd("memcode"), rd("fullname"), rd("address"), Date.Parse(rd("releasedate")).ToString("M/dd/yyyy"), Date.Parse(rd("maturitydate")).ToString("M/dd/yyyy"), rd("runbal"), rd("monthno"))
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub txtsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            display_members()
        End If
    End Sub
End Class