Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp, aux_cpf, tipo As String
    Public UserId As Integer
    Sub conecta_banco_sql_server()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DELL;Initial Catalog=cad_user;trusted_connection=yes")
            MsgBox("Conexão ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
