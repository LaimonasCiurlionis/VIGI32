using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Page> Pages { get; set; }

        public Book(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Pages = new List<Page>();
        }
    }
}
