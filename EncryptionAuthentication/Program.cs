using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

namespace EncryptionAuthentication
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            Menu(users);
        }
        static void Menu(Dictionary<string, string> users)
        {
            Console.WriteLine("\nSelect an option(1/2/3)\n\t1:Enter New User\t2:Authenticate Existing User\t3.Exit Application");
            var newUser = Console.ReadKey(false);
            switch (newUser.Key)
            {
                case ConsoleKey.D1:
                    CreateAccount(users);
                    Menu(users);
                    break;
                case ConsoleKey.D2:
                    if (users.Count == 0)
                    {
                        Console.WriteLine("\n\tNo Current Users!");
                        Menu(users);
                    }
                    AuthenticateAccount(users);
                    Menu(users);
                    break;
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid option");
                    Menu(users);
                    break;
            }
        }
        static Dictionary<string, string> CreateAccount(Dictionary<string, string> users)
        {
            Console.WriteLine("\n\tEnter a Username:");
            string Username = Console.ReadLine();
            Console.WriteLine("\tEnter a Password:");
            string Password = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                Console.WriteLine("Invalid username or password");
                Menu(users);
            }
            else if (users.ContainsKey(Username))
            {
                Console.WriteLine("\nUsername already in use");
                Menu(users);
            }
            else
            users.Add(Username, Encrypt.Hash(Password));
            Console.WriteLine($"Account Created\tUsername: {Username}\tPassword: {Password}\nEncoded Password {users[Username]}");
            return users;
        }
        static void AuthenticateAccount(Dictionary<string, string> users)
        {
            Console.WriteLine("\n\tEnter your Username:");
            string Username = Console.ReadLine();
            Console.WriteLine("\tEnter your Password:");
            string Password = Console.ReadLine();
            Console.WriteLine(users.ContainsKey(Username) && users[Username] == Encrypt.Hash(Password) ? $"\nAuthentication of {Username} Successful!" : "\nInvalid Username or Password");
            return;
        }
    }

    public class Encrypt
    {
        public static string Hash(string input)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input)); //makes byte array of the hashed input string
            List<string> hashedInput = new List<string>();

            foreach (byte b in bytes)
                hashedInput.Add(b.ToString("X2")); //X2 formats tostring item to hexadecimal
            string hashedFinal = "";
            foreach (string s in hashedInput)
                hashedFinal += s;
            return hashedFinal;
        }
    }
}