namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneralUser generalUser = new("Tomas");
            MessengerUser messengerUser = new("Eirik", "Superdude");

            generalUser.Contact();
            messengerUser.Contact();


            //Console.WriteLine($"{generalUser.Name}");
        }
    }
}
