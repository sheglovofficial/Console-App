using System;

namespace mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("Enter your name(ENG): ");
            name = Console.ReadLine();

            string age = "";
            Console.Write($"Enter your age: {age}");
            age = Console.ReadLine();
            int ageConvert = Convert.ToInt32(age);

            string height = "";
            Console.Write($"Enter your height: {height}");
            height = Console.ReadLine();
            int heightConvert = Convert.ToInt32(height);

            string weight = "";
            Console.Write($"Enter your weight: {weight}");
            weight = Console.ReadLine();
            int weightConvert = Convert.ToInt32(weight);

            string residenceAddress = "";
            Console.Write("Enter your place of residence (ENG): ");
            residenceAddress = Console.ReadLine();
            Console.WriteLine();

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
