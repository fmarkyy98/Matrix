using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix<int> M1 = new MyMatrix<int>(10, 10);
            MyMatrix<int> M2 = new MyMatrix<int>(10, 20);
            M1.doNothing(2);
        }
    }
}
