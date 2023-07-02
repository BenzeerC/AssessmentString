using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    internal class Program3
    {
        //Write a program to count occurrences of a character in given string.

        static void Main(string[] args)
        {
            string str = "Hellotoall";

            Console.WriteLine("String:"+str);

            while (str[0] > 0)
            {
                Console.Write(str[0] + " = ");

                int cal = 0;
                for (int j = 1; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);

                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();


            

        }
    }
}
