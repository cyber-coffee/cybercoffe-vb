Public Class frm_menu_relat
    Private Sub frm_menu_relat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_relatorio.SelectedIndex = 0
    End Sub

    Private Sub btn_retornar_menu_Click(sender As Object, e As EventArgs) Handles btn_retornar_menu.Click
        Me.Close()
    End Sub

    Private Sub btn_abrir_relatorio_Click(sender As Object, e As EventArgs) Handles btn_abrir_relatorio.Click
        If UCase(cmb_relatorio.Text) = "RELATÓRIO DE PRODUTOS VENDIDOS" Then
            relat_produtos_vendidos.ShowDialog()
        ElseIf UCase(cmb_relatorio.Text) = "RELATÓRIO DE CLIENTES ATENDIDOS" Then
            relat_cliente_atendido.ShowDialog()
        ElseIf UCase(cmb_relatorio.Text) = "RELATÓRIO DE PROCESSOS" Then
            relat_processos.ShowDialog()
        Else
            mensagem_aviso("Relatório não encontrado! Favor selecionar outro relatório.")
        End If
    End Sub
End Class