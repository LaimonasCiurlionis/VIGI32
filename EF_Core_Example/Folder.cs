namespace EF_Core_Example
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public List<File> Files { get; set; }
        public Folder()
        {
            Files = new List<File>();
        }
    }
}
