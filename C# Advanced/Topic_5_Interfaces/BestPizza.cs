using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public class BestPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing best pizza in town");
        }
    }
}
