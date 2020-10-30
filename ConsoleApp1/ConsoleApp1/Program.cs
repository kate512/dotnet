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
            Console.Write("Привет! Сколько дней вы живете в этом прекрасном мире? ");
            var days = Convert.ToInt32(Console.ReadLine());//возвращает только строки
            var years = days / 365;
            var mon = days % 365 / 30;
            var ostDay = days - years * 365 - mon * 30;
            Console.WriteLine($"Тебе уже {years} лет, {mon} месяцев и {ostDay} дней. Как здорово!");    // выводим
            if (years >= 18)
            {
                for(var i = 1; i <= 10; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Console.Write("Ты такой взрослый, совершеннолетний! Поздравляю тебя <3 ");
            }
            else
            {
                Console.WriteLine("Вам еще нет 18, у вас вся жизнь впереди <3 ");
            }
            Console.ReadKey();
        }
    }
}
