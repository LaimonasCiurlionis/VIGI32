//CALLING GENERIC METHOD
using Topic_1_Generics;

ShowItem<string>("name");
ShowItem<int>(10);
ShowItem<Human>(new Human { Name = "John", Age = 30 });

//GETTING INFORMATION ABOUT THE TYPE
GetType<string>("name");
GetType<int>(5);
GetType<Human>(new Human { Name = "John", Age = 30 });

var selfMadeList = new MySelfMadeList<int?>();
var selfMadeListString = new MySelfMadeList<string>();
for (int i = 0; i < 100; i++)
{
    if (i == 50) 
    {
        selfMadeList.AddItem(null);
    }

    selfMadeList.AddItem(i);
}

//2.
Validation.Validate<string>("TEST");
Validation.Validate<string>(null);


void ShowItem<T>(T item) 
{
    Console.WriteLine($"Item: {item}");
}

string GetType<T>(T item) 
{
    var type = item.GetType();
    var type2 = typeof(T);
    return type.Name;
}
