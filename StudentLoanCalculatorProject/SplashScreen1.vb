Public NotInheritable Class splStudentLoanCalc

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgLoading.Increment(10)
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
