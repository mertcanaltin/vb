Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sayi1 As Integer = 0, sayi2 As Integer = 0, sayi3 As Integer = 0, sayi4 As Integer = 0
        Dim s As Random = New Random()
        sayi1 = s.[Next](1, 7)
        sayi2 = s.[Next](1, 7)
        sayi3 = s.[Next](1, 7)
        sayi4 = s.[Next](1, 7)

        If (sayi1 + sayi2) > (sayi3 + sayi4) Then
            Label1.Text = ("Mert: " & (sayi1 + sayi2) & " e " & (sayi3 + sayi4) & " ile kazandı.. ONUR KAYBETTİ ")
        ElseIf (sayi1 + sayi2) < (sayi3 + sayi4) Then
            Label1.Text = ("Onur: " & (sayi3 + sayi4) & " e " & (sayi2 + sayi1) & " ile kazandı.. MERT KAYBETTİ")
        ElseIf (sayi1 + sayi2) = (sayi3 + sayi4) Then
            Label1.Text = ("Berabere: " & (sayi1 + sayi2) & " = " & (sayi3 + sayi4))
        End If
    End Sub

End Class
