using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.Write("a: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var ds = new ArithmaticClass();
            Console.WriteLine($"#1 {ds.z_func1(x, y, a)}");
            Console.WriteLine($"#2 {ds.z_func2(x, y, a)}");
        }
    }
}
