using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    //Write a program to count total number of words in a string.

    internal class Program5
    {
        static void Main(string[] args)
        {
            int a = 0, MyWord = 1;
            
            string str = "Benzeer Altaf Chaus";

            while(a<=str.Length-1)
            {
                if (str[a]==' ' || str[a]==' ' || str[a]=='\t') 
                {
                    MyWord++;
                }
                a++;
            }
            Console.WriteLine("Number of words in the string={0}",MyWord);

        }
    }
}
