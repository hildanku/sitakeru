<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudRoom
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbacktohome = New System.Windows.Forms.Button()
        Me.tbruangid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnulangi = New System.Windows.Forms.Button()
        Me.btntambahruang = New System.Windows.Forms.Button()
        Me.btncarikelas = New System.Windows.Forms.Button()
        Me.btnhapusruang = New System.Windows.Forms.Button()
        Me.tbcarikelas = New System.Windows.Forms.TextBox()
        Me.btnupdateruang = New System.Windows.Forms.Button()
        Me.tbnamakelas = New System.Windows.Forms.TextBox()
        Me.tbnamaruang = New System.Windows.Forms.TextBox()
        Me.tbkoderuang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelpw = New System.Windows.Forms.Label()
        Me.labeluser = New System.Windows.Forms.Label()
        Me.labelnama = New System.Windows.Forms.Label()
        Me.dgruang = New System.Windows.Forms.DataGridView()
        Me.tbkodekelas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbkelasid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnulangikelas = New System.Windows.Forms.Button()
        Me.btntambahkelas = New System.Windows.Forms.Button()
        Me.btnhapuskelas = New System.Windows.Forms.Button()
        Me.btnupdatekelas = New System.Windows.Forms.Button()
        Me.dgkelas = New System.Windows.Forms.DataGridView()
        Me.btncariruang = New System.Windows.Forms.Button()
        Me.tbcariruang = New System.Windows.Forms.TextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgruang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgkelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 12)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Sistem Tata Kelola Ruangan V.0.1 | by 220202636"
        '
        'btnbacktohome
        '
        Me.btnbacktohome.Location = New System.Drawing.Point(685, 15)
        Me.btnbacktohome.Name = "btnbacktohome"
        Me.btnbacktohome.Size = New System.Drawing.Size(95, 25)
        Me.btnbacktohome.TabIndex = 62
        Me.btnbacktohome.Text = "Keluar Halaman"
        Me.btnbacktohome.UseVisualStyleBackColor = True
        '
        'tbruangid
        '
        Me.tbruangid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbruangid.Location = New System.Drawing.Point(105, 97)
        Me.tbruangid.Name = "tbruangid"
        Me.tbruangid.ReadOnly = True
        Me.tbruangid.Size = New System.Drawing.Size(131, 20)
        Me.tbruangid.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "ID"
        '
        'btnulangi
        '
        Me.btnulangi.Location = New System.Drawing.Point(242, 134)
        Me.btnulangi.Name = "btnulangi"
        Me.btnulangi.Size = New System.Drawing.Size(76, 34)
        Me.btnulangi.TabIndex = 57
        Me.btnulangi.Text = "Ulangi"
        Me.btnulangi.UseVisualStyleBackColor = True
        '
        'btntambahruang
        '
        Me.btntambahruang.Location = New System.Drawing.Point(242, 96)
        Me.btntambahruang.Name = "btntambahruang"
        Me.btntambahruang.Size = New System.Drawing.Size(76, 36)
        Me.btntambahruang.TabIndex = 56
        Me.btntambahruang.Text = "Tambah Data"
        Me.btntambahruang.UseVisualStyleBackColor = True
        '
        'btncarikelas
        '
        Me.btncarikelas.Location = New System.Drawing.Point(739, 175)
        Me.btncarikelas.Name = "btncarikelas"
        Me.btncarikelas.Size = New System.Drawing.Size(54, 20)
        Me.btncarikelas.TabIndex = 55
        Me.btncarikelas.Text = "Cari Data"
        Me.btncarikelas.UseVisualStyleBackColor = True
        '
        'btnhapusruang
        '
        Me.btnhapusruang.Location = New System.Drawing.Point(324, 134)
        Me.btnhapusruang.Name = "btnhapusruang"
        Me.btnhapusruang.Size = New System.Drawing.Size(76, 34)
        Me.btnhapusruang.TabIndex = 54
        Me.btnhapusruang.Text = "Hapus Data"
        Me.btnhapusruang.UseVisualStyleBackColor = True
        '
        'tbcarikelas
        '
        Me.tbcarikelas.Location = New System.Drawing.Point(429, 176)
        Me.tbcarikelas.Name = "tbcarikelas"
        Me.tbcarikelas.Size = New System.Drawing.Size(304, 20)
        Me.tbcarikelas.TabIndex = 52
        '
        'btnupdateruang
        '
        Me.btnupdateruang.Location = New System.Drawing.Point(324, 97)
        Me.btnupdateruang.Name = "btnupdateruang"
        Me.btnupdateruang.Size = New System.Drawing.Size(76, 36)
        Me.btnupdateruang.TabIndex = 51
        Me.btnupdateruang.Text = "Update Data"
        Me.btnupdateruang.UseVisualStyleBackColor = True
        '
        'tbnamakelas
        '
        Me.tbnamakelas.Location = New System.Drawing.Point(505, 148)
        Me.tbnamakelas.Name = "tbnamakelas"
        Me.tbnamakelas.Size = New System.Drawing.Size(124, 20)
        Me.tbnamakelas.TabIndex = 50
        '
        'tbnamaruang
        '
        Me.tbnamaruang.Location = New System.Drawing.Point(105, 148)
        Me.tbnamaruang.Name = "tbnamaruang"
        Me.tbnamaruang.Size = New System.Drawing.Size(131, 20)
        Me.tbnamaruang.TabIndex = 49
        '
        'tbkoderuang
        '
        Me.tbkoderuang.Location = New System.Drawing.Point(105, 123)
        Me.tbkoderuang.Name = "tbkoderuang"
        Me.tbkoderuang.Size = New System.Drawing.Size(131, 20)
        Me.tbkoderuang.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Kelola Data Ruang & Kelas"
        '
        'labelpw
        '
        Me.labelpw.AutoSize = True
        Me.labelpw.Location = New System.Drawing.Point(426, 126)
        Me.labelpw.Name = "labelpw"
        Me.labelpw.Size = New System.Drawing.Size(61, 13)
        Me.labelpw.TabIndex = 45
        Me.labelpw.Text = "Kode Kelas"
        '
        'labeluser
        '
        Me.labeluser.AutoSize = True
        Me.labeluser.Location = New System.Drawing.Point(24, 151)
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(70, 13)
        Me.labeluser.TabIndex = 44
        Me.labeluser.Text = "Nama Ruang"
        '
        'labelnama
        '
        Me.labelnama.AutoSize = True
        Me.labelnama.Location = New System.Drawing.Point(27, 126)
        Me.labelnama.Name = "labelnama"
        Me.labelnama.Size = New System.Drawing.Size(67, 13)
        Me.labelnama.TabIndex = 43
        Me.labelnama.Text = "Kode Ruang"
        '
        'dgruang
        '
        Me.dgruang.AllowUserToDeleteRows = False
        Me.dgruang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgruang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgruang.Location = New System.Drawing.Point(27, 204)
        Me.dgruang.Name = "dgruang"
        Me.dgruang.ReadOnly = True
        Me.dgruang.Size = New System.Drawing.Size(373, 238)
        Me.dgruang.TabIndex = 42
        '
        'tbkodekelas
        '
        Me.tbkodekelas.Location = New System.Drawing.Point(505, 123)
        Me.tbkodekelas.Name = "tbkodekelas"
        Me.tbkodekelas.Size = New System.Drawing.Size(124, 20)
        Me.tbkodekelas.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Nama Kelas"
        '
        'tbkelasid
        '
        Me.tbkelasid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkelasid.Location = New System.Drawing.Point(504, 97)
        Me.tbkelasid.Name = "tbkelasid"
        Me.tbkelasid.ReadOnly = True
        Me.tbkelasid.Size = New System.Drawing.Size(125, 20)
        Me.tbkelasid.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "ID"
        '
        'btnulangikelas
        '
        Me.btnulangikelas.Location = New System.Drawing.Point(635, 134)
        Me.btnulangikelas.Name = "btnulangikelas"
        Me.btnulangikelas.Size = New System.Drawing.Size(76, 34)
        Me.btnulangikelas.TabIndex = 78
        Me.btnulangikelas.Text = "Ulangi"
        Me.btnulangikelas.UseVisualStyleBackColor = True
        '
        'btntambahkelas
        '
        Me.btntambahkelas.Location = New System.Drawing.Point(635, 97)
        Me.btntambahkelas.Name = "btntambahkelas"
        Me.btntambahkelas.Size = New System.Drawing.Size(76, 35)
        Me.btntambahkelas.TabIndex = 77
        Me.btntambahkelas.Text = "Tambah Data"
        Me.btntambahkelas.UseVisualStyleBackColor = True
        '
        'btnhapuskelas
        '
        Me.btnhapuskelas.Location = New System.Drawing.Point(717, 134)
        Me.btnhapuskelas.Name = "btnhapuskelas"
        Me.btnhapuskelas.Size = New System.Drawing.Size(76, 34)
        Me.btnhapuskelas.TabIndex = 76
        Me.btnhapuskelas.Text = "Hapus Data"
        Me.btnhapuskelas.UseVisualStyleBackColor = True
        '
        'btnupdatekelas
        '
        Me.btnupdatekelas.Location = New System.Drawing.Point(717, 97)
        Me.btnupdatekelas.Name = "btnupdatekelas"
        Me.btnupdatekelas.Size = New System.Drawing.Size(76, 35)
        Me.btnupdatekelas.TabIndex = 75
        Me.btnupdatekelas.Text = "Update Data"
        Me.btnupdatekelas.UseVisualStyleBackColor = True
        '
        'dgkelas
        '
        Me.dgkelas.AllowUserToDeleteRows = False
        Me.dgkelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgkelas.Location = New System.Drawing.Point(420, 204)
        Me.dgkelas.Name = "dgkelas"
        Me.dgkelas.ReadOnly = True
        Me.dgkelas.Size = New System.Drawing.Size(373, 238)
        Me.dgkelas.TabIndex = 79
        '
        'btncariruang
        '
        Me.btncariruang.Location = New System.Drawing.Point(346, 178)
        Me.btncariruang.Name = "btncariruang"
        Me.btncariruang.Size = New System.Drawing.Size(54, 20)
        Me.btncariruang.TabIndex = 81
        Me.btncariruang.Text = "Cari Data"
        Me.btncariruang.UseVisualStyleBackColor = True
        '
        'tbcariruang
        '
        Me.tbcariruang.Location = New System.Drawing.Point(27, 178)
        Me.tbcariruang.Name = "tbcariruang"
        Me.tbcariruang.Size = New System.Drawing.Size(313, 20)
        Me.tbcariruang.TabIndex = 80
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(584, 16)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(95, 24)
        Me.btnrefresh.TabIndex = 86
        Me.btnrefresh.Text = "Refresh Data"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(770, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Data count"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(701, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Jumlah Data :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(366, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Data count"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 456)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Jumlah Data :"
        '
        'CrudRoom
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(831, 504)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncariruang)
        Me.Controls.Add(Me.tbcariruang)
        Me.Controls.Add(Me.dgkelas)
        Me.Controls.Add(Me.btnulangikelas)
        Me.Controls.Add(Me.btntambahkelas)
        Me.Controls.Add(Me.btnhapuskelas)
        Me.Controls.Add(Me.btnupdatekelas)
        Me.Controls.Add(Me.tbkelasid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbkodekelas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbacktohome)
        Me.Controls.Add(Me.tbruangid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnulangi)
        Me.Controls.Add(Me.btntambahruang)
        Me.Controls.Add(Me.btncarikelas)
        Me.Controls.Add(Me.btnhapusruang)
        Me.Controls.Add(Me.tbcarikelas)
        Me.Controls.Add(Me.btnupdateruang)
        Me.Controls.Add(Me.tbnamakelas)
        Me.Controls.Add(Me.tbnamaruang)
        Me.Controls.Add(Me.tbkoderuang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelpw)
        Me.Controls.Add(Me.labeluser)
        Me.Controls.Add(Me.labelnama)
        Me.Controls.Add(Me.dgruang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrudRoom"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrudRoom"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgruang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgkelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbacktohome As System.Windows.Forms.Button
    Friend WithEvents tbruangid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnulangi As System.Windows.Forms.Button
    Friend WithEvents btntambahruang As System.Windows.Forms.Button
    Friend WithEvents btncarikelas As System.Windows.Forms.Button
    Friend WithEvents btnhapusruang As System.Windows.Forms.Button
    Friend WithEvents tbcarikelas As System.Windows.Forms.TextBox
    Friend WithEvents btnupdateruang As System.Windows.Forms.Button
    Friend WithEvents tbnamakelas As System.Windows.Forms.TextBox
    Friend WithEvents tbnamaruang As System.Windows.Forms.TextBox
    Friend WithEvents tbkoderuang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labelpw As System.Windows.Forms.Label
    Friend WithEvents labeluser As System.Windows.Forms.Label
    Friend WithEvents labelnama As System.Windows.Forms.Label
    Friend WithEvents dgruang As System.Windows.Forms.DataGridView
    Friend WithEvents tbkodekelas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbkelasid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnulangikelas As System.Windows.Forms.Button
    Friend WithEvents btntambahkelas As System.Windows.Forms.Button
    Friend WithEvents btnhapuskelas As System.Windows.Forms.Button
    Friend WithEvents btnupdatekelas As System.Windows.Forms.Button
    Friend WithEvents dgkelas As System.Windows.Forms.DataGridView
    Friend WithEvents btncariruang As System.Windows.Forms.Button
    Friend WithEvents tbcariruang As System.Windows.Forms.TextBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
