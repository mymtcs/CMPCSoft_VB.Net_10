Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Imports Telerik.WinControls.Data

Public Class frm_recons_amount
    Public intrate As Integer = 0
    Public ttlint As Double = 0

    Private Sub bttnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnok.Click
        If MessageBox.Show("Are you sure you want to restructured this loan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            bttnok.Enabled = False
            ttlint = Double.Parse(txtpdi.Text) + Double.Parse(txtpdp.Text)
            Me.Close()
        End If
    End Sub

    Private Sub frm_recons_amount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        compute_bal()
        txtprin.Enabled = True
        bttnok.Enabled = False
        txtpayment.Text = 0
        txtcycle.Text = 0
    End Sub

    Private Sub compute_bal()
        conn()
        sql = "select (x.principal-x.ttlprnpaid) as prnbal,(x.interest-x.ttlintpaid) as intbal,x.pnnumber,x.intrate,x.payno,x.modeofpayment,x.monthno from(SELECT a.pnnumber,a.intrate,a.payno,a.modeofpayment,"
        sql += "ttlprnpaid=isnull((SELECT (SUM(principal+AdvPrincipal)) FROM LoanCollect WHERE pnnumber=a.pnnumber),0),"
        sql += "ttlintpaid=isnull((SELECT (SUM(intpaid+AdvInterest)) FROM LoanCollect WHERE pnnumber=a.pnnumber),0),"
        sql += "principal=isnull((select sum(principal) from loansched where pnnumber=a.pnnumber),0),"
        sql += "interest=isnull((select sum(interest) from loansched where pnnumber=a.pnnumber),0),"
        sql += "monthno=isnull((datediff(month,maturitydate,'" & systemdate & "')),1)"
        sql += " FROM Loans a WHERE a.pnnumber='" + frm_members.dtgridloan_list.CurrentRow.Cells(0).Value + "'"
        sql += ")x "
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        If rd.Read Then
            ' txtpdi.Text = rd("intbal").ToString
            txtprin.Text = rd("prnbal") + rd("intbal")
            txtno_of_months.Value = rd("monthno")
            If rd("modeofpayment") = "Week(s)" Then
                intrate = rd("intrate") / (rd("payno") / 4)
            ElseIf rd("modeofpayment") = "Semi-Monthly" Then
                intrate = rd("intrate") / (rd("payno") / 2)
            Else
                intrate = rd("intrate") / 4
            End If
        End If
        rd.Close()
        myConn.Close()
        compute_penalty()
    End Sub

    Private Sub cboterms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboterms.SelectedIndexChanged
        lblterm.Text = cboterms.Text & " Payment"
    End Sub

    Private Sub bttncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttncompute.Click
        ttlint = Double.Parse(txtpdi.Text) + Double.Parse(txtpdp.Text)
        txtcycle.Text = Math.Round((Double.Parse(txtprin.Text) + Double.Parse(ttlint)) / Double.Parse(txtpayment.Text))
        bttnok.Enabled = True
    End Sub

    Private Sub txtprin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprin.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtprin.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtprin.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtprin.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            ''If e.KeyChar = Chr(13) Then GetNextControl(bttnsave_receipt, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtprin_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprin.KeyUp
        Try
            If Not txtprin.Text.Contains(".") And Double.Parse(txtprin.Text) > 0 Then
                txtprin.Text = Format(Val(Replace(txtprin.Text, ",", "")), "#,###,###")
                txtprin.Select(txtprin.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpdi.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtpdi.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtprin.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtpdi.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            ''If e.KeyChar = Chr(13) Then GetNextControl(bttnsave_receipt, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtint_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpdi.KeyUp
        Try
            If Not txtpdi.Text.Contains(".") And Double.Parse(txtpdi.Text) > 0 Then
                txtpdi.Text = Format(Val(Replace(txtpdi.Text, ",", "")), "#,###,###")
                txtpdi.Select(txtpdi.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtpayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayment.KeyPress
        Try
            Dim dot As Integer, ch As String
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = "." And txtpayment.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point

            dot = txtpayment.Text.IndexOf(".")
            If dot > -1 Then            'allow only 2 decimal places
                ch = txtpdi.Text.Substring(dot + 1)
                If ch.Length > 1 Then e.Handled = True 'does not allow any other keypresses
            End If

            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
            If e.KeyChar = "-" Then e.Handled = False
            ''If e.KeyChar = Chr(13) Then GetNextControl(bttnsave_receipt, True).Focus() 'Enter key moves to next control in Tab order
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtpayment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpayment.KeyUp
        Try
            If Not txtpayment.Text.Contains(".") And Double.Parse(txtpayment.Text) > 0 Then
                txtpayment.Text = Format(Val(Replace(txtpayment.Text, ",", "")), "#,###,###")
                txtpayment.Select(txtpayment.Text.Length, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtno_of_months_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtno_of_months.ValueChanged
        compute_penalty()
    End Sub

    Private Sub compute_penalty()
        Try
            Dim pdi As Double = (Double.Parse(txtprin.Text) * Double.Parse(txtno_of_months.Value)) * 0.02
            Dim pdp As Double = (Double.Parse(txtprin.Text) * 0.04) * Double.Parse(txtno_of_months.Value)

            txtpdi.Text = pdi.ToString("N2")
            txtpdp.Text = pdp.ToString("N2")
            ttlint = Double.Parse(txtpdi.Text) + Double.Parse(txtpdp.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class