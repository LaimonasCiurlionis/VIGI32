using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public abstract class Animal
    {
        public abstract void Run();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }




    }
}
