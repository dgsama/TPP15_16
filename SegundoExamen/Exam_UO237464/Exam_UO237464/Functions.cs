using System;
using System.Collections;

namespace LabExam2
{
    static class Functions
    {
        /*string extension methods to calculate the amount of characters of a certain type that are inside of an string*/

        public static int NumOfUpperCaseLetters(this string str)
        {
            int num = 0;

            foreach (var c in str)
                if (char.IsUpper(c)) num++;

            return num;
        }

        public static int NumOfLowerCaseLetters(this string str)
        {
            int num = 0;

            foreach (var c in str)
                if (char.IsLower(c)) num++;

            return num;
        }

        public static int NumOfDigits(this string str)
        {
            int num = 0;

            foreach (var c in str)
                if (char.IsDigit(c)) num++;

            return num;
        }

        public static int NumOfSpecialCharacters(this string str)
        {
            return str.Length - NumOfUpperCaseLetters(str) - NumOfLowerCaseLetters(str) - NumOfDigits(str);
        }



        /*      Data structure printing functions */

        public static void PrintDictionary(IDictionary dic)
        {
            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + ": " + dic[key]);
            }
        }

        public static void PrintEnumerable(IEnumerable enumerable)
        {
            Console.Write("[");
            foreach (var element in enumerable)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
