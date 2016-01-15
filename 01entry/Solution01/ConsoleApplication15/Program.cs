using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        /// <summary>
        /// インクリメント、デクリメント
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = 5;
            n2 = n1++;
            Console.WriteLine(n2);

            n1 = 5;
            n2 = ++n1;
            Console.WriteLine(n2);

            n1 = 5;
            Console.WriteLine(n1--);

            n1 = 5;
            Console.WriteLine(--n1);

            Console.ReadLine();
        }
    }
}
