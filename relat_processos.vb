Public Class relat_processos
    Private Sub relat_processos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        preencher_datas()
        cmb_data.SelectedIndex = 0
        preencher_processos()
        footer_date.Text = get_curr_date()
    End Sub

    Sub preencher_processos()
        Try
            rs = consultar_processos_personalizado(cmb_data.Text)
            dgv_relat_processos.Rows.Clear()
            While rs.EOF = False
                With dgv_relat_processos
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                End With
                rs.MoveNext()
            End While
        Catch ex As Exception
            mensagem_erro("Erro ao preencher relatório.")
        End Try
    End Sub

    Sub preencher_datas()
        Dim datas_obj As ADODB.Recordset
        cmb_data.Items.Clear()
        Try
            datas_obj = consultar_datas_processos()
            While datas_obj.EOF = False
                With cmb_data
                    .Items.Add(datas_obj.Fields(0).Value)
                End With
                datas_obj.MoveNext()
            End While
        Catch ex As Exception
            mensagem_erro("Erro ao carregar datas.")
        End Try
    End Sub

    Private Sub cmb_data_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_data.SelectedIndexChanged
        preencher_processos()
    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        Me.Close()
    End Sub
End Class