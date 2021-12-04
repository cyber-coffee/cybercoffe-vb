﻿Module common_commands_db
    Public db, db_cep As ADODB.Connection
    Public rs As ADODB.Recordset
    Public Id_gerente as String
    Public sql, nome_func As String
    Public resp, diretorio As String
    Public cont As Integer

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MYSQL ODBC 8.0 ANSI Driver};Server=localhost;Database=db_cybercoffee;port=3306;Uid=root;Pwd=")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub conecta_banco_cep_mysql()
        Try
            db_cep = CreateObject("ADODB.Connection")
            db_cep.Open("DRIVER={MYSQL ODBC 8.0 ANSI Driver};Server=localhost;Database=db_cep;port=3306;Uid=root;Pwd=")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Function mensagem_erro(mensagem As String)
        MsgBox("Erro ao processar solicitação: " + vbNewLine &
               mensagem, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
    End Function

    Function mensagem_aviso(mensagem As String)
        MsgBox("Atenção: " + vbNewLine &
               mensagem, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
    End Function

    Function mensagem_sucesso(mensagem As String)
        MsgBox("Sucesso: " + vbNewLine &
               mensagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
    End Function

    Function mensagem_opcao(mensagem As String)
        Return MsgBox(mensagem, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "INFO")
    End Function

    Function excluir_campo(tabela As String, nome_id As String, id As Integer)
        Try
            sql = "DELETE FROM " & tabela & " WHERE " & nome_id & " = " & id
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function selecionar_campos(tabela As String, nome_campo As String, valor As String)
        Try
            sql = "SELECT * from " & tabela & " WHERE " & nome_campo & " = '" & valor & "'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
        End Try
    End Function

    Function selecionar_tudo(tabela As String)
        Try
            sql = "SELECT * from " & tabela
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw
        End Try
    End Function

    Function selecionar_campos_join(tabela_principal As String, tabela_secundaria As String, nome_id_principal As String, nome_id_secundario As String, id_principal As String)
        Try
            sql = "SELECT * from " & tabela_principal & " LEFT JOIN " & tabela_secundaria & " ON (" & tabela_principal & "." & nome_id_principal & " = " & tabela_secundaria & "." & nome_id_secundario & ") WHERE " & tabela_principal & "." & nome_id_principal & " = " & id_principal
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw
        End Try
    End Function


    Function selecionar_tudo_join(tabela_principal As String, tabela_secundaria As String, nome_id_principal As String, nome_id_secundario As String)
        Try
            sql = "SELECT * from " & tabela_principal & " LEFT JOIN " & tabela_secundaria & " ON (" & tabela_principal & "." & nome_id_principal & " = " & tabela_secundaria & "." & nome_id_secundario & ")"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw
        End Try
    End Function

    Function selecionar_ultimo_campo(tabela As String, nome_id As String)
        Try
            sql = "SELECT * from " & tabela & " order by " & nome_id & " DESC LIMIT 1"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw
        End Try
    End Function

    Function selecionar_como(tabela As String, nome_campo As String, campo As String)
        Try
            sql = "SELECT * from " & tabela & " WHERE " & nome_campo & " LIKE '%" & campo & "%'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw
        End Try
    End Function

    Function selecionar_como_join(tabela_principal As String, tabela_secundaria As String, nome_id_principal As String, nome_id_secundario As String, nome_campo As String, campo As String)
        Try
            sql = "SELECT * from " & tabela_principal & " LEFT JOIN " & tabela_secundaria & " ON (" & tabela_principal & "." & nome_id_principal & " = " & tabela_secundaria & "." & nome_id_secundario & ") WHERE " & nome_campo & " LIKE '%" & campo & "%'"
            rs = db.Execute(sql)
            Return rs
        Catch ex As Exception
            mensagem_erro(ex.Message)
            Throw
        End Try
    End Function

    Function limpar_txt()
        With frm_login
            .txt_user.Clear()
            .txt_password.Clear()
            .txt_user.Focus()
            .btn_signin.Visible = False
        End With
    End Function

    Function parse_date(Date_str As String)
        Try
            If Date_str.Split("-"c).Length <= 1 Then
                Return Date_str
            End If
            Dim date_parts As String()
            date_parts = Date_str.Split("-"c)
            Return date_parts(2) & "/" & date_parts(1) & "/" & date_parts(0)
        Catch ex As Exception
            Return "ERRO"
        End Try
    End Function

    Function get_curr_date()
        Dim this_date As Date
        this_date = Date.Today
        Return this_date.Day & "/" & this_date.Month & "/" & this_date.Year
    End Function
End Module
