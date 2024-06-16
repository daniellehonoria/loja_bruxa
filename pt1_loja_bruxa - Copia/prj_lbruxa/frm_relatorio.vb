Imports System.Data.OleDb

Public Class frm_relatorio

    Private Sub frm_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn = New OleDbConnection("Provider=sqloledb;Data Source=DELL;Initial Catalog=cad_user;Integrated Security=SSPI;")
                conn.Open()

                Dim Cmd As New OleDbCommand("select venda.data_venda,
                    cad.nome,
                    prod.nome_prod,
                    venda.qtd_prod,
                    venda.qtd_prod * prod.valor_prod AS total
                    from tab_venda as venda
                    inner join tab_cadastro AS cad ON cad.id_user = venda.id_user
                    inner join tab_prod AS prod ON prod.id_prod = venda.id_prod", conn)
                Dim Relat_vendas As OleDbDataReader = Cmd.ExecuteReader

                Dim DTable As New DataTable With {.TableName = "Vendas"}
                DTable.Load(Relat_vendas)

                dt_grid_relat.DataSource = DTable

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
        End Try

        dt_grid_relat.Columns(0).Width = 100
        dt_grid_relat.Columns(1).Width = 120
        dt_grid_relat.Columns(2).Width = 120
        dt_grid_relat.Columns(3).Width = 60
        dt_grid_relat.Columns(4).Width = 100
    End Sub

    Private Sub dt_grid_relat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid_relat.CellContentClick

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        frm_menuADM.Show()
        Me.Hide()
    End Sub
End Class