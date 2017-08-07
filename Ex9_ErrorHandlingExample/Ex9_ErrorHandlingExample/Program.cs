using System;
using System.IO;


namespace Ex9_ErrorHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"c:\Users\student\Desktop\Kevin\Week3-C#\test.txt");
                Console.WriteLine(sr.ReadToEnd());
            }

            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("and the program continues...");
        } //end main
    } // end class
} // end namespace
