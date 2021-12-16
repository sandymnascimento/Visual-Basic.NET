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
        Me.SuspendLayout()
        '
        'Btn_Pricipal
        '
        Me.Btn_Pricipal.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn_Pricipal.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Btn_Pricipal.Location = New System.Drawing.Point(123, 112)
        Me.Btn_Pricipal.Name = "Btn_Pricipal"
        Me.Btn_Pricipal.Size = New System.Drawing.Size(94, 39)
        Me.Btn_Pricipal.TabIndex = 0
        Me.Btn_Pricipal.UseVisualStyleBackColor = False
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Principal.Location = New System.Drawing.Point(45, 62)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(261, 32)
        Me.Lbl_Principal.TabIndex = 1
        Me.Lbl_Principal.Text = "Clique no botão abaixo!"
        Me.Lbl_Principal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 208)
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
End Class
