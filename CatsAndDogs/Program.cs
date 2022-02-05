using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or a dog?");
            string userChoice = Console.ReadLine();

            if (userChoice == "Cat")
            {
                Console.WriteLine("You are home-lover!");
            }
            else if (userChoice == "Dog")
            {
                Console.WriteLine("You are a partygoer!");
            }
            else
            {
                Console.WriteLine($"You are a {userChoice} friend");
            }


            Console.WriteLine("Kena Päeva!");
        
    }
    }
}
