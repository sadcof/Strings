using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета сотрудника");

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите любимое блюдо");
            string dish = Console.ReadLine();

            Console.WriteLine("Введите любимый цвет волос");
            string hairColor = Console.ReadLine();

            Console.WriteLine("Введите должность");
            string post = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}{surname}, вы любите кушать {dish}, " +
                $"любите людей с цветом волос {hairColor}, а работаете на должности {post}");
            Console.ReadKey();
        } 
    }
}
