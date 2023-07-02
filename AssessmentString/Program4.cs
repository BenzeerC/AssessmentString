using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    //Write a program to trim leading white space characters in a string.
    internal class Program4
    {
        static void Main(string[] args)
        {
            string str1 = "Be";
            string str2 = " nz";
            string str3 = " ee ";
            string str4 = "   r";

            Console.WriteLine("Before:");//Before triming the string
            Console.WriteLine(str1);
            Console.WriteLine(str2);    
            Console.WriteLine(str3);
            Console.WriteLine(str4);


            Console.WriteLine("After:");//After triming the string
            Console.WriteLine(str1.Trim());
            Console.WriteLine(str2.Trim());
            Console.WriteLine(str3.Trim());
            Console.WriteLine(str4.Trim());
        }
    }
}
