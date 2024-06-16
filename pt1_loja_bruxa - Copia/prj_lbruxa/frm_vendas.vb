Public Class frm_vendas

    Private Sub cbx_busca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_busca.SelectedIndexChanged
        ' Verificar se o usuário selecionou um item na combobox
        If cbx_busca.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = cbx_busca.SelectedItem.ToString()

            cbx_busca.Text = String.Empty ' Limpa o texto da combobox
            cbx_busca.Focus() ' Define o foco na combobox

            ' Buscar o produto no banco de dados
            Dim rs As New ADODB.Recordset
            rs.Open("SELECT * FROM tab_prod WHERE nome_prod LIKE '%" & selectedItem & "%'", db)

            ' Verificar se o produto foi encontrado
            If Not rs.EOF Then
                ' Adicionar o produto ao DataGridView
                AddProductToDataGridView(rs)
                ' Atualizar o total
                UpdateTotal()
            End If
            rs.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frm_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conecta_banco_sql_server()
        frm_login.Hide()
        'TODO: esta linha de código carrega dados na tabela 'Cad_userDataSet2.tab_venda'. Você pode movê-la ou removê-la conforme necessário.
        'Me.Tab_vendaTableAdapter.Fill(Me.Cad_userDataSet2.tab_venda)

        ' Carregar os produtos na combobox
        LoadProductsToCombobox()
        ' Limpar o DataGridView e a Combobox
        cbx_busca.Text = String.Empty
        DataGridView1.Rows.Clear()
        cbx_busca.Focus() ' Define o foco na combobox

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub btn_fecharpedido_Click(sender As Object, e As EventArgs) Handles btn_fecharpedido.Click
        Dim resposta As DialogResult = MessageBox.Show("Deseja registrar a compra?", "Registrar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            ' Percorrer as linhas do DataGridView
            For Each row As DataGridViewRow In DataGridView1.Rows
                ' Verificar se a linha não é uma linha vazia
                If Not row.IsNewRow Then
                    ' Obter os valores das células
                    Dim nome_prod As String = row.Cells("nome_prod").Value.ToString()
                    Dim qtd_prod As Integer = CInt(row.Cells("qtd_prod").Value)

                    ' Buscar o ID do produto no banco de dados
                    Dim rs As New ADODB.Recordset
                    rs.Open("SELECT id_prod, qtd_prod FROM tab_prod WHERE nome_prod = '" & nome_prod & "'", db)
                    Dim id_prod As Integer = 0
                    Dim qtd_estoque As Integer = 0
                    If Not rs.EOF Then
                        id_prod = CInt(rs("id_prod").Value)
                        qtd_estoque = CInt(rs("qtd_prod").Value)
                    End If
                    rs.Close()

                    ' Atualizar a quantidade do produto no estoque
                    Dim qtd_nova As Integer = qtd_estoque - qtd_prod
                    If qtd_nova >= 0 Then
                        Dim sql As String = "UPDATE tab_prod SET qtd_prod = " & qtd_nova & " WHERE id_prod = " & id_prod
                        db.Execute(sql)
                    Else
                        MessageBox.Show("Erro: quantidade do produto no estoque é insuficiente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End If
            Next

            ' Inserir os dados na tabela tab_venda
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim nome_prod As String = row.Cells("nome_prod").Value.ToString()
                    Dim qtd_prod As Integer = CInt(row.Cells("qtd_prod").Value)

                    Dim rs As New ADODB.Recordset
                    rs.Open("SELECT id_prod FROM tab_prod WHERE nome_prod = '" & nome_prod & "'", db)
                    Dim id_prod As Integer = 0
                    If Not rs.EOF Then
                        id_prod = CInt(rs("id_prod").Value)
                    End If
                    rs.Close()

                    Dim sql As String = "INSERT INTO tab_venda (id_user, id_prod, qtd_prod) VALUES (" & UserId & ", " & id_prod & ", " & qtd_prod & ")"
                    db.Execute(sql)
                End If
            Next

            MessageBox.Show("Compra registrada com sucesso!", "AVISO!", MessageBoxButtons.OK)

            ' Limpar o DataGridView
            DataGridView1.Rows.Clear()

            ' Zerar o total
            lbl_total.Text = "0,00"

            ' Atualizar o total no DataGridView
            UpdateTotal()
            cbx_busca.Focus()
        End If
    End Sub

    Private Sub lbl_total_Click(sender As Object, e As EventArgs) Handles lbl_total.Click

    End Sub

    ' Método para carregar os produtos na combobox
    Private Sub LoadProductsToCombobox()

        Dim rs As New ADODB.Recordset
        rs.Open("SELECT nome_prod FROM tab_prod", db)

        While Not rs.EOF
            cbx_busca.Items.Add(rs("nome_prod").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    ' Método para adicionar um produto ao DataGridView
    Private Sub AddProductToDataGridView(rs As ADODB.Recordset)
        ' Verificar se o produto já está no DataGridView
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells("nome_prod") IsNot Nothing AndAlso DataGridView1.Rows(i).Cells("nome_prod").Value IsNot Nothing Then
                If DataGridView1.Rows(i).Cells("nome_prod").Value.ToString() = rs("nome_prod").Value.ToString() Then
                    ' Se o produto já está no DataGridView, incrementar a quantidade
                    If DataGridView1.Rows(i).Cells("qtd_prod") IsNot Nothing AndAlso DataGridView1.Rows(i).Cells("qtd_prod").Value IsNot Nothing Then
                        DataGridView1.Rows(i).Cells("qtd_prod").Value = CInt(DataGridView1.Rows(i).Cells("qtd_prod").Value) + 1
                    End If
                    ' Atualizar o preço
                    If DataGridView1.Rows(i).Cells("valor_prod") IsNot Nothing AndAlso DataGridView1.Rows(i).Cells("valor_prod").Value IsNot Nothing Then
                        DataGridView1.Rows(i).Cells("valor_prod").Value = CInt(DataGridView1.Rows(i).Cells("qtd_prod").Value) * CDec(rs("valor_prod").Value)
                    End If
                    Return
                End If
            End If
        Next

        ' Se o produto não está no DataGridView, adicionar uma nova linha
        DataGridView1.Rows.Add(rs("nome_prod").Value, 1, rs("valor_prod").Value)
    End Sub

    ' Método para atualizar o total
    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            total += CDec(DataGridView1.Rows(i).Cells("valor_prod").Value)
        Next
        lbl_total.Text = total.ToString("C")
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        cbx_busca.Items.Clear()
        cbx_busca.SelectedIndex = -1
        cbx_busca.Text = String.Empty
        cbx_busca.Focus()
        DataGridView1.Rows.Clear()
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Dim resposta As DialogResult = MessageBox.Show("Você deseja mesmo cancelar o pedido?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            cbx_busca.Items.Clear()
            cbx_busca.SelectedIndex = -1
            cbx_busca.Text = String.Empty
            cbx_busca.Focus()
            DataGridView1.Rows.Clear()
            lbl_total.Text = "0,00"

            'carregar a lista de itens da combobox
            LoadProductsToCombobox()
        End If
    End Sub
End Class