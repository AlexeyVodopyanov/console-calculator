using System;
using static System.Console;
namespace Calc
{
    class Program
    {
        

        public static int GetResult(int a, int b, string cmd)
        {
            int result;
            switch (cmd)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
        static void Main()
        {
            WriteLine("Введите первое число ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("Введите второе число ");
            int b = Convert.ToInt32(ReadLine());

            WriteLine("Пожалуйста выбирите +, -, *, / ");
            string cmd = ReadLine();
            int result = GetResult(a, b, cmd);
            WriteLine($"{a} {cmd} {b} = {result}");
        }
    }
}
