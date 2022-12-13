using EF_Core_Example;

using var dbContext = new BookContext();
var book = new Book { Name = "Harry Poter" };
var book1 = new Book { Name = "Lord of the rings" };

dbContext.AddRange
    (
    new Category { Name = "Adventure", Books = new List<Book> { book } },
    new Category { Name = "Fantasy", Books = new List<Book> { book, book1 } }
    );


dbContext.SaveChanges();