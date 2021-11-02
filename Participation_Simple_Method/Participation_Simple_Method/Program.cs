using System;

namespace Participation_Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any type of animal.");
            string animal = Console.ReadLine();

            string noise = Speak(animal);
            Console.WriteLine($"A {animal} makes the sound of {noise}!");
            
        }
        static string Speak(string animal)
        {
            string animalSound = "";
            if (animal == "cow")
	        {
                animalSound = "moo";
	        }
            else if (animal == "dog")
	        {
                animalSound = "ruff";
	        }
            else if (animal == "pig")
            {
                animalSound = "oink";
            }
            else
            {
                animalSound = "AAAAAAHHHHH";
            }
            
            return animalSound;
        }
        
    }
}
