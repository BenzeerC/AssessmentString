using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    //Write a program to check whether given string is palindrome or not.

    internal class Program7
    {
        static void Main(string[] args)
        {
            string string1, rev;
            string1 = "level";
            char[] ch=string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = string1.Equals(rev,StringComparison.OrdinalIgnoreCase);
            if(b == true)
            {
                Console.WriteLine($"{string1}:IS Palindrome.");
            }
            else
            {
                Console.WriteLine($"{string1}:Is Not Palindrome.");
            }




        }
    }
}
