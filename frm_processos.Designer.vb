<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_processos
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
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.cmb_funcionarios = New System.Windows.Forms.ComboBox()
        Me.lbl_func = New System.Windows.Forms.Label()
        Me.cpf_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_do_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(12, 19)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 41
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(318, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "NÃO SEI AINDA"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.cybercoffee.My.Resources.Resources.close
        Me.Button1.Location = New System.Drawing.Point(780, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 28)
        Me.Button1.TabIndex = 56
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_clientes
        '
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cpf_cliente, Me.nome_cliente, Me.id_do_pedido})
        Me.dgv_clientes.Location = New System.Drawing.Point(2, 143)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowTemplate.Height = 25
        Me.dgv_clientes.Size = New System.Drawing.Size(800, 423)
        Me.dgv_clientes.TabIndex = 57
        '
        'cmb_funcionarios
        '
        Me.cmb_funcionarios.FormattingEnabled = True
        Me.cmb_funcionarios.Location = New System.Drawing.Point(2, 99)
        Me.cmb_funcionarios.Name = "cmb_funcionarios"
        Me.cmb_funcionarios.Size = New System.Drawing.Size(218, 23)
        Me.cmb_funcionarios.TabIndex = 58
        '
        'lbl_func
        '
        Me.lbl_func.AutoSize = True
        Me.lbl_func.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_func.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_func.Location = New System.Drawing.Point(2, 79)
        Me.lbl_func.Name = "lbl_func"
        Me.lbl_func.Size = New System.Drawing.Size(78, 17)
        Me.lbl_func.TabIndex = 59
        Me.lbl_func.Text = "Funcionário:"
        '
        'cpf_cliente
        '
        Me.cpf_cliente.HeaderText = "CPF"
        Me.cpf_cliente.Name = "cpf_cliente"
        '
        'nome_cliente
        '
        Me.nome_cliente.HeaderText = "Nome"
        Me.nome_cliente.Name = "nome_cliente"
        '
        'id_do_pedido
        '
        Me.id_do_pedido.HeaderText = "ID do pedido"
        Me.id_do_pedido.Name = "id_do_pedido"
        '
        'frm_processos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 578)
        Me.Controls.Add(Me.lbl_func)
        Me.Controls.Add(Me.cmb_funcionarios)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_processos"
        Me.Text = "frm_processos"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_logo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents cmb_funcionarios As ComboBox
    Friend WithEvents lbl_func As Label
    Friend WithEvents cpf_cliente As DataGridViewTextBoxColumn
    Friend WithEvents nome_cliente As DataGridViewTextBoxColumn
    Friend WithEvents id_do_pedido As DataGridViewTextBoxColumn
End Class
