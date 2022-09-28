namespace Lesson08.BookStruct
{
    public struct Book
    {
        public string name;
        public string id;
        public string locadId;

        public Book(string name, string id)
        {
            this.name = name;
            this.id = id;
            this.locadId = this.name + "_" + this.id;
        }
    }
}