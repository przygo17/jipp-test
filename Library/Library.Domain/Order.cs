using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    public class Order
    {
        public DateTime Date { get; set; }
        public List<BookOrdered> BooksOrderedList { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }

        public override string ToString()
        {
            string str = $"Order: {Date}\n";

            foreach (var item in BooksOrderedList)
            {
                str += $"Book: {item.BookId} Count: {item.NumberOrdered}\n";
            }

            return str;
        }
    }
}