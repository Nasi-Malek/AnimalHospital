using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospital
{


    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; } // Typ av djur (t.ex. Hund, Katt)
        public int Age { get; set; } // Ålder i år
        public bool IsVaccinated { get; set; } // Om djuret är vaccinerat eller inte
        public int NumberOfLegs { get; set; } // Antal ben
    }

}
