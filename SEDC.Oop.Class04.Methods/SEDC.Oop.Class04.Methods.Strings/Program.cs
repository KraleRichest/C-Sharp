using System;

namespace SEDC.Oop.Class04.Methods.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Trajan";

            string hello1 = "Hello " + name;
            string hello2 = string.Format("Hello {0}", name);  // Hello Trajan
            string hello3 = $"Hello {name}";

            Console.WriteLine("Hello1: " + hello1);
            Console.WriteLine("Hello2: " + hello2);
            Console.WriteLine("Hello3: " + hello3);

            string path = "Check your c:\\ drive";
            string a = "We will have \"fair\" elections";
            string b = "The \\n \n sign means new line";

            Console.WriteLine(path);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string path1 = @"Check your c:\ drive";
            string a1 = @"We will have ""fair"" elections";
            string b1 = @"The \\n \n sign means new line";

            Console.WriteLine(path1);
            Console.WriteLine(a1);
            Console.WriteLine(b1);

            string filePath = @"system\windows";
            string c1 = $@"Check your c:\{filePath} drive";
            Console.WriteLine(c1);

            string myStringCurrency = string.Format("{0:C}", 105.5);
            Console.WriteLine(myStringCurrency);

            int phoneNumber = 077132123;
            //077-132-123
            string formateNumber = string.Format("{0:0##-###-###}", phoneNumber);
            Console.WriteLine(formateNumber);

            string formatWithMultipleStrings = string.Format("{0} {1} {2} {3} {4} {5}", "Hello", "my", "name", "is", "Krale", "!");
            Console.WriteLine(formatWithMultipleStrings);

            string ourString = "             We are learning C# and it is FUN and EASY, Okay maybe just Fun.";
            string lowLetters = ourString.ToLower();
            Console.WriteLine(lowLetters);
            string upperLeters = ourString.ToUpper();
            Console.WriteLine(upperLeters);

            string[] splited = ourString.Trim().Split(' ');
            Console.WriteLine("The length is: " + splited.Length);
            foreach(string word in splited)
            {
                Console.WriteLine(word);
            }

            string substring = ourString.Substring(25, 50);
            Console.WriteLine(substring);


            Console.ReadLine();
        }
    }
}
