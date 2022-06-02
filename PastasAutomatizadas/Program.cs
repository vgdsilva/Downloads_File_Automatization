// See https://aka.ms/new-console-template for more information

string userName = Environment.UserName;

string source_dir = @$"C:\Users\{userName}\Downloads";
string destination_dir_image = @$"C:\Users\{userName}\Pictures";
string destination_dir_documents = @$"C:\Users\{userName}\Documents";

string[] images_extentions = { ".jpg", ".png" };
string[] documents_extentions = { ".doc", ".pdf", ".docx", ".txt", ".xls", ".xlsx"};


Executar();



void Executar()
{
    // Pegar todos arquivos que estão dentro da pasta Downloads
    Console.WriteLine(source_dir);

    var files = from file in Directory.EnumerateFiles(source_dir) select file;
    Console.WriteLine("Files: {0}", files.Count<string>().ToString());
    Console.WriteLine("List of Files");
    
    foreach (var file in files)
    {
        string fl = file.Replace($@"{source_dir}\", " ");
        Console.WriteLine("{0}", fl);
    }



}


/// <summary>
/// Verificar se existe algum arquivo com o mesmo nome na pasta de destino
/// </summary>
bool VerifyIfFileExists(string fileName, string dir)
{
    if (System.IO.File.Exists(fileName))
    {
        return true;
    }
    else
    {
        return false;
    }
}

/// <summary>
/// Mover arquivo da pasta para a pasta de destino
/// </summary>
void MoveFiles(string destination, string entry, string name)
{

}
