using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Role
    {
        public enum UserRole
        {
            Администратор,
            Модератор,
            Пользователь,
            Гость
        }
        public void Roles(string user)
        {
            {
                switch (user.ToLower())
                {
                    case "администратор":
                        Console.WriteLine($"Вы зарегестрировны как {UserRole.Администратор}");
                        break;
                    case "модератор":
                        Console.WriteLine($"Вы зарегестрировны как {UserRole.Модератор}");
                        break;
                    case "пользователь":
                        Console.WriteLine($"Вы зарегестрировны как {UserRole.Пользователь}");
                        break;
                    case "гость":
                        Console.WriteLine($"Вы зарегестрировны как {UserRole.Гость}");
                        break;
                }
            }
        }
    }
}
