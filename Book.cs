using System;
using System.Collections.Generic;
using System.Text;

namespace ASMLibrary
{
    class Book
    {
        protected string bookID, title, type, author;
        protected decimal price;
        public string BookID { get { return this.bookID; } set { this.bookID = value; } }
        public string Title { get { return this.title; } set { this.title = value; } }
        public string Type { get { return this.type; } set { this.type = value; } }
        public string Author { get { return this.author; } set { this.author = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }

        public Book(string bookID, string title, string type, string author, decimal price)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Type = type;
            this.Author = author;
            this.Price = price;
        }
        public Book() {}
        public void InputBook()
        {
            Console.WriteLine();
            Console.Write("Input the ID of book: ");            
            BookID = Console.ReadLine();

            Console.Write("Input book title: ");
            Title = Console.ReadLine();

            Console.Write("Input type of book: ");
            Type = Console.ReadLine();

            Console.Write("Input author of book: ");
            Author = Console.ReadLine();

            Console.Write("Input price of book: ");
            Price = decimal.Parse(Console.ReadLine());
        }
        public virtual void DisplayBook()
        {
            Console.WriteLine();
            Console.WriteLine("=== Book inforamtion ===");
            Console.WriteLine($"Book ID: {BookID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price}");
        }

    }
    
}
