using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Добавил пространство имен
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        // Удаление из строки текста в фигурных скобках
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string strUpgraded = Regex.Replace(str, @"{[\d\D]+}", ""); // Честно позаимствовал данное выражение

            Console.WriteLine(strUpgraded);
            Console.ReadKey();
        }
    }
}
