using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3._4
{
    public class Emp
    {
        private static int _n = 1;
        private int _id;
        private string _name;
        private int _age;
        private float _salary;
        public Emp()
        {
            _id = _n;
            _n++;
        }
        public int Id
        {
            get {return _id;}
            private set {}  //for security
        }
        public string Name
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public int Age
        { 
            get { return _age; } 
            set { 
                if(value >= 18 && value <= 60)
                    _age = value;
            }
        }
        public float Salary
        {
            get { return _salary; }
            set
            { 
                if(value >= 7000 && value <= 45000)
                    _salary = value;
            }
        }
        public void print()
        {
            Console.WriteLine($"\nName: {_name}\nId: {_id}\nAge: {_age}\nSalary: {Salary}$\n");
        }
    }
}
