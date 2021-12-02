<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relat_produtos_vendidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_retornar_menu = New System.Windows.Forms.Button()
        Me.cmb_campo_ordenacao = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.dgv_relat_produtos = New System.Windows.Forms.DataGridView()
        Me.Data_emissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtde_produtos_vendidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.footer_date = New System.Windows.Forms.TextBox()
        Me.chk_agrupar_produtos = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_relat_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_retornar_menu
        '
        Me.btn_retornar_menu.BackColor = System.Drawing.Color.White
        Me.btn_retornar_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_retornar_menu.Location = New System.Drawing.Point(12, 25)
        Me.btn_retornar_menu.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_retornar_menu.Name = "btn_retornar_menu"
        Me.btn_retornar_menu.Size = New System.Drawing.Size(200, 26)
        Me.btn_retornar_menu.TabIndex = 80
        Me.btn_retornar_menu.Text = "Retornar ao menu"
        Me.btn_retornar_menu.UseVisualStyleBackColor = False
        '
        'cmb_campo_ordenacao
        '
        Me.cmb_campo_ordenacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_campo_ordenacao.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_campo_ordenacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_campo_ordenacao.FormattingEnabled = True
        Me.cmb_campo_ordenacao.Items.AddRange(New Object() {"Data", "Nome do Produto", "Quantidade de produtos vendidos"})
        Me.cmb_campo_ordenacao.Location = New System.Drawing.Point(525, 108)
        Me.cmb_campo_ordenacao.Name = "cmb_campo_ordenacao"
        Me.cmb_campo_ordenacao.Size = New System.Drawing.Size(263, 23)
        Me.cmb_campo_ordenacao.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 32)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Relatório: Produtos Vendidos"
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(684, 30)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 77
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'dgv_relat_produtos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.dgv_relat_produtos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_relat_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_relat_produtos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgv_relat_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_relat_produtos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_relat_produtos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_relat_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data_emissao, Me.Nome_produto, Me.qtde_produtos_vendidos})
        Me.dgv_relat_produtos.GridColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgv_relat_produtos.Location = New System.Drawing.Point(12, 162)
        Me.dgv_relat_produtos.Name = "dgv_relat_produtos"
        Me.dgv_relat_produtos.RowTemplate.Height = 25
        Me.dgv_relat_produtos.Size = New System.Drawing.Size(776, 263)
        Me.dgv_relat_produtos.TabIndex = 76
        '
        'Data_emissao
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.Data_emissao.DefaultCellStyle = DataGridViewCellStyle3
        Me.Data_emissao.HeaderText = "Data"
        Me.Data_emissao.Name = "Data_emissao"
        '
        'Nome_produto
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.Nome_produto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nome_produto.HeaderText = "Nome do Produto"
        Me.Nome_produto.Name = "Nome_produto"
        '
        'qtde_produtos_vendidos
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.qtde_produtos_vendidos.DefaultCellStyle = DataGridViewCellStyle5
        Me.qtde_produtos_vendidos.HeaderText = "Qtde. Produtos Vendidos"
        Me.qtde_produtos_vendidos.Name = "qtde_produtos_vendidos"
        '
        'footer_date
        '
        Me.footer_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.footer_date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.footer_date.Enabled = False
        Me.footer_date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.footer_date.ForeColor = System.Drawing.Color.White
        Me.footer_date.Location = New System.Drawing.Point(717, 452)
        Me.footer_date.Name = "footer_date"
        Me.footer_date.PlaceholderText = "00/00/0000"
        Me.footer_date.Size = New System.Drawing.Size(71, 18)
        Me.footer_date.TabIndex = 81
        '
        'chk_agrupar_produtos
        '
        Me.chk_agrupar_produtos.AutoSize = True
        Me.chk_agrupar_produtos.ForeColor = System.Drawing.Color.White
        Me.chk_agrupar_produtos.Location = New System.Drawing.Point(12, 112)
        Me.chk_agrupar_produtos.Name = "chk_agrupar_produtos"
        Me.chk_agrupar_produtos.Size = New System.Drawing.Size(125, 19)
        Me.chk_agrupar_produtos.TabIndex = 82
        Me.chk_agrupar_produtos.Text = "Agrupar produtos?"
        Me.chk_agrupar_produtos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(445, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Ordenar por:"
        '
        'relat_produtos_vendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_agrupar_produtos)
        Me.Controls.Add(Me.footer_date)
        Me.Controls.Add(Me.btn_retornar_menu)
        Me.Controls.Add(Me.cmb_campo_ordenacao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_logo)
        Me.Controls.Add(Me.dgv_relat_produtos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "relat_produtos_vendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "relat_produtos_vendidos"
        CType(Me.dgv_relat_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_retornar_menu As Button
    Friend WithEvents cmb_campo_ordenacao As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_logo As Label
    Friend WithEvents dgv_relat_produtos As DataGridView
    Friend WithEvents footer_date As TextBox
    Friend WithEvents Data_emissao As DataGridViewTextBoxColumn
    Friend WithEvents Nome_produto As DataGridViewTextBoxColumn
    Friend WithEvents qtde_produtos_vendidos As DataGridViewTextBoxColumn
    Friend WithEvents chk_agrupar_produtos As CheckBox
    Friend WithEvents Label1 As Label
End Class
