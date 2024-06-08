Public Class Login
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = “" Or PasswordTb.Text = "" Then
            MsgBox("Enter UserName and Password”)
        ElseIf UnameTb.Text = “Parth” And PasswordTb.Text = "5212" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox(“Wrong Username or Password”)
            UnameTb.Text = “"
            PasswordTb.Text = “"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
