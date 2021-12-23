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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TelaPrincipal))
        Me.Btn_Pricipal = New System.Windows.Forms.Button()
        Me.Lbl_PedeNumero = New System.Windows.Forms.Label()
        Me.Txt_ASCII = New System.Windows.Forms.TextBox()
        Me.Lbl_InfoASCII = New System.Windows.Forms.Label()
        Me.Txt_EntradaLista = New System.Windows.Forms.TextBox()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.Btn_AddLista = New System.Windows.Forms.Button()
        Me.Btn_ExibeLista = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Pricipal
        '
        Me.Btn_Pricipal.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Pricipal.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_Pricipal.Location = New System.Drawing.Point(101, 83)
        Me.Btn_Pricipal.Name = "Btn_Pricipal"
        Me.Btn_Pricipal.Size = New System.Drawing.Size(100, 34)
        Me.Btn_Pricipal.TabIndex = 0
        Me.Btn_Pricipal.UseVisualStyleBackColor = False
        '
        'Lbl_PedeNumero
        '
        Me.Lbl_PedeNumero.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_PedeNumero.Location = New System.Drawing.Point(12, 18)
        Me.Lbl_PedeNumero.Name = "Lbl_PedeNumero"
        Me.Lbl_PedeNumero.Size = New System.Drawing.Size(308, 33)
        Me.Lbl_PedeNumero.TabIndex = 1
        Me.Lbl_PedeNumero.Text = "Digite um número (entre 33 e 127) "
        Me.Lbl_PedeNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_ASCII
        '
        Me.Txt_ASCII.Location = New System.Drawing.Point(117, 54)
        Me.Txt_ASCII.Name = "Txt_ASCII"
        Me.Txt_ASCII.Size = New System.Drawing.Size(71, 23)
        Me.Txt_ASCII.TabIndex = 2
        '
        'Lbl_InfoASCII
        '
        Me.Lbl_InfoASCII.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_InfoASCII.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_InfoASCII.Location = New System.Drawing.Point(21, 120)
        Me.Lbl_InfoASCII.Name = "Lbl_InfoASCII"
        Me.Lbl_InfoASCII.Size = New System.Drawing.Size(263, 63)
        Me.Lbl_InfoASCII.TabIndex = 3
        Me.Lbl_InfoASCII.Text = "E veja a qual caraceter ele corresponde segundo a tabela ASCII!"
        Me.Lbl_InfoASCII.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_EntradaLista
        '
        Me.Txt_EntradaLista.Location = New System.Drawing.Point(21, 237)
        Me.Txt_EntradaLista.Name = "Txt_EntradaLista"
        Me.Txt_EntradaLista.Size = New System.Drawing.Size(167, 23)
        Me.Txt_EntradaLista.TabIndex = 4
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(21, 266)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(167, 122)
        Me.Txt_Lista.TabIndex = 5
        '
        'Btn_AddLista
        '
        Me.Btn_AddLista.Location = New System.Drawing.Point(195, 237)
        Me.Btn_AddLista.Name = "Btn_AddLista"
        Me.Btn_AddLista.Size = New System.Drawing.Size(98, 23)
        Me.Btn_AddLista.TabIndex = 6
        Me.Btn_AddLista.Text = "Adicione à lista"
        Me.Btn_AddLista.UseVisualStyleBackColor = True
        '
        'Btn_ExibeLista
        '
        Me.Btn_ExibeLista.Location = New System.Drawing.Point(21, 394)
        Me.Btn_ExibeLista.Name = "Btn_ExibeLista"
        Me.Btn_ExibeLista.Size = New System.Drawing.Size(272, 23)
        Me.Btn_ExibeLista.TabIndex = 7
        Me.Btn_ExibeLista.Text = "Exibir a lista"
        Me.Btn_ExibeLista.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Digite elementos para sua lista:"
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 429)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_ExibeLista)
        Me.Controls.Add(Me.Btn_AddLista)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Txt_EntradaLista)
        Me.Controls.Add(Me.Lbl_InfoASCII)
        Me.Controls.Add(Me.Txt_ASCII)
        Me.Controls.Add(Me.Lbl_PedeNumero)
        Me.Controls.Add(Me.Btn_Pricipal)
        Me.Name = "Frm_TelaPrincipal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Pricipal As Button
    Friend WithEvents Lbl_PedeNumero As Label
    Friend WithEvents Txt_ASCII As TextBox
    Friend WithEvents Lbl_InfoASCII As Label
    Friend WithEvents Txt_EntradaLista As TextBox
    Friend WithEvents Txt_Lista As TextBox
    Friend WithEvents Btn_AddLista As Button
    Friend WithEvents Btn_ExibeLista As Button
    Friend WithEvents Label1 As Label
End Class
