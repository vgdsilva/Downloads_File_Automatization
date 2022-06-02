// See https://aka.ms/new-console-template for more information

string userName = Environment.UserName;

string source_dir = @$"C:\Users\{userName}\Downloads";
string destination_dir_image = @$"C:\Users\{userName}\Pictures\";
string destination_dir_documents = @$"C:\Users\{userName}\Documents\";

string[] images_extentions = { ".jpg", ".png" };
string[] documents_extentions = { ".doc", ".pdf", ".docx", ".txt", ".xls", ".xlsx"};


Executar();



void Executar()
{
    try
    {
        // Pegar todos arquivos que estão dentro da pasta Downloads
        Console.WriteLine(source_dir);

        var files = from file in Directory.EnumerateFiles(source_dir) select file;
        Console.WriteLine("Files: {0}", files.Count<string>().ToString());
        Console.WriteLine("List of Files Moved:");
        foreach (var file in files)
        {
            string source_file = file.Replace($@"{source_dir}\", " ");
            //Console.WriteLine("{0}", fl);

            CheckImageFiles(file, images_extentions);
            CheckDocumentsFiles(file, documents_extentions);
        }
    }
    catch (Exception)
    {

        throw;
    }
}

void CheckImageFiles(string file, string[] extentions)
{
    for (int i = 0; i < images_extentions.Length; i++)
        if (file.EndsWith(images_extentions[i]))
        {
            string source_file = file.Replace($@"{source_dir}\", " ");
            Console.WriteLine("Moved image file: {0} to Directory: {1}", source_file, destination_dir_image);
            MoveFiles(destination_dir_image, file, source_file);
        }     
}

void CheckDocumentsFiles(string file, string[] extentions)
{
    for (int i = 0; i < extentions.Length; i++)
        if (file.EndsWith(extentions[i]))
        {
            string source_file = file.Replace($@"{source_dir}\", " ");
            Console.WriteLine("Moved Document file: {0} to Directory: {1}", source_file, destination_dir_documents);
            MoveFiles(destination_dir_documents, file, source_file);
        }            
}

/// <summary>
/// Verificar se existe algum arquivo com o mesmo nome na pasta de destino
/// </summary>
void VerifyIfFileExists(string fileName, string dir, string[] extensions)
{
    int contador = 1;
    do
    {
        


    } while (File.Exists(fileName));
}

void VerifyIfDestinationExist(string destination_dir)
{
    if (Directory.Exists(destination_dir))
    {
        Console.WriteLine("Directory Exists");
    }
    else
    {
        Directory.CreateDirectory(destination_dir);
        Console.WriteLine(" Create the Directory");
    }



}

/// <summary>
/// Mover arquivo da pasta para a pasta de destino
/// </summary>
void MoveFiles(string destination, string pathToMove, string fileName)
{
    VerifyIfDestinationExist(destination);

    string moveTo = Path.Combine(destination, fileName);

    File.Move(pathToMove, moveTo);

}
