using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public abstract class Person
    {
        public virtual void GetBody()
        {
            Console.WriteLine("Person has two legs, two arms ...");
        }

        public abstract void GetCharacter();
    }
}
