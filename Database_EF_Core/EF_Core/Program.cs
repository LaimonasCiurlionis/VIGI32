// See https://aka.ms/new-console-template for more information
using EF_Core;
using Microsoft.EntityFrameworkCore;

BookContext context = new BookContext();

// Adding page to DB tab;e
/*Page firstPage = new Page(3, "The story ends...");

context.Pages.Add(firstPage);

context.SaveChanges();*/

// Removing page from table

/*context.Pages.Remove(new Page(new Guid("E12F517A-BE37-4D86-A383-C0AFD55BEEA0")));

context.SaveChanges();*/


/*var book = new Book("Harry Potter");

for (int i = 1; i <= 560; i++)
{
    book.Pages.Add(new Page(i, $"Content of page {i}"));
}

context.Books.Add(book);

context.SaveChanges();*/

// return page by number
/*var page = context.Pages.Where(x => x.Number == 407).FirstOrDefault();

*/

// Remove book with pages
/*var book = context.Books.Where(book => book.Name == "Harry Potter").Include(a => a.Pages).FirstOrDefault();

context.Books.Remove(book);

context.SaveChanges();*/
