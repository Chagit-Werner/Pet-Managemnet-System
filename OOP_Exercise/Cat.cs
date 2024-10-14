using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class Cat:Pet
    {
        public string Color { get; private set; }

        public Cat(string name, int age, string species, string color)
            : base(name, age, species)
        {
            Color = color;
        }

        public override string MakeSound()
        {
            return "Meow!";
        }

        public override string Eat()
        {
            return "Cats eat yogurt.";
        }
    }
}
