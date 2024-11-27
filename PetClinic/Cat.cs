using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    internal class Cat : Pet
    {
        private string color;

        public Cat (string name,int age,string species,string color):base(name,age,species)
        {
            this.color = color;
        }

        public override string makeSound()
        {
            return "meow";
        }
        public override string eat()
        {
            return "cat food";
        }
    
    }
}
