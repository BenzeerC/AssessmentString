using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    //Write a program to find first occurrence of a word in a given string.
    internal class Program6
    {
        public static object Max_Size { get; private set; }

        static void Main(string[] args)
        {
            string str, word;
            int i, index, found = 0;

            //input string and word from user
            Console.WriteLine("Enter any string:");
            str = Console.ReadLine();
            Console.WriteLine("Enter any word:");
            word = Console.ReadLine();

            //Run a loop start to end of string
            index = 0;
            while (str[index]!='\0')
            {
                if (str[index] == word[0])//If first character of word matches with the given string 
                {
                    i = 0;    //Match entire word with current found index
                    found = 1;

                    while (i < word.Length) 
                    {
                        if (str[index + i] != word[i])
                        {
                            found = 0;
                            break;
                        }
                        i++;
                    }

                }

                //If the word is found then get out of loop
                if(found==1)
                {
                    break;
                }

                index++;
            }

            //Print success message if the word is found
            if (found==1)
            {
                Console.WriteLine($"{word} :is found at index {index}");

            }
            else
            {
                Console.WriteLine($"{word}:is not found");
            }


            Console.ReadLine();









        }
    }
}
