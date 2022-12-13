using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    public class Page
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public string Content { get; set; }

        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        public Page(int number, string content)
        {
            Id = Guid.NewGuid();
            Number = number;
            Content = content;
        }

        public Page(Guid id)
        {
            Id=id;
        }
    }
}
