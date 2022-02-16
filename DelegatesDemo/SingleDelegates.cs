using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class SingleDelegates
    {
        delegate void DelOperation(int x, int y);

        public void Delegates()
        {
            DelOperation[] obj ={
                new DelOperation(Operation.Add),
                new DelOperation(Operation.Multiple)
            };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
            }
        }
    }
}
