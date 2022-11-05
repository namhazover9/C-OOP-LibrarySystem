using System;
using System.Collections.Generic;
using System.Text;

namespace ASMLibrary
{
    class Person
    {
        protected string fullName, email;
        public string FullName { get { return this.fullName; } set { this.fullName = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }

        public Person(string fullName, string email)
        {
            this.FullName = fullName;
            this.Email = email;
        }
        public Person() { }
        public void InputInfo()
        {
            Console.Write("Input your full name: ");
            FullName = Console.ReadLine();

            Console.Write("Input your email: ");
            Email = Console.ReadLine();
        }       
    }
    interface IBook
    {
        void ViewBook(List<Book> books, List<GoldenEditionBook> goldenEditionBooks);
        void SearchBookByTitle(List<Book> books, List<GoldenEditionBook> goldenEditionBooks);
    }

}
