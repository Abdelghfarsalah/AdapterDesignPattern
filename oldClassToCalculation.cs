using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class oldClassToCalculation : ICalculator
    {
        
        public oldClassToCalculation(int numberOne,int NumberTow) {
            this.numberOne = numberOne;
            this.NumberTow = NumberTow;
        }

        public int numberOne {  get; set; }
        public int NumberTow {  get; set; }


        public void Add()
        {
            Console.WriteLine($"Sum of {numberOne} and {NumberTow} is {NumberTow+ numberOne}");
            Console.WriteLine("=============================================================");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul of {numberOne} and {NumberTow} is {NumberTow * numberOne}");
            Console.WriteLine("=============================================================");
        }

        public void Div()
        {
            Console.WriteLine($"Div of {numberOne} and {NumberTow} is {numberOne / NumberTow}");
            Console.WriteLine("=============================================================");
        }

        public void Sub()
        {
            Console.WriteLine($"Sub of {numberOne} and {NumberTow} is {numberOne - NumberTow}");
            Console.WriteLine("=============================================================");
        }
    }
}
