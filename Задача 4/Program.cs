using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Role role = new Role();
            foreach (var elem in Enum.GetValues(typeof(Role.UserRole)))
            {
                Console.WriteLine(elem);
            }
            Console.Write("Введите роль пользователя: ");
            string user = Console.ReadLine();
            role.Roles(user);

            Console.ReadKey();
        }
    }
}
