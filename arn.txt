Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rast As New Random
        Dim s1, s2, s3 As Integer
        s1 = rast.Next(5, 16)
        s2 = rast.Next(1, 4)
        s3 = rast.Next(5, 16)
        Label1.Text = s1
        Label3.Text = s3
        If s2 = 1 Then
            Label2.Text = "<>"
        ElseIf s2 = 2 Then
            Label2.Text = "="
        ElseIf s2 = 3 Then
            Label2.Text = "<"
        End If
        If s1 = s3 And s2 = 2 Then
            MsgBox("Tebrikler kazandınız")
        End If
    End Sub
End Class
