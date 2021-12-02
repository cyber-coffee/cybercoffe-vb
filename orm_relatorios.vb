Module orm_relatorios

    Function relatorio_produtos_vendidos()
        Try
            sql = "select pedido.Data_emissao as 'Data', produto.Nome_produto as 'Nome do Produto', sum(Qtde_produto) as 'Quantidade de produtos vendidos' from pedido_produto left join produto on (pedido_produto.ID_produto = produto.ID_produto) left join pedido on (pedido.ID_pedido = pedido_produto.ID_pedido) where pedido.Status = 'Finalizado' group by produto.Nome_produto, pedido.Data_emissao"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro ao exibir o relatório")
            Throw ex
        End Try
    End Function

    Function relatorio_produtos_vendidos_ordenar(valor_ordenacao As String)
        Try
            sql = "select pedido.Data_emissao as 'Data', produto.Nome_produto as 'Nome do Produto', sum(Qtde_produto) as 'Quantidade de produtos vendidos' from pedido_produto left join produto on (pedido_produto.ID_produto = produto.ID_produto) left join pedido on (pedido.ID_pedido = pedido_produto.ID_pedido) where pedido.Status = 'Finalizado' group by produto.Nome_produto, pedido.Data_emissao order by " & valor_ordenacao '
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro ao exibir o relatório")
            Throw ex
        End Try
    End Function

    Function relatorio_produtos_vendidos_agrupar_produto_e_data(campo_ordenacao As String)
        Try
            sql = "select pedido.Data_emissao as 'Data', produto.Nome_produto as 'Nome do Produto', sum(Qtde_produto) as 'Quantidade de produtos vendidos' from pedido_produto left join produto on (pedido_produto.ID_produto = produto.ID_produto) left join pedido on (pedido.ID_pedido = pedido_produto.ID_pedido) where pedido.Status = 'Finalizado' group by produto.Nome_produto, pedido.Data_emissao order by `" & campo_ordenacao & "`"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro ao exibir o relatório")
            Throw ex
        End Try
    End Function

    Function relatorio_produtos_vendidos_agrupar_produto(campo_ordenacao As String)
        Try
            sql = "select pedido.Data_emissao as 'Data', produto.Nome_produto as 'Nome do Produto', sum(Qtde_produto) as 'Quantidade de produtos vendidos' from pedido_produto left join produto on (pedido_produto.ID_produto = produto.ID_produto) left join pedido on (pedido.ID_pedido = pedido_produto.ID_pedido) where pedido.Status = 'Finalizado' group by produto.Nome_produto order by `" & campo_ordenacao & "`"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro ao exibir o relatório")
            Throw ex
        End Try
    End Function
End Module
