Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net
'Imports MySql.Data
'Imports Telerik_WinControls_Multiview
'Imports MySql.Data.MySqlClient

Module Module_Class
    'Public Add As New Telerik_WinControls_Multiview.Telerik_WinControls_Multiview.Myfunction
    Public datestarted As Date
    Public systemdate As Date
    Public officer As String = ""
    Public user As String = ""
    Public usersname As String = ""
    Public usertype As String = ""
    Public productcode As String = "Coolway"
    Public branch As String = "00"
    Public CompName As String = "not modified"
    Public compaddress As String = "not modified"
    Public AreaManager As String = "not modified"
    Public AreaSupervisor As String = "not modified"
    Public bookkeeper As String = "not modified"
    Public cashier As String = "not modified"
    Public branchcode As String = "00"
    Public loannumber As String
    Public llp As String
    Public interest As Double = 0
    Public aging As Integer = 0
    Public total_provisions As Double = 0
    Public constr As String
    'Public mysqlmyconn As MySqlConnection
    'Public mysqlrd As MySqlDataReader
    'Public mysqlcmd As New MySqlCommand
    Public myConn As SqlConnection
    Public myConn1 As SqlConnection
    Public sql As String
    Public sql1 As String
    Public rd As SqlDataReader
    Public rd1 As SqlDataReader
    Public cmd As New SqlCommand
    Public cmd1 As New SqlCommand
    Public time As String = DateTime.Now.Hour & ":" & DateTime.Now.Minute
    Public thread As System.Threading.Thread
    Public GL_loans As String
    Public GL_income As String
    Public GL_sa As String
    Public GL_cf As String
    Public code_series As String
    Public path As String
    Public strpath As String
    Public grouptype As String
    Public amount_w_markup As String
    Public multiproduct As String
    Public isPension As String
    Public isP3 As String
    Public member_code As String = ""
    Public myFont As New Font("Courier New", 9, FontStyle.Strikeout, GraphicsUnit.Point, Nothing)
    ' Public adminpass As String = "bur@k" old adminpass
    ' Public userpass As String = "bur@k"  old userpass

    Public adminpass As String = "bur@kxp" 'new adminpass 1/26/2021
    Public userpass As String = "bur@kxp"  'new userpass 1/26/2021
    Public TRNX As String = "ACTIVE"

    ' ADDDED NEW PUBLIC VARIABLE TO HOLD THEN accountmaster table GL_sa field
    ' 11/18/2021
    Public AccountMaster_GL_sa As String



    Public Sub getpath()
        path = System.IO.Path.GetDirectoryName( _
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        strpath = path
        strpath = strpath.ToString.Replace("file:\", "")
    End Sub

    'Public Sub mysqlconn()
    '    'If loginfrm.chk_windows_auth.Checked Then
    '    '    constr = "Data Source=" + loginfrm.txtserver.Text + ";Initial Catalog=" + loginfrm.txtdb.Text + ";Trusted_Connection=true;"
    '    'Else
    '    constr = "server=43.255.154.34;" _
    '        & "uid=coolwaympc_user;" _
    '        & "pwd=coolway9658;" _
    '        & "database=coolwayDB;" _
    '        & "port=3306;"
    '    'mysqlconstr = "server=localhost;" _
    '    '  & "uid=root;" _
    '    '  & "pwd=;" _
    '    '  & "database=#coolw@ydb;" _
    '    '  & "port=3306;"
    '    'End If
    '    mysqlmyconn = New MySqlConnection(constr)
    '    'myConn.Open()
    'End Sub

    Public Sub conn()
        'If loginfrm.chk_windows_auth.Checked Then
        '    constr = "Data Source=" + loginfrm.txtserver.Text + ";Initial Catalog=" + loginfrm.txtdb.Text + ";Trusted_Connection=true;"
        'Else
        constr = "Data Source=" + loginfrm.txtserver.Text + ";Network Library=DBMSSOCN;Initial Catalog=" + loginfrm.txtdb.Text + ";USER ID=sa; PASSWORD=" + loginfrm.txtserver_pass.Text.Replace("123456789", "") + ";"
        'End If

        myConn = New SqlConnection(constr)
        'myConn.Open()
    End Sub

    Public Sub testconn()
        conn()
        myConn.Open()
        'loginfrm.Size = New Size(582, 377)
        'loginfrm.lblsetupdb.Text = "Setup Database?"
        loginfrm.txtuser.Clear()
        loginfrm.txtpassword.Clear()
        loginfrm.txtuser.Focus()
        loginfrm.TabControl1.SelectedTab = loginfrm.TabPage1
    End Sub

    Public Sub testconnSQL()
        conn()
        myConn.Open()
        'loginfrm.Size = New Size(582, 377)
        'loginfrm.lblsetupdb.Text = "Setup Database?"
        loginfrm.txtuser.Clear()
        loginfrm.txtpassword.Clear()
        loginfrm.txtuser.Focus()
        loginfrm.TabControl1.SelectedTab = loginfrm.TabPage1
    End Sub



    Public Sub capslock_status()
        If Control.IsKeyLocked(Keys.CapsLock) Then
            MDIfrm.lblcapslock.ForeColor = Color.Red
            MDIfrm.lblcapslock.Text = "ON"
        Else
            MDIfrm.lblcapslock.ForeColor = Color.Black
            MDIfrm.lblcapslock.Text = "OFF"
        End If
    End Sub

    'Public Sub update_accesstemp()
    '    mysqlconn()
    '    sql = "update access_temp set status='X' where userid='" + user + "'"
    '    mysqlcmd = New MySqlCommand(sql, mysqlmyconn)
    '    mysqlmyconn.Open()
    '    mysqlcmd.ExecuteNonQuery()
    '    mysqlmyconn.Close()
    'End Sub


    Public Sub gen_qoutes()
        Dim RandomObject As New Random
        Dim char1Array As String() = New String() {"The most common way people give up their power is by thinking they don’t have any. –Alice Walker", _
                                                   "If You Are Working On Something That You Really Care About, You Don’t Have To Be Pushed. The Vision Pulls You. - Steve Jobs", _
                                                   "I am not a product of my circumstances. I am a product of my decisions. –Stephen Covey", _
                                                   "You can never cross the ocean until you have the courage to lose sight of the shore. –Christopher Columbus", _
                                                  "The two most important days in your life are the day you are born and the day you find out why. –Mark Twain", _
                                                  "The best revenge is massive success. –Frank Sinatra", _
                                                   "People often say that motivation doesn’t last. Well, neither does bathing.  That’s why we recommend it daily. –Zig Ziglar", _
                                                   "Life shrinks or expands in proportion to one's courage. –Anais Nin", _
                                                   "You Learn More From Failure Than From Success. Don’t Let It Stop You. Failure Builds Character.- Unknown", _
                                                    "People Who Are Crazy Enough To Think They Can Change The World, Are The Ones Who Do.- Rob Siltanen", _
                                                   "Failure Will Never Overtake Me If My Determination To Succeed Is Strong Enough. - Og Mandino", _
                                                   "The Only Limit To Our Realization Of Tomorrow Will Be Our Doubts Of Today. - Franklin D. Roosevelt", _
                                                   "Success isn't always about greatness. It's about consistency. Consistent hard work leads to success. Greatness will come. -Dwayne Johnson", _
                                                   "A dream doesn't become reality through magic; it takes sweat, determination and hard work. -Colin Powell", _
                                                   "Luck? I don't know anything about luck. I've never banked on it and I'm afraid of people who do. Luck to me is something else: Hard work - and realizing what is opportunity and what isn't. -Lucille Ball"}
        loginfrm.txtqoutes.Text = char1Array(RandomObject.Next(0, 14))
    End Sub

    Public Sub select_grptype()

        'MsgBox("Public Sub select_grptype()")

        conn()
        sql = "SELECT a.GroupType,a.IsPension,a.isP3,a.MultiProduct,b.* FROM loantype a, sysparmtr b where a.gl_loans='" + GL_loans + "' and a.gl_loans=b.gl_loans"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            grouptype = rd("GroupType")
            multiproduct = rd("MultiProduct")

            AreaManager = rd("AreaManager").ToString
            AreaSupervisor = rd("AreaSupervisor").ToString
            bookkeeper = rd("Bookkeeper").ToString
            cashier = rd("cashier").ToString
            code_series = rd("code_series").ToString
            GL_loans = rd("GL_loans").ToString
            GL_income = rd("GL_income").ToString
            GL_sa = rd("GL_sa").ToString
            GL_cf = rd("GL_cf").ToString
            isPension = rd("IsPension").ToString
            isP3 = rd("IsP3").ToString
            productcode = "CMPCsoft"
        End If
        rd.Close()
        myConn.Close()

        'MsgBox("EXIT----> Public Sub select_grptype()")
    End Sub




    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
               As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)), _
                  CLng(intAmount.ToString.Trim.Length / 3) + 1, _
                   CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, _
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String = _
                {"", "One", "Two", "Three", _
                  "Four", "Five", _
                  "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"", _
                "Eleven", "Twelve", "Thirteen", _
                  "Fourteen", "Fifteen", _
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten", _
                "Twenty", "Thirty", _
                  "Forty", "Fifty", "Sixty", _
                  "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "", _
                "Thousand", "Million", _
                  "Billion", "Trillion", _
                  "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount & _
                Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) - _
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount & _
                tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
                  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), _
                  wAmount.Trim & " Pesos And ", 1)) & " Cents"
            End If
        Catch ex As Exception
            'MessageBox.Show("Error Encountered: " & ex.Message, _
            '  "Convert Numbers To Words", _
            '  MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = _
          IIf(InStr(wAmount.Trim.ToLower, "pesos"), _
          wAmount.Trim, wAmount.Trim & " Pesos")

        'Display the result

        Return wAmount
    End Function

    Public Function Crypt(ByVal Text As String) As String

        ' Encrypts/decrypts the passed string using 
        ' a simple ASCII value-swapping algorithm
        Dim datecredit As Date = "8/30/2020"
        Dim strTempChar As String, i As Integer

        For i = 1 To Len(Text)

            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = CType(Asc(Mid$(Text, i, 1)) + 128, String)
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = CType(Asc(Mid$(Text, i, 1)) - 128, String)
            End If

            'Mid$(Text, i, 1) = Chr(CType(strTempChar, Integer))

        Next i
        'If datecredit <= Date.Today.ToString("M/dd/yyyy") Then
        '    Text = "%$#@$"
        'End If
        Return Text

    End Function
End Module
