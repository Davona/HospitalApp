using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Cardiologist : Doctors
    {
        public Cardiologist(string name, string surname, ushort age) : base(name, surname, age)
        {

        }
        public override void Action()
        {
            Console.WriteLine($"Doctor {_surname} observe hearts");
        }
    }
}
