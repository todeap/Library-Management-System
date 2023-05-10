Module Library
    Public book_list As New List(Of Book)()
    Public Sub initialise()
        Dim book1 As New Book()
        book1.id = 1
        book1.auther_Name = "Mark Twain"
        book1.book_name = "Adventures of Tom Sawyer"
        book1.description = "Adventures of Tom inthe mountains"
        book_list.Add(book1)

        Dim book2 As New Book()
        book2.id = 2
        book2.auther_Name = "Kazi Nasrul Islam"
        book2.book_name = "Agni Veena"
        book2.description = "Love story of Agni and Veena"
        book_list.Add(book2)

        Dim book3 As New Book()
        book3.id = 3
        book3.auther_Name = "George Orwell"
        book3.book_name = "Animal Farm"
        book3.description = "Domestic animal description"
        book_list.Add(book3)

        Dim book4 As New Book()
        book4.id = 4
        book4.auther_Name = "Lewis Wallace"
        book4.book_name = "Ben Hur"
        book4.description = "Explain London city life in 1700"
        book_list.Add(book4)

        Dim book5 As New Book()
        book5.id = 5
        book5.auther_Name = "Babur"
        book5.book_name = "Baburnama"
        book5.description = "Biography of Babur"
        book_list.Add(book5)

        Dim book6 As New Book()
        book6.id = 6
        book6.auther_Name = "Kautilya"
        book6.book_name = "Arthashastra"
        book6.description = "Explain how to rule and what are the duties of King"
        book_list.Add(book6)

        Dim book7 As New Book()
        book7.id = 7
        book7.auther_Name = "Bankimchandra Chattopadhyay"
        book7.book_name = "Anand Math"
        book7.description = "Showcase the bengal life in 19th centuary"
        book_list.Add(book7)

        Dim book8 As New Book()
        book8.id = 8
        book8.auther_Name = "Adolf Hitler"
        book8.book_name = "Mein Kampf"
        book8.description = "Autobiography of Adolf Hitler"
        book_list.Add(book8)

        Dim book9 As New Book()
        book9.id = 9
        book9.auther_Name = "Edward Gibbon"
        book9.book_name = "The Decline and Fall of the Roman Empire"
        book9.description = "History of Rom city"
        book_list.Add(book9)

        Dim book10 As New Book()
        book10.id = 10
        book10.auther_Name = "Mark Twain"
        book10.book_name = "Adventures of Tom Sawyer"
        book10.description = "Adventures of Tom inthe mountains"
        book_list.Add(book10)

        Dim book11 As New Book()
        book11.id = 11
        book11.auther_Name = "H.G. Wells"
        book11.book_name = "Time Machine"
        book11.description = "Science fiction novel"
        book_list.Add(book11)

        Dim book12 As New Book()
        book12.id = 12
        book12.auther_Name = "E.M.Forster"
        book12.book_name = "A passage to India"
        book12.description = "History of India"
        book_list.Add(book12)

        Dim book13 As New Book()
        book13.id = 13
        book13.auther_Name = "M Laxmikanth"
        book13.book_name = "Indian Polity"
        book13.description = "Bible for UPSC Indian Polity Subject"
        book_list.Add(book13)
    End Sub
End Module
