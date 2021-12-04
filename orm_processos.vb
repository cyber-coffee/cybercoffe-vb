Module orm_processos

    Function consultar_processo_id(id_processo As Integer)
        Return selecionar_campos("processo", "ID_processo", id_processo.ToString)
    End Function

    Function consultar_todos_processos()
        Return selecionar_tudo("processo")
    End Function

    Function consultar_processo_data(data As String)
        Return selecionar_campos("processo", "Data_criacao", data)
    End Function

    Function consultar_processos_personalizado(data As String)
        Try
            sql = "select processo.Data_criacao, processo.Descricao, gerente.nome as 'Gerente', atendente.nome as 'Atendente' from processo left join gerente on (processo.ID_gerente = gerente.ID_gerente) left join atendente on (processo.ID_atendente = atendente.ID_atendente) where processo.Data_criacao = '" & data & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro ao processar pedido.")
            Throw ex
        End Try
    End Function

    Function consultar_datas_processos()
        Try
            sql = "select distinct Data_criacao from processo"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro ao processar pedido.")
            Throw ex
        End Try
    End Function

    Function inserir_processo(descricao As String, id_gerente As Integer, id_atendente As Integer)
        Dim campos_id, valores_id As String

        campos_id = ""
        valores_id = ""

        If id_gerente <> 0 And id_atendente <> 0 Then
            campos_id = "ID_gerente,ID_atendente"
            valores_id = "'" & id_gerente & "','" & id_atendente & "'"
        ElseIf id_gerente <> 0 And id_atendente = 0 Then
            campos_id = "ID_gerente"
            valores_id = "'" & id_gerente.ToString & "'"
        ElseIf id_gerente = 0 And id_atendente <> 0 Then
            campos_id = "ID_atendente"
            valores_id = "'" & id_atendente.ToString & "'"
        End If

        Try
            sql = "INSERT INTO processo (Descricao," & campos_id & ") VALUES ('" & descricao & "'," & valores_id & ")"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function excluir_processo(id_processo As Integer)
        Return excluir_campo("processo", "ID_processo", id_processo)
    End Function

End Module
