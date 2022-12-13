namespace EF_Core_Example
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Category()
        {

        }

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Books = new List<Book>();
        }
    }
}
