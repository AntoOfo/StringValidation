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

            static bool EvenQuotation(string quotation)
            {
                int count = 0;


            }

            static bool EndOfSentence(string sentence)
            {

            }

            static bool NumberSpellOut(string sentence)
            {

            }




        }
    }
}