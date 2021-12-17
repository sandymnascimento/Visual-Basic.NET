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
        Me.Btn_Inteiros = New System.Windows.Forms.Button()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_Decimais = New System.Windows.Forms.Button()
        Me.Btn_IntNegativo = New System.Windows.Forms.Button()
        Me.Btn_DbNegativo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn_Soma = New System.Windows.Forms.Button()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Btn_Multiplicacao = New System.Windows.Forms.Button()
        Me.Btn_Subtracao = New System.Windows.Forms.Button()
        Me.Btn_Divisao = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Inteiros
        '
        Me.Btn_Inteiros.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Inteiros.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_Inteiros.Location = New System.Drawing.Point(166, 67)
        Me.Btn_Inteiros.Name = "Btn_Inteiros"
        Me.Btn_Inteiros.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Inteiros.TabIndex = 0
        Me.Btn_Inteiros.Text = "Inteiros"
        Me.Btn_Inteiros.UseVisualStyleBackColor = False
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Principal.Location = New System.Drawing.Point(117, 23)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(575, 41)
        Me.Lbl_Principal.TabIndex = 1
        Me.Lbl_Principal.Text = "Clique nos botões abaixo para gerar um número aleatório."
        Me.Lbl_Principal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Decimais
        '
        Me.Btn_Decimais.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Decimais.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_Decimais.Location = New System.Drawing.Point(404, 67)
        Me.Btn_Decimais.Name = "Btn_Decimais"
        Me.Btn_Decimais.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Decimais.TabIndex = 3
        Me.Btn_Decimais.Text = "Decimais"
        Me.Btn_Decimais.UseVisualStyleBackColor = False
        '
        'Btn_IntNegativo
        '
        Me.Btn_IntNegativo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_IntNegativo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_IntNegativo.Location = New System.Drawing.Point(285, 67)
        Me.Btn_IntNegativo.Name = "Btn_IntNegativo"
        Me.Btn_IntNegativo.Size = New System.Drawing.Size(113, 50)
        Me.Btn_IntNegativo.TabIndex = 4
        Me.Btn_IntNegativo.Text = "Inteiro negativo"
        Me.Btn_IntNegativo.UseVisualStyleBackColor = False
        '
        'Btn_DbNegativo
        '
        Me.Btn_DbNegativo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_DbNegativo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_DbNegativo.Location = New System.Drawing.Point(523, 67)
        Me.Btn_DbNegativo.Name = "Btn_DbNegativo"
        Me.Btn_DbNegativo.Size = New System.Drawing.Size(113, 50)
        Me.Btn_DbNegativo.TabIndex = 5
        Me.Btn_DbNegativo.Text = "Decimal negativo"
        Me.Btn_DbNegativo.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(323, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 23)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(404, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 23)
        Me.TextBox2.TabIndex = 7
        '
        'Btn_Soma
        '
        Me.Btn_Soma.Location = New System.Drawing.Point(323, 205)
        Me.Btn_Soma.Name = "Btn_Soma"
        Me.Btn_Soma.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Soma.TabIndex = 8
        Me.Btn_Soma.Text = " +"
        Me.Btn_Soma.UseVisualStyleBackColor = True
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_Resultado.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Resultado.Location = New System.Drawing.Point(387, 292)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(0, 22)
        Me.Lbl_Resultado.TabIndex = 9
        '
        'Btn_Multiplicacao
        '
        Me.Btn_Multiplicacao.Location = New System.Drawing.Point(323, 234)
        Me.Btn_Multiplicacao.Name = "Btn_Multiplicacao"
        Me.Btn_Multiplicacao.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Multiplicacao.TabIndex = 10
        Me.Btn_Multiplicacao.Text = "x"
        Me.Btn_Multiplicacao.UseVisualStyleBackColor = True
        '
        'Btn_Subtracao
        '
        Me.Btn_Subtracao.Location = New System.Drawing.Point(404, 205)
        Me.Btn_Subtracao.Name = "Btn_Subtracao"
        Me.Btn_Subtracao.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Subtracao.TabIndex = 11
        Me.Btn_Subtracao.Text = "-"
        Me.Btn_Subtracao.UseVisualStyleBackColor = True
        '
        'Btn_Divisao
        '
        Me.Btn_Divisao.Location = New System.Drawing.Point(404, 234)
        Me.Btn_Divisao.Name = "Btn_Divisao"
        Me.Btn_Divisao.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Divisao.TabIndex = 12
        Me.Btn_Divisao.Text = "/"
        Me.Btn_Divisao.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(317, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Calculadora rústica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(364, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Resultado"
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 332)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Divisao)
        Me.Controls.Add(Me.Btn_Subtracao)
        Me.Controls.Add(Me.Btn_Multiplicacao)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Btn_Soma)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_DbNegativo)
        Me.Controls.Add(Me.Btn_IntNegativo)
        Me.Controls.Add(Me.Btn_Decimais)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.Btn_Inteiros)
        Me.Name = "Frm_TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerando números"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Inteiros As Button
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Decimais As Button
    Friend WithEvents Btn_IntNegativo As Button
    Friend WithEvents Btn_DbNegativo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn_Soma As Button
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Btn_Multiplicacao As Button
    Friend WithEvents Btn_Subtracao As Button
    Friend WithEvents Btn_Divisao As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

