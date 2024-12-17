using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArithmaticClass
    {
        public float z_func1(int arg1, int arg2, int arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;
            return 10 * x - ((x / y) / (2 * a / x)) + (3 * x + 2 * a - a) / (3 * a + 2 * x + y) - 2 * x;
        }
        public float z_func2(int arg1, int arg2, int arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;
            return 9 * x - ((x / y) / (2 * a / x)) + (3 * x + 2 * a + a) / (3 * a + 2 * x - y) + 12 * x;
        }
    }
}
