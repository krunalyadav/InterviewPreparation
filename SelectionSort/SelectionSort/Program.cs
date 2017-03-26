using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, index, temp;
            Random rad = new Random();
            int[] ary = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ary[i] = rad.Next(1, 100);
            }

            Console.WriteLine("Unsorted integers");
            Console.WriteLine(string.Join(",", ary));

            for (int i = 0; i < ary.Length; i++)
            {
                min = ary[i];
                index = i;
                if (i == (ary.Length - 1))
                    break;
                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (ary[j] < min)
                    {
                        min = ary[j];
                        index = j;
                    }
                }
                if (index != i)
                {
                    temp = ary[i];
                    ary[i] = ary[index];
                    ary[index] = temp;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted integers");
            Console.WriteLine(string.Join(",", ary));

            Console.Read();
        }
    }
}