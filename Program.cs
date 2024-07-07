using System;
using Animals.Models;
using Animals.Services;

class Program
{
    static void Main(string[] args)
    {
        AnimalService animalService = new AnimalService();

        Dog dog = new Dog();
        dog.Name = "Sharik";
        dog.Age = 1;

        Cat cat = new Cat();
        cat.Name = "Belka";
        cat.Age = 2;

        animalService.FeedAnimal(dog);
        animalService.SpeakAnimal(dog);
        animalService.SleepAnimal(dog);

        animalService.FeedAnimal(cat);
        animalService.SpeakAnimal(cat);
        animalService.SleepAnimal(cat);

       
    }








}
