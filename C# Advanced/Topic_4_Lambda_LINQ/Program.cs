// See https://aka.ms/new-console-template for more information
using Topic_4_Lambda_LINQ;


var integers = new List<int>() { 1, 2, 3, 4 };

Console.WriteLine("Where(x => x > 3) - Elements bigger than 3");
var integersBiggerThanThree = integers.Where(x => x > 3);
foreach (var item in integersBiggerThanThree)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("Select(x => x * 3) - return new values multiplied by 3");
var integersMultipliedByFive = integers.Select(x => x * 3);

foreach (var item in integersMultipliedByFive)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var animals = new List<Animal>()
{
    new Animal() { Name = "Lion", Weight = 400 },
    new Animal() { Name = "Dog", Weight = 10  },
    new Animal() { Name = "Pig", Weight = 100 },
    new Animal() { Name = "Horse", Weight = 500 },
    new Animal() { Name = "Cat", Weight = 5 }
};

Console.WriteLine("OrderBy(x => x.Name) - orders animals by weight");
var orderedAnimals = animals.OrderByDescending(x => x.Weight);

foreach (var item in orderedAnimals)
{
    Console.WriteLine($"{item.Name} weights {item.Weight} kg");
}
Console.WriteLine();


Console.WriteLine("Where(x => x.Weight > 20) - returns animals which weight more than 20");
var animalWeightMoreThan20 = animals.Where(x => x.Weight > 20);

foreach (var animal in animalWeightMoreThan20)
{
    Console.WriteLine(animal.Name);
}
Console.WriteLine();

var animalsInPoundsOrderedByWeightWhereNameEndsByGLetter = animals
    .Select(x => new Animal() { Name = x.Name, Weight = x.Weight * 2 })
    .Where(x => x.Name.EndsWith('g'))
    .OrderBy(x => x.Weight);

foreach (var item in animalsInPoundsOrderedByWeightWhereNameEndsByGLetter)
{
    Console.WriteLine($"{item.Name} weights {item.Weight} pounds");
}
Console.WriteLine();

Console.WriteLine("people.SelectMany(p => p.Dogs) - all dogs from the people");
var person2 = new Person() { Name = "Laima", Dogs = new List<Dog>() };
person2.Dogs.Add(new Dog() { Name = "Cikas" });
var simas = new Person() { Name = "Simas", Dogs = new List<Dog>() { new Dog() { Name = "Bethovenas" }, new Dog() { Name = "Grikis" }, new Dog() { Name = "Simba" } } };

var people = new List<Person>() { new Person() { Name = "Tadas", Dogs = new List<Dog>() { new Dog { Name = "Amsis" }, new Dog { Name = "Amse" } } }, person2, simas };

var allDogs = people.SelectMany(p => p.Dogs);

foreach (var dog in allDogs)
{
    Console.WriteLine(dog.Name);
}











