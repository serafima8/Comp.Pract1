using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Программа №1(Лебедева)");
            Console.Write("Введите своё имя:");
            string name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Здравствуйте,{name}");
            Console.SetWindowSize(60, 25);
            bool capsLockInclude = Console.CapsLock;
            if (capsLockInclude)
            {
                Console.WriteLine($"Состояние CapsLock:включен");
            }
            else
            {
                Console.WriteLine($"Состояние CapsLock: выключен");
            }

            bool NumLock = Console.NumberLock;
            if (NumLock)
            {
                Console.WriteLine($"Состояние NumLock: включен");
            }
            else
            {
                Console.WriteLine($"Состояние NumLock: выключен");
            }
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
