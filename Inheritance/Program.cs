using System;
using System.ComponentModel.DataAnnotations;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var zooAnimals = new Animal();
            var cockatoo = new Bird()
            {
                Name = "cockatoo",
                IsMobile = true,
                SleepCycle = "diurnal",
                CanFly = true,
                FeatherColor = "white",
                MatingCry = "scream"
            };
            zooAnimals.ZooStock.Add(cockatoo);
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
            zooAnimals.ZooStock.Add(chameleon);
            foreach (var creature in zooAnimals.ZooStock)
            {
                if (creature is Reptile)
                {
                    Console.WriteLine($"This is a {chameleon.Name}. It is {chameleon.CanCamoflauge} that they can camouflage.\n");
                    Console.WriteLine($"It's {chameleon.DoesSlither} that {chameleon.Name} does sliver. This one is about {chameleon.SizeInches} long!");
                    Reptile.IsHungry(creature);
                }

                if (creature is Bird)
                {
                    Console.WriteLine($"This is a {cockatoo.Name} it has {cockatoo.FeatherColor} feathers and makes the sound {cockatoo.MatingCry}, and as you might've guess it is {cockatoo.CanFly} that it can fly.");
                    Bird.MigrationSeason();
                    Bird.IsHungry(creature);
                }
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
