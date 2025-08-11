using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars_OOPS
{
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }


        // Default constructor
        public Person()
        {
            Id = 0;
            Name = null;
            Email = null;
        }
        public Person(int id, string? name, string? email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        //display details
        public void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");

        }
        public string GetPersonInfo()
        {
            return $"ID: {Id}, Name: {Name}, Email: {Email}";
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}";
        }

    }
}
