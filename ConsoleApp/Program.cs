namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GeneralUser> users = new();

            GeneralUser generalUser = new("Tomas");
            users.Add(generalUser);
            MessengerUser messengerUser = new("Eirik", "Superdude");
            users.Add(messengerUser);
            SnapUser snapUser = new("Ina", "Giggles");
            users.Add(snapUser);

            //generalUser.Contact();
            //messengerUser.Contact();
            //snapUser.Contact();

            foreach (GeneralUser user in users) {
                user.Contact();
            }




            //Console.WriteLine($"{generalUser.Name}");
        }
    }
}
