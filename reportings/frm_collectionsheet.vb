Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_collectionsheet
    Dim ctrcode As String
    Dim collcode As String
    Dim ctrchief As String
    Dim coldayno As Integer = 0

    Private Sub generate_collsheet()
        Dim MyRpt As New collectionsheet

        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        DS.Tables.Add("dummy")
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))      '0
            .Add("int13", Type.GetType("System.Double"))     '1
            .Add("str3", Type.GetType("System.String"))      '2
            .Add("str4", Type.GetType("System.String"))      '3
            .Add("str5", Type.GetType("System.String"))      '4
            .Add("int1", Type.GetType("System.Double"))      '5
            .Add("int2", Type.GetType("System.Double"))      '6
            .Add("int3", Type.GetType("System.Double"))      '7
            .Add("str13", Type.GetType("System.String"))     '8
            .Add("date3", Type.GetType("System.DateTime"))   '9
            .Add("int4", Type.GetType("System.Double"))      '10
            .Add("str12", Type.GetType("System.String"))     '11
            .Add("int5", Type.GetType("System.Double"))      '12
            .Add("str6", Type.GetType("System.String"))      '13
            .Add("str7", Type.GetType("System.String"))      '14
            .Add("int6", Type.GetType("System.Double"))      '15
            .Add("int7", Type.GetType("System.Double"))      '16
            .Add("int8", Type.GetType("System.Double"))      '17
            .Add("int9", Type.GetType("System.Double"))      '18
            .Add("int10", Type.GetType("System.Double"))     '19
            .Add("str8", Type.GetType("System.String"))      '20 row(20) = compaddress.ToString
            .Add("str14", Type.GetType("System.String"))     '21 
            .Add("str10", Type.GetType("System.String"))     '22 row(22) = CompName.ToString
        End With

         conn()
        sql = "select y.savingsBal, y.ctrname, y.ctraddr, y.collname,y.prnamnt, y.sssbal, y.CF,y.ctrcode, y.grpcode,y.SSSNo, y.Accountnumber,y.TotalPayment,y.maturitydate,y.releasedate,y.PrnPar,y.LH,y.IntPar,y.Principal,y.Interest,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.ttlamntpaid,y.intloan,y.pnnumber,y.MemCode,y.Fullname,y.savings from ("
        sql += "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar,(x.TotalPrnPaid+x.TotalintPaid) as ttlamntpaid from ("
        sql += "select a.Accountnumber,a.pnnumber,c.SSSNo,a.MemCode,a.grpcode,a.ctrcode,(CONVERT(VARCHAR(10),a.releasedate,110)) As releasedate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As maturitydate,"
        sql += "b.Interest,b.Principal,b.savings,LH=isnull((b.lh),0),b.Duedate,b.CF,c.Fullname,"
        sql += "sssbal=isnull((select sum(debit-credit) from SSSLedger where memcode=a.memcode),0),"
        sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intloan=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "collname=(select fullname from Officer where CollCode=a.CollCode),"
        sql += "ctrname=(select ctrchief from Center where ctrcode=a.ctrcode),"
        sql += "ctraddr=(select ctraddress from Center where ctrcode=a.ctrcode),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPayment=ISNULL((select count(pnnumber) FROM loancollect where pnnumber=a.pnnumber and cancel='N'),0),"
        sql += "savingsBal=isnull((select (SUM(debit)-SUM(credit)) from accountledger where Active='Y' and accountnumber=a.accountnumber),0)"
        sql += "from Loans a,Loansched b, Members c where"
        sql += " a.ctrcode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + txtloantype.SelectedValue + "' "
        sql += " and a.pnnumber=b.pnnumber and a.MemCode=c.MemCode  AND a.status='A' AND c.status='A' and a.released='Y'  AND a.maturitydate >= '" & matdate.Value & "'"
        sql += ") x"
        sql += ") y"
        sql += " GROUP BY y.savingsBal, y.ctrname, y.ctraddr, y.collname,y.prnamnt, y.sssbal, y.CF,y.ctrcode, y.grpcode,y.SSSNo, y.Accountnumber,y.TotalPayment,y.maturitydate,y.releasedate,y.PrnPar,y.LH,y.IntPar,y.Principal,y.Interest,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.ttlamntpaid,y.intloan,y.pnnumber,y.MemCode,y.Fullname,y.savings"
        sql += " ORDER BY y.grpcode, y.Fullname ASC"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 120
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("ctrcode").ToString
            row(1) = rd("grpcode").ToString
            row(2) = rd("fullname").ToString
            row(3) = rd("collname").ToString
            row(4) = loginfrm.txtuser.Text
            row(5) = rd("PrnPar") + rd("IntPar")
            row(6) = rd("Principal") + rd("Interest")
            row(7) = rd("cf").ToString
            row(8) = rd("maturitydate").ToString
            row(9) = txtdate.Value
            row(10) = (Double.Parse(rd("prnamnt").ToString) + Double.Parse(rd("intloan").ToString)) - (Double.Parse(rd("TotalPrnPaid").ToString) + Double.Parse(rd("TotalintPaid").ToString))
            row(11) = rd("ctrname").ToString
            row(12) = rd("savings").ToString
            row(13) = rd("ctrname").ToString
            row(14) = rd("ctraddr").ToString.Replace("Undefined", "")
            row(15) = rd("sssbal").ToString
            row(16) = rd("ttlamntpaid").ToString
            row(17) = rd("TotalPayment").ToString
            row(18) = rd("savingsBal").ToString
            row(19) = rd("LH").ToString
            row(20) = compaddress.ToString
            If rd("SSSNo").ToString = "" Then
                row(21) = "unregistered"
            Else
                row(21) = "____________"
            End If
            'new added 5/23/2023
            row(22) = CompName.ToString

            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        MyRpt.SetDataSource(DS)

        crviewer.ReportSource = MyRpt

        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub generate_collsheet_IL()
        Dim MyRpt As New collectionsheet_IL '// report filename
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        DS.Tables.Add("dummy")
        With DS.Tables(0).Columns
            .Add("date3", Type.GetType("System.DateTime")) '0
            .Add("str5", Type.GetType("System.String"))    '1
            .Add("str3", Type.GetType("System.String"))    '2
            .Add("str6", Type.GetType("System.String"))    '3
            .Add("str13", Type.GetType("System.String"))   '4
            .Add("int6", Type.GetType("System.Double"))    '5
            .Add("int4", Type.GetType("System.Double"))    '6
            .Add("int1", Type.GetType("System.Double"))    '7
            .Add("int2", Type.GetType("System.Double"))    '8
            .Add("int5", Type.GetType("System.Double"))    '9
            .Add("str12", Type.GetType("System.String"))   '10
            .Add("str4", Type.GetType("System.String"))    '11
            .Add("int3", Type.GetType("System.Double"))    '12
            .Add("str10", Type.GetType("System.String"))   '13 row(13) = CompName.ToString
            .Add("str11", Type.GetType("System.String"))   '14 row(14) = compaddress.ToString
            .Add("str7", Type.GetType("System.String"))    '15
            .Add("str14", Type.GetType("System.String"))   '16
            .Add("int7", Type.GetType("System.Double"))    '17
        End With

        conn()
        sql = "select y.CollCode,y.TotalPayment,y.maturitydate,y.releasedate,y.collname,y.PrnPar,y.IntPar,y.Principal,y.Interest,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.ttlamntpaid,y.loanamnt,y.prnloan,y.intloan,y.Duedate,y.pnnumber,y.MemCode,y.Fullname,y.savings,y.sssno,y.address,y.LH,y.sssbal from ("
        sql += "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar,(x.TotalPrnPaid+x.TotalintPaid) as ttlamntpaid from ("
        sql += "select a.pnnumber,a.MemCode,a.CollCode,a.loanamnt,c.SSSNO,c.address,(CONVERT(VARCHAR(10),a.releasedate,110)) As releasedate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As maturitydate,"
        sql += "b.savings,LH=isnull((b.lh),0),c.Fullname,"
        sql += "sssbal=isnull((select sum(debit-credit) from SSSLedger where memcode=a.memcode),0),"
        sql += "collname=(select fullname from Officer where CollCode=a.CollCode),"
        sql += "prnloan=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intloan=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Interest=isnull((select interest from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),0),"
        sql += "Principal=isnull((select principal from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPayment=ISNULL((select count(pnnumber) from loancollect where pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += "from Loans a,Loansched b, Members c where "
        sql += " a.CollCode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + txtloantype.SelectedValue + "'"
        sql += " and a.pnnumber=b.pnnumber and a.MemCode=c.MemCode AND a.status='A' and a.released='Y'"
        sql += ") x"
        sql += ") y where y.Duedate='" + txtdate.Value + "'"
        sql += " GROUP BY y.CollCode,y.TotalPayment,y.maturitydate,y.releasedate,y.collname,y.PrnPar,y.IntPar,y.Principal,y.Interest,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.ttlamntpaid,y.loanamnt,y.prnloan,y.intloan,y.Duedate,y.pnnumber,y.MemCode,y.Fullname,y.savings,y.sssno,y.address,y.LH,y.sssbal ORDER BY y.Fullname ASC"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 120
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = txtdate.Value
            row(1) = user.ToString
            row(2) = rd("fullname").ToString
            row(3) = rd("address").ToString.Replace("Undefined", "")
            row(4) = rd("maturitydate").ToString
            row(5) = rd("sssbal").ToString
            row(6) = (Double.Parse(rd("prnloan").ToString) + Double.Parse(rd("intloan").ToString)) - (Double.Parse(rd("TotalPrnPaid").ToString) + Double.Parse(rd("TotalintPaid").ToString))
            row(7) = rd("PrnPar") + rd("IntPar")
            row(8) = rd("Principal") + rd("Interest")
            row(9) = rd("savings").ToString
            row(10) = usersname.ToString
            row(11) = rd("collname").ToString
            row(12) = rd("TotalPayment").ToString
            row(13) = CompName.ToString
            row(14) = compaddress.ToString
            row(15) = "Acct. Reference :" & rd("CollCode").ToString
            If rd("SSSNo").ToString = "" Then
                row(16) = "unregistered"
            Else
                row(16) = "____________"
            End If
            row(17) = rd("LH").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        MyRpt.SetDataSource(DS)

        crviewer.ReportSource = MyRpt

        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub generate_collsheet_P3()
        Dim MyRpt As New collectionsheet_IL

        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        DS.Tables.Add("dummy")
        With DS.Tables(0).Columns
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str13", Type.GetType("System.String"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str4", Type.GetType("System.String"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("str10", Type.GetType("System.String"))
            .Add("str11", Type.GetType("System.String"))
            .Add("str7", Type.GetType("System.String"))
            .Add("int7", Type.GetType("System.Double"))
        End With

        conn()
        sql = "select y.CollCode,y.TotalPayment,y.maturitydate,y.releasedate,y.collname,y.PrnPar,y.LH,y.IntPar,y.Principal,y.Interest,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.ttlamntpaid,y.loanamnt,y.prnloan,y.intloan,y.pnnumber,y.MemCode,y.Fullname,y.savings,y.address from ("
        sql += "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar,(x.TotalPrnPaid+x.TotalintPaid) as ttlamntpaid from ("
        sql += "select a.pnnumber,a.MemCode,a.CollCode,a.loanamnt,c.address,(CONVERT(VARCHAR(10),a.releasedate,110)) As releasedate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As maturitydate,"
        sql += "b.savings,LH=isnull((b.lh),0),c.Fullname,"
        sql += "collname=(select fullname from Officer where CollCode=a.CollCode),"
        sql += "prnloan=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intloan=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "Interest=isnull((select interest from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),0),"
        sql += "Principal=isnull((select principal from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPayment=ISNULL((select count(pnnumber) from loancollect where pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
        sql += "from Loans a,Loansched b, Members c where "
        sql += " a.CollCode='" + txtcenter.SelectedValue + "' and a.GL_loans='" + txtloantype.SelectedValue + "'"
        sql += " and a.pnnumber=b.pnnumber and a.MemCode=c.MemCode AND a.status='A' and a.released='Y'"
        sql += ") x"
        sql += ") y where y.Duedate='" + txtdate.Value + "'"
        sql += " GROUP BY y.CollCode,y.TotalPayment,y.maturitydate,y.releasedate,y.collname,y.PrnPar,y.LH,y.IntPar,y.Principal,y.Interest,y.Totalprndue,y.Totalintdue,y.TotalPrnPaid,y.TotalintPaid,y.ttlamntpaid,y.loanamnt,y.prnloan,y.intloan,y.pnnumber,y.MemCode,y.Fullname,y.savings,y.address ORDER BY y.Fullname ASC"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 120
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = txtdate.Value
            row(1) = user.ToString
            row(2) = rd("fullname").ToString
            row(3) = rd("address").ToString
            row(4) = rd("maturitydate").ToString
            row(5) = rd("loanamnt").ToString
            row(6) = (Double.Parse(rd("prnloan").ToString) + Double.Parse(rd("intloan").ToString)) - (Double.Parse(rd("TotalPrnPaid").ToString) + Double.Parse(rd("TotalintPaid").ToString))
            row(7) = rd("PrnPar") + rd("IntPar")
            row(8) = rd("Principal") + rd("Interest")
            row(9) = rd("savings").ToString
            row(10) = usersname.ToString
            row(11) = rd("collname").ToString
            row(12) = rd("TotalPayment").ToString
            row(13) = CompName.ToString
            row(14) = compaddress.ToString
            row(15) = "Acct. Reference :" & rd("CollCode").ToString
            row(16) = rd("LH").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        MyRpt.SetDataSource(DS)

        crviewer.ReportSource = MyRpt

        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub generate_collsheetCL()
        Dim MyRpt As New collectionsheet_CL

        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        DS.Tables.Add("dummy")
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))     '0
            .Add("str3", Type.GetType("System.String"))     '1
            .Add("str4", Type.GetType("System.String"))     '2
            .Add("str5", Type.GetType("System.String"))     '3
            .Add("int1", Type.GetType("System.Double"))     '4
            .Add("int2", Type.GetType("System.Double"))     '5
            .Add("int3", Type.GetType("System.Double"))     '6
            .Add("str13", Type.GetType("System.String"))    '7
            .Add("date3", Type.GetType("System.DateTime"))  '8 
            .Add("int4", Type.GetType("System.Double"))     '9
            .Add("str12", Type.GetType("System.String"))    '10
            .Add("str6", Type.GetType("System.String"))     '11
            .Add("str8", Type.GetType("System.String"))     '12
            .Add("int8", Type.GetType("System.Double"))     '13
            .Add("str7", Type.GetType("System.String"))     '14 row(14) = CompName.ToString
            .Add("str10", Type.GetType("System.String"))    '15 row(15) = compaddress.ToString
            .Add("str11", Type.GetType("System.String"))    '16
        End With

        conn()
        sql = "select x.*,((x.totalprndue-x.TotalPrnPaid)) as PrnPar,((x.totalintdue-x.TotalIntPaid)) as IntPar,(x.TotalPrnPaid+x.TotalintPaid) as ttlamntpaid from("
        sql += "select a.pnnumber,a.MemCode,a.CollCode,a.ctrcode,a.grpcode,a.loanamnt,b.fullname,b.address,(CONVERT(VARCHAR(10),a.releasedate,110)) As releasedate,(CONVERT(VARCHAR(10),a.maturitydate,110)) As maturitydate,a.status,"
        sql += "prnloan=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "intloan=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "subproduct=isnull((select Description from SubProducts where code=a.Subproductcode),'Basic Needs'),"
        sql += "Interest=isnull((select interest from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),0),"
        sql += "Principal=isnull((select principal from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),0),"
        sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<'" + txtdate.Value + "'),0),"
        sql += "TotalPrnPaid=ISNULL((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalintPaid=ISNULL((SELECT SUM(intpaid+advinterest) FROM LoanCollect WHERE trnxdate<='" + txtdate.Value + "' AND pnnumber=a.pnnumber),0),"
        sql += "TotalPayment=ISNULL((select count(pnnumber) from loancollect where pnnumber=a.pnnumber),0),"
        sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and duedate='" + txtdate.Value + "'),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc)),"
        sql += "collname=(select fullname from Officer where CollCode=a.CollCode),"
        sql += "ctrchief=(select ctrchief from center where ctrcode=a.ctrcode),"
        sql += "ctraddr=(select ctraddress from center where ctrcode=a.ctrcode)"
        sql += " from loans a, members b where a.memcode=b.memcode and a.status='A' and a.released='Y'"
        If cbo_option.Text = "By Officer" Then
            sql += " and  a.collcode='" + txtcenter.SelectedValue + "' "
        Else
            sql += " and  a.ctrcode='" + txtcenter.SelectedValue + "' "
        End If
        sql += " and a.GL_loans='" + txtloantype.SelectedValue + "')x order by x.ctrcode,x.grpcode,x.Fullname,x.pnnumber"
        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 120
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("ctrcode").ToString
            row(1) = rd("fullname").ToString
            row(2) = rd("collname").ToString
            row(3) = loginfrm.txtuser.Text
            row(4) = Double.Parse(rd("PrnPar")) + Double.Parse(rd("IntPar"))
            row(5) = Double.Parse(rd("Principal")) + Double.Parse(rd("Interest"))
            row(6) = rd("ttlamntpaid").ToString
            row(7) = rd("maturitydate").ToString
            row(8) = txtdate.Value
            row(9) = (Double.Parse(rd("prnloan").ToString) + Double.Parse(rd("intloan").ToString)) - (Double.Parse(rd("TotalPrnPaid").ToString) + Double.Parse(rd("TotalintPaid").ToString))
            row(10) = rd("ctrchief").ToString
            row(11) = rd("ctraddr").ToString.Replace("UNDEFINED,", "")
            row(12) = rd("subproduct").ToString
            row(13) = rd("TotalPayment").ToString
            row(14) = rd("ctrcode").ToString
            row(14) = CompName.ToString
            row(15) = compaddress.ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        MyRpt.SetDataSource(DS)
        crviewer.ReportSource = MyRpt
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub frm_collectionsheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gen_loantype()
        txtdate.Value = systemdate
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

    Private Sub select_center()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT ctrcode,ctrname FROM center  WHERE status='A' and gl_loans='" + txtloantype.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("ctrcode").ToString, rd("ctrname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcenter.DataSource = table1
        Me.txtcenter.AutoFilter = True
        txtcenter.DisplayMember = "Description"
        txtcenter.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcenter.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcenter.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcenter.EditorControl.Columns(0).Width = 100
        Me.txtcenter.EditorControl.Columns(1).Width = 200
        Me.txtcenter.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub select_PA()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "select collcode,Fullname from Officer where status='A'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("collcode").ToString, rd("Fullname").ToString)
        End While
        rd.Close()
        myConn.Close()
        txtcenter.DataSource = table1
        Me.txtcenter.AutoFilter = True
        txtcenter.DisplayMember = "Description"
        txtcenter.ValueMember = "Code"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.txtcenter.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.txtcenter.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        Me.txtcenter.EditorControl.Columns(0).Width = 100
        Me.txtcenter.EditorControl.Columns(1).Width = 200
        Me.txtcenter.MultiColumnComboBoxElement.DropDownWidth = 400
    End Sub

    Private Sub txtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.ValueChanged
        If txtdate.Value.DayOfWeek.ToString = "Monday" Then
            coldayno = 1
        ElseIf txtdate.Value.DayOfWeek.ToString = "Tuesday" Then
            coldayno = 2
        ElseIf txtdate.Value.DayOfWeek.ToString = "Wednesday" Then
            coldayno = 3
        ElseIf txtdate.Value.DayOfWeek.ToString = "Thursday" Then
            coldayno = 4
        ElseIf txtdate.Value.DayOfWeek.ToString = "Friday" Then
            coldayno = 5
        ElseIf txtdate.Value.DayOfWeek.ToString = "Saturday" Then
            coldayno = 6
        ElseIf txtdate.Value.DayOfWeek.ToString = "Sunday" Then
            coldayno = 7
        End If
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        If grouptype = "N" And multiproduct = "N" And Not isP3 = "Y" Then
            generate_collsheet_IL()
        ElseIf grouptype = "Y" And multiproduct = "N" Then
            'MessageBox.Show("generate_collsheet()")
            generate_collsheet() 'hawak kamay
        ElseIf multiproduct = "Y" Then
            generate_collsheetCL() 'commodity
        ElseIf isP3 = "Y" Then
            generate_collsheet_P3() 'p3
        End If
        SplashScreen.Close()
    End Sub

    Private Sub cbo_option_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_option.SelectedIndexChanged
        If cbo_option.Text = "By Officer" Then
            select_PA()
        Else
            select_center()
        End If
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        If cbo_option.Text = "By Officer" Then
            select_PA()
        Else
            select_center()
        End If
    End Sub
End Class