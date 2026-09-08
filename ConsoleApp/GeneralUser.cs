using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class GeneralUser
    {
        public string Name { get; set; }

        public GeneralUser(string name)
        {
            Name = name;  
        }

        public void Contact()
        {
            Console.WriteLine($"Contacting {Name} by email.");
        }
    }
}
