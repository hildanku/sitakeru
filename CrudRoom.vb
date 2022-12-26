Imports MySql.Data.MySqlClient
Imports System.Data
Public Class CrudRoom
    Sub countruang()
        Dim jmldata
        jmldata = dgruang.RowCount()
        Label9.Text = jmldata
    End Sub
    Sub countkelas()
        Dim jmldata
        jmldata = dgkelas.RowCount
        Label4.Text = jmldata
    End Sub

    Sub inactvbtnruang()
        tbruangid.Enabled = False
        tbkoderuang.Enabled = False
        tbnamaruang.Enabled = False
        btntambahruang.Enabled = False
        btnulangi.Enabled = False
        btnhapusruang.Enabled = False
        btnupdateruang.Enabled = False
        tbruangid.BackColor = Color.Gray
        tbkoderuang.BackColor = Color.Gray
        tbnamaruang.BackColor = Color.Gray
    End Sub
    Sub inactvbtnkelas()
        tbruangid.Enabled = False
        tbkodekelas.Enabled = False
        tbnamakelas.Enabled = False
        btntambahkelas.Enabled = False
        btnulangikelas.Enabled = False
        btnhapuskelas.Enabled = False
        btnupdatekelas.Enabled = False
        tbruangid.BackColor = Color.Gray
        tbkodekelas.BackColor = Color.Gray
        tbnamakelas.BackColor = Color.Gray
    End Sub
    Sub actvbtnkelas()
        tbruangid.Enabled = False
        tbkodekelas.Enabled = True
        tbnamakelas.Enabled = True
        tbruangid.BackColor = Color.White
        tbkoderuang.BackColor = Color.White
        tbnamaruang.BackColor = Color.White
    End Sub
    Sub actvbtnruang()
        tbruangid.Enabled = False
        tbkoderuang.Enabled = True
        tbnamaruang.Enabled = True
        tbruangid.BackColor = Color.White
        tbkoderuang.BackColor = Color.White
        tbnamaruang.BackColor = Color.White
    End Sub
    Sub tabledgvruang()
        Try
            dgruang.Columns(0).Width = 30
            dgruang.Columns(1).Width = 70
            dgruang.Columns(2).Width = 130
            dgruang.Columns(0).HeaderText = "ID"
            dgruang.Columns(1).HeaderText = "Kode Ruang"
            dgruang.Columns(2).HeaderText = "Nama Ruang"
            dgruang.Columns(3).HeaderText = "Status Ruang"
        Catch ex As Exception
        End Try
    End Sub
    Sub tabledgvkelas()
        Try
            dgkelas.Columns(0).Width = 30
            dgkelas.Columns(1).Width = 70
            dgkelas.Columns(2).Width = 130
            dgkelas.Columns(0).HeaderText = "ID"
            dgkelas.Columns(1).HeaderText = "Kode Kelas"
            dgkelas.Columns(2).HeaderText = "Nama Kelas"
            dgkelas.Columns(3).HeaderText = "Status Kelas"
        Catch ex As Exception
        End Try
    End Sub
    Sub cleandataruang()
        tbruangid.ResetText()
        tbkoderuang.ResetText()
        tbnamaruang.ResetText()
    End Sub
    Sub cleandatakelas()
        tbkelasid.ResetText()
        tbkodekelas.ResetText()
        tbnamakelas.ResetText()
    End Sub

    Sub refreshdatakelas()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM kelas"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Da.SelectCommand = Cmd
            Da.Fill(Ds, "kelas")
            With dgkelas
                .DataSource = Ds.Tables("kelas")
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
    Sub refreshdataruang()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM ruang"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Da.SelectCommand = Cmd
            Da.Fill(Ds, "ruang")
            With dgruang
                .DataSource = Ds.Tables("ruang")
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

    Sub qryruang(ByVal sql As String)
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = sql
        Da.SelectCommand = Cmd
        Ds.Tables.Clear()
        Da.Fill(Ds, "ruang")
        dgruang.DataSource = (Ds.Tables("ruang"))
        Conn.Close()
    End Sub
    Sub qrykelas(ByVal sql As String)
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = sql
        Da.SelectCommand = Cmd
        Ds.Tables.Clear()
        Da.Fill(Ds, "kelas")
        dgkelas.DataSource = (Ds.Tables("kelas"))
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
    Private Sub Crudroom_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btntambahruang.Enabled = True
        btntambahkelas.Enabled = True
        btnulangi.Enabled = True
        btnulangikelas.Enabled = True
        btnhapusruang.Enabled = False
        btnhapuskelas.Enabled = False
        btnupdateruang.Enabled = False
        btnupdatekelas.Enabled = False
        tbkelasid.Enabled = False
        tbruangid.Enabled = False
        cleandataruang()
        cleandatakelas()
    End Sub
    Private Sub CrudRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        countkelas()
        countruang()


        btntambahruang.Enabled = True
        btntambahkelas.Enabled = True
        btnulangi.Enabled = True
        btnulangikelas.Enabled = True
        btnhapusruang.Enabled = False
        btnhapuskelas.Enabled = False
        btnupdateruang.Enabled = False
        btnupdatekelas.Enabled = False
        cleandataruang()
        cleandatakelas()
        refreshdatakelas()
        refreshdataruang()
        tabledgvruang()
        tabledgvkelas()
    End Sub
    ' START CRUD RUANG
    Private Sub btntambahruang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambahruang.Click

        Try
            'validasi
            If tbkoderuang.Text = String.Empty Then MsgBox("Nama belum diisi!") : Exit Sub
            If tbnamaruang.Text = String.Empty Then MsgBox("Username belum diisi!") : Exit Sub

            Proc("INSERT INTO ruang (kode_ruang, nama_ruang,status) VALUES " & _
              "('" & tbkoderuang.Text & "', '" & tbnamaruang.Text & "','0')")
            MsgBox("Data sukses diinput!", vbInformation, "Success")
            qryruang("select * from ruang")
            tabledgvruang()
            cleandataruang()
            btnhapusruang.Enabled = False
            btnulangi.Enabled = True
            btnupdateruang.Enabled = False
            btntambahruang.Enabled = True

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)

        Finally
            Conn.Dispose()

        End Try
    End Sub

    Private Sub btnulangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnulangi.Click
        cleandataruang()
    End Sub
    Private Sub dgruang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgruang.CellClick
        tbruangid.Enabled = False
        Dim i As Integer
        i = Me.dgruang.CurrentRow.Index
        With dgruang.Rows.Item(i)
            tbruangid.Text = .Cells(0).Value.ToString
            tbkoderuang.Text = .Cells(1).Value.ToString
            tbnamaruang.Text = .Cells(2).Value.ToString
            tbruangid.Focus()
            btnhapusruang.Enabled = False
            btntambahruang.Enabled = True
            btnulangi.Enabled = True
            btnupdateruang.Enabled = False
        End With
    End Sub

    Private Sub dgruang_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgruang.CellMouseDoubleClick
        tbruangid.Text = dgruang.CurrentRow.Cells(0).Value.ToString
        tbkoderuang.Text = dgruang.CurrentRow.Cells(1).Value.ToString
        tbnamaruang.Text = dgruang.CurrentRow.Cells(2).Value.ToString
        btnupdateruang.Enabled = True
        btnhapusruang.Enabled = True
        btntambahruang.Enabled = False
        btnulangi.Enabled = True
        tbruangid.ReadOnly = True

    End Sub

    Private Sub tbruangid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbruangid.KeyPress

        If e.KeyChar = Chr(13) Then
            tbruangid.Text = UCase(tbruangid.Text)
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * from ruang WHERE id ='" & tbruangid.Text & "'"
            Cmd.CommandText = getData
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                tbruangid.Enabled = False
                tbkoderuang.Text = Rd.Item("Kode Ruang")
                tbnamaruang.Text = Rd.Item("Nama Ruang")
                btnupdateruang.Enabled = True
                btntambahruang.Enabled = False
            Else
                btntambahruang.Enabled = True
            End If
            Rd.Close()
            Conn.Close()
            tbkoderuang.Focus()
        End If
    End Sub
    Private Sub btnupdateruang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateruang.Click
        Try
            '       If tbkoderuang.MaxLength >= 6 Then MsgBox("Kode Ruang melebihi batas karakter!") : Exit Sub
            If tbkoderuang.Text = String.Empty Then MsgBox("Kode Ruang belum diisi!") : Exit Sub
            If tbnamaruang.Text = String.Empty Then MsgBox("Nana belum diisi!") : Exit Sub


            Proc("UPDATE ruang SET kode_ruang='" & tbkoderuang.Text & "',nama_ruang='" &
        tbnamaruang.Text & "' WHERE ruang_id ='" & tbruangid.Text & "'")
            MsgBox("Data telah diperbarui!", vbInformation, "Error")
            qryruang("SELECT * FROM ruang")
            tabledgvruang()
            cleandataruang()
            btnupdateruang.Enabled = False
            btnhapusruang.Enabled = False
            btntambahruang.Enabled = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub

    Private Sub btnhapusruang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapusruang.Click
        Try
            Proc("DELETE FROM ruang WHERE ruang_id ='" & tbruangid.Text & "'")
            MsgBox("Data sukses dihapus!", vbInformation, "Success")
            qryruang("SELECT * FROM ruang")
            tabledgvruang()
            btntambahruang.Enabled = True
            btnupdateruang.Enabled = False
            btnhapusruang.Enabled = False

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub
    ' END CRUD RUANG
    'START CRUD KELAS
    Private Sub btntambahkelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambahkelas.Click

        Try
            'validasi
            If tbkodekelas.Text = String.Empty Then MsgBox("Kode Ruang belum diisi!") : Exit Sub
            If tbnamakelas.Text = String.Empty Then MsgBox("Nama Ruang belum diisi!") : Exit Sub


            If tbkodekelas.MaxLength >= 6 Then MsgBox("Kode Kelas melebihi batas karakter!") : Exit Sub

            Proc("INSERT INTO kelas (kode_kelas, nama_kelas) VALUES " & _
              "('" & tbkodekelas.Text & "', '" & tbnamakelas.Text & "')")
            MsgBox("Data sukses diinput!", vbInformation, "Success")
            qrykelas("SELECT * FROM kelas")
            tabledgvkelas()
            cleandatakelas()
            btnhapuskelas.Enabled = False
            btnulangikelas.Enabled = False
            btnupdatekelas.Enabled = False
            btntambahkelas.Enabled = True

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)

        Finally
            Conn.Dispose()

        End Try
    End Sub

    Private Sub btnulangikelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnulangikelas.Click
        cleandatakelas()
        btnhapuskelas.Enabled = False
        btnupdatekelas.Enabled = False
        btntambahkelas.Enabled = True

    End Sub
    Private Sub dgkelas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgkelas.CellClick
        tbruangid.Enabled = False
        Dim i As Integer
        i = Me.dgkelas.CurrentRow.Index
        With dgkelas.Rows.Item(i)
            tbkelasid.Text = .Cells(0).Value.ToString
            tbkodekelas.Text = .Cells(1).Value.ToString
            tbnamakelas.Text = .Cells(2).Value.ToString
            tbkelasid.Focus()
            btnhapuskelas.Enabled = False
            btntambahkelas.Enabled = True
            btnulangikelas.Enabled = True
            btnupdatekelas.Enabled = False
        End With
    End Sub

    Private Sub dgkelas_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgkelas.CellMouseDoubleClick
        tbkelasid.Text = dgkelas.CurrentRow.Cells(0).Value.ToString
        tbkodekelas.Text = dgkelas.CurrentRow.Cells(1).Value.ToString
        tbnamakelas.Text = dgkelas.CurrentRow.Cells(2).Value.ToString
        btnulangikelas.Enabled = True
        btntambahkelas.Enabled = False
        btnhapuskelas.Enabled = True
        btnupdatekelas.Enabled = True
        tbkelasid.ReadOnly = True

    End Sub

    Private Sub tbkelasid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbkelasid.KeyPress

        If e.KeyChar = Chr(13) Then
            tbkelasid.Text = UCase(tbkelasid.Text)
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM kelas WHERE kelas_id ='" & tbkelasid.Text & "'"
            Cmd.CommandText = getData
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                tbruangid.Enabled = False
                tbkodekelas.Text = Rd.Item("Kode Kelas")
                tbnamakelas.Text = Rd.Item("Nama Kelas")
                btnupdatekelas.Enabled = True
                btntambahkelas.Enabled = False
            Else
                btntambahkelas.Enabled = True
            End If
            Rd.Close()
            Conn.Close()
            tbkodekelas.Focus()
        End If
    End Sub
    Private Sub btnupdatekelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdatekelas.Click
        Try
            If tbkodekelas.Text = String.Empty Then MsgBox("Kode Kelas belum diisi!") : Exit Sub
            If tbnamakelas.Text = String.Empty Then MsgBox("Nana belum diisi!") : Exit Sub

            Proc("UPDATE kelas SET kode_kelas='" & tbkodekelas.Text & "',nama_kelas='" &
        tbnamakelas.Text & "' WHERE kelas_id ='" & tbkelasid.Text & "'")
            MsgBox("Data telah diperbarui!", vbInformation, "Error")
            qrykelas("SELECT * FROM kelas")
            tabledgvkelas()
            cleandatakelas()
            btnupdatekelas.Enabled = False
            btntambahkelas.Enabled = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub

    Private Sub btnhapuskelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapuskelas.Click
        Try
            Proc("DELETE FROM kelas WHERE kelas_id ='" & tbkelasid.Text & "'")
            MsgBox("Data sukses dihapus!", vbInformation, "Success")
            qrykelas("SELECT * FROM kelas")
            tabledgvkelas()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshdatakelas()
        refreshdataruang()

        tabledgvkelas()
        tabledgvruang()
    End Sub
    ' END CRUD KELAS

    Private Sub btnbacktohome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbacktohome.Click
        Me.Close()

    End Sub


    Private Sub btncarikelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarikelas.Click
        Dim cari As String
        cari = tbcarikelas.Text
        qrykelas("SELECT * FROM kelas WHERE kode_kelas like '%" & cari & "%'")
        tabledgvkelas()
    End Sub

    Private Sub btncariruang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncariruang.Click
        Dim cari As String
        cari = tbcariruang.Text
        qryruang("SELECT * FROM ruang WHERE kode_ruang like '%" & cari & "%'")
        tabledgvkelas()
    End Sub

End Class