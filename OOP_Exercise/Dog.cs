using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class Dog : Pet
    {
        public string Breed { get; private set; }

        // Constructor
        public Dog(string name, int age, string species, string breed)
            : base(name, age, species)
        {
            Breed = breed;
        }
        public override string Eat()
        {
            return "Hav Hav";
        }

        public override string MakeSound()
        {
            return "Dogs eat dos food";
        }
    }
}
