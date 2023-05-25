<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuser
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cari = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.dguser = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgpelanggan = New System.Windows.Forms.DataGridView()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No"
        '
        'cari
        '
        Me.cari.AutoSize = True
        Me.cari.Location = New System.Drawing.Point(210, 199)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(24, 13)
        Me.cari.TabIndex = 4
        Me.cari.Text = "cari"
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(98, 38)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(151, 20)
        Me.tbid.TabIndex = 5
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(98, 65)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(151, 20)
        Me.tbnama.TabIndex = 6
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(98, 92)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(151, 20)
        Me.tbusername.TabIndex = 7
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(98, 118)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(151, 20)
        Me.tbpassword.TabIndex = 8
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(257, 196)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(151, 20)
        Me.txtcari.TabIndex = 9
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(66, 151)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 10
        Me.btn.Text = "ADD"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(159, 151)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 11
        Me.btsimpan.Text = "Save"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(257, 151)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 12
        Me.btedit.Text = "Edit"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(363, 151)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 13
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(454, 151)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 14
        Me.btbatal.Text = "Baal"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(550, 151)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 15
        Me.btkeluar.Text = "btkeluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'dguser
        '
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.Location = New System.Drawing.Point(56, 232)
        Me.dguser.Name = "dguser"
        Me.dguser.Size = New System.Drawing.Size(559, 120)
        Me.dguser.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nana"
        '
        'dgpelanggan
        '
        Me.dgpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpelanggan.Location = New System.Drawing.Point(56, 232)
        Me.dgpelanggan.Name = "dgpelanggan"
        Me.dgpelanggan.Size = New System.Drawing.Size(559, 120)
        Me.dgpelanggan.TabIndex = 16
        '
        'frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 396)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dguser)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmuser"
        Me.Text = "Form1"
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cari As System.Windows.Forms.Label
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents dguser As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgpelanggan As System.Windows.Forms.DataGridView

End Class
