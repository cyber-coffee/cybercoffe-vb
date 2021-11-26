Module orm_atendente

    Function consultar_atendente_id(id_atendente As Integer)
        Return selecionar_campos("atendente", "id_atendente", id_atendente.ToString)
    End Function

    Function consultar_todos_atendentes()
        Return selecionar_tudo("atendente")
    End Function

    Function inserir_atendente(nome As String, senha As String, cpf_atendente As String, id_gerente As Integer, data_admissao As String)
        Try
            sql = "INSERT INTO atendente (nome, senha, cpf_atendente, id_gerente, data_admissao) values ('" & nome & "','" & senha & "','" & cpf_atendente & "','" & id_gerente & "','" & data_admissao & "')"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function alterar_atendente(nome As String, senha As String, cpf_atendente As String, id_gerente As Integer, data_admissao As String, id_atendente As Integer)
        Try
            sql = "UPDATE atendente SET nome = '" & nome & "', " &
                    "senha = '" & senha & "', " &
                    "cpf_atendente = '" & cpf_atendente & "'," &
                    "data_admissao = '" & data_admissao & "'," &
                    "WHERE ID_atendente = " & id_atendente
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function excluir_atendente(id_atendente As Integer)
        Return excluir_campo("atendente", "ID_atendente", id_atendente)
    End Function
End Module
