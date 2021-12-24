Public Class Frm_TelaPrincipal
    Dim acompanhado As Boolean
    Dim idade As Integer
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Cbx_Sim_Click(sender As Object, e As EventArgs) Handles Cbx_Sim.Click
        acompanhado = True

    End Sub

    Private Sub Cbx_Nao_CheckedChanged(sender As Object, e As EventArgs) Handles Cbx_Nao.CheckedChanged
        acompanhado = False

    End Sub

    Private Sub Btn_Pricipal_Click(sender As Object, e As EventArgs) Handles Btn_Pricipal.Click
        If Txt_Idade.Text Is "" Then
            MsgBox("Por favor, digite a idade.")
        Else
            idade = Txt_Idade.Text
            If idade >= 18 Then
                Lbl_Resultado.Text = "Você pode comprar o ingresso e comparecer ao evento."
            ElseIf idade >= 16 Then
                If acompanhado Then
                    Lbl_Resultado.Text = "Você pode comprar o ingresso e comparecer ao evento" + vbCrLf + "acompanhado de seus responsáveis."
                Else
                    Lbl_Resultado.Text = "Você não pode comprar o ingresso e comparecer ao evento." + vbCrLf + "É necessário o acompanhamento de responsáveis."
                End If
            Else
                Lbl_Resultado.Text = "Você não pode comprar o ingresso ou comparecer ao evento."
            End If
            Txt_Idade.Text = ""
            acompanhado = ""

        End If
    End Sub


End Class
