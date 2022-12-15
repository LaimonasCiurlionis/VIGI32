using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Example
{
    public class File
    {
        public int Id { get; set; }

        [ForeignKey("Folder")]
        public int FolderId { get; set; }
        public Folder Folder { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
    }
}
