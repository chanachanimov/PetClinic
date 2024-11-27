using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Pet> pets = new List<Pet>
        {
            new Dog("Nahum", 3, "Dog", "Brown"),
            new Cat("Bela", 2, "Cat", "White")
        };

            IVeterinarian generalVet = new GeneralVeterinarian("Dr. Alprin");
            IVeterinarian specialistVet = new SpecialistVeterinarian("Dr. Levi", "Orthopedics");

            foreach (Pet pet in pets)
            {
                Console.WriteLine(generalVet.examinePet(pet));
                Console.WriteLine(specialistVet.examinePet(pet));
            }
        }
    }
}
