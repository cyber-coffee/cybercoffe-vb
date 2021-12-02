Public Class frm_clientes

    Sub preencher_atendentes()
        rs = consultar_todos_atendentes()
        While rs.EOF = False
            With cmb_atendente
                .Items.Add(rs.Fields(2).Value & "-" & rs.Fields(0).Value)
            End With
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_clientes()
        dgv_clientes.Rows.Clear()
        cont = 1
        rs = consultar_todos_clientes()
        While rs.EOF = False
            With dgv_clientes
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(1).Value, parse_date(rs.Fields(4).Value), rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value, Nothing)
            End With
            cont = cont + 1
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_clientes_similares()
        dgv_clientes.Rows.Clear()
        cont = 1
        rs = consultar_cliente_similares(cmb_tipo_campo.Text, txt_nome_campo.Text)
        While rs.EOF = False
            With dgv_clientes
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(1).Value, parse_date(rs.Fields(4).Value), rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value, Nothing)
            End With
            cont = cont + 1
            rs.MoveNext()
        End While
    End Sub

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        conecta_banco_cep_mysql()
        alterar_sessao_atendente(consultar_atendente_id(1))
        preencher_atendentes()
        preencher_clientes()
        txt_nome_atendente.Text = atendente.Fields(0).Value
        txt_cargo_atendente.Text = role
        cmb_tipo_campo.SelectedIndex = 0
    End Sub

    Private Sub cmb_atendente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_atendente.SelectedValueChanged
        Dim values_atendente As String()
        values_atendente = cmb_atendente.Text.Split("-"c)
        txt_id_atendente.Text = values_atendente(0)
    End Sub

    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        Try
            If cliente_existe(txt_cpf.Text) Then
                mensagem_aviso("Cliente com CPF escrito já está cadastrado! Nenhuma alteração feita.")
                Exit Sub
            End If
            If chk_cadastro_simplificado.Checked Then
                If campos_vazios_simplificado() Then
                    mensagem_aviso("Campos vazios encontrados!" + vbNewLine &
                                   "Favor preencher todos os campos necessários" + vbNewLine &
                                   "(CPF do cliente, Nome do cliente e selecionar atendente).")
                    Exit Sub
                End If
                inserir_cliente_simplificado(txt_cpf.Text, txt_nome_cliente.Text, Integer.Parse(txt_id_atendente.Text))
                mensagem_sucesso("Cadastro simplificado do cliente efetuado com sucesso!")
                preencher_clientes()
                inserir_processo("Cliente de cpf: " & txt_cpf.Text & " cadastrado de forma simplificada.", 0, atendente.Fields(2).Value)
                Exit Sub
            End If
            If campos_vazios() Then
                mensagem_aviso("Campos vazios encontrados!" + vbNewLine &
                                   "Favor preencher todos os campos.")
                Exit Sub
            End If
            inserir_cliente(txt_cpf.Text, txt_nome_cliente.Text, Integer.Parse(txt_id_atendente.Text),
                            txt_data_nasc.Text, txt_cep.Text, txt_endereco.Text, txt_comp.Text, txt_bairro.Text,
                            txt_cidade.Text, txt_uf.Text, txt_fone_residencial.Text, txt_celular.Text, txt_email.Text)
            mensagem_sucesso("Cliente cadastrado com sucesso!")
            preencher_clientes()
            inserir_processo("Cliente de cpf: " & txt_cpf.Text & " cadastrado.", 0, atendente.Fields(2).Value)
        Catch ex As Exception
            mensagem_erro("Erro no processamento do pedido!" + vbNewLine &
                          "Inserção cancelada.")
        End Try
    End Sub

    Function campos_vazios()
        Return txt_cpf.Text = "" Or txt_nome_cliente.Text = "" Or txt_id_atendente.Text = "" Or
        txt_data_nasc.Text = "" Or txt_cep.Text = "" Or txt_endereco.Text = "" Or txt_comp.Text = "" Or txt_bairro.Text = "" Or
        txt_cidade.Text = "" Or txt_uf.Text = "" Or txt_fone_residencial.Text = "" Or txt_celular.Text = "" Or txt_email.Text = ""
    End Function

    Function campos_vazios_simplificado()
        Return txt_cpf.Text = "" Or txt_nome_cliente.Text = "" Or txt_id_atendente.Text = ""
    End Function

    Private Sub btn_alterar_cliente_Click(sender As Object, e As EventArgs) Handles btn_alterar_cliente.Click
        If campos_vazios() And Not chk_cadastro_simplificado.Checked Then
            mensagem_aviso("Campos vazios encontrados!" + vbNewLine &
                                   "Favor preencher todos os campos.")
            Exit Sub
        End If
        Try
            alterar_cliente(txt_nome_cliente.Text, Integer.Parse(txt_id_atendente.Text), txt_data_nasc.Text,
                            txt_cep.Text, txt_endereco.Text, txt_comp.Text, txt_bairro.Text, txt_cidade.Text,
                            txt_uf.Text, txt_fone_residencial.Text, txt_celular.Text, txt_email.Text, txt_cpf.Text)
            mensagem_sucesso("Cliente alterado com sucesso.")
            preencher_clientes()
            inserir_processo("Cliente de cpf: " & txt_cpf.Text & " alterado.", 0, atendente.Fields(2).Value)
        Catch ex As Exception
            mensagem_erro("Erro no processamento do pedido!" + vbNewLine &
                          "Alteração cancelada.")
        End Try
    End Sub

    Private Sub dgv_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        If dgv_clientes.CurrentRow.Cells(14).Selected Then
            With dgv_clientes.CurrentRow
                txt_cpf.Text = .Cells(1).Value
                txt_id_atendente.Text = .Cells(2).Value
                txt_nome_cliente.Text = .Cells(3).Value
                txt_data_nasc.Text = .Cells(4).Value
                txt_cep.Text = .Cells(5).Value
                txt_endereco.Text = .Cells(6).Value
                txt_comp.Text = .Cells(7).Value
                txt_bairro.Text = .Cells(8).Value
                txt_cidade.Text = .Cells(9).Value
                txt_uf.Text = .Cells(10).Value
                txt_fone_residencial.Text = .Cells(11).Value
                txt_celular.Text = .Cells(12).Value
                txt_email.Text = .Cells(13).Value
            End With
        End If
    End Sub

    Private Sub txt_nome_campo_TextChanged(sender As Object, e As EventArgs) Handles txt_nome_campo.TextChanged
        preencher_clientes_similares()
    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            rs = consultar_cep(txt_cep.Text)
            If rs.EOF = True Then
                mensagem_aviso("CEP não encontrado. Favor digitar outro CEP.")
                Exit Sub
            End If
            txt_endereco.Text = rs.Fields(1).Value
            txt_bairro.Text = rs.Fields(3).Value
            txt_cidade.Text = rs.Fields(2).Value
            txt_uf.Text = rs.Fields(4).Value
        Catch ex As Exception
            mensagem_erro("Erro ao buscar CPF.")
        End Try
    End Sub
End Class