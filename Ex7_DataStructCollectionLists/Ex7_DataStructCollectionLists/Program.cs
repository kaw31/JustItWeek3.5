using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_DataStructCollectionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToAdd;
           

            List<string> myBooks = new List<string>() { "Silence of the Lambs", "The Shinning", "Harrry Potter", "Game of Thrones" };

            Console.WriteLine("Here is your book collection. To add a book, press A; To exit press X. ");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                if (response == 'A')
                {
                    Console.WriteLine("Type the name of the book you would like to add:");
                    bookToAdd = Console.ReadLine();
                    myBooks.Add(bookToAdd);
                }
                Console.WriteLine("What would you like to do next: A or X?");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while (response != 'X');

           
            foreach(string title in myBooks)
            {
                Console.WriteLine(title);
            }
            
        }
    }
}
