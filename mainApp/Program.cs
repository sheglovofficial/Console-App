using System;
using System.IO;
using System.Threading;

namespace mainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string path = @"C:\Programming\Console-App\mainApp\info.txt"; // File creation path (you can specify your own)
            int age = 0, height = 0, weight = 0;

            // Global variables are declared

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t==============================================");
            Console.Write("\n\t\t\t\t\tEnter your name: ");
            name = Console.ReadLine();      // Username input

            bool ageCorrect = false;
            while (ageCorrect == false)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter your age: ");
                    age = Int32.Parse(Console.ReadLine());     // Age input
                    ageCorrect = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\tERROR: Please use Integer, not String!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            bool heightCorrect = false;
            while (heightCorrect == false)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter your height: ");
                    height = Int32.Parse(Console.ReadLine());       // Height input
                    heightCorrect = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\tERROR: Please use Integer, not String!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            bool weightCorrect = false;
            while (weightCorrect == false)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\t\t\t\t\tEnter your weight: ");
                    weight = Int32.Parse(Console.ReadLine());       // Weight input
                    weightCorrect = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\tERROR: Please use Integer, not String!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t\t\t\t\tEnter your place of residence: ");
            string residenceAddress = Console.ReadLine();       // Residence Address input

            Console.WriteLine("\n\t\t\t\t==============================================");

            Console.WriteLine();


            Console.WriteLine("\t\t\t\t\tFile recording starts!\n");

            for (int i = 0; i < 1; i++)
            {
                Console.Write("\t\t\t\t\tLoading [######");
                Thread.Sleep(1000);
                Console.Write("###");
                Thread.Sleep(1000);
                Console.Write("####");
                Thread.Sleep(1000);
                Console.Write("######");
                Thread.Sleep(1000);
                Console.WriteLine("#######] - 100%\n");
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\t\t\tRecording completed!\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\t\t\t\t\tPress the Enter key to close the program");

            Console.ReadKey();

            string[] infoUser = new string[] { "========= INFORMATION ABOUT YOU =========\n",
                                            $"\t1. Name: {name}",
                                            $"\t2. Age: {age}",
                                            $"\t3. Height: {height}",
                                            $"\t4. Weight: {weight}",
                                            $"\t5. Residence Address: {residenceAddress}\n",
                                            "========================================="};

            File.WriteAllLines(path, infoUser);
        }
    }
}
