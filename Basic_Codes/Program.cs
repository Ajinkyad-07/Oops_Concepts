using System.ComponentModel;
using System.Text;

namespace Basic_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CheckNumberIsDivisibleBy();
            //RemoveDuplicateCharacterFromString();
            //ReverseString();
            //CheckIfStringIsPalindrom();
            //var factoutput = Factorial(10);
            //Console.WriteLine("factoutput => " + factoutput);
            Fibonacci();
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

        public static void ReverseString()
        {
            Console.WriteLine("Please enter a string : ");
            var input = Console.ReadLine();
            var inputStringArray = input.ToCharArray();
            var outputString = String.Empty;
            for (int i = inputStringArray.Length - 1; i >= 0 ; i--)
            {
                outputString += inputStringArray[i];
            }
            Console.WriteLine("output is " + outputString);
        }

        public static void CheckIfStringIsPalindrom()
        {
            // order of the string is same means actual and resrse string should be same 
            Console.WriteLine("Please enter a string : ");
            var input = Console.ReadLine();
            var inputStringArray = input.ToCharArray();
            var output = String.Empty;
            for (int i = inputStringArray.Length - 1; i >= 0 ; i--)
            {
                output += inputStringArray[i];
            }

            if (input == output)
                Console.WriteLine("Input string is palindrome...");
            else
                Console.WriteLine("Input string is not palindrome...");
        }

        public static int Factorial(int input = 5)
        {
            // 5*4*3*2*1
            var asb = (input == 0) ? 1 : input * Factorial(input - 1);
            return asb;
        }

        public static void Fibonacci()
        {
            var input = 10;
            var outputString = new StringBuilder();
            var a = 0;
            var b = 1;
            var temp = 0;
            outputString.AppendLine(a.ToString());
            outputString.AppendLine(b.ToString());

            for (int i = 2; i < input; i++)
            {
                temp = a + b;
                outputString.AppendLine(temp.ToString());
                a = b;
                b = temp;
            }

            Console.WriteLine(outputString.ToString());
        }
    }
}
