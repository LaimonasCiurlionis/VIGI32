namespace Topic_9_Classes_OOP.Inheritance
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public void MakeSound() 
        {
            Console.WriteLine("AU!");
        }
    }
}
