Public Class frmuser
    Sub tampilusers(ByVal sql As String)
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Sql
        Da.SelectCommand = Cmd
        Ds.Tables.Clear()
        Da.Fill(Ds, "users")
        dguser.DataSource = (ds.Tables("users"))
        Conn.Close()
    End Sub
    Sub prosesusers(ByVal sql As String)
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = sql
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Sub setdatagrid()
        dguser.Columns(0).HeaderText = "ID"
        dguser.Columns(1).HeaderText = "NAMA"
        dguser.Columns(2).HeaderText = "ALAMAT"
        dguser.Columns(3).HeaderText = "NO.HP"
        dguser.Columns(0).Width = 70
        dguser.Columns(1).Width = 100
        dguser.Columns(2).Width = 200
        dguser.Columns(3).Width = 100
    End Sub
    Sub tidakaktif()
        tbid.Enabled = False
        tbnama.Enabled = False
        tbusername.Enabled = False
        tbpassword.Enabled = False
        btsimpan.Enabled = False
        btbatal.Enabled = False
        bthapus.Enabled = False
        btedit.Enabled = False
        tbid.BackColor = Color.Gray
        tbnama.BackColor = Color.Gray
        tbusername.BackColor = Color.Gray
        tbpassword.BackColor = Color.Gray
    End Sub
    Sub aktif()
        tbid.Enabled = True
        tbnama.Enabled = True
        tbusername.Enabled = True
        tbpassword.Enabled = True
        tbid.BackColor = Color.White
        tbnama.BackColor = Color.White
        tbusername.BackColor = Color.White
        tbpassword.BackColor = Color.White
    End Sub
    Sub bersih()
        tbid.Text = ""
        tbnama.Text = ""
        tbusername.Text = ""
        tbpassword.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        btn.Enabled = True
        btbatal.Enabled = False
        btn.Focus()
        bthapus.Enabled = False
        bersih()
        tidakaktif()
        btsimpan.Enabled = False
    End Sub
    Private Sub bttambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        bersih()
        aktif()
        btn.Enabled = False
        btbatal.Enabled = True
        btsimpan.Enabled = True
        bthapus.Enabled = False
        tbid.Focus()
    End Sub


    Private Sub frmusers_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        tidakaktif()
        bersih()
    End Sub
    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Dispose()
    End Sub
    Private Sub frmusers_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        tampilusers("select * from users")
        setdatagrid()
        tidakaktif()
    End Sub
    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        prosesusers("insert into users values('" & tbid.Text & "','" &
       tbnama.Text & "','" & tbusername.Text & "','" & tbpassword.Text & "')")
        MsgBox("Data Telah Tersimpan", MsgBoxStyle.Information, "Informasi")
        tampilusers("select* from users")
        setdatagrid()
        bersih()
        tidakaktif()
        btsimpan.Enabled = False
        btn.Enabled = True
    End Sub
    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click

        prosesusers("delete from users where Id_users='" & tbid.Text & "'")
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
        tampilusers("select* from users")
        setdatagrid()

    End Sub
    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbid.KeyPress
        If e.KeyChar = Chr(13) Then
            tbid.Text = UCase(tbid.Text)
            Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "select * from users WHERE Id_users='" &
           tbid.Text & "'"
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                tbid.Enabled = False
                tbnama.Text = Rd.Item("Nama")
                tbusername.Text = Rd.Item("Alamat")
                tbpassword.Text = Rd.Item("No_Hp")
                btedit.Enabled = True
                btsimpan.Enabled = False
            Else
                btsimpan.Enabled = True
            End If
            Rd.Close()
            Conn.Close()
            aktif()
            tbnama.Focus()
        End If
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        txtcari.Text = UCase(txtcari.Text)
        tampilusers("SELECT * from users WHERE Id_users like '%" & txtcari.Text & "%' or Nama like '%" & txtcari.Text & "%'")
        setdatagrid()
    End Sub
    Private Sub dguser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dguser.CellClick
        aktif()
        tbid.Enabled = False
        Dim i As Integer
        i = Me.dguser.CurrentRow.Index
        With dguser.Rows.Item(i)
            tbid.Text = .Cells(0).Value
            tbnama.Text = .Cells(1).Value
            tbusername.Text = .Cells(2).Value
            tbpassword.Text = .Cells(3).Value
            tbid.Focus()
            bthapus.Enabled = True
            btsimpan.Enabled = False
            btbatal.Enabled = True
            btn.Enabled = False
            btedit.Enabled = True
        End With
    End Sub
    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnama.KeyPress
        If e.KeyChar = Chr(13) Then
            tbnama.Text = UCase(tbnama.Text)
            tbusername.Focus()
        End If
    End Sub
    Private Sub txtalamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbusername.KeyPress
        If e.KeyChar = Chr(13) Then
            tbpassword.Focus()
        End If
    End Sub
    Private Sub txthp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btsimpan.Focus()
        End If
    End Sub
    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        prosesusers("UPDATE users set nama='" & tbnama.Text & "',username='" & tbusername.Text & "',password='" & tbpassword.Text & "' where id ='" & tbid.Text & "'")
        MsgBox("Data Telah Diperbahrui", MsgBoxStyle.Information, "Informasi")
        tampilusers("select * from users")
        setdatagrid()
        bersih()
        tidakaktif()
        btsimpan.Enabled = False
        btn.Enabled = True
    End Sub

    Private Sub dgpelanggan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dguser.CellClick, dgpelanggan.CellClick

    End Sub

End Class