using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace EncryptAndDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter plain test: ");
            string message = Console.ReadLine();
            List<char> ListMessage = new List<char>();
            foreach (char i in message.ToUpper())
            {
                if (char.IsLetter(i))
                    ListMessage.Add(i);
                else
                    continue;
            }
            string singleKeyEn = SingleKeyEncrypt(ListMessage);
            string multiKeyEn = MultiKeyEncrypt(ListMessage);
            string continuousKeyEn = ContinuousKeyEncrypt(ListMessage);

            Console.WriteLine($"\nYou entered [{message}] as plain text");
            Console.WriteLine($"You entered [{singlekey}] as your single key");
            Console.WriteLine($"You entered [{multistringKey}] as your multi key");

            Console.WriteLine($"\nEncrypted message with single key is [{singleKeyEn}]");
            Console.WriteLine($"Encrypted message with multi key is [{multiKeyEn}]");
            Console.WriteLine($"Encrypted message with continuous key is [{continuousKeyEn}]");

            Console.WriteLine($"\nDecrypted message with single key is [{decryptSingle(singleKeyEn)}]");
            Console.WriteLine($"Decrypted message with multi key is [{decryptMulti(multiKeyEn)}]");
            Console.WriteLine($"Decrypted message with continuous key is [{decryptContinuous(continuousKeyEn)}]");
        }

        //encoding methods
        static char singlekey;
        static string SingleKeyEncrypt(List<char> message)
        {
            string encodedSingleKeyMessage = "";
            Console.Write("Enter your single key as an alpha character: ");
            singlekey = Console.ReadKey().KeyChar;
            int key = char.ToUpper(singlekey) - 64;
            if (char.IsLetter(singlekey))
            {
                foreach (char i in message)
                {
                    if (i + key > 90)
                    {
                        int encoded = i + key - 26;
                        encodedSingleKeyMessage += (char)encoded;
                    }
                    else
                    {
                        int encoded = i + key;
                        encodedSingleKeyMessage += (char)encoded;
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid key");
                SingleKeyEncrypt(message);
            }
            return encodedSingleKeyMessage;
        }

        static List<int> multiKey = new List<int>();
        static string multistringKey;
        static string MultiKeyEncrypt(List<char> message)
        {
            string encodedMutliKeyMessage = "";
            Console.Write("\nEnter your multi key as an alpha character: ");
            multistringKey = Console.ReadLine();
            string key = multistringKey.ToUpper();
            foreach (char i in key)
            {
                if (char.IsLetter(i))
                    multiKey.Add(i - 64);
                else
                {
                    Console.WriteLine("Invalid Key");
                    MultiKeyEncrypt(message);
                }
            }
            for (int i = 0, j = 0; i < message.Count; i++, j++)
            {
                if (j < multiKey.Count)
                {
                    if (message[i] + multiKey[j] > 90)
                    {
                        int encoded = message[i] + multiKey[j] - 26;
                        encodedMutliKeyMessage += (char)encoded;
                    }
                    else
                    {
                        int encoded = message[i] + multiKey[j];
                        encodedMutliKeyMessage += (char)encoded;
                    }
                }
                else
                {
                    j = 0;
                    if (message[i] + multiKey[j] > 90)
                    {
                        int encoded = message[i] + multiKey[j] - 26;
                        encodedMutliKeyMessage += (char)encoded;
                    }
                    else
                    {
                        int encoded = message[i] + multiKey[j];
                        encodedMutliKeyMessage += (char)encoded;
                    }
                }
            }
            return encodedMutliKeyMessage;
        }

        static string ContinuousKeyEncrypt(List<char> message)
        {
            string encodedContinuousKeyMessage = "";
            
            for (int i = 0, j = 0, k =0; i < message.Count; i++)
            {
                if (j < multiKey.Count)
                {
                    if (message[i] + multiKey[j] > 90)
                    {
                        int encoded = message[i] + multiKey[j] - 26;
                        encodedContinuousKeyMessage += (char)encoded;
                    }
                    else
                    {
                        int encoded = message[i] + multiKey[j];
                        encodedContinuousKeyMessage += (char)encoded;
                    }
                    j++;
                }
                else
                {
                    if (message[i] + message[k] - 64 > 90)
                    {
                        int encoded = message[i] + message[k] - 26 - 64;
                        encodedContinuousKeyMessage += (char)encoded;
                    }
                    else
                    {
                        int encoded = message[i] + message[k] - 64;
                        encodedContinuousKeyMessage += (char)encoded;
                    }
                    k++;
                }
            }
            return encodedContinuousKeyMessage;
        }

        //decoding methods
        static string decryptSingle(string encodedSingleKeyMessage)
        {
            string decodedMessage = "";
            int key = char.ToUpper(singlekey) - 64;
            foreach (char i in encodedSingleKeyMessage)
            {
                if (i - key + 26 < 90)
                {
                    int decoded = i - key + 26;
                    decodedMessage += (char)decoded;
                }
                else
                {
                    int decoded = i - key;
                    decodedMessage += (char)decoded;
                }
            }
            return decodedMessage;
        }

        static string decryptMulti(string encodedMultiKeyMessage)
        {
            string decodedMessage = "";
            int j = 0;
            foreach (char i in encodedMultiKeyMessage)
            {
                if (j < multiKey.Count)
                {
                    if (i - multiKey[j] + 26 < 90)
                    {
                        int decoded = i - multiKey[j] + 26;
                        decodedMessage += (char)decoded;
                    }
                    else
                    {
                        int decoded = i - multiKey[j];
                        decodedMessage += (char)decoded;
                    }
                }
                else
                {
                    j = 0;
                    if (i - multiKey[j] + 26 < 90)
                    {
                        int decoded = i - multiKey[j] + 26;
                        decodedMessage += (char)decoded;
                    }
                    else
                    {
                        int decoded = i - multiKey[j];
                        decodedMessage += (char)decoded;
                    }
                }
                j++;
            }
            return decodedMessage;
        }

        static string decryptContinuous(string encodedContinuousKeyMessage)
        {
            string decodedMessage = "";
            int j = 0;
            int k = 0;
            foreach (char i in encodedContinuousKeyMessage)
            {
                if (j < multiKey.Count)
                {
                    if (i - multiKey[j] + 26 < 90)
                    {
                        int decoded = i - multiKey[j] + 26;
                        decodedMessage += (char)decoded;
                    }
                    else
                    {
                        int decoded = i - multiKey[j];
                        decodedMessage += (char)decoded;
                    }
                    j++;
                }
                else
                {
                    if (i - decodedMessage.ToCharArray()[k] + 26 + 64 < 90)
                    {
                        int decoded = i - decodedMessage.ToCharArray()[k] + 26 + 64;
                        decodedMessage += (char)decoded;
                    }
                    else
                    {
                        int decoded = i - decodedMessage.ToCharArray()[k] + 64;
                        decodedMessage += (char)decoded;
                    }
                    k++;
                }
            }
            return decodedMessage;
        }
    }
}
