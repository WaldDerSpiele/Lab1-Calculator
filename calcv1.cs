using System;

class CalculatorV1
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Простой калькулятор (+, -, *, /)");
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: неверная операция!");
                    validOperation = false;
                    break;
            }

            if (validOperation)
                Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");

            Console.WriteLine("Продолжить? (да/нет)");
            if (Console.ReadLine().ToLower() != "да")
                break;
        }
    }
}