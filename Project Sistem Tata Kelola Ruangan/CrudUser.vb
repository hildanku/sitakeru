
Public Class CrudUser
    ' START FUNCTION
    '  Sub databarang()
    'Dim jmldata
    '   jmldata = dguser.RowCount
    '  Label6.Text = jmldata
    ' End Sub
    Sub tabledgvuser()
        Try
            dguser.Columns(0).Width = 70
            dguser.Columns(1).Width = 130
            dguser.Columns(2).Width = 100
            dguser.Columns(3).Width = 120
            dguser.Columns(4).Width = 100
            dguser.Columns(0).HeaderText = "ID"
            dguser.Columns(1).HeaderText = "Nama"
            dguser.Columns(2).HeaderText = "User"
            dguser.Columns(3).HeaderText = "Password"
            dguser.Columns(4).HeaderText = "Role"
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
    End Sub
    Sub cleandata()
        tbid.ResetText()
        tbnama.ResetText()
        tbusername.ResetText()
        tbpassword.ResetText()
    End Sub
    Sub loaddata()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            getData = "SELECT * FROM users"
            Cmd.Connection = Conn
            Cmd.CommandText = getData
            Da.SelectCommand = Cmd
            Da.Fill(Ds, "users")
            With dguser
                .DataSource = Ds.Tables("users")
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
        Da.Fill(Ds, "users")
        dguser.DataSource = (Ds.Tables("users"))
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
    Sub ValidasiDuplikat()
        Try
            Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "SELECT * FROM users WHERE username='" & tbusername.Text & "'"
            Rd = Cmd.ExecuteReader()
            If Rd.HasRows = True Then
                MsgBox("Data sudah terdaftar di Database!", vbCritical, "Error")
            End If
            Conn.Close()
        Catch ex As Exception

        Finally
            Conn.Dispose()

        End Try

    End Sub
    ' END FUNCTION

    Private Sub CrudUser_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btntambah.Enabled = True
        btnulangi.Enabled = True
        btnhapus.Enabled = False
        btnupdate.Enabled = False

        cleandata()
    End Sub
    Private Sub CrudUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        '     databarang()
        tbid.Enabled = False
        btntambah.Enabled = True
        btnulangi.Enabled = True
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        tabledgvuser()
    End Sub
    Private Sub dguser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dguser.CellClick
        tbid.Enabled = False
        Dim i As Integer
        i = Me.dguser.CurrentRow.Index
        With dguser.Rows.Item(i)
            tbid.Text = .Cells(0).Value
            tbnama.Text = .Cells(1).Value
            tbusername.Text = .Cells(2).Value
            tbpassword.Text = .Cells(3).Value
            tbid.Focus()
            btnhapus.Enabled = False
            btntambah.Enabled = True
            btnulangi.Enabled = True
            btnupdate.Enabled = False
        End With
    End Sub

    Private Sub dguser_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dguser.CellMouseDoubleClick
        tbid.Text = dguser.CurrentRow.Cells(0).Value
        tbnama.Text = dguser.CurrentRow.Cells(1).Value
        tbusername.Text = dguser.CurrentRow.Cells(2).Value
        tbpassword.Text = dguser.CurrentRow.Cells(3).Value
        optM.Text = dguser.CurrentRow.Cells(4).Value
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = True
        btnulangi.Enabled = True

        tbid.ReadOnly = True

    End Sub


    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click

        Try
            'validasi
            If tbnama.Text = String.Empty Then MsgBox("Nama belum diisi!") : Exit Sub
            If tbusername.Text = String.Empty Then MsgBox("Username belum diisi!") : Exit Sub
            If tbpassword.Text = String.Empty Then MsgBox("Password belum diisi!") : Exit Sub
            If optO.Checked = False And optM.Checked = False Then
                MsgBox("Pilih Role yang tersedia", vbCritical, "Error")
                Return
            End If

            Dim str As String
            str = "role"
            If optO.Checked = True Then
                str = "operator"

            ElseIf optM.Checked = True Then
                str = "mahasiswa"
            End If

            Proc("INSERT INTO users (nama, username, password,role) VALUES " & _
              "('" & tbnama.Text & "', '" & tbusername.Text & "','" & tbpassword.Text & "','" & str & "')")
            MsgBox("Data sukses diinput!", vbInformation, "Success")
            qry("SELECT * FROM users")
            tabledgvuser()
            cleandata()
            tbid.Enabled = False
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
            Proc("DELETE FROM users WHERE id ='" & tbid.Text & "'")
            MsgBox("Data sukses dihapus!", vbInformation, "Success")
            qry("SELECT * FROM users")
            tabledgvuser()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            If tbnama.Text = String.Empty Then MsgBox("Nama belum diisi!") : Exit Sub
            If tbusername.Text = String.Empty Then MsgBox("Username belum diisi!") : Exit Sub
            If tbpassword.Text = String.Empty Then MsgBox("Password belum diisi!") : Exit Sub
            If optO.Checked = False And optM.Checked = False Then
                MsgBox("Pilih Role yang tersedia", vbCritical, "Error")
                Return
            End If

            Dim str As String
            str = "role"
            If optO.Checked = True Then
                str = "operator"
            ElseIf optM.Checked = True Then
                str = "mahasiswa"
            End If

            Proc("UPDATE users SET nama='" & tbnama.Text & "',username='" &
        tbusername.Text & "',password='" & tbpassword.Text & "',role='" & str & "' WHERE id ='" & tbid.Text & "'")
            MsgBox("Data telah diperbarui!", vbInformation, "Error")
            qry("SELECT * FROM users")
            tabledgvuser()
            cleandata()
            btnupdate.Enabled = False
            btntambah.Enabled = True
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim cari As String
        cari = tbcari.Text
        qry("SELECT * FROM users WHERE id like '%" & cari & "%' or nama like '%" & cari & "%' or username like '%" & cari & "%' or role like '%" & cari & "%'")
        tabledgvuser()
    End Sub
    Private Sub btnbacktohome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbacktohome.Click
        Me.Close()
    End Sub
    Private Sub btnulangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnulangi.Click
        cleandata()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnupdate.Enabled = False
    End Sub

End Class