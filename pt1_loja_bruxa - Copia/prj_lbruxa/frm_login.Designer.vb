<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_versenha = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(152, 254)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Multiline = True
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(182, 31)
        Me.txt_senha.TabIndex = 7
        Me.txt_senha.Text = "senha"
        '
        'btn_entrar
        '
        Me.btn_entrar.AutoSize = True
        Me.btn_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_entrar.Location = New System.Drawing.Point(180, 314)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(85, 32)
        Me.btn_entrar.TabIndex = 8
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(152, 195)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(186, 31)
        Me.txt_cpf.TabIndex = 6
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_sair
        '
        Me.btn_sair.AutoSize = True
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(351, 12)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(85, 32)
        Me.btn_sair.TabIndex = 9
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(94, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(66, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SENHA:"
        '
        'cb_versenha
        '
        Me.cb_versenha.AutoSize = True
        Me.cb_versenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cb_versenha.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cb_versenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cb_versenha.Location = New System.Drawing.Point(339, 254)
        Me.cb_versenha.Name = "cb_versenha"
        Me.cb_versenha.Size = New System.Drawing.Size(59, 31)
        Me.cb_versenha.TabIndex = 12
        Me.cb_versenha.Text = "Ver senha"
        Me.cb_versenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_versenha.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Desenvolvido por Peter Milanez(1680482321011) e Danielle Honória (1680482321045)"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 453)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_versenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_cpf)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_versenha As CheckBox
    Friend WithEvents Label3 As Label
End Class
