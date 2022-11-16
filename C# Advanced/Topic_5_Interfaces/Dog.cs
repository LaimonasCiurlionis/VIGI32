using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public class Dog : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Dog is running");
        }
    }
}
