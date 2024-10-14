using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal abstract class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        protected string Species { get; set; }

        public Pet(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }
        public abstract string MakeSound();

        public abstract string Eat();
    }
}
