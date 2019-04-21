Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblIntRate As Double = 0
        Dim intLoanAmt As Integer = 0
        Dim intLoanDuration As Integer = 0
        Dim dblLoanPmt As Double = 0

        Integer.TryParse(txtLoanAmt.Text, intLoanAmt)
        Integer.TryParse(txtLoanDuration.Text, intLoanDuration)

        If radDirectSubLoan.Checked Then
            dblIntRate = 0.066
        ElseIf radDirectUnSubLoan.Checked Then
            dblIntRate = 0.0505
        Else
            dblIntRate = 0.076
        End If


        dblLoanPmt = -Financial.Pmt(dblIntRate / 365, intLoanDuration * 365, intLoanAmt)

        ' Increase heigth of form to allow room for ammortization schedule table
        Me.Height = 900
    End Sub

    Private Sub txtLoanAmt_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmt.TextChanged
        txtLoanAmt.Text = String.Empty
    End Sub

    Private Sub txtLoanDuration_TextChanged(sender As Object, e As EventArgs) Handles txtLoanDuration.TextChanged
        txtLoanAmt.Text = String.Empty
    End Sub

    Private Sub radDirectSubLoan_CheckedChanged(sender As Object, e As EventArgs) Handles radDirectSubLoan.CheckedChanged

    End Sub

End Class
