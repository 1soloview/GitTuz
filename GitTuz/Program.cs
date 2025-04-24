using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 2 * Math.Cos(x);
            Console.WriteLine($"Для значения x = {x}, F = {F}.");
            Console.ReadKey();
        }
    }
}
