using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._2
{
    public class Circle : Shape
    {
        
        public override double Area()
        {
            return Math.PI * _dim1 * _dim1;
        }
        /*
         * make the following methods public instead of protected in the base class
            public override void SetDim2(float n)
            {
                    _dim1 = n;
            }
            public override float GetDim2()
            {
                return _dim1;
            }
        */
        public override string ToString()
        {
            return $"Circle => Radius:{_dim1} , Area:{Area()}";
        }
    }
}
