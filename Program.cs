using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_22_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }
        static void Exercise1()
        {
            Console.WriteLine("Задача 1:\n");
            KillStatistic statistic1 = new KillStatistic()
            {
                Kills = 2,
                People = 100
            };
            KillStatistic statistic2 = new KillStatistic()
            {
                Kills = 3,
                People = 150
            };

            Console.WriteLine("statistic 1:");
            statistic1.Print();
            Console.WriteLine("statistic 2:");
            statistic2.Print();

            if (statistic1 == statistic2)
            {
                Console.WriteLine("\nВ первой и второй статистике одинаковый коэфицент убийств!");
                statistic2.Print();
            }
            else
            {
                Console.WriteLine("\nВ первой и второй статистике не одинаковый коэфицент убийств!");
            }
        }
        static void Exercise2()
        {
            Console.WriteLine("\nЗадача 2:\n");

            ClassWithArray array1 = new ClassWithArray(4);
            ClassWithArray array2 = new ClassWithArray(6);
            Random random = new Random();

            Console.WriteLine("array 1:");
            for(int i = 0; i < array1.Size; i++)
            {
                array1[i] = random.Next(100);
                Console.WriteLine($"{i + 1} : {array1[i]}");
            }

            Console.WriteLine("array 2:");
            for (int i = 0; i < array2.Size; i++)
            {
                array2[i] = random.Next(100);
                Console.WriteLine($"{i + 1} : {array2[i]}");
            }

            if(array1 != array2)
            {
                Console.WriteLine("Суммы первого и второго массива не равны");
            }
            else
            {
                Console.WriteLine("Суммы массивов равны!");
            }
        }
    }
}
