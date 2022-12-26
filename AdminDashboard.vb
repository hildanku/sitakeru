Public Class AdminDashboard
    Sub hidebro()
        CrudUser.Hide()
        CrudRoom.Hide()
        CrudKetersediaan.Hide()
        TentangAplikasi.Hide()
        CrudInventaris.Hide()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '   Lbl12Jam.Text = Format(Now, "hh:mm:ss tt")
        labelwaktu.Text = Format(Now, "dddd, dd – MMMM – yyyy")
        waktu.Text = Format(Now, "H:mm:ss")
    End Sub
    Private Sub AdminDashboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' labelwaktu.Text = Today
        Timer1.Enabled = True
    End Sub
    Private Sub CrudUserPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrudUserPage.Click
        hidebro()
        CrudUser.TopLevel = False
        PanelIndex.Controls.Add(CrudUser)
        CrudUser.Show()
    End Sub

    Private Sub CrudRoomPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrudRoomPage.Click
        hidebro()
        CrudRoom.TopLevel = False
        PanelIndex.Controls.Add(CrudRoom)
        CrudRoom.Show()
    End Sub
    Private Sub CrudKetersediaanPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrudKetersediaanPage.Click
        hidebro()
        CrudKetersediaan.TopLevel = False
        PanelIndex.Controls.Add(CrudKetersediaan)
        CrudKetersediaan.Show()
    End Sub

    Private Sub CrudInventarisPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrudInventarisPage.Click
        hidebro()
        CrudInventaris.TopLevel = False
        PanelIndex.Controls.Add(CrudInventaris)
        CrudInventaris.Show()
    End Sub
    Private Sub TentangAplikasiPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TentangAplikasiPage.Click
        hidebro()
        TentangAplikasi.TopLevel = False
        PanelIndex.Controls.Add(TentangAplikasi)
        TentangAplikasi.Show()
    End Sub
    Private Sub Homepage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Homepage.Click
        Call hidebro()
    End Sub
    Private Sub mnz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnz.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mxz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mxz.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub cls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cls.Click
        Me.Dispose()
    End Sub

End Class