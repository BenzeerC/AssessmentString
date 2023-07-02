using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and make use of all string functions in it

            string FirstName;
            string LastName;

            FirstName = "Benzeer Chaus";
            LastName = "Chaus";

            Console.WriteLine(FirstName.Clone());//To make string colone.

            Console.WriteLine(FirstName.CompareTo(LastName));//Compare two string value and returns 0 for true and 1 for false

            Console.WriteLine(FirstName.Contains("eer"));// Contains Check whether specified value exists or not in  the string

            Console.WriteLine(FirstName.EndsWith("s"));//EndsWith to check whether specified value is the last character of string
           
            Console.WriteLine(FirstName.Equals(LastName));////Compare two string and returns true and false

            Console.WriteLine(FirstName.GetHashCode());//Returns HashCode(memory) of String
            
            Console.WriteLine(FirstName.GetType());//Returns type of string

            Console.WriteLine(FirstName.GetTypeCode());
            ///Returns type of string

            Console.WriteLine(FirstName.IndexOf("z"));//Returns the first index position of specified value

            Console.WriteLine(FirstName.ToLower());//Covert string into lower case

            Console.WriteLine(FirstName.ToUpper());//Convert string into upper case

            Console.WriteLine(FirstName.Insert(0,"Hello"));// Insert substring into string

            Console.WriteLine(FirstName.IsNormalized());//Check Whether string is in Unicode normalization from C

            Console.WriteLine(FirstName.LastIndexOf("s"));//Returns the last index position of specified value

            Console.WriteLine(FirstName.Length);//Returns the Length of String

            Console.WriteLine(FirstName.Remove(7));
            ///Deletes all the characters from begining to specified index.

            Console.WriteLine(FirstName.Replace("z","j"));//Replace the character

            String[] split = FirstName.Split(new char[] { 'e' });////Split the string based on specified value

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(FirstName.StartsWith("B"));////Check wheter first character of string is same as specified value

            Console.WriteLine(FirstName.Substring(2,5));////Returns substring

            Console.WriteLine(FirstName.ToCharArray());////Converts an string into char array.

            Console.WriteLine(FirstName.Trim());
            //It removes starting and ending white spaces from string.


        }
    }
}
