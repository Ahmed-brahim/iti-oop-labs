using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._2
{
    public class Triangle:Shape
    {
        public override double Area()
        {
            return 0.5 * _dim1 * _dim2;
        }
        public void SetDim2(float n)
        {
            _dim2 = n;
        }
        public float GetDim2()
        {
            return _dim2;
        }
        public override string ToString()
        {
            return $"Triangle => Base:{_dim1} , Height:{_dim2} , Area:{Area()}";
        }
    }
}
