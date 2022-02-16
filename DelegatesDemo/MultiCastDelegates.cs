using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
   public class MultiCastDelegates
    {
        delegate void DelOperation(int x, int y);
        public void MulDelegates()
        {
            DelOperation obj = Operation.Add;
            obj += Operation.Multiple;

            obj(5, 5);
            obj(8, 3);
        }
    }
}
