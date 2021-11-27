Public Class frm_menu_atendente

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        frm_products.Show()

    End Sub


    Private Sub frm_menu_atendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_nome.Text = "Funcionario logado: " + nome_func
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        resp = MsgBox("Deseja mesmo fazer logout?", vbInformation + vbYesNo, "Logout")
        If resp = vbYes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PrcessosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrcessosToolStripMenuItem.Click
        frm_processos.Show()

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        frm_orders.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_processos.Show()

    End Sub

End Class