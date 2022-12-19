// See https://aka.ms/new-console-template for more information
using EF_Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

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

/*var books = context.Pages.Select(x => x).Include(x => x.Pages);

foreach (var book in books)
{
    Console.WriteLine(book.Name);
    foreach (var page in book.Pages)
    {
        Console.WriteLine(page.Content);
    }
}*/

using (var conn = new SqlConnection("YOUR_CONNECTION_STRING"))
{
    conn.Open();
    Console.WriteLine("Select page for return");
    var pageToRead = Console.ReadLine();

    SqlCommand command = new SqlCommand($"[dbo].[selectPageByNumber]", conn);

    command.CommandType = CommandType.StoredProcedure;

    command.Parameters.Add(new SqlParameter("number", pageToRead));

    SqlDataReader reader = command.ExecuteReader();

    var pages = new List<Page>();
    while (reader.Read())
    {
        var id = (Guid)reader[0];
        var number = (int)reader[1];
        var content = (string)reader[2];
        var page = new Page(id, number, content);
        pages.Add(page);
    }
    command.Dispose();
    reader.Close();
}




