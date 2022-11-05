using System;
using System.Collections.Generic;

namespace ASMLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<Book> books = new List<Book>();
            List<GoldenEditionBook> goldenEditionBooks = new List<GoldenEditionBook>();
            List<Borrowing> borrowings = new List<Borrowing>();
            List<Student> students = new List<Student>();
            Librarian librarian = new Librarian();
            try
            {
                int choose;
                do
                {
                    MainMenu();
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            librarian.InputInfo();
                            LoginAsLibrarian(books, goldenEditionBooks, borrowings);
                            break;
                        case 2:
                            LoginAsStudent(books, goldenEditionBooks, borrowings, students);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Thank for your using!");
                            break;
                        default:
                            Console.WriteLine("Input failed!!");
                            break;
                    }
                } while (choose != 3);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("=====          WELCOME TO GREENWICH LIBRARY       =====");
            Console.WriteLine("==        - Full enjoyment with classic books -      ==");
            Console.WriteLine("==                                                   ==");
            Console.WriteLine("==  1. Log in as a librarian                         ==");
            Console.WriteLine("==                                                   ==");
            Console.WriteLine("==  2. Log in as a student                           ==");
            Console.WriteLine("==                                                   ==");
            Console.WriteLine("==  3. Quit the app.                                 ==");
            Console.WriteLine("==                                                   ==");
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            Console.Write("Please choose your choice: ");
        }
        static void ShowLibrarianMenu()
        {
            Console.WriteLine();
            Console.WriteLine("======= LIBRARIAN MENU ========");
            Console.WriteLine("====  1. Add new books.    ====");
            Console.WriteLine("====  2. View all books.   ====");
            Console.WriteLine("====  3. Search book.      ====");
            Console.WriteLine("====  4. Edit book(by ID)  ====");
            Console.WriteLine("====  5. Remove book(by ID)====");
            Console.WriteLine("====  6. View Borrowing.   ====");
            Console.WriteLine("====  7. Log out.          ====");
            Console.WriteLine();
            Console.Write("Please choose your choice: ");          
        }
        static void LoginAsLibrarian(List<Book> books, List<GoldenEditionBook> goldenEditionBooks, List<Borrowing> borrowings)
        {

            Librarian librarian = new Librarian();
            Borrowing borrowing = new Borrowing();
            try
            {
                int choose;
                do
                {
                    ShowLibrarianMenu();
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            librarian.AddBook(books, goldenEditionBooks);
                            break;
                        case 2:
                            librarian.ViewBook(books, goldenEditionBooks);
                            break;
                        case 3:
                            librarian.SearchBookByTitle(books, goldenEditionBooks);
                            break;
                        case 4:
                            librarian.EditBook(books, goldenEditionBooks);
                            break;
                        case 5:
                            librarian.RemoveBook(books, goldenEditionBooks);
                            break;
                        case 6:
                            borrowing.ShowBorrowing(borrowings);
                            break;
                        case 7:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("Input failed!!");
                            break;
                    }
                } while (choose != 7);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ShowStudentMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=======  STUDENT MENU  ========");
            Console.WriteLine("====  1. View all books.   ====");
            Console.WriteLine("====  2. Search book.      ====");
            Console.WriteLine("====  3. Make borrowing    ====");
            Console.WriteLine("====  4. Log out.          ====");
            Console.WriteLine();
            Console.Write("Please choose your choice: ");
        }

        static void LoginAsStudent(List<Book> books, List<GoldenEditionBook> goldenEditionBooks, List<Borrowing> borrowings, List<Student> students)
        {
            Student student = new Student();          
            try
            {
                int choose;
                do
                {
                    ShowStudentMenu();
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            student.ViewBook(books, goldenEditionBooks);
                            break;
                        case 2:
                            student.SearchBookByTitle(books, goldenEditionBooks);
                            break;
                        case 3:
                            student.MakeBorrowing(books, goldenEditionBooks, students, borrowings);
                            break;
                        case 4:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("Input failed!!");
                            break;
                    }
                } while (choose != 4);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
