using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public class Human : ICanRun
    {
        public void Run()
        {
            Console.WriteLine("Human is running");
        }
    }
}
