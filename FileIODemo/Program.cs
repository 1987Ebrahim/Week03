using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //STEP I

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteFile("test.txt");
            ReadFile("test.txt");
        }
        static void ReadFile (string filename)
        {
            //STEP II - create the object to read a file
            TextReader reader = new StreamReader(filename);
            //STEP III - read a line
            string line = reader.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            //STEP IV - Close the file
            reader.Close();
        }

        static void WriteFile(string filename)
        {
            //STEP II - create the object to write a file
            TextWriter writer = new StreamWriter(filename);
            //STEP III - perform some writing
            for (int i = 1; i <= 10; i++)
            {
                writer.WriteLine($"{i} x 12 = {i * 12}");
            }
            //STEP IV - close the file
            writer.Close();
        }
    }
}
