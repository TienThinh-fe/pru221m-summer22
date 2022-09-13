string[] lines = System.IO.File.ReadAllLines(@"test.txt");

Console.WriteLine("Contents of test.txt = ");
int index = 1;
foreach (string line in lines)
{
    if (index % 2 == 0)
    {
        Console.WriteLine("\t" + line);
        using StreamWriter file = new("output.txt", append: true);
        await file.WriteLineAsync(line);
    }
    index++;
}
