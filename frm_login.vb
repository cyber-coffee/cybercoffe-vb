Public Class frm_login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_signin.Click
        frm_signin.Show()
        Me.Hide()

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conecta_banco_mysql()
        limpar_txt()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_user.Text = "" Or
            txt_password.Text = "" Then
            MsgBox("Preencha todos os campos!!", vbExclamation + vbOKOnly, "AVISO")
        Else
            sql = "SELECT * from atendente WHERE nome = '" & txt_user.Text & "' and senha = '" & txt_password.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Funcionário: " & txt_user.Text & ", logado com sucesso.", vbInformation + vbOKOnly, "AVISO")
                frm_menu_atendente.Show()
                Me.Hide()
            Else
                MsgBox("Conta não encontrada no banco!!", vbExclamation + vbOKOnly, "AVISO")
                limpar_txt()

            End If
        End If

    End Sub

    Private Sub lbl_underline_Click(sender As Object, e As EventArgs) Handles lbl_underline.Click

    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        sql = "SELECT * from gerente WHERE nome = '" & txt_user.Text & "' and senha = '" & txt_password.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            btn_signin.Visible = True
        Else
            btn_signin.Visible = False
        End If
    End Sub

    Private Sub ckb_senha_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_senha.CheckedChanged
        If txt_password.PasswordChar = "*" Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub txt_exit_Click(sender As Object, e As EventArgs) Handles txt_exit.Click
        resp = MsgBox("Deseja mesmo sair do sistema?", vbInformation + vbYesNo, "AVISO")
        If resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_user_DoubleClick(sender As Object, e As EventArgs) Handles txt_user.DoubleClick
        limpar_txt()

    End Sub
End Class