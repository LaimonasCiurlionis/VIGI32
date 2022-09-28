// See https://aka.ms/new-console-template for more information
using Lesson08.BookStruct;

Console.WriteLine("Hello, World!");

Book book = new Book("Tomas", "1");

Console.WriteLine(book.locadId);

Saskaita saskaita = new Saskaita("Tomas", "Nerijus", 60);

Console.WriteLine(saskaita.GautiSaskaitosNumeri());
