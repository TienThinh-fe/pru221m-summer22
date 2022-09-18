namespace Exercise4
{
    public class Program
    {
        public static void Main()
        {
            Kid kid = new Kid();
            kid.PrintMessage();

            Console.WriteLine();

            Artistic artistic = new Artistic();
            artistic.PrintMessage();

            Console.WriteLine();

            Friendly friendly = new Friendly();
            friendly.PrintMessage();
        }

    }
}
