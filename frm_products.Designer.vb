<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_products))
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_nome_produto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_qtde_estoque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_valor_unit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.cl_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_qtde_estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_valor_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_buscar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cl_remover = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtde_estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txt_campo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_opcoes = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_categorias = New System.Windows.Forms.DataGridView()
        Me.id_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar_categoria = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_remover_categoria = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_editar_categoria = New System.Windows.Forms.Button()
        Me.btn_cadastrar_categoria = New System.Windows.Forms.Button()
        Me.txt_nome_categoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txt_id_categoria = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 150)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'txt_nome_produto
        '
        Me.txt_nome_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_nome_produto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_produto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nome_produto.ForeColor = System.Drawing.Color.White
        Me.txt_nome_produto.Location = New System.Drawing.Point(46, 150)
        Me.txt_nome_produto.Name = "txt_nome_produto"
        Me.txt_nome_produto.PlaceholderText = "Nome"
        Me.txt_nome_produto.Size = New System.Drawing.Size(164, 18)
        Me.txt_nome_produto.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "________________________________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 284)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'txt_qtde_estoque
        '
        Me.txt_qtde_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_qtde_estoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtde_estoque.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_qtde_estoque.ForeColor = System.Drawing.Color.White
        Me.txt_qtde_estoque.Location = New System.Drawing.Point(46, 284)
        Me.txt_qtde_estoque.Name = "txt_qtde_estoque"
        Me.txt_qtde_estoque.PlaceholderText = "Quantidade disponível"
        Me.txt_qtde_estoque.Size = New System.Drawing.Size(164, 18)
        Me.txt_qtde_estoque.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "________________________________________________________"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(13, 354)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(283, 23)
        Me.cmb_categoria.TabIndex = 34
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 217)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'txt_valor_unit
        '
        Me.txt_valor_unit.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_valor_unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valor_unit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_valor_unit.ForeColor = System.Drawing.Color.White
        Me.txt_valor_unit.Location = New System.Drawing.Point(46, 217)
        Me.txt_valor_unit.Name = "txt_valor_unit"
        Me.txt_valor_unit.PlaceholderText = "Valor Unitário"
        Me.txt_valor_unit.Size = New System.Drawing.Size(164, 18)
        Me.txt_valor_unit.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "________________________________________________________"
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lbl_category.Location = New System.Drawing.Point(17, 327)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(58, 15)
        Me.lbl_category.TabIndex = 38
        Me.lbl_category.Text = "Categoria"
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(12, 19)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 39
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'dgv_produtos
        '
        Me.dgv_produtos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_produtos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_id, Me.cl_nome, Me.cl_qtde_estoque, Me.cl_valor_unit, Me.Nome_categoria, Me.cl_buscar, Me.cl_remover})
        Me.dgv_produtos.Location = New System.Drawing.Point(326, 74)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.RowTemplate.Height = 25
        Me.dgv_produtos.Size = New System.Drawing.Size(656, 341)
        Me.dgv_produtos.TabIndex = 43
        '
        'cl_id
        '
        Me.cl_id.HeaderText = "Id"
        Me.cl_id.Name = "cl_id"
        '
        'cl_nome
        '
        Me.cl_nome.HeaderText = "Nome"
        Me.cl_nome.Name = "cl_nome"
        '
        'cl_qtde_estoque
        '
        Me.cl_qtde_estoque.HeaderText = "Qtde. Disponível"
        Me.cl_qtde_estoque.Name = "cl_qtde_estoque"
        '
        'cl_valor_unit
        '
        Me.cl_valor_unit.HeaderText = "Valor unitário"
        Me.cl_valor_unit.Name = "cl_valor_unit"
        '
        'Nome_categoria
        '
        Me.Nome_categoria.HeaderText = "Categoria"
        Me.Nome_categoria.Name = "Nome_categoria"
        '
        'cl_buscar
        '
        Me.cl_buscar.HeaderText = "Buscar"
        Me.cl_buscar.Image = CType(resources.GetObject("cl_buscar.Image"), System.Drawing.Image)
        Me.cl_buscar.Name = "cl_buscar"
        '
        'cl_remover
        '
        Me.cl_remover.HeaderText = "Remover"
        Me.cl_remover.Image = CType(resources.GetObject("cl_remover.Image"), System.Drawing.Image)
        Me.cl_remover.Name = "cl_remover"
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        '
        'valor_unit
        '
        Me.valor_unit.HeaderText = "Valor Unitário"
        Me.valor_unit.Name = "valor_unit"
        '
        'qtde_estoque
        '
        Me.qtde_estoque.HeaderText = "Qtde. Estoque"
        Me.qtde_estoque.Name = "qtde_estoque"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 74)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_id.ForeColor = System.Drawing.Color.White
        Me.txt_id.Location = New System.Drawing.Point(46, 74)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.PlaceholderText = "Id"
        Me.txt_id.Size = New System.Drawing.Size(164, 18)
        Me.txt_id.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 15)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "________________________________________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Cadastro de Produtos"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(331, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 51
        Me.PictureBox4.TabStop = False
        '
        'txt_campo
        '
        Me.txt_campo.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_campo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_campo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_campo.ForeColor = System.Drawing.Color.White
        Me.txt_campo.Location = New System.Drawing.Point(364, 26)
        Me.txt_campo.Name = "txt_campo"
        Me.txt_campo.PlaceholderText = "Campo"
        Me.txt_campo.Size = New System.Drawing.Size(164, 18)
        Me.txt_campo.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(327, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(287, 15)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "________________________________________________________"
        '
        'cmb_opcoes
        '
        Me.cmb_opcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_opcoes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_opcoes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_opcoes.FormattingEnabled = True
        Me.cmb_opcoes.Items.AddRange(New Object() {"Nome_produto", "valor", "Qtde_estoque", "Nome_Categoria"})
        Me.cmb_opcoes.Location = New System.Drawing.Point(671, 28)
        Me.cmb_opcoes.Name = "cmb_opcoes"
        Me.cmb_opcoes.Size = New System.Drawing.Size(311, 23)
        Me.cmb_opcoes.TabIndex = 52
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1016, 447)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btn_editar)
        Me.TabPage2.Controls.Add(Me.btn_cadastrar)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.cmb_opcoes)
        Me.TabPage2.Controls.Add(Me.dgv_produtos)
        Me.TabPage2.Controls.Add(Me.txt_id)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_campo)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.txt_nome_produto)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.PictureBox5)
        Me.TabPage2.Controls.Add(Me.txt_valor_unit)
        Me.TabPage2.Controls.Add(Me.lbl_category)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cmb_categoria)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.txt_qtde_estoque)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1008, 419)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro de produtos"
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(152, 392)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(144, 23)
        Me.btn_editar.TabIndex = 54
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.White
        Me.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(13, 392)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(133, 23)
        Me.btn_cadastrar.TabIndex = 53
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dgv_categorias)
        Me.TabPage1.Controls.Add(Me.btn_editar_categoria)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar_categoria)
        Me.TabPage1.Controls.Add(Me.txt_nome_categoria)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.PictureBox7)
        Me.TabPage1.Controls.Add(Me.txt_id_categoria)
        Me.TabPage1.Controls.Add(Me.PictureBox6)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1008, 419)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Categorias"
        '
        'dgv_categorias
        '
        Me.dgv_categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_categorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_categorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_categoria, Me.categoria, Me.btn_buscar_categoria, Me.btn_remover_categoria})
        Me.dgv_categorias.Location = New System.Drawing.Point(349, 27)
        Me.dgv_categorias.Name = "dgv_categorias"
        Me.dgv_categorias.RowTemplate.Height = 25
        Me.dgv_categorias.Size = New System.Drawing.Size(634, 347)
        Me.dgv_categorias.TabIndex = 60
        '
        'id_categoria
        '
        Me.id_categoria.HeaderText = "Id"
        Me.id_categoria.Name = "id_categoria"
        '
        'categoria
        '
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        '
        'btn_buscar_categoria
        '
        Me.btn_buscar_categoria.HeaderText = "Buscar"
        Me.btn_buscar_categoria.Image = CType(resources.GetObject("btn_buscar_categoria.Image"), System.Drawing.Image)
        Me.btn_buscar_categoria.Name = "btn_buscar_categoria"
        '
        'btn_remover_categoria
        '
        Me.btn_remover_categoria.HeaderText = "Remover"
        Me.btn_remover_categoria.Image = CType(resources.GetObject("btn_remover_categoria.Image"), System.Drawing.Image)
        Me.btn_remover_categoria.Name = "btn_remover_categoria"
        '
        'btn_editar_categoria
        '
        Me.btn_editar_categoria.BackColor = System.Drawing.Color.White
        Me.btn_editar_categoria.Location = New System.Drawing.Point(170, 216)
        Me.btn_editar_categoria.Name = "btn_editar_categoria"
        Me.btn_editar_categoria.Size = New System.Drawing.Size(145, 23)
        Me.btn_editar_categoria.TabIndex = 59
        Me.btn_editar_categoria.Text = "Editar"
        Me.btn_editar_categoria.UseVisualStyleBackColor = False
        '
        'btn_cadastrar_categoria
        '
        Me.btn_cadastrar_categoria.BackColor = System.Drawing.Color.White
        Me.btn_cadastrar_categoria.Location = New System.Drawing.Point(32, 216)
        Me.btn_cadastrar_categoria.Name = "btn_cadastrar_categoria"
        Me.btn_cadastrar_categoria.Size = New System.Drawing.Size(132, 23)
        Me.btn_cadastrar_categoria.TabIndex = 58
        Me.btn_cadastrar_categoria.Text = "Cadastrar"
        Me.btn_cadastrar_categoria.UseVisualStyleBackColor = False
        '
        'txt_nome_categoria
        '
        Me.txt_nome_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_nome_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_categoria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nome_categoria.ForeColor = System.Drawing.Color.White
        Me.txt_nome_categoria.Location = New System.Drawing.Point(65, 149)
        Me.txt_nome_categoria.Name = "txt_nome_categoria"
        Me.txt_nome_categoria.PlaceholderText = "Nome"
        Me.txt_nome_categoria.Size = New System.Drawing.Size(164, 18)
        Me.txt_nome_categoria.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 21)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Cadastro de Categorias"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(28, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(287, 15)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "________________________________________________________"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(32, 149)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 57
        Me.PictureBox7.TabStop = False
        '
        'txt_id_categoria
        '
        Me.txt_id_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_id_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_categoria.Enabled = False
        Me.txt_id_categoria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_id_categoria.ForeColor = System.Drawing.Color.White
        Me.txt_id_categoria.Location = New System.Drawing.Point(65, 76)
        Me.txt_id_categoria.Name = "txt_id_categoria"
        Me.txt_id_categoria.PlaceholderText = "Id"
        Me.txt_id_categoria.Size = New System.Drawing.Size(164, 18)
        Me.txt_id_categoria.TabIndex = 55
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(32, 76)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 57
        Me.PictureBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(28, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 15)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "________________________________________________________"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(989, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 28)
        Me.Button1.TabIndex = 55
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 528)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_products"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_categorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_nome_produto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_qtde_estoque As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_valor_unit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_category As Label
    Friend WithEvents lbl_logo As Label
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents valor_unit As DataGridViewTextBoxColumn
    Friend WithEvents qtde_estoque As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txt_campo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_opcoes As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents dgv_categorias As DataGridView
    Friend WithEvents btn_editar_categoria As Button
    Friend WithEvents btn_cadastrar_categoria As Button
    Friend WithEvents txt_nome_categoria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents txt_id_categoria As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cl_id As DataGridViewTextBoxColumn
    Friend WithEvents cl_nome As DataGridViewTextBoxColumn
    Friend WithEvents cl_qtde_estoque As DataGridViewTextBoxColumn
    Friend WithEvents cl_valor_unit As DataGridViewTextBoxColumn
    Friend WithEvents Nome_categoria As DataGridViewTextBoxColumn
    Friend WithEvents cl_buscar As DataGridViewImageColumn
    Friend WithEvents cl_remover As DataGridViewImageColumn
    Friend WithEvents id_categoria As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents btn_buscar_categoria As DataGridViewImageColumn
    Friend WithEvents btn_remover_categoria As DataGridViewImageColumn
    Friend WithEvents Button1 As Button
End Class
