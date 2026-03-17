Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frm_utilities

    Private Sub frm_utilities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'view_overposting()
        view_member()
        'view_center()
    End Sub

    'Private Sub view_overposting()
    '    LV1.Items.Clear()
    '    conn()
    '    sql = "select y.pnnumber,y.LoanBal,y.intBal,y.payno from(select x.*,(x.prnamnt-x.ttlprnpaid) As LoanBal, (x.intamnt-x.ttlintpaid) As intBal from (SELECT a.pnnumber,"
    '    sql += "prnamnt=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
    '    sql += "intamnt=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
    '    sql += "payno = isnull((select top 1 payno from loancollect where pnnumber=a.pnnumber order by payno desc),1),"
    '    sql += "ttlprnpaid=isnull((select sum(principal+advprincipal) from loancollect where  trnxdate<='" + systemdate + "' and pnnumber=a.pnnumber),0),"
    '    sql += "ttlintpaid=isnull((select sum(intpaid+advinterest) from loancollect where trnxdate<='" + systemdate + "' and pnnumber=a.pnnumber),0) "
    '    sql += " FROM Loans a,members b WHERE a.MemCode=b.MemCode AND a.released='Y' and a.status<>'X' and a.releasedate<='" + systemdate + "' and a.gl_loans='" + GL_loans + "'"
    '    sql += ")x )y WHERE "
    '    If ComboBox1.Text = "Interest" Then
    '        sql += "(y.intbal)<0"
    '    Else
    '        sql += "(y.LoanBal)<0"
    '    End If
    '    sql += " and y.LoanBal=(y.intbal-(y.intbal*2))"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While (rd.Read())
    '        Dim lvitem As New ListViewItem(rd(0).ToString())
    '        For i As Integer = 1 To rd.FieldCount - 1
    '            lvitem.SubItems.Add(rd(i).ToString())
    '        Next
    '        LV1.Items.Add(lvitem)
    '    End While
    '    rd.Close()
    '    myConn.Close()
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    view_overposting()
    'End Sub

    Public Sub view_member()
        conn()
        lstmerge_members.Items.Clear()
        sql = "SELECT  a.MemCode,a.Fullname,a.Address,CONVERT(VARCHAR(10),a.Birthdate,101) As Birthdate,a.gl_loans,a.status,cbubal=isnull((select sum(debit-credit) from CbuLedger where cbuaccount=a.cbuaccount),0) FROM Members a WHERE a.fullname LIKE '%" + txtsearch.Text + "%'   ORDER BY a.fullname ASC"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader()
        While (rd.Read())
            Dim lvitem As New ListViewItem(rd(0).ToString())
            For i As Integer = 1 To rd.FieldCount - 1
                lvitem.SubItems.Add(rd(i).ToString())
            Next
            lstmerge_members.Items.Add(lvitem)
        End While
        rd.Close()
        myConn.Close()
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Control.CheckForIllegalCrossThreadCalls = False
    '    thread = New System.Threading.Thread(AddressOf SplashScreen.ShowDialog)
    '    thread.Start()
    '    For i As Integer = 0 To LV1.Items.Count - 1
    '        conn()
    '        sql = "update loancollect set principal=principal+" + Decimal.Parse(LV1.Items(i).SubItems(1).Text).ToString + ",intpaid=intpaid+" + Decimal.Parse(LV1.Items(i).SubItems(2).Text).ToString + " where pnnumber ='" + LV1.Items(i).SubItems(0).Text + "' and payno = " + LV1.Items(i).SubItems(3).Text + ""
    '        cmd = New SqlCommand(sql, myConn)
    '        myConn.Open()
    '        cmd.ExecuteNonQuery()
    '        myConn.Close()
    '    Next
    '    SplashScreen.Close()
    'End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        view_member()
    End Sub

    Private Sub bttntrnsfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttntrnsfer.Click
        Dim lvitem As New ListViewItem(lstmerge_members.FocusedItem.SubItems(0).Text)
        lvitem.SubItems.Add(lstmerge_members.FocusedItem.SubItems(1).Text)
        lvitem.SubItems.Add(lstmerge_members.FocusedItem.SubItems(2).Text)
        lvitem.SubItems.Add(lstmerge_members.FocusedItem.SubItems(3).Text)
        lvitem.SubItems.Add(lstmerge_members.FocusedItem.SubItems(6).Text)
        lstmerge.Items.Add(lvitem)
        lstmerge_members.FocusedItem.BackColor = Color.Yellow
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Make sure you have entered the correct information on accounts being merged. Do you wish to proceed?", "Merging is Dangerous!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
        Else
            If lblmemcode.Text = "000" Then
                MsgBox("No member code has been selected to set as original.", MsgBoxStyle.Exclamation, "Invalid")
            Else
                conn()
                sql = "update members set status='A' where memcode='" + lblmemcode.Text + "' "
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                For i As Integer = 0 To lstmerge.Items.Count - 1
                    conn()
                    sql = "update loans set memcode='" + lblmemcode.Text + "' where memcode='" + lstmerge.Items(i).SubItems(0).Text + "' "
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "update accountmaster set memcode='" + lblmemcode.Text + "' where memcode='" + lstmerge.Items(i).SubItems(0).Text + "' "
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    conn()
                    sql = "update loancollect set memcode='" + lblmemcode.Text + "' where memcode='" + lstmerge.Items(i).SubItems(0).Text + "' "
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()
                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    If lstmerge.Items(i).SubItems(0).Text <> lblmemcode.Text Then
                        conn()
                        sql = "update members set status='X' where memcode='" + lstmerge.Items(i).SubItems(0).Text + "' "
                        cmd = New SqlCommand(sql, myConn)
                        myConn.Open()
                        cmd.ExecuteNonQuery()
                        myConn.Close()
                    End If
                Next
                lstmerge.Items.Clear()

                conn()
                sql = "INSERT INTO logs (Pnnumber,Reasons,date,userID,time) VALUES ('" + usertype + "','Merging member " & lblmemcode.Text & "','" + systemdate + "','" + user.ToString + "','" + time.ToString + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()

                view_member()
                lblmemcode.Text = "000"

                MessageBox.Show("Merging successful!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If   
    End Sub

    Private Sub bttncancel_transfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncancel_transfer.Click
        lstmerge.FocusedItem.Remove()
    End Sub

    Private Sub lstmerge_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstmerge.SelectedIndexChanged
        lblmemcode.Text = lstmerge.FocusedItem.SubItems(0).Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lstmerge.Items.Clear()
        lblmemcode.Text = "000"
        lstmerge_members.BackColor = Color.White
    End Sub

    'Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtctrcode.Text = lst_center.FocusedItem.SubItems(0).Text
    '    txtgl.Text = lst_center.FocusedItem.SubItems(4).Text
    'End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    conn()
    '    sql = "update center set gl_loans='" + txtgl.Text + "' where ctrcode='" + txtctrcode.Text + "'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    cmd.ExecuteNonQuery()
    '    myConn.Close()
    '    'view_center()
    'End Sub

    'Public Sub view_center()
    '    conn()
    '    lst_center.Items.Clear()
    '    sql = "SELECT ctrcode,ctrname,ctrchief,ctraddress,gl_loans from center where ctrname like '%" + txtsearch_ctr.Text + "%' or ctraddress like '%" + txtsearch_ctr.Text + "%'"
    '    cmd = New SqlCommand(sql, myConn)
    '    myConn.Open()
    '    rd = cmd.ExecuteReader()
    '    While (rd.Read())
    '        Dim lvitem As New ListViewItem(rd(0).ToString())
    '        For i As Integer = 1 To rd.FieldCount - 1
    '            lvitem.SubItems.Add(rd(i).ToString())
    '        Next
    '        lst_center.Items.Add(lvitem)
    '    End While
    '    rd.Close()
    '    myConn.Close()
    '    For x As Integer = 0 To lstmerge_members.Items.Count - 1

    '    Next
    'End Sub

    'Private Sub txtsearch_ctr_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    view_center()
    'End Sub

    'Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Export the listview to an Excel spreadsheet
    '    SaveFileDialog1.Title = "Save Excel File"
    '    SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
    '    SaveFileDialog1.ShowDialog()
    '    'exit if no file selected
    '    If SaveFileDialog1.FileName = "" Then
    '        Exit Sub
    '    End If
    '    'create objects to interface to Excel
    '    Dim xls As New Excel.Application
    '    Dim book As Excel.Workbook
    '    Dim sheet As Excel.Worksheet
    '    'create a workbook and get reference to first worksheet
    '    xls.Workbooks.Add()
    '    book = xls.ActiveWorkbook
    '    sheet = book.ActiveSheet
    '    'step through rows and columns and copy data to worksheet
    '    Dim row As Integer = 1
    '    Dim col As Integer = 1
    '    For Each item As ListViewItem In LV1.Items
    '        For i As Integer = 0 To item.SubItems.Count - 1
    '            sheet.Cells(row, col) = item.SubItems(i).Text
    '            col = col + 1
    '        Next
    '        row += 1
    '        col = 1
    '    Next
    '    'save the workbook and clean up
    '    book.SaveAs(SaveFileDialog1.FileName)
    '    xls.Workbooks.Close()
    '    xls.Quit()
    '    releaseObject(sheet)
    '    releaseObject(book)
    '    releaseObject(xls)
    '    MsgBox("Export completed.", MsgBoxStyle.Information, "Completed")
    'End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_check_points.ShowDialog()
    End Sub
End Class