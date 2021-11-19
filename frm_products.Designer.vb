<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_products))
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cl_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_qtde_estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_valor_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl_buscar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cl_remover = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtde_estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(66, 104)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'txt_product_name
        '
        Me.txt_product_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_product_name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_product_name.ForeColor = System.Drawing.Color.White
        Me.txt_product_name.Location = New System.Drawing.Point(99, 104)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.PlaceholderText = "Nome"
        Me.txt_product_name.Size = New System.Drawing.Size(164, 18)
        Me.txt_product_name.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(62, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "________________________________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(99, 274)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "Quantidade em estoque"
        Me.TextBox1.Size = New System.Drawing.Size(164, 18)
        Me.TextBox1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "________________________________________________________"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cargo", "Atendente", "Gerente"})
        Me.ComboBox1.Location = New System.Drawing.Point(62, 366)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(287, 23)
        Me.ComboBox1.TabIndex = 34
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 192)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(99, 192)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "Valor Unitário"
        Me.TextBox2.Size = New System.Drawing.Size(164, 18)
        Me.TextBox2.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(62, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "________________________________________________________"
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.lbl_category.Location = New System.Drawing.Point(62, 335)
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
        Me.lbl_logo.Location = New System.Drawing.Point(66, 41)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 39
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(369, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 33)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(515, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 33)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(654, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 33)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Excluir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl_id, Me.cl_nome, Me.cl_qtde_estoque, Me.cl_valor_unit, Me.cl_buscar, Me.cl_remover})
        Me.DataGridView1.Location = New System.Drawing.Point(369, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(407, 285)
        Me.DataGridView1.TabIndex = 43
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
        Me.cl_qtde_estoque.HeaderText = "Qtde. Estoque"
        Me.cl_qtde_estoque.Name = "cl_qtde_estoque"
        '
        'cl_valor_unit
        '
        Me.cl_valor_unit.HeaderText = "Valor unitário"
        Me.cl_valor_unit.Name = "cl_valor_unit"
        '
        'cl_buscar
        '
        Me.cl_buscar.HeaderText = "Buscar"
        Me.cl_buscar.Name = "cl_buscar"
        '
        'cl_remover
        '
        Me.cl_remover.HeaderText = "Remover"
        Me.cl_remover.Name = "cl_remover"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = CType(resources.GetObject("ToolStrip1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'frm_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_logo)
        Me.Controls.Add(Me.lbl_category)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_products"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_category As Label
    Friend WithEvents lbl_logo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cl_id As DataGridViewTextBoxColumn
    Friend WithEvents cl_nome As DataGridViewTextBoxColumn
    Friend WithEvents cl_qtde_estoque As DataGridViewTextBoxColumn
    Friend WithEvents cl_valor_unit As DataGridViewTextBoxColumn
    Friend WithEvents cl_buscar As DataGridViewImageColumn
    Friend WithEvents cl_remover As DataGridViewImageColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents valor_unit As DataGridViewTextBoxColumn
    Friend WithEvents qtde_estoque As DataGridViewTextBoxColumn
End Class
