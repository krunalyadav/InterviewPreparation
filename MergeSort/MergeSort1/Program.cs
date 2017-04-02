using System;

namespace MergeSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rad = new Random();
            int[] ary = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ary[i] = rad.Next(1, 100);
            }

            Console.WriteLine("Unsorted integers");
            Console.WriteLine(string.Join(",", ary));
            ary = MergeSort(ary);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted integers");
            Console.WriteLine(string.Join(",", ary));
            Console.ReadLine();
        }

        static int[] MergeSort(int[] ary)
        {
            if (ary.Length == 1)
                return ary;
            int mid = ary.Length / 2;
            int[] a = new int[mid];
            int[] b = new int[ary.Length - mid];
            Array.Copy(ary, 0, a, 0, mid);
            Array.Copy(ary, mid, b, 0, ary.Length - mid);
            a = MergeSort(a);
            b = MergeSort(b);
            return Merge(a, b);
        }

        static int[] Merge(int[] a, int[] b)
        {
            int i = 0, j = 0, k = 0, alen = a.Length, blen = b.Length;
            int[] c = new int[alen + blen];
            while (i < alen && j < blen)
            {
                if (a[i] < b[j]) // make greater than for ordering in descending order
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }
            while (i < alen)
            {
                c[k++] = a[i++];
            }
            while (j < blen)
            {
                c[k++] = b[j++];
            }
            return c;
        }
    }
}