using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int num = int.Parse(line);

            if( num > 80 )
                Console.WriteLine("Aランクです");
            else if(num > 60)
                Console.WriteLine("Bランクです");
            else if(num > 40)
                Console.WriteLine("Cランクです");
            else
            {
                Console.WriteLine("Dランクです");
            }
            Console.ReadLine();
        }
    }
}
