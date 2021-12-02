<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relat_processos
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.footer_date = New System.Windows.Forms.TextBox()
        Me.btn_retornar_menu = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.dgv_relat_processos = New System.Windows.Forms.DataGridView()
        Me.Data_criacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao_processo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_gerente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_atendente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_data = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_relat_processos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'footer_date
        '
        Me.footer_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.footer_date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.footer_date.Enabled = False
        Me.footer_date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.footer_date.ForeColor = System.Drawing.Color.White
        Me.footer_date.Location = New System.Drawing.Point(717, 471)
        Me.footer_date.Name = "footer_date"
        Me.footer_date.PlaceholderText = "00/00/0000"
        Me.footer_date.Size = New System.Drawing.Size(71, 18)
        Me.footer_date.TabIndex = 89
        '
        'btn_retornar_menu
        '
        Me.btn_retornar_menu.BackColor = System.Drawing.Color.White
        Me.btn_retornar_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_retornar_menu.Location = New System.Drawing.Point(12, 23)
        Me.btn_retornar_menu.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_retornar_menu.Name = "btn_retornar_menu"
        Me.btn_retornar_menu.Size = New System.Drawing.Size(200, 26)
        Me.btn_retornar_menu.TabIndex = 88
        Me.btn_retornar_menu.Text = "Retornar ao menu"
        Me.btn_retornar_menu.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(501, 32)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Relatório: Processos registrados pelo sistema"
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(684, 28)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 85
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'dgv_relat_processos
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.dgv_relat_processos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_relat_processos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_relat_processos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgv_relat_processos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_relat_processos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_relat_processos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_relat_processos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data_criacao, Me.Descricao_processo, Me.Nome_gerente, Me.Nome_atendente})
        Me.dgv_relat_processos.GridColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgv_relat_processos.Location = New System.Drawing.Point(12, 183)
        Me.dgv_relat_processos.Name = "dgv_relat_processos"
        Me.dgv_relat_processos.RowTemplate.Height = 25
        Me.dgv_relat_processos.Size = New System.Drawing.Size(776, 282)
        Me.dgv_relat_processos.TabIndex = 84
        '
        'Data_criacao
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.Data_criacao.DefaultCellStyle = DataGridViewCellStyle9
        Me.Data_criacao.HeaderText = "Data"
        Me.Data_criacao.Name = "Data_criacao"
        '
        'Descricao_processo
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        Me.Descricao_processo.DefaultCellStyle = DataGridViewCellStyle10
        Me.Descricao_processo.HeaderText = "Descrição"
        Me.Descricao_processo.Name = "Descricao_processo"
        '
        'Nome_gerente
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        Me.Nome_gerente.DefaultCellStyle = DataGridViewCellStyle11
        Me.Nome_gerente.HeaderText = "Gerente"
        Me.Nome_gerente.Name = "Nome_gerente"
        '
        'Nome_atendente
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        Me.Nome_atendente.DefaultCellStyle = DataGridViewCellStyle12
        Me.Nome_atendente.HeaderText = "Atendente"
        Me.Nome_atendente.Name = "Nome_atendente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Data:"
        '
        'cmb_data
        '
        Me.cmb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_data.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_data.FormattingEnabled = True
        Me.cmb_data.Location = New System.Drawing.Point(56, 131)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(197, 23)
        Me.cmb_data.TabIndex = 92
        '
        'relat_processos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 501)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_data)
        Me.Controls.Add(Me.footer_date)
        Me.Controls.Add(Me.btn_retornar_menu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_logo)
        Me.Controls.Add(Me.dgv_relat_processos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "relat_processos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "relat_processos"
        CType(Me.dgv_relat_processos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents footer_date As TextBox
    Friend WithEvents btn_retornar_menu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_logo As Label
    Friend WithEvents dgv_relat_processos As DataGridView
    Friend WithEvents Data_criacao As DataGridViewTextBoxColumn
    Friend WithEvents Descricao_processo As DataGridViewTextBoxColumn
    Friend WithEvents Nome_gerente As DataGridViewTextBoxColumn
    Friend WithEvents Nome_atendente As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_data As ComboBox
End Class
