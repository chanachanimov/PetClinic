using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetClinic
{
    internal interface IVeterinarian
    {
        string GetName();
        string examinePet(Pet pet);

    }
}
