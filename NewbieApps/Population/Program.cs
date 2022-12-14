using System;
using System.Collections.Generic;


namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<string> menPopulation = new List<string>();
            while ( i < 1000)
            { 
            string[] firstName = { "John", "Adam", "Greg", "Vin", "Jahson", "Jake", "Jack", "Harry", "Jacob", "George", "James" };
            string[] lastName = { "Smith", "Jones", "Williams", "Diesel", "Taylor", "Davies", " Evans", "Thomas", "Johnson", "Roberts", "Wood" };

            Random rand = new Random();
       `     string randomFirstName = firstName[rand.Next(firstName.Length)];
            string randomLastName = lastName[rand.Next(lastName.Length)];
            string fullName = (randomFirstName +" "+ randomLastName);
            
            menPopulation.Add(fullName);
            
                  
            Console.WriteLine(menPopulation[i]);
            i++;
            }
         

        }  
    }
}
