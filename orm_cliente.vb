Module orm_cliente

    Function consultar_cliente_id(id_cliente As Integer)
        Return selecionar_campos("cliente", "ID_cliente", id_cliente.ToString)
    End Function

    Function inserir_cliente(cpf_cliente As String, nome_cliente As String, id_atendente As String)
        Try
            sql = "INSERT INTO cliente (CPF_cliente, Nome_cliente, ID_atendente) VALUES ('" & cpf_cliente & "','" & nome_cliente & "','" & id_atendente & "')"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function alterar_cliente(nome_cliente As String, cpf_cliente As String)
        Try
            sql = "UPDATE cliente SET nome_cliente = '" & nome_cliente & "' WHERE CPF_cliente = '" & cpf_cliente & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function excluir_cliente(cpf_cliente As String)
        Try
            sql = "DELETE FROM cliente WHERE cpf_cliente = '" & cpf_cliente & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

End Module
