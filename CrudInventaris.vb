Public Class CrudInventaris

    Private Sub CrudInventaris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbdataruang()
        '      loaddata()
        qry("SELECT * FROM `inventaris_ruang`")

        tabledgvinventaris()

    End Sub
    Sub refreshdataruang()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM inventaris_ruang"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Da.SelectCommand = Cmd
            Da.Fill(Ds, "inventaris_ruang")
            With dginventaris
                .DataSource = Ds.Tables("inventaris_ruang")
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With
            Conn.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub
    Sub qry(ByVal sql As String)
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = sql
        Da.SelectCommand = Cmd
        Ds.Tables.Clear()
        Da.Fill(Ds, "inventaris_ruang")
        dginventaris.DataSource = (Ds.Tables("inventaris_ruang"))
        Conn.Close()
    End Sub
    Sub Proc(ByVal sql As String)
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = sql
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Sub tabledgvinventaris()
        Try

            dginventaris.Columns(0).HeaderText = "ID"
            dginventaris.Columns(1).HeaderText = "Kode Ruang"
            dginventaris.Columns(2).HeaderText = "Jumlah Kursi"
            dginventaris.Columns(3).HeaderText = "AC"
            dginventaris.Columns(4).HeaderText = "Akses Internet"
            dginventaris.Columns(5).HeaderText = "Kelengkapan Lain"
            dginventaris.Columns(6).HeaderText = "Keterangan"
        Catch ex As Exception
        End Try
    End Sub

    Sub cleandata()
        cbkoderuang.ResetText()
        tbkursi.ResetText()
        cbac.ResetText()
        cbaksesinternet.ResetText()
        rtkelengkapanlain.ResetText()
        rtketerangan.ResetText()
    End Sub
    Sub loaddata()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM inventaris_ruang"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Da.SelectCommand = Cmd
            Da.Fill(Ds, "inventaris_ruang")
            With dginventaris
                .DataSource = Ds.Tables("inventaris_ruang")
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With
            Conn.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub

    Sub cbdataruang()
        Try
            cbkoderuang.Items.Clear()
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM ruang WHERE table_used = '0'"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Rd = Cmd.ExecuteReader
            Do While Rd.Read
                cbkoderuang.Items.Add(Rd.Item(1))

            Loop
            Conn.Close()

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try

    End Sub
    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click

        Try
            'validasi
            If cbkoderuang.Text = String.Empty Then MsgBox("Kode Ruang belum dipilih!") : Exit Sub
            If tbkursi.Text = String.Empty Then MsgBox("Kode Kelas belum dipilih!") : Exit Sub
            If cbac.Text = String.Empty Then MsgBox("Keterangan belum diisi!") : Exit Sub
            If cbaksesinternet.Text = String.Empty Then MsgBox("Keterangan belum diisi!") : Exit Sub
            If rtkelengkapanlain.Text = String.Empty Then MsgBox("Keterangan belum diisi!") : Exit Sub
            If rtketerangan.Text = String.Empty Then MsgBox("Keterangan belum diisi!") : Exit Sub

            '     Proc("INSERT INTO inventaris_ruang (kode_ruang, jumlah_kursi, ac, internet_lan, kelengkapan_lain, keterangan) VALUES " & _
            '      "('" & cbkoderuang.Text & "', '" & tbkursi.Text & "','" & cbac.Text & "','" & cbaksesinternet.Text & "','" & rtkelengkapanlain.Text & "','" & rtketerangan.Text & "')")
            Proc("INSERT INTO `inventaris_ruang` (`id`, `kode_ruang`, `jumlah_kursi`, `ac`, `internet_lan`, `kelengkapan_lain`, `keterangan`) VALUES (NULL, '" & cbkoderuang.Text & "', '" & tbkursi.Text & "', '" & cbac.Text & "', '" & cbaksesinternet.Text & "', '" & rtkelengkapanlain.Text & "', '" & rtketerangan.Text & "')")
            Proc("UPDATE ruang SET table_used='1' WHERE kode_ruang ='" & cbkoderuang.Text & "'")
            MsgBox("Data sukses diinput!", vbInformation, "Success")

            qry("SELECT * from inventaris_ruang")
            cbdataruang()
            cleandata()
            btnhapus.Enabled = False
            btnulangi.Enabled = True
            btnupdate.Enabled = False
            btntambah.Enabled = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally

            Conn.Dispose()
        End Try
    End Sub


    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Try
            Proc("DELETE from inventaris_ruang WHERE kode_ruang ='" & cbkoderuang.Text & "'")
            Proc("UPDATE ruang SET table_used='0' WHERE kode_ruang ='" & cbkoderuang.Text & "'")
            MsgBox("Data sukses dihapus!", vbInformation, "Success")
            qry("SELECT * from inventaris_ruang")
            tabledgvinventaris()
            cbdataruang()
            cleandata()
            btnupdate.Enabled = False
            btnulangi.Enabled = True
            btntambah.Enabled = True
            btnhapus.Enabled = False

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub
    Private Sub dginventaris_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dginventaris.CellClick
        cbkoderuang.Enabled = True
        Dim i As Integer
        i = Me.dginventaris.CurrentRow.Index
        With dginventaris.Rows.Item(i)
            dginventaris.Text = .Cells(1).Value
            dginventaris.Text = .Cells(2).Value
            dginventaris.Text = .Cells(3).Value
            dginventaris.Text = .Cells(4).Value
            dginventaris.Text = .Cells(5).Value
            dginventaris.Text = .Cells(6).Value
            cbkoderuang.Focus()
            btnhapus.Enabled = False
            btntambah.Enabled = True
            btnulangi.Enabled = True
            btnupdate.Enabled = False
        End With
    End Sub

    Private Sub dginventaris_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dginventaris.CellMouseDoubleClick

        cbkoderuang.Text = dginventaris.CurrentRow.Cells(1).Value
        tbkursi.Text = dginventaris.CurrentRow.Cells(2).Value
        cbac.Text = dginventaris.CurrentRow.Cells(3).Value
        cbaksesinternet.Text = dginventaris.CurrentRow.Cells(4).Value
        rtkelengkapanlain.Text = dginventaris.CurrentRow.Cells(5).Value
        rtketerangan.Text = dginventaris.CurrentRow.Cells(6).Value
        btnupdate.Enabled = True
        btnulangi.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = True
        '      cbkoderuang.ReadOnly = True

    End Sub

    Private Sub cbkoderuang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbkoderuang.KeyPress

        Conn.Open()
        Cmd.Connection = Conn
        getData = "SELECT * FROM inventaris_ruang WHERE kode_ruang ='" & cbkoderuang.Text & "'"
        Cmd.CommandText = getData
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then

            cbkoderuang.Text = Rd.Item("kode_ruang")
            tbkursi.Text = Rd.Item("jumlah_kursi")
            cbac.Text = Rd.Item("ac")
            cbaksesinternet.Text = Rd.Item("internet_lan")
            rtkelengkapanlain.Text = Rd.Item("kelengkapan_lain")
            rtketerangan.Text = Rd.Item("keterangan")
            btnupdate.Enabled = True
            btntambah.Enabled = False
        Else
            btntambah.Enabled = True

            Rd.Close()
            Conn.Close()
        End If
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            If cbkoderuang.Text = String.Empty Then MsgBox("Kode Ruang belum dipilih!") : Exit Sub

            Proc("UPDATE inventaris_ruang SET kode_ruang='" & cbkoderuang.Text & "',jumlah_kursi='" &
        tbkursi.Text & "',ac='" & cbac.Text & "',internet_lan='" & cbaksesinternet.Text & "',kelengkapan_lain='" & rtkelengkapanlain.Text & "',keterangan='" & rtketerangan.Text & "' WHERE kode_ruang ='" & cbkoderuang.Text & "'")
            MsgBox("Data telah diperbarui!", vbInformation, "Error")
            qry("SELECT * FROM inventaris_ruang")
            tabledgvinventaris()
            cleandata()

            btnupdate.Enabled = False
            btntambah.Enabled = True
            btnulangi.Enabled = True
            btnhapus.Enabled = False
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub
    Private Sub btnbacktohome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbacktohome.Click
        Me.Close()
    End Sub

    Private Sub btnulangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnulangi.Click
        cleandata()
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        qry("SELECT * FROM `inventaris_ruang`")
        tabledgvinventaris()
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim cari As String
        cari = tbcari.Text
        qry("SELECT * FROM inventaris_ruang WHERE kode_ruang like '%" & cari & "%'")
        tabledgvinventaris()
    End Sub

End Class