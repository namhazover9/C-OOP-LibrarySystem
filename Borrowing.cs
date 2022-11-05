using System;
using System.Collections.Generic;
using System.Text;

namespace ASMLibrary
{
  
    class Borrowing
    {
        private string borrowID;
        private int quantity;
        private DateTime startDate, dueDate;
        private Student student;

        public string BorrowID { get { return this.borrowID; } set { this.borrowID = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
        public DateTime StartDate { get { return this.startDate; } set { this.startDate = value; } }
        public DateTime DueDate { get { return this.dueDate; } set { this.dueDate = value; } }
        public Student Student { get { return this.student; } set { this.student = value; } }

        public Borrowing(string borrowID, int quantity, DateTime startDate, DateTime dueDate, Student student)
        {
            this.BorrowID = borrowID;
            this.Quantity = quantity;
            this.StartDate = startDate;
            this.DueDate = dueDate;
            this.Student = student;
        }     
        public Borrowing() {}
        public void DisplayBorrowing()
        {
            Console.WriteLine("===== Borrowing information =====");
            Console.WriteLine($"Borrow ID: {BorrowID}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Start Date: {StartDate}");
            Console.WriteLine($"Due Date: {DueDate}");
            Console.WriteLine($"Student ID: {student.StudentID}");
            Console.WriteLine($"Student name: {student.FullName}");
            Console.WriteLine($"Student email: {student.Email}");
            Console.WriteLine("================================");
            Console.WriteLine();
        }
        public void ShowBorrowing(List<Borrowing> borrowings)
        {
            for (int i = 0; i < borrowings.Count; i++)
                borrowings[i].DisplayBorrowing();
        }
    }
}


