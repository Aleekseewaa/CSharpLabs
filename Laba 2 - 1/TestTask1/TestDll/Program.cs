using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (; ;)
            {
                Console.WriteLine("Выберите библиотеку для теста:");
                Console.WriteLine("1: Сдвиг влево, Сдвиг вправо");
                Console.WriteLine("=====================================");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваш выбор = {0}. Запускаем тест", n);
                Console.WriteLine();
                switch (n)
                {
                    case 1:
                        BitwiseOperations.LeftRight(4, 1);
                        BitwiseOperations.Assignment(2);
                        break;
                }
            }
        }
    }
}
