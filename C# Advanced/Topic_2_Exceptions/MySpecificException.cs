using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_2_Exceptions
{
    public class MySpecificException : Exception
    {
        public MySpecificException(string message) : base(message)
        {

        }
    }
}
