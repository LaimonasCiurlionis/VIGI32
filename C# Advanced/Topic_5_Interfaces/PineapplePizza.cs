using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public class PineapplePizza : IPizza
    {
        public int Lenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Prepare()
        {
            Console.WriteLine("Preparing Pineapple pizza");
        }
    }
}
