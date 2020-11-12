Public Class SplashScreenForm
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    'Private Sub SplashScreenForm_Click(sender As Object, e As EventArgs) Handles Me.Click
    '    StansGroceryForm.Show()
    '    Me.Hide()
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class