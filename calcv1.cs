using System;

class CalculatorV2
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Расширенный калькулятор (+, -, *, /, sqrt, ^)");
            Console.WriteLine("Введите операцию (+, -, *, /, sqrt, ^):");
            string operation = Console.ReadLine();

            double result = 0;
            bool validOperation = true;

            if (operation == "sqrt")
            {
                Console.WriteLine("Введите число:");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num >= 0)
                    result = Math.Sqrt(num);
                else
                {
                    Console.WriteLine("Ошибка: нельзя извлечь корень из отрицательного числа!");
                    validOperation = false;
                }
            }
            else
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                if (operation != "^" && operation != "+" && operation != "-" && 
                    operation != "*" && operation != "/")
                {
                    Console.WriteLine("Ошибка: неверная операция!");
                    validOperation = false;
                }
                else
                {
                    Console.WriteLine("Введите второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 != 0)
                                result = num1 / num2;
                            else
                            {
                                Console.WriteLine("Ошибка: деление на ноль!");
                                validOperation = false;
                            }
                            break;
                        case "^":
                            result = Math.Pow(num1, num2);
                            break;
                    }
                }
            }

            if (validOperation)
                Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Продолжить? (да/нет)");
            if (Console.ReadLine().ToLower() != "да")
                break;
        }
    }
}