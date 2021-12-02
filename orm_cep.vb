Module orm_cep

    Function consultar_cep(cep As String)
        Try
            sql = "SELECT * from tb_cep where cep = '" & cep & "'"
            rs = db_cep.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro("Erro: " & ex.Message)
            Throw ex
        End Try
    End Function

End Module
