using PetFriendsConsoleApp.Entity;
using PetFriendsConsoleApp.Methods;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>();
        pets.Add(new Pet("Cat", "Jogh", 4));

        while (true){
            int number;
            Console.WriteLine("1. List all of our current pet information.\n2. Add a new animal friend to the list. \n3. Change pet information.\n4. Delete pet from list.\n5. Exit");
            Console.Write("Choose a task number - ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Incorrect format. Enter a number:");
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
                case 4:
                    PetService.DeletePet(pets);
                    break;
                case 5:
                    return;
            }
        }
    }
}