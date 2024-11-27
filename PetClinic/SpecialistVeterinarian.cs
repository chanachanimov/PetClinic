using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    internal class SpecialistVeterinarian : IVeterinarian
    {   private string name;
        private string specialty;

        public SpecialistVeterinarian (string name,string specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }
        public string GetName()
        {
            return name;
        }

        public string examinePet(Pet pet)
        {
            return $"Examining {pet.getName()} ({pet.getSpecies()}). Specialized examination completed. The pet is healthy in the area of {specialty}.";
        }

    }
}
