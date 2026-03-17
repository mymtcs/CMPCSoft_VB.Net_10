Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports Telerik.WinControls.Data

Public Class frm_matured_loans
    Private cntr As String
    Private collcode As String
    Private ctrcode As String

    Private Sub frm_matured_loans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gendate.Value = systemdate
        gen_loantype()
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

    Private Sub generate_delinquency()
        'REPORT OBJECT
        Dim MyRpt As New matured_account

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("date1", Type.GetType("System.DateTime"))
            .Add("date2", Type.GetType("System.DateTime"))
            .Add("int2", Type.GetType("System.Double"))
            .Add("int3", Type.GetType("System.Double"))
            .Add("int4", Type.GetType("System.Double"))
            .Add("int5", Type.GetType("System.Double"))
            .Add("date3", Type.GetType("System.DateTime"))
            .Add("int6", Type.GetType("System.Double"))
            .Add("str4", Type.GetType("System.String"))
            .Add("str5", Type.GetType("System.String"))
            .Add("str6", Type.GetType("System.String"))
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))
            .Add("int7", Type.GetType("System.Double"))
            .Add("int8", Type.GetType("System.Double"))
            .Add("date4", Type.GetType("System.DateTime"))
            .Add("int9", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In frmpar_reports.lstclientagings.Items
        conn()
        If multiproduct = "N" Then
            sql = "select *,(y.holdout-y.Loanbal) As exposeamnt from ("
            sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,((x.loanamnt+x.interestdue)-(x.TotalPrnPaid+x.TotalintPaid))as runbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.totalintdue-x.TotalIntPaid) >1) then datediff(day,x.maturitydate,'" + gendate.Value + "') else (case when ((x.totalprndue-x.TotalPrnPaid)>1) then datediff(day,x.maturitydate,'" + gendate.Value + "') else 0 end)  end as PARDays from ("
            sql += "select a.pnnumber,b.Fullname,a.Collcode,a.releasedate,a.loandate,b.address,a.maturitydate,a.ctrcode,a.loanamnt,"
            sql += "prnloan=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
            sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
            sql += "Collname=(select fullname from officer where CollCode=a.collcode),"
            sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(9) + "'),"
            sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
            sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
            sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where  trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
            sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where  trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
            sql += "holdout=isnull((select SUM(debit-credit) from AccountLedger where Accountnumber=a.Accountnumber and active='Y'),0),"
            sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + gendate.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
            'sql += "DateClosed=isnull((select dateclosed from loans where pnnumber=a.pnnumber),'" + gendate.Value.AddYears(60) + "')"
            sql += "from Loans a,Members b where  a.status<>'X' and a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + GL_loans + "'"
        Else
            sql = "select *,(y.holdout-y.Loanbal) As exposeamnt from ("
            sql += "select x.*,((x.prnloan)-x.TotalPrnPaid)as Loanbal,((x.loanamnt)-(x.TotalPrnPaid+x.TotalintPaid))as runbal,(x.totalprndue-x.TotalPrnPaid) as PrnPar,(x.totalintdue-x.TotalIntPaid) as IntPar,case when ((x.totalintdue-x.TotalIntPaid) >1) then datediff(day,x.maturitydate,'" + gendate.Value + "') else (case when ((x.totalprndue-x.TotalPrnPaid)>1) then datediff(day,x.maturitydate,'" + gendate.Value + "') else 0 end)  end as PARDays from ("
            sql += "select a.pnnumber,b.Fullname,a.Collcode,a.releasedate,a.loandate,b.address,a.maturitydate,a.ctrcode,loanamnt,"
            sql += "prnloan=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber),0),"
            sql += "interestdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
            sql += "DateClosed=isnull((select DateClosed from loans where pnnumber=a.pnnumber),'" + systemdate.AddYears(999) + "'),"
            sql += "Collname=(select fullname from officer where CollCode=a.collcode),"
            sql += "Totalprndue=isnull((select sum(Principal) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
            sql += "Totalintdue=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber and duedate<='" + gendate.Value + "'),0),"
            sql += "TotalPrnPaid=isnull((SELECT SUM(principal+advprincipal) from LoanCollect where trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
            sql += "TotalintPaid=isnull((SELECT SUM(intpaid+advinterest) from LoanCollect where trnxdate<='" + gendate.Value + "' and cancel='N' AND pnnumber=a.pnnumber),0),"
            sql += "holdout=0," 'isnull((select SUM(debit)-SUM(credit) from AccountLedger where Accountnumber=c.Accountnumber),0),"
            sql += "Duedate=isnull((select top 1 duedate from loansched where pnnumber=a.pnnumber and rngprin>((SELECT SUM(principal+advprincipal) FROM LoanCollect WHERE trnxdate<='" + gendate.Value + "' AND pnnumber=a.pnnumber)) order by duedate asc),(select top 1 duedate from loansched where pnnumber=a.pnnumber order by duedate asc))"
            sql += "from Loans a,Members b where a.status<>'X' and a.MemCode=b.MemCode and a.released='Y' AND a.GL_loans='" + GL_loans + "'"
        End If
        If cboption.Text = "By Officer" Then
            If txtcenter.SelectedValue <> "All" Then
                sql += " and a.CollCode='" + txtcenter.SelectedValue + "'"
            End If
        Else
            If txtcenter.SelectedValue <> "All" Then
                sql += " and a.ctrcode='" + txtcenter.SelectedValue + "'"
            End If
        End If
        sql += ") x WHERE x.DateClosed>'" + gendate.Value + "' "
        sql += ") y where y.PARdays>0 order by y.PARdays"

        cmd = New SqlCommand(sql, myConn)
        cmd.CommandTimeout = 100
        myConn.Open()
        rd = cmd.ExecuteReader()
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = rd("pnnumber").ToString
            row(1) = rd("Fullname").ToString
            row(2) = rd("loanamnt").ToString
            row(3) = rd("maturitydate").ToString
            row(4) = rd("duedate").ToString
            row(5) = rd("Totalprndue").ToString
            row(6) = rd("TotalPrnPaid").ToString
            row(7) = Double.Parse(rd("Loanbal").ToString)
            row(8) = rd("PARdays").ToString
            row(9) = gendate.Value
            row(10) = Decimal.Parse(rd("PrnPar").ToString)
            row(11) = rd("Collname").ToString
            row(12) = rd("ctrcode").ToString
            row(13) = rd("address").ToString
            row(14) = CompName.ToString
            row(15) = compaddress.ToString
            row(16) = txtloantype.Text
            If rd("exposeamnt") < 0 Then
                row(17) = 0
            Else
                row(17) = rd("exposeamnt").ToString
            End If
            row(18) = rd("holdout").ToString
            row(19) = rd("releasedate").ToString
            row(20) = rd("runbal").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
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


    Private Sub cboption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboption.SelectedIndexChanged
        If cboption.Text = "By Officer" Then
            select_PA()
        Else
            select_center()
        End If
    End Sub

    Private Sub select_center()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT ctrcode,ctrname FROM center  WHERE status='A' and GL_loans='" + txtloantype.SelectedValue + "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("All", "All")
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
        sql = "select collcode,Fullname from Officer where status='A' "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        table1.Rows.Add("All", "All")
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

    Private Sub txtcenter_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcenter.SelectedValueChanged
        'MsgBox(txtcenter.SelectedValue)
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        'If txtcoll.Text <> "" Then
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        'Try
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        generate_delinquency()
        'Catch ex As Exception
        '    SplashScreen.Close()
        'End Try
        SplashScreen.Close()
        'End If
    End Sub

    Private Sub txtloantype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloantype.Validated
        If cboption.Text = "By Officer" Then
            select_PA()
        Else
            select_center()
        End If
    End Sub
End Class