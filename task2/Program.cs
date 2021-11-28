using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        // Палиндром
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            str = str.ToLower().Replace(" ", string.Empty);
            string strReversed = new string(str.Reverse().ToArray());
            strReversed = String.Join(" ", strReversed);

            if (str == strReversed)
            {
                Console.Write("Это палиндром!");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Это не палиндром!");
                Console.ReadLine();
            }
        }
    }
}
