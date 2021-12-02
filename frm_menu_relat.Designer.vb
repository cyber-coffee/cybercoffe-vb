<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_relat
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
        Me.btn_retornar_menu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_relatorio = New System.Windows.Forms.ComboBox()
        Me.btn_abrir_relatorio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_retornar_menu
        '
        Me.btn_retornar_menu.BackColor = System.Drawing.Color.White
        Me.btn_retornar_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_retornar_menu.Location = New System.Drawing.Point(19, 17)
        Me.btn_retornar_menu.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_retornar_menu.Name = "btn_retornar_menu"
        Me.btn_retornar_menu.Size = New System.Drawing.Size(200, 26)
        Me.btn_retornar_menu.TabIndex = 81
        Me.btn_retornar_menu.Text = "Retornar ao menu"
        Me.btn_retornar_menu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Tipo do relatório: "
        '
        'cmb_relatorio
        '
        Me.cmb_relatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_relatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.cmb_relatorio.FormattingEnabled = True
        Me.cmb_relatorio.Items.AddRange(New Object() {"Relatório de produtos Vendidos", "Relatório de clientes atendidos", "Relatório de processos"})
        Me.cmb_relatorio.Location = New System.Drawing.Point(195, 89)
        Me.cmb_relatorio.Name = "cmb_relatorio"
        Me.cmb_relatorio.Size = New System.Drawing.Size(263, 23)
        Me.cmb_relatorio.TabIndex = 84
        '
        'btn_abrir_relatorio
        '
        Me.btn_abrir_relatorio.BackColor = System.Drawing.Color.White
        Me.btn_abrir_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_abrir_relatorio.Location = New System.Drawing.Point(327, 140)
        Me.btn_abrir_relatorio.Margin = New System.Windows.Forms.Padding(10, 8, 3, 3)
        Me.btn_abrir_relatorio.Name = "btn_abrir_relatorio"
        Me.btn_abrir_relatorio.Size = New System.Drawing.Size(131, 26)
        Me.btn_abrir_relatorio.TabIndex = 86
        Me.btn_abrir_relatorio.Text = "Abrir Relatório"
        Me.btn_abrir_relatorio.UseVisualStyleBackColor = False
        '
        'frm_menu_relat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 221)
        Me.Controls.Add(Me.btn_abrir_relatorio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_relatorio)
        Me.Controls.Add(Me.btn_retornar_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_menu_relat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_menu_relat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_retornar_menu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_relatorio As ComboBox
    Friend WithEvents btn_abrir_relatorio As Button
End Class
