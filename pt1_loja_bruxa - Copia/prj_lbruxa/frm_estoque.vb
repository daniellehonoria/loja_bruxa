Public Class frm_estoque
    Private tipo As Object
    Private editingMode As Boolean = False ' Variável para controlar o modo de edição
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Cad_userDataSet3.tab_prod'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tab_prodTableAdapter1.Fill(Me.Cad_userDataSet3.tab_prod)
        'TODO: esta linha de código carrega dados na tabela 'Cad_userDataSet.tab_prod'. Pode ser movida ou removida se necessário.
        'Me.Tab_prodTableAdapter.Fill(Me.Cad_userDataSet1.tab_prod)
        'conecta_banco_sql_server()

    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try

            If Not editingMode Then ' Se não estiver no modo de edição, execute o código de inserção
                sql = "select * from tab_prod where nome_prod = '" & txt_prod.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Produto já cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "insert into tab_prod(nome_prod,valor_prod,qtd_prod) values ('" & txt_prod.Text & "', " & txt_valor.Text & ", " & txt_qtd.Text & ")"
                    rs = db.Execute(sql)

                    MsgBox("Produto cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_prod.Clear()
                    txt_valor.Clear()
                    txt_qtd.Clear()
                    txt_prod.Focus()
                End If
            Else ' Se estiver no modo de edição, execute o código de atualização
                Dim sqlUpdate As String = "UPDATE tab_prod SET nome_prod = '" & txt_prod.Text & "', valor_prod = " & txt_valor.Text & ", qtd_prod = " & txt_qtd.Text & " WHERE id_prod = '" & txt_id_prod.Text & "'"
                rs = db.Execute(sqlUpdate)

                MsgBox("Dados do produto atualizados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                ' Volte o formulário para o modo de inserção
                editingMode = False
                btn_ok.Text = "OK"
            End If

            ' Atualize a DataGridView para refletir as alterações
            Me.Tab_prodTableAdapter1.Fill(Me.Cad_userDataSet3.tab_prod)
        Catch ex As Exception
            MsgBox("Erro ao cadastrar ou atualizar registro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")

        End Try
    End Sub

    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'esta linha de código carrega dados na tabela 'Cad_userDataSet1.tab_prod'
        Me.Tab_prodTableAdapter1.Fill(Me.Cad_userDataSet3.tab_prod)

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            ' Verifica se há uma linha selecionada na DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Pega o índice da linha selecionada
                Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

                Dim prod As String = ""

                For Each cell As DataGridViewCell In DataGridView1.Rows(rowIndex).Cells
                    If cell.OwningColumn.HeaderText = "nome_prod" Then ' Substitua "nome do produto" pelo cabeçalho correto da coluna
                        prod = cell.Value.ToString()
                        Exit For
                    End If
                Next

                ' Constrói a instrução SQL para obter todos os dados do registro com base no produto
                Dim sqlSelect As String = "SELECT * FROM tab_prod WHERE nome_prod = '" & prod & "'"
                rs = db.Execute(sqlSelect)

                ' Verifica se o registro foi encontrado
                If Not rs.EOF Then
                    ' Exibir os dados no formulário de edição
                    txt_id_prod.Text = rs.Fields("id_prod").Value.ToString()
                    txt_prod.Text = rs.Fields("nome_prod").Value.ToString()
                    txt_valor.Text = rs.Fields("valor_prod").Value.ToString()
                    txt_qtd.Text = rs.Fields("qtd_prod").Value.ToString()

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

    Private Sub btn_exc_Click(sender As Object, e As EventArgs) Handles btn_exc.Click
        Try
            ' Verifica se há uma linha selecionada na DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then

                ' Obtém o índice da linha selecionada
                Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

                ' Procura o valor do nome do produto na linha selecionada
                Dim id As String = ""

                For Each cell As DataGridViewCell In DataGridView1.Rows(rowIndex).Cells
                    If cell.OwningColumn.HeaderText = "id_prod" Then ' Substitua "produto" pelo cabeçalho correto da coluna
                        id = cell.Value.ToString()
                        Exit For
                    End If
                Next

                ' Confirmação de exclusão
                Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                If resp = MsgBoxResult.Yes Then
                    ' Constrói a instrução SQL para excluir o registro com base no CPF
                    Dim sqlDelete As String = "DELETE FROM tab_prod WHERE id_prod = '" & id & "'"

                    ' Executa o comando SQL para excluir o registro com base no CPF
                    rs = db.Execute(sqlDelete)

                    MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    ' Atualiza a DataGridView após a exclusão
                    Me.Tab_prodTableAdapter1.Fill(Me.Cad_userDataSet3.tab_prod)
                End If
            Else
                MsgBox("Selecione um único registro para excluir.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir registro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_qtd_TextChanged(sender As Object, e As EventArgs) Handles txt_qtd.TextChanged

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        txt_prod.Clear()
        txt_qtd.Clear()
        txt_valor.Clear()
        txt_id_prod.Clear()
        frm_menuADM.Show()
        Me.Hide()
    End Sub

End Class