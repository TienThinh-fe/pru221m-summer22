while (true)
{
    try
    {
        Console.Write("Enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Format error");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Overflow error");
    }
    finally
    {
        Console.WriteLine("FINALLY");
    }
}