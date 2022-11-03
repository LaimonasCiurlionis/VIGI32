namespace Topic_9_Classes_OOP.Inheritance
{
    public class Cat : Animal
    {
        public int Life { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Miau!");
        }
    }
}
