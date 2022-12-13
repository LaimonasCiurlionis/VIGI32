namespace EF_Core_Example
{
    public class Book
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public List<Page> Pages { get; set; }
        public List<Category> Categories { get; set; }

        public Book()
        {

        }

        public Book(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Pages = new List<Page>();
            Categories = new List<Category>();
        }
    }
}
