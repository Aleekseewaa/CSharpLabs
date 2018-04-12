using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BitwiseOperations
    {
        public static void LeftRight(int n, int k)
        {
            int resultLk = n << k;
            int resultLn = k << n;
            int resultRk = n >> k;
            int resultRn = k >> n;
            Console.WriteLine("Свиг влево на {0} шагов = {1}", k, resultLk);
            Console.WriteLine("Сдвиг влево на {0} шагов = {1}",n,resultLn);
            Console.WriteLine("Сдвиг вправо на {0} шагов = {1}", n, resultRk);
            Console.WriteLine("Сдвиг вправо на {0} шагов = {1}", n, resultRn);
        }

        public static void BwO(int x, int y)
        {
            int r = x & y;
            int r1 = x ^ y;
            int r2 = x | y;
            Console.WriteLine(r + " " + r1 + " " + r2);
        }
        
        public static void Assignment(int k)
        {
            int result = 3;
            Console.WriteLine("Операция <<= {0}", result <<= k); //сдигает res на k влево
            Console.WriteLine("Операция >>= {0}", result >>= k);//сдигает res на k влево
            Console.WriteLine("Операция &= {0}", result &= k);
            Console.WriteLine("Операция ^= {0}", result ^= k);
            Console.WriteLine("Операция |= {0}", result |= k);
        }
    }
}
