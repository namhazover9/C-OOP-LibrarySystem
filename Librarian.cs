using System;
using System.Collections.Generic;
using System.Text;

namespace ASMLibrary
{
    class Librarian : Person, IBook
    {
        private string libID;
        private List<Book> books;
        private List<GoldenEditionBook> goldenEditionBooks;
        public string LibID { get { return this.libID; } set { this.libID = value; } }
        public List<Book> Books { get { return this.books; } set { this.books = value; } }
        public List<GoldenEditionBook> GoldenEditionBooks { get { return this.goldenEditionBooks; } set { this.goldenEditionBooks = value; } }

        public Librarian(string fullName, string email) : base(fullName, email)
        {
        }
        public Librarian(string fullName, string email, string libID, List<Book> books, List<GoldenEditionBook> goldenEditionBooks) : this(fullName, email)
        {
            this.LibID = libID;
            this.Books = books;
            this.GoldenEditionBooks = goldenEditionBooks;
        }
        public Librarian() { }
        public new void InputInfo()
        {
            base.InputInfo();
            Console.Write("Input your Librarian ID: ");
            LibID = Console.ReadLine();
        }
        // ADD BOOK
        public void AddBook(List<Book> books, List<GoldenEditionBook> goldenEditionBooks)
        {
            try
            {
                Console.Write("Input the number of books to add: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Is there a special edition of this book? [y/n]: ");
                    string question = Console.ReadLine();
                    if (question == "y" || question == "Y")
                    {
                        GoldenEditionBook goldenEditionBook = new GoldenEditionBook();
                        goldenEditionBook.InputBook();
                        goldenEditionBooks.Add(goldenEditionBook);
                    }
                    else
                    {
                        Book book = new Book();
                        book.InputBook();
                        books.Add(book);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error info: " + ex.Message);
            }
        }
        // VIEW BOOK
        public void ViewBook(List<Book> books, List<GoldenEditionBook> goldenEditionBooks)
        {
            for (int i = 0; i < books.Count; i++)
                books[i].DisplayBook();
            for (int i = 0; i < goldenEditionBooks.Count; i++)
                goldenEditionBooks[i].DisplayBook();
        }
        // SEARCH BOOK BY TITLE
        public void SearchBookByTitle(List<Book> books, List<GoldenEditionBook> goldenEditionBooks)
        {
            Console.Write("Enter the TITLE of book to search for: ");
            string title = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Equals(title))
                {
                    books[i].DisplayBook();            
                }
                else
                {
                    for (int j = 0; j < goldenEditionBooks.Count; j++)
                    {
                        if (goldenEditionBooks[j].Title.Equals(title))
                            goldenEditionBooks[j].DisplayBook();
                        else
                            Console.WriteLine("Invalid book!");
                    }
                }
            }
        }
        // REMOVE BOOK BY ID
        public void RemoveBook(List<Book> books, List<GoldenEditionBook> goldenEditionBooks)
        {
            Console.Write("Enter the ID of book to remove: ");
            string id = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookID.Equals(id))
                {
                    books.Remove(books[i]);
                    Console.WriteLine("Remove successfully!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    for (int j = 0; j < goldenEditionBooks.Count; j++)
                    {
                        if (goldenEditionBooks[j].BookID.Equals(id))
                        {
                            goldenEditionBooks.Remove(goldenEditionBooks[j]);
                            Console.WriteLine("Remove successfully!");
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Invalid book!");
                    }
                }
            }
        }
        // EDIT BOOK BY ID
        public void EditBook(List<Book> books, List<GoldenEditionBook> goldenEditionBooks)
        {
            Console.Write("Enter the ID of book to edit: ");
            string id = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookID.Equals(id))
                {
                    books[i].DisplayBook();
                    Console.WriteLine("--- Edit book ---");
                    books.Remove(books[i]);
                    Book book = new Book();
                    book.InputBook();
                    books.Add(book);
                    Console.WriteLine("Edit successfully!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    for (int j = 0; j < goldenEditionBooks.Count; j++)
                    {
                        if (goldenEditionBooks[j].BookID.Equals(id))
                        {
                            goldenEditionBooks[j].DisplayBook();
                            Console.WriteLine("--- Edit Book ---");
                            goldenEditionBooks.Remove(goldenEditionBooks[j]);
                            GoldenEditionBook goldenEditionBook = new GoldenEditionBook();
                            goldenEditionBook.InputBook();
                            goldenEditionBooks.Add(goldenEditionBook);
                            Console.WriteLine("Edit successfully!");
                            Console.WriteLine();
                            break;
                        }
                        else
                            Console.WriteLine("Invalid book!");
                    }
                }
            }
        }
    }
}
