// See https://aka.ms/new-console-template for more information
using BooksLibrary;

Book harryPotter;

harryPotter.author = "Rowling";
harryPotter.title = "Harry potter";
harryPotter.id = 1;
harryPotter.pages = 600;

Book lordOfTheRings = new Book("Lord of the Rings", "Tolkien", 2, 540);

Console.WriteLine($"An author of {harryPotter.title} is {harryPotter.author}. And an author of {lordOfTheRings.title} is {lordOfTheRings.author}");

lordOfTheRings.PrintTitle();

