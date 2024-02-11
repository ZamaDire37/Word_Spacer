using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words_Spacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a sentence: ");
                string inputSentence = Console.ReadLine();

                // Use a method to add spaces between words
                string resultSentence = AddSpacesBetweenWords(inputSentence);

                Console.WriteLine("Result: " + resultSentence);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }

        static string AddSpacesBetweenWords(string input)
        {
            // Split the input into words
            string[] words = input.Split(' ');

            // Join the words with spaces in between
            return string.Join(" ", words);
        }
    }
}