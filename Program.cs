using System;
using System.Collections.Generic;
using System.Collections;

namespace chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Oblong", "Elongated, usually from the square or circular form.");
            wordsAndDefinitions.Add("Persnickety", "Snobbish or having the aloof attitude of a snob.");
            wordsAndDefinitions.Add("Circumvent", "To go around or bypass");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Persnickety"]);
            Console.WriteLine(wordsAndDefinitions["Oblong"]);

/*
    Loop over dictionary to get the following output:
        The definition of [WORD] is [DEFINITION]
        The definition of [WORD] is [DEFINITION]
        The definition of [WORD] is [DEFINITION]
*/
            foreach (KeyValuePair<string, string> dictionaryItem in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {dictionaryItem.Key} is {dictionaryItem.Value}");
            }
        }
    }
}