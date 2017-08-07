using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7._2_DataStructCollectionListsRemoveNSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToAdd = "";
            string bookToRemove = "";


            List<string> myBooks = new List<string>() { "Silence of the Lambs", "The Shinning", "Harrry Potter", "Game of Thrones" };

            Console.WriteLine("Here is your book collection. To add a book, press A, To exit press X, To delete press D,  list press L, to sort press S. ");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
               
                Console.WriteLine("What would you like to do next: A, X, D, L or X?");
                response = Convert.ToChar(Console.ReadLine().ToUpper());

                switch(response)
                {
                    case 'a':
                        Console.WriteLine("Please enter book title to be added");
                        bookToAdd = Console.ReadLine();
                        myBooks.Add(bookToAdd);
                        break;
                    case 'd':
                        Console.WriteLine("Please enter book title to delete");
                        bookToRemove = Console.ReadLine();
                        if(myBooks.Remove(bookToAdd))
                        {
                            myBooks.Remove(bookToAdd);
                            Console.WriteLine(bookToRemove + " has been removed.");
                        }
                }


            } while (response != 'X');

                foreach (string title in myBooks)
                {
                    Console.WriteLine(title);
                }

            Console.WriteLine();

            myBooks.ForEach(Console.WriteLine);

        }
    }
}
