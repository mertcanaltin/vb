Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim istenilen() As String = {"Mr", "Ultrason", "tomografi"}
        ComboBox1.Items.AddRange(istenilen)
        ComboBox1.Items.Insert(0, "Seçiniz")
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim secilentarih As Date = DateTimePicker1.Value

        ListBox1.Items.Add(ComboBox1.SelectedItem & ": " & secilentarih)

    End Sub
End Class
