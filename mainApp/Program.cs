using System;

namespace mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0, height = 0, weight = 0;

            // Global variables are declared

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            bool ageCorrect = false;
            while (ageCorrect == false)
            {
                try
                {
                    Console.Write("Enter your age: ");
                    age = Int32.Parse(Console.ReadLine());
                    ageCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Please use Integer, not String!");
                }
            }

            bool heightCorrect = false;
            while (heightCorrect == false)
            {
                try
                {
                    Console.Write("Enter your height: ");
                    height = Int32.Parse(Console.ReadLine());
                    heightCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Please use Integer, not String!");
                }
            }

            bool weightCorrect = false;
            while (weightCorrect == false)
            {
                try
                {
                    Console.Write("Enter your weight: ");
                    weight = Int32.Parse(Console.ReadLine());
                    weightCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Please use Integer, not String!");
                }
            }

            Console.Write("Enter your place of residence: ");
            string residenceAddress = Console.ReadLine();

            Console.WriteLine();

            // All data is assigned to its own variables. Ready to withdraw 

            Console.WriteLine("========= INFORMATION ABOUT YOU =========");

            Console.WriteLine($"1. Name: {name}");
            Console.WriteLine($"2. Age: {age}");
            Console.WriteLine($"3. Height: {height}");
            Console.WriteLine($"4. Weight: {weight}");
            Console.WriteLine($"5. Residence Address: {residenceAddress}");

            Console.WriteLine("=========================================");

            Console.ReadKey();
        }
    }
}
