using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    internal abstract class Pet
    {
        private string name;
        private int age;
        protected string species;

        public Pet(string name, int age, string species)
        {
            this.name = name;
            this.age = age;
            this.species = species;

        }


        public string getName()
        {
            return name;

        }

        public int getAge()
        { 
        return age;
        }

        public string getSpecies()
        {
            return species;
        }

        public abstract string makeSound();
        public abstract string eat();
    }

 
}

