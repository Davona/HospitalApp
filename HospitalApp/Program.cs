using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cardiologist cardiologist = new Cardiologist("Ashot", "Gevorgan", 44);
            cardiologist.Action();
            Dermatologist dermatologist = new Dermatologist("Vahik", "Karapetyan", 40);
            dermatologist.Action();
            Ophthalmologist ophthalmologist = new Ophthalmologist("Anna", "Suvaryan", 35);
            ophthalmologist.Action();
            Pediatrician pediatrician = new Pediatrician("Meri", "Avagyan", 42);
            pediatrician.Action();
        }
    }
}
