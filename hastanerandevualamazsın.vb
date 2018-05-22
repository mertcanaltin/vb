Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim secilentarih As Date = DateTimePicker1.Value
        If secilentarih.DayOfWeek = 0 Then
            ListBox1.Items.Add("Pazar gününe sıra alamazsınız.")
        Else
            ListBox1.Items.Add(ComboBox1.SelectedItem & ": " & secilentarih)
        End If
    End Sub
