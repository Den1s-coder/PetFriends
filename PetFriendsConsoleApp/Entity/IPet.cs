using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFriendsConsoleApp.Entity
{
    internal interface IPet
    {
        public string PetType { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string PhysicalDescription { get; set; }
        string PersonalityDescription { get; set; }

        public void PetInfo();
    }
}
