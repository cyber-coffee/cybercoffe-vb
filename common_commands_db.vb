Module common_commands_db
    Public db As ADODB.Connection
    Public rs As ADODB.Recordset
    Public sql As String

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MYSQL ODBC 8.0 ANSI Driver};Server=localhost;Database=cadastro_clientes;port=3306;Uid=root;Pwd=")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Function mensagem_erro(mensagem As String)
        MsgBox("Erro ao processar solicitação: " + vbNewLine &
               mensagem, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
    End Function

    Function excluir_campo(tabela As String, nome_id As String, id As Integer)
        Try
            sql = "DELETE FROM " & tabela & " WHERE " & nome_id & " = " & id
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function selecionar_campos(tabela As String, nome_campo As String, valor As String)
        Try
            sql = "SELECT * from " & tabela & " WHERE " & nome_campo & " = '" & valor & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function selecionar_campos_join(tabela_principal As String, tabela_secundaria As String, nome_id_principal As String, nome_id_secundario As String, id_principal As String)
        Try
            sql = "SELECT * from " & tabela_principal & " t1 LEFT JOIN " & tabela_secundaria & " t2 ON (" & tabela_principal & "." & nome_id_principal & " = " & tabela_secundaria & "." & nome_id_secundario & ") WHERE " & tabela_principal & "." & nome_id_principal & " = " & id_principal
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function
End Module
