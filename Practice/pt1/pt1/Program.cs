// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static int staticCounter = 0;

        private string instanceMessage;

        public Program(string message) => instanceMessage = message;

        static void DisplayStaticCounter()
        {
            Console.WriteLine($"static Counter Value: {staticCounter}");
        }

        public void DisplayInstanceMessage()
        {
            Console.WriteLine($"Instance Message: {instanceMessage}");
        }

        public int AddNumbers(int a,int b)
        {
            return a + b;
        }

        static void Main(string [] args)
        {
            int intNumber = 42;
            float floatNumber = 3.14f;
            bool isCodingFun = true;
            string greeting = "Hello, .NET Core!";

            Console.WriteLine("Primitive Data Type:");
            Console.WriteLine($"Integer: {intNumber}");
            Console.WriteLine($"Float: {floatNumber}");
            Console.WriteLine($"Boolean: {isCodingFun}");
            Console.WriteLine($"String: {greeting}");

            staticCounter++;
            DisplayStaticCounter();

            Program Program = new Program("Welcome To C#.net Core!");
            Program.DisplayInstanceMessage();
            int sum = Program.AddNumbers(5, 7);
            Console.WriteLine($"Sum Of 5 and 7: {sum}");

            Console.WriteLine("Program Execution Complete!");
            
            return ;
            


        }
    }
}