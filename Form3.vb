Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not auther_name.Text = "" And Not book_name.Text = "" And Not book_des.Text = "" Then
            For Each book As Book In book_list
                If book.auther_Name.ToLower = auther_name.Text.ToLower And book.book_name.ToLower = book_name.Text.ToLower Then
                    book.description = book_des.Text
                End If
            Next
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