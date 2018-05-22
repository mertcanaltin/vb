sayı  ürettik 


Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim sayi1, sayi2 As Integer
        Dim rastgele As New Random




        sayi1 = rastgele.Next(5, 16) '10 ile 20 arasında random üretir'
        sayi2 = rastgele.Next(5, 16)
        TextBox1.Text = sayi1 & " " & sayi2
    End Sub
End Class
