Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_loanavailment

    Private Sub generate_loanavailment()
        'REPORT OBJECT
        Dim MyRpt As New loanavailment

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("date1", Type.GetType("System.DateTime"))
            '.Add("int1", Type.GetType("System.Double"))
            .Add("str5", Type.GetType("System.String"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
            .Add("str8", Type.GetType("System.String"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        sql = "select fullname,address,membertype,gender,birthdate,hlreleasedate,hlmatdate,clmatdate,ilmatdate,plmatdate,"
        sql += "hl=isnull(([1050-03]),0),"
        sql += "clreleasedate,"
        sql += "cl=isnull(([1050-02]),0),"
        sql += "ilreleasedate,"
        sql += "il = isnull(([1050-05]), 0),"
        sql += "plreleasedate,"
        sql += "pl = isnull(([1050-06]), 0)"
        sql += " from "
        sql += "("
        'sql += "select y.fullname,y.address,y.gender,datediff(year,y.birthdate,getdate()) as age,y.membertype,"
        sql += "select y.fullname,y.address,y.gender,y.birthdate,y.membertype,"
        sql += "(select releasedate from loans where memcode=w.memcode and gl_loans='1050-03' and released='Y') as hlreleasedate,"
        sql += "(select releasedate from loans where memcode=w.memcode and gl_loans='1050-02' and released='Y') as clreleasedate,"
        sql += "(select releasedate from loans where memcode=w.memcode and gl_loans='1050-05' and released='Y') as ilreleasedate,"
        sql += "(select releasedate from loans where memcode=w.memcode and gl_loans='1050-06' and released='Y') as plreleasedate,"

        sql += "(select maturitydate from loans where memcode=w.memcode and gl_loans='1050-03' and released='Y') as hlmatdate,"
        sql += "(select maturitydate from loans where memcode=w.memcode and gl_loans='1050-02' and released='Y') as clmatdate,"
        sql += "(select maturitydate from loans where memcode=w.memcode and gl_loans='1050-05' and released='Y') as ilmatdate,"
        sql += "(select maturitydate from loans where memcode=w.memcode and gl_loans='1050-06' and released='Y') as plmatdate,"

        sql += "loanbal=isnull((select sum(d.prnbal-d.ttlprnpaid) from(select a.pnnumber,"
        sql += "prnbal=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<=w.releasedate and pnnumber=a.pnnumber),0)"
        sql += " from loans a where memcode=w.memcode and status='A' and gl_loans=x.gl_loans)d),0),"

        sql += " x.gl_loans"
        sql += " from loans w, sysparmtr x, members y where w.memcode=y.memcode and w.gl_loans=x.gl_loans and w.released='Y' and w.releasedate <='" + systemdate + "'"

        sql += ") a"
        sql += " pivot "
        sql += "("
        sql += " sum(loanbal)"
        sql += " for gl_loans in ([1050-03],[1050-02],[1050-05],[1050-06])"
        sql += ") piv"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName
            row(1) = systemdate
            row(2) = rd("fullname").ToString
            row(3) = rd("address").ToString
            row(4) = rd("membertype").ToString
            row(5) = rd("gender").ToString
            row(6) = rd("birthdate").ToString
            row(7) = rd("hlreleasedate").ToString.Replace("12:00:00 AM", "")
            row(8) = rd("hl").ToString
            row(9) = rd("cl").ToString
            row(10) = rd("il").ToString
            row(11) = rd("pl").ToString
            row(12) = rd("clreleasedate").ToString.Replace("12:00:00 AM", "")
            row(13) = rd("ilreleasedate").ToString.Replace("12:00:00 AM", "")
            row(14) = rd("plreleasedate").ToString.Replace("12:00:00 AM", "")
            DS.Tables(0).Rows.Add(row)
        End While

        'row(8) = MDIfrm.lblparval.Text

        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crviewer.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub frm_loanavailment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        generate_loanavailment()
        'Catch ex As Exception

        'End Try
    End Sub
End Class