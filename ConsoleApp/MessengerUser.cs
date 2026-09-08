using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class MessengerUser : GeneralUser
    {
        public string GamerTag { get; set; }

        public MessengerUser(string name, string gamerTag = "") : base(name)
        {
            GamerTag = gamerTag;
        }

        public override void Contact()
        {
            Console.WriteLine($"Contacting {Name} with tag {GamerTag} by messenger.");
        }
    }
}
