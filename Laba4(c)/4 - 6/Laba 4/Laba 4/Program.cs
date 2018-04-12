using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Solution
    {
        private Random random = new Random();

        public void CreateArr(string name, int[] arr, int begin, int end)
        {
            for (int i = begin; i < end; i++)
                arr[i] = random.Next(-50, 50);

        }

        public void PrintArr(string name, int[] arr)
        {
            Console.Write(name + ": ");
            foreach (int val in arr)
                Console.Write(val + " ");

            Console.WriteLine();
        }

        public void PrintArr(string name, int[] arr, int begin)
        {
            if (begin < arr.GetLength(0))
            {
                for (int i = begin; i < arr.GetLength(0); i++)
                    Console.Write(arr[i] + "; ");

                Console.WriteLine();
            }
            else
                Console.WriteLine("=(");
        }

        public void SumArr(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr2.GetLength(0)];
            int n = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(0); j++)
                    if ((i == j) && (arr1[i] != 0) && (arr2[j] != 0))
                    {
                        res[n] = arr1[i] + arr2[j];
                        n++;
                    }
            PrintArr("Сумма = ", res);
        }

        public void SubArr(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr2.GetLength(0)];
            int n = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(0); j++)
                    if ((i == j) && (arr1[i] != 0) && (arr2[j] != 0))
                    {
                        res[n] = arr1[i] - arr2[j];
                        n++;
                    }
            PrintArr("Вычитание = ", res);
        }

        public void MultSklArr(int[] arr1, int skl)
        {
            int[] res = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
                res[i] = arr1[i] * skl;

            PrintArr("Умножение на скаляр = ", res);
        }

        public void DivSklArr(int[] arr1, int skl)
        {
            int[] res = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
                res[i] = arr1[i] / skl;

            PrintArr("Деление на скаляр = ", res);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ob = new Solution();

            int length1 = 11;
            int length2 = 14;
            int begin1 = 1;
            int begin2 = 0;
            int end1 = 8;
            int end2 = 10;
            int[] arr1 = new int[length1];
            int[] arr2 = new int[length2];
            ob.CreateArr("arr1", arr1, begin1, end1);
            ob.CreateArr("arr2", arr2, begin2, end2);
            ob.PrintArr("arr1", arr1);
            ob.PrintArr("arr2", arr2);
            ob.SumArr(arr1, arr2);
            ob.SubArr(arr1, arr2);
            ob.MultSklArr(arr1, 6);
            ob.DivSklArr(arr1, 3);

            ob.PrintArr("arr", arr2, 5); //вывод массива по заданному индексу
        }
    }
}
