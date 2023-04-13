using System;

namespace Loop_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence!");
            string response = Console.ReadLine();
            Console.WriteLine($"The statement, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it");

            Console.WriteLine("Enter a whole number");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sume of the individual digits of {response2} is {SumOfDigits(response2)}");
        }

        /// <summary>
        /// Uses the sentence to count the number of spaces in the sentence and returns it
        /// </summary>
        /// <param name="sentence"> The sentence it uses to count the number of spaces </param>
        /// <returns> Returns the number of space in sentence </returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                    numberOfSpaces++;
            }
            return numberOfSpaces;
        }

        /// <summary>
        /// Gets the sum of the individual digits of the number typed, then returns a sum
        /// </summary>
        /// <param name="number"> put the string as number </param>
        /// <returns> Returns the sum of the numbers </returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }

            return sum;
        }
    }
}
