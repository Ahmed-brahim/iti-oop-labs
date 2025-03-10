using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._2
{
    public class Rectangle:Shape
    {
        public override double Area()
        {
            return _dim1 * _dim2;
        }
        public void SetDim2(float width)
        {
            _dim2 = width;
        }
        public float GetDim2()
        {
            return _dim2;
        }
        public override string ToString()
        {
            return $"Rectangle => length:{_dim1} , width:{_dim2} , Area:{Area()}";
        }
    }
}
