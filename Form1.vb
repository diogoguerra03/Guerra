Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l As New Login
        l.MdiParent = Me
        l.Show()
    End Sub
End Class
