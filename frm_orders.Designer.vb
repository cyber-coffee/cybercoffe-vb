<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orders))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_system = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_profile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_log_out = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_atendente = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cargo = New System.Windows.Forms.Label()
        Me.btn_retornar_menu = New System.Windows.Forms.Button()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_orders = New System.Windows.Forms.DataGridView()
        Me.order_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payment_method = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_open = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cod_pedido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_adicionar_pedido = New System.Windows.Forms.Button()
        Me.txt_cod_atendente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome_atendente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_data_emissao = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_pedido = New System.Windows.Forms.Button()
        Me.btn_alterar_pedido = New System.Windows.Forms.Button()
        Me.btn_cadastrar_cliente = New System.Windows.Forms.Button()
        Me.txt_cpf_cliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_system, Me.menu_user})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_system
        '
        Me.menu_system.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_exit})
        Me.menu_system.ForeColor = System.Drawing.Color.White
        Me.menu_system.Name = "menu_system"
        Me.menu_system.Size = New System.Drawing.Size(57, 20)
        Me.menu_system.Text = "System"
        '
        'menu_exit
        '
        Me.menu_exit.Name = "menu_exit"
        Me.menu_exit.Size = New System.Drawing.Size(93, 22)
        Me.menu_exit.Text = "Exit"
        '
        'menu_user
        '
        Me.menu_user.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_profile, Me.menu_log_out})
        Me.menu_user.ForeColor = System.Drawing.Color.White
        Me.menu_user.Name = "menu_user"
        Me.menu_user.Size = New System.Drawing.Size(42, 20)
        Me.menu_user.Text = "User"
        '
        'menu_profile
        '
        Me.menu_profile.Name = "menu_profile"
        Me.menu_profile.Size = New System.Drawing.Size(115, 22)
        Me.menu_profile.Text = "Profile"
        '
        'menu_log_out
        '
        Me.menu_log_out.Name = "menu_log_out"
        Me.menu_log_out.Size = New System.Drawing.Size(115, 22)
        Me.menu_log_out.Text = "Log out"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_retornar_menu)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(42, 105)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(223, 147)
        Me.FlowLayoutPanel2.TabIndex = 20
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.PictureBox5)
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_atendente)
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
        'txt_atendente
        '
        Me.txt_atendente.AutoSize = True
        Me.txt_atendente.ForeColor = System.Drawing.Color.White
        Me.txt_atendente.Location = New System.Drawing.Point(33, 10)
        Me.txt_atendente.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txt_atendente.Name = "txt_atendente"
        Me.txt_atendente.Size = New System.Drawing.Size(92, 15)
        Me.txt_atendente.TabIndex = 0
        Me.txt_atendente.Text = "Employee name"
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel4.Controls.Add(Me.txt_cargo)
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
        'txt_cargo
        '
        Me.txt_cargo.AutoSize = True
        Me.txt_cargo.ForeColor = System.Drawing.Color.White
        Me.txt_cargo.Location = New System.Drawing.Point(33, 10)
        Me.txt_cargo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(30, 15)
        Me.txt_cargo.TabIndex = 0
        Me.txt_cargo.Text = "Role"
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
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(42, 53)
        Me.lbl_logo.Margin = New System.Windows.Forms.Padding(22, 23, 3, 0)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 15
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(291, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(658, 385)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_orders)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(650, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sumário de Pedidos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_orders
        '
        Me.dgv_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_orders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_orders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.dgv_orders.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.order_id, Me.order_date, Me.customer, Me.total, Me.status, Me.payment_method, Me.btn_open})
        Me.dgv_orders.Location = New System.Drawing.Point(3, 3)
        Me.dgv_orders.Name = "dgv_orders"
        Me.dgv_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgv_orders.RowTemplate.Height = 25
        Me.dgv_orders.Size = New System.Drawing.Size(647, 351)
        Me.dgv_orders.TabIndex = 1
        '
        'order_id
        '
        Me.order_id.HeaderText = "Order Id"
        Me.order_id.Name = "order_id"
        Me.order_id.Width = 70
        '
        'order_date
        '
        Me.order_date.HeaderText = "Data de Emissão"
        Me.order_date.Name = "order_date"
        Me.order_date.Width = 108
        '
        'customer
        '
        Me.customer.HeaderText = "Customer"
        Me.customer.Name = "customer"
        Me.customer.Width = 84
        '
        'total
        '
        Me.total.HeaderText = "Total "
        Me.total.Name = "total"
        Me.total.Width = 60
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.Width = 64
        '
        'payment_method
        '
        Me.payment_method.HeaderText = "Forma pagto."
        Me.payment_method.Name = "payment_method"
        Me.payment_method.Width = 95
        '
        'btn_open
        '
        Me.btn_open.HeaderText = "Verificar"
        Me.btn_open.Image = CType(resources.GetObject("btn_open.Image"), System.Drawing.Image)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Width = 55
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_cod_pedido)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.btn_adicionar_pedido)
        Me.TabPage2.Controls.Add(Me.txt_cod_atendente)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_nome_atendente)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_data_emissao)
        Me.TabPage2.Controls.Add(Me.btn_cancelar_pedido)
        Me.TabPage2.Controls.Add(Me.btn_alterar_pedido)
        Me.TabPage2.Controls.Add(Me.btn_cadastrar_cliente)
        Me.TabPage2.Controls.Add(Me.txt_cpf_cliente)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_status)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txt_nome_cliente)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(650, 357)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dados de pedido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(38, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 21)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Código do Pedido"
        '
        'txt_cod_pedido
        '
        Me.txt_cod_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cod_pedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod_pedido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cod_pedido.ForeColor = System.Drawing.Color.White
        Me.txt_cod_pedido.Location = New System.Drawing.Point(75, 99)
        Me.txt_cod_pedido.Name = "txt_cod_pedido"
        Me.txt_cod_pedido.PlaceholderText = "Cód. Pedido (opcional)"
        Me.txt_cod_pedido.Size = New System.Drawing.Size(135, 18)
        Me.txt_cod_pedido.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(38, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 15)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "_____________________________________"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(42, 99)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'btn_adicionar_pedido
        '
        Me.btn_adicionar_pedido.BackColor = System.Drawing.Color.White
        Me.btn_adicionar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_adicionar_pedido.Location = New System.Drawing.Point(429, 105)
        Me.btn_adicionar_pedido.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_adicionar_pedido.Name = "btn_adicionar_pedido"
        Me.btn_adicionar_pedido.Size = New System.Drawing.Size(200, 26)
        Me.btn_adicionar_pedido.TabIndex = 85
        Me.btn_adicionar_pedido.Text = "Novo Pedido"
        Me.btn_adicionar_pedido.UseVisualStyleBackColor = False
        '
        'txt_cod_atendente
        '
        Me.txt_cod_atendente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cod_atendente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod_atendente.Enabled = False
        Me.txt_cod_atendente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cod_atendente.ForeColor = System.Drawing.Color.White
        Me.txt_cod_atendente.Location = New System.Drawing.Point(38, 192)
        Me.txt_cod_atendente.Name = "txt_cod_atendente"
        Me.txt_cod_atendente.PlaceholderText = "0"
        Me.txt_cod_atendente.Size = New System.Drawing.Size(31, 18)
        Me.txt_cod_atendente.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(38, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 21)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Atendente"
        '
        'txt_nome_atendente
        '
        Me.txt_nome_atendente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_nome_atendente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_atendente.Enabled = False
        Me.txt_nome_atendente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nome_atendente.ForeColor = System.Drawing.Color.White
        Me.txt_nome_atendente.Location = New System.Drawing.Point(75, 192)
        Me.txt_nome_atendente.Name = "txt_nome_atendente"
        Me.txt_nome_atendente.PlaceholderText = "Nome do Atendente"
        Me.txt_nome_atendente.Size = New System.Drawing.Size(135, 18)
        Me.txt_nome_atendente.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 21)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Dados do pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(240, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Data emissão"
        '
        'txt_data_emissao
        '
        Me.txt_data_emissao.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_data_emissao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data_emissao.Enabled = False
        Me.txt_data_emissao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_data_emissao.ForeColor = System.Drawing.Color.White
        Me.txt_data_emissao.Location = New System.Drawing.Point(244, 284)
        Me.txt_data_emissao.Name = "txt_data_emissao"
        Me.txt_data_emissao.PlaceholderText = "00/00/0000"
        Me.txt_data_emissao.Size = New System.Drawing.Size(164, 18)
        Me.txt_data_emissao.TabIndex = 79
        '
        'btn_cancelar_pedido
        '
        Me.btn_cancelar_pedido.BackColor = System.Drawing.Color.White
        Me.btn_cancelar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar_pedido.Location = New System.Drawing.Point(429, 204)
        Me.btn_cancelar_pedido.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_cancelar_pedido.Name = "btn_cancelar_pedido"
        Me.btn_cancelar_pedido.Size = New System.Drawing.Size(200, 26)
        Me.btn_cancelar_pedido.TabIndex = 78
        Me.btn_cancelar_pedido.Text = "Cancelar Pedido"
        Me.btn_cancelar_pedido.UseVisualStyleBackColor = False
        '
        'btn_alterar_pedido
        '
        Me.btn_alterar_pedido.BackColor = System.Drawing.Color.White
        Me.btn_alterar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_alterar_pedido.Location = New System.Drawing.Point(429, 155)
        Me.btn_alterar_pedido.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_alterar_pedido.Name = "btn_alterar_pedido"
        Me.btn_alterar_pedido.Size = New System.Drawing.Size(200, 26)
        Me.btn_alterar_pedido.TabIndex = 77
        Me.btn_alterar_pedido.Text = "Alterar Pedido"
        Me.btn_alterar_pedido.UseVisualStyleBackColor = False
        '
        'btn_cadastrar_cliente
        '
        Me.btn_cadastrar_cliente.BackColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(429, 56)
        Me.btn_cadastrar_cliente.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(200, 26)
        Me.btn_cadastrar_cliente.TabIndex = 76
        Me.btn_cadastrar_cliente.Text = "Novo cliente"
        Me.btn_cadastrar_cliente.UseVisualStyleBackColor = False
        '
        'txt_cpf_cliente
        '
        Me.txt_cpf_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cpf_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf_cliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cpf_cliente.ForeColor = System.Drawing.Color.White
        Me.txt_cpf_cliente.Location = New System.Drawing.Point(277, 99)
        Me.txt_cpf_cliente.Name = "txt_cpf_cliente"
        Me.txt_cpf_cliente.PlaceholderText = "CPF do Cliente"
        Me.txt_cpf_cliente.Size = New System.Drawing.Size(107, 18)
        Me.txt_cpf_cliente.TabIndex = 71
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(240, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 15)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "___________________________"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(244, 99)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 18)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 73
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Status"
        '
        'txt_status
        '
        Me.txt_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_status.Enabled = False
        Me.txt_status.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_status.ForeColor = System.Drawing.Color.White
        Me.txt_status.Location = New System.Drawing.Point(46, 282)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.PlaceholderText = "Status"
        Me.txt_status.Size = New System.Drawing.Size(164, 18)
        Me.txt_status.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(240, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "CPF"
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_nome_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_cliente.Enabled = False
        Me.txt_nome_cliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_nome_cliente.ForeColor = System.Drawing.Color.White
        Me.txt_nome_cliente.Location = New System.Drawing.Point(244, 192)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.PlaceholderText = "Nome do Cliente"
        Me.txt_nome_cliente.Size = New System.Drawing.Size(164, 18)
        Me.txt_nome_cliente.TabIndex = 59
        '
        'frm_orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_logo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_orders"
        Me.Text = "Gerenciamento de Pedidos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu_system As ToolStripMenuItem
    Friend WithEvents menu_exit As ToolStripMenuItem
    Friend WithEvents menu_user As ToolStripMenuItem
    Friend WithEvents menu_profile As ToolStripMenuItem
    Friend WithEvents menu_log_out As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_atendente As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_cargo As Label
    Friend WithEvents btn_retornar_menu As Button
    Friend WithEvents lbl_logo As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_orders As DataGridView
    Friend WithEvents order_id As DataGridViewTextBoxColumn
    Friend WithEvents order_date As DataGridViewTextBoxColumn
    Friend WithEvents customer As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents payment_method As DataGridViewTextBoxColumn
    Friend WithEvents btn_open As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents txt_cpf_cliente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_cancelar_pedido As Button
    Friend WithEvents btn_alterar_pedido As Button
    Friend WithEvents btn_cadastrar_cliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_data_emissao As TextBox
    Friend WithEvents txt_cod_atendente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome_atendente As TextBox
    Friend WithEvents btn_adicionar_pedido As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cod_pedido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
