using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор C#");

        while (true)
        {
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ошибка ввода!");
                continue;
            }

            Console.Write("Введите оператор (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Ошибка ввода!");
                continue;
            }

            double result = op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 != 0 ? num1 / num2 : double.NaN,
                _ => double.NaN
            };

            if (double.IsNaN(result))
                Console.WriteLine("Ошибка: неверная операция или деление на ноль!");
            else
                Console.WriteLine($"Результат: {result}");

            Console.Write("Хотите продолжить? (да/нет): ");
            if (Console.ReadLine()?.ToLower() != "да") break;
        }
    }
}
