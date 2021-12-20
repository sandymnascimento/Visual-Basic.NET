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
        Me.Lbl_PedeNumero = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_InfoASCII = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Pricipal
        '
        Me.Btn_Pricipal.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Pricipal.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_Pricipal.Location = New System.Drawing.Point(103, 83)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 23)
        Me.TextBox1.TabIndex = 2
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
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 228)
        Me.Controls.Add(Me.Lbl_InfoASCII)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_PedeNumero)
        Me.Controls.Add(Me.Btn_Pricipal)
        Me.Name = "Frm_TelaPrincipal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primeira aplicação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Pricipal As Button
    Friend WithEvents Lbl_PedeNumero As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_InfoASCII As Label
End Class
