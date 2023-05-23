using System;

namespace Dz_3._2
{
    class Program
    {
        /*Гражданин 1 марта открыл счет в банке, вложив 1000 руб. 
         * Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы. 
         * Определить через сколько месяцев размер вклада превысит 1200 руб*/
        static void Main(string[] args)
        {
            int month = -1;
            for (double i = 1000.00; i <= 1200.00; i = i + (i * 0.02))
            {
                month = month + 1;
                Console.WriteLine($"{i}  {month}");
            }
            Console.WriteLine($"\nThe deposit will exceed 1200 " +
                $"rubles in {month} months");
        }
    }
}
