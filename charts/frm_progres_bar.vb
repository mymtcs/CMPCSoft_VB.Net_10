Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Charting
Imports System.Drawing.Printing

Public Class frm_progres_bar
    'Dim paramnt1 As Decimal = 0
    'Dim paramnt2 As Decimal = 0
    Dim paramnt3 As Decimal = 0
    Dim paramnt4 As Decimal = 0
    Dim day1 As Integer = 0
    Dim day2 As Integer = 0

    Private Sub frm_progres_bar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        view_officer()
        dtasof.Value = systemdate
    End Sub

    Private Sub view_officer()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT CollCode,fullname FROM Officer WHERE  gl_loans='" + GL_loans + "'  ORDER BY fullname ASC"
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
        RadButton1.Enabled = True
    End Sub

    Private Sub gen_progress_rpt()
        Me.progress_chartview.Series.Clear()

        Dim [set] As New DataSet()
        Dim loanportf As New DataTable("LP")
        Dim loanrel As New DataTable("LR")
        Dim collections As New DataTable("Collections")
        Dim ttlamntpar As New DataTable("ttlamntpar")

        [set].Tables.Add(loanportf)
        [set].Tables.Add(loanrel)
        [set].Tables.Add(collections)
        [set].Tables.Add(ttlamntpar)

        For Each table As DataTable In [set].Tables
            table.Columns.Add("Month")
            table.Columns.Add("Usage", GetType(Double))
        Next

        conn()
        sql = " SELECT SUM(y.ttllnbal3) As week3,SUM(y.ttllnbal4) As week4 from ("
        sql += "select (x.Totallnamnt3-x.TotalPrnPaid3) As ttllnbal3,(x.Totallnamnt4-x.TotalPrnPaid4) As ttllnbal4 from ( select "
        'sql += "Totallnamnt1=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate <='" + dtasof.Value.AddDays(-21) + "'),0),"
        'sql += "Totallnamnt2=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate <='" + dtasof.Value.AddDays(-14) + "'),0),"
        sql += "Totallnamnt3=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and releasedate <='" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "Totallnamnt4=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and releasedate <='" + dtasof.Value + "'),0),"
        sql += "TotalPrnPaid1=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value.AddDays(-21) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid2=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid3=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid4=isnull((select sum(prnpaid+advprincipal) from LoanCollect where CONVERT(DATETIME,FLOOR(convert(float,trnxdate))) <='" + dtasof.Value + "' AND pnnumber=a.pnnumber),0)"
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
            'loanportf.Rows.Add(dtasof.Value.AddDays(-21).ToString("MMM - dd"), rd("week1").ToString)
            'loanportf.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week2").ToString)
            loanportf.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week3").ToString)
            loanportf.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week4").ToString)
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "SELECT SUM(y.ttllnbal3) As week3,SUM(y.ttllnbal4) As week4 from ("
        sql += "select (x.Totallnamnt3) As ttllnbal3,(x.Totallnamnt4) As ttllnbal4 from ( select "
        'sql += "Totallnamnt1=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate between '" + dtasof.Value.AddDays(-28) + "' and '" + dtasof.Value.AddDays(-21) + "'),0),"
        'sql += "Totallnamnt2=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and ccheckdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "'),0),"
        sql += "Totallnamnt3=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and releasedate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "Totallnamnt4=isnull((select sum(loanamnt) from loans where pnnumber=a.pnnumber and releasedate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "'),0)"
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
            'loanrel.Rows.Add(dtasof.Value.AddDays(-21).ToString("MMM - dd"), rd("week1").ToString)
            'loanrel.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week2").ToString)
            loanrel.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week3").ToString)
            loanrel.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week4").ToString)
        End If
        rd.Close()
        myConn.Close()

        conn()
        sql = "SELECT SUM(y.ttllnbal3) As week3,SUM(y.ttllnbal3) As week4 from ("
        sql += "select (x.TotalPrnPaid3) As ttllnbal3,(x.TotalPrnPaid4) As ttllnbal4 from ( select "
        'sql += "TotalPrnPaid1=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-28) + "' and '" + dtasof.Value.AddDays(-21) + "' AND pnnumber=a.pnnumber),0),"
        'sql += "TotalPrnPaid2=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid3=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPrnPaid4=isnull((select sum(prnpaid+advprincipal) from LoanCollect where trnxdate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "' AND pnnumber=a.pnnumber),0)"
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
            'collections.Rows.Add(dtasof.Value.AddDays(-21).ToString("MMM - dd"), rd("week1").ToString)
            'collections.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week2").ToString)
            collections.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week3").ToString)
            collections.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week4").ToString)
        End If
        rd.Close()
        myConn.Close()

        'PARamnt
        'ttlamntpar.Rows.Add(dtasof.Value.AddDays(-21).ToString("MMM - dd"), paramnt1.ToString)
        'ttlamntpar.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), paramnt2.ToString)
        ttlamntpar.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), paramnt3.ToString)
        ttlamntpar.Rows.Add(dtasof.Value.ToString("MMM - dd"), paramnt4.ToString)

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
        Me.progress_chartview.Series.AddRange(lpSeries, lrSeries, collSeries, ttlamntparSeries)
        Me.progress_chartview.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        'Me.progress_chartview.Title = "WEEKLY PROGRESS REPORT (LOAN PORTFOLIO)"

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
            'sql += "week1=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and ccheckdate<='" + dtasof.Value.AddDays(-21) + "'),0),"
            'sql += "week2=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and ccheckdate<='" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "week3=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and releasedate<='" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "week4=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where collcode=a.collcode and status='A' and releasedate<='" + dtasof.Value + "'),0)"
            sql += " from loans a "
            sql += "where a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        Else
            sql = "select x.* from(select "
            'sql += "week1=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and ccheckdate<='" + dtasof.Value.AddDays(-21) + "'),0),"
            'sql += "week2=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and ccheckdate<='" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "week3=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and releasedate<='" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "week4=isnull((SELECT (count(memcode)) as ttlmem FROM Loans where status='A' and releasedate<='" + dtasof.Value + "'),0)"
            sql += " from loans a "
        End If
        sql += ")x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            'members.Rows.Add(dtasof.Value.AddDays(-21).ToString("MMM - dd"), rd("week1").ToString)
            'members.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week2").ToString)
            members.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week3").ToString)
            members.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week4").ToString)
        End If
        rd.Close()
        myConn.Close()

        conn()
        If Not txtcoll.SelectedValue = "000" Then
            sql = "select (x.Totallnrel3) As week3,(x.Totallnrel4) As week4 from ( select "
            'sql += "Totallnrel1=isnull((select count(pnnumber) from loans where collcode=a.collcode and ccheckdate between '" + dtasof.Value.AddDays(-28) + "' and '" + dtasof.Value.AddDays(-21) + "'),0),"
            'sql += "Totallnrel2=isnull((select count(pnnumber) from loans where collcode=a.collcode and ccheckdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "Totallnrel3=isnull((select count(pnnumber) from loans where collcode=a.collcode and releasedate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "Totallnrel4=isnull((select count(pnnumber) from loans where collcode=a.collcode and releasedate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "'),0)"
            sql += "from Loans a where a.status='A' and a.released='Y' and a.collcode='" + txtcoll.SelectedValue.ToString + "'"
        Else
            sql = "select (x.Totallnrel3) As week3,(x.Totallnrel4) As week4 from ( select "
            'sql += "Totallnrel1=isnull((select count(pnnumber) from loans where ccheckdate between '" + dtasof.Value.AddDays(-28) + "' and '" + dtasof.Value.AddDays(-21) + "'),0),"
            'sql += "Totallnrel2=isnull((select count(pnnumber) from loans where ccheckdate between '" + dtasof.Value.AddDays(-21) + "' and '" + dtasof.Value.AddDays(-14) + "'),0),"
            sql += "Totallnrel3=isnull((select count(pnnumber) from loans where releasedate between '" + dtasof.Value.AddDays(-14) + "'  and '" + dtasof.Value.AddDays(-7) + "'),0),"
            sql += "Totallnrel4=isnull((select count(pnnumber) from loans where releasedate between '" + dtasof.Value.AddDays(-7) + "' and '" + dtasof.Value + "'),0)"
            sql += "from Loans a where a.status='A' and a.released='Y'"
        End If
        sql += ")x "
        sql += " group by x.Totallnrel3,x.Totallnrel4 "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then
            'lnacctrel.Rows.Add(dtasof.Value.AddDays(-21).ToString("MMM - dd"), rd("week1").ToString)
            'lnacctrel.Rows.Add(dtasof.Value.AddDays(-14).ToString("MMM - dd"), rd("week2").ToString)
            lnacctrel.Rows.Add(dtasof.Value.AddDays(-7).ToString("MMM - dd"), rd("week3").ToString)
            lnacctrel.Rows.Add(dtasof.Value.ToString("MMM - dd"), rd("week4").ToString)
        End If
        rd.Close()
        myConn.Close()

        'ttlmem_PAR
        conn()
        sql = "select count(y.pnnumber) ttlmempar,isnull((sum(Loanbal)),0) as Loanbal from ("
        sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.TotalPrnPaid-x.totalprndue) <= 0.01) then datediff(day,x.Duedate,'" + dtasof.Value.AddDays(-7) + "') else (case when ((x.TotalIntPaid-x.totalintdue)<=0.01) then datediff(day,x.Duedate,'" + dtasof.Value.AddDays(-7) + "') else 0 end)  end as PARDays from ("
        sql += " select a.pnnumber,"
        sql += "prnloan=isnull((select top 1 rngprin from loansched where pnnumber=a.pnnumber),0),"
        sql += "intloan=isnull((select top 1 rngint from loansched where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value.AddDays(-7) + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(prnpaid+advprincipal) from LoanCollect where trnxdate<='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(prnpaid+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtasof.Value.AddDays(-7) + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + GL_loans + "'"
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
            paramnt3 = rd("Loanbal").ToString
        End If
        rd.Close()
        myConn.Close()

        'ttlmem_PAR
        conn()
        sql = "select count(y.pnnumber) ttlmempar,isnull((sum(Loanbal)),0) as Loanbal from ("
        sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.TotalPrnPaid-x.totalprndue) <= 0.01) then datediff(day,x.Duedate,'" + dtasof.Value + "') else (case when ((x.TotalIntPaid-x.totalintdue)<=0.01) then datediff(day,x.Duedate,'" + dtasof.Value + "') else 0 end)  end as PARDays from ("
        sql += "select a.pnnumber,"
        sql += "prnloan=isnull((select top 1 rngprin from loansched where pnnumber=a.pnnumber),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + dtasof.Value + "'),0),"
        sql += "TotalPrnPaid=isnull((SELECT SUM(prnpaid+advprincipal) from LoanCollect where trnxdate<='" + dtasof.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + dtasof.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(prnpaid+advprincipal) FROM LoanCollect WHERE trnxdate<='" + dtasof.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += " from Loans a,Members b where a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + GL_loans + "'"
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
            paramnt4 = rd("Loanbal").ToString
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

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Dim myPrintDialog As New PrintDialog()
        Dim memoryImage As New System.Drawing.Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(memoryImage, Panel1.ClientRectangle)
        'If myPrintDialog.ShowDialog() = DialogResult.OK Then
        Dim values As System.Drawing.Printing.PrinterSettings
        values = myPrintDialog.PrinterSettings
        myPrintDialog.Document = PrintDocument1
        PrintDocument1.PrintController = New StandardPrintController()
        PrintDocument1.Print()
        'End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub txtdaymode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdaymode.Validated
        If txtdaymode.Text = "Monthly" Then
            day1 = Double.Parse(System.DateTime.DaysInMonth(dtasof.Value.Year, dtasof.Value.Month)) - Double.Parse(System.DateTime.DaysInMonth(dtasof.Value.Year, dtasof.Value.Month)) * 2
            Try
                day2 = Double.Parse(System.DateTime.DaysInMonth(dtasof.Value.Year, (dtasof.Value.Month - 1)))
            Catch ex As Exception
                day2 = Double.Parse(System.DateTime.DaysInMonth((dtasof.Value.Year - 1), 12))
            End Try
        Else
            day1 = -7
            day2 = -14
        End If
        'MsgBox(day2.ToString)
    End Sub
End Class