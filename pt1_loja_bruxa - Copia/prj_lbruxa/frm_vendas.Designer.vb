<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_vendas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vendas))
        Me.cbx_busca = New System.Windows.Forms.ComboBox()
        Me.Cad_userDataSet2 = New prj_lbruxa.cad_userDataSet2()
        Me.TabvendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_vendaTableAdapter = New prj_lbruxa.cad_userDataSet2TableAdapters.tab_vendaTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nome_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_fecharpedido = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.Cad_userDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabvendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_busca
        '
        Me.cbx_busca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_busca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_busca.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cbx_busca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbx_busca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_busca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cbx_busca.FormattingEnabled = True
        Me.cbx_busca.ItemHeight = 27
        Me.cbx_busca.Location = New System.Drawing.Point(126, 69)
        Me.cbx_busca.Name = "cbx_busca"
        Me.cbx_busca.Size = New System.Drawing.Size(273, 33)
        Me.cbx_busca.TabIndex = 0
        Me.cbx_busca.Text = "Digite o nome do produto:"
        '
        'Cad_userDataSet2
        '
        Me.Cad_userDataSet2.DataSetName = "cad_userDataSet2"
        Me.Cad_userDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabvendaBindingSource
        '
        Me.TabvendaBindingSource.DataMember = "tab_venda"
        Me.TabvendaBindingSource.DataSource = Me.Cad_userDataSet2
        '
        'Tab_vendaTableAdapter
        '
        Me.Tab_vendaTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_prod, Me.qtd_prod, Me.valor_prod})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(88, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(338, 268)
        Me.DataGridView1.TabIndex = 1
        '
        'nome_prod
        '
        Me.nome_prod.HeaderText = "Produto"
        Me.nome_prod.Name = "nome_prod"
        Me.nome_prod.ReadOnly = True
        Me.nome_prod.Width = 125
        '
        'qtd_prod
        '
        Me.qtd_prod.HeaderText = "Qtde"
        Me.qtd_prod.Name = "qtd_prod"
        '
        'valor_prod
        '
        Me.valor_prod.HeaderText = "Preço"
        Me.valor_prod.Name = "valor_prod"
        Me.valor_prod.ReadOnly = True
        Me.valor_prod.Width = 110
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lbl_total.Location = New System.Drawing.Point(119, 448)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(107, 31)
        Me.lbl_total.TabIndex = 2
        Me.lbl_total.Text = "0,00"
        '
        'btn_fecharpedido
        '
        Me.btn_fecharpedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_fecharpedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_fecharpedido.Location = New System.Drawing.Point(349, 424)
        Me.btn_fecharpedido.Name = "btn_fecharpedido"
        Me.btn_fecharpedido.Size = New System.Drawing.Size(63, 46)
        Me.btn_fecharpedido.TabIndex = 3
        Me.btn_fecharpedido.Text = "FECHAR PEDIDO"
        Me.btn_fecharpedido.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(442, 425)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(60, 44)
        Me.btn_sair.TabIndex = 4
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(212, 425)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(119, 46)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "CANCELAR PEDIDO"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frm_vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(519, 521)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_fecharpedido)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbx_busca)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_vendas"
        Me.Text = "VENDA"
        CType(Me.Cad_userDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabvendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbx_busca As ComboBox
    Friend WithEvents Cad_userDataSet2 As cad_userDataSet2
    Friend WithEvents TabvendaBindingSource As BindingSource
    Friend WithEvents Tab_vendaTableAdapter As cad_userDataSet2TableAdapters.tab_vendaTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_fecharpedido As Button
    Friend WithEvents nome_prod As DataGridViewTextBoxColumn
    Friend WithEvents qtd_prod As DataGridViewTextBoxColumn
    Friend WithEvents valor_prod As DataGridViewTextBoxColumn
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_cancelar As Button
End Class
