using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    public class Date
    {
        private int month = 7;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if((value > 0) &&( value < 13))
                {
                    month = value;
                }
            }
        }
    }
}
