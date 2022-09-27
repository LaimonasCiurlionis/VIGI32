// See https://aka.ms/new-console-template for more information
using BooksLibrary;
using Topic_7_Structs_UnitTests;

#region Basic Structs

Book harryPotter;
harryPotter.author = "Rowling";
harryPotter.title = "Harry potter";
harryPotter.id = 1;
harryPotter.pages = 600;

Book lordOfTheRings = new Book("Lord of the Rings", "Tolkien", 2, 540);

Console.WriteLine($"An author of {harryPotter.title} is {harryPotter.author}. And an author of {lordOfTheRings.title} is {lordOfTheRings.author}");

lordOfTheRings.PrintTitle();

Book t = harryPotter;

t.author = "Some other name";
harryPotter.author = "Changed name";
Console.WriteLine(harryPotter.author);
Console.WriteLine(t.author);

#endregion

List<Voter> result_6 = Exercise_6();

List<Voter> Exercise_6()
{
    List<Voter> voters = new List<Voter>();
    Random rnd = new Random();

    for (int i = 1; i <= 10; i++)
    {
        var isVotedValue = rnd.Next(2) == 0 ? false : true;
        Voter voter = new Voter(i, isVotedValue);
        voters.Add(voter);
    }

    return voters;
}


Animal animal1 = new Animal("CAT1", "CAT");
Animal animal2 = new Animal("CAT2", "CAT");
Animal animal3 = new Animal("CAT3", "CAT");
Animal animal4 = new Animal("FISH1", "FISH");
Animal animal5 = new Animal("FISH2", "FISH");
Animal animal6 = new Animal("BIRD1", "BIRD");

//1
List<Animal> animals = new List<Animal>();
animals.Add(animal1);
animals.Add(animal2);
animals.Add(animal3);
animals.Add(animal4);
animals.Add(animal5);
animals.Add(animal6);

//2
List<Animal> animals2 = new List<Animal> { animal1, animal2, animal3, animal4, animal5, animal6 };

//3
List<Animal> animals3 = new List<Animal>
{
    new Animal("CAT1", "CAT"),
    new Animal("CAT2", "CAT"),
    new Animal("CAT3", "CAT"),
    new Animal("FISH1", "FISH"),
    new Animal("FISH2", "FISH"),
    new Animal("BIRD1", "BIRD"),
};

Zoo zoo = new Zoo("MyZoo3000", "Some_Address", animals3);

int animalCount = zoo.GetAnimalCount();
int fishCount = zoo.GetFishCount();

var animalCountByType = zoo.GetAnimalCountByType();

Console.WriteLine(animalCountByType.birdCount);
Console.WriteLine(animalCountByType.catCount);
Console.WriteLine(animalCountByType.fishCount);

//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
var result = zoo.animals
    .GroupBy(x => x.type)
    .Select(x => new
    {
        Type = x.Key,
        Count = x.Count()
    })
    .ToList();

Console.WriteLine();
































