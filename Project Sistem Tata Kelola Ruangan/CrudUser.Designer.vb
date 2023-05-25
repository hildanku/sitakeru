<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudUser
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbacktohome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labeluser = New System.Windows.Forms.Label()
        Me.labelnama = New System.Windows.Forms.Label()
        Me.labelpw = New System.Windows.Forms.Label()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.optO = New System.Windows.Forms.RadioButton()
        Me.optM = New System.Windows.Forms.RadioButton()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnulangi = New System.Windows.Forms.Button()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dguser = New System.Windows.Forms.DataGridView()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Kelola Data User"
        '
        'btnbacktohome
        '
        Me.btnbacktohome.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnbacktohome.Location = New System.Drawing.Point(678, 15)
        Me.btnbacktohome.Name = "btnbacktohome"
        Me.btnbacktohome.Size = New System.Drawing.Size(95, 25)
        Me.btnbacktohome.TabIndex = 40
        Me.btnbacktohome.Text = "Keluar Halaman"
        Me.btnbacktohome.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 12)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Sistem Tata Kelola Ruangan V.0.1 | by 220202636"
        '
        'labeluser
        '
        Me.labeluser.AutoSize = True
        Me.labeluser.Location = New System.Drawing.Point(134, 156)
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(55, 13)
        Me.labeluser.TabIndex = 16
        Me.labeluser.Text = "Username"
        '
        'labelnama
        '
        Me.labelnama.AutoSize = True
        Me.labelnama.Location = New System.Drawing.Point(134, 134)
        Me.labelnama.Name = "labelnama"
        Me.labelnama.Size = New System.Drawing.Size(35, 13)
        Me.labelnama.TabIndex = 15
        Me.labelnama.Text = "Nama"
        '
        'labelpw
        '
        Me.labelpw.AutoSize = True
        Me.labelpw.Location = New System.Drawing.Point(134, 178)
        Me.labelpw.Name = "labelpw"
        Me.labelpw.Size = New System.Drawing.Size(53, 13)
        Me.labelpw.TabIndex = 17
        Me.labelpw.Text = "Password"
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(210, 175)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(253, 20)
        Me.tbpassword.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Role"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(210, 153)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(253, 20)
        Me.tbusername.TabIndex = 21
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(210, 131)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(253, 20)
        Me.tbnama.TabIndex = 20
        '
        'optO
        '
        Me.optO.AutoSize = True
        Me.optO.Location = New System.Drawing.Point(242, 198)
        Me.optO.Name = "optO"
        Me.optO.Size = New System.Drawing.Size(66, 17)
        Me.optO.TabIndex = 36
        Me.optO.TabStop = True
        Me.optO.Text = "Operator"
        Me.optO.UseVisualStyleBackColor = True
        '
        'optM
        '
        Me.optM.AutoSize = True
        Me.optM.Location = New System.Drawing.Point(314, 198)
        Me.optM.Name = "optM"
        Me.optM.Size = New System.Drawing.Size(78, 17)
        Me.optM.TabIndex = 37
        Me.optM.TabStop = True
        Me.optM.Text = "Mahasiswa"
        Me.optM.UseVisualStyleBackColor = True
        '
        'tbid
        '
        Me.tbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbid.Location = New System.Drawing.Point(210, 109)
        Me.tbid.Name = "tbid"
        Me.tbid.ReadOnly = True
        Me.tbid.Size = New System.Drawing.Size(253, 20)
        Me.tbid.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "ID"
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(570, 109)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 50)
        Me.btnupdate.TabIndex = 26
        Me.btnupdate.Text = "Update Data"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(469, 220)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(196, 20)
        Me.btncari.TabIndex = 33
        Me.btncari.Text = "Cari Data"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnulangi
        '
        Me.btnulangi.Location = New System.Drawing.Point(469, 164)
        Me.btnulangi.Name = "btnulangi"
        Me.btnulangi.Size = New System.Drawing.Size(95, 49)
        Me.btnulangi.TabIndex = 35
        Me.btnulangi.Text = "Ulangi"
        Me.btnulangi.UseVisualStyleBackColor = True
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(210, 220)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(253, 20)
        Me.tbcari.TabIndex = 27
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(570, 164)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(95, 50)
        Me.btnhapus.TabIndex = 32
        Me.btnhapus.Text = "Hapus Data"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Cari"
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(469, 108)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(95, 50)
        Me.btntambah.TabIndex = 34
        Me.btntambah.Text = "Tambah Data"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dguser
        '
        Me.dguser.AllowUserToDeleteRows = False
        Me.dguser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dguser.Location = New System.Drawing.Point(130, 246)
        Me.dguser.Name = "dguser"
        Me.dguser.ReadOnly = True
        Me.dguser.Size = New System.Drawing.Size(535, 164)
        Me.dguser.TabIndex = 12
        '
        'CrudUser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 522)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.dguser)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnbacktohome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.optO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.optM)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.tbcari)
        Me.Controls.Add(Me.labeluser)
        Me.Controls.Add(Me.labelpw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.labelnama)
        Me.Controls.Add(Me.btnulangi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrudUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnbacktohome As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labeluser As System.Windows.Forms.Label
    Friend WithEvents labelnama As System.Windows.Forms.Label
    Friend WithEvents labelpw As System.Windows.Forms.Label
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents optO As System.Windows.Forms.RadioButton
    Friend WithEvents optM As System.Windows.Forms.RadioButton
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnulangi As System.Windows.Forms.Button
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dguser As System.Windows.Forms.DataGridView
End Class
