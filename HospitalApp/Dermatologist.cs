using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Dermatologist : Doctors
    {
        public Dermatologist(string name, string surname, ushort age) : base(name, surname, age)
        {

        }
        public override void Action()
        {
            Console.WriteLine($"Doctor {_surname} focus on diseases of the skin, nails, and hair");
        }
    }
}
