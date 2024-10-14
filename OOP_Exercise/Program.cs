using OOP_Exercise;

var pets = new List<Pet>
            {
                new Dog("Buddy", 3, "Dog", "Golden Retriever"),
                new Cat("Whiskers", 2, "Cat", "Tabby"),
                new Dog("Max", 5, "Dog", "Beagle"),
                new Cat("Luna", 4, "Cat", "Siamese")
            };
var generalVet = new GeneralVeterinarian("Dr. Smith");
var specialistVet = new SpecialistVeterinarian("Dr. Jones", "Dermatology");

foreach (var pet in pets)
{
    Console.WriteLine($"Examining pet: {pet.Name},  of age {pet.Age}.");
    Console.WriteLine(generalVet.ExaminePet(pet));
    Console.WriteLine(specialistVet.ExaminePet(pet));
    Console.WriteLine();
}
