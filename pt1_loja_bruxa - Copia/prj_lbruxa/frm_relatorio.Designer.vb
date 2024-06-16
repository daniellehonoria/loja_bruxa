<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_relatorio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relatorio))
        Me.dt_grid_relat = New System.Windows.Forms.DataGridView()
        Me.btn_sair = New System.Windows.Forms.Button()
        CType(Me.dt_grid_relat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_grid_relat
        '
        Me.dt_grid_relat.AllowUserToAddRows = False
        Me.dt_grid_relat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.dt_grid_relat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.dt_grid_relat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid_relat.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dt_grid_relat.DefaultCellStyle = DataGridViewCellStyle1
        Me.dt_grid_relat.Location = New System.Drawing.Point(17, 96)
        Me.dt_grid_relat.Name = "dt_grid_relat"
        Me.dt_grid_relat.RowHeadersVisible = False
        Me.dt_grid_relat.Size = New System.Drawing.Size(469, 345)
        Me.dt_grid_relat.TabIndex = 0
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.FlatAppearance.BorderSize = 3
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(406, 463)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(80, 32)
        Me.btn_sair.TabIndex = 33
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_lbruxa.My.Resources.Resources.relat_fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(504, 496)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.dt_grid_relat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relatorio"
        Me.Text = "Relatório de vendas"
        CType(Me.dt_grid_relat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dt_grid_relat As DataGridView
    Friend WithEvents btn_sair As Button
End Class
