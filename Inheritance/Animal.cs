using System;
using System.Collections.Generic;

namespace Inheritance;

public class Animal
{
    public  List<Animal> ZooStock { get; set; } = new List<Animal>();
    public string Name { get; set; }
    public bool IsMobile { get; set; }
    public string SleepCycle { get; set; }

    public static void IsHungry(Animal creature)
    {
        
        if (creature is Bird)
        {
            Console.WriteLine("When a bird is hungry we feed it seeds!");
        }

        if (creature is Reptile)
        {
            Console.WriteLine("When a reptile is hungry we feed them insects");
        }
    }
 
}