Module orm_gerente

    Function consultar_gerente_id(id_gerente As Integer)
        Return selecionar_campos("gerente", "ID_gerente", id_gerente.ToString)
    End Function
    Function inserir_gerente(nome As String, senha As String, cpf_gerente As String, data_admissao As String)
        Try
            sql = "INSERT INTO gerente (nome, senha, cpf_gerente, data_admissao) VALUES ('" & nome & "','" & senha & "','" & cpf_gerente & "','" & data_admissao & "')"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function alterar_gerente(nome As String, senha As String, cpf_gerente As String, data_admissao As String, id_gerente As Integer)
        Try
            sql = "UPDATE gerente SET nome = '" & nome & "'," &
                " senha = '" & senha & "'," &
                " CPF_gerente = '" & cpf_gerente & "'," &
                "data_admissao = '" & data_admissao & "' " &
                "WHERE ID_gerente = " & id_gerente
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function excluir_gerente(id_gerente As Integer)
        Return excluir_campo("gerente", "ID_gerente", id_gerente)
    End Function
End Module
