Public Class frm_cadastro
    Private tipo As Object
    Private editingMode As Boolean = False ' Variável para controlar o modo de edição

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Cad_userDataSet4.tab_cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tab_cadastroTableAdapter1.Fill(Me.Cad_userDataSet4.tab_cadastro)
        'TODO: esta linha de código carrega dados na tabela 'Cad_userDataSet.tab_cadastro'. Você pode movê-la ou removê-la conforme necessário.
        'Me.Tab_cadastroTableAdapter.Fill(Me.Cad_userDataSet.tab_cadastro)
        'conecta_banco_sql_server()
        frm_login.Hide()
        Me.Show()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Try
            If Not editingMode Then ' Se não estiver no modo de edição, execute o código de inserção
                sql = "select * from tab_cadastro where cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("CPF já cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    Dim tipo As String
                    If input_admin.GetItemChecked(0) Then
                        tipo = "ADM" ' Se o item do CheckedListBox está marcado, é ADM
                    Else
                        tipo = "CAIXA" ' Se o item do CheckedListBox não está marcado, é CAIXA
                    End If

                    sql = "insert into tab_cadastro(nome,cpf,nascimento,telefone,senha,email,status,tipo) values ('" & txt_nome.Text & "', '" & txt_cpf.Text & "', '" & txt_nasc.Text & "', '" & txt_tel.Text & "', '" & txt_senha.Text & "', '" & txt_email.Text & "', 'DESBLOQ', '" & tipo & "')"
                    rs = db.Execute(sql)

                    MsgBox("Cadastro realizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_nome.Clear()
                    txt_cpf.Clear()
                    txt_nasc.Clear()
                    txt_tel.Clear()
                    txt_senha.Clear()
                    txt_email.Clear()
                    input_admin.ClearSelected()
                    txt_nome.Focus()
                End If
            Else ' Se estiver no modo de edição, execute o código de atualização
                Dim sqlUpdate As String = "UPDATE tab_cadastro SET nome = '" & txt_nome.Text & "', nascimento = '" & txt_nasc.Text & "', telefone = '" & txt_tel.Text & "', senha = '" & txt_senha.Text & "', email = '" & txt_email.Text & "', status = '" & lbl_blq.Text & "' WHERE id_user = '" & txt_id_user.Text & "'"
                rs = db.Execute(sqlUpdate)

                MsgBox("Registro atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                ' Volte o formulário para o modo de inserção
                editingMode = False
                btn_ok.Text = "OK"
            End If

            ' Atualize a DataGridView para refletir as alterações
            Me.Tab_cadastroTableAdapter1.Fill(Me.Cad_userDataSet4.tab_cadastro)
        Catch ex As Exception
            MsgBox("Erro ao cadastrar ou atualizar registro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_exc_Click(sender As Object, e As EventArgs) Handles btn_exc.Click
        Try
            ' Verifica se há uma linha selecionada na DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Obtém o índice da linha selecionada
                Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

                ' Procura o valor do CPF na linha selecionada
                Dim id As String = ""

                For Each cell As DataGridViewCell In DataGridView1.Rows(rowIndex).Cells
                    If cell.OwningColumn.HeaderText = "id_user" Then ' Substitua "id" pelo cabeçalho correto da coluna
                        id = cell.Value.ToString()
                        Exit For
                    End If
                Next

                ' Confirmação de exclusão
                Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                If resp = MsgBoxResult.Yes Then
                    ' Constrói a instrução SQL para excluir o registro com base no id
                    Dim sqlDelete As String = "DELETE FROM tab_cadastro WHERE id_user = '" & id & "'"

                    ' Executa o comando SQL para excluir o registro com base no CPF
                    rs = db.Execute(sqlDelete)

                    MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    ' Atualiza a DataGridView após a exclusão
                    Me.Tab_cadastroTableAdapter1.Fill(Me.Cad_userDataSet4.tab_cadastro)
                End If
            Else
                MsgBox("Selecione um único registro para excluir.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir registro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            ' Verifica se há uma linha selecionada na DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Obtém o índice da linha selecionada
                Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

                Dim cpf As String = ""

                For Each cell As DataGridViewCell In DataGridView1.Rows(rowIndex).Cells
                    If cell.OwningColumn.HeaderText = "cpf" Then ' Substitua "cpf" pelo cabeçalho correto da coluna
                        cpf = cell.Value.ToString()
                        Exit For
                    End If
                Next

                ' Constrói a instrução SQL para obter todos os dados do registro com base no CPF
                Dim sqlSelect As String = "SELECT * FROM tab_cadastro WHERE cpf = '" & cpf & "'"
                rs = db.Execute(sqlSelect)

                ' Verifica se o registro foi encontrado
                If Not rs.EOF Then
                    ' Exibir os dados no formulário de edição
                    txt_id_user.Text = rs.Fields("id_user").Value.ToString()
                    txt_nome.Text = rs.Fields("nome").Value.ToString()
                    txt_cpf.Text = rs.Fields("cpf").Value.ToString()
                    txt_nasc.Text = rs.Fields("nascimento").Value.ToString()
                    txt_email.Text = rs.Fields("email").Value.ToString()
                    txt_tel.Text = rs.Fields("telefone").Value.ToString()
                    txt_senha.Text = rs.Fields("senha").Value.ToString()
                    lbl_blq.Text = rs.Fields("status").Value.ToString()

                    ' Altera o texto do botão para "Salvar"
                    btn_ok.Text = "Salvar"

                    ' Define que estamos no modo de edição
                    editingMode = True
                Else
                    MsgBox("Registro não encontrado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Else
                MsgBox("Selecione um único registro para editar.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao editar registro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_bloq_Click(sender As Object, e As EventArgs) Handles btn_bloq.Click
        btn_edit_Click(sender, e)

        If lbl_blq.Text.ToUpper = "DESBLOQ" Then
            lbl_blq.Text = "BLOQ"
        Else
            lbl_blq.Text = "DESBLOQ"
        End If

        btn_ok_Click(sender, e)
        txt_nome.Clear()
        txt_cpf.Clear()
        txt_nasc.Clear()
        txt_tel.Clear()
        txt_senha.Clear()
        txt_email.Clear()
        input_admin.ClearSelected()
        txt_nome.Focus()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click

        frm_menuADM.Show()
        Me.Hide()

    End Sub
End Class

