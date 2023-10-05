using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,c=0;
            Console.WriteLine("adaad ra vared konid!");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                if (n % i == 0) c++;
            if (c == 2)
                Console.WriteLine("adaad shoma aval hast!");
            else
                Console.WriteLine("adaad shoma aval nist!");

                        


        }
    }
}
