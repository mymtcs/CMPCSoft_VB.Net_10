Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data

Public Class frm_abstractsavings

    Private Sub frm_abstractsavings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtfrom.Value = systemdate
        dtto.Value = systemdate
        gen_loantype()
    End Sub

    Private Sub abstract_savings()
        'REPORT OBJECT
        Dim MyRpt As New abstractsavings

        'DATASET, AND DATAROW OBJECTS NEEDED TO MAKE THE DATA SOURCE
        Dim row As DataRow = Nothing
        Dim DS As New DataSet

        'ADD A TABLE TO THE DATASET
        DS.Tables.Add("dummy")
        'ADD THE COLUMNS TO THE TABLE
        With DS.Tables(0).Columns
            .Add("str13", Type.GetType("System.String"))
            .Add("str12", Type.GetType("System.String"))
            .Add("str15", Type.GetType("System.String"))
            .Add("str16", Type.GetType("System.String"))
            .Add("str1", Type.GetType("System.String"))
            .Add("str2", Type.GetType("System.String"))
            .Add("str3", Type.GetType("System.String"))
            .Add("int1", Type.GetType("System.Double"))
            .Add("int2", Type.GetType("System.Double"))
        End With

        'LOOP THE LISTVIEW AND ADD A ROW TO THE TABLE FOR EACH LISTVIEWITEM
        'For Each LVI As ListViewItem In lstloanrel.Items

        conn()
        sql = "select x.* from(select a.Debit,a.Credit,a.Postmode,b.Accountnumber,"
        sql += "accountname=isnull((select fullname from members where memcode=b.memcode),(select ctrname from center where accountnumber=b.accountnumber)) "
        sql += "from Accountledger a, Accountmaster b  where a.active='Y' and a.GL_sa='" + txtloantype.SelectedValue + "' and  a.accountnumber=b.accountnumber and a.PostingDate between '" + dtfrom.Value + "' AND '" + dtto.Value + "'"
        sql += ")x order by x.Accountnumber"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        While rd.Read
            row = DS.Tables(0).NewRow
            row(0) = CompName.ToString
            row(1) = compaddress.ToString
            row(2) = dtfrom.Value & " to " & dtto.Value
            row(3) = productcode.ToString
            row(4) = rd("accountname").ToString
            row(5) = rd("accountnumber").ToString
            row(6) = rd("Postmode").ToString
            row(7) = rd("Debit").ToString
            row(8) = rd("Credit").ToString
            DS.Tables(0).Rows.Add(row)
        End While
        rd.Close()
        myConn.Close()
        'Next

        'SET THE REPORT SOURCE TO THE DATABASE
        MyRpt.SetDataSource(DS)

        'ASSIGN THE REPORT TO THE CRVIEWER CONTROL
        crv_loantoberel.ReportSource = MyRpt

        'DISPOSE OF THE DATASET
        DS.Dispose()
        DS = Nothing
    End Sub

    Private Sub gen_loantype()
        Dim table1 As DataTable = New DataTable()
        conn()
        sql = "SELECT  accountcode,acct_description FROM chartaccounts  WHERE Accttype='savings'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        table1.Columns.Add("Code")
        table1.Columns.Add("Description")
        While (rd.Read())
            table1.Rows.Add(rd("accountcode").ToString, rd("acct_description").ToString)
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
        Me.txtloantype.EditorControl.Columns(0).Width = 100
        Me.txtloantype.EditorControl.Columns(1).Width = 250
        Me.txtloantype.MultiColumnComboBoxElement.DropDownWidth = 420
    End Sub

    Private Sub bttngenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttngenerate.Click
        SplashScreen.count = 0
        Control.CheckForIllegalCrossThreadCalls = False
        thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
        thread.Start()
        GL_loans = txtloantype.SelectedValue
        select_grptype()
        abstract_savings()
        SplashScreen.Close()
    End Sub
End Class