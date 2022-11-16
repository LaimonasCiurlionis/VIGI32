// See https://aka.ms/new-console-template for more information

using Topic_5_Interfaces;

var pizzaList = new List<IPizza>();

pizzaList.Add(new BestPizza());

var pineapplePizza = new PineapplePizza();

pizzaList.Add(pineapplePizza);

foreach (var pizza in pizzaList)
{
    pizza.Prepare();
}

// IComparer

var bmwList = new List<Bmw>() { new Bmw() { Model = "Chuligange", Color = "Red", TankSize = 40 }, new Bmw() { Model = "X5", Color = "Green", TankSize = 70 }, new Bmw() { Model = "X6", Color = "Black", TankSize = 70 } };

bmwList.Sort(new BmwComparer());

foreach (var item in bmwList)
{
    Console.WriteLine($"{item.Color} {item.Model} {item.TankSize}");
}

// Abstract class

var dog = new Dog();
dog.Run();
dog.Sleep();

var jonas = new Jonas();

jonas.GetBody();
jonas.GetCharacter();