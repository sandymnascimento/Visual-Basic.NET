<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Pricipal = New System.Windows.Forms.Button()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Lbl_PedeIdade = New System.Windows.Forms.Label()
        Me.Lbl_Responsaveis = New System.Windows.Forms.Label()
        Me.Cbx_Sim = New System.Windows.Forms.CheckBox()
        Me.Cbx_Nao = New System.Windows.Forms.CheckBox()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Pricipal
        '
        Me.Btn_Pricipal.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Pricipal.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_Pricipal.Location = New System.Drawing.Point(28, 287)
        Me.Btn_Pricipal.Name = "Btn_Pricipal"
        Me.Btn_Pricipal.Size = New System.Drawing.Size(94, 39)
        Me.Btn_Pricipal.TabIndex = 0
        Me.Btn_Pricipal.UseVisualStyleBackColor = False
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Principal.AutoEllipsis = True
        Me.Lbl_Principal.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Principal.Location = New System.Drawing.Point(41, 21)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(292, 75)
        Me.Lbl_Principal.TabIndex = 1
        Me.Lbl_Principal.Text = "Verifique se pode comparecer ao evento"
        Me.Lbl_Principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_Principal.UseMnemonic = False
        '
        'Lbl_PedeIdade
        '
        Me.Lbl_PedeIdade.AutoSize = True
        Me.Lbl_PedeIdade.Location = New System.Drawing.Point(28, 119)
        Me.Lbl_PedeIdade.Name = "Lbl_PedeIdade"
        Me.Lbl_PedeIdade.Size = New System.Drawing.Size(100, 15)
        Me.Lbl_PedeIdade.TabIndex = 2
        Me.Lbl_PedeIdade.Text = "Digite a sua idade"
        '
        'Lbl_Responsaveis
        '
        Me.Lbl_Responsaveis.AutoSize = True
        Me.Lbl_Responsaveis.Location = New System.Drawing.Point(28, 192)
        Me.Lbl_Responsaveis.Name = "Lbl_Responsaveis"
        Me.Lbl_Responsaveis.Size = New System.Drawing.Size(238, 15)
        Me.Lbl_Responsaveis.TabIndex = 3
        Me.Lbl_Responsaveis.Text = "Está acompanhado dos responsáveis legais?"
        '
        'Cbx_Sim
        '
        Me.Cbx_Sim.AutoSize = True
        Me.Cbx_Sim.Location = New System.Drawing.Point(28, 227)
        Me.Cbx_Sim.Name = "Cbx_Sim"
        Me.Cbx_Sim.Size = New System.Drawing.Size(46, 19)
        Me.Cbx_Sim.TabIndex = 5
        Me.Cbx_Sim.Text = "Sim"
        Me.Cbx_Sim.UseVisualStyleBackColor = True
        '
        'Cbx_Nao
        '
        Me.Cbx_Nao.AutoSize = True
        Me.Cbx_Nao.Location = New System.Drawing.Point(28, 252)
        Me.Cbx_Nao.Name = "Cbx_Nao"
        Me.Cbx_Nao.Size = New System.Drawing.Size(48, 19)
        Me.Cbx_Nao.TabIndex = 6
        Me.Cbx_Nao.Text = "Não"
        Me.Cbx_Nao.UseVisualStyleBackColor = True
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(28, 146)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Idade.TabIndex = 7
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoEllipsis = True
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Resultado.Location = New System.Drawing.Point(28, 377)
        Me.Lbl_Resultado.MinimumSize = New System.Drawing.Size(305, 50)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(305, 50)
        Me.Lbl_Resultado.TabIndex = 8
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 491)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Cbx_Nao)
        Me.Controls.Add(Me.Cbx_Sim)
        Me.Controls.Add(Me.Lbl_Responsaveis)
        Me.Controls.Add(Me.Lbl_PedeIdade)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.Btn_Pricipal)
        Me.Name = "Frm_TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primeira aplicação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Pricipal As Button
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Lbl_PedeIdade As Label
    Friend WithEvents Lbl_Responsaveis As Label
    Friend WithEvents Cbx_Sim As CheckBox
    Friend WithEvents Cbx_Nao As CheckBox
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Lbl_Resultado As Label
End Class

