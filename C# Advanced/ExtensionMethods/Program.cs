// See https://aka.ms/new-console-template for more information


using ExtensionMethods;

int integer = 10;

var decreasedNumber = integer.DecreaseByInteger(100, "Labas");

Console.WriteLine(decreasedNumber);

new List<int> { 1, 2, 3, 3, 3, 3 }.RemoveDigitAndPrintRemainingDigits(3);

var ferrari = new Car { Model = "Ferrari" };

Car mercedes = new Car();
mercedes.Model = "Mercedes";

var carList = new List<Car> { ferrari, mercedes };
var carList2 = new List<Car> { new Car { Model = "Audi" }, mercedes, new Car { Model = "Toyota" } };

mercedes.PrintCarModel();

