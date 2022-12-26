<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudKetersediaan
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnbacktohome = New System.Windows.Forms.Button()
        Me.tbketid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnulangi = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.tbketerangan = New System.Windows.Forms.TextBox()
        Me.labelpw = New System.Windows.Forms.Label()
        Me.labeluser = New System.Windows.Forms.Label()
        Me.labelnama = New System.Windows.Forms.Label()
        Me.dgketersediaan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbkoderuang = New System.Windows.Forms.ComboBox()
        Me.cbkodekelas = New System.Windows.Forms.ComboBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        CType(Me.dgketersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Kelola Ketersediaan Ruang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(569, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Jumlah Data :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(638, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Data count"
        '
        'btnbacktohome
        '
        Me.btnbacktohome.Location = New System.Drawing.Point(685, 15)
        Me.btnbacktohome.Name = "btnbacktohome"
        Me.btnbacktohome.Size = New System.Drawing.Size(95, 22)
        Me.btnbacktohome.TabIndex = 68
        Me.btnbacktohome.Text = "Keluar Halaman"
        Me.btnbacktohome.UseVisualStyleBackColor = True
        '
        'tbketid
        '
        Me.tbketid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbketid.Location = New System.Drawing.Point(108, 102)
        Me.tbketid.Name = "tbketid"
        Me.tbketid.ReadOnly = True
        Me.tbketid.Size = New System.Drawing.Size(426, 20)
        Me.tbketid.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "ID"
        '
        'btnulangi
        '
        Me.btnulangi.Location = New System.Drawing.Point(551, 159)
        Me.btnulangi.Name = "btnulangi"
        Me.btnulangi.Size = New System.Drawing.Size(108, 51)
        Me.btnulangi.TabIndex = 63
        Me.btnulangi.Text = "Ulangi"
        Me.btnulangi.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(551, 216)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(223, 22)
        Me.btncari.TabIndex = 61
        Me.btncari.Text = "Cari Data"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(667, 159)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(107, 50)
        Me.btnhapus.TabIndex = 60
        Me.btnhapus.Text = "Hapus Data"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Cari"
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(108, 218)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(426, 20)
        Me.tbcari.TabIndex = 58
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(667, 102)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(108, 52)
        Me.btnupdate.TabIndex = 57
        Me.btnupdate.Text = "Update Data"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'tbketerangan
        '
        Me.tbketerangan.Location = New System.Drawing.Point(108, 182)
        Me.tbketerangan.Name = "tbketerangan"
        Me.tbketerangan.Size = New System.Drawing.Size(426, 20)
        Me.tbketerangan.TabIndex = 55
        '
        'labelpw
        '
        Me.labelpw.AutoSize = True
        Me.labelpw.Location = New System.Drawing.Point(18, 185)
        Me.labelpw.Name = "labelpw"
        Me.labelpw.Size = New System.Drawing.Size(62, 13)
        Me.labelpw.TabIndex = 52
        Me.labelpw.Text = "Keterangan"
        '
        'labeluser
        '
        Me.labeluser.AutoSize = True
        Me.labeluser.Location = New System.Drawing.Point(18, 158)
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(84, 13)
        Me.labeluser.TabIndex = 51
        Me.labeluser.Text = "Digunakan Oleh"
        '
        'labelnama
        '
        Me.labelnama.AutoSize = True
        Me.labelnama.Location = New System.Drawing.Point(20, 131)
        Me.labelnama.Name = "labelnama"
        Me.labelnama.Size = New System.Drawing.Size(67, 13)
        Me.labelnama.TabIndex = 50
        Me.labelnama.Text = "Kode Ruang"
        '
        'dgketersediaan
        '
        Me.dgketersediaan.AllowUserToAddRows = False
        Me.dgketersediaan.AllowUserToDeleteRows = False
        Me.dgketersediaan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgketersediaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgketersediaan.Location = New System.Drawing.Point(13, 253)
        Me.dgketersediaan.Name = "dgketersediaan"
        Me.dgketersediaan.ReadOnly = True
        Me.dgketersediaan.Size = New System.Drawing.Size(761, 150)
        Me.dgketersediaan.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 12)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Sistem Tata Kelola Ruangan V.0.1 | by 220202636"
        '
        'cbkoderuang
        '
        Me.cbkoderuang.FormattingEnabled = True
        Me.cbkoderuang.Location = New System.Drawing.Point(108, 128)
        Me.cbkoderuang.Name = "cbkoderuang"
        Me.cbkoderuang.Size = New System.Drawing.Size(426, 21)
        Me.cbkoderuang.TabIndex = 72
        '
        'cbkodekelas
        '
        Me.cbkodekelas.FormattingEnabled = True
        Me.cbkodekelas.Location = New System.Drawing.Point(108, 155)
        Me.cbkodekelas.Name = "cbkodekelas"
        Me.cbkodekelas.Size = New System.Drawing.Size(426, 21)
        Me.cbkodekelas.TabIndex = 73
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(584, 16)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(95, 22)
        Me.btnrefresh.TabIndex = 74
        Me.btnrefresh.Text = "Refresh Data"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(551, 100)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(110, 52)
        Me.btntambah.TabIndex = 62
        Me.btntambah.Text = "Tambah Data"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'CrudKetersediaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(847, 517)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.cbkodekelas)
        Me.Controls.Add(Me.cbkoderuang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnbacktohome)
        Me.Controls.Add(Me.tbketid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnulangi)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbcari)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.tbketerangan)
        Me.Controls.Add(Me.labelpw)
        Me.Controls.Add(Me.labeluser)
        Me.Controls.Add(Me.labelnama)
        Me.Controls.Add(Me.dgketersediaan)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrudKetersediaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrudKetersediaan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgketersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnbacktohome As System.Windows.Forms.Button
    Friend WithEvents tbketid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnulangi As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents tbketerangan As System.Windows.Forms.TextBox
    Friend WithEvents labelpw As System.Windows.Forms.Label
    Friend WithEvents labeluser As System.Windows.Forms.Label
    Friend WithEvents labelnama As System.Windows.Forms.Label
    Friend WithEvents dgketersediaan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbkoderuang As System.Windows.Forms.ComboBox
    Friend WithEvents cbkodekelas As System.Windows.Forms.ComboBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class
