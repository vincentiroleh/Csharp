using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: create variables of different data types
            // TODO: initialize with a "default" value

            string firstName;
            string lastName;
            int age;
            string street;
            string city;
            string country;
            DateTime birthDate;

            // TODO: assign some values
            firstName = "Vincent";
            lastName = "Iroleh";
            age = 24;
            street = "7 Chief Ubani Street Eziama";
            city = "Aba";
            country = "Nigeria";
            birthDate = new DateTime(1995, 4, 19);

            // TODO: output to the console window
            // TODO: use simple output with just variable name

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // TODO: use placeholder style
            Console.WriteLine("{0} years old.", age);

            // TODO: use string concatenation 
            Console.WriteLine(street + ", " + city + ", " + country);

            // TODO: use string interpolation
            Console.WriteLine($"Born on {birthDate}. from {firstName} {lastName}");

        }
    }
}
