using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_DataStructDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a dictionary with a string key and string value
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();
            //declare variables for accepting user input
            string answer;
            string result;
            string newKey;
            string newValue;

            //add entries to dictionary
            codingLanguages.Add("C#", "The best programming language in the world");
            codingLanguages.Add("Java", "Named after its inventor's favourite coffee");
            codingLanguages.Add("Scratch", "Cool for kids");

            //prompt user for input and convert it to upper case
            Console.WriteLine("Coding languages dictionary. \n Type K to look for a language, \n D to look for a description, \n L to use a key to look up a value, \n C to count the list, \n P to print the contents, \n A to add an entry, \n R to delete an entry and \n X to exit:");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                switch (response)
                {
                    //look up a key
                    case 'K':
                        Console.WriteLine("Type the language that you want to look for:");
                        answer = Console.ReadLine();
                        if (codingLanguages.ContainsKey(answer))
                        {
                            Console.WriteLine(answer + " is in the dictionary.");
                        }
                        else
                        {
                            Console.WriteLine(answer + " is not in the dictionary.");
                        }
                        break;
                    //look up a description
                    case 'D':
                        Console.WriteLine("Type the description that you want to look for:");
                        answer = Console.ReadLine();
                        if (codingLanguages.ContainsValue(answer))
                        {
                            Console.WriteLine(answer + " is in the dictionary.");
                        }
                        else
                        {
                            Console.WriteLine(answer + " is not in the dictionary.");
                        }
                        break;
                    //count the number of entries in the dictionary
                    case 'C':
                        int totalItems = codingLanguages.Count();
                        Console.WriteLine("There are " + totalItems + " entries in the dictionary.");
                        break;
                    //use a key to look up a description
                    case 'L':
                        Console.WriteLine("Type the name of the coding language that you want to look up:");
                        answer = Console.ReadLine();
                        //look up value using the key
                        if (codingLanguages.TryGetValue(answer, out result))
                        {
                            Console.WriteLine("The key " + answer + " has the value " + result);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the key " + answer + " was not in the dictionary.");
                        }
                        break;
                    case 'P':
                        foreach (KeyValuePair<string, string> entry in codingLanguages)
                        {
                            Console.WriteLine("Key is: {0}\tValue is: {1} ", entry.Key, entry.Value);
                        }
                        Console.WriteLine();
                        break;
                    case 'A':
                        Console.WriteLine("Type the key for your new entry: ");
                        newKey = Console.ReadLine();
                        Console.WriteLine("Type the value for your new entry: ");
                        newValue = Console.ReadLine();
                        codingLanguages.Add(newKey, newValue);
                        break;
                    case 'R':
                        Console.WriteLine("Type the key of the entry you want to delete: ");
                        answer = Console.ReadLine();
                        codingLanguages.Remove(answer);
                        break;
                    default:
                        break;
                }
                //prompt user to make another selection
                Console.WriteLine("Please make another selection: ");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while (response != 'X');  //exit
        }


    }
    }

