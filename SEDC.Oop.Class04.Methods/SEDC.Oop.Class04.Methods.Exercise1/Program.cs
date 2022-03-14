using System;

namespace SEDC.Oop.Class04.Methods.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your first number?");
            //string input1 = Console.ReadLine();
            //bool isValidInput1 = int.TryParse(input1, out int parsedInput1);
            //Console.WriteLine("Please enter your second number?");
            //string input2 = Console.ReadLine();
            //bool isValidInput2 = int.TryParse(input2, out int parsedInput2);
            //Console.WriteLine("If you want to subtract enter -, if you want to multiply enter *");
            //string userChoise = Console.ReadLine();
            //if (userChoise == "-")
            //{
            //    int resultSubstract = SubstractMethod(parsedInput1, parsedInput2);
            //    Console.WriteLine(resultSubstract);
            //} else if (userChoise == "*")
            //{
            //    int resultMultiply = MultiplyMethod(parsedInput1, parsedInput2);
            //    Console.WriteLine(resultMultiply);
            //} else
            //{
            //    Console.WriteLine("Enter valid choise");
            //}

            Substrings();



            Console.ReadLine();
        }

        public static int SubstractMethod(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public static int MultiplyMethod(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public static string Substrings()
        {
            string abc = "Hello from SEDC Codeacademy 2021";
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            bool isValidInput = int.TryParse(input, out int parsedInput);
            string result = string.Empty;
            if ((parsedInput > abc.Length) || (parsedInput <= 0))
            {
                Console.WriteLine("Enter valid number");
            } else
            {
                result = abc.Substring(0, parsedInput);
                Console.WriteLine(result);
                Console.WriteLine(result.Length);
            
            }
            return result;
        }
    }
}
