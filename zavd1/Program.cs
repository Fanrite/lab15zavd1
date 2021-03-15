using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, outp = "eror";
            char o = 'о';
            int i = 0;

            Console.Write("vvedit stroku:");
            s = Console.ReadLine();

            foreach (char f in s)
            {
                if (o == f)
                    i++;
            }

            if (i == 0)
                outp = "bukvi o nemae";

            else if (i != 0)
                outp = $"tut {i} bukv o";

            Console.WriteLine($"{outp}");
            Console.ReadKey();
        }
    }
}
