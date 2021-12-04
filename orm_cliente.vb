Module orm_cliente

    Function consultar_cliente_cpf(cpf_cliente As String)
        Return selecionar_campos("cliente", "CPF_cliente", cpf_cliente)
    End Function

    Function consultar_todos_clientes()
        Return selecionar_tudo("cliente")
    End Function

    Function consultar_cliente_similares(nome_campo As String, valor As String)
        Return selecionar_como("cliente", nome_campo, valor)
    End Function

    Function cliente_existe(CPF_cliente As String)
        rs = consultar_cliente_cpf(CPF_cliente)
        Return Not rs.EOF
    End Function

    Function inserir_cliente_simplificado(cpf_cliente As String, nome_cliente As String, id_atendente As String)
        Try
            sql = "INSERT INTO cliente (CPF_cliente, Nome_cliente, ID_atendente) VALUES ('" & cpf_cliente & "','" & nome_cliente & "','" & id_atendente & "')"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function inserir_cliente(cpf_cliente As String, nome_cliente As String, id_atendente As String, data_nascimento As String, cep As String, endereco As String, complemento As String, bairro As String, cidade As String, uf As String, fone_residencial As String, celular As String, email As String, nome_foto As String)
        Try
            sql = "INSERT INTO cliente (CPF_cliente, Nome_cliente, ID_atendente, Data_nascimento, cep, endereco, complemento, bairro, cidade, uf, fone_residencial, celular, email, foto) " &
                                        "VALUES('" & cpf_cliente & "'," &
                                        "'" & nome_cliente & "'," &
                                        "'" & id_atendente & "'," &
                                        "'" & data_nascimento & "'," &
                                        "'" & cep & "'," &
                                        "'" & endereco & "'," &
                                        "'" & complemento & "'," &
                                        "'" & bairro & "'," &
                                        "'" & cidade & "'," &
                                        "'" & uf & "'," &
                                        "'" & fone_residencial & "'," &
                                        "'" & celular & "'," &
                                        "'" & email & "'," &
                                        "'" & nome_foto.Replace("\", "\\").Trim & "'" &
                                        ")"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try

    End Function

    Function alterar_cliente(nome_cliente As String, id_atendente As Integer, data_nascimento As String, cep As String, endereco As String, complemento As String, bairro As String, cidade As String, uf As String, fone_residencial As String, celular As String, email As String, cpf_cliente As String, nome_foto As String)
        Try
            sql = "UPDATE cliente SET nome_cliente = '" & nome_cliente & "', " &
                    "ID_atendente = '" & id_atendente.ToString & "'," &
                    "ID_atendente = '" & id_atendente.ToString & "'," &
                    "Data_nascimento = '" & data_nascimento & "'," &
                    "cep = '" & cep & "'," &
                    "endereco = '" & endereco & "'," &
                    "complemento = '" & complemento & "'," &
                    "bairro = '" & bairro & "'," &
                    "cidade = '" & cidade & "'," &
                    "UF = '" & uf & "'," &
                    "fone_residencial = '" & fone_residencial & "'," &
                    "celular = '" & celular & "'," &
                    "email = '" & email & "', " &
                    "foto ='" & nome_foto.Replace("\", "\\").Trim & "'" &
                    "WHERE CPF_cliente = '" & cpf_cliente & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

    Function excluir_cliente(cpf_cliente As String)
        Try
            sql = "DELETE FROM cliente WHERE cpf_cliente = '" & cpf_cliente & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw ex
        End Try
    End Function

End Module
