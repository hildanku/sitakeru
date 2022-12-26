<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudInventaris
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnbacktohome = New System.Windows.Forms.Button()
        Me.tbkursi = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.labeluser = New System.Windows.Forms.Label()
        Me.labelpw = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelnama = New System.Windows.Forms.Label()
        Me.btnulangi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbkoderuang = New System.Windows.Forms.ComboBox()
        Me.cbac = New System.Windows.Forms.ComboBox()
        Me.cbaksesinternet = New System.Windows.Forms.ComboBox()
        Me.rtkelengkapanlain = New System.Windows.Forms.RichTextBox()
        Me.rtketerangan = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dginventaris = New System.Windows.Forms.DataGridView()
        CType(Me.dginventaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sistem Tata Kelola Ruangan V.0.1 | by 220202636"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Kelola Inventaris Kelas"
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(584, 16)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(95, 24)
        Me.btnrefresh.TabIndex = 88
        Me.btnrefresh.Text = "Refresh Data"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnbacktohome
        '
        Me.btnbacktohome.Location = New System.Drawing.Point(685, 15)
        Me.btnbacktohome.Name = "btnbacktohome"
        Me.btnbacktohome.Size = New System.Drawing.Size(95, 25)
        Me.btnbacktohome.TabIndex = 87
        Me.btnbacktohome.Text = "Keluar Halaman"
        Me.btnbacktohome.UseVisualStyleBackColor = True
        '
        'tbkursi
        '
        Me.tbkursi.Location = New System.Drawing.Point(194, 106)
        Me.tbkursi.Name = "tbkursi"
        Me.tbkursi.Size = New System.Drawing.Size(290, 20)
        Me.tbkursi.TabIndex = 94
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(503, 150)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(113, 50)
        Me.btntambah.TabIndex = 101
        Me.btntambah.Text = "Tambah Data"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(625, 210)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(113, 50)
        Me.btnhapus.TabIndex = 99
        Me.btnhapus.Text = "Hapus Data"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(503, 106)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(235, 38)
        Me.btncari.TabIndex = 100
        Me.btncari.Text = "Cari Data"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(625, 150)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(113, 50)
        Me.btnupdate.TabIndex = 96
        Me.btnupdate.Text = "Update Data"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(503, 80)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(235, 20)
        Me.tbcari.TabIndex = 97
        '
        'labeluser
        '
        Me.labeluser.AutoSize = True
        Me.labeluser.Location = New System.Drawing.Point(77, 109)
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(66, 13)
        Me.labeluser.TabIndex = 90
        Me.labeluser.Text = "Jumlah Kursi"
        '
        'labelpw
        '
        Me.labelpw.AutoSize = True
        Me.labelpw.Location = New System.Drawing.Point(78, 135)
        Me.labelpw.Name = "labelpw"
        Me.labelpw.Size = New System.Drawing.Size(21, 13)
        Me.labelpw.TabIndex = 91
        Me.labelpw.Text = "AC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Keterangan"
        '
        'labelnama
        '
        Me.labelnama.AutoSize = True
        Me.labelnama.Location = New System.Drawing.Point(78, 83)
        Me.labelnama.Name = "labelnama"
        Me.labelnama.Size = New System.Drawing.Size(67, 13)
        Me.labelnama.TabIndex = 89
        Me.labelnama.Text = "Kode Ruang"
        '
        'btnulangi
        '
        Me.btnulangi.Location = New System.Drawing.Point(503, 211)
        Me.btnulangi.Name = "btnulangi"
        Me.btnulangi.Size = New System.Drawing.Size(113, 49)
        Me.btnulangi.TabIndex = 102
        Me.btnulangi.Text = "Ulangi"
        Me.btnulangi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Akses Internet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Kelengkapan Lain"
        '
        'cbkoderuang
        '
        Me.cbkoderuang.FormattingEnabled = True
        Me.cbkoderuang.Location = New System.Drawing.Point(194, 80)
        Me.cbkoderuang.Name = "cbkoderuang"
        Me.cbkoderuang.Size = New System.Drawing.Size(290, 21)
        Me.cbkoderuang.TabIndex = 111
        '
        'cbac
        '
        Me.cbac.FormattingEnabled = True
        Me.cbac.Items.AddRange(New Object() {"TERSEDIA", "TIDAK TERSEDIA", "RUSAK"})
        Me.cbac.Location = New System.Drawing.Point(194, 132)
        Me.cbac.Name = "cbac"
        Me.cbac.Size = New System.Drawing.Size(290, 21)
        Me.cbac.TabIndex = 112
        '
        'cbaksesinternet
        '
        Me.cbaksesinternet.FormattingEnabled = True
        Me.cbaksesinternet.Items.AddRange(New Object() {"TERSEDIA", "TIDAK TERSEDIA"})
        Me.cbaksesinternet.Location = New System.Drawing.Point(194, 160)
        Me.cbaksesinternet.Name = "cbaksesinternet"
        Me.cbaksesinternet.Size = New System.Drawing.Size(290, 21)
        Me.cbaksesinternet.TabIndex = 113
        '
        'rtkelengkapanlain
        '
        Me.rtkelengkapanlain.Location = New System.Drawing.Point(194, 187)
        Me.rtkelengkapanlain.Name = "rtkelengkapanlain"
        Me.rtkelengkapanlain.Size = New System.Drawing.Size(290, 35)
        Me.rtkelengkapanlain.TabIndex = 114
        Me.rtkelengkapanlain.Text = ""
        '
        'rtketerangan
        '
        Me.rtketerangan.Location = New System.Drawing.Point(194, 228)
        Me.rtketerangan.Name = "rtketerangan"
        Me.rtketerangan.Size = New System.Drawing.Size(290, 32)
        Me.rtketerangan.TabIndex = 115
        Me.rtketerangan.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 494)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 12)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Sistem Tata Kelola Ruangan V.0.1 | by 220202636"
        '
        'dginventaris
        '
        Me.dginventaris.AllowUserToAddRows = False
        Me.dginventaris.AllowUserToDeleteRows = False
        Me.dginventaris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dginventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dginventaris.Location = New System.Drawing.Point(80, 272)
        Me.dginventaris.Name = "dginventaris"
        Me.dginventaris.ReadOnly = True
        Me.dginventaris.Size = New System.Drawing.Size(658, 190)
        Me.dginventaris.TabIndex = 117
        '
        'CrudInventaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(831, 532)
        Me.Controls.Add(Me.dginventaris)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rtketerangan)
        Me.Controls.Add(Me.rtkelengkapanlain)
        Me.Controls.Add(Me.cbaksesinternet)
        Me.Controls.Add(Me.cbac)
        Me.Controls.Add(Me.cbkoderuang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbkursi)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.tbcari)
        Me.Controls.Add(Me.labeluser)
        Me.Controls.Add(Me.labelpw)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelnama)
        Me.Controls.Add(Me.btnulangi)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnbacktohome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrudInventaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrudInventaris"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dginventaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btnbacktohome As System.Windows.Forms.Button
    Friend WithEvents tbkursi As System.Windows.Forms.TextBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents labeluser As System.Windows.Forms.Label
    Friend WithEvents labelpw As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelnama As System.Windows.Forms.Label
    Friend WithEvents btnulangi As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbkoderuang As System.Windows.Forms.ComboBox
    Friend WithEvents cbac As System.Windows.Forms.ComboBox
    Friend WithEvents cbaksesinternet As System.Windows.Forms.ComboBox
    Friend WithEvents rtkelengkapanlain As System.Windows.Forms.RichTextBox
    Friend WithEvents rtketerangan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dginventaris As System.Windows.Forms.DataGridView
End Class
