using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._1
{
    public class Person
    {
        protected int _age;
        protected string _name;
        #region Constructors
        public Person():this(0,"Not Defined")
        {
            
        }
        public Person(int age):this(age,"Not Defined")
        {
            
        }
        public Person(string name):this(0,name)
        {
            
        }
        public Person(int age,string name)
        {
            _age = age;
            _name = name;
        }
        #endregion

        #region Setters and Getters
        public virtual void SetAge(int n)
        {
            _age = n;
        }
        public virtual int GetAge()
        {
            return _age;
        }
        public virtual void SetName(string n)
        {
            _name = n;
        }
        public virtual string GetName()
        {
            return _name;
        }
        #endregion
        public override string ToString()
        {
           return $"Person => Name:{_name} , Age:{_age}";
        }
        //public abstract void print();
       

    }
}
