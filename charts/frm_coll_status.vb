Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Charting

Public Class frm_coll_status
    Dim paramnt1 As Decimal = 0
    Dim paramnt2 As Decimal = 0
    Dim paramnt3 As Decimal = 0

    Dim [set] As New DataSet()
    Dim loanportf As New DataTable("LP")
    Dim loanrel As New DataTable("LR")
    Dim collections As New DataTable("Collections")
    Dim ttlamntpar As New DataTable("ttlamntpar")

    Private Sub frm_coll_status_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        view_officer()
        dtasof.Value = systemdate
    End Sub

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer  ORDER BY fullname ASC" 'WHERE  productcode='" + productcode.ToString + "'
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Fullname")
        table1.Rows.Add("000", "All")
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
        Me.txtcoll.MultiColumnComboBoxElement.DropDownWidth = 350
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        members_chart()
        gen_progress_rpt()
        lblheader.Text = "PROGRESS REPORT (" & txtcoll.Text & ")"
        SplashScreen.Close()
    End Sub

    Private Sub gen_progress_rpt()
        Me.progress_chartview.Series.Clear()


        [set].Tables.Add(loanportf)
        [set].Tables.Add(loanrel)
        [set].Tables.Add(collections)
        [set].Tables.Add(ttlamntpar)
        For Each table As DataTable In [set].Tables
            table.Columns.Add("Month")
            table.Columns.Add("Usage", GetType(Double))
        Next


        conn()
        sql = " SELECT SUM(y.ttllnbal1) As week1,SUM(y.ttllnbal2) As week2,SUM(y.ttllnbal3) As week3 from ("
        sql += "select (x.Totallnamnt1-x.TotalPrnPaid1) As ttllnbal1,(x.Totallnamnt2-x.TotalPrnPaid2) As ttllnbal2,(x.Totallnamnt3-x.TotalPrnPaid3) As ttllnbal3 from ( select "
        sql += "Totallnamnt1=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate <='" + dtasof.Value.AddDays(-14) + "'),0),"
        sql += "Totallnamnt2=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate <='" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "Totallnamnt3=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate <='" + dtasof.Value + "'),0),"
        sql += "TotalPrnPaid1=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid2=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid3=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value + "' AND pnnumber=a.pnnumber),0)"
        sql += " from Loans a where a.status='A' and a.released='Y' "
        If Not txtcoll.SelectedValue = "000" Then
            sql += "and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ")x "
        sql += ")y "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            loanportf.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week1").ToString)
            loanportf.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week2").ToString)
            loanportf.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week3").ToString)
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "SELECT SUM(y.ttllnbal1) As week1,SUM(y.ttllnbal2) As week2,SUM(y.ttllnbal3) As week3 from ("
        sql += "select (x.Totallnamnt1) As ttllnbal1,(x.Totallnamnt2) As ttllnbal2,(x.Totallnamnt3) As ttllnbal3 from ( select "
        sql += "Totallnamnt1=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "'),0),"
        sql += "Totallnamnt2=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "Totallnamnt3=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "'),0)"
        sql += "from Loans a where a.status='A' and a.released='Y' "
        If Not txtcoll.SelectedValue = "000" Then
            sql += "and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ")x "
        sql += ")y "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            loanrel.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week1").ToString)
            loanrel.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week2").ToString)
            loanrel.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week3").ToString)
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "SELECT SUM(y.ttllnbal1) As week1,SUM(y.ttllnbal2) As week2,SUM(y.ttllnbal3) As week3 from ("
        sql += "select (x.TotalPrnPaid1) As ttllnbal1,(x.TotalPrnPaid2) As ttllnbal2,(x.TotalPrnPaid3) As ttllnbal3 from ( select "
        sql += "TotalPrnPaid1=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid2=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid3=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "' AND pnnumber=a.pnnumber),0)"
        sql += "from Loans a where  a.released='Y' "
        If Not txtcoll.SelectedValue = "000" Then
            sql += "and a.collcode='" + txtcoll.SelectedValue.ToString + "' and loantype='" + productcode.ToString + "'"
        End If
        sql += ")x "
        sql += ")y "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            collections.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week1").ToString)
            collections.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week2").ToString)
            collections.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week3").ToString)
        End If
        rd.Close()
        myConn.Close()

        'PARamnt
        ttlamntpar.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), paramnt1.ToString)
        ttlamntpar.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), paramnt2.ToString)
        ttlamntpar.Rows.Add(dtasof.Value.ToString("MMM - dd"), paramnt3.ToString)

        Me.progress_chartview.DataSource = [set]


        Dim lpSeries As New BarSeries("Usage", "Month")
        lpSeries.DataMember = "LP"
        lpSeries.LegendTitle = "Loan Portfolio"
        lpSeries.ShowLabels = True

        Dim lrSeries As New BarSeries("Usage", "Month")
        lrSeries.DataMember = "LR"
        lrSeries.LegendTitle = "Loan Amnt Released"
        lrSeries.ShowLabels = True

        Dim collSeries As New BarSeries("Usage", "Month")
        collSeries.DataMember = "Collections"
        collSeries.LegendTitle = "Collections"
        collSeries.ShowLabels = True

        Dim ttlamntparSeries As New BarSeries("Usage", "Month")
        ttlamntparSeries.DataMember = "ttlamntpar"
        ttlamntparSeries.LegendTitle = "Total Amount PAR"
        ttlamntparSeries.ShowLabels = True

        Me.progress_chartview.ChartElement.LegendPosition = DirectCast(Bottom, LegendPosition)
        Me.progress_chartview.View.Palette = KnownPalette.Metro
        Me.progress_chartview.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        'Me.progress_chartview.Title = "WEEKLY PROGRESS REPORT (LOAN PORTFOLIO)"
        Me.progress_chartview.Series.AddRange(lpSeries, lrSeries, collSeries, ttlamntparSeries)
    End Sub

    Private Sub members_chart()
        Me.memberschartview.Series.Clear()
        Me.memberschartview.View.Palette = KnownPalette.Summer

        Dim [set] As New DataSet()
        Dim members As New DataTable("Members")
        Dim lnacctrel As New DataTable("lnacctrel")
        Dim memPAR As New DataTable("memPAR")

        [set].Tables.Add(members)
        [set].Tables.Add(lnacctrel)
        [set].Tables.Add(memPAR)
        For Each table As DataTable In [set].Tables
            table.Columns.Add("Month")
            table.Columns.Add("Usage", GetType(Double))
        Next
        conn()
        If Not txtcoll.SelectedValue = "000" Then
            sql = "select x.* from(select "
            sql += "week1=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and ccheckdate<='" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "week2=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and ccheckdate<='" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "week3=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and ccheckdate<='" + dtasof.Value + "'),0)"
            sql += " from loans a "
            sql += "where a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        Else
            sql = "select x.* from(select "
            sql += "week1=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and ccheckdate<='" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "week2=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and ccheckdate<='" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "week3=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and ccheckdate<='" + dtasof.Value + "'),0)"
            sql += " from loans a "
        End If
        sql += ")x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            members.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week1").ToString)
            members.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week2").ToString)
            members.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week3").ToString)
        End If
        rd.Close()
        myConn.Close()

        conn()
        If Not txtcoll.SelectedValue = "000" Then
            sql = "select (x.Totallnrel1) As week1,(x.Totallnrel2) As week2,(x.Totallnrel3) As week3 from ( select "
            sql += "Totallnrel1=isnull((select count(pnnumber) from loans where collcode=a.collcode and ccheckdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "Totallnrel2=isnull((select count(pnnumber) from loans where collcode=a.collcode and ccheckdate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "Totallnrel3=isnull((select count(pnnumber) from loans where collcode=a.collcode and ccheckdate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "'),0)"
            sql += "from Loans a where a.status='A' and a.released='Y' and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        Else
            sql = "select (x.Totallnrel1) As week1,(x.Totallnrel2) As week2,(x.Totallnrel3) As week3 from ( select "
            sql += "Totallnrel1=isnull((select count(pnnumber) from loans where ccheckdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "Totallnrel2=isnull((select count(pnnumber) from loans where ccheckdate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "Totallnrel3=isnull((select count(pnnumber) from loans where ccheckdate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "'),0)"
            sql += "from Loans a where a.status='A' and a.released='Y'"
        End If
        sql += ")x "
        sql += " group by x.Totallnrel1,x.Totallnrel2,x.Totallnrel3 "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            lnacctrel.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week1").ToString)
            lnacctrel.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week2").ToString)
            lnacctrel.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week3").ToString)
        End If
        rd.Close()
        myConn.Close()

        'ttlmem_PAR
        conn()
        sql = "select count(y.pnnumber) ttlmempar,sum(Loanbal) as Loanbal from ("
        sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.TotalPrnPaid-x.totalprndue) <= 0.01) then datediff(day,x.Duedate,'" + dtasof.Value.AddDays(-14) + "') else (case when ((x.TotalIntPaid-x.totalintdue)<=0.01) then datediff(day,x.Duedate,'" + dtasof.Value.AddDays(-14) + "') else 0 end)  end as PARDays from ("
        sql += " select a.pnnumber,a.prnloan,"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value.AddDays(-14) + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value.AddDays(-14) + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(prnpaid+advprincipal) from LoanCollect where trnxdate<='" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(prnpaid+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where a.MemCode=b.MemCode and a.released='Y' AND a.Loantype='" + productcode.ToString + "'"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.CollCode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ") x"
        sql += ") y where y.PARdays>0 and y.Loanbal>0"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            memPAR.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("ttlmempar").ToString)
            paramnt1 = rd("Loanbal").ToString
        End If
        rd.Close()
        myConn.Close()

        'ttlmem_PAR
        conn()
        sql = "select count(y.pnnumber) ttlmempar,sum(Loanbal) as Loanbal from ("
        sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.TotalPrnPaid-x.totalprndue) <= 0.01) then datediff(day,x.Duedate,'" + dtasof.Value.AddDays(-7) + "') else (case when ((x.TotalIntPaid-x.totalintdue)<=0.01) then datediff(day,x.Duedate,'" + dtasof.Value.AddDays(-7) + "') else 0 end)  end as PARDays from ("
        sql += " select a.pnnumber,a.prnloan,"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(prnpaid+advprincipal) from LoanCollect where trnxdate<='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(prnpaid+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where a.MemCode=b.MemCode and a.released='Y' AND a.Loantype='" + productcode.ToString + "'"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.CollCode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ") x"
        sql += ") y where y.PARdays>0 and y.Loanbal>0"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            memPAR.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("ttlmempar").ToString)
            paramnt2 = rd("Loanbal").ToString
        End If
        rd.Close()
        myConn.Close()

        'ttlmem_PAR
        conn()
        sql = "select count(y.pnnumber) ttlmempar,sum(Loanbal) as Loanbal from ("
        sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.TotalPrnPaid-x.totalprndue) <= 0.01) then datediff(day,x.Duedate,'" + dtasof.Value + "') else (case when ((x.TotalIntPaid-x.totalintdue)<=0.01) then datediff(day,x.Duedate,'" + dtasof.Value + "') else 0 end)  end as PARDays from ("
        sql += " select a.pnnumber,a.prnloan,"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(prnpaid+advprincipal) from LoanCollect where trnxdate<='" + dtasof.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + dtasof.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(prnpaid+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtasof.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where a.MemCode=b.MemCode and a.released='Y' AND a.Loantype='" + productcode.ToString + "'"
        If Not txtcoll.SelectedValue = "000" Then
            sql += " and a.CollCode='" + txtcoll.SelectedValue.ToString + "'"
        End If
        sql += ") x"
        sql += ") y where y.PARdays>0 and y.Loanbal>0"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            memPAR.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("ttlmempar").ToString)
            paramnt3 = rd("Loanbal").ToString
        End If
        rd.Close()
        myConn.Close()

        Me.memberschartview.DataSource = [set]

        Dim memberSeries As New BarSeries("Usage", "Month")
        memberSeries.DataMember = "Members"
        memberSeries.LegendTitle = "Members"
        memberSeries.ShowLabels = True

        Dim lnacctRelSeries As New BarSeries("Usage", "Month")
        lnacctRelSeries.DataMember = "lnacctrel"
        lnacctRelSeries.LegendTitle = "Loan Acct Released"
        lnacctRelSeries.ShowLabels = True

        Dim memPARSeries As New BarSeries("Usage", "Month")
        memPARSeries.DataMember = "memPAR"
        memPARSeries.LegendTitle = "PAR Members"
        memPARSeries.ShowLabels = True

        'Me.memberschartview.Title = "WEEKLY PROGRESS REPORT (MEMBERS)"
        Me.memberschartview.Series.AddRange(memberSeries, lnacctRelSeries, memPARSeries)
        Me.memberschartview.ChartElement.LegendPosition = DirectCast(Bottom, LegendPosition)
        Me.memberschartview.View.Palette = KnownPalette.Lilac
        Me.memberschartview.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal

    End Sub
End Class