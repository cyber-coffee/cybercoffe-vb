Public Class frm_processos
    Private Sub frm_processos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nome_funcionario As String
        sql = "SELECT nome FROM atendente"
        rs = db.Execute(sql)

        While rs.EOF = False
            nome_funcionario = rs.Fields(0).Value
            cmb_funcionarios.Items.Add(nome_funcionario)
            rs.MoveNext()

        End While
    End Sub

    Private Sub cmb_funcionarios_TextChanged(sender As Object, e As EventArgs) Handles cmb_funcionarios.TextChanged
        sql = "select cliente.CPF_cliente, cliente.nome_cliente, pedido.ID_pedido from pedido left join cliente on (cliente.CPF_cliente = pedido.CPF_cliente) 
    where pedido.ID_atendente = (select ID_atendente from atendente where atendente.nome = '" & cmb_funcionarios.Text & "')"

        rs = db.Execute(sql)
        While rs.EOF = False
            dgv_clientes.Rows().Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
            rs.MoveNext()
        End While


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
