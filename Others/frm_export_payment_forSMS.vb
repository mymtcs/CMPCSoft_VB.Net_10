Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports System.ComponentModel
Imports Telerik.WinControls.Data

Public Class frm_export_payment_forSMS

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        displayaverage()
    End Sub

    Private Sub displayaverage()
        conn()
        sql = "select x.mobileno,('Your payment of " & Format(dtpick.Value, "MMM") & "." & dtpick.Value.Day & " has been posted w/ amount of ' + cast(x.amntpaid as varchar(10))) as smscontent,x.fullname,x.amntpaid from (select a.mobileno,a.fullname,"
        sql += "amntpaid=isnull((select sum(prnpaid+intpaid+savings+cf+advprincipal+advinterest+ssscont) from loancollect where pnnumber=b.pnnumber and trnxdate='" & dtpick.Value & "'),0),"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=b.pnnumber),0),"
        sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=b.pnnumber),0),"
        sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<='" & dtpick.Value & "' and pnnumber=b.pnnumber),0),"
        sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where trnxdate<='" & dtpick.Value & "' and pnnumber=b.pnnumber),0) "
        sql += " from members a,loans b where a.memcode=b.memcode and b.gl_loans='1050-03')x where x.amntpaid>0 and x.mobileno<>'' order by x.fullname"

        'sql = "SELECT a.payno,CONVERT(VARCHAR(10),a.trnxdate,101) As trnxdate,CONVERT(VARCHAR(10),a.collectiondate,101) As collectiondate,a.prnum,a.prndue,a.principal,a.AdvPrincipal,a.intdue,a.intpaid,a.AdvInterest,a.savings,a.CF,a.prnduebalance,a.intduebalance,a.runningbalance,a.userid,a.remarks FROM LoanCollect a ORDER BY payno"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        lstcbu.Items.Clear()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lvitem.SubItems.Add(dtpick.Value)
            lstcbu.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub cryptaverage()
        conn()
        sql = "select x.cbuaccount,x.fullname,x.bal,(sum(x.Debit*datediffer)/12) as dev from(select a.cbuaccount,a.PostingDate,a.Debit,"
        sql += "datediffer=datediff(month,PostingDate,'" + dtpick.Value + "')+1,"
        sql += "fullname=(select fullname from members where cbuaccount=a.cbuaccount),"
        sql += "bal=isnull((select sum(debit-credit) from cbuledger where cbuaccount=a.cbuaccount),0)"
        sql += " from cbuledger a)x where x.PostingDate<='" + dtpick.Value + "' and x.bal>0 group by x.cbuaccount,x.fullname,x.bal order by x.fullname"

        'sql = "SELECT a.payno,CONVERT(VARCHAR(10),a.trnxdate,101) As trnxdate,CONVERT(VARCHAR(10),a.collectiondate,101) As collectiondate,a.prnum,a.prndue,a.principal,a.AdvPrincipal,a.intdue,a.intpaid,a.AdvInterest,a.savings,a.CF,a.prnduebalance,a.intduebalance,a.runningbalance,a.userid,a.remarks FROM LoanCollect a ORDER BY payno"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        lstcrypt.Items.Clear()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            'lvitem.SubItems.Add(0)
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstcrypt.Items.Add(lvitem)
            lvitem.EnsureVisible()
        End While
        rd.Close()
        myConn.Close()
    End Sub

    Private Sub bttnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnexport.Click
        'cryptaverage()
        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .FileName = branch & " exported payment for SMS of " & dtpick.Value.ToString("M.dd.yy") & "_" & lstcbu.Items.Count
            .InitialDirectory = "C:\"
            .Filter = ("ONLY Text Files (*.txt) | *.csv")
        End With

        If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Write As New IO.StreamWriter(sfile.FileName)
            Dim k As ListView.ColumnHeaderCollection = lstcbu.Columns
            For Each x As ListViewItem In lstcbu.Items
                Dim StrLn As String = ""
                For i = 0 To x.SubItems.Count - 1
                    StrLn += x.SubItems(i).Text + "_"
                Next
                Write.WriteLine(StrLn)
            Next
            Write.Close() 'Or  Write.Flush()
            MsgBox("Export completed.", MsgBoxStyle.Information, "Message")
        End If
    End Sub

    Private Sub frm_export_payment_forSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpick.Value = Date.Today
    End Sub
End Class