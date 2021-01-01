using System;

namespace mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string age = "";
            string height = "";
            string weight = "";
            string name = "";

            // Global variables are declared

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            bool ageCorrect = false;
            while (ageCorrect == false)
            {
                try
                {
                    Console.Write($"Enter your age: {age}");
                    age = Console.ReadLine();
                    int ageConvert = Convert.ToInt32(age);
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
                    Console.Write($"Enter your height: {height}");
                    height = Console.ReadLine();
                    int heightConvert = Convert.ToInt32(height);
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
                    Console.Write($"Enter your weight: {weight}");
                    weight = Console.ReadLine();
                    int weightConvert = Convert.ToInt32(weight);
                    weightCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Please use Integer, not String!");
                }
            }

            string residenceAddress = "";
            Console.Write("Enter your place of residence: ");
            residenceAddress = Console.ReadLine();

            Console.WriteLine();

            // All data is assigned to its own variables. Ready to withdraw 

            Console.WriteLine("========= INFORMATION ABOUT YOU =========");

            Console.WriteLine($"1. Name: {name}");
            Console.WriteLine($"2. Age: {age}");
            Console.WriteLine($"3. Height: {height}");
            Console.WriteLine($"4. Weight: {weight}");
            Console.WriteLine($"5. Residence Address: {residenceAddress}");

            Console.WriteLine("=========================================");

        }
    }
}
