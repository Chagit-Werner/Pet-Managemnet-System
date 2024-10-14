using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class GeneralVeterinarian:IVeterinarian
    {
        private string name;

        public GeneralVeterinarian(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual string ExaminePet(Pet pet)
        {
            return $"Veterinarian {name} is examining {pet.Name},  generally.";
        }
    }
}
