using EF_Core_Example;
using Microsoft.IdentityModel.Tokens;
using File = EF_Core_Example.File;

//using var dbContext = new BookContext();
//var book = new Book { Name = "Harry Poter" };
//var book1 = new Book { Name = "Lord of the rings" };

//dbContext.AddRange
//    (
//    new Category { Name = "Adventure", Books = new List<Book> { book } },
//    new Category { Name = "Fantasy", Books = new List<Book> { book, book1 } }
//    );

//dbContext.SaveChanges();

//2. Užduotis
using var dbContext = new BookContext();
var myFolderPath = @"C:\\Users\\laimo\\Desktop\\New folder";
string[] paths = Directory.GetFiles(myFolderPath, "*.*", SearchOption.AllDirectories);

foreach (var path in paths)
{
    var fileInfo = new FileInfo(path);
    string[] directories = path.Split(Path.DirectorySeparatorChar);

    var folderName = directories[directories.Length - 2];
    var folder = dbContext.Folders.FirstOrDefault(x => x.Path == fileInfo.DirectoryName) ?? new Folder { Name = folderName, Path = fileInfo.DirectoryName };

    var fileEntity = new File { Name = fileInfo.Name, Path = fileInfo.FullName, Size = fileInfo.Length };
    folder.Files.Add(fileEntity);

    if (folder.Id == 0) 
    {
        dbContext.Folders.Add(folder);
    }

    dbContext.SaveChanges();
}

Console.WriteLine();
