<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelU = New System.Windows.Forms.Label()
        Me.labelP = New System.Windows.Forms.Label()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cls = New System.Windows.Forms.Button()
        Me.mxz = New System.Windows.Forms.Button()
        Me.mnz = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnrepeat = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelU
        '
        Me.labelU.AutoSize = True
        Me.labelU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelU.Location = New System.Drawing.Point(340, 199)
        Me.labelU.Name = "labelU"
        Me.labelU.Size = New System.Drawing.Size(73, 15)
        Me.labelU.TabIndex = 0
        Me.labelU.Text = "Username"
        '
        'labelP
        '
        Me.labelP.AutoSize = True
        Me.labelP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelP.Location = New System.Drawing.Point(340, 221)
        Me.labelP.Name = "labelP"
        Me.labelP.Size = New System.Drawing.Size(69, 15)
        Me.labelP.TabIndex = 1
        Me.labelP.Text = "Password"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(434, 198)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(162, 20)
        Me.tbusername.TabIndex = 2
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(434, 221)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassword.Size = New System.Drawing.Size(162, 20)
        Me.tbpassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sistem Tata Kelola Ruangan V.0.1 | by 220202636"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Login Page"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 444)
        Me.Panel1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(38, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Welcome guest!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(59, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "UNIVERSITAS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANGKAT KANTIN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(168, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 39)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cls)
        Me.Panel3.Controls.Add(Me.mxz)
        Me.Panel3.Controls.Add(Me.mnz)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(425, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(123, 39)
        Me.Panel3.TabIndex = 0
        '
        'cls
        '
        Me.cls.FlatAppearance.BorderSize = 0
        Me.cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cls.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.close15px
        Me.cls.Location = New System.Drawing.Point(84, 7)
        Me.cls.Name = "cls"
        Me.cls.Size = New System.Drawing.Size(27, 24)
        Me.cls.TabIndex = 17
        Me.cls.UseVisualStyleBackColor = True
        '
        'mxz
        '
        Me.mxz.FlatAppearance.BorderSize = 0
        Me.mxz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mxz.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.maximize15px
        Me.mxz.Location = New System.Drawing.Point(51, 7)
        Me.mxz.Name = "mxz"
        Me.mxz.Size = New System.Drawing.Size(27, 24)
        Me.mxz.TabIndex = 16
        Me.mxz.UseVisualStyleBackColor = True
        '
        'mnz
        '
        Me.mnz.FlatAppearance.BorderSize = 0
        Me.mnz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mnz.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.minimize15px
        Me.mnz.Location = New System.Drawing.Point(18, 7)
        Me.mnz.Name = "mnz"
        Me.mnz.Size = New System.Drawing.Size(27, 24)
        Me.mnz.TabIndex = 15
        Me.mnz.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.user1
        Me.PictureBox2.Location = New System.Drawing.Point(255, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'btnrepeat
        '
        Me.btnrepeat.FlatAppearance.BorderSize = 0
        Me.btnrepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepeat.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.repeat
        Me.btnrepeat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrepeat.Location = New System.Drawing.Point(483, 262)
        Me.btnrepeat.Name = "btnrepeat"
        Me.btnrepeat.Size = New System.Drawing.Size(113, 47)
        Me.btnrepeat.TabIndex = 5
        Me.btnrepeat.Text = "       Ulangi"
        Me.btnrepeat.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.FlatAppearance.BorderSize = 0
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Image = Global.Project_Sistem_Tata_Kelola_Ruangan.My.Resources.Resources.loginicoo
        Me.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsubmit.Location = New System.Drawing.Point(354, 262)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(123, 47)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "       Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 444)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnrepeat)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.labelP)
        Me.Controls.Add(Me.labelU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN | SITAKERU"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelU As System.Windows.Forms.Label
    Friend WithEvents labelP As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btnrepeat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cls As System.Windows.Forms.Button
    Friend WithEvents mxz As System.Windows.Forms.Button
    Friend WithEvents mnz As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
