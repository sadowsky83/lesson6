using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Самое длинное влово в строке
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] strArray = str.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries); // Просто хотел попробовать строку со знаками препинания
            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > maxLength)
                {
                    maxLength = strArray[i].Length;
                    index = i;
                }
            }

            Console.Write("Самое длинное слово: {0}", strArray[index]);
            Console.ReadLine();
        }
    }
}
