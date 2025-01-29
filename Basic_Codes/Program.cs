using System.ComponentModel;

namespace Basic_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CheckNumberIsDivisibleBy();
            RemoveDuplicateCharacterFromString();
        }


        //Write a program to remove duplicate characters from a string?
        public static void RemoveDuplicateCharacterFromString()
        {
            Console.WriteLine("Enter a strig : ");
            var inputString = Console.ReadLine();

            var finalstring = String.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!finalstring.Contains(inputString[i]))
                {
                    finalstring += inputString[i];
                }
            }

            Console.WriteLine(finalstring);
        }

        // Write a program to check whether the entered number is not divisible by 3 and 7?
        public static void CheckNumberIsDivisibleBy()
        {
            Console.WriteLine("Please enter a number : ");
            var input = int.Parse(Console.ReadLine());

            if(input % 3 != 0 || input % 7 != 0)
            {
                Console.WriteLine("entered number is not divisible by 3 and 7");
            }
            else
            {
                Console.WriteLine("entered number is  divisible by 3 and 7");
            }

            Console.WriteLine("Total numbers which is not divisible by 3 and 7 till " + input);

            for (int i = 0; i <= input; i++) 
            {
                if (i % 3 == 0 || i % 7 == 0)
                    continue;
                else
                    Console.Write("{0} ", i);
            }
        }
    }
}
