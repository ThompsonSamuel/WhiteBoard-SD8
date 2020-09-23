using System;
using System.Collections.Generic;
using System.Linq;

namespace MathGames
{
    class Program
    {
        static void Main() 
        {
            int total = 0;
            Menu(total);
        }
        static void Menu(double total)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Math Games");
            Console.WriteLine("\t To add, enter 1: \n\t To subtract, enter 2: \n\t To multiply, enter 3: \n\t To divide, enter 4: \n\t To Exit, eneter 5:");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    total += function(1);
                    Menu(total);
                    break;
                case ConsoleKey.D2:
                    total += function(2);
                    Menu(total);
                    break;
                case ConsoleKey.D3:
                    total += function(3);
                    Menu(total);
                    break;
                case ConsoleKey.D4:
                    total += function(4);
                    Menu(total);
                    break;
                case ConsoleKey.D5:
                    for(int i = 0; i < testR.Count; i++)
                        Console.Write($"Test {i + 1}. {testR[i]}% \t");
                    Console.WriteLine($"\nTotal grade is {Math.Round(total/testR.Count)}%");
                    Console.Write("\n\nPress 'Enter' to return to the menu");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    return;
                default:
                    Menu(total);
                    break;
            }
        }
        static double function(int t)
        {
            string[] typeOfProb = { "Addition", "Subtraction", "Multiplication", "Division" };
            int numberProblems = numProb();
            Console.WriteLine($"You are testing {typeOfProb[t - 1]} and have {numberProblems} problems\nPress any key to begin:");
            Console.ReadKey();
            int count = 0;
            for (int i = 0; i < (int)numberProblems; i++)
            {
                int a = random.Next(1, 50), b = random.Next(1, 50);
                double kind = Kind(a, b, t, out string question);
                Console.Write($"{i + 1}. {question}");
                if(Console.ReadLine() == Math.Round(kind, 2).ToString())
                {
                    Console.WriteLine("Correct.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {Math.Round(kind, 2)}");
                }
            }
            double grade = Math.Round((double)count / numberProblems, 2) * 100;
            Console.WriteLine($"You got {count} out of {numberProblems} correct, your grade is {grade}%");
            testR.Add(grade);
            Console.Write("\nPress 'Enter' to return to the menu");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            return grade;
        }

        static double Kind(int a, int b, int t, out string question)
        {
            switch (t)
            {
                case 1: //addition
                    question = $"{a} + {b} = ";
                    return a + b;
                case 2: //subtraction
                    question = $"{a} - {b} = ";
                    return a - b;
                case 3: //multiplication
                    question = $"{a} * {b} = ";
                    return a * b;
                case 4: //division
                    question = $"{a} / {b} = ";
                    return a / (double)b;
                default:
                    throw new Exception("unkown type of Math");
            }
        }

        static int numProb()
        {
            Console.WriteLine("Enter a number of problems between 1 and 12:");
            List<int> possible = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string num = Console.ReadLine();
            if (!Int32.TryParse(num, out int problems) || !possible.Contains(problems))
            {
                Console.WriteLine("Invalid option");
                numProb();
            }
            return problems;
        }
        static Random random = new Random();
        static List<double> testR = new List<double>();
    }
}
