using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars_OOPS
{
    internal class GenericCollection
    {
        public List<int> numbers = new List<int>();
        public List<string> names = new List<string>();
        public List<Person> persons = new List<Person>(); //hold person objects

        public void AddNumbers(int number)
        {
            numbers.Add(number); //add an integer to number list
        }
        public void AddName(string name)
        {
            names.Add(name); //add a string to name list
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);  //display person object to the list
        }
        public void displayNumbers()
        {
            Console.WriteLine("Numbers in the collection:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void removeNumber(int number)
        {
            if (numbers.Contains(number)) //it checks if the number exists in the list
            {
                numbers.Remove(number); //remove a number from the list
                Console.WriteLine($"Number {number} removed from the collection.");
            }
            else // if the number does not exist in the list
            {
                Console.WriteLine($"Number {number} not found in the collection.");
            }
        }
        public void clearNumbers()
        {
            numbers.Clear(); //clear all numbers from the list
            Console.WriteLine("All numbers cleared from the collection.");
        }

        public void displayNames()
        {
            Console.WriteLine("Names in the collection:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        public void removeName(string name)
        {
            if (names.Contains(name)) //it checks if the name exists in the list
            {
                names.Remove(name); //remove a name from the list
                Console.WriteLine($"Name {name} removed from the collection.");
            }
            else // if the name does not exist in the list
            {
                Console.WriteLine($"Name {name} not found in the collection.");
            }
        }
        public void clearNames()
        {
            names.Clear(); //clear all names from the list
            Console.WriteLine("All names cleared from the collection.");
        }
        public void displayPersons()
        {
            Console.WriteLine("Persons in the collection:");
            foreach (var person in persons)
            {
                person.DisplayDetails(); //call display details method of person class
            }

        }
        public void removePerson(Person person)
        {
            if (persons.Contains(person)) //it checks if the person exists in the list
            {
                persons.Remove(person); //remove a person from the list
                Console.WriteLine($"Person {person.Name} removed from the collection.");
            }
            else // if the person does not exist in the list
            {
                Console.WriteLine($"Person {person.Name} not found in the collection.");
            }
        }
        public void clearPersons()
        {
            persons.Clear(); //clear all persons from the list
            Console.WriteLine("All persons cleared from the collection.");
        }

    }
}
