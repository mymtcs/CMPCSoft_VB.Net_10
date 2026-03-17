Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frm_PAR
    Private cntr As String
    Private collcode As String
    Private ctrcode As String

    Private Sub frmpar_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_coll()
        gendate.Value = systemdate
    End Sub

    Private Sub select_coll()
        'Try
        conn()
        sql = "select fullname from officer where status='A' order by fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        txtcoll.Items.Clear()
        txtcoll.Items.Add("All")
        While rd.Read()
            txtcoll.Items.Add(rd.Item("fullname"))
        End While
        myConn.Close()
        'Catch ex As Exception
        'myConn.Close()
        'End Try
    End Sub

    Private Sub select_center()
        'Try
        Call conn()
        sql = "select ctrchief from center order by ctrchief ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        txtcoll.Items.Clear()
        txtcoll.Items.Add("All")
        While rd.Read()
            txtcoll.Items.Add(rd.Item("ctrchief"))
        End While
        myConn.Close()
        'Catch ex As Exception
        'myConn.Close()
        'End Try
    End Sub

    Private Sub generate_PAR()
        'REPORT OBJECT
        Dim MyRpt As New portfolio_at_risk

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("str16", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        For Each LVI As ListViewItem In lstpar.Items
            row = DS.Tables(0).NewRow
            row(0) = LVI.SubItems(3).Text
            Try
                row(1) = LVI.SubItems(0).Text
            Catch ex As Exception
                row(1) = 0
            End Try
            Try
                If Double.Parse(LVI.SubItems(1).Text) < 1 Then
                    row(2) = 0
                Else
                    row(2) = LVI.SubItems(1).Text
                End If
            Catch ex As Exception
                row(2) = 0
            End Try
            Try
                If Double.Parse(LVI.SubItems(2).Text) < 0 Then
                    row(3) = 0
                Else
                    row(3) = LVI.SubItems(2).Text
                End If

            Catch ex As Exception
                row(3) = 0
            End Try
            row(4) = CompName.ToString
            row(5) = compaddress.ToString
            row(6) = gendate.Value
            row(7) = productcode.ToString
            DS.Tables(0).Rows.Add(row)
        Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtcoll.Text <> "" Then
            SplashScreen.count = 0
            Control.CheckForIllegalCrossThreadCalls = False
            thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
            thread.Start()
            Dim dfrom As Integer = 0
            Dim dto As Integer = 30
            lstpar.Items.Clear()
            conn()
            For i As Integer = 0 To 4
                sql = "select count(y.activemembers) As ttlmember,sum(y.PrnPar) as amntoverdue,sum(y.loanbal) as loanbal from ("
                sql += "select x.*,(x.pnnumber) As activemembers,((x.prnamnt)-x.TotalPrnPaid)as Loanbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.TotalPrnPaid-x.totalprndue) <= 0.01) then datediff(day,x.Duedate,'" + gendate.Value + "') else (case when ((x.TotalIntPaid-x.totalintdue)<=0.01) then datediff(day,x.Duedate,'" + gendate.Value + "') else 0 end)  end as PARDays from ("
                sql += "select a.pnnumber,a.Memcode,a.loandate,a.interestdue,a.loantype,GL_loans,"
                sql += "prnamnt=isnull((select top 1 rngprin from loansched where pnnumber=a.pnnumber order by LnNum DESC),0),"
                sql += "Collname=(select fullname from officer where collcode=a.collcode),"
                sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
                sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
                sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
                sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
                sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
                sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(prnpaid+advprincipal) FROM LoanCollect WHERE trnxdate<='" + gendate.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
                sql += "from Loans a where  a.released='Y' AND a.status<>'X'"
                If cboption.Text = "Product Assistant" Then
                    If txtcoll.Text <> "All" Then
                        sql += " and a.CollCode='" + collcode.ToString + "'"
                    End If
                Else
                    If txtcoll.Text <> "All" Then
                        sql += " and a.ctrcode='" + ctrcode.ToString + "'"
                    End If
                End If
                sql += ") x  WHERE x.DateClosed>'" + gendate.Value + "' ) y "
                If i = 0 Then
                    sql += "where y.PARdays < 0.01"
                ElseIf i < 4 And i > 0 Then
                    sql += "where y.PARdays > " + dfrom.ToString + " and  y.PARdays <= " + dto.ToString + " and y.Totalprndue>y.TotalPrnPaid"
                ElseIf i = 4 Then
                    sql += "where y.PARdays > " + dfrom.ToString + " and y.Totalprndue>y.TotalPrnPaid"
                End If
                sql += " and y.GL_loans='" + GL_loans + "' and y.loanbal >0"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader()
                If rd.Read Then
                    Dim lvitem As New ListViewItem(rd("ttlmember").ToString)
                    lvitem.SubItems.Add(rd("amntoverdue").ToString)
                    lvitem.SubItems.Add(rd("loanbal").ToString)
                    If i = 0 Then
                        lvitem.SubItems.Add("Current")
                    ElseIf i = 1 Then
                        lvitem.SubItems.Add("1-" & dto.ToString & " days")
                    ElseIf i = 2 Then
                        lvitem.SubItems.Add("31-" & dto.ToString & " days")
                    ElseIf i = 3 Then
                        lvitem.SubItems.Add("61-" & dto.ToString & " days")
                    ElseIf i = 4 Then
                        lvitem.SubItems.Add("Over " & dfrom.ToString & " days")
                    End If
                    lstpar.Items.Add(lvitem)
                End If
                rd.Close()
                myConn.Close()

                If i > 0 Then
                    dfrom = dfrom + 30
                    dto = dto + 30
                End If
            Next
            generate_PAR()
            SplashScreen.Close()
        End If
    End Sub

    Private Sub txtcoll_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcoll.SelectedIndexChanged
        If cboption.Text = "Product Assistant" Then
            Call conn()
            sql = "SELECT CollCode FROM officer WHERE fullname='" + txtcoll.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            If rd.Read Then
                collcode = rd("CollCode").ToString
            End If
            myConn.Close()
        Else
            Call conn()
            sql = "SELECT ctrcode FROM Center WHERE ctrchief='" + txtcoll.Text + "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader()
            If rd.Read Then
                ctrcode = rd("ctrcode").ToString
            End If
            myConn.Close()
        End If
    End Sub

    Private Sub cboption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboption.SelectedIndexChanged
        If cboption.Text = "Product Assistant" Then
            select_coll()
            lblcode.Text = "Coll Code :"
        Else
            select_center()
            lblcode.Text = "Ctr Code :"
        End If
    End Sub
End Class