Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchField As String
        Dim book_present As Boolean
        book_present = False
        searchField = SearchBox.Text.ToLower()
        DataGridView1.Rows.Clear()
        For Each book As Book In book_list
            If searchField = book.auther_Name.ToLower() Or searchField = book.book_name.ToLower() Or searchField = "all" Then
                DataGridView1.Rows.Add(book.book_name, book.auther_Name, book.description)
                book_present = True
            End If
        Next
        If Not book_present Then
            MessageBox.Show("Searched book not found in data base try to contact Admin")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialise()

        For Each book As Book In book_list
            DataGridView1.Rows.Add(book.book_name, book.auther_Name, book.description)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class
