using System;
using System.Collections.Generic;
using DesignPatternsPresentation.Classes;

namespace DesignPatternsPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //INHERITANCE
            Console.WriteLine("===== INHERITANCE =====");
            Animal2 dog1 = new Dog();
            Dog dog2 = new Dog();
            dog2.Move();
            dog1.Move();
            dog2.Speak();
            //dog1.Speak(); //<== Inheritance falls apart.

            //COMPOSITION & STRATEGY PATTERN
            Console.WriteLine("\n\n===== COMPOSITION & STRATEGY =====");
            Animal dog = new Animal(new Bark(), new MoveLikeADog());
            Animal wolf = new Animal(new Howl(), new MoveLikeADog());
            //pass in the implementation you need.
            dog.Move();
            wolf.Move();
            dog.Speak();
            wolf.Speak();

            //NULL OBJECT PATTERN
            Console.WriteLine("\n\n===== NULL OBJECT PATTERN =====");
            dog.Speak();
            dog.SetSpeech(new Silence());
            dog.Speak();

            //ADAPTER PATTERN
            Console.WriteLine("\n\n===== ADAPTING A CAR =====");
            Car car = new Car();
            CarAdapter adaptedCar = new CarAdapter(car, speed: 25);
            Animal carAnimal = new Animal(adaptedCar, adaptedCar);
            carAnimal.Move();
            carAnimal.Speak();

            //DECORATOR PATTERN
            Console.WriteLine("\n\n===== DECORATING FOR SPEED =====");
            wolf.Move();
            IMove fastMovement = new FastMovement(new MoveLikeADog(), 3);
            wolf.SetMovement(fastMovement);
            wolf.Move();

            //POWERFUL ITERATION
            Console.WriteLine("\n\n===== THE POWER OF ABSTRACTION =====");
            List<Animal> animals = new List<Animal>(2);
            animals.Add(new Animal(new Bark(), new MoveLikeADog()));
            animals.Add(new Animal(new Howl(), new MoveLikeADog()));
            animals.Add(new Animal(new Silence(), new MoveLikeADog()));

            foreach(Animal animal in animals)
            {
                animal.Speak();
            }
        }
    }
}
