using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static int Converte(string c)//Конвертер из текста в числа
        {
            return System.Convert.ToInt32(c);
        }
        static void Main(string[] args)//Пишем в консольку счет цифр от вашей до нуля
        {
            Console.WriteLine("Введите циферку:");
            string a = Console.ReadLine();
            int k = Converte(a);
            if (k > 0)
            {
                for (int i = k - 1; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Счет окончен, всем спасибо! Расходимся по домам, ребята!");
            }
            else
            {
                Console.WriteLine("Ну, и? Что ты эти хотел сказать? Что я полный нуль?");
            }
            Console.ReadKey();
        }
    }
}
