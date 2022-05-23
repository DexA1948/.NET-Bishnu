public class Program
{
    public static async Task Main()
    {
        // Person p1 = new();
        // p1.Name = "c";

        // var x = p1.Name;
        // var y = p1.Address;

        // //Defining constants
        // const int f = 445;
        // byte g = 45;

        //Asynchronous asynchronous = new Asynchronous();
        //await asynchronous.DownloadText(); 

        FileIO fileIO = new();
        string path = @"C:\Users\I82287\OneDrive - Cotiviti\Documents\vedas.txt";
        fileIO.ReadFileFromDisk(path);   
        fileIO.CreateFileToDisk();    
    }
}