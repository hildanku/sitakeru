Public Class Login
    Dim Ifail = 0


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ifail = 0
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim stru As String = tbusername.Text
        Dim strp As String = tbpassword.Text

        If stru = String.Empty Then MsgBox("Username belum diisi!") : Exit Sub
        If strp = String.Empty Then MsgBox("Password belum diisi!") : Exit Sub
            Try
                If checklogin(stru, strp) > 0 Then
                    MsgBox("Welcome " & stru & "!")
                    AdminDashboard.Show()
                    Me.Hide()

                Else
                MsgBox("Username/password Salah." & vbCrLf & "Silahkan cek lagi!")
                End If
            Catch ex As Exception
                MsgBox("Error Login: " & ex.Message)
            End Try
    End Sub
    Private Sub btnrepeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepeat.Click
        tbusername.ResetText()
        tbpassword.ResetText()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()

    End Sub


    Private Sub cls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cls.Click
        Me.Dispose()
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class