using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ErrorHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values1 = { 2, 4, 6, 8, 10, 12 };
            int[] values2 = new int[6];

            

            try
            {
                for (int i = 0; i <= values1.Length; i++)
                {
                    Console.WriteLine("Result" + values1[i]);
                }
                
            }
            catch (IndexOutOfRangeException n)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("The end");
        }
    }
}
