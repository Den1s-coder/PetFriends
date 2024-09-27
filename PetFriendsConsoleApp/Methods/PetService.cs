using PetFriendsConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFriendsConsoleApp.Methods
{
    internal class PetService
    {
        public static void GetAllPets(Pet[] pets)
        {
            foreach (Pet p in pets) 
            {
                if (p != null)
                {
                    p.PetInfo();
                }
            }
        }

        public static void AddPet(Pet[] pets)
        {
            for (int i = 0; i < pets.Length; i++)
            {
                while (pets[i] != null) i++;
                if (i > pets.Length) {
                    Console.WriteLine("Массив заполнен, очистите место чтобы добавить питомца");
                    break; 
                }

                Console.WriteLine();
                string PetType = Console.ReadLine();

                Console.WriteLine();
                string Name = Console.ReadLine();

                Console.WriteLine();
                int Age; 

                while( !int.TryParse(Console.ReadLine(), out Age))
                {
                    Console.WriteLine("Неверный формат возраста. Введите число:");
                };

                pets[i] = new Pet(PetType,Name,Age);

                Console.WriteLine("Объект успешно добавлен:");
                break;
            }
        }
        public static void EditPetInfo(Pet[] pets)
        {
            Console.Write("Введите номер питомца в списке, информацию которого хотите изменить: ");

            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Неверный формат возраста. Введите число:");
            };

            number--;

            Console.WriteLine($"Питомец по имени {pets[number].Name} ,какую информацию вы хотите изменить?");
            Console.WriteLine("1. PetType\n2. Name\n3. Age\n4. PhisicalDescription\n5. PersonalityDescription\n6. Назад");            

            bool exit = false;
            while (exit == false) 
            {
                Console.Write("Введите номер задачи:");

                int changeNumber;

                while (!int.TryParse(Console.ReadLine(), out changeNumber))
                {
                    Console.WriteLine("Неверный формат возраста. Введите число:");
                };

                switch (changeNumber) 
                {
                    case 1:
                        Console.WriteLine("Введите измененый тип питомца");
                        pets[number].PetType = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите новое имя питомца");
                        pets[number].Name = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите количество лет питомца");

                        int age;

                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Неверный формат возраста. Введите число:");
                        };

                        pets[number].Age = age;
                        break;
                    case 4:
                        Console.WriteLine("Введите физические особености питомца");
                        pets[number].PhysicalDescription = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Введите персональные особености питомца");
                        pets[number].PersonalityDescription = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        exit = true;
                        break;
                }
            }
        }
    }
}
