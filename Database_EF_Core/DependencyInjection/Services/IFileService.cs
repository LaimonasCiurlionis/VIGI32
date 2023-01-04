namespace DependencyInjection.Services
{
    public interface IFileService
    {
        void WriteToFile(string path, string content);
    }
}
