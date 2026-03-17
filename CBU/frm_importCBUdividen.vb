Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.UI

Public Class frm_importCBUdividen

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function Crypt( _
      ByVal Text As String) As String
        ' Encrypts/decrypts the passed string using 
        ' a simple ASCII value-swapping algorithm
        Dim strTempChar As String, i As Integer
        For i = 1 To Len(Text)
            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) + 128, String)
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) - 128, String)
            End If
            'Mid$(Text, i, 1) = Chr(CType(strTempChar, Integer))
        Next i
        Return Text
    End Function

    Private Sub bttnimport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnimport.Click
        Dim MyFile As String
        OpenFileDialog1.Filter = "File csv (*.csv)|*.csv|text (*.txt)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            MyFile = OpenFileDialog1.FileName
            Dim oInfile As New System.IO.StreamReader(MyFile)
            dtgrd_cbu.Rows.Clear()
            Dim line As String
            Dim reader As IO.StreamReader = Nothing
            lblfilename.Text = MyFile
            Try
                reader = New IO.StreamReader(MyFile)
                line = reader.ReadLine

                While Not line Is Nothing
                    Dim parts As String() = line.Split("_")
                    dtgrd_cbu.Rows.Add(parts)
                    line = reader.ReadLine
                End While
            Finally
                If Not reader Is Nothing Then
                    reader.Close()
                End If
            End Try
            oInfile.Close()

            For row As Integer = 0 To dtgrd_cbu.Rows.Count - 1
                For col As Integer = 0 To dtgrd_cbu.Columns.Count - 1
                    dtgrd_cbu.Rows(row).Cells(col).Value = Crypt(dtgrd_cbu.Rows(row).Cells(col).Value)
                Next
                'dtgrd_att.Rows(i).Cells(x).Value = sb
            Next
        End If
        Dim ttlavg As Decimal = 0
        For i As Integer = 0 To dtgrd_cbu.Rows.Count - 1
            ttlavg = ttlavg + Double.Parse(dtgrd_cbu.Rows(i).Cells(3).Value)
        Next
        txtttlavg.Text = ttlavg
    End Sub

    Private Sub bttnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To dtgrd_cbu.Rows.Count - 1
            Dim cbuacct As String = dtgrd_cbu.Rows(i).Cells(0).Value
            Dim lvitem As New ListViewItem(Crypt(cbuacct))
            For col As Integer = 1 To dtgrd_cbu.Columns.Count - 1
                lvitem.SubItems.Add(Crypt(dtgrd_cbu.Rows(i).Cells(col).Value))
            Next
            lstcbu.Items.Add(lvitem)
            'Next
        Next

        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .FileName = "Computed dividen as of " & systemdate.ToString("M.dd.yy") & "_" & lstcbu.Items.Count
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

    Private Sub bttncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncompute.Click
        If MessageBox.Show("Are you sure you want to upload this CBU Dividen?. This may take time to upload.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim count As Integer = 0
            Dim ttlupload As Decimal = 0
            For i As Integer = 0 To dtgrd_cbu.Rows.Count - 1
                Dim postno As Integer = 0
                Dim cbu_gl As String = ""
                conn()
                sql = "SELECT max(a.postno) as postno,isnull((select top 1 gl_loans from CBULedger where cbuaccount=a.cbuaccount),'1050-03') as gl_loans FROM CBULedger a WHERE cbuaccount='" + dtgrd_cbu.Rows(i).Cells(0).Value + "' group by cbuaccount"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                rd = cmd.ExecuteReader
                If rd.Read Then
                    cbu_gl = rd("gl_loans")
                    postno = rd("postno") + 1
                End If
                rd.Close()
                myConn.Close()
                conn()
                sql = "INSERT INTO CBULedger(CBUaccount,PostingDate,Postno,Debit,Credit,Remarks,Reference,userid,tdate,Active,postmode,gl_loans) VALUES "
                sql += "('" + dtgrd_cbu.Rows(i).Cells(0).Value + "'"
                sql += ",'" + systemdate + "'"
                sql += "," + postno.ToString + ""
                sql += "," + Double.Parse(dtgrd_cbu.Rows(i).Cells(4).Value).ToString + ",0"
                sql += ",'Computed dividen'"
                Try
                    sql += ",'" + dtgrd_cbu.Rows(i).Cells(6).Value.ToString.Substring(0, 15) + "'"
                Catch ex As Exception
                    sql += ",'" + dtgrd_cbu.Rows(i).Cells(6).Value.ToString + "'"
                End Try
                sql += ",'" + user.ToString + "'"
                sql += ",'" + systemdate + "'"
                sql += ",'Y','CM','" + cbu_gl + "')"
                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                cmd.ExecuteNonQuery()
                myConn.Close()
                count = count + 1
                Try
                    ttlupload = ttlupload + Double.Parse(dtgrd_cbu.Rows(i).Cells(4).Value)
                Catch ex As Exception

                End Try
            Next

            MsgBox(count & " record was successfully uploaded." & " Total amount uploaded : " & ttlupload, MsgBoxStyle.Information, "Message")
            txtrecord.Text = count
            txtamount.Text = ttlupload
        End If
    End Sub
End Class
