using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MyMatrix<T>
    {
        private T[] V1;

        /// <summary>
        /// This is the Constructor.</para>
        /// </summary>
                public MyMatrix(int n, int m)
        {
            V1 = new T[n * m];
        }
       /// <summary>
       /// An absolutly pointless Function. It realy does nothing.
       /// </summary>
       /// <param name="i">Dosn't metters what are you writeing here. It hase no effect to you'r function.</param>
        public void doNothing(int i)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void doNothing2(int i, int j)
        {

        }

    }
}
