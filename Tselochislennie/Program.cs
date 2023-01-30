using System;

namespace Tselochislennie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* 
            double SumSin(int kol)
            {
                if (kol == 1) return Math.Sin(1);
                return SumSin(kol - 1) + Math.Sin(kol);
            }

            void Task_2_1()
            {
                Console.WriteLine("Задача 2.1");
                const int n = 10;
                double r = 0;
                for (int i = 1; i <= n; i++)
                {
                    r += 1 / SumSin(i);
                    Console.WriteLine("\t"+r);
                }
                Console.WriteLine("End: "+r);
            }
            
            void Task_2_2()
            {
                Console.WriteLine("Задача 2.2");
                const int n = 10;
                double r = 0;
                for (int i = 1; i <= n; i++)
                {
                    r += Math.Cos(i) / SumSin(i);
                    Console.WriteLine("\t"+r);
                }
                Console.WriteLine("End: "+r);
            }
            
            Task_2_1();
            Task_2_2();
        }
    }
}