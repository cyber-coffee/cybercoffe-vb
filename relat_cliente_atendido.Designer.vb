<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relat_cliente_atendido
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
        Me.dgv_relat_clientes = New System.Windows.Forms.DataGridView()
        Me.Data_emissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_atendente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clientes_atendidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.footer_date = New System.Windows.Forms.TextBox()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_nome_atendente = New System.Windows.Forms.ComboBox()
        Me.btn_retornar_menu = New System.Windows.Forms.Button()
        CType(Me.dgv_relat_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_relat_clientes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.dgv_relat_clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_relat_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_relat_clientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgv_relat_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_relat_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_relat_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_relat_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data_emissao, Me.Nome_atendente, Me.Clientes_atendidos})
        Me.dgv_relat_clientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgv_relat_clientes.Location = New System.Drawing.Point(12, 100)
        Me.dgv_relat_clientes.Name = "dgv_relat_clientes"
        Me.dgv_relat_clientes.RowTemplate.Height = 25
        Me.dgv_relat_clientes.Size = New System.Drawing.Size(776, 316)
        Me.dgv_relat_clientes.TabIndex = 0
        '
        'Data_emissao
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.Data_emissao.DefaultCellStyle = DataGridViewCellStyle3
        Me.Data_emissao.HeaderText = "Data emissão"
        Me.Data_emissao.Name = "Data_emissao"
        '
        'Nome_atendente
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.Nome_atendente.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nome_atendente.HeaderText = "Atendente"
        Me.Nome_atendente.Name = "Nome_atendente"
        '
        'Clientes_atendidos
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.Clientes_atendidos.DefaultCellStyle = DataGridViewCellStyle5
        Me.Clientes_atendidos.HeaderText = "Clientes atendidos"
        Me.Clientes_atendidos.Name = "Clientes_atendidos"
        '
        'footer_date
        '
        Me.footer_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.footer_date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.footer_date.Enabled = False
        Me.footer_date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.footer_date.ForeColor = System.Drawing.Color.White
        Me.footer_date.Location = New System.Drawing.Point(717, 503)
        Me.footer_date.Name = "footer_date"
        Me.footer_date.PlaceholderText = "00/00/0000"
        Me.footer_date.Size = New System.Drawing.Size(71, 18)
        Me.footer_date.TabIndex = 60
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(684, 20)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 61
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(537, 32)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Relatório: Clientes recepcionados por atendente"
        '
        'cmb_nome_atendente
        '
        Me.cmb_nome_atendente.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_nome_atendente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_nome_atendente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_nome_atendente.FormattingEnabled = True
        Me.cmb_nome_atendente.Items.AddRange(New Object() {"Nome do Atendente"})
        Me.cmb_nome_atendente.Location = New System.Drawing.Point(630, 59)
        Me.cmb_nome_atendente.Name = "cmb_nome_atendente"
        Me.cmb_nome_atendente.Size = New System.Drawing.Size(158, 23)
        Me.cmb_nome_atendente.TabIndex = 74
        '
        'btn_retornar_menu
        '
        Me.btn_retornar_menu.BackColor = System.Drawing.Color.White
        Me.btn_retornar_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_retornar_menu.Location = New System.Drawing.Point(12, 15)
        Me.btn_retornar_menu.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_retornar_menu.Name = "btn_retornar_menu"
        Me.btn_retornar_menu.Size = New System.Drawing.Size(200, 26)
        Me.btn_retornar_menu.TabIndex = 75
        Me.btn_retornar_menu.Text = "Retornar ao menu"
        Me.btn_retornar_menu.UseVisualStyleBackColor = False
        '
        'relat_cliente_atendido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 533)
        Me.Controls.Add(Me.btn_retornar_menu)
        Me.Controls.Add(Me.cmb_nome_atendente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_logo)
        Me.Controls.Add(Me.footer_date)
        Me.Controls.Add(Me.dgv_relat_clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "relat_cliente_atendido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "relat_cliente_atendidovb"
        CType(Me.dgv_relat_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents qtde_clientes_atendidos As ColumnHeader
    Friend WithEvents dgv_relat_clientes As DataGridView
    Friend WithEvents Nome_atendente As DataGridViewTextBoxColumn
    Friend WithEvents Clientes_atendidos As DataGridViewTextBoxColumn
    Friend WithEvents Data_emissao As DataGridViewTextBoxColumn
    Friend WithEvents footer_date As TextBox
    Friend WithEvents lbl_logo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_nome_atendente As ComboBox
    Friend WithEvents btn_retornar_menu As Button
End Class
