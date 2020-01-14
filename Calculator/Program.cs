using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string numOne;
            //string numTwo;
            //string 

            Console.WriteLine("Please enter your math equation, Two numbers and one operator");





            Console.WriteLine("Enter your first number:");

            int numOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your first number is: " + numOne);

            Console.WriteLine("Enter your operator:");
            string Operator = (Console.ReadLine());
            //Console.WriteLine("Your first number is: " + Operator);

            Console.WriteLine("Enter your second number:");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your first number is: " + numTwo);

            //Console.WriteLine("First Number" + numOne + "operator" + Operator + "number two" + numTwo + "=");



            Console.WriteLine(numOne + Operator + numTwo + "=" );







            switch (Operator)
            {
                case "+":

                    Console.WriteLine(numOne + numTwo);

                    break;
                case "-":
                    Console.WriteLine(numOne - numTwo);
                    break;

                case "/":
                    Console.WriteLine(numOne / numTwo);
                    break;

                case "%":
                    Console.WriteLine(numOne % numTwo);
                    break;

                case "*":
                    Console.WriteLine(numOne * numTwo);
                    break;
                default:
                    break;
            }


        }
    }
}
