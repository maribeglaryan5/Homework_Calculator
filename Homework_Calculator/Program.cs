using System.Runtime.ExceptionServices;

namespace Homework_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Please, write your first number.";
            Console.Write(text);
            double firsInput = double.Parse(Console.ReadLine());

            string text2 = "Please, write your second number.";
            Console.Write(text2);
            double secondInput = double.Parse(Console.ReadLine());

            string text3 = "Choose one of these arithmetic actions: + - * / .";
            Console.Write(text3);
            char inputChar = char.Parse(Console.ReadLine());

            if (inputChar.Equals('+'))
            {
                double result3 = firsInput + secondInput;
                Console.Write($"Your calculated number is {result3}");
            }
            if (inputChar.Equals('-'))
            {
                double result4 = firsInput - secondInput;
                Console.Write($"Your calculated number is {result4}");
            }
            if (inputChar.Equals('/'))
            {
                double result5 = firsInput / secondInput;
                Console.Write($"Your calculated number is {result5}.");
            }

            if (inputChar.Equals('*'))
            {
                double result6 = firsInput * secondInput;
                Console.Write($"Your calculated number is {result6}.");

            }




        }
    }
}
