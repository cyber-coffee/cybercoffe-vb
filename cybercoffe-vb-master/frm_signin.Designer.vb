<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_signin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_signin))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn2_signin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_underline = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txt_cpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_manager = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.link_encerrar = New System.Windows.Forms.LinkLabel()
        Me.ckb_atendente = New System.Windows.Forms.CheckBox()
        Me.ckb_gerente = New System.Windows.Forms.CheckBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(354, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(536, 603)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'btn2_signin
        '
        Me.btn2_signin.BackColor = System.Drawing.Color.White
        Me.btn2_signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn2_signin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn2_signin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btn2_signin.Location = New System.Drawing.Point(39, 498)
        Me.btn2_signin.Name = "btn2_signin"
        Me.btn2_signin.Size = New System.Drawing.Size(283, 33)
        Me.btn2_signin.TabIndex = 5
        Me.btn2_signin.Text = "Sign in"
        Me.btn2_signin.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(35, 319)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 275)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_password.ForeColor = System.Drawing.Color.White
        Me.txt_password.Location = New System.Drawing.Point(68, 319)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.PlaceholderText = "Password"
        Me.txt_password.Size = New System.Drawing.Size(164, 18)
        Me.txt_password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(35, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "________________________________________________________"
        '
        'lbl_underline
        '
        Me.lbl_underline.AutoSize = True
        Me.lbl_underline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lbl_underline.Location = New System.Drawing.Point(33, 287)
        Me.lbl_underline.Name = "lbl_underline"
        Me.lbl_underline.Size = New System.Drawing.Size(287, 15)
        Me.lbl_underline.TabIndex = 16
        Me.lbl_underline.Text = "________________________________________________________"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_login.ForeColor = System.Drawing.Color.White
        Me.lbl_login.Location = New System.Drawing.Point(30, 64)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(53, 21)
        Me.lbl_login.TabIndex = 15
        Me.lbl_login.Text = "Login"
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(30, 32)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 14
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(35, 372)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'txt_cpassword
        '
        Me.txt_cpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cpassword.ForeColor = System.Drawing.Color.White
        Me.txt_cpassword.Location = New System.Drawing.Point(68, 372)
        Me.txt_cpassword.Name = "txt_cpassword"
        Me.txt_cpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_cpassword.PlaceholderText = "Confirm password"
        Me.txt_cpassword.Size = New System.Drawing.Size(164, 18)
        Me.txt_cpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "________________________________________________________"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(37, 170)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'txt_manager
        '
        Me.txt_manager.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_manager.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_manager.Enabled = False
        Me.txt_manager.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_manager.ForeColor = System.Drawing.Color.White
        Me.txt_manager.Location = New System.Drawing.Point(68, 170)
        Me.txt_manager.Name = "txt_manager"
        Me.txt_manager.PlaceholderText = "Manager name"
        Me.txt_manager.ReadOnly = True
        Me.txt_manager.Size = New System.Drawing.Size(164, 18)
        Me.txt_manager.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "________________________________________________________"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(30, 100)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(287, 23)
        Me.cmb_cargo.TabIndex = 28
        Me.cmb_cargo.Text = "Select ID manager:"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(35, 221)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 31
        Me.PictureBox6.TabStop = False
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_user.ForeColor = System.Drawing.Color.White
        Me.txt_user.Location = New System.Drawing.Point(70, 221)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PlaceholderText = "Username"
        Me.txt_user.Size = New System.Drawing.Size(164, 18)
        Me.txt_user.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "________________________________________________________"
        '
        'link_encerrar
        '
        Me.link_encerrar.AutoSize = True
        Me.link_encerrar.LinkColor = System.Drawing.Color.Coral
        Me.link_encerrar.Location = New System.Drawing.Point(39, 557)
        Me.link_encerrar.Name = "link_encerrar"
        Me.link_encerrar.Size = New System.Drawing.Size(87, 15)
        Me.link_encerrar.TabIndex = 32
        Me.link_encerrar.TabStop = True
        Me.link_encerrar.Text = "Encerrar sessão"
        Me.link_encerrar.VisitedLinkColor = System.Drawing.Color.Crimson
        '
        'ckb_atendente
        '
        Me.ckb_atendente.AutoSize = True
        Me.ckb_atendente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ckb_atendente.Location = New System.Drawing.Point(30, 129)
        Me.ckb_atendente.Name = "ckb_atendente"
        Me.ckb_atendente.Size = New System.Drawing.Size(81, 19)
        Me.ckb_atendente.TabIndex = 33
        Me.ckb_atendente.Text = "Atendente"
        Me.ckb_atendente.UseVisualStyleBackColor = True
        '
        'ckb_gerente
        '
        Me.ckb_gerente.AutoSize = True
        Me.ckb_gerente.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ckb_gerente.Location = New System.Drawing.Point(177, 129)
        Me.ckb_gerente.Name = "ckb_gerente"
        Me.ckb_gerente.Size = New System.Drawing.Size(67, 19)
        Me.ckb_gerente.TabIndex = 34
        Me.ckb_gerente.Text = "Gerente"
        Me.ckb_gerente.UseVisualStyleBackColor = True
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cpf.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_cpf.Location = New System.Drawing.Point(68, 273)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(164, 18)
        Me.txt_cpf.TabIndex = 1
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(68, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CPF:"
        '
        'frm_signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(889, 598)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.ckb_gerente)
        Me.Controls.Add(Me.ckb_atendente)
        Me.Controls.Add(Me.link_encerrar)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_cargo)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txt_manager)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txt_cpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn2_signin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_underline)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_logo)
        Me.Controls.Add(Me.PictureBox3)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_signin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_signin"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn2_signin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_underline As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_logo As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txt_cpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txt_manager As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents link_encerrar As LinkLabel
    Friend WithEvents ckb_atendente As CheckBox
    Friend WithEvents ckb_gerente As CheckBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label5 As Label
End Class
