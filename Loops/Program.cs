using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab.Task1();
            Lab.Task2();
            Lab.Task3();
            Lab.Task4();
            Lab.Task5();
            Lab.Task6();
            Lab.Task7();
            Lab.Task8();

        }
        class Lab
        {
            public static void Task1()
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            public static void Task2()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Сума: " + sum);
            }
            public static void Task3()
            {
                Console.WriteLine("Введіть число:");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            public static void Task4()
            {
                Console.WriteLine("Введіть число:");
                int number = Convert.ToInt32(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("Factorial: " + factorial);
            }
            public static void Task5()
            {
                bool IsPrime(int number)
                {
                    if (number <= 1) 
                        return false;
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                            return false;
                    }
                    return true;
                }
                int limit = 50;
                int sum = 0;
                for (int i = 2; i <= limit; i++)
                {
                    if (IsPrime(i))
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("Сума простих чисел від 1 до 50: " + sum);
            }
            public static void Task6()
            {
                Console.WriteLine("Введіть число:");
                string input = Console.ReadLine();

                int number = Convert.ToInt32(input);

                if (number == 0)
                {
                    Console.WriteLine("Двійкова система: 0");
                    return;
                }

                bool isNegative = number < 0;
                if (isNegative) number = -number;

                string binary = "";
                while (number > 0)
                {
                    binary = (number % 2) + binary;
                    number /= 2;
                }

                if (isNegative) binary = "-" + binary;

                Console.WriteLine("Двійкова система: " + binary);
            }

            public static void Task7()
            {
                Console.Write("Введіть число: ");
                string input = Console.ReadLine();

                int number = Convert.ToInt32(input);

                int a = 0;
                int b = 1;
                int sum = 0;
                int count = 0;

                while (a < number)
                {
                    Console.Write(a + " ");
                    sum += a;
                    count++;
                    int temp = a + b;
                    a = b;
                    b = temp;
                }

                Console.WriteLine("Сума чисел: " + sum);
                Console.WriteLine("Кількість елементів: " + count);
            }
            public static void Task8()
            {
                Console.Write("Введіть перше число: ");
                string input = Console.ReadLine();

                int num1 = Convert.ToInt32(input);

                Console.Write("Введіть друге число: ");
                input = Console.ReadLine();

                int num2 = Convert.ToInt32(input);

                int a = num1;
                int b = num2;

                while (num2 != 0)
                {
                    int temp = num2;
                    num2 = num1 % num2;
                    num1 = temp;
                }

                int nsd = num1;

                Console.WriteLine($"\nНСД чисел {a} і {b} = {nsd}");
            }

        }
        

    }
}

