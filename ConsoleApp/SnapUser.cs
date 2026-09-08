using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp
{
    public class SnapUser : GeneralUser
    {
        public string Nickname { get; set; }

        public SnapUser(string name, string nickname = "") : base(name)
        {
            Nickname = nickname;
        }

        public override void Contact()
        {
            Console.WriteLine($"Contacting {Name} with nickname {Nickname} by Snap.");
        }
    }
}
