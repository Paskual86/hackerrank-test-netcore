using System;

namespace HackerRankTest.Tests
{
    public static class MinimunSwap2
    {
        public static void Execute() 
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);
            Console.WriteLine($"Swap Quantity: {res}");
        }

        private static int swapQuantity = 0;

        static int minimumSwaps(int[] arr)
        {
            //QuickSort(arr, 0, arr.Length - 1);
            QuickSort2(arr);
            return swapQuantity;
        }

        static void QuickSort2(int[] arr)
        {
            bool bNotSorted = false;
            while (!bNotSorted)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != (i+1))
                    {
                        Swap(arr, i, (arr[i]-1));
                    }
                }
                bNotSorted = IsSorted(arr);
                PrintArray(arr);

            }
        }

        private static bool IsSorted(int [] arr) 
        {
            bool bResult = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if(i+1!=arr[i])
                {
                    bResult = false;
                    break;
                }
            }
            return bResult;
        }

        static void QuickSort(int[] arr, int left, int right) 
        {
            int index = Partition(arr, left, right);
            if (left < index - 1)
            {
                QuickSort(arr, left, index - 1);
            }
            if (index < right) 
            {
                QuickSort(arr, index, right);
            }
        }

        static int Partition(int[] arr, int left, int right) 
        {
            int pivot = arr[(left + right) / 2];
            while (left <= right)
            {
                while (arr[left] < pivot) left++;
                while (arr[right] > pivot) right--;

                if (left <= right)
                {
                    if (left != right)
                    {
                        Swap(arr, left, right);
                        PrintArray(arr);
                    }
                    left++;
                    right--;
                }
            }
            return left;
        }

        private static bool Swap(int[] arr, int positionOriginal, int positionFinal) 
        {
            bool result = false;

            if (positionOriginal < arr.Length && positionFinal < arr.Length) 
            {
                swapQuantity++;
                int aux = arr[positionOriginal];
                arr[positionOriginal] = arr[positionFinal];
                arr[positionFinal] = aux;
                result = true;

            }

            return result;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
