﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    enum Cal
    {
        Сложение,
        Вычитание, 
        Деление, 
        Умножение
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Ввеите значение переменной X: ");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите значение переменной Y: ");
            double y=Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("0 - Сложение:");
                Console.WriteLine("1 - Вычитание:");
                Console.WriteLine("2 - Деление:");
                Console.WriteLine("3 - Умножение:");

                int cal = int.Parse(Console.ReadLine());
                switch ((Cal)cal)
                {

                    case Cal.Сложение:
                        Console.WriteLine($"Сложение: {x + y}");
                        break;
                    case Cal.Вычитание:
                        Console.WriteLine($"Вычитание: {x - y}");
                        break;
                    case Cal.Деление:
                        Console.WriteLine($"Деление: {x / y}");
                        break;
                    case Cal.Умножение:
                        Console.WriteLine($"Умножение: {x * y}");
                        break;
                    default:
                        Console.WriteLine("Операции не существует.");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}
