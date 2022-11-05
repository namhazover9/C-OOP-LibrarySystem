using System;
using System.Collections.Generic;
using System.Text;

namespace ASMLibrary
{
    class Student : Person, IBook
    {
        private string studentID;
        private List<Book> books;
        private List<GoldenEditionBook> goldenEditionBooks;
        private List<Borrowing> borrowings;

        public string StudentID { get { return this.studentID; } set { this.studentID = value; } }
        public List<Book> Books { get { return this.books; } set { this.books = value; } }
        public List<GoldenEditionBook> GoldenEditionBooks { get { return this.goldenEditionBooks; } set { this.goldenEditionBooks = value; } }
        public List<Borrowing> Borrowings { get { return this.borrowings; } set { this.borrowings = value; } }

        public Student(string fullName, string email) : base(fullName, email)
        {
        }
        public Student(string fullName, string email, string studentID, List<Book> books, List<GoldenEditionBook> goldenEditionBooks) : this(fullName, email)
        {
            this.StudentID = studentID;
            this.Books = books;
            this.GoldenEditionBooks = goldenEditionBooks;
        }
        public Student() { }

        public new void InputInfo()
        {
            base.InputInfo();
            Console.Write("Input your Student ID: ");
            StudentID = Console.ReadLine();
        }
        // SHOW BOOK
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
        // MAKE BORROWING
        public void MakeBorrowing(List<Book> books, List<GoldenEditionBook> goldenEditionBooks, List<Student> students, List<Borrowing> borrowings)
        {
            try
            {
                // Take student info
                Console.WriteLine("Input your infor to borrow book: ");
                Student student = new Student();
                student.InputInfo();               

                // Take borrowing info
                Random rnd = new Random(); Borrowing borrowing = new Borrowing(); string Numrd_str = rnd.Next(100, 999).ToString();
                borrowing.BorrowID = "B0" + Numrd_str;
                Console.Write("Input the number of books you want to borrow: ");
                borrowing.Quantity = int.Parse(Console.ReadLine()); borrowing.StartDate = DateTime.Now; borrowing.DueDate = borrowing.StartDate.AddDays(7);
                borrowing = new Borrowing(borrowing.BorrowID, borrowing.Quantity, borrowing.StartDate, borrowing.DueDate, student);
                borrowings.Add(borrowing);

                for (int i = 0; i < borrowing.Quantity; i++)
                {
                    Console.Write("Enter the TITLE of book you are looking for: ");
                    string title = Console.ReadLine();
                    for (int j = 0; j < books.Count; j++)
                    {
                        if (books[j].Title.Equals(title)){ Console.WriteLine($"Making borrowing {books[j].Title} book successfully");
                            break; }
                        else
                        {
                            for (int k = 0; k < goldenEditionBooks.Count; k++)
                            {
                                if (goldenEditionBooks[k].Title.Equals(title)) {
                                    Console.WriteLine($"Making borrowing {goldenEditionBooks[k].Title} book successfully");
                                    break; }
                                else { Console.WriteLine("Invalid book!"); }
                            }
                        }
                    }
                }
                Console.WriteLine("===== Your borrowing information =====");
                Console.WriteLine($"Your Borrow ID: {borrowing.BorrowID}");
                Console.WriteLine($"Quantity: {borrowing.Quantity}");
                Console.WriteLine($"You can borrow books for 7 days from today {borrowing.StartDate} to {borrowing.DueDate}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error info: " + ex.Message);
            }
        }
    }
}
