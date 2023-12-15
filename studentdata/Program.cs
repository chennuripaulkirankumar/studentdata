using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdata
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = "C:/Users/paulk/Documents/.NET simpilearn/projects/project 1.14 sec 6/studentdata/studentdata/Data/students.txt";
              //string fileName = @"C:\Users\paulk\Documents\.NET simpilearn\projects\project 1.14 sec 6\studentdata\studentdata\Data";
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found: " + filePath);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Student Data:");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.ReadLine(); // To keep the console window open
            
        }
    }
}
