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
    Console.WriteLine(source_dir);

}


void MoveFiles(string destination, string entry, string name)
{

}
