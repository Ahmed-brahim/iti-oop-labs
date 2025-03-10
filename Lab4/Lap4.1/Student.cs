using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap4._1
{
    internal class Student:Person
    {
        int grade;

        #region Constructors    
        public Student():base()
        {
            grade = 0;
        }
        public Student(int age):base(age)
        {
            grade = 0;
        }
        public Student(string name):base(name)
        {
            grade = 0;
        }
        public Student(int age,string name):base(age,name)
        {
            grade = 0;
        }
        public Student(int age,string name,int grade):base(age,name)
        {
            this.grade = grade;
        }
        #endregion

        #region Setters and Getters
        public virtual void SetGrade(int n)
        {
            grade = n;
        }
        public virtual int GetGrade()
        {
            return grade;
        }
        #endregion
        public override string ToString()
        {
            return $"Student => Name:{GetName()} , Age:{GetAge()} , Grade:{grade}";
        }
        
    }
}
