using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_23
{
    // 1 задание

    enum Month
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }

    // 2 задание 

    enum Week
    {
        Sat,
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri
    }

    class Program
    {
        static void Main(string[] args)
        {

            // 1 задание 

            foreach (var i in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{(int)i}\t{i}");
            }

            // 2 задание

            foreach (var i in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine($"{i} имеет значение {(int)i}");
            }

            Console.ReadKey();
        }
    }
}
