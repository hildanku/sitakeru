Public Class CrudKetersediaan
    Sub inactivebutton()
        tbketid.Enabled = False
        cbkoderuang.Enabled = False
        cbkodekelas.Enabled = False
        tbketerangan.Enabled = False
        tbketid.BackColor = Color.Gray
        cbkoderuang.BackColor = Color.Gray
        cbkodekelas.BackColor = Color.Gray
        tbketerangan.BackColor = Color.Gray
    End Sub
    Sub activebutton()
        tbketid.Enabled = False
        tbketid.BackColor = Color.White
        cbkoderuang.BackColor = Color.White
        cbkodekelas.BackColor = Color.White
        tbketerangan.BackColor = Color.White
    End Sub
 
    Sub databarang()
        Dim jmldata
        jmldata = dgketersediaan.RowCount
        Label6.Text = jmldata
    End Sub
    Sub tabledgvketersediaan()
        Try
            dgketersediaan.Columns(0).Width = 70
            dgketersediaan.Columns(1).Width = 150
            dgketersediaan.Columns(2).Width = 150
            dgketersediaan.Columns(3).Width = 200
            dgketersediaan.Columns(4).Width = 150
            dgketersediaan.Columns(0).HeaderText = "ID"
            dgketersediaan.Columns(1).HeaderText = "Kode Ruang"
            dgketersediaan.Columns(2).HeaderText = "Digunakan Oleh"
            dgketersediaan.Columns(3).HeaderText = "Keterangan"
            dgketersediaan.Columns(4).HeaderText = "Status"
        Catch ex As Exception
        End Try
    End Sub
    Sub cleandata()
        cbkoderuang.ResetText()
        cbkodekelas.ResetText()
        tbketerangan.ResetText()
    End Sub
    Sub loaddata()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM ketersediaan_ruang"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Da.SelectCommand = Cmd
            Da.Fill(Ds, "ketersediaan_ruang")
            With dgketersediaan
                .DataSource = Ds.Tables("ketersediaan_ruang")
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
            getData = "SELECT * FROM ruang WHERE status = 0"
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
    Sub cbdatakelas()
        Try
            cbkodekelas.Items.Clear()
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM kelas WHERE status = 0"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Rd = Cmd.ExecuteReader
            Do While Rd.Read
                cbkodekelas.Items.Add(Rd.Item(1))

            Loop
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
        Da.Fill(Ds, "ketersediaan_ruang")
        dgketersediaan.DataSource = (Ds.Tables("ketersediaan_ruang"))
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

    Private Sub CrudKetersediaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbdataruang()
        cbdatakelas()
        databarang()
        qry("SELECT * FROM `ketersediaan_ruang`")

        tabledgvketersediaan()
        btntambah.Enabled = True
        btnulangi.Enabled = True
        btnhapus.Enabled = False
        btnupdate.Enabled = False
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click

        Try
            'validasi
            If cbkoderuang.Text = String.Empty Then MsgBox("Kode Ruang belum dipilih!") : Exit Sub
            If cbkodekelas.Text = String.Empty Then MsgBox("Kode Kelas belum dipilih!") : Exit Sub
            If tbketerangan.Text = String.Empty Then MsgBox("Keterangan belum diisi!") : Exit Sub

            Proc("INSERT INTO ketersediaan_ruang (kode_ruang, dipakai_oleh, keterangan,status) VALUES " & _
              "('" & cbkoderuang.Text & "', '" & cbkodekelas.Text & "','" & tbketerangan.Text & "','1')")
            Proc("UPDATE ruang SET status='1' WHERE kode_ruang ='" & cbkoderuang.Text & "'")
            Proc("UPDATE kelas SET status='1' WHERE kode_kelas ='" & cbkodekelas.Text & "'")
            MsgBox("Data sukses diinput!", vbInformation, "Success")

            qry("SELECT * from ketersediaan_ruang")
            cbdataruang()
            cbdatakelas()
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
            Proc("DELETE from ketersediaan_ruang WHERE ket_id ='" & tbketid.Text & "'")
            Proc("UPDATE ruang SET status='0' WHERE kode_ruang ='" & cbkoderuang.Text & "'")
            Proc("UPDATE kelas SET status='0' WHERE kode_kelas ='" & cbkodekelas.Text & "'")

            MsgBox("Data sukses dihapus!", vbInformation, "Success")
            qry("SELECT * from ketersediaan_ruang")
            tabledgvketersediaan()
            cbdataruang()
            cbdatakelas()
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
    Private Sub dgketersediaan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgketersediaan.CellClick
        activebutton()
        tbketid.Enabled = False
        Dim i As Integer
        i = Me.dgketersediaan.CurrentRow.Index
        With dgketersediaan.Rows.Item(i)
            dgketersediaan.Text = .Cells(0).Value
            dgketersediaan.Text = .Cells(1).Value
            dgketersediaan.Text = .Cells(2).Value
            dgketersediaan.Text = .Cells(3).Value
            tbketid.Focus()
            btnhapus.Enabled = False
            btntambah.Enabled = True
            btnulangi.Enabled = True
            btnupdate.Enabled = False
        End With
    End Sub

    Private Sub dgketersediaan_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgketersediaan.CellMouseDoubleClick
        tbketid.Text = dgketersediaan.CurrentRow.Cells(0).Value
        cbkoderuang.Text = dgketersediaan.CurrentRow.Cells(1).Value
        cbkodekelas.Text = dgketersediaan.CurrentRow.Cells(2).Value
        tbketerangan.Text = dgketersediaan.CurrentRow.Cells(3).Value
        btnupdate.Enabled = True
        btnulangi.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = True
        tbketid.ReadOnly = True

    End Sub

    Private Sub tbketid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbketid.KeyPress

        If e.KeyChar = Chr(13) Then
            tbketid.Text = UCase(tbketid.Text)
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM ketersediaan_ruang WHERE ket_id ='" & tbketid.Text & "'"
            Cmd.CommandText = getData
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                tbketid.Enabled = False
                cbkoderuang.Text = Rd.Item("Kode_Kelas")
                cbkodekelas.Text = Rd.Item("Kode_Ruang")
                tbketerangan.Text = Rd.Item("keterangan")
                btnupdate.Enabled = True
                btntambah.Enabled = False
            Else
                btntambah.Enabled = True
            End If
            Rd.Close()
            Conn.Close()
            activebutton()
            tbketid.Focus()
        End If
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            If cbkoderuang.Text = String.Empty Then MsgBox("Kode Ruang belum dipilih!") : Exit Sub
            If cbkodekelas.Text = String.Empty Then MsgBox("Kode Kelas belum dipilih!") : Exit Sub
            If tbketerangan.Text = String.Empty Then MsgBox("Keterangan belum diisi!") : Exit Sub

            Proc("UPDATE ketersediaan_ruang SET kode_ruang='" & cbkoderuang.Text & "',dipakai_oleh='" &
        cbkodekelas.Text & "',keterangan='" & tbketerangan.Text & "' WHERE ket_id ='" & tbketid.Text & "'")
            MsgBox("Data telah diperbarui!", vbInformation, "Error")
            qry("SELECT * FROM ketersediaan_ruang")
            tabledgvketersediaan()
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
    End Sub
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        qry("SELECT * FROM `ketersediaan_ruang`")
        tabledgvketersediaan()
        cbdatakelas()
        cbdataruang()

    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim cari As String
        cari = tbcari.Text
        qry("SELECT * FROM ketersediaan_ruang WHERE kode_ruang like '%" & cari & "%'")
        tabledgvketersediaan()
    End Sub

End Class