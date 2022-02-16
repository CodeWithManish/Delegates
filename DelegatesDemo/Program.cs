using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates Operation!");
            Console.WriteLine("Enter 1. to print sinle Delegates\n");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        SingleDelegates single=new SingleDelegates();   
                        single.Delegates();
                        break;



                }
            }
        }
    }
}
