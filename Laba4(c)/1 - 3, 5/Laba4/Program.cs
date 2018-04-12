using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arrs
    {
        private Random random = new Random();

        public int[] CreateOneDimArr(int[] arr) //заполнение массива рандомными числами
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i] = random.Next(-50, 50);

            return arr;
        }

        public void PrintArr1(string name, int[] arr)//вывод массива
        {
            Console.Write(name + " = { ");
            for (int i = 0; i < arr.GetLength(0); i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine("}");
        }

        public int[] Sum(int[] A, int[] B) //суммирование 
        {
            int[] new_arr = new int[A.GetLength(0)];
            for (int i = 0; i < new_arr.GetLength(0); i++)
                new_arr[i] = A[i] + B[i];

            return new_arr;
        }

        public int[,] MultMatr(int[,] arr1, int[,] arr2) //умножение
        {
            int[,] new_arr = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < new_arr.GetLength(0); i++)
                for (int j = 0; j < new_arr.GetLength(1); j++)
                    new_arr[i, j] = arr1[i, j] * arr2[i, j];

            return new_arr;
        }

        public void PrintArr2(string name, int[,] arr)//печать двумерного массива
        {
            Console.Write(name + " = \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public int[,] CreateOneDimArr2(int[,] arr)//заполнение двумерного массива
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                    arr[i, j] = random.Next(-50, 50);

            return arr;
        }

        public void PrintArr3(string name, int[][] arr)//вывод массива массивов
        {
            Console.WriteLine(name + " = ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("({0}): ", i);
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");

                Console.WriteLine();
            }
            Console.WriteLine("");
        }

        public int[][] CreateOneDimArr3(int[][] arr)//заполнение массива массивов
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = random.Next(-50, 50);

            return arr;
        }

        /* ------------------------------------------------------------------------------------------------*/
        /* МЕТОДЫ ЛАБОРАТОРНОЙ РАБОТЫ №4 */
        /* ------------------------------------------------------------------------------------------------*/

        public void PrintAnyArr(string name, Array arr) //ЗАДАНИЕ №4.1
        {
            switch (arr.Rank)
            {
                case 1:
                    Console.Write(name + " = { ");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        var val = arr.GetValue(i);
                        Console.Write(val + " ");
                    }
                    Console.WriteLine("}");
                    break;
                case 2:
                    Console.Write(name + " = { ");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        Console.Write("{ ");
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            var val = arr.GetValue(i, j);
                            Console.Write(val + " ");
                        }
                        Console.Write("}");
                    }
                    Console.WriteLine("}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
        }
        public void PrintAnyArr2(string name, Array arr) //ЗАДАНИЕ №4.2
        {
            Console.Write(name + " = { ");
            foreach (var val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("}");
        }

        public void PrintAnyArr3(string name, Object arr)
        {
            Console.WriteLine(name + " = { " + arr + " }");
        }

        public static void PrintArrObj(string name, object[] arr)
        {
            Console.Write(name + " = { ");
            foreach (var val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("}");
        }

        static void Main(string[] args)
        {
            Arrs ob = new Arrs();
            int[] A = new int[5], B = new int[5], C = new int[5];
            int[][] R =
                        {
                         new int [1],
                         new int [2],
                         new int [3],
                         new int [4],
                         new int [5],
                         new int [6],
                         new int [7],
                         new int [8],
                         new int [9],
                         new int [10]
                         };
            for (; ; )
            {
                Console.WriteLine("Лабораторная работа №3 + №4!");
                Console.WriteLine("1 - Задание №1 (+ методы печати №4 (1,2,3))");
                Console.WriteLine("2 - Задание №2");
                Console.WriteLine("3 - Задание №3");
                Console.WriteLine("4 - Задание №5 (лаба №4)");
                Console.WriteLine("0 - Выход \n");
                int choice;
                var check = int.TryParse(Console.ReadLine(), out choice);
                if (check)
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Введите размерность массива D:");
                            int size = int.Parse(Console.ReadLine());
                            //создание массивов
                            ob.CreateOneDimArr(A);
                            ob.CreateOneDimArr(B);
                            int[] X = { 5, 5, 6, 6, 7, 7 };
                            int[] U, V;
                            U = new int[3] { 1, 2, 3 };
                            //V = { 1,2,3 };
                            V = new int[3];
                            V = U;
                            V[0] = 9;
                            int[] D = new int[size];
                            ob.CreateOneDimArr(D);
                            //вывод массивов на экран 
                            ob.PrintArr1("A", A);
                            ob.PrintArr1("B", B);
                            ob.PrintArr1("C", ob.Sum(A, B));
                            ob.PrintArr1("X", X);
                            ob.PrintArr1("U", U);
                            ob.PrintArr1("V", V);
                            ob.PrintArr1("D", D);
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Метод PrintAnyArr");
                            ob.PrintAnyArr("A", A);
                            ob.PrintAnyArr("B", B);
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Метод PrintAnyArr2");
                            ob.PrintAnyArr2("A", A);
                            ob.PrintAnyArr2("B", B);
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Метод PrintAnyArr3");
                            ob.PrintAnyArr3("A", A);
                            ob.PrintAnyArr3("B", B);
                            Console.WriteLine("--------------------------");
                            break;
                        case 2:
                            Console.Clear();
                            int[,] Q = new int[3, 3], W = new int[3, 3], P = new int[3, 3];
                            //создание массивов
                            ob.CreateOneDimArr2(Q);
                            ob.CreateOneDimArr2(W);
                            //вывод массивов на экран 
                            ob.PrintArr2("Q", Q);
                            ob.PrintArr2("W", W);
                            P = ob.MultMatr(Q, W);
                            ob.PrintArr2("P", P);
                            Console.WriteLine("---------------------------------------------");
                            break;
                        case 3:
                            Console.Clear();
                            ob.CreateOneDimArr3(R);
                            ob.PrintArr3("R", R);
                            break;
                        case 4:
                            Console.Clear();
                            string[] str = { "J", "v", "k", "55555" };
                            int[] str1 = { 1, 5, 7, 8 };
                            Arrs.PrintArrObj("str", str);
                            //Arrs.PrintArrObj("4", str1);
                            Console.WriteLine("---------------------------------------------");
                            break;
                    }
                if (choice == 0) break;
            }
        }
    }
}
