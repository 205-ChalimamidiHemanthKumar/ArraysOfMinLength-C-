using System;

namespace ConsoleApp11
{
   public class ArrayExample
    {
        static void PrintMin(int[] arr)
        {
            int min = arr[0];
            for (int i=1; i<arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum Lenth:" + min);
        }
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 20, 30, 40, 50, };
            int[] arr2 = { 2, 39, 40, 38, 28, 59 };
            PrintMin(arr1);
            PrintMin(arr2);
         }
    }
}
