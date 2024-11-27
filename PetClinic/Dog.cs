using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    internal class Dog : Pet
    {
        private string breed;

        public Dog(string name, int age, string species,string breed) : base(name, age, species)
        {
            this.breed = breed;
        }

        public override string makeSound()
        {
            return "bark";
        }

        public override string eat()
        {
            return "dog food";
        }

    }

}


