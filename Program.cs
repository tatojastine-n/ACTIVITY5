using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAreYouReally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            string name = "";
            int age = 0;
            float height = 0f;
            bool isValid;

            //get name input 
            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                isValid = !
                    string.IsNullOrEmpty(name);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid name: ");
                }
            } while (!isValid);

            //get age input
            do
            {
                Console.Write("Enter your age: ");
                string ageInput = Console.ReadLine();
                isValid = int.TryParse(ageInput, out age) && age > 0 && age <= 120;
                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid age between 1 and 120.");
                }
            } while (!isValid);

            //get height input
            do
            {
                Console.Write("Enter your height: ");
                string heightInput = Console.ReadLine();
                isValid = float.TryParse(heightInput, out height) && height > 0 && height <= 9;
                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid height between 0 and 9 ft.");
                }
            } while (!isValid);

            //display summary 
            Console.WriteLine($"\nSummary: Name: {name}, Age: {age}, Height: {height:F1}");
        }
    }
}
