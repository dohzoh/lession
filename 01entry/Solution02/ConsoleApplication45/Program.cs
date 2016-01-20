using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = 10;
                var s = Console.ReadLine();
                var m = int.Parse(s);
                var ans = n/m;
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                // throw;
            }
            finally
            {
                Console.WriteLine("finished");
            }

            Console.ReadLine();
        }
    }
}
