﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface ICalculator
    {
        void Add();
        void Sub();
        void Mul();
        void Div();
    }
}
