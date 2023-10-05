Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim firstNumber, lastNumber As Integer
        firstNumber = Val(txtFirstNumber.Text)
        lastNumber = Val(txtSecondNumber.Text)
        Sum(firstNumber, lastNumber)
    End Sub

    Sub Sum(a As Single, b As Single)
        Dim sum As Integer
        sum = a + b
        txtSum.Text = sum
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub
End Class
