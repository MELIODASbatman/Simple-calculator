Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblnumber1.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim number1 As Double
        Dim number2 As Double
        Dim answer As Double

        'when using Double which gives answer in decimal format we convert the text to double using Convert.ToDouble() method.
        number1 = Convert.ToDouble(txtnumber1.Text)
        number2 = Convert.ToDouble(txtnumber2.Text)
        answer = number1 + number2

        MessageBox.Show("The answer is: " & answer)
    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        Dim number1 As Double
        Dim number2 As Double
        Dim answer As Double

        'when using Double which gives answer in decimal format we convert the text to double using Convert.ToDouble() method.
        number1 = Convert.ToDouble(txtnumber1.Text)
        number2 = Convert.ToDouble(txtnumber2.Text)
        answer = number1 - number2

        MessageBox.Show("The answer is: " & answer)
    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        Dim number1 As Double
        Dim number2 As Double
        Dim answer As Double

        'when using Double which gives answer in decimal format we convert the text to double using Convert.ToDouble() method.
        number1 = Convert.ToDouble(txtnumber1.Text)
        number2 = Convert.ToDouble(txtnumber2.Text)
        answer = number1 * number2

        MessageBox.Show("The answer is: " & answer)
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        Dim number1 As Double
        Dim number2 As Double
        Dim answer As Double

        'when using Double which gives answer in decimal format we convert the text to double using Convert.ToDouble() method.
        number1 = Convert.ToDouble(txtnumber1.Text)
        number2 = Convert.ToDouble(txtnumber2.Text)
        answer = number1 / number2

        MessageBox.Show("The answer is: " & answer)
    End Sub
End Class
