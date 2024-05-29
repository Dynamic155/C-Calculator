using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usr;
            Console.Clear();
            
            Console.WriteLine("Enter your username below:");

            usr = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Welcome {usr} to the calculator.");

            int num1;
            int num2;

            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"First num is '{num1}'");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Please enter your seccond number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your seccond num is '{num2}'");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            string answer;
            int result;

            Console.WriteLine("Please enter your operation (EG: '+', '-', '*', '/'): ");
            answer = Console.ReadLine();
            Console.Clear();

            /* Attempt 1:
            if(answer == "+") {
                result = num1 + num2;
                Console.WriteLine($"{usr}... Your answer is: {num1} {answer} {num2} = {result}");
            }
            else if(answer == "-") {
                result = num1 - num2;
                Console.WriteLine($"{usr}... Your answer is: {num1} {answer} {num2} = {result}");
            }
            else if(answer == "*") {
                result = num1 * num2;
                Console.WriteLine($"{usr}... Your answer is: {num1} {answer} {num2} = {result}");
            }
            else if(answer == "/") {
                result = num1 / num2;
                Console.WriteLine($"{usr}... Your answer is: {num1} {answer} {num2} = {result}");
            }
            else if(answer == "x") {
                Console.WriteLine("Okay bro... You think you are tougher than me?!?!?!?!");
                System.Threading.Thread.Sleep(1000);
                result = num1 * num2;
                Console.WriteLine($"how about this huh, your number is {result} okay dude!!");
            }
            else {
                Console.WriteLine("The operator you entered is invalid.");
            }
            */

            // Version 2. Re-Written:
            var operations = new Dictionary<string, Func<int, int, int>>() 
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => a - b },
                { "*", (a, b) => a * b },
                { "/", (a, b) => a / b },
                { "x", (a, b) => a * b },
            };

            if (operations.ContainsKey(answer))
            {
                result = operations[answer](num1, num2);
                Console.WriteLine($"{usr}... Your answer is: {num1} {answer} {num2} = {result}");
            }
            else {
                Console.WriteLine("nah, don't think so.");
            }

            
        }
    }
}