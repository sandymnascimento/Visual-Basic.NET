Public Class Frm_TelaPrincipal

    Dim ListaCurso As String
    Public Sub New() ' é executado quando o form form aberto

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btn_Pricipal_Click(sender As Object, e As EventArgs) Handles Btn_Pricipal.Click
        Dim num As Integer = Val(Txt_ASCII.Text)
        Dim letra As Char = Chr(num)
        MsgBox("A caractere correspondente é " + letra, , "Conversor de caracteres")
    End Sub

    Private Sub Btn_AddLista_Click(sender As Object, e As EventArgs) Handles Btn_AddLista.Click
        Dim texto As String = Txt_EntradaLista.Text
        ListaCurso = ListaCurso + texto + vbCrLf
        Txt_Lista.Text = ListaCurso

    End Sub

    Private Sub Btn_ExibeLista_Click(sender As Object, e As EventArgs) Handles Btn_ExibeLista.Click
        MsgBox(ListaCurso)
    End Sub
End Class
