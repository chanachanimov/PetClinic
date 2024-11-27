using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetClinic
{
    internal class GeneralVeterinarian : IVeterinarian
    {

        private string name;

        public GeneralVeterinarian (string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public string examinePet (Pet pet)
        {

            return $"examining {pet.getName()} ({pet.getSpecies()}) .General health check completed.The pet is healthy.";
        }

    }
}
