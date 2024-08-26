using System;
using System.ComponentModel.DataAnnotations;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var zooBirds = new Bird();
            var zooReptiles = new Reptile();
            var cockatoo = new Bird()
            {
                Name = "cockatoo",
                IsMobile = true,
                SleepCycle = "diurnal",
                CanFly = true,
                FeatherColor = "white",
                MatingCry = "scream"
            };
            zooBirds.BirdsList.Add(cockatoo);
            var chameleon = new Reptile()
            {
                Name = "chameleon",
                IsMobile = true,
                SleepCycle = "diurnal",
                IsScaly = true,
                CanCamoflauge = true,
                DoesSlither = false,
                SizeInches = 12
            };
            zooReptiles.ReptileList.Add(chameleon);
            foreach (var creature in zooReptiles.ReptileList)
            {
                string timeSleep = null;

                    Console.WriteLine($"This is a {creature.Name}. It is {creature.CanCamoflauge} that they can camouflage.\n");
                    Console.WriteLine($"It's {creature.DoesSlither} that {creature.Name} does sliver. This one is about {creature.SizeInches} long!");
                    if (creature.SleepCycle == "diurnal")
                    {
                        timeSleep = "night";
                    }
                    else
                    {
                        timeSleep = "day";
                    }
                    Console.WriteLine($"The {creature.Name} is {creature.SleepCycle} which means that it sleeps at {timeSleep}");
                    Reptile.IsHungry(creature);
            }

            foreach (var creature in zooBirds.BirdsList)
            {
                string timeSleep = null;
                Console.WriteLine($"This is a {creature.Name} it has {creature.FeatherColor} feathers and makes the sound {creature.MatingCry}, and as you might've guess it is {creature.CanFly} that it can fly.");
                if (creature.SleepCycle == "diurnal")
                {
                    timeSleep = "night";
                }
                else
                {
                    timeSleep = "day";
                }
                Console.WriteLine($"The {creature.Name} is {creature.SleepCycle} which means that it sleeps at {timeSleep}");
                Bird.MigrationSeason();
                Bird.IsHungry(creature);
            }
           
            
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
        }
        
    }
}
