using System;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstName = { "John", "Adam", "Greg", "Vin", "Jahson", "Jake", " Jack", "Harry", "Jacob", "George", "James" };
            string[] lastName = { "Smith", "Jones", "Williams", "Diesel", "Taylor", "Davies", " Evans", "Thomas", "Johnson", "Roberts", "Wood" };

            Random rand = new Random();
            string randomFirstName = firstName[rand.Next(firstName.Length)];
            string randomLastName = lastName[rand.Next(lastName.Length)];

            Console.WriteLine("Your random name " + randomFirstName + " " + randomLastName);
        }
    }
}
