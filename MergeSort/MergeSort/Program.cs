using System;

namespace MergeSort
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
            SortMerge(ary, 0, ary.Length- 1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted integers");
            Console.WriteLine(string.Join(",", ary));
            Console.ReadLine();
        }

        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);

                MainMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}