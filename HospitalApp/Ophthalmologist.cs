using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Ophthalmologist:Doctors
    {
        public Ophthalmologist(string name, string surname, ushort age) : base(name, surname, age)
        {

        }
        public override void Action()
        {
            Console.WriteLine($"Doctor {_surname} prescribe glasses or contact lenses");
        }
    }
}
