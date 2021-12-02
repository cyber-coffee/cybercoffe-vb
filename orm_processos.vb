Module orm_processos

    Function consultar_processo_id(id_processo As Integer)
        Return selecionar_campos("processo", "ID_processo", id_processo.ToString)
    End Function

    Function inserir_processo(descricao As String, id_gerente As Integer, id_atendente As Integer)
        Dim campos_id, valores_id As String

        campos_id = ""
        valores_id = ""

        If id_gerente <> vbNull And id_atendente <> vbNull Then
            campos_id = "ID_gerente,ID_atendente"
            valores_id = "'" & id_gerente & "','" & id_atendente & "'"
        ElseIf id_gerente <> vbNull And id_atendente = vbNull Then
            campos_id = "ID_gerente"
            valores_id = "'" & id_gerente & "'"
        ElseIf id_gerente = vbNull And id_atendente <> vbNull Then
            campos_id = "ID_atendente"
            valores_id = "'" & id_atendente & "'"
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
