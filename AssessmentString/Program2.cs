using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    //Write a program to find first occurrence of a character in a given string.

    internal class Program2
    {
        static void Main(string[] args)
        {
            string str = "Do whatever is good for everyone";

            int index1 =str.IndexOf('g');

            Console.WriteLine("The Index value of character 'g' is "+index1);

            int index2 = str.IndexOf('c');

            Console.WriteLine("The Index value of character 'c' is" + index2);

            Console.ReadLine();
        }
       
    }
}
