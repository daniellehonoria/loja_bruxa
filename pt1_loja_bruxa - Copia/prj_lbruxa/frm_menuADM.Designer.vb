<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menuADM
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menuADM))
        Me.btn_estoque = New System.Windows.Forms.Button()
        Me.btn_relatorios = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_estoque
        '
        Me.btn_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_estoque.BackgroundImage = CType(resources.GetObject("btn_estoque.BackgroundImage"), System.Drawing.Image)
        Me.btn_estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estoque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_estoque.Location = New System.Drawing.Point(81, 181)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(95, 127)
        Me.btn_estoque.TabIndex = 1
        Me.btn_estoque.Text = "ESTOQUE"
        Me.btn_estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_estoque.UseVisualStyleBackColor = False
        '
        'btn_relatorios
        '
        Me.btn_relatorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_relatorios.BackgroundImage = CType(resources.GetObject("btn_relatorios.BackgroundImage"), System.Drawing.Image)
        Me.btn_relatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_relatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_relatorios.Location = New System.Drawing.Point(198, 181)
        Me.btn_relatorios.Name = "btn_relatorios"
        Me.btn_relatorios.Size = New System.Drawing.Size(95, 127)
        Me.btn_relatorios.TabIndex = 2
        Me.btn_relatorios.Text = "RELATÓRIOS"
        Me.btn_relatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_relatorios.UseVisualStyleBackColor = False
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cadastro.BackgroundImage = CType(resources.GetObject("btn_cadastro.BackgroundImage"), System.Drawing.Image)
        Me.btn_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_cadastro.Location = New System.Drawing.Point(319, 181)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(97, 127)
        Me.btn_cadastro.TabIndex = 3
        Me.btn_cadastro.Text = "CADASTRO"
        Me.btn_cadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(176, 357)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(143, 44)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_menuADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(502, 496)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.btn_relatorios)
        Me.Controls.Add(Me.btn_estoque)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_menuADM"
        Me.Text = "Menu de opções"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_estoque As Button
    Friend WithEvents btn_relatorios As Button
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents btn_sair As Button
End Class
