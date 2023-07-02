using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    internal class Program10
    {
        //WAP to find longest word in the given sentence

        static void Main(string[] args)
        {
            string str = "Find the longest word.";
            string[] words = str.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            string word = " ";
            int ctr = 0;
            foreach (string s in words)
            {
                if (s.Length > ctr)
                {
                    word= s;
                    ctr =s.Length;
                }
            }
            Console.WriteLine(word);

        }
    }
}
