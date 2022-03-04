using static System.Console;

WriteLine("File name: ");

var name = ReadLine();
name = ClearName(name);
var path = Path.Combine(Environment.CurrentDirectory, $"{name}.txt");

CreateFile(path);

WriteLine("Press Enter to end...");
ReadLine();

static string ClearName(string name)
{
    foreach (var item in Path.GetInvalidFileNameChars())
    {
        name = name.Replace(item, '-');
    }
    return name;
}
static void CreateFile(string path)
{
    try
    {

        using var sw = File.CreateText(path);
        sw.WriteLine("Line 1");
        sw.WriteLine("Line 2");
        sw.WriteLine("Line 3");
    }

    catch
    {
        WriteLine("Invalid Name!");
    }
}