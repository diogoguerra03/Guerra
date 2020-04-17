Public Class Login
    Dim pass As Boolean = False
    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TxtUser.Text = "admin" And TxtPass.Text = "admin" Then
            Dim msg = "Inseriu os dados corretos"
            Dim titulo = "Information"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
            Me.Close()
        Else

            If count = 3 Then
                Dim msg = "O nome de utilizador: admin" & vbCrLf & "A palavra-passe: admin"
                Dim titulo = "Dica"
                Dim botoes = MessageBoxButtons.OK
                Dim icone = MessageBoxIcon.Information
                MessageBox.Show(msg, titulo, botoes, icone)
            Else
                count += 1
                Dim msg = "Iseriu o nome de utilizador ou a palavra-passe errados"
                Dim titulo = "Erro"
                Dim botoes = MessageBoxButtons.OK
                Dim icone = MessageBoxIcon.Error
                MessageBox.Show(msg, titulo, botoes, icone)
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        If pass = True Then
            TxtPass.PasswordChar = "*"
            pass = False
            BtnView.Image = ImgPass.Images(0)
        Else
            TxtPass.PasswordChar = ""
            pass = True
            BtnView.Image = ImgPass.Images(1)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnView.Image = ImgPass.Images(0)
    End Sub
End Class