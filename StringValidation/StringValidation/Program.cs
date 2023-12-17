using System.Security.Cryptography.X509Certificates;

namespace StringValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");

            string userString = Console.ReadLine();     // User Input

            if (CheckUppercase(userString) && EvenQuotes(userString) && EndOfSentence(userString) && NumberSpellOut(userString) && EndPeriod(userString))
            {
                Console.WriteLine("Valid Sentence! :)");
            }
            else
            {
                Console.WriteLine("Invalid Sentence.. :(");
            }


            static bool CheckUppercase(string upper)
            {
                if (char.IsUpper(upper[0]) == false)        // if first character in string is uppercase
                {
                    Console.WriteLine("Sentence needs to start with capital letter.")
                    return false;
                }

                return true;

            }

            static bool EvenQuotes(string quotes)
            {

                return quotes.Count('"') % 2 == 0;      // count method with " as param


            }

            static bool EndOfSentence(string sentence)
            {
                char endChar = sentence[sentence.Length - 1];

                if (endChar != '.' ||  endChar != '?' || endChar != '!')        // if endchar doesnt end with terminators
                {
                    Console.WriteLine("Sentence needs to end with a terminator");
                    return false;
                }

                return true;

            }

            static bool NumberSpellOut(string sentence)
            {

                foreach (char c in sentence) {

                    if (char.IsLetterOrDigit(c))
                    {
                        int number = c - '0';

                        if (number < 13)
                        {
                            Console.WriteLine("Numbers under 13 should be spelled out");
                            return false;
                        }
                    }
                }
                return true;

            }

            static bool EndPeriod(string sentence)
            {
                int count = 0;

                for (int i = 0; i < sentence.Length - 1; i++)
                {
                    if (sentence[i] == '.')
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    Console.WriteLine("Sentence should only have period at the end");
                    return false;
                }

                return true;
            }




        }
    }
}