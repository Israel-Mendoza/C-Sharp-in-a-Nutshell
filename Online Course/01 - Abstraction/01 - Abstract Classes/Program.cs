void DoAnimalStuff(Animal anAnimal)
{
    anAnimal.MakeNoise();
    anAnimal.Move("slow");
    Console.WriteLine();
}

var someAnimals = new List<Animal>();
someAnimals.Add(new Dog("Wolf", "very big", 100));
someAnimals.Add(new Dog("Chihuahua", "very small", 10));
someAnimals.Add(new Fish("Shark", "big", 100));
someAnimals.Add(new Fish("Goldfish", "small", 0.1));
someAnimals.Add(new Horse("Clydesdale", "big", 800));

foreach (Animal animal in someAnimals)
{
    DoAnimalStuff(animal);
    // If the animal is an instance of Mammal, then call a method specific to that mammal
    if (animal is Mammal mammal)
        mammal.ShedHair();
}
// Aooooooooooo
// The Dog ('Wolf') is walking...

// Woof!
// The Dog ('Chihuahua') is walking...

// Splash!
// The Fish ('Shark') is swimming lazily...

// Gloo gloo...
// The Fish ('Goldfish') is swimming lazily...

// The Horse ('Clydesdale') ('Clydesdale') says 'Neeeeigh'
// The Horse ('Clydesdale') is jogging

// The Horse ('Clydesdale') does not lose hairs...
