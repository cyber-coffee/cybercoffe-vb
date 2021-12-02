Public Class relat_cliente_atendido
    Private Sub relat_cliente_atendido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        preencher_combo_atendentes()
        preencher_dgv()
        cmb_nome_atendente.SelectedIndex = 0
        footer_date.Text = get_curr_date()
    End Sub

    Sub preencher_combo_atendentes()
        rs = consultar_todos_atendentes()
        While rs.EOF = False
            cmb_nome_atendente.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_dgv()
        dgv_relat_clientes.Rows.Clear()
        sql = "SELECT pedido.Data_emissao, atendente.nome, count(*) as 'Qtde. clientes' FROM `atendente` left join pedido on (atendente.ID_atendente = pedido.ID_atendente) group by atendente.ID_atendente, pedido.Data_emissao order by pedido.Data_emissao"
        rs = db.Execute(sql)
        While rs.EOF = False
            With dgv_relat_clientes
                .Rows.Add(parse_date(rs.Fields(0).Value), rs.Fields(1).Value, rs.Fields(2).Value)
            End With
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_dgv_custom(nome_atendente As String)
        dgv_relat_clientes.Rows.Clear()
        sql = "SELECT pedido.Data_emissao, atendente.nome, count(*) as 'Qtde. clientes' FROM `atendente` left join pedido on (atendente.ID_atendente = pedido.ID_atendente)  where atendente.nome = '" & nome_atendente & "' group by atendente.ID_atendente, pedido.Data_emissao order by pedido.Data_emissao"
        rs = db.Execute(sql)
        While rs.EOF = False
            With dgv_relat_clientes
                .Rows.Add(parse_date(rs.Fields(0).Value), rs.Fields(1).Value, rs.Fields(2).Value)
            End With
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmb_nome_atendente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nome_atendente.SelectedIndexChanged
        If cmb_nome_atendente.SelectedIndex <> 0 Then
            preencher_dgv_custom(cmb_nome_atendente.Text)
        End If
    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        Me.Close()
    End Sub
End Class