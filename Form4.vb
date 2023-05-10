Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not deleteBox.Text = "" Then
            Dim deleteBook As Book
            For Each book As Book In book_list
                If book.auther_Name.ToLower = deleteBox.Text.ToLower Or book.book_name.ToLower = deleteBox.Text.ToLower Then
                    deleteBook = book
                End If
            Next
            book_list.Remove(deleteBook)
            Form1.DataGridView1.Rows.Clear()
            For Each book As Book In book_list
                Form1.DataGridView1.Rows.Add(book.book_name, book.auther_Name, book.description)
            Next
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Please enter book details")
        End If
    End Sub
End Class