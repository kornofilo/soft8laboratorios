Public Class Form8
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ListBox1.Items.Add(TextBox1.Text)
		TextBox1.Clear()


	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		ListBox2.Items.Add(ListBox1.SelectedItem)
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

		ListBox2.Items.Remove(ListBox2.SelectedItem)
		TextBox1.Clear()

	End Sub
End Class