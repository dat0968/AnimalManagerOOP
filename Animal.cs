using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Animal
    {
        public string NameAnimal { get; set; }
        public int YearOldAnimal { get; set; }
    public virtual void MakeSound()
    {
        Console.WriteLine("I'm an animal");
    }
    public Animal(string nameAnimal, int yearOldAnimal) //This is a constructor function with parameters
    {
            NameAnimal = nameAnimal;
            YearOldAnimal = yearOldAnimal;
        }
    }

