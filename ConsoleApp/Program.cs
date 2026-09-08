namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneralUser person = new("Tomas");

            Console.WriteLine($"{person.Name}");
        }
    }
}
