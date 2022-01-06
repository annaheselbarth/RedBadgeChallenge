using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RedBadgeChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* 1.Using LINQ complete the following: 
                Given a non - empty list of strings, return a list that contains only unique(non - duplicate) strings.
                Expected input and output
                ["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]
            */


            var words = new List<string> { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst", };
            var uniqueWord = words
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .ToList();

            foreach (var word in uniqueWord)
            {
                Console.WriteLine(word);
            }


            Console.WriteLine("----------------------");


            /*
                2.Using RegEx complete the following:
                Given a string, write a method that checks if consists of letters only and ends with period.If string has more than one word, words are separated by space.
                Expected input and output
                ("She is nice.") → true
                ("true 222.") → false */


            public static bool IsAlphabets()
            {
                string inputString = "hello.";
                Regex r = new Regex("^[a-zA-Z]+[.]$");
                if (r.IsMatch(inputString))
                    return true;
                else
                    return false;
            }







            /*
                3.Using a built in C# Library (for instance Console is a built in C# library) AND loops complete the following:
                Given a string, write a method that checks if each word in the string starts with lower case and if so, removes this letter from the string.
                Expected input and output
                "Alfa Beta gamma" → "Alfa Beta amma"*/

            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.Write("\n\nReplace lowercase characters by uppercase and vice-versa :\n");
            Console.Write("--------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); // Converts string into char array.

            Console.Write("\nAfter conversion, the string is : ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.ToLower(ch)) // check whether the character is lowercase

                    if (Char.IsLetter(ch))
                        i++;


                    //Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
                    else
                        Console.Write(ch); // Converts uppercase character to lowercase.
            }
            Console.Write("\n\n");


            Console.ReadLine();


            /*
                4.Using LINQ complete the following:
                Write a query that returns dot product of two arrays.
                Expected input and output
                [1, 2, 3], [4, 5, 6] → 32
                [7, -9, 3, -5], [9, 1, 0, -4] → 74
            */
        }
    }
}
