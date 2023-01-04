namespace DependencyInjection.Services
{
    public class FileService : IFileService
    {
        public void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
