Public Class Frm_TelaPrincipal
    Private Sub Btn_Inteiros_Click(sender As Object, e As EventArgs) Handles Btn_Inteiros.Click
        Dim int As Integer
        Dim num As Random = New Random()

        int = num.Next(0, 1000)
        MsgBox("O número gerado foi: " + int.ToString, , "Número aleatório")


    End Sub

    Private Sub Btn_IntNegativo_Click(sender As Object, e As EventArgs) Handles Btn_IntNegativo.Click
        Dim int As Integer
        Dim num As Random = New Random()

        int = num.Next(-1000, 0)
        MsgBox("O número gerado foi: " + int.ToString, , "Número aleatório")
    End Sub

    Private Sub Btn_Decimais_Click(sender As Object, e As EventArgs) Handles Btn_Decimais.Click
        Dim float As Double
        Dim num As Random = New Random()

        float = num.Next(0, 1000) + num.NextSingle()
        MsgBox("O número gerado foi: " + float.ToString("####.000"), , "Número aleatório")
    End Sub

    Private Sub Btn_DbNegativo_Click(sender As Object, e As EventArgs) Handles Btn_DbNegativo.Click
        Dim float As Double
        Dim num As Random = New Random()

        float = num.Next(-1000, 0) + num.NextDouble()
        MsgBox("O número gerado foi: " + float.ToString("####.000"), , "Número aleatório")


    End Sub

    Private Sub Btn_Soma_Click(sender As Object, e As EventArgs) Handles Btn_Soma.Click
        Dim num1 As Double = TextBox1.Text
        Dim num2 As Double = TextBox2.Text

        Dim resultado As Double = num1 + num2
        Lbl_Resultado.Text = resultado.ToString

    End Sub
    Private Sub Btn_Subtracao_Click(sender As Object, e As EventArgs) Handles Btn_Subtracao.Click
        Dim num1 As Double = TextBox1.Text
        Dim num2 As Double = TextBox2.Text

        Dim resultado As Double = num1 - num2
        Lbl_Resultado.Text = resultado.ToString

    End Sub

    Private Sub Btn_Multiplicacao_Click(sender As Object, e As EventArgs) Handles Btn_Multiplicacao.Click
        Dim num1 As Double = TextBox1.Text
        Dim num2 As Double = TextBox2.Text

        Dim resultado As Double = num1 * num2
        Lbl_Resultado.Text = resultado.ToString
    End Sub

    Private Sub Btn_Divisao_Click(sender As Object, e As EventArgs) Handles Btn_Divisao.Click
        Dim num1 As Double = TextBox1.Text
        Dim num2 As Double = TextBox2.Text

        Dim resultado As Double = num1 / num2
        Lbl_Resultado.Text = resultado.ToString

    End Sub

End Class
