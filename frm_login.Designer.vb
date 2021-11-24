<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_underline = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_signin = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ckb_senha = New System.Windows.Forms.CheckBox()
        Me.txt_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_user.ForeColor = System.Drawing.Color.White
        Me.txt_user.Location = New System.Drawing.Point(61, 141)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PlaceholderText = "Username"
        Me.txt_user.Size = New System.Drawing.Size(164, 18)
        Me.txt_user.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_password.ForeColor = System.Drawing.Color.White
        Me.txt_password.Location = New System.Drawing.Point(59, 206)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.PlaceholderText = "Password"
        Me.txt_password.Size = New System.Drawing.Size(164, 18)
        Me.txt_password.TabIndex = 1
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lbl_logo.Location = New System.Drawing.Point(22, 38)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(104, 21)
        Me.lbl_logo.TabIndex = 2
        Me.lbl_logo.Text = "CyberCoffee"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_login.ForeColor = System.Drawing.Color.White
        Me.lbl_login.Location = New System.Drawing.Point(24, 93)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(53, 21)
        Me.lbl_login.TabIndex = 3
        Me.lbl_login.Text = "Login"
        '
        'lbl_underline
        '
        Me.lbl_underline.AutoSize = True
        Me.lbl_underline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lbl_underline.Location = New System.Drawing.Point(24, 153)
        Me.lbl_underline.Name = "lbl_underline"
        Me.lbl_underline.Size = New System.Drawing.Size(287, 15)
        Me.lbl_underline.TabIndex = 4
        Me.lbl_underline.Text = "________________________________________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "________________________________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(28, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Log in"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_signin
        '
        Me.btn_signin.BackColor = System.Drawing.Color.White
        Me.btn_signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_signin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_signin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btn_signin.Location = New System.Drawing.Point(30, 371)
        Me.btn_signin.Name = "btn_signin"
        Me.btn_signin.Size = New System.Drawing.Size(283, 33)
        Me.btn_signin.TabIndex = 2
        Me.btn_signin.Text = "Manager environment"
        Me.btn_signin.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(355, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(447, 453)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'ckb_senha
        '
        Me.ckb_senha.AutoSize = True
        Me.ckb_senha.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ckb_senha.Location = New System.Drawing.Point(238, 205)
        Me.ckb_senha.Name = "ckb_senha"
        Me.ckb_senha.Size = New System.Drawing.Size(75, 19)
        Me.ckb_senha.TabIndex = 11
        Me.ckb_senha.Text = "Visualizar"
        Me.ckb_senha.UseVisualStyleBackColor = True
        '
        'txt_exit
        '
        Me.txt_exit.BackColor = System.Drawing.Color.White
        Me.txt_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_exit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txt_exit.Location = New System.Drawing.Point(30, 332)
        Me.txt_exit.Name = "txt_exit"
        Me.txt_exit.Size = New System.Drawing.Size(283, 33)
        Me.txt_exit.TabIndex = 12
        Me.txt_exit.Text = "Exit system"
        Me.txt_exit.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_exit)
        Me.Controls.Add(Me.ckb_senha)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_signin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_underline)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_logo As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_underline As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_signin As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ckb_senha As CheckBox
    Friend WithEvents txt_exit As Button
End Class
