<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_nasc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.input_admin = New System.Windows.Forms.CheckedListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NascimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenhaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabcadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cad_userDataSet = New prj_lbruxa.cad_userDataSet()
        Me.Tab_cadastroTableAdapter = New prj_lbruxa.cad_userDataSetTableAdapters.tab_cadastroTableAdapter()
        Me.btn_exc = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_bloq = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_blq = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_user = New System.Windows.Forms.TextBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Cad_userDataSet4 = New prj_lbruxa.cad_userDataSet4()
        Me.TabcadastroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_cadastroTableAdapter1 = New prj_lbruxa.cad_userDataSet4TableAdapters.tab_cadastroTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabcadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cad_userDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cad_userDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabcadastroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(109, 245)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(140, 26)
        Me.txt_cpf.TabIndex = 1
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_nome.Location = New System.Drawing.Point(109, 193)
        Me.txt_nome.Multiline = True
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(273, 32)
        Me.txt_nome.TabIndex = 0
        '
        'txt_nasc
        '
        Me.txt_nasc.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_nasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nasc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_nasc.Location = New System.Drawing.Point(255, 245)
        Me.txt_nasc.Mask = "99/99/9999"
        Me.txt_nasc.Name = "txt_nasc"
        Me.txt_nasc.Size = New System.Drawing.Size(127, 26)
        Me.txt_nasc.TabIndex = 2
        Me.txt_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(109, 353)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(187, 32)
        Me.txt_email.TabIndex = 5
        '
        'txt_tel
        '
        Me.txt_tel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_tel.Location = New System.Drawing.Point(109, 300)
        Me.txt_tel.Multiline = True
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(140, 32)
        Me.txt_tel.TabIndex = 3
        '
        'btn_ok
        '
        Me.btn_ok.AutoSize = True
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_ok.Location = New System.Drawing.Point(199, 405)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(80, 32)
        Me.btn_ok.TabIndex = 7
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(255, 300)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Multiline = True
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(126, 31)
        Me.txt_senha.TabIndex = 4
        '
        'input_admin
        '
        Me.input_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.input_admin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input_admin.CheckOnClick = True
        Me.input_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_admin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.input_admin.FormattingEnabled = True
        Me.input_admin.Items.AddRange(New Object() {"ADM"})
        Me.input_admin.Location = New System.Drawing.Point(300, 362)
        Me.input_admin.Margin = New System.Windows.Forms.Padding(2)
        Me.input_admin.Name = "input_admin"
        Me.input_admin.Size = New System.Drawing.Size(67, 14)
        Me.input_admin.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IduserDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.CpfDataGridViewTextBoxColumn, Me.NascimentoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.SenhaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabcadastroBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(482, 72)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(608, 322)
        Me.DataGridView1.TabIndex = 11
        '
        'IduserDataGridViewTextBoxColumn
        '
        Me.IduserDataGridViewTextBoxColumn.DataPropertyName = "id_user"
        Me.IduserDataGridViewTextBoxColumn.HeaderText = "id_user"
        Me.IduserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IduserDataGridViewTextBoxColumn.Name = "IduserDataGridViewTextBoxColumn"
        Me.IduserDataGridViewTextBoxColumn.ReadOnly = True
        Me.IduserDataGridViewTextBoxColumn.Width = 50
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomeDataGridViewTextBoxColumn.Width = 80
        '
        'CpfDataGridViewTextBoxColumn
        '
        Me.CpfDataGridViewTextBoxColumn.DataPropertyName = "cpf"
        Me.CpfDataGridViewTextBoxColumn.HeaderText = "cpf"
        Me.CpfDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CpfDataGridViewTextBoxColumn.Name = "CpfDataGridViewTextBoxColumn"
        Me.CpfDataGridViewTextBoxColumn.ReadOnly = True
        Me.CpfDataGridViewTextBoxColumn.Width = 60
        '
        'NascimentoDataGridViewTextBoxColumn
        '
        Me.NascimentoDataGridViewTextBoxColumn.DataPropertyName = "nascimento"
        Me.NascimentoDataGridViewTextBoxColumn.HeaderText = "nascimento"
        Me.NascimentoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NascimentoDataGridViewTextBoxColumn.Name = "NascimentoDataGridViewTextBoxColumn"
        Me.NascimentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NascimentoDataGridViewTextBoxColumn.Width = 70
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 80
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "telefone"
        Me.TelefoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefoneDataGridViewTextBoxColumn.Width = 60
        '
        'SenhaDataGridViewTextBoxColumn
        '
        Me.SenhaDataGridViewTextBoxColumn.DataPropertyName = "senha"
        Me.SenhaDataGridViewTextBoxColumn.HeaderText = "senha"
        Me.SenhaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SenhaDataGridViewTextBoxColumn.Name = "SenhaDataGridViewTextBoxColumn"
        Me.SenhaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SenhaDataGridViewTextBoxColumn.Width = 52
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 52
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 52
        '
        'TabcadastroBindingSource
        '
        Me.TabcadastroBindingSource.DataMember = "tab_cadastro"
        Me.TabcadastroBindingSource.DataSource = Me.Cad_userDataSet
        '
        'Cad_userDataSet
        '
        Me.Cad_userDataSet.DataSetName = "cad_userDataSet"
        Me.Cad_userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tab_cadastroTableAdapter
        '
        Me.Tab_cadastroTableAdapter.ClearBeforeFill = True
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
        Me.btn_exc.Location = New System.Drawing.Point(920, 417)
        Me.btn_exc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exc.Name = "btn_exc"
        Me.btn_exc.Size = New System.Drawing.Size(80, 32)
        Me.btn_exc.TabIndex = 12
        Me.btn_exc.Text = "EXCLUIR"
        Me.btn_exc.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderSize = 3
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(835, 417)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(80, 32)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "EDITAR"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_bloq
        '
        Me.btn_bloq.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_bloq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_bloq.FlatAppearance.BorderSize = 3
        Me.btn_bloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bloq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_bloq.Location = New System.Drawing.Point(745, 417)
        Me.btn_bloq.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_bloq.Name = "btn_bloq"
        Me.btn_bloq.Size = New System.Drawing.Size(86, 32)
        Me.btn_bloq.TabIndex = 14
        Me.btn_bloq.Text = "BLOQ/DESB"
        Me.btn_bloq.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_bloq.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(106, 337)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "e-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(106, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(253, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "senha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(106, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "cpf"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(253, 228)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "nascimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(106, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "nome"
        '
        'lbl_blq
        '
        Me.lbl_blq.AutoSize = True
        Me.lbl_blq.Location = New System.Drawing.Point(143, 405)
        Me.lbl_blq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_blq.Name = "lbl_blq"
        Me.lbl_blq.Size = New System.Drawing.Size(0, 13)
        Me.lbl_blq.TabIndex = 22
        Me.lbl_blq.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(844, 461)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "*Para utilizar os botões acima, selecione uma linha"
        '
        'txt_id_user
        '
        Me.txt_id_user.Location = New System.Drawing.Point(220, 72)
        Me.txt_id_user.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_user.Name = "txt_id_user"
        Me.txt_id_user.Size = New System.Drawing.Size(76, 20)
        Me.txt_id_user.TabIndex = 24
        Me.txt_id_user.Visible = False
        '
        'btn_sair
        '
        Me.btn_sair.AutoSize = True
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(1003, 416)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(85, 32)
        Me.btn_sair.TabIndex = 25
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Cad_userDataSet4
        '
        Me.Cad_userDataSet4.DataSetName = "cad_userDataSet4"
        Me.Cad_userDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabcadastroBindingSource1
        '
        Me.TabcadastroBindingSource1.DataMember = "tab_cadastro"
        Me.TabcadastroBindingSource1.DataSource = Me.Cad_userDataSet4
        '
        'Tab_cadastroTableAdapter1
        '
        Me.Tab_cadastroTableAdapter1.ClearBeforeFill = True
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1124, 509)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.txt_id_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_blq)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_bloq)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_exc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.input_admin)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nasc)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_cpf)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro"
        Me.Text = "Novo usuário"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabcadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cad_userDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cad_userDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabcadastroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_nasc As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents input_admin As CheckedListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cad_userDataSet As cad_userDataSet
    Friend WithEvents TabcadastroBindingSource As BindingSource
    Friend WithEvents Tab_cadastroTableAdapter As cad_userDataSetTableAdapters.tab_cadastroTableAdapter
    Friend WithEvents btn_exc As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_bloq As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_blq As Label
    Friend WithEvents IduserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CpfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NascimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SenhaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_user As TextBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents Cad_userDataSet4 As cad_userDataSet4
    Friend WithEvents TabcadastroBindingSource1 As BindingSource
    Friend WithEvents Tab_cadastroTableAdapter1 As cad_userDataSet4TableAdapters.tab_cadastroTableAdapter
End Class
