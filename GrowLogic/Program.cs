using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GrowLogic
{
    class Program
    {
        static void do_something()
        {
            
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Thread.Sleep(500);
                do_something();
            }
        }
    }
}
