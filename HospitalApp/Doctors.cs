using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Doctors
    {
        public Doctors(string name, string surname, ushort age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
        protected string _name;
        protected string _surname;
        protected ushort _age;
        public virtual void Action()
        {
            Console.WriteLine();
        }
    }
}
