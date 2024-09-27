using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFriendsConsoleApp.Entity
{
    internal class Pet : IPet
    {
        public string PetType {  get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public string PhysicalDescription { get; set; }
        public string PersonalityDescription { get; set; }

        public Pet(string PetType, string Name, int Age, string PhysicalDescription = "Nothing", string PersonalityDescription = "Nothing")
        {
            this.PetType = PetType;
            this.Name = Name;
            this.Age = Age;
            this.PhysicalDescription = PhysicalDescription;
            this.PersonalityDescription = PersonalityDescription;
        }

        public void PetInfo()
        {
            Console.WriteLine($"{PetType} named {Name} she is {Age} years old");
            Console.WriteLine($"Desription\n Physical: {PhysicalDescription}.\n Personality: {PersonalityDescription}.\n");
        }
    }
}
