Module orm_categoria

    Function consultar_categoria_id(id_categoria As Integer)
        Return selecionar_campos("categoria", "ID_categoria", id_categoria.ToString)
    End Function

    Function consultar_categoria_nome(nome_categoria As String)
        Return selecionar_campos("categoria", "Nome_categoria", nome_categoria)
    End Function

    Function consultar_categorias()
        Return selecionar_tudo("categoria")
    End Function
    Function inserir_categoria(nome_categoria As String)
        Try
            sql = "INSERT INTO categoria (nome_categoria) values ('" & nome_categoria & "')"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function alterar_categoria(nome_categoria As String, id_categoria As Integer)
        Try
            sql = "UPDATE categoria SET nome_categoria = '" & nome_categoria & "' WHERE ID_categoria = " & id_categoria
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function excluir_categoria(id_categoria As Integer)
        Return excluir_campo("categoria", "ID_categoria", id_categoria)
    End Function
End Module
