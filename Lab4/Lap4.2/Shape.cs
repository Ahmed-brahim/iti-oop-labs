using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._2
{
    public abstract class Shape
    {
        protected float _dim1;
        protected float _dim2;
        #region constructors
        public Shape():this(1,1)
        {
            
        }
        public Shape(float dim1):this(dim1,dim1)
        {
            
        }
        public Shape(float dim1,float dim2)
        {
            _dim1 = dim1;
            _dim2 = dim2;
        }
        #endregion
        #region setters and getters
        public virtual void SetDim1(float n)
        {
            _dim1 = n;
        }
        public virtual float GetDim1()
        {
            return _dim1;
        }
        protected virtual void SetDim2(float n)
        {
            _dim2 = n;
        }
        protected virtual float GetDim2()
        {
            return _dim2;
        }
        #endregion
        public abstract double Area();
        public override  string ToString()
        {
            return $"Shape => Dim1:{_dim1} , Dim2:{_dim2}";
        }
    }
}
