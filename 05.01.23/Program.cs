using System;

namespace _05._01._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The lengh of massive");

            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int positive = 0;
            int negative = 0;
            int zero = 0;
            int sum = 0;
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"mass [{i}]=");
                mass[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    positive++;
                }

                if (mass[i] < 0)
                {
                    negative++;
                }

                if (mass[i] == 0)
                {
                    zero++;
                }
            }
            Console.WriteLine($"Positive= {positive}\nNegative= {negative}\nZero={zero} ");

            //for (int i = 0; i < mass.Length; i++)
            //{

            //    if (mass[i] < 0)
            //    {
            //        count++;
            //        sum += mass[i];
            //    }

            //}
        }
    }
}
