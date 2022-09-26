using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary
{
    public struct Book
    {
        public string title = "Bible"; // Default value
        public string author;
        public int id;
        public int pages;

        public Book(string title, string author, int id, int pages)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.pages = pages;
        }

        public void PrintTitle()
        {
            Console.WriteLine(title);
        }
    }
}
