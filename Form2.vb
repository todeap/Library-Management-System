Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not auther_name.Text = "" And Not book_name.Text = "" And Not book_des.Text = "" Then
            book_list.Add(New Book() With {.id = book_list.Count + 1, .auther_Name = auther_name.Text, .book_name = book_name.Text, .description = book_des.Text})
            Me.Hide()
            Form1.DataGridView1.Rows.Clear()
            For Each book As Book In book_list
                Form1.DataGridView1.Rows.Add(book.book_name, book.auther_Name, book.description)
            Next
            Form1.Show()
        Else
            MessageBox.Show("Please enter book details")
        End If

    End Sub
End Class