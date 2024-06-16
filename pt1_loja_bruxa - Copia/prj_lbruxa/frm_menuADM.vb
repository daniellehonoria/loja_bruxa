Public Class frm_menuADM
    Private Sub frm_menuADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.Hide()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        frm_estoque.Show()
        Me.Hide()
    End Sub

    Private Sub btn_relatorios_Click(sender As Object, e As EventArgs) Handles btn_relatorios.Click
        frm_relatorio.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        frm_cadastro.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        frm_login.Show()
        Me.Hide()
    End Sub
End Class