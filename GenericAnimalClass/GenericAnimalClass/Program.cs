using System;
using static System.Console;

namespace GenericAnimalClass 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Animal<string> animalName = new Animal<string>("Fruit Bat");
            Animal<string> animalHabitat = new Animal<string>("Tropical Forest");
            Animal<bool> endangered = new Animal<bool>(true);
            Animal<bool> extinct= new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(30);
            WriteLine($"The {animalName.getAnimal()} lives in {animalHabitat.getAnimal()} habitats.");
            WriteLine($"{animalName.getAnimal()}s on average live {averageLifespan.getAnimal()} years.");
            WriteLine($"Endangered Status: {endangered.getAnimal()} Extinction Status: {extinct.getAnimal()}");
        }
    }
    class Animal<T>
    {
        public T AnimalData { get; set; }
        public Animal(T data) 
        { 
            AnimalData= data;
        }
        public T getAnimal()
        { return AnimalData; }
    }
}