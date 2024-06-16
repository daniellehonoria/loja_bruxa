Imports Microsoft.VisualBasic.ApplicationServices

Public Class frm_login
    Private tipo As String
    Private status As String

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        frm_menuADM.Hide()
        conecta_banco_sql_server()
        txt_cpf.Focus()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        sql = "SELECT * FROM tab_cadastro WHERE cpf = '" & txt_cpf.Text & "' AND senha = '" & txt_senha.Text & "'"
        rs = db.Execute(sql)

        If Not (rs.EOF) Then

            tipo = rs("tipo").Value.ToString() 'Obtém o tipo de usuário do banco de dados
            Module1.UserId = CInt(rs("id_user").Value)
            ' O recordset não está vazio
            status = rs("status").Value.ToString() 'Obtém o status de usuário do banco de dados
            If status.ToString.ToUpper = "BLOQ" Then
                MsgBox("Usuário bloqueado, contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                tipo = rs("tipo").Value.ToString() 'Obtém o tipo de usuário do banco de dados
                If tipo.ToString.ToUpper = "ADM" Then
                    ' Chama o formulário frm_cadastro se o usuário for administrador
                    MsgBox("Logado como Administrador!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    'Dim frm As New frm_cadastro()
                    frm_menuADM.ShowDialog()
                    txt_cpf.Clear()
                    txt_senha.Clear()
                    txt_cpf.Focus()
                    cb_versenha.Checked = False

                ElseIf tipo.ToString.ToUpper = "CAIXA" Then
                    ' Chama o formulário frm_vendas se o usuário for caixa
                    MsgBox("Logado como Vendedor!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    'Dim frm As New frm_menuCAIXA()
                    frm_vendas.ShowDialog()
                    txt_cpf.Clear()
                    txt_senha.Clear()
                    txt_cpf.Focus()
                    cb_versenha.Checked = False

                End If
            End If
        Else
            ' O recordset está vazio
            MsgBox("Login ou senha foi digitado errado, tente novamente ou contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
    End Sub
    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        If txt_cpf.Text.Length = 14 Then
            txt_senha.Focus()
            txt_senha.Clear()
        End If
    End Sub
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        End
    End Sub

    Private Sub cb_versenha_CheckedChanged(sender As Object, e As EventArgs) Handles cb_versenha.CheckedChanged
        If cb_versenha.Checked Then
            txt_senha.PasswordChar = ChrW(0)
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
