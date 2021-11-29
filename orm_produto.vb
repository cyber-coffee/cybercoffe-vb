Module orm_produto

    Function consultar_produto_id(id_produto As Integer)
        Return selecionar_campos("produto", "ID_produto", id_produto.ToString)
    End Function

    Function consultar_todos_produtos()
        Return selecionar_tudo("produto")
    End Function

    Function consultar_produtos_como_campo(nome_campo As String, campo As String)
        Return selecionar_como("produto", nome_campo, campo)
    End Function

    Function consultar_todos_produtos_e_categoria()
        Return selecionar_tudo_join("produto", "categoria", "ID_categoria", "ID_categoria")
    End Function
    Function inserir_produto(nome_produto As String, valor As Double, id_categoria As Integer, qtde_estoque As Integer)
        Try
            sql = "INSERT INTO produto (Nome_produto, valor, id_categoria, Qtde_estoque) VALUES ('" & nome_produto & "','" & valor.ToString.Replace(",", ".") & "'," & id_categoria & ", " & qtde_estoque & ")"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function consultar_todos_produtos_e_categoria_como(nome_campo As String, campo As String)
        Return selecionar_como_join("produto", "categoria", "ID_categoria", "ID_categoria", nome_campo, campo)
    End Function

    Function alterar_produto(nome_produto As String, valor As Double, id_categoria As Integer, qtde_estoque As Integer, id_produto As Integer)
        Try
            sql = "UPDATE produto SET Nome_produto = '" & nome_produto & "', " &
                " valor = '" & valor.ToString.Replace(",", ".") & "', " &
                " Qtde_estoque = " & qtde_estoque & ", " &
                " ID_categoria = " & id_categoria &
                " WHERE id_produto = " & id_produto
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function excluir_produto(id_produto As Integer)
        Return excluir_campo("produto", "ID_produto", id_produto)
    End Function

End Module
