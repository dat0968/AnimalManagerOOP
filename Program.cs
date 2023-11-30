using System;
using System.IO.Pipes;

class program
{
    static string ans;
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter number of animals: ");
            int numberofanimals = int.Parse(Console.ReadLine());
            Animal[] animals = new Animal[numberofanimals];
            for (int i = 0; i < numberofanimals; i++)
            {
                Console.WriteLine("No.{0}", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Is it a dog ? yes/no ?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.Write("Breed: ");
                    string breed = Console.ReadLine();
                    Console.WriteLine("the breed: {0}", breed);
                    animals[i] = new Dog(name, age, breed);


                }
                else if (answer == "no")
                {
                    Console.WriteLine("this isn't a dog");
                    animals[i] = new Animal(name, age);

                }
                else
                {
                    Console.WriteLine("Error. Only enter yes or no Please!!!");
                }
            }
            foreach (var animal in animals)
            {
                Console.Write($"{animal.NameAnimal} ({animal.YearOldAnimal} years old) says: ");
                animal.MakeSound();
            }
            Console.WriteLine("Do you want to continue ?, yes/no?");
            ans = Console.ReadLine();
            if (ans != "yes" && ans != "no")
            {
                Console.WriteLine("Error.Only enter yes or no!!!");
            }
        } while (ans == "yes");
}
}