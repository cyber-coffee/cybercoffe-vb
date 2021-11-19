Public Class frm_products
    Private Sub frm_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        rs = consultar_categorias()
        While rs.EOF = False
            With cmb_categoria
                .Items.Add(rs.Fields(1).Value)
            End With
            rs.MoveNext()
        End While

        preencher_produtos()
        preencher_categorias()
    End Sub



    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If txt_nome_produto.Text = "" Or
            txt_valor_unit.Text = "" Or
            txt_qtde_estoque.Text = "" Or
            cmb_categoria.Text = "" Then
            MsgBox("Campos vazios encontrados!" + vbNewLine &
                   "Favor preencher todos os campos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        End If

        Dim valor_unit As Double
        Dim qtde_estoque As Integer

        Try
            valor_unit = Double.Parse(txt_valor_unit.Text)
            qtde_estoque = Integer.Parse(txt_qtde_estoque.Text)
        Catch ex As Exception
            MsgBox("Valor(es) numérico(s) inválido(s)!" + vbNewLine &
                   "Favor preencher valor unitário como decimal e quantidade estoque como valor inteiro.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        End Try

        Dim categoria_id As Integer

        rs = consultar_categoria_nome(cmb_categoria.Text)

        If rs.EOF = True Then
            MsgBox("Categoria não encontrada!" + vbNewLine &
                   "Favor selecionar uma categoria válida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        End If

        categoria_id = rs.Fields(0).Value

        inserir_produto(txt_nome_produto.Text, valor_unit, categoria_id, qtde_estoque)
        MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        preencher_produtos()
        limpar_campos_produto()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If txt_nome_produto.Text = "" Or
            txt_valor_unit.Text = "" Or
            txt_qtde_estoque.Text = "" Or
            cmb_categoria.Text = "" Or
            txt_id.Text = "" Then
            MsgBox("Campos vazios encontrados!" + vbNewLine &
                   "Favor preencher todos os campos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        End If

        Dim valor_unit As Double
        Dim qtde_estoque As Integer

        Try
            valor_unit = Double.Parse(txt_valor_unit.Text)
            qtde_estoque = Integer.Parse(txt_qtde_estoque.Text)
        Catch ex As Exception
            MsgBox("Valor(es) numérico(s) inválido(s)!" + vbNewLine &
                   "Favor preencher valor unitário como decimal e quantidade estoque como valor inteiro.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        End Try

        Dim categoria_id As Integer

        rs = consultar_categoria_nome(cmb_categoria.Text)

        If rs.EOF = True Then
            MsgBox("Categoria não encontrada!" + vbNewLine &
                   "Favor selecionar uma categoria válida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        End If

        categoria_id = rs.Fields(0).Value

        alterar_produto(txt_nome_produto.Text, valor_unit, categoria_id, qtde_estoque, txt_id.Text)
        MsgBox("Produto alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        preencher_produtos()
        limpar_campos_produto()
    End Sub

    Private Sub preencher_produtos()
        dgv_produtos.Rows().Clear()
        rs = consultar_todos_produtos_e_categoria()
        While rs.EOF = False
            With dgv_produtos
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(7).Value, Nothing, Nothing)
            End With
            rs.MoveNext()
        End While
    End Sub

    Private Sub preencher_categorias()
        dgv_categorias.Rows().Clear()
        rs = consultar_categorias()
        While rs.EOF = False
            With dgv_categorias
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
            End With
            rs.MoveNext()
        End While
    End Sub

    Private Sub preencher_produtos_similares(nome_campo As String, valor As String)
        dgv_produtos.Rows().Clear()
        rs = consultar_todos_produtos_e_categoria_como(nome_campo, valor)
        While rs.EOF = False
            With dgv_produtos
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(7).Value, Nothing, Nothing)
            End With
            rs.MoveNext()
        End While
    End Sub

    Private Sub dgv_produtos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellClick
        If dgv_produtos.CurrentRow.Cells(5).Selected Then
            txt_id.Text = dgv_produtos.CurrentRow.Cells(0).Value
            txt_nome_produto.Text = dgv_produtos.CurrentRow.Cells(1).Value
            txt_qtde_estoque.Text = dgv_produtos.CurrentRow.Cells(2).Value
            txt_valor_unit.Text = dgv_produtos.CurrentRow.Cells(3).Value
            cmb_categoria.Text = dgv_produtos.CurrentRow.Cells(4).Value
        End If
        If dgv_produtos.CurrentRow.Cells(6).Selected Then
            resp = mensagem_opcao("Deseja realmente apagar o produto de id: " & dgv_produtos.CurrentRow.Cells(0).Value & "?")
            If resp = vbYes Then
                excluir_produto(dgv_produtos.CurrentRow.Cells(0).Value)
                mensagem_sucesso("Produto excluído com sucesso!")
            Else
                mensagem_sucesso("Remoção cancelada")
            End If
            preencher_produtos()
        End If
    End Sub

    Sub limpar_campos()
        txt_id.Text = ""
        txt_nome_produto.Text = ""
        txt_qtde_estoque.Text = ""

    End Sub

    Private Sub txt_campo_TextChanged(sender As Object, e As EventArgs) Handles txt_campo.TextChanged
        preencher_produtos_similares(cmb_opcoes.Text, txt_campo.Text)
    End Sub

    Private Sub dgv_categorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_categorias.CellClick
        If dgv_categorias.CurrentRow.Cells(2).Selected Then
            txt_id_categoria.Text = dgv_categorias.CurrentRow.Cells(0).Value
            txt_nome_categoria.Text = dgv_categorias.CurrentRow.Cells(1).Value
        End If
        If dgv_categorias.CurrentRow.Cells(3).Selected Then
            resp = mensagem_opcao("Deseja mesmo apagar a categoria: " + dgv_categorias.CurrentRow.Cells(1).Value + "?")
            If resp = vbYes Then
                excluir_categoria(dgv_categorias.CurrentRow.Cells(0).Value)
                mensagem_sucesso("Exclusão feita com sucesso!")
            Else
                mensagem_sucesso("Remoção cancelada")
            End If
            preencher_categorias()
            limpar_campos_categoria()
        End If
    End Sub

    Private Sub btn_editar_categoria_Click(sender As Object, e As EventArgs) Handles btn_editar_categoria.Click
        If txt_id_categoria.Text = "" Or txt_nome_categoria.Text = "" Then
            mensagem_aviso("Campos vazios encontrados! Favor preencher todos os campos necessários")
            Exit Sub
        End If
        alterar_categoria(txt_nome_categoria.Text, txt_id_categoria.Text)
        mensagem_sucesso("Categoria alterada com sucesso!")
        preencher_categorias()
        limpar_campos_categoria()
    End Sub

    Private Sub btn_cadastrar_categoria_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_categoria.Click
        If txt_nome_categoria.Text = "" Then
            mensagem_aviso("Campos vazios encontrados! Favor preencher todos os campos necessários")
            Exit Sub
        End If
        inserir_categoria(txt_nome_categoria.Text)
        mensagem_sucesso("Categoria cadastrada com sucesso!")
        preencher_categorias()
        limpar_campos_categoria()
    End Sub

    Sub limpar_campos_produto()
        txt_id.Text = ""
        txt_nome_produto.Text = ""
        txt_qtde_estoque.Text = ""
        txt_valor_unit.Text = ""
        cmb_categoria.Text = ""
    End Sub

    Sub limpar_campos_categoria()
        txt_id_categoria.Text = ""
        txt_nome_categoria.Text = ""
    End Sub

    Private Sub frm_products_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class