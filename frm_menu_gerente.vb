Public Class frm_menu_gerente
    Private Sub Button21_Click(sender As Object, e As EventArgs)

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

    Private Sub PrcessosToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        frm_processos.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        frm_menu_relat.ShowDialog()
    End Sub
End Class