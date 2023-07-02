using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    //Write a program to check whether two strings are anagram or not?

    internal class Program8
    {
        static void Main(string[] args)
        {
            string str1 = "Slient";
            string str2 = "Listen";

            char[] ch1= str1.ToLower().ToCharArray();
            char[] ch2= str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if(val1==val2)
            {
                Console.WriteLine("Both the strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagram");
            }
        }
    }
}
