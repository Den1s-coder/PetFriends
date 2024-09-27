using PetFriendsConsoleApp.Entity;
using PetFriendsConsoleApp.Methods;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet[] pets = new Pet[8];
        pets[0] = new Pet("Cat", "Jogh", 4);

        while (true){
            int number;

            Console.Write("Выберете задачу: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Неверный формат возраста. Введите число:");
            };

            switch (number)
            {
                case 1:
                    PetService.GetAllPets(pets);
                    break;
                case 2:
                    PetService.AddPet(pets);
                    break;
                case 3:
                    PetService.EditPetInfo(pets);
                    break;
            }
        }
    }
}