Public Class frm_orders
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Sub preencher_pedidos()
        dgv_orders.Rows.Clear()
        rs = consultar_pedidos_por_atendente(Integer.Parse(atendente.Fields(2).Value))
        While rs.EOF = False
            With dgv_orders
                .Rows.Add(rs.Fields(0).Value, parse_date(rs.Fields(1).Value), rs.Fields(4).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing)
            End With
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_dados_pedido()
        Dim atendente_atual, cliente_atual, pedido_atual As ADODB.Recordset
        Try
            pedido_atual = consultar_pedido_id(Integer.Parse(txt_cod_pedido.Text))
            atendente_atual = consultar_atendente_id(Integer.Parse(pedido_atual.Fields(3).Value))
            If atendente_atual.EOF = False Then
                txt_cod_atendente.Text = atendente_atual.Fields(2).Value
                txt_nome_atendente.Text = atendente_atual.Fields(0).Value
            End If
            If pedido_atual.EOF = False Then
                txt_cpf_cliente.Text = pedido_atual.Fields(4).Value
                txt_status.Text = pedido_atual.Fields(5).Value
                txt_data_emissao.Text = parse_date(pedido_atual.Fields(1).Value)
            End If
            cliente_atual = consultar_cliente_cpf(txt_cpf_cliente.Text)
            If cliente_atual.EOF = False Then
                txt_nome_cliente.Text = cliente_atual.Fields(1).Value
            End If

        Catch ex As Exception
            txt_cod_atendente.Text = atendente.Fields(2).Value
            txt_nome_atendente.Text = atendente.Fields(0).Value
            txt_atendente.Text = atendente.Fields(0).Value
            txt_cargo.Text = role
            txt_status.Text = "Não iniciado"
            txt_data_emissao.Text = today
            txt_cpf_cliente.Text = ""
            txt_nome_cliente.Text = "Nome do cliente"
        End Try
    End Sub


    Private Sub frm_orders_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
        alterar_sessao_atendente(consultar_atendente_id(1))
        alterar_sessao_cargo("Atendente")
        preencher_pedidos()
        txt_cod_atendente.Text = atendente.Fields(2).Value
        txt_nome_atendente.Text = atendente.Fields(0).Value
        txt_atendente.Text = atendente.Fields(0).Value
        txt_cargo.Text = role
        txt_status.Text = "Não iniciado"
        txt_data_emissao.Text = today
    End Sub

    Private Sub dgv_orders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_orders.CellClick
        If dgv_orders.CurrentRow.Cells(6).Selected Then
            alterar_pedido_selecionado(dgv_orders.CurrentRow.Cells(0).Value)
            frm_pedido.Show()
            Exit Sub
        End If
        alterar_pedido_selecionado(dgv_orders.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txt_cpf_cliente_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_cliente.LostFocus
        Try
            rs = selecionar_campos("cliente", "CPF_cliente", txt_cpf_cliente.Text)
            If rs.EOF = True Then
                txt_nome_cliente.Text = "Nome do cliente"
                Exit Sub
            End If
            txt_nome_cliente.Text = rs.Fields(1).Value
        Catch ex As Exception
            txt_nome_cliente.Text = "Nome do cliente"
        End Try
    End Sub

    Private Sub btn_adicionar_pedido_Click(sender As Object, e As EventArgs) Handles btn_adicionar_pedido.Click
        Dim pedido_existe As Boolean
        Try
            rs = consultar_pedido_id(Integer.Parse(txt_cod_pedido.Text))
            pedido_existe = Not rs.EOF
        Catch ex As Exception
            pedido_existe = False
        End Try
        If (pedido_existe) Then
            mensagem_aviso("Há um pedido com id cadastrado no sistema!" + vbNewLine &
                            "Favor manter campo id em branco.")
            Exit Sub
        End If
        inserir_pedido(txt_cod_atendente.Text, txt_cpf_cliente.Text)
        mensagem_sucesso("Pedido criado com sucesso!")
        preencher_pedidos()
    End Sub

    Private Sub txt_cod_pedido_LostFocus(sender As Object, e As EventArgs) Handles txt_cod_pedido.LostFocus
        preencher_dados_pedido()
    End Sub

    Private Sub btn_alterar_pedido_Click(sender As Object, e As EventArgs) Handles btn_alterar_pedido.Click
        Try
            rs = consultar_pedido_id(Integer.Parse(txt_cod_pedido.Text))
            If rs.EOF = False Then
                alterar_pedido(Integer.Parse(txt_cod_atendente.Text), txt_cpf_cliente.Text, txt_status.Text, rs.Fields(6).Value, Integer.Parse(txt_cod_pedido.Text), rs.Fields(2).Value)
                mensagem_sucesso("Pedido alterado com sucesso!")
                preencher_pedidos()
                preencher_dados_pedido()
            End If
        Catch ex As Exception
            mensagem_erro("Ocorreu um erro! Alterações canceladas.")
        End Try
    End Sub

    Private Sub btn_cancelar_pedido_Click(sender As Object, e As EventArgs) Handles btn_cancelar_pedido.Click
        Try
            If txt_cod_pedido.Text = "" Then
                mensagem_aviso("Favor inserir um código de pedido válido.")
                Exit Sub
            End If

            If pedido_cancelado(Integer.Parse(txt_cod_pedido.Text)) Or pedido_finalizado(Integer.Parse(txt_cod_pedido.Text)) Then
                mensagem_aviso("Pedido finalizado ou cancelado anteriormente. Alterações descartadas.")
                Exit Sub
            End If

            resp = mensagem_opcao("Deseja realmente cancelar o pedido?" + vbNewLine &
                                  "(Essa ação é irreversível e o pedido se tornará imutável)")
            If resp = vbNo Then
                mensagem_aviso("Alterações canceladas")
                Exit Sub
            End If

            rs = consultar_pedido_id(Integer.Parse(txt_cod_pedido.Text))
            If rs.EOF = False Then
                alterar_pedido(rs.Fields(3).Value, rs.Fields(4).Value, "Cancelado", rs.Fields(6).Value, Integer.Parse(txt_cod_pedido.Text), rs.Fields(2).Value)
                mensagem_sucesso("Pedido alterado com sucesso!")
                preencher_pedidos()
                preencher_dados_pedido()
            End If
        Catch ex As Exception
            mensagem_erro("Ocorreu um erro! Alterações canceladas.")
        End Try
    End Sub

    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        frm_clientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        Me.Close()
    End Sub
End Class