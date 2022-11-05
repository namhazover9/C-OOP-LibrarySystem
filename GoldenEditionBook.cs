using System;
using System.Collections.Generic;
using System.Text;

namespace ASMLibrary
{
    class GoldenEditionBook : Book
    {
        private string limitBorrow, specialThings;
        public string LimitBorrow { get { return this.limitBorrow; } set { this.limitBorrow = value; } }
        public string SpecialThings { get { return this.specialThings; } set { this.specialThings = value; } }

        public GoldenEditionBook(string bookID, string title, string type, string author, decimal price) : base(bookID, title, type, author, price)
        {
        }
        public GoldenEditionBook(string bookID, string title, string type, string author, decimal price, string limitBorrow, string specialThings) : this(bookID, title, type, author, price)
        {
            this.LimitBorrow = limitBorrow;
            this.SpecialThings = specialThings;
        }
        public GoldenEditionBook() { }
        public new void InputBook()
        {
            base.InputBook();
            Console.Write("Input the limit of book: ");
            LimitBorrow = Console.ReadLine();

            Console.Write("Input the specials of book: ");
            SpecialThings = Console.ReadLine();
        }
        public override void DisplayBook()
        {
            base.DisplayBook();
            Console.WriteLine("-- The book has Golden Edition --");
            Console.WriteLine($"Golden Price: {base.Price * (decimal)1.3}");
            Console.WriteLine($"The Limit: {LimitBorrow}");
            Console.WriteLine($"The Specials: {SpecialThings}");
            Console.WriteLine("---------------------------------");
        }
    }
}
