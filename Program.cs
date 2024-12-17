using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            List<string> zodiacSigns = new List<string>();

            zodiacSigns.Add("овен");
            zodiacSigns.Add("телец");
            zodiacSigns.Add("рак");

            Console.WriteLine("Исходный список:");
            OutputList(zodiacSigns);

            for (int i = 0; i < zodiacSigns.Count; i++)
            {
                zodiacSigns[i] = zodiacSigns[i].ToUpper();
            }

            Console.WriteLine("\nСписок в верхнем регистре:");
            OutputList(zodiacSigns);

            Console.WriteLine($"\nКоличество элементов: {zodiacSigns.Count}");

            zodiacSigns.Add("новый знак");
            Console.WriteLine("\nДобавлен элемент в конец:");
            OutputList(zodiacSigns);
        }
        static void OutputList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}