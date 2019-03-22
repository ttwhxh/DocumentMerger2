using System;
using System.IO;

namespace DocumentMerger2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 3)
            {
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
                System.Environment.Exit(1);
            }

            string[] inputs = new string[args.Length - 1];
            Array.Copy(args, 0, inputs, 0, args.Length - 1);
            var output = args[args.Length - 1];

            string outputfile = "output.txt";
            try 
            {
                for (int i = 0; i < args.Length - 1; i++)
                {
                    string value = args[i];
                   string file = System.IO.File.ReadAllText(args[i]);
                    Console.WriteLine("for: {0}", value);
                    
                }

                StreamWriter sw = new StreamWriter(outputfile);

              
                File.WriteAllText(outputfile, output);

                int count = output.Length;

                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.\n", output, count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in {0}: {1}", outputfile, e.Message);

            }
        }
    }
}


