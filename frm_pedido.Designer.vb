<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido))
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_pedidos_produto = New System.Windows.Forms.DataGridView()
        Me.id_pedido_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_produto_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtde_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_remover_pedido_produto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_valor_unitario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_adicionar_produto = New System.Windows.Forms.Button()
        Me.btn_limpar_campos = New System.Windows.Forms.Button()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_produto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id_pedido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_nome_atendente = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cargo_atendente = New System.Windows.Forms.Label()
        Me.btn_retornar_menu = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_cpf_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_finalizar_pedido = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_status_pedido = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_forma_pagto = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_pedidos_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(9, 18)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 40
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(253, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 333)
        Me.TabControl1.TabIndex = 41
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dgv_pedidos_produto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(604, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resumo do pedido"
        '
        'dgv_pedidos_produto
        '
        Me.dgv_pedidos_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pedidos_produto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgv_pedidos_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos_produto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pedido_produto, Me.nome_produto_pedido, Me.nome_categoria, Me.qtde_pedido, Me.valor_subtotal, Me.btn_remover_pedido_produto})
        Me.dgv_pedidos_produto.Location = New System.Drawing.Point(3, 3)
        Me.dgv_pedidos_produto.Name = "dgv_pedidos_produto"
        Me.dgv_pedidos_produto.RowTemplate.Height = 25
        Me.dgv_pedidos_produto.Size = New System.Drawing.Size(598, 342)
        Me.dgv_pedidos_produto.TabIndex = 0
        '
        'id_pedido_produto
        '
        Me.id_pedido_produto.HeaderText = "ID"
        Me.id_pedido_produto.Name = "id_pedido_produto"
        '
        'nome_produto_pedido
        '
        Me.nome_produto_pedido.HeaderText = "Produto"
        Me.nome_produto_pedido.Name = "nome_produto_pedido"
        '
        'nome_categoria
        '
        Me.nome_categoria.HeaderText = "Categoria"
        Me.nome_categoria.Name = "nome_categoria"
        '
        'qtde_pedido
        '
        Me.qtde_pedido.HeaderText = "Quantidade"
        Me.qtde_pedido.Name = "qtde_pedido"
        '
        'valor_subtotal
        '
        Me.valor_subtotal.HeaderText = "Subtotal"
        Me.valor_subtotal.Name = "valor_subtotal"
        '
        'btn_remover_pedido_produto
        '
        Me.btn_remover_pedido_produto.HeaderText = "REMOVER"
        Me.btn_remover_pedido_produto.Image = CType(resources.GetObject("btn_remover_pedido_produto.Image"), System.Drawing.Image)
        Me.btn_remover_pedido_produto.Name = "btn_remover_pedido_produto"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.txt_valor_unitario)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.btn_adicionar_produto)
        Me.TabPage2.Controls.Add(Me.btn_limpar_campos)
        Me.TabPage2.Controls.Add(Me.txt_subtotal)
        Me.TabPage2.Controls.Add(Me.txt_qtde)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.txt_cod_produto)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.cmb_produto)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.cmb_categoria)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(604, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adicionar novo Produto"
        '
        'txt_valor_unitario
        '
        Me.txt_valor_unitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_valor_unitario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valor_unitario.Enabled = False
        Me.txt_valor_unitario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_valor_unitario.ForeColor = System.Drawing.Color.White
        Me.txt_valor_unitario.Location = New System.Drawing.Point(185, 202)
        Me.txt_valor_unitario.Name = "txt_valor_unitario"
        Me.txt_valor_unitario.PlaceholderText = "$0.00"
        Me.txt_valor_unitario.Size = New System.Drawing.Size(164, 18)
        Me.txt_valor_unitario.TabIndex = 73
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(185, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 21)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Valor unitário"
        '
        'btn_adicionar_produto
        '
        Me.btn_adicionar_produto.BackColor = System.Drawing.Color.White
        Me.btn_adicionar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_adicionar_produto.Location = New System.Drawing.Point(27, 261)
        Me.btn_adicionar_produto.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_adicionar_produto.Name = "btn_adicionar_produto"
        Me.btn_adicionar_produto.Size = New System.Drawing.Size(200, 26)
        Me.btn_adicionar_produto.TabIndex = 71
        Me.btn_adicionar_produto.Text = "Adicionar Produto"
        Me.btn_adicionar_produto.UseVisualStyleBackColor = False
        '
        'btn_limpar_campos
        '
        Me.btn_limpar_campos.BackColor = System.Drawing.Color.White
        Me.btn_limpar_campos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpar_campos.Location = New System.Drawing.Point(237, 261)
        Me.btn_limpar_campos.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_limpar_campos.Name = "btn_limpar_campos"
        Me.btn_limpar_campos.Size = New System.Drawing.Size(200, 26)
        Me.btn_limpar_campos.TabIndex = 61
        Me.btn_limpar_campos.Text = "Limpar Campos"
        Me.btn_limpar_campos.UseVisualStyleBackColor = False
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_subtotal.ForeColor = System.Drawing.Color.White
        Me.txt_subtotal.Location = New System.Drawing.Point(369, 202)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.PlaceholderText = "$0.00"
        Me.txt_subtotal.Size = New System.Drawing.Size(164, 18)
        Me.txt_subtotal.TabIndex = 61
        '
        'txt_qtde
        '
        Me.txt_qtde.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_qtde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtde.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_qtde.ForeColor = System.Drawing.Color.White
        Me.txt_qtde.Location = New System.Drawing.Point(64, 202)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.PlaceholderText = "Quantidade"
        Me.txt_qtde.Size = New System.Drawing.Size(107, 18)
        Me.txt_qtde.TabIndex = 68
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(27, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 15)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "___________________________"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(31, 202)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 18)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 70
        Me.PictureBox4.TabStop = False
        '
        'txt_cod_produto
        '
        Me.txt_cod_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cod_produto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod_produto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cod_produto.ForeColor = System.Drawing.Color.White
        Me.txt_cod_produto.Location = New System.Drawing.Point(411, 94)
        Me.txt_cod_produto.Name = "txt_cod_produto"
        Me.txt_cod_produto.PlaceholderText = "Código"
        Me.txt_cod_produto.Size = New System.Drawing.Size(164, 18)
        Me.txt_cod_produto.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(374, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 15)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "___________________________"
        '
        'cmb_produto
        '
        Me.cmb_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_produto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_produto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_produto.FormattingEnabled = True
        Me.cmb_produto.Location = New System.Drawing.Point(185, 100)
        Me.cmb_produto.Name = "cmb_produto"
        Me.cmb_produto.Size = New System.Drawing.Size(164, 23)
        Me.cmb_produto.TabIndex = 67
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(378, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'cmb_categoria
        '
        Me.cmb_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(23, 100)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(148, 23)
        Me.cmb_categoria.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(369, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 21)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Subtotal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(23, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 21)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Quantidade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(369, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 21)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Código do Produto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(185, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Produto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(23, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Categoria"
        '
        'txt_id_pedido
        '
        Me.txt_id_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_id_pedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_pedido.Enabled = False
        Me.txt_id_pedido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_id_pedido.ForeColor = System.Drawing.Color.White
        Me.txt_id_pedido.Location = New System.Drawing.Point(292, 18)
        Me.txt_id_pedido.Name = "txt_id_pedido"
        Me.txt_id_pedido.PlaceholderText = "Id do pedido"
        Me.txt_id_pedido.Size = New System.Drawing.Size(164, 18)
        Me.txt_id_pedido.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(255, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 15)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "________________________________________________________"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(259, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 50
        Me.PictureBox3.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_retornar_menu)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(9, 62)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(223, 147)
        Me.FlowLayoutPanel2.TabIndex = 51
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.PictureBox5)
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_nome_atendente)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(10, 13)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(10, 13, 3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(200, 37)
        Me.FlowLayoutPanel3.TabIndex = 29
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 28
        Me.PictureBox5.TabStop = False
        '
        'txt_nome_atendente
        '
        Me.txt_nome_atendente.AutoSize = True
        Me.txt_nome_atendente.ForeColor = System.Drawing.Color.White
        Me.txt_nome_atendente.Location = New System.Drawing.Point(33, 10)
        Me.txt_nome_atendente.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txt_nome_atendente.Name = "txt_nome_atendente"
        Me.txt_nome_atendente.Size = New System.Drawing.Size(92, 15)
        Me.txt_nome_atendente.TabIndex = 0
        Me.txt_nome_atendente.Text = "Employee name"
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel4.Controls.Add(Me.txt_cargo_atendente)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(10, 66)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(10, 13, 3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(200, 37)
        Me.FlowLayoutPanel4.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'txt_cargo_atendente
        '
        Me.txt_cargo_atendente.AutoSize = True
        Me.txt_cargo_atendente.ForeColor = System.Drawing.Color.White
        Me.txt_cargo_atendente.Location = New System.Drawing.Point(33, 10)
        Me.txt_cargo_atendente.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txt_cargo_atendente.Name = "txt_cargo_atendente"
        Me.txt_cargo_atendente.Size = New System.Drawing.Size(30, 15)
        Me.txt_cargo_atendente.TabIndex = 0
        Me.txt_cargo_atendente.Text = "Role"
        '
        'btn_retornar_menu
        '
        Me.btn_retornar_menu.BackColor = System.Drawing.Color.White
        Me.btn_retornar_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_retornar_menu.Location = New System.Drawing.Point(10, 114)
        Me.btn_retornar_menu.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_retornar_menu.Name = "btn_retornar_menu"
        Me.btn_retornar_menu.Size = New System.Drawing.Size(200, 26)
        Me.btn_retornar_menu.TabIndex = 31
        Me.btn_retornar_menu.Text = "Retornar ao menu"
        Me.btn_retornar_menu.UseVisualStyleBackColor = False
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(695, 437)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.PlaceholderText = "Total"
        Me.txt_total.Size = New System.Drawing.Size(164, 18)
        Me.txt_total.TabIndex = 52
        '
        'txt_cpf_cliente
        '
        Me.txt_cpf_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cpf_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf_cliente.Enabled = False
        Me.txt_cpf_cliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cpf_cliente.ForeColor = System.Drawing.Color.White
        Me.txt_cpf_cliente.Location = New System.Drawing.Point(254, 437)
        Me.txt_cpf_cliente.Name = "txt_cpf_cliente"
        Me.txt_cpf_cliente.PlaceholderText = "CPF do Cliente"
        Me.txt_cpf_cliente.Size = New System.Drawing.Size(164, 18)
        Me.txt_cpf_cliente.TabIndex = 53
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_nome_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_cliente.Enabled = False
        Me.txt_nome_cliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nome_cliente.ForeColor = System.Drawing.Color.White
        Me.txt_nome_cliente.Location = New System.Drawing.Point(442, 437)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.PlaceholderText = "Nome do Cliente"
        Me.txt_nome_cliente.Size = New System.Drawing.Size(164, 18)
        Me.txt_nome_cliente.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(253, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(442, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(695, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Total"
        '
        'btn_finalizar_pedido
        '
        Me.btn_finalizar_pedido.BackColor = System.Drawing.Color.White
        Me.btn_finalizar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_finalizar_pedido.Location = New System.Drawing.Point(22, 369)
        Me.btn_finalizar_pedido.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_finalizar_pedido.Name = "btn_finalizar_pedido"
        Me.btn_finalizar_pedido.Size = New System.Drawing.Size(200, 26)
        Me.btn_finalizar_pedido.TabIndex = 58
        Me.btn_finalizar_pedido.Text = "Finalizar Pedido"
        Me.btn_finalizar_pedido.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 21)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Status do Pedido"
        '
        'txt_status_pedido
        '
        Me.txt_status_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_status_pedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_status_pedido.Enabled = False
        Me.txt_status_pedido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_status_pedido.ForeColor = System.Drawing.Color.White
        Me.txt_status_pedido.Location = New System.Drawing.Point(20, 262)
        Me.txt_status_pedido.Name = "txt_status_pedido"
        Me.txt_status_pedido.PlaceholderText = "Status do pedido"
        Me.txt_status_pedido.Size = New System.Drawing.Size(164, 18)
        Me.txt_status_pedido.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 298)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 21)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Forma de Pagamento"
        '
        'cmb_forma_pagto
        '
        Me.cmb_forma_pagto.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_forma_pagto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_forma_pagto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_forma_pagto.FormattingEnabled = True
        Me.cmb_forma_pagto.Items.AddRange(New Object() {"Dinheiro", "Cartão de crédito", "Cartão de débito"})
        Me.cmb_forma_pagto.Location = New System.Drawing.Point(22, 324)
        Me.cmb_forma_pagto.Name = "cmb_forma_pagto"
        Me.cmb_forma_pagto.Size = New System.Drawing.Size(197, 23)
        Me.cmb_forma_pagto.TabIndex = 72
        '
        'frm_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 473)
        Me.Controls.Add(Me.cmb_forma_pagto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_status_pedido)
        Me.Controls.Add(Me.btn_finalizar_pedido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome_cliente)
        Me.Controls.Add(Me.txt_cpf_cliente)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.txt_id_pedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_logo)
        Me.Name = "frm_pedido"
        Me.Text = "frm_pedido"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_pedidos_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_logo As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_id_pedido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgv_pedidos_produto As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_nome_atendente As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_cargo_atendente As Label
    Friend WithEvents btn_retornar_menu As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents id_pedido_produto As DataGridViewTextBoxColumn
    Friend WithEvents nome_produto_pedido As DataGridViewTextBoxColumn
    Friend WithEvents nome_categoria As DataGridViewTextBoxColumn
    Friend WithEvents qtde_pedido As DataGridViewTextBoxColumn
    Friend WithEvents valor_subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btn_remover_pedido_produto As DataGridViewImageColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cpf_cliente As TextBox
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_finalizar_pedido As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_status_pedido As TextBox
    Friend WithEvents cmb_produto As ComboBox
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents btn_adicionar_produto As Button
    Friend WithEvents btn_limpar_campos As Button
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txt_cod_produto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_forma_pagto As ComboBox
    Friend WithEvents txt_valor_unitario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tn As Button
End Class
