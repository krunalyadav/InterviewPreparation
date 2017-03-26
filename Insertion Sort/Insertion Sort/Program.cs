using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Random rad = new Random();
            int[] ary = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ary[i] = rad.Next(1, 100);
            }

            Console.WriteLine("Unsorted integers");
            Console.WriteLine(string.Join(",", ary));

            for (int i = 1; i < ary.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ary[j] > ary[j + 1])
                    {
                        temp = ary[j + 1];
                        ary[j + 1] = ary[j];
                        ary[j] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted integers");
            Console.WriteLine(string.Join(",", ary));

            Console.Read();
        }
    }
}