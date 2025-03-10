using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._1
{
    public class Employee:Person
    {
        float salary;  
        #region Constructors
        public Employee():base()
        {
            salary = 0;
        }
        public Employee(int age):base(age)
        {
            salary = 0;
        }
        public Employee(string name):base(name)
        {
            salary = 0;
        }
        public Employee(int age,string name):base(age,name)
        {
            salary = 0;
        }
        public Employee(int age,string name,float salary):base(age,name)
        {
            this.salary = salary;
        }
        #endregion

        #region Setters and Getters
        public virtual void SetSalary(float n)
        {
            salary = n;
        }
        public virtual float GetSalary()
        {
            return salary;
        }
        #endregion
        public override string ToString()
        {
            return $"Employee => Name:{GetName()} , Age:{GetAge()} , Salary:{salary}";
        }
    }
}
