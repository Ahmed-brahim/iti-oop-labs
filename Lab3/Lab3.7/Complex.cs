using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lap3._7
{
    public class Complex
    {
        public int Real;
        public int Imag;
        public Complex()
        {
        }

        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }
        public void Print()
        {
            Console.Write($"{Real} ");
            if(Imag > 0)
            {
                Console.WriteLine($"+ {Imag}i");
            }
            else if(Imag < 0)
            {
                Console.WriteLine($"- {-1 * Imag}i");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
