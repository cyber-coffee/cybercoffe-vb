Public Class frm_pedido
    Private Sub frm_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_categorias()
        preencher_dados_pedido()
        preencher_pedido_produtos()
    End Sub

    Sub carregar_categorias()
        rs = consultar_categorias()
        While rs.EOF = False
            With cmb_categoria
                .Items.Add(rs.Fields(1).Value)
            End With
            rs.MoveNext()
        End While

    End Sub

    Sub carregar_produtos(categoria As String)
        rs = consultar_categoria_nome(categoria)

        If rs.EOF = True Then
            Exit Sub
        End If

        Dim id_categoria = rs.Fields(0).Value

        rs = consultar_produtos_como_campo("ID_categoria", id_categoria)
        cmb_produto.Items.Clear()

        While rs.EOF = False
            With cmb_produto
                .Items.Add(rs.Fields(1).Value)
            End With
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_dados_pedido()
        Try
            Dim atendente, cliente, pedido As ADODB.Recordset
            pedido = consultar_pedido_id(ID_pedido)
            txt_id_pedido.Text = ID_pedido
            If pedido.EOF = True Then
                mensagem_aviso("Pedido não encontrado!")
                Me.Close()
                Exit Sub
            End If
            txt_status_pedido.Text = pedido.Fields(5).Value
            txt_cpf_cliente.Text = pedido.Fields(4).Value
            cmb_forma_pagto.Text = pedido.Fields(6).Value
            txt_total.Text = pedido.Fields(2).Value
            cliente = consultar_cliente_cpf(pedido.Fields(4).Value)
            atendente = consultar_atendente_id(Integer.Parse(pedido.Fields(3).Value))
            If cliente.EOF = False Then
                txt_nome_cliente.Text = cliente.Fields(1).Value
            End If
            If atendente.EOF = False Then
                txt_cargo_atendente.Text = "Atendente"
                txt_nome_atendente.Text = atendente.Fields(0).Value
            End If
        Catch ex As Exception
            mensagem_erro("Erro no carregamento do pedido: " & ex.Message & " -> " & ex.StackTrace)
        End Try

    End Sub
    Private Sub cmb_categoria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_categoria.SelectedValueChanged
        carregar_produtos(cmb_categoria.SelectedItem.ToString)
    End Sub



    Private Sub cmb_produto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_produto.SelectedValueChanged
        rs = consultar_produtos_como_campo("Nome_produto", cmb_produto.Text)
        If rs.EOF = True Then
            Exit Sub
        End If
        txt_cod_produto.Text = rs.Fields(0).Value
        txt_valor_unitario.Text = rs.Fields(2).Value
    End Sub



    Sub limpar_campos()
        txt_cod_produto.Text = ""
        txt_qtde.Text = ""
        txt_subtotal.Text = ""
        txt_valor_unitario.Text = ""
        cmb_categoria.Text = ""
        cmb_produto.Text = ""
    End Sub

    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        Dim valor_unitario, qtde As Double
        Try
            valor_unitario = Double.Parse(txt_valor_unitario.Text)
            qtde = Double.Parse(txt_qtde.Text)
        Catch ex As Exception
            Exit Sub
        End Try

        txt_subtotal.Text = "$" & (valor_unitario * qtde).ToString
    End Sub

    Private Sub btn_limpar_campos_Click(sender As Object, e As EventArgs) Handles btn_limpar_campos.Click
        limpar_campos()
    End Sub

    Private Sub btn_adicionar_produto_Click(sender As Object, e As EventArgs) Handles btn_adicionar_produto.Click
        If pedido_finalizado(ID_pedido) Or pedido_cancelado(ID_pedido) Then
            mensagem_aviso("Pedido já finalizado! Nenhuma alteração será feita")
            Exit Sub
        End If
        Dim id_produto, qtde_produto As Integer
        Dim valor_unitario, total As Double
        Try
            id_produto = Integer.Parse(txt_cod_produto.Text)
            qtde_produto = Integer.Parse(txt_qtde.Text)
            valor_unitario = Double.Parse(txt_valor_unitario.Text)
            total = Double.Parse(txt_total.Text)
        Catch ex As Exception
            mensagem_erro("Alguns dos valores inseridos não são validos. Favor preencher corretamente")
            Exit Sub
        End Try
        total += valor_unitario * qtde_produto
        adicionar_produto_a_pedido(ID_pedido, id_produto, qtde_produto)
        rs = consultar_pedido_id(ID_pedido)
        Try
            If rs.EOF = False Then
                alterar_pedido(Integer.Parse(rs.Fields(3).Value), rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Integer.Parse(ID_pedido), total)
                mensagem_sucesso("Sucesso na alteração do total do pedido")
            End If
        Catch ex As Exception
            mensagem_erro("Erro na alteração do valor total do pedido!")
        End Try
        preencher_pedido_produtos()
    End Sub

    Sub preencher_pedido_produtos()
        Dim pedido_produto As ADODB.Recordset
        dgv_pedidos_produto.Rows.Clear()
        pedido_produto = selecionar_como_join("pedido_produto", "produto", "ID_produto", "ID_produto", "ID_pedido", ID_pedido.ToString)
        While pedido_produto.EOF = False
            Dim categoria As ADODB.Recordset
            Dim id_categoria, qtde_produto As Integer
            Dim valor_unitario As Double
            Try
                id_categoria = Integer.Parse(pedido_produto.Fields(8).Value)
                qtde_produto = Integer.Parse(pedido_produto.Fields(3).Value)
                valor_unitario = Double.Parse(pedido_produto.Fields(6).Value)
                categoria = consultar_categoria_id(id_categoria)

                With dgv_pedidos_produto
                    .Rows.Add(pedido_produto.Fields(0).Value, pedido_produto.Fields(5).Value, categoria.Fields(1).Value, qtde_produto, qtde_produto * valor_unitario, Nothing)
                End With
            Catch ex As Exception
                mensagem_erro("Erro ao carregar dados do pedido:" & ex.Message & " -> " & ex.StackTrace)
            End Try
            pedido_produto.MoveNext()
        End While
    End Sub

    Private Sub btn_finalizar_pedido_Click(sender As Object, e As EventArgs) Handles btn_finalizar_pedido.Click
        If pedido_finalizado(ID_pedido) or pedido_cancelado(ID_pedido) Then
            mensagem_aviso("Pedido já finalizado! Nenhuma alteração será feita")
            Exit Sub
        End If
        rs = consultar_pedido_id(ID_pedido)
        resp = mensagem_opcao("Deseja realmente finalizar o pedido?" + vbNewLine &
                               "(Essa ação não poderá ser desfeita, e o pedido se tornará imutável.)")
        Try
            If rs.EOF = False Then
                alterar_pedido(Integer.Parse(rs.Fields(3).Value), rs.Fields(4).Value, "Finalizado", cmb_forma_pagto.Text, Integer.Parse(ID_pedido), rs.Fields(2).Value)
                mensagem_sucesso("Sucesso na alteração do total do pedido")
            End If
        Catch ex As Exception
            mensagem_erro("Erro na alteração do valor total do pedido: " & ex.Message & "->" & ex.StackTrace)
        End Try
        preencher_dados_pedido()
    End Sub

    Private Sub dgv_pedidos_produto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos_produto.CellContentClick
        If dgv_pedidos_produto.CurrentRow.Cells(5).Selected Then
            If pedido_finalizado(ID_pedido) Then
                mensagem_aviso("Pedido já finalizado! Nenhuma alteração será feita")
                Exit Sub
            End If
            resp = mensagem_opcao("Deseja realmente remover o produto do pedido?")
            If resp = vbNo Then
                mensagem_aviso("Remoção cancelada")
                Exit Sub
            End If
            remover_produto_do_pedido(ID_pedido, Integer.Parse(dgv_pedidos_produto.CurrentRow.Cells(0).Value))
            mensagem_sucesso("Produto removido com sucesso")
            preencher_dados_pedido()
            preencher_pedido_produtos()
        End If
    End Sub

    Sub retornar_ao_menu()
        Try
            frm_orders.ShowDialog()
            Me.Close()
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        retornar_ao_menu()
    End Sub

    Private Sub btn_cancelar_pedido_Click(sender As Object, e As EventArgs) Handles btn_cancelar_pedido.Click
        If pedido_finalizado(ID_pedido) Or pedido_cancelado(ID_pedido) Then
            mensagem_aviso("Pedido já finalizado! Nenhuma alteração será feita")
            Exit Sub
        End If
        rs = consultar_pedido_id(ID_pedido)
        resp = mensagem_opcao("Deseja realmente finalizar o pedido?" + vbNewLine &
                               "(Essa ação não poderá ser desfeita, e o pedido se tornará imutável.)")
        Try
            If rs.EOF = False Then
                alterar_pedido(Integer.Parse(rs.Fields(3).Value), rs.Fields(4).Value, "Cancelado", cmb_forma_pagto.Text, Integer.Parse(ID_pedido), rs.Fields(2).Value)
                mensagem_sucesso("Sucesso na alteração do total do pedido")
            End If
        Catch ex As Exception
            mensagem_erro("Erro na alteração do valor total do pedido: " & ex.Message & "->" & ex.StackTrace)
        End Try
        preencher_dados_pedido()
    End Sub

    Private Sub btn_quitReq_Click(sender As Object, e As EventArgs) Handles btn_quitReq.Click
        Me.Close()
    End Sub
End Class