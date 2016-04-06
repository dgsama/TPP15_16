using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TPP.ObjectOriented.Overload {

    /// <summary>
    /// Class that add the word counting functionality to the C# string type, using the extension methods feature.
    /// </summary>
    static class StringExtensionClass {

        /// <summary>
        /// Extension method (note the this keyword in the first parameter)
        /// </summary>
        /// <param name="str">String whose words will be counted</param>
        /// <returns>Number of words</returns>
        static public uint ContarPalabras(this string str) {
            // * Break the string using regular expressions
            var lines = Regex.Split(str, "\r|\n|[.]|[,]|[ ]");
            uint no_of_words = 0;
            foreach (var line in lines)
                // * Discard blank lines and whitespaces
                if (!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line))
                    no_of_words++;
            return no_of_words;
        }

    }


}
