using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" B0226497_段昱如_PDPR__Week6_5");
            int n;
            Console.Write("請輸入n:");
            n = int.Parse(Console.ReadLine());
            int y = n << 1;
            Console.WriteLine($"n = n << 1 左移一位 :{Convert.ToString(y, toBase: 10)}");
            int z = n << 2;
            Console.WriteLine($"n = n << 2 左移兩位 :{Convert.ToString(z, toBase: 10)}");
            int w = n >> 2;
            Console.WriteLine($"n = n >> 2 右移兩位 :{Convert.ToString(w, toBase: 10)}");
            int x = n >> 3;
            Console.WriteLine($"n = n >> 3 右移三位 :{Convert.ToString(x, toBase: 10)}");




            Console.ReadLine();


        }
    }
}
