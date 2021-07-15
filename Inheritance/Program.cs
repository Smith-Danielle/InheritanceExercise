using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - COMPLETE
            // give this class 4 members that all Animals have in common - COMPLETE


            // Create a class Bird - COMPLETE
            // give this class 4 members that are specific to Bird - COMPLETE
            // Set this class to inherit from your Animal Class - COMPLETE

            // Create a class Reptile - COMPLETE
            // give this class 4 members that are specific to Reptile - COMPLETE
            // Set this class to inherit from your Animal Class - COMPLETE

            

            //Create an object of your Bird class - COMPLETE
            Bird robin = new Bird();
            Bird penguin = new Bird();
            //  give values to your members using the object of your Bird class - COMPLETE
            robin.Color = "blue";
            robin.Weight = 0.17; // in pounds
            robin.Mobility = "flight";
            robin.LifeSpan = 2; // in years
            robin.Sound = "chirp chirp";
            robin.Wingspan = 9; //in inches
            robin.BeakColor = "black";
            robin.LivesInNest = true;
            robin.AbilityToFly = true;

            penguin.Color = "black";
            penguin.Weight = 50; // in pounds
            penguin.Mobility = "walk";
            penguin.LifeSpan = 20; // in years
            penguin.Sound = "honk honk";
            penguin.Wingspan = 30; //in inches
            penguin.BeakColor = "black";
            penguin.LivesInNest = false;
            penguin.AbilityToFly = false;

            // Creatively display the class member values


            //Create an object of your Reptile class - COMPLETE
            Reptile chameleon = new Reptile();
            Reptile alligator = new Reptile();
            //  give values to your members using the object of your Bird class - COMPLETE
            chameleon.Color = "pink";
            chameleon.Weight = .19; // in pounds
            chameleon.Mobility = "walk";
            chameleon.LifeSpan = 6; // in years
            chameleon.Sound = "hisssssss";
            chameleon.LivesInWater = false;
            chameleon.ShedPerYear = 12;
            chameleon.ScalePattern = "circular";
            chameleon.NumberOfTeeth = 15;

            alligator.Color = "brown";
            alligator.Weight = 500; // in pounds
            alligator.Mobility = "crawl/swim";
            alligator.LifeSpan = 30; // in years
            alligator.Sound = "grrrissss";
            alligator.LivesInWater = true;
            alligator.ShedPerYear = 12;
            alligator.ScalePattern = "rectangular";
            alligator.NumberOfTeeth = 80;

            // Creatively display the class member values


            //List of all Animals
            Console.WriteLine("Welcome to our mini zoo.");
            Console.WriteLine("We have a couple of selections to choose from.");

            string nextStep;
            do
            {
                Console.WriteLine("If you would like to see our birds, please type in birds.");
                Console.WriteLine("Or if you would like to see our reptiles, please type in reptiles.");

                string animalType = Console.ReadLine();
                Console.Clear();
                if (animalType == "birds")
                {
                    Console.WriteLine("Great! We have robins and penguins.");
                    Console.WriteLine("Please enter robins or penguins to get more information on the species.");
                    string speciesBirds = Console.ReadLine();
                    Console.Clear();
                    if (speciesBirds == "robins")
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine($"Color: {robin.Color}");
                        Console.WriteLine($"Weight: {robin.Weight}");
                        Console.WriteLine($"Weight (in pounds): {robin.Weight}");
                        Console.WriteLine($"Mobility: {robin.Mobility}");
                        Console.WriteLine($"LifeSpan (in years): {robin.LifeSpan}");
                        Console.WriteLine($"Wingspan (in inches): {robin.Wingspan}");
                        Console.WriteLine($"BeakColor: {robin.BeakColor}");
                        Console.WriteLine($"Lives in Nest: {robin.LivesInNest}");
                        Console.WriteLine($"Ability to Fly: {robin.AbilityToFly}");
                        robin.MakesNoise();
                        Console.WriteLine("-------------------------------------------");
                    }
                    else if (speciesBirds == "penguins")
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine($"Color: {penguin.Color}");
                        Console.WriteLine($"Weight: {penguin.Weight}");
                        Console.WriteLine($"Weight (in pounds): {penguin.Weight}");
                        Console.WriteLine($"Mobility: {penguin.Mobility}");
                        Console.WriteLine($"LifeSpan (in years): {penguin.LifeSpan}");
                        Console.WriteLine($"Wingspan (in inches): {penguin.Wingspan}");
                        Console.WriteLine($"BeakColor: {penguin.BeakColor}");
                        Console.WriteLine($"Lives in Nest: {penguin.LivesInNest}");
                        Console.WriteLine($"Ability to Fly: {penguin.AbilityToFly}");
                        penguin.MakesNoise();
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                else if (animalType == "reptiles")
                {
                    Console.WriteLine("Great! We have chameleons and alligators.");
                    Console.WriteLine("Please enter chameleons or alligators to get more information on the species.");
                    string speciesReptiles = Console.ReadLine();
                    Console.Clear();
                    if (speciesReptiles == "chameleons")
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine($"Color: {chameleon.Color}");
                        Console.WriteLine($"Weight: {chameleon.Weight}");
                        Console.WriteLine($"Weight (in pounds): {chameleon.Weight}");
                        Console.WriteLine($"Mobility: {chameleon.Mobility}");
                        Console.WriteLine($"LifeSpan (in years): {chameleon.LifeSpan}");
                        Console.WriteLine($"Lives in Water: {chameleon.LivesInWater}");
                        Console.WriteLine($"Sheds Per Year: {chameleon.ShedPerYear}");
                        Console.WriteLine($"Sacle Pattern: {chameleon.ScalePattern}");
                        Console.WriteLine($"Number of Teeth: {chameleon.NumberOfTeeth}");
                        chameleon.MakesNoise();
                        Console.WriteLine("-------------------------------------------");
                    }
                    else if (speciesReptiles == "alligators")
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine($"Color: {alligator.Color}");
                        Console.WriteLine($"Weight: {alligator.Weight}");
                        Console.WriteLine($"Weight (in pounds): {alligator.Weight}");
                        Console.WriteLine($"Mobility: {alligator.Mobility}");
                        Console.WriteLine($"LifeSpan (in years): {alligator.LifeSpan}");
                        Console.WriteLine($"Lives in Water: {alligator.LivesInWater}");
                        Console.WriteLine($"Sheds Per Year: {alligator.ShedPerYear}");
                        Console.WriteLine($"Sacle Pattern: {alligator.ScalePattern}");
                        Console.WriteLine($"Number of Teeth: {alligator.NumberOfTeeth}");
                        chameleon.MakesNoise();
                        Console.WriteLine("-------------------------------------------");
                    }
                    
                }

                Console.WriteLine("Thanks for visiting the zoo.");
                Console.WriteLine("If you would like to see other animals in our zoo, please type more.");
                Console.WriteLine("Or type exit to close.");
                nextStep = Console.ReadLine();
                Console.Clear();

            } while (nextStep == "more");
            if (nextStep == "exit")
            {
                Console.WriteLine("See you next time!!");
            }
        }
    }
}
