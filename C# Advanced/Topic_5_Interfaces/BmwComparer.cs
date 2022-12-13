using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Interfaces
{
    public class BmwComparer : IComparer<Bmw>
    {
        public int Compare(Bmw? x, Bmw? y)
        {
            if (x.TankSize < y.TankSize)
            {
                return -1;
            }
            else if(x.TankSize > y.TankSize)
            {
                return 1;
            }
            else
            {
                return string.Compare(x.Color, y.Color);
            }
        }
    }
}
