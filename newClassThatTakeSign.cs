using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class newClassThatTakeSign
    {
        public newClassThatTakeSign(int numberOne, int NumberTow,bool numberOnesign,bool NumberTowsign)
        {
            this.numberOne = numberOne;
            this.NumberTow = NumberTow;
            this.numberOnesign = numberOnesign;
            this.NumberTowsign=NumberTowsign;
        }

        public int numberOne { get; set; }
        public int NumberTow { get; set; }
        public bool numberOnesign { get; set; }
        public bool NumberTowsign { get; set; }
    }
}
