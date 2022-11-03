namespace Topic_9_Classes_OOP.Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayMyName() 
        {
            Console.WriteLine($"Hello, my name is: {Name}");
        }
    }
}
