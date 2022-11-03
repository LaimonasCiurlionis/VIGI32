Console.WriteLine("Enter a number: ");

string userInput = Console.ReadLine();
var x = Convert.ToInt32(userInput);
var x1 = int.Parse(userInput);

//kopijuoti: ctrl + d

//string interpolation
Console.WriteLine("{0}{0}{0}", x);
Console.WriteLine("{0}  {0}", x);
Console.WriteLine("{0}  {0}", x);
Console.WriteLine("{0}  {0}", x);
Console.WriteLine("{0}{0}{0}", x);

string name = "Vardas";
string lastName = "Pavarde";

//Old version
Console.WriteLine("My name is {0} and my lastname is {1}", name, lastName);

//New version
Console.WriteLine($"My name is {name} and my lastname is {lastName}");

//------------------VARIABLES----------------------------------

//Varaibles init
int yearOfBirth;
string firstName;

//Variables init and value assign
string lastName2 = "Pavardenis";

//decimal suffix M
decimal money = 1999.9m;
float num = 1999.9f;

DateTime lastPayDay = DateTime.Now;
DateTime date = new DateTime(2022, 01, 01, 16, 15, 20);
DateTime decreasedDate = date.AddDays(-5);

//https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
string formattedDate = lastPayDay.ToString("dddd, dd MMMM yyyy");

char y = "Pavardenis"[0];
int ilgis = "Pavardenis".Length;

//------------LOGIC OPERATORS------------------------------------------
bool A = false;
bool B = false;

bool A_OR_B = A || B; //=> FALSE
bool A_AND_B = A && B; //=> FALSE
bool A_NOT = !A; // => TRUE


bool A1 = false;
bool B1 = true;

bool A1_OR_B1 = A1 || B1; //=> TRUE
bool A1_AND_B1 = A1 && B1; //=> FALSE
bool B1_NOT = !B1; //=> FALSE

bool A3 = !(!A1 && (!(A || A1) && (A && B1)));












