Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If String.IsNullOrEmpty(TxtKullaniciAdi.Text) And String.IsNullOrEmpty(TxtParola.Text) Then
            MessageBox.Show("Kullanıcı adı ve/veya şifre boş bırakılmaz.", "UYARI")
            Return
        End If

        If TxtKullaniciAdi.Text = "tugba" And TxtParola.Text = "1234" Then

            Me.Hide()

            Dim box = New FrmMain()
            box.Show()
        Else
            MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış ", "UYARI")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub
End Class
