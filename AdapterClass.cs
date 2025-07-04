using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class AdapterClass : ICalculator
    {

        private oldClassToCalculation _oldClassToCalculation;
        public AdapterClass(newClassThatTakeSign newClass) {
            if (newClass.numberOnesign)
            {
                this.numberOne = newClass.numberOne * -1;
            }else
            {
                this.numberOne = newClass.numberOne;
            }
            if (newClass.NumberTowsign)
            {
                this.NumberTow = newClass.NumberTow * -1;
            }
            else
            {
                this.NumberTow = newClass.NumberTow;
            }
            _oldClassToCalculation = new oldClassToCalculation(numberOne, NumberTow);
        }
        public int numberOne { get; set; }
        public int NumberTow { get; set; }

        public void Add()
        {_oldClassToCalculation.Add();
        }

        public void Div()
        {
            _oldClassToCalculation.Div();
        }

        public void Mul()
        {
            _oldClassToCalculation.Mul();
        }

        public void Sub()
        {
            _oldClassToCalculation.Sub();
        }
    }
}
