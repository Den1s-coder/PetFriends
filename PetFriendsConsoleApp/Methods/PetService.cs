using PetFriendsConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetFriendsConsoleApp.Methods
{
    internal class PetService
    {
        public static void GetAllPets(List<Pet> pets)
        {
            if (pets.Count == 0) 
            { 
                Console.WriteLine("List is empty"); 
                return;
            }
            foreach (Pet p in pets) 
            {
                if (p != null)
                {
                    p.PetInfo();
                }
            }
        }

        public static void AddPet(List<Pet> pets)
        {
                Console.Write("Set pet type - ");
                string PetType = Console.ReadLine();

                Console.Write("Set pet name - ");
                string Name = Console.ReadLine();

                Console.Write("Set pet age - ");
                int Age; 

                while( !int.TryParse(Console.ReadLine(), out Age))
                {
                    Console.WriteLine("Error: Incorrect age format. Enter a number:");
                };

                pets.Add(new Pet(PetType,Name,Age));

                Console.WriteLine("Pet successfully added");
            
        }
        public static void EditPetInfo(List<Pet> pets)
        {
            Console.Write("Enter the number of the pet in the list whose information you want to change - ");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Incorrect format. Enter a number:");
            };

            number--;

            Console.WriteLine($"Pet named {pets[number].Name}, what information do you want to change?");
            Console.WriteLine("1. PetType\n2. Name\n3. Age\n4. PhisicalDescription\n5. PersonalityDescription\n6. Back");            

            bool exit = false;
            while (exit == false) 
            {
                Console.Write("Enter the task number - ");

                int changeNumber;

                while (!int.TryParse(Console.ReadLine(), out changeNumber))
                {
                    Console.WriteLine("Error: Incorrect age format. Enter a number:");
                };

                switch (changeNumber) 
                {
                    case 1:
                        Console.WriteLine("Enter the changed type of pet");
                        pets[number].PetType = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter a new pet name");
                        pets[number].Name = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter the number of years of the pet");

                        int age;

                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Error: Incorrect age format. Enter a number:");
                        };

                        pets[number].Age = age;
                        break;
                    case 4:
                        Console.WriteLine("Enter the physical characteristics of the pet");
                        pets[number].PhysicalDescription = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter the personal characteristics of the pet");
                        pets[number].PersonalityDescription = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        exit = true;
                        break;
                }
            }
        }
        public static List<Pet> DeletePet(List<Pet> pets)
        {
            Console.Write("Enter the number of the pet you want to delete  - ");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Incorrect format. Enter a number:");
            };

            number--; //Indexes start with 0

            if (number < 0 || number >= pets.Count)
            {
                Console.WriteLine("Error: this number is out of range.");
            }
            else
            {
                pets.RemoveAt(number);
                Console.WriteLine("Pet successfully removed.");
            }

            return pets;
        }
    }
}
