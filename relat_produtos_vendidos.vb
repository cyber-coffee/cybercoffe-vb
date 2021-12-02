Public Class relat_produtos_vendidos
    Private Sub relat_produtos_vendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        preencher_campos()
        footer_date.Text = get_curr_date()
        cmb_campo_ordenacao.SelectedIndex = 0
    End Sub

    Sub preencher_campos()
        dgv_relat_produtos.Rows.Clear()
        rs = relatorio_produtos_vendidos_agrupar_produto_e_data("Data")
        While rs.EOF = False
            With dgv_relat_produtos
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
            End With
            rs.MoveNext()
        End While
    End Sub

    Sub preencher_campos_customizado(tipo_ordenacao As String)
        dgv_relat_produtos.Rows.Clear()
        If chk_agrupar_produtos.Checked Then
            rs = relatorio_produtos_vendidos_agrupar_produto(tipo_ordenacao)
        Else
            rs = relatorio_produtos_vendidos_agrupar_produto_e_data(tipo_ordenacao)
        End If

        While rs.EOF = False
            With dgv_relat_produtos
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
            End With
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmb_campo_ordenacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_campo_ordenacao.SelectedIndexChanged
        preencher_campos_customizado(cmb_campo_ordenacao.Text)
    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        Me.Close()
    End Sub

    Private Sub chk_agrupar_produtos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_agrupar_produtos.CheckedChanged
        preencher_campos_customizado(cmb_campo_ordenacao.Text)
    End Sub
End Class