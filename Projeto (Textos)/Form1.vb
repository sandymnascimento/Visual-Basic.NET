Public Class Frm_TelaPrincipal
    Public Sub New() ' é executado quando o form form aberto

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btn_Pricipal_Click(sender As Object, e As EventArgs) Handles Btn_Pricipal.Click
        Dim num As Integer = Val(TextBox1.Text)
        Dim letra As Char = Chr(num)
        MsgBox("A caractere correspondente é " + letra, , "Conversor de caracteres")
    End Sub

End Class
