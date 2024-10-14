using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class SpecialistVeterinarian:GeneralVeterinarian
    {
        public string Specialty { get; set; }
        public SpecialistVeterinarian(string name, string specialty)
            : base(name)
        {
            Specialty = specialty;
        }

        public override string ExaminePet(Pet pet)
        {
            return $"Veterinarian {GetName()}, a {Specialty} specialist," +
                $" is examining {pet.Name}, with a specialized examination.";
        }
    }
}
