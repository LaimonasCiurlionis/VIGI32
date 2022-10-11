using Topic_9_Classes_OOP.Entities;
using Topic_9_Classes_OOP.Inheritance;

Customer customer = new Customer();
var customer2 = new Customer("John", "Doe");
var customer3 = new Customer("X", "X", "John.Doe@mail.com");

//Value type
int i1 = 42;
int i2 = i1;
i2 = 5;

// What is i1? => 42

//Reference type
var c1 = new Customer();
c1.FirstName = "John";

var c2 = c1;
var c3 = c1;
c2.FirstName = "Bob";

//What is c1.FirstName? => Bob

//NON STATIC
customer.SayMyFullName("Some Name");

//STATIC
Customer.SayMyFullNameStatic("Some Name");


//INHERITANCE
var animal = new Animal();
animal.SayMyName();

var dog = new Dog();
dog.Color = "RED";

var cat = new Cat();
cat.Age = 5;

var superDog = new SpecificDog();
superDog.SomeSpecificProperty = 1;