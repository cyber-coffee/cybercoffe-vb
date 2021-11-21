Public Class frm_signin


    Private Sub btn2_signin_Click(sender As Object, e As EventArgs) Handles btn2_signin.Click
        If txt_user.Text = "" Or
            txt_cpf.Text = "" Or
            (txt_manager.Text = "" And ckb_gerente.Checked = False) Or
            txt_password.Text = "" Or
            txt_cpassword.Text = "" Then
            MsgBox("preencha todos os campos!", vbExclamation + vbOKOnly, "AVISO")
            Exit Sub

        ElseIf txt_password.Text <> txt_cpassword.Text Then
            MsgBox("Senhas não conferem!", vbExclamation + vbOKOnly, "AVISO")
            txt_password.Clear()
            txt_cpassword.Clear()
            txt_password.Focus()
            Exit Sub
        End If

        If Me.ckb_atendente.Checked = True Then


            sql = "SELECT * from atendente WHERE CPF_atendente = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("Funcionario de CPF: " & txt_cpf.Text & " ja registrado no sistema.", vbExclamation + vbOKOnly, "AVISO")
                Exit Sub
            Else
                sql = "INSERT INTO atendente (nome, senha, CPF_atendente, ID_gerente) VALUES ('" & txt_user.Text & "', '" & txt_password.Text & "', '" & txt_cpf.Text & "', '" & cmb_cargo.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Funcionario de cpf: " & txt_cpf.Text & ", registrado com sucesso", vbInformation + vbOKOnly, "AVISO")
                txt_user.Clear()
                txt_password.Clear()
                txt_cpassword.Clear()
                txt_cpf.Clear()
                txt_manager.Clear()
                txt_user.Focus()
            End If
            Exit Sub

        ElseIf Me.ckb_gerente.Checked = True Then


            sql = "SELECT * from gerente WHERE CPF_gerente = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("Gerente de CPF: " & txt_cpf.Text & " ja registrado no sistema.", vbExclamation + vbOKOnly, "AVISO")
                Exit Sub
            Else
                sql = "INSERT INTO gerente (nome, senha, CPF_gerente) VALUES ('" & txt_user.Text & "', '" & txt_password.Text & "'," &
                        "'" & txt_cpf.Text & "')"

                rs = db.Execute(sql)
                MsgBox("Gerente de cpf: " & txt_cpf.Text & ", registrado com sucesso", vbInformation + vbOKOnly, "AVISO")
                txt_user.Clear()
                txt_password.Clear()
                txt_cpassword.Clear()
                txt_cpf.Clear()
                txt_manager.Clear()
                txt_user.Focus()

            End If

        End If

    End Sub

    Private Sub frm_signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conecta_banco_mysql()
        sql = "SELECT ID_gerente from gerente"
        rs = db.Execute(sql)

        While rs.EOF = False
            Id_gerente = rs.Fields(0).Value
            cmb_cargo.Items.Add(Id_gerente)
            rs.MoveNext()
        End While

    End Sub

    Private Sub link_encerrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_encerrar.LinkClicked
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub ckb_gerente_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_gerente.CheckedChanged
        If ckb_gerente.Checked = True Then
            ckb_atendente.Visible = False
            cmb_cargo.Enabled = False
            txt_manager.Clear()
        Else
            ckb_atendente.Visible = True
            cmb_cargo.Enabled = True

        End If
    End Sub

    Private Sub ckb_atendente_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_atendente.CheckedChanged
        If ckb_atendente.Checked = True Then
            ckb_gerente.Visible = False
        Else
            ckb_gerente.Visible = True
        End If
    End Sub

    Private Sub cmb_cargo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_cargo.SelectedValueChanged
        sql = "SELECT nome from gerente WHERE ID_gerente = " & cmb_cargo.Text & ""
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_manager.Text = rs.Fields(0).Value
        End If
    End Sub
End Class