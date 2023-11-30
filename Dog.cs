using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string nameAnimal, int yearOldAnimal, string breed) : base(nameAnimal, yearOldAnimal) //This is a constructor function with parameters
    {
        Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("I'm a dog");
        }
    }

