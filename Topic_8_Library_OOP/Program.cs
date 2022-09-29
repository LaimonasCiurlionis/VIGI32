using Lesson08.BookStruct;
using Topic_8_Library_OOP;

#region Example

Console.WriteLine("Hello, World!");

Book book = new Book("Tomas", "1");

Console.WriteLine(book.locadId);

Saskaita saskaita = new Saskaita("Tomas", "Nerijus", 60);

Console.WriteLine(saskaita.GautiSaskaitosNumeri());

Example example = new Example(50);
int result = example.GetWeight();

ExampleProperty exampleProperty = new ExampleProperty();
exampleProperty.Weight = 50;
int result2 = exampleProperty.Weight;

ExamplePropertyRaw examplePropertyRaw = new ExamplePropertyRaw();
examplePropertyRaw.Weight = 150;
int result3 = examplePropertyRaw.Weight;

#endregion