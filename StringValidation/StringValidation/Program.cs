using System.Security.Cryptography.X509Certificates;

namespace StringValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");

            string userString = Console.ReadLine();     // User Input


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



            }




        }
    }
}