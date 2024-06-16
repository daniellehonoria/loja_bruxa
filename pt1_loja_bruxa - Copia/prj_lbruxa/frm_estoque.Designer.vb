<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estoque
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estoque))
        Me.txt_prod = New System.Windows.Forms.TextBox()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabprodBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cad_userDataSet3 = New prj_lbruxa.cad_userDataSet3()
        Me.TabprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cad_userDataSet1 = New prj_lbruxa.cad_userDataSet1()
        Me.Tab_prodTableAdapter = New prj_lbruxa.cad_userDataSet1TableAdapters.tab_prodTableAdapter()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_exc = New System.Windows.Forms.Button()
        Me.txt_id_prod = New System.Windows.Forms.TextBox()
        Me.Tab_prodTableAdapter1 = New prj_lbruxa.cad_userDataSet3TableAdapters.tab_prodTableAdapter()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.IdprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabprodBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cad_userDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cad_userDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_prod
        '
        Me.txt_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_prod.Location = New System.Drawing.Point(87, 165)
        Me.txt_prod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_prod.Multiline = True
        Me.txt_prod.Name = "txt_prod"
        Me.txt_prod.Size = New System.Drawing.Size(223, 29)
        Me.txt_prod.TabIndex = 0
        '
        'txt_qtd
        '
        Me.txt_qtd.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_qtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_qtd.Location = New System.Drawing.Point(197, 223)
        Me.txt_qtd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtd.Multiline = True
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(111, 25)
        Me.txt_qtd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(84, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(84, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(194, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "quantidade"
        '
        'txt_valor
        '
        Me.txt_valor.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_valor.Location = New System.Drawing.Point(86, 223)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(106, 26)
        Me.txt_valor.TabIndex = 25
        '
        'btn_ok
        '
        Me.btn_ok.AutoSize = True
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_ok.Location = New System.Drawing.Point(158, 283)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(80, 32)
        Me.btn_ok.TabIndex = 26
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprodDataGridViewTextBoxColumn, Me.NomeprodDataGridViewTextBoxColumn, Me.QtdprodDataGridViewTextBoxColumn, Me.ValorprodDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabprodBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(431, 66)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(473, 249)
        Me.DataGridView1.TabIndex = 27
        '
        'TabprodBindingSource1
        '
        Me.TabprodBindingSource1.DataMember = "tab_prod"
        Me.TabprodBindingSource1.DataSource = Me.Cad_userDataSet3
        '
        'Cad_userDataSet3
        '
        Me.Cad_userDataSet3.DataSetName = "cad_userDataSet3"
        Me.Cad_userDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabprodBindingSource
        '
        Me.TabprodBindingSource.DataMember = "tab_prod"
        Me.TabprodBindingSource.DataSource = Me.Cad_userDataSet1
        '
        'Cad_userDataSet1
        '
        Me.Cad_userDataSet1.DataSetName = "cad_userDataSet1"
        Me.Cad_userDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tab_prodTableAdapter
        '
        Me.Tab_prodTableAdapter.ClearBeforeFill = True
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderSize = 3
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(659, 332)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(80, 32)
        Me.btn_edit.TabIndex = 29
        Me.btn_edit.Text = "EDITAR"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_exc
        '
        Me.btn_exc.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_exc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_exc.FlatAppearance.BorderSize = 3
        Me.btn_exc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_exc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_exc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_exc.Location = New System.Drawing.Point(744, 332)
        Me.btn_exc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exc.Name = "btn_exc"
        Me.btn_exc.Size = New System.Drawing.Size(80, 32)
        Me.btn_exc.TabIndex = 28
        Me.btn_exc.Text = "EXCLUIR"
        Me.btn_exc.UseVisualStyleBackColor = False
        '
        'txt_id_prod
        '
        Me.txt_id_prod.Location = New System.Drawing.Point(197, 252)
        Me.txt_id_prod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_prod.Name = "txt_id_prod"
        Me.txt_id_prod.Size = New System.Drawing.Size(111, 20)
        Me.txt_id_prod.TabIndex = 30
        Me.txt_id_prod.Visible = False
        '
        'Tab_prodTableAdapter1
        '
        Me.Tab_prodTableAdapter1.ClearBeforeFill = True
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
        Me.btn_sair.Location = New System.Drawing.Point(828, 332)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(80, 32)
        Me.btn_sair.TabIndex = 32
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'IdprodDataGridViewTextBoxColumn
        '
        Me.IdprodDataGridViewTextBoxColumn.DataPropertyName = "id_prod"
        Me.IdprodDataGridViewTextBoxColumn.HeaderText = "id_prod"
        Me.IdprodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdprodDataGridViewTextBoxColumn.Name = "IdprodDataGridViewTextBoxColumn"
        Me.IdprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdprodDataGridViewTextBoxColumn.Width = 80
        '
        'NomeprodDataGridViewTextBoxColumn
        '
        Me.NomeprodDataGridViewTextBoxColumn.DataPropertyName = "nome_prod"
        Me.NomeprodDataGridViewTextBoxColumn.HeaderText = "nome_prod"
        Me.NomeprodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomeprodDataGridViewTextBoxColumn.Name = "NomeprodDataGridViewTextBoxColumn"
        Me.NomeprodDataGridViewTextBoxColumn.Width = 180
        '
        'QtdprodDataGridViewTextBoxColumn
        '
        Me.QtdprodDataGridViewTextBoxColumn.DataPropertyName = "qtd_prod"
        Me.QtdprodDataGridViewTextBoxColumn.HeaderText = "qtd_prod"
        Me.QtdprodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QtdprodDataGridViewTextBoxColumn.Name = "QtdprodDataGridViewTextBoxColumn"
        Me.QtdprodDataGridViewTextBoxColumn.Width = 80
        '
        'ValorprodDataGridViewTextBoxColumn
        '
        Me.ValorprodDataGridViewTextBoxColumn.DataPropertyName = "valor_prod"
        Me.ValorprodDataGridViewTextBoxColumn.HeaderText = "valor_prod"
        Me.ValorprodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorprodDataGridViewTextBoxColumn.Name = "ValorprodDataGridViewTextBoxColumn"
        Me.ValorprodDataGridViewTextBoxColumn.Width = 80
        '
        'frm_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_lbruxa.My.Resources.Resources.estoque_frm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 375)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.txt_id_prod)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_exc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_qtd)
        Me.Controls.Add(Me.txt_prod)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_estoque"
        Me.Text = "frm_estoque"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabprodBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cad_userDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cad_userDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_prod As TextBox
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cad_userDataSet1 As cad_userDataSet1
    Friend WithEvents TabprodBindingSource As BindingSource
    Friend WithEvents Tab_prodTableAdapter As cad_userDataSet1TableAdapters.tab_prodTableAdapter
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_exc As Button
    Friend WithEvents txt_id_prod As TextBox
    Friend WithEvents Cad_userDataSet3 As cad_userDataSet3
    Friend WithEvents TabprodBindingSource1 As BindingSource
    Friend WithEvents Tab_prodTableAdapter1 As cad_userDataSet3TableAdapters.tab_prodTableAdapter
    Friend WithEvents btn_sair As Button
    Friend WithEvents IdprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtdprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
