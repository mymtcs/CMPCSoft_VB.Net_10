Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Module PieModule

    Public Sub InitializePie1()
        MDIfrm.pie_members.Series.Clear()
        MDIfrm.pie_members.AreaType = ChartAreaType.Pie
        MDIfrm.pie_members.View.Palette = KnownPalette.Autumn
        Dim pie As New PieSeries()
        'pie.LabelMode = PieLabelModes.Horizontal
        'pie.ShowLabels = True
        'pie.DrawLinesToLabels = True
        'Dim smartPie As New PieSeries()
        'smartPie.LabelMode = PieLabelModes.Horizontal
        'smartPie.ShowLabels = True
        'smartPie.DrawLinesToLabels = True
        'smartPie.SyncLinesToLabelsColor = True

        For Each dataItem As KeyValuePair(Of Double, Object) In GetPieData_ttlmembers()
            Dim point As New PieDataPoint(dataItem.Key, dataItem.Value.ToString())
            point.Label = dataItem.Value.ToString() ' & "(" & dataItem.Key & ")"
            pie.DataPoints.Add(point)

            'point = New PieDataPoint(dataItem.Key, dataItem.Value.ToString())
            'point.Label = dataItem.Value.ToString()
            'smartPie.DataPoints.Add(point)
        Next

        MDIfrm.pie_members.Series.Add(pie)
        MDIfrm.pie_members.ShowLegend = True
        MDIfrm.pie_members.Title = "MEMBERS STATUS"
    End Sub

    Public Function GetPieData_ttlmembers() As List(Of KeyValuePair(Of Double, Object))
        Dim productdesc As String = "Products"
        Dim data As New List(Of KeyValuePair(Of Double, Object))()
        conn()
        'sql = "select x.* from(select DISTINCT a.description,"
        'sql += "ttlmembers=isnull((select count(pnnumber) from loans where status='A' and released='Y' and gl_loans=a.gl_loans),0)"
        'sql += " from Products a)x"
        sql = "select x.* from(select DISTINCT a.loandesc,"
        sql += "ttlmembers=isnull((select count(pnnumber) from loans where status='A' and released='Y' and gl_loans=a.gl_loans),0)"
        sql += " from loantype a)x"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            productdesc = rd("loandesc")
            data.Add(New KeyValuePair(Of Double, Object)(rd("ttlmembers").ToString, productdesc))
        End While

        Return data
    End Function

    Public Function GetPieData_par() As List(Of KeyValuePair(Of Double, Object))
        Dim productdesc As String = "Products"
        Dim data As New List(Of KeyValuePair(Of Double, Object))()
        conn()
        sql = "select z.* from(select DISTINCT w.loandesc,"
        sql += " PARmembers=isnull((select count(y.pnnumber) from ("
        sql += " select x.* ,case when ((x.totalprndue-x.TotalPrnPaid) >1) then datediff(day,x.Duedate,'9/2/2016') else (case when ((x.totalintdue-x.TotalIntPaid)>1) then datediff(day,x.Duedate,'9/2/2016') else 0 end)  end as PARDays from ("
        sql += " select a.pnnumber,a.collcode,"
        sql += " DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'9/2/2018'),"
        sql += " prnamount=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += " Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='9/1/2016'),0),"
        sql += " Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='9/1/2016'),0),"
        sql += " TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='9/1/2016' AND pnnumber=a.pnnumber),0),"
        sql += " TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<'9/1/2016' AND pnnumber=a.pnnumber),0),"
        sql += " Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='9/1/2016' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += "  from Loans a where a.status<>'X' and a.released='Y' and a.gl_loans=w.gl_loans"
        sql += " ) x where x.DateClosed>'9/1/2016'"
        sql += " ) y where y.PARdays>0),0)"
        sql += " from loantype w)z"

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            productdesc = rd("loandesc")
            data.Add(New KeyValuePair(Of Double, Object)(rd("PARmembers").ToString, productdesc))
        End While
        Return data
    End Function

    Public Sub InitializePie2()
        MDIfrm.pie_par.Series.Clear()
        MDIfrm.pie_par.AreaType = ChartAreaType.Pie
        MDIfrm.pie_par.View.Palette = KnownPalette.Autumn
        Dim pie As New PieSeries()
        'pie.LabelMode = PieLabelModes.Horizontal
        'pie.ShowLabels = True
        'pie.DrawLinesToLabels = True
        'Dim smartPie As New PieSeries()
        'smartPie.LabelMode = PieLabelModes.Horizontal
        'smartPie.ShowLabels = True
        'smartPie.DrawLinesToLabels = True
        'smartPie.SyncLinesToLabelsColor = True

        For Each dataItem As KeyValuePair(Of Double, Object) In GetPieData_par()
            Dim point As New PieDataPoint(dataItem.Key, dataItem.Value.ToString())
            point.Label = dataItem.Value.ToString() ' & "(" & dataItem.Key & ")"
            pie.DataPoints.Add(point)

            'point = New PieDataPoint(dataItem.Key, dataItem.Value.ToString())
            'point.Label = dataItem.Value.ToString()
            'smartPie.DataPoints.Add(point)
        Next

        MDIfrm.pie_par.Series.Add(pie)
        MDIfrm.pie_par.ShowLegend = True
        MDIfrm.pie_par.Title = "PAR STATUS"
    End Sub




    Public Sub InitializePie()

        Dim point1 As PieDataPoint
        Dim point2 As PieDataPoint
        Dim point3 As PieDataPoint
        Dim point4 As PieDataPoint
        Dim pieSeries As New PieSeries()
        pieSeries.ShowLabels = True

        conn()
        sql = ""

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        If rd.Read Then

            point1 = New PieDataPoint()
            point1.Value = rd("ttlmempar_0Days").ToString
            pieSeries.DataPoints.Add(point1)
            point1.Label = "0 Days and Below"


            point2 = New PieDataPoint()
            point2.Value = rd("ttlmempar1_30Days").ToString
            pieSeries.DataPoints.Add(point2)
            point2.Label = "1 To 30 Days"

            point3 = New PieDataPoint()
            point3.Value = rd("ttlmempar31_60Days").ToString
            pieSeries.DataPoints.Add(point3)
            point3.Label = "31 To 60 Days"

            point4 = New PieDataPoint()
            point4.Value = rd("ttlmempar61_90Days").ToString
            pieSeries.DataPoints.Add(point4)
            point4.Label = "61 To 90 Days"
        End If
        rd.Close()
        myConn.Close()
        MDIfrm.pie_members.ShowLegend = True
        MDIfrm.pie_members.Title = "MEMBERS STATUS"
    End Sub
End Module
