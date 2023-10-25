using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodnaVjezba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = a + b;
            string str;

            Console.WriteLine("{0}, \n{1}, ", a, b);
            Console.Write("{0}, \n", c);

            do
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write("{0}, ", c);
                str = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(str));
        }
    }
}
